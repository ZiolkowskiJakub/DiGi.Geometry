using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Comparer for sorting points along a segment based on their projection parameter.
        /// </summary>
        private struct PointAlongSegmentComparer : IComparer<Point2D>
        {
            private readonly Point2D start;
            private readonly Vector2D vector;

            public PointAlongSegmentComparer(Point2D start, Vector2D vector)
            {
                this.start = start;
                this.vector = vector;
            }

            public int Compare(Point2D? point2D_1, Point2D? point2D_2)
            {
                if (point2D_1 == null && point2D_2 == null)
                {
                    return 0;
                }
                if (point2D_1 == null)
                {
                    return -1;
                }
                if (point2D_2 == null)
                {
                    return 1;
                }

                double t1 = (point2D_1.X - start.X) * vector.X + (point2D_1.Y - start.Y) * vector.Y;
                double t2 = (point2D_2.X - start.X) * vector.X + (point2D_2.Y - start.Y) * vector.Y;
                return t1.CompareTo(t2);
            }
        }

        /// <summary>
        /// Splits a collection of segments into smaller segments based on their intersections.
        /// </summary>
        /// <param name="segment2Ds">The collection of segments to split.</param>
        /// <param name="tolerance">The distance tolerance for intersection detection.</param>
        /// <returns>A list of the resulting split segments.</returns>
        public static List<Segment2D>? Split(this IEnumerable<Segment2D>? segment2Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segment2Ds == null)
            {
                return null;
            }

            int capacity = segment2Ds is IReadOnlyCollection<Segment2D> roc ? roc.Count : (segment2Ds is ICollection<Segment2D> col ? col.Count : 16);
            List<(BoundingBox2D BoundingBox, Segment2D Segment, int Index)> segmentInfos = new(capacity);
            List<Segment2D> originalSegments = new(capacity);
            List<Point2D> point2Ds = new(capacity * 2);

            // Local spatial hash grid for O(1) point deduplication
            Dictionary<(long X, long Y), List<Point2D>> points_ByCell = [];

            (long X, long Y) GetPointCell(Point2D point)
            {
                return ((long)System.Math.Round(point.X / tolerance), (long)System.Math.Round(point.Y / tolerance));
            }

            Point2D AddUniquePoint(Point2D point)
            {
                (long X, long Y) cell = GetPointCell(point);
                for (long x = cell.X - 1; x <= cell.X + 1; x++)
                {
                    for (long y = cell.Y - 1; y <= cell.Y + 1; y++)
                    {
                        if (points_ByCell.TryGetValue((x, y), out List<Point2D>? cellPoints))
                        {
                            for (int k = 0; k < cellPoints.Count; k++)
                            {
                                Point2D existing = cellPoints[k];
                                double dx = existing.X - point.X;
                                double dy = existing.Y - point.Y;
                                if (dx * dx + dy * dy <= tolerance * tolerance)
                                {
                                    return existing;
                                }
                            }
                        }
                    }
                }

                if (!points_ByCell.TryGetValue(cell, out List<Point2D>? list))
                {
                    list = [];
                    points_ByCell[cell] = list;
                }
                list.Add(point);
                point2Ds.Add(point);
                return point;
            }

            int originalIndex = 0;
            foreach (Segment2D segment2D in segment2Ds)
            {
                if (segment2D == null)
                {
                    continue;
                }

                BoundingBox2D? boundingBox2D = segment2D.GetBoundingBox();
                if (boundingBox2D is null)
                {
                    continue;
                }

                if (segment2D.Length < tolerance)
                {
                    continue;
                }

                segmentInfos.Add((boundingBox2D, segment2D, originalIndex));
                originalSegments.Add(segment2D);
                AddUniquePoint(segment2D[0]!);
                AddUniquePoint(segment2D[1]!);
                originalIndex++;
            }

            int count = segmentInfos.Count;

            List<List<Point2D>?> point2Ds_BySegment = new(count);
            for (int i = 0; i < count; i++)
            {
                point2Ds_BySegment.Add(null);
            }

            void AddPointToSegment(int segmentIndex, Point2D point)
            {
                List<Point2D>? segmentPoints = point2Ds_BySegment[segmentIndex];
                if (segmentPoints == null)
                {
                    segmentPoints = [];
                    point2Ds_BySegment[segmentIndex] = segmentPoints;
                }

                for (int k = 0; k < segmentPoints.Count; k++)
                {
                    Point2D existing = segmentPoints[k];
                    double dx = existing.X - point.X;
                    double dy = existing.Y - point.Y;
                    if (dx * dx + dy * dy <= tolerance * tolerance)
                    {
                        return;
                    }
                }

                segmentPoints.Add(point);
            }

            // Sweep and Prune: sort segmentInfos by Min.X coordinate
            segmentInfos.Sort((x, y) => x.BoundingBox.Min.X.CompareTo(y.BoundingBox.Min.X));

            List<Point2D> point2Ds_Intersection = [];

            for (int i = 0; i < count - 1; i++)
            {
                BoundingBox2D boundingBox2D_1 = segmentInfos[i].BoundingBox;
                Segment2D segment2D_1 = segmentInfos[i].Segment;
                int idx_1 = segmentInfos[i].Index;
                double maxLimitX = boundingBox2D_1.Max.X + tolerance;

                for (int j = i + 1; j < count; j++)
                {
                    BoundingBox2D boundingBox2D_2 = segmentInfos[j].BoundingBox;
                    if (boundingBox2D_2.Min.X > maxLimitX)
                    {
                        break;
                    }

                    // Check Y overlap
                    if (boundingBox2D_1.Min.Y > boundingBox2D_2.Max.Y + tolerance ||
                        boundingBox2D_2.Min.Y > boundingBox2D_1.Max.Y + tolerance)
                    {
                        continue;
                    }

                    Segment2D segment2D_2 = segmentInfos[j].Segment;
                    if (segment2D_1.Similar(segment2D_2, tolerance))
                    {
                        continue;
                    }

                    point2Ds_Intersection.Clear();

                    if (segment2D_1.On(segment2D_2[0], tolerance))
                    {
                        point2Ds_Intersection.Add(segment2D_2[0]!);
                    }

                    if (segment2D_2.On(segment2D_1[0], tolerance))
                    {
                        point2Ds_Intersection.Add(segment2D_1[0]!);
                    }

                    if (segment2D_1.On(segment2D_2[1], tolerance))
                    {
                        point2Ds_Intersection.Add(segment2D_2[1]!);
                    }

                    if (segment2D_2.On(segment2D_1[1], tolerance))
                    {
                        point2Ds_Intersection.Add(segment2D_1[1]!);
                    }

                    if (point2Ds_Intersection.Count == 0)
                    {
                        Point2D? point2D_Intersection = IntersectionPoint(segment2D_1, segment2D_2, out Point2D? point2D_Closest1, out Point2D? point2D_Closest2, tolerance);
                        if (point2D_Intersection != null)
                        {
                            if (point2D_Closest1 != null && point2D_Closest2 != null)
                            {
                                if (point2D_Closest1.Distance(point2D_Closest2) <= tolerance)
                                {
                                    point2Ds_Intersection.Add(point2D_Intersection);
                                }
                            }
                            else
                            {
                                point2Ds_Intersection.Add(point2D_Intersection);
                            }
                        }
                    }

                    if (point2Ds_Intersection.Count == 0)
                    {
                        continue;
                    }

                    for (int k = 0; k < point2Ds_Intersection.Count; k++)
                    {
                        Point2D point2D_Intersection_Temp = AddUniquePoint(point2Ds_Intersection[k]);

                        if (point2D_Intersection_Temp.Distance(segment2D_1.Start) > tolerance && point2D_Intersection_Temp.Distance(segment2D_1.End) > tolerance)
                        {
                            AddPointToSegment(idx_1, point2D_Intersection_Temp);
                        }

                        if (point2D_Intersection_Temp.Distance(segment2D_2.Start) > tolerance && point2D_Intersection_Temp.Distance(segment2D_2.End) > tolerance)
                        {
                            int idx_2 = segmentInfos[j].Index;
                            AddPointToSegment(idx_2, point2D_Intersection_Temp);
                        }
                    }
                }
            }

            List<Segment2D> segment2Ds_Result = [];

            // Spatial hash grid for duplicate checks in result list
            Dictionary<(long X, long Y), List<int>> indexes_ByCell = [];

            (long X, long Y) GetCell(Point2D? point2D_Cell)
            {
                return ((long)System.Math.Round(point2D_Cell!.X / tolerance), (long)System.Math.Round(point2D_Cell.Y / tolerance));
            }

            void RegisterSegment(int index_Segment, Segment2D segment2D_New)
            {
                (long X, long Y) cell_1 = GetCell(segment2D_New[0]);
                (long X, long Y) cell_2 = GetCell(segment2D_New[1]);

                if (!indexes_ByCell.TryGetValue(cell_1, out List<int>? indexes_Cell1))
                {
                    indexes_Cell1 = [];
                    indexes_ByCell[cell_1] = indexes_Cell1;
                }
                indexes_Cell1.Add(index_Segment);

                if (cell_2 != cell_1)
                {
                    if (!indexes_ByCell.TryGetValue(cell_2, out List<int>? indexes_Cell2))
                    {
                        indexes_Cell2 = [];
                        indexes_ByCell[cell_2] = indexes_Cell2;
                    }
                    indexes_Cell2.Add(index_Segment);
                }
            }

            bool ContainsSimilarSegment(Segment2D segment2D_Candidate)
            {
                (long X, long Y) cell = GetCell(segment2D_Candidate[0]);

                for (long x = cell.X - 1; x <= cell.X + 1; x++)
                {
                    for (long y = cell.Y - 1; y <= cell.Y + 1; y++)
                    {
                        if (indexes_ByCell.TryGetValue((x, y), out List<int>? indexes_Cell))
                        {
                            for (int k = 0; k < indexes_Cell.Count; k++)
                            {
                                int index_Cell = indexes_Cell[k];
                                if (segment2Ds_Result[index_Cell].Similar(segment2D_Candidate, tolerance))
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }

                return false;
            }

            for (int i = 0; i < count; i++)
            {
                Segment2D segment2D_Temp = originalSegments[i];
                if (ContainsSimilarSegment(segment2D_Temp))
                {
                    continue;
                }

                List<Point2D>? point2Ds_Temp = point2Ds_BySegment[i];
                if (point2Ds_Temp == null || point2Ds_Temp.Count == 0)
                {
                    RegisterSegment(segment2Ds_Result.Count, segment2D_Temp);
                    segment2Ds_Result.Add(segment2D_Temp);
                    continue;
                }

                AddPointToSegment(i, segment2D_Temp[0]!);
                AddPointToSegment(i, segment2D_Temp[1]!);

                Point2D point2D_Start = segment2D_Temp.Start!;
                Vector2D vector2D_Dir = segment2D_Temp.Vector!;

                point2Ds_Temp.Sort(new PointAlongSegmentComparer(point2D_Start, vector2D_Dir));

                for (int j = 0; j < point2Ds_Temp.Count - 1; j++)
                {
                    Point2D point2D_1 = point2Ds_Temp[j];
                    Point2D point2D_2 = point2Ds_Temp[j + 1];

                    Segment2D segment2D_Candidate = new(point2D_1, point2D_2);
                    if (ContainsSimilarSegment(segment2D_Candidate))
                    {
                        continue;
                    }

                    RegisterSegment(segment2Ds_Result.Count, segment2D_Candidate);
                    segment2Ds_Result.Add(segment2D_Candidate);
                }
            }

            return segment2Ds_Result;
        }

        /// <summary>
        /// Splits a segmentable geometry into smaller segments based on their intersections.
        /// </summary>
        /// <param name="segmentable2D">The segmentable geometry to split.</param>
        /// <param name="tolerance">The distance tolerance for intersection detection.</param>
        /// <returns>A list of the resulting split segments.</returns>
        public static List<Segment2D>? Split(this ISegmentable2D? segmentable2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            List<Segment2D>? segment2Ds = segmentable2D?.GetSegments();
            if (segment2Ds == null)
            {
                return null;
            }

            return Split(segment2Ds, tolerance);
        }

        /// <summary>
        /// Splits a collection of segmentable geometries into smaller segments based on their intersections.
        /// </summary>
        /// <typeparam name="T">A type that implements the <see cref="ISegmentable2D"/> interface.</typeparam>
        /// <param name="segmentable2Ds">The collection of segmentable geometries to split.</param>
        /// <param name="tolerance">The distance tolerance for intersection detection.</param>
        /// <returns>A list of the resulting split segments, or null if the input is null.</returns>
        public static List<Segment2D>? Split<T>(this IEnumerable<T>? segmentable2Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance) where T : ISegmentable2D
        {
            List<Segment2D>? segment2Ds = segmentable2Ds?.Segments();
            if (segment2Ds == null)
            {
                return null;
            }

            return Split(segment2Ds, tolerance);
        }

        /// <summary>
        /// Splits a polygonal face into multiple faces using a collection of segmentable geometries as cutting lines.
        /// </summary>
        /// <typeparam name="T">A type that implements the <see cref="ISegmentable2D"/> interface.</typeparam>
        /// <param name="polygonalFace2D">The polygonal face to split.</param>
        /// <param name="segmentable2Ds">The collection of segmentable geometries used for splitting.</param>
        /// <param name="tolerance">The distance tolerance for intersection detection.</param>
        /// <returns>A list of the resulting split polygonal faces, or null if the input is null or no faces could be created.</returns>
        public static List<PolygonalFace2D>? Split<T>(this IPolygonalFace2D? polygonalFace2D, IEnumerable<T>? segmentable2Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance) where T : ISegmentable2D
        {
            if (polygonalFace2D == null || segmentable2Ds == null)
            {
                return null;
            }

            List<IPolygonal2D>? polygonal2Ds = polygonalFace2D.Edges;
            if (polygonal2Ds is null || polygonal2Ds.Count == 0)
            {
                return null;
            }

            BoundingBox2D? boundingBox2D = polygonalFace2D.GetBoundingBox();
            if (boundingBox2D is null)
            {
                return null;
            }

            List<ISegmentable2D> segmentable2Ds_Temp = [];
            foreach (T segmentable2D in segmentable2Ds)
            {
                segmentable2Ds_Temp.Add(segmentable2D);
            }
            segmentable2Ds_Temp.AddRange(polygonal2Ds);

            List<Segment2D>? segment2Ds = segmentable2Ds_Temp.Split(tolerance);

            List<PolygonalFace2D>? result = Create.PolygonalFace2Ds(segment2Ds);
            if (result == null || result.Count == 0)
            {
                return result;
            }

            for (int i = result.Count - 1; i >= 0; i--)
            {
                Point2D? point2D = result[i]?.GetInternalPoint(tolerance);
                if (point2D == null || !boundingBox2D.InRange(point2D, tolerance))
                {
                    result.RemoveAt(i);
                    continue;
                }

                if (!polygonalFace2D.InRange(point2D, tolerance))
                {
                    result.RemoveAt(i);
                    continue;
                }
            }

            return result;
        }
    }
}
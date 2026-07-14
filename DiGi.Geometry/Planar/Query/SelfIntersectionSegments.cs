using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Identifies segments that are part of self-intersections in a collection of segments.
        /// </summary>
        /// <param name="segment2Ds">The collection of segments to analyze.</param>
        /// <param name="maxLength">The maximum length for an intersection segment to be considered.</param>
        /// <param name="tolerance">The distance tolerance for intersection detection.</param>
        /// <returns>A list of segments that are self-intersections.</returns>
        public static List<Segment2D>? SelfIntersectionSegments(this IEnumerable<Segment2D>? segment2Ds, double maxLength, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segment2Ds == null)
                return null;

            // Cache once so a lazy source is not re-enumerated on every outer iteration below.
            Segment2D[] segment2Ds_Cached = segment2Ds as Segment2D[] ?? [.. segment2Ds];

            List<Segment2D> result = [];

            // Spatial hash grid: result segments are bucketed by the tolerance-sized cell of each endpoint, so the "Similar" dedup lookup avoids an O(n) scan over the growing result list.
            Dictionary<(long X, long Y), List<int>> indexes_ByCell = [];

            (long X, long Y) GetCell(Point2D? point2D_Cell)
            {
                return ((long)System.Math.Round(point2D_Cell!.X / tolerance), (long)System.Math.Round(point2D_Cell.Y / tolerance));
            }

            bool TryAddResult(Segment2D segment2D_Candidate)
            {
                (long X, long Y) = GetCell(segment2D_Candidate[0]);

                HashSet<int> indexes_Checked = [];
                for (long x = X - 1; x <= X + 1; x++)
                {
                    for (long y = Y - 1; y <= Y + 1; y++)
                    {
                        if (!indexes_ByCell.TryGetValue((x, y), out List<int>? indexes_Cell))
                        {
                            continue;
                        }

                        foreach (int index_Cell in indexes_Cell)
                        {
                            if (!indexes_Checked.Add(index_Cell))
                            {
                                continue;
                            }

                            if (result[index_Cell].Similar(segment2D_Candidate, tolerance))
                            {
                                return false;
                            }
                        }
                    }
                }

                int index_New = result.Count;
                result.Add(segment2D_Candidate);

                foreach ((long X, long Y) cell_New in new[] { GetCell(segment2D_Candidate[0]), GetCell(segment2D_Candidate[1]) })
                {
                    if (!indexes_ByCell.TryGetValue(cell_New, out List<int>? indexes_Cell_New))
                    {
                        indexes_Cell_New = [];
                        indexes_ByCell[cell_New] = indexes_Cell_New;
                    }

                    indexes_Cell_New.Add(index_New);
                }

                return true;
            }

            IEnumerable<Segment2D> GetOtherSegments(int index_Skip)
            {
                for (int j = 0; j < segment2Ds_Cached.Length; j++)
                {
                    if (j != index_Skip)
                    {
                        yield return segment2Ds_Cached[j];
                    }
                }
            }

            for (int i = 0; i < segment2Ds_Cached.Length; i++)
            {
                Segment2D segment2D = segment2Ds_Cached[i];

                Point2D? point2D = segment2D.Start;
                Vector2D? vector2D = segment2D.Direction;
                vector2D?.Inverse();

                IEnumerable<Segment2D> segment2Ds_Temp = GetOtherSegments(i);

                Vector2D? vector2D_Intersection = Create.SegmentableTraceResult2D(point2D, vector2D, segment2Ds_Temp, tolerance)?.Vector2D;
                if (vector2D_Intersection != null && vector2D_Intersection.Length > 0)
                {
                    Point2D point2D_Temp = new(point2D);
                    point2D_Temp.Move(vector2D_Intersection);

                    Segment2D segment2D_Intersection = new(point2D_Temp, point2D);
                    if (segment2D_Intersection.Length > maxLength)
                    {
                        continue;
                    }

                    List<Point2D>? point2Ds_Intersections = segment2D_Intersection.IntersectionPoints(segment2Ds_Temp, tolerance);
                    if (point2Ds_Intersections != null && point2Ds_Intersections.Count == 2)
                    {
                        TryAddResult(segment2D_Intersection);
                    }
                }

                point2D = segment2D.End;
                vector2D = segment2D.Direction;

                vector2D_Intersection = Create.SegmentableTraceResult2D(point2D, vector2D, segment2Ds_Temp, tolerance)?.Vector2D;
                if (vector2D_Intersection != null && vector2D_Intersection.Length > 0)
                {
                    Point2D point2D_Temp = new(point2D);
                    point2D_Temp.Move(vector2D_Intersection);

                    Segment2D segment2D_Intersection = new(point2D_Temp, point2D);
                    if (segment2D_Intersection.Length > maxLength)
                        continue;

                    List<Point2D>? point2Ds_Intersections = segment2D_Intersection.IntersectionPoints(segment2Ds_Temp, tolerance);
                    if (point2Ds_Intersections != null && point2Ds_Intersections.Count == 2)
                    {
                        TryAddResult(segment2D_Intersection);
                    }
                }
            }

            result.AddRange(segment2Ds_Cached);

            return result;
        }

        /// <summary>
        /// Identifies segments that are part of self-intersections in a segmentable geometry.
        /// </summary>
        /// <param name="segmentable2D">The segmentable geometry to analyze.</param>
        /// <param name="maxLength">The maximum length for an intersection segment to be considered.</param>
        /// <param name="tolerance">The distance tolerance for intersection detection.</param>
        /// <returns>A list of segments that are self-intersections.</returns>
        public static List<Segment2D>? SelfIntersectionSegments(this ISegmentable2D? segmentable2D, double maxLength, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segmentable2D == null)
            {
                return null;
            }

            return SelfIntersectionSegments(segmentable2D.GetSegments(), maxLength, tolerance);
        }
    }
}
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Geometries;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        /// <summary>
        /// Calculates the intersection result of two segments.
        /// </summary>
        /// <param name="segment2D_1">The first segment.</param>
        /// <param name="segment2D_2">The second segment.</param>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>An IntersectionResult2D containing the intersection geometry; otherwise, null if either input is null.</returns>
        public static IntersectionResult2D? IntersectionResult2D(this Segment2D? segment2D_1, Segment2D? segment2D_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segment2D_1 == null || segment2D_2 == null)
            {
                return null;
            }

            BoundingBox2D? boundingBox2D_1 = segment2D_1.GetBoundingBox();
            if (boundingBox2D_1 is null)
            {
                return null;
            }

            BoundingBox2D? boundingBox2D_2 = segment2D_2.GetBoundingBox();
            if (boundingBox2D_2 is null)
            {
                return null;
            }

            if (!boundingBox2D_1.InRange(boundingBox2D_2, tolerance))
            {
                return new IntersectionResult2D();
            }

            IGeometry2D? geometry2D = IntersectionGeometry2D(segment2D_1, segment2D_2, tolerance, out bool handled);
            if (!handled)
            {
                return null;
            }

            if (geometry2D == null)
            {
                return new IntersectionResult2D();
            }

            return new IntersectionResult2D([geometry2D], false);
        }

        /// <summary>
        /// Calculates the intersection result of two lines.
        /// </summary>
        /// <param name="line2D_1">The first line.</param>
        /// <param name="line2D_2">The second line.</param>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>An IntersectionResult2D containing the intersection geometry; otherwise, null if either input is null.</returns>
        public static IntersectionResult2D? IntersectionResult2D(this Line2D? line2D_1, Line2D? line2D_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (line2D_1 is null || line2D_2 is null)
            {
                return null;
            }

            Point2D? point2D = line2D_1.IntersectionPoint(line2D_2);
            if (point2D != null)
            {
                return new IntersectionResult2D(point2D);
            }

            if (line2D_1.On(line2D_2.Origin, tolerance))
            {
                return new IntersectionResult2D(line2D_1);
            }

            return new IntersectionResult2D();
        }

        /// <summary>
        /// Calculates the intersection result of a segment and a collection of segments.
        /// </summary>
        /// <param name="segment2D">The segment to check.</param>
        /// <param name="segment2Ds">The collection of segments to intersect with.</param>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>An IntersectionResult2D containing all unique intersection geometries; otherwise, null if either input is null.</returns>
        public static IntersectionResult2D? IntersectionResult2D(this Segment2D? segment2D, IEnumerable<Segment2D>? segment2Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segment2D == null || segment2Ds == null)
            {
                return null;
            }

            BoundingBox2D? boundingBox2D_1 = segment2D.GetBoundingBox();
            if (boundingBox2D_1 == null)
            {
                return new IntersectionResult2D();
            }

            IntersectionAccumulator accumulator = new(tolerance);
            foreach (Segment2D segment2D_Temp in segment2Ds)
            {
                if (segment2D_Temp == null)
                {
                    continue;
                }

                BoundingBox2D? boundingBox2D_2 = segment2D_Temp.GetBoundingBox();
                if (boundingBox2D_2 == null || !boundingBox2D_1.InRange(boundingBox2D_2, tolerance))
                {
                    continue;
                }

                IGeometry2D? geometry2D = IntersectionGeometry2D(segment2D, segment2D_Temp, tolerance, out _);
                accumulator.Add(geometry2D);
            }

            return accumulator.ToResult();
        }

        /// <summary>
        /// Calculates the intersection result between two collections of segments.
        /// </summary>
        /// <param name="segment2Ds_1">The first collection of segments.</param>
        /// <param name="segment2Ds_2">The second collection of segments.</param>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>An IntersectionResult2D containing all unique intersection geometries; otherwise, null if either input is null.</returns>
        public static IntersectionResult2D? IntersectionResult2D(this IEnumerable<Segment2D>? segment2Ds_1, IEnumerable<Segment2D>? segment2Ds_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segment2Ds_1 == null || segment2Ds_2 == null)
            {
                return null;
            }

            List<Segment2D> segment2Ds_Source1 = [];
            List<BoundingBox2D> boundingBox2Ds_Source1 = [];
            foreach (Segment2D segment2D in segment2Ds_1)
            {
                if (segment2D != null)
                {
                    BoundingBox2D? boundingBox2D = segment2D.GetBoundingBox();
                    if (boundingBox2D != null)
                    {
                        segment2Ds_Source1.Add(segment2D);
                        boundingBox2Ds_Source1.Add(boundingBox2D);
                    }
                }
            }

            List<Segment2D> segment2Ds_Source2 = [];
            List<BoundingBox2D> boundingBox2Ds_Source2 = [];
            foreach (Segment2D segment2D in segment2Ds_2)
            {
                if (segment2D != null)
                {
                    BoundingBox2D? boundingBox2D = segment2D.GetBoundingBox();
                    if (boundingBox2D != null)
                    {
                        segment2Ds_Source2.Add(segment2D);
                        boundingBox2Ds_Source2.Add(boundingBox2D);
                    }
                }
            }

            if (segment2Ds_Source1.Count == 0 || segment2Ds_Source2.Count == 0)
            {
                return new IntersectionResult2D();
            }

            IntersectionAccumulator accumulator = new(tolerance);

            for (int i = 0; i < segment2Ds_Source1.Count; i++)
            {
                Segment2D segment2D_1 = segment2Ds_Source1[i];
                BoundingBox2D boundingBox2D_1 = boundingBox2Ds_Source1[i];

                for (int j = 0; j < segment2Ds_Source2.Count; j++)
                {
                    BoundingBox2D boundingBox2D_2 = boundingBox2Ds_Source2[j];
                    if (!boundingBox2D_1.InRange(boundingBox2D_2, tolerance))
                    {
                        continue;
                    }

                    IGeometry2D? geometry2D = IntersectionGeometry2D(segment2D_1, segment2Ds_Source2[j], tolerance, out _);
                    accumulator.Add(geometry2D);
                }
            }

            return accumulator.ToResult();
        }

        /// <summary>
        /// Calculates the intersection result of two segmentable geometries.
        /// </summary>
        /// <param name="segmentable2D_1">The first segmentable geometry.</param>
        /// <param name="segmentable2D_2">The second segmentable geometry.</param>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>An IntersectionResult2D containing the intersection geometry; otherwise, null if either input is null.</returns>
        public static IntersectionResult2D? IntersectionResult2D(this ISegmentable2D? segmentable2D_1, ISegmentable2D? segmentable2D_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segmentable2D_1 == null || segmentable2D_2 == null)
            {
                return null;
            }

            return IntersectionResult2D(segmentable2D_1.GetSegments(), segmentable2D_2.GetSegments(), tolerance);
        }

        /// <summary>
        /// Calculates the intersection result of a line and a segment.
        /// </summary>
        /// <param name="line2D">The line.</param>
        /// <param name="segment2D">The segment.</param>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>An IntersectionResult2D containing the intersection geometry; otherwise, null if either input is null.</returns>
        public static IntersectionResult2D? IntersectionResult2D(this Line2D? line2D, Segment2D? segment2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (line2D is null || segment2D is null)
            {
                return null;
            }

            IGeometry2D? geometry2D = IntersectionGeometry2D(line2D, segment2D, tolerance);
            if (geometry2D == null)
            {
                return new IntersectionResult2D();
            }

            return new IntersectionResult2D([geometry2D], false);
        }

        /// <summary>
        /// Calculates the intersection result of a line and a collection of segments.
        /// </summary>
        /// <param name="line2D">The line.</param>
        /// <param name="segment2Ds">The collection of segments.</param>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>An IntersectionResult2D containing all unique intersection geometries; otherwise, null if either input is null.</returns>
        public static IntersectionResult2D? IntersectionResult2D(this Line2D? line2D, IEnumerable<Segment2D>? segment2Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (line2D is null || segment2Ds == null)
            {
                return null;
            }

            IntersectionAccumulator accumulator = new(tolerance);
            foreach (Segment2D segment2D_Temp in segment2Ds)
            {
                if (segment2D_Temp == null)
                {
                    continue;
                }

                BoundingBox2D? boundingBox2D = segment2D_Temp.GetBoundingBox();
                if (boundingBox2D == null || !boundingBox2D.InRange(line2D, tolerance))
                {
                    continue;
                }

                IGeometry2D? geometry2D = IntersectionGeometry2D(line2D, segment2D_Temp, tolerance);
                accumulator.Add(geometry2D);
            }

            return accumulator.ToResult();
        }

        /// <summary>
        /// Calculates the intersection result of a segmentable geometry and a line.
        /// </summary>
        /// <param name="segmentable2D">The segmentable geometry.</param>
        /// <param name="line2D">The line.</param>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>An IntersectionResult2D containing the intersection geometry; otherwise, null if either input is null.</returns>
        public static IntersectionResult2D? IntersectionResult2D(this ISegmentable2D? segmentable2D, Line2D? line2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (line2D is null || segmentable2D is null)
            {
                return null;
            }

            return IntersectionResult2D(line2D, segmentable2D.GetSegments(), tolerance);
        }

        /// <summary>
        /// Calculates the intersection result of a segmentable geometry with itself or other segments within it.
        /// </summary>
        /// <param name="segmentable2D">The segmentable geometry.</param>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>An IntersectionResult2D containing the self-intersection geometries; otherwise, null if input is null.</returns>
        public static IntersectionResult2D? IntersectionResult2D(this ISegmentable2D? segmentable2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            return IntersectionResult2D(segmentable2D, int.MaxValue, tolerance);
        }

        /// <summary>
        /// Calculates the intersection result of a segmentable geometry with itself or other segments within it, up to a maximum number of intersections.
        /// </summary>
        /// <param name="segmentable2D">The segmentable geometry.</param>
        /// <param name="maxCount">The maximum number of intersections to find.</param>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>An IntersectionResult2D containing the self-intersection geometries; otherwise, null if input is null.</returns>
        public static IntersectionResult2D? IntersectionResult2D(this ISegmentable2D? segmentable2D, int maxCount, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            List<Segment2D>? segment2Ds = segmentable2D?.GetSegments();
            if (segment2Ds == null || segment2Ds.Count == 0)
            {
                return null;
            }

            int count_Segment2Ds = segment2Ds.Count;

            int count = 0;

            IntersectionAccumulator accumulator = new(tolerance);

            // Precompute bounding boxes to avoid redundant calculations inside nested loops
            List<BoundingBox2D?> boundingBox2Ds = new(count_Segment2Ds);
            for (int i = 0; i < count_Segment2Ds; i++)
            {
                boundingBox2Ds.Add(segment2Ds[i]?.GetBoundingBox());
            }

            for (int i = 0; i < count_Segment2Ds - 1; i++)
            {
                Segment2D segment2D_1 = segment2Ds[i];
                BoundingBox2D? boundingBox2D_1 = boundingBox2Ds[i];

                for (int j = i + 1; j < count_Segment2Ds; j++)
                {
                    Segment2D segment2D_2 = segment2Ds[j];
                    BoundingBox2D? boundingBox2D_2 = boundingBox2Ds[j];

                    if (boundingBox2D_1 == null || boundingBox2D_2 == null || !boundingBox2D_1.InRange(boundingBox2D_2, tolerance))
                    {
                        continue;
                    }

                    IGeometry2D? geometry2D_Raw = IntersectionGeometry2D(segment2D_1, segment2D_2, tolerance, out _);
                    if (geometry2D_Raw != null)
                    {
                        bool adjacent = i + 1 == j;
                        bool last = i == 0 && j == count_Segment2Ds - 1;

                        IGeometry2D? geometry2D;

                        if (!adjacent && !last)
                        {
                            geometry2D = geometry2D_Raw;
                        }
                        else if (geometry2D_Raw is Segment2D)
                        {
                            geometry2D = geometry2D_Raw;
                        }
                        else
                        {
                            geometry2D = null;
                            if (geometry2D_Raw is Point2D point2D)
                            {
                                Point2D? point2D_Endpoint1 = segment2D_1[1];
                                Point2D? point2D_Endpoint0 = segment2D_1[0];

                                if (adjacent && point2D_Endpoint1 != null && !Query.AlmostEquals(point2D_Endpoint1, point2D, tolerance))
                                {
                                    geometry2D = point2D;
                                }
                                else if (last && point2D_Endpoint0 != null && !Query.AlmostEquals(point2D_Endpoint0, point2D, tolerance))
                                {
                                    geometry2D = point2D;
                                }
                            }
                        }

                        if (geometry2D != null && accumulator.Add(geometry2D))
                        {
                            count++;
                        }
                    }

                    if (count >= maxCount)
                    {
                        break;
                    }
                }

                if (count >= maxCount)
                {
                    break;
                }
            }

            return accumulator.ToResult();
        }

        /// <summary>
        /// Calculates the intersection result of a polygonal face and a linear geometry.
        /// </summary>
        /// <param name="polygonalFace2D">The polygonal face.</param>
        /// <param name="linear2D">The linear geometry.</param>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>An IntersectionResult2D containing the intersection geometry; otherwise, null if either input is null.</returns>
        public static IntersectionResult2D? IntersectionResult2D(this IPolygonalFace2D? polygonalFace2D, ILinear2D? linear2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (polygonalFace2D == null || linear2D == null)
            {
                return null;
            }

            List<IPolygonal2D>? edges = polygonalFace2D.Edges;
            if (edges == null)
            {
                return null;
            }

            double tolerance_Squared = tolerance * tolerance;

            List<Point2D> point2Ds = [];
            if (linear2D is ISegmentable2D segmentable2D)
            {
                List<Point2D>? point2Ds_Segmentable2D = segmentable2D.GetPoints();
                if (point2Ds_Segmentable2D != null)
                {
                    for (int i = 0; i < point2Ds_Segmentable2D.Count; i++)
                    {
                        if (polygonalFace2D.Inside(point2Ds_Segmentable2D[i], tolerance))
                        {
                            point2Ds.Add(point2Ds_Segmentable2D[i]);
                        }
                    }
                }
            }

            for (int i = 0; i < edges.Count; i++)
            {
                List<Segment2D>? segment2Ds = edges[i]?.GetSegments();
                if (segment2Ds == null)
                {
                    continue;
                }

                foreach (Segment2D segment2D in segment2Ds)
                {
                    if (segment2D == null)
                    {
                        continue;
                    }

                    Point2D? point2D_Start = segment2D.Start;
                    if (point2D_Start != null && linear2D.On(point2D_Start, tolerance))
                    {
                        AddUniqueByDistance(point2Ds, point2D_Start, tolerance_Squared);
                    }

                    Point2D? point2D_End = segment2D.End;
                    if (point2D_End != null && linear2D.On(point2D_End, tolerance))
                    {
                        AddUniqueByDistance(point2Ds, point2D_End, tolerance_Squared);
                    }

                    Point2D? point2D_Intersection = linear2D.IntersectionPoint(segment2D, tolerance);
                    if (point2D_Intersection != null)
                    {
                        AddUniqueByDistance(point2Ds, point2D_Intersection, tolerance_Squared);
                    }
                }
            }

            if (point2Ds.Count == 0)
            {
                return new IntersectionResult2D();
            }

            if (point2Ds.Count == 1)
            {
                return new IntersectionResult2D(point2Ds[0]);
            }

            Query.ExtremePoints(point2Ds, out Point2D? point2D_1, out Point2D? point2D_2);

            point2Ds.Sort((x, y) => x.Distance(point2D_1).CompareTo(y.Distance(point2D_1)));

            List<IGeometry2D> geometry2Ds = [];

            int count = point2Ds.Count;

            List<bool> bools = [];
            for (int i = 0; i < count - 1; i++)
            {
                bool @bool = polygonalFace2D.InRange(point2Ds[i].Mid(point2Ds[i + 1]), tolerance);
                bools.Add(@bool);

                if (@bool)
                {
                    geometry2Ds.Add(new Segment2D(point2Ds[i], point2Ds[i + 1]));
                }
            }

            if (!bools[0])
            {
                geometry2Ds.Add(point2Ds[0]);
            }

            for (int i = 0; i < bools.Count - 1; i++)
            {
                if (!bools[i] && !bools[i + 1])
                {
                    geometry2Ds.Add(point2Ds[i + 1]);
                }
            }

            if (!bools[count - 2])
            {
                geometry2Ds.Add(point2Ds[count - 1]);
            }

            return new IntersectionResult2D(geometry2Ds, false);
        }

        /// <summary>
        /// Calculates the intersection result of two polygonal faces.
        /// </summary>
        /// <param name="polygonalFace2D_1">The first polygonal face.</param>
        /// <param name="polygonalFace2D_2">The second polygonal face.</param>
        /// <returns>An IntersectionResult2D containing the intersection geometry; otherwise, null if either input is null.</returns>
        public static IntersectionResult2D? IntersectionResult2D(this IPolygonalFace2D? polygonalFace2D_1, IPolygonalFace2D? polygonalFace2D_2)
        {
            if (polygonalFace2D_1 == null || polygonalFace2D_2 == null)
            {
                return null;
            }

            Polygon? polygon_1 = Convert.ToNTS(polygonalFace2D_1);
            if (polygon_1 == null)
            {
                return null;
            }

            Polygon? polygon_2 = Convert.ToNTS(polygonalFace2D_2);
            if (polygon_2 == null)
            {
                return null;
            }

            NetTopologySuite.Geometries.Geometry? geometry;
            try
            {
                geometry = polygon_1.Intersection(polygon_2);
            }
            catch
            {
                return null;
            }

            List<NetTopologySuite.Geometries.Geometry>? geometries = geometry is GeometryCollection geometryCollection ? geometryCollection.Geometries?.ToList() : [geometry];
            if (geometries == null || geometries.Count == 0)
            {
                return new IntersectionResult2D();
            }

            List<IGeometry2D> geometry2Ds = [];
            foreach (NetTopologySuite.Geometries.Geometry geometry_Temp in geometries)
            {
                if (geometry_Temp is MultiPolygon multipolygon)
                {
                    geometry2Ds.AddRange(multipolygon.ToDiGi_PolygonalFace2Ds());
                }
                else if (geometry_Temp is Polygon polygon)
                {
                    PolygonalFace2D? polygonalFace2D = polygon.ToDiGi();
                    if (polygonalFace2D != null)
                    {
                        geometry2Ds.Add(polygonalFace2D);
                    }
                }
                else if (geometry_Temp is LineString lineString)
                {
                    IGeometry2D? geometry2D = lineString.ToDiGi();
                    if (geometry2D is not null)
                    {
                        geometry2Ds.Add(geometry2D);
                    }
                }
                else if (geometry_Temp is LinearRing lineRing)
                {
                    IGeometry2D? geometry2D = (lineRing).ToDiGi();
                    if (geometry2D is not null)
                    {
                        geometry2Ds.Add(geometry2D);
                    }
                }
            }

            return new IntersectionResult2D(geometry2Ds, false);
        }

        /// <summary>
        /// Computes the raw intersection geometry between two segments without allocating an <see cref="Classes.IntersectionResult2D"/> or cloning redundantly.
        /// </summary>
        /// <param name="segment2D_1">The first segment (must be non-null).</param>
        /// <param name="segment2D_2">The second segment (must be non-null).</param>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <param name="handled">Set to <see langword="false"/> only for the degenerate fall-through case where no intersection topology could be resolved; otherwise <see langword="true"/>.</param>
        /// <returns>A freshly owned <see cref="Point2D"/> or <see cref="Segment2D"/>, or null when the segments do not intersect.</returns>
        private static IGeometry2D? IntersectionGeometry2D(Segment2D segment2D_1, Segment2D segment2D_2, double tolerance, out bool handled)
        {
            handled = true;

            Point2D? point2D_Start1 = segment2D_1[0];
            Point2D? point2D_End1 = segment2D_1[1];
            Point2D? point2D_Start2 = segment2D_2[0];
            Point2D? point2D_End2 = segment2D_2[1];

            bool on_1 = segment2D_1.On(point2D_Start2, tolerance);
            bool on_2 = segment2D_1.On(point2D_End2, tolerance);
            bool on_3 = segment2D_2.On(point2D_Start1, tolerance);
            bool on_4 = segment2D_2.On(point2D_End1, tolerance);

            if (!on_1 && !on_2 && !on_3 && !on_4)
            {
                return segment2D_1.IntersectionPoint(segment2D_2, tolerance);
            }

            if (on_1 && on_2)
            {
                return new Segment2D(segment2D_2);
            }

            if (on_3 && on_4)
            {
                return new Segment2D(segment2D_1);
            }

            if (on_2 && on_3)
            {
                if (Query.AlmostEquals(point2D_End2, point2D_Start1, tolerance))
                {
                    return point2D_End2;
                }

                return new Segment2D(point2D_End2, point2D_Start1);
            }

            if (on_1 && on_3)
            {
                if (Query.AlmostEquals(point2D_Start2, point2D_Start1, tolerance))
                {
                    return point2D_Start2;
                }

                return new Segment2D(point2D_Start2, point2D_Start1);
            }

            if (on_2 && on_4)
            {
                if (Query.AlmostEquals(point2D_End2, point2D_End1, tolerance))
                {
                    return point2D_End2;
                }

                return new Segment2D(point2D_End2, point2D_End1);
            }

            if (on_1 && on_4)
            {
                if (Query.AlmostEquals(point2D_Start2, point2D_End1, tolerance))
                {
                    return point2D_Start2;
                }

                return new Segment2D(point2D_Start2, point2D_End1);
            }

            handled = false;
            return null;
        }

        /// <summary>
        /// Computes the raw intersection geometry between a line and a segment without allocating an <see cref="Classes.IntersectionResult2D"/> or cloning redundantly.
        /// </summary>
        /// <param name="line2D">The line (must be non-null).</param>
        /// <param name="segment2D">The segment (must be non-null).</param>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>A freshly owned <see cref="Segment2D"/> when the segment lies on the line, a <see cref="Point2D"/> when they cross, or null when they do not intersect.</returns>
        private static IGeometry2D? IntersectionGeometry2D(Line2D line2D, Segment2D segment2D, double tolerance)
        {
            Point2D? point2D_Start = segment2D[0];
            Point2D? point2D_End = segment2D[1];

            if (point2D_Start != null && point2D_End != null && line2D.On(point2D_Start, tolerance) && line2D.On(point2D_End))
            {
                return new Segment2D(segment2D);
            }

            return line2D.IntersectionPoint(segment2D, tolerance);
        }

        /// <summary>
        /// Accumulates unique intersection points and segments, deduplicating within a distance tolerance.
        /// Points use a linear scan while few, then transparently switch to a uniform spatial-hash grid
        /// (cell size equal to the tolerance) so lookups stay near O(1) as the result set grows.
        /// First-seen ordering is preserved.
        /// </summary>
        private sealed class IntersectionAccumulator
        {
            private const int HashThreshold = 16;

            private readonly double tolerance;
            private readonly double tolerance_Squared;
            private readonly List<Point2D> point2Ds = [];
            private readonly List<Segment2D> segment2Ds = [];
            private Dictionary<(long, long), List<Point2D>>? pointBuckets;

            /// <summary>
            /// Initializes a new accumulator using the supplied distance tolerance.
            /// </summary>
            /// <param name="tolerance">The distance tolerance used for deduplication.</param>
            public IntersectionAccumulator(double tolerance)
            {
                this.tolerance = tolerance;
                tolerance_Squared = tolerance * tolerance;
            }

            /// <summary>
            /// Adds a candidate intersection geometry unless a similar one is already present.
            /// </summary>
            /// <param name="geometry2D">The candidate intersection geometry.</param>
            /// <returns>True if the geometry is a point or a segment (an intersection event); otherwise, false.</returns>
            public bool Add(IGeometry2D? geometry2D)
            {
                if (geometry2D is Point2D point2D)
                {
                    AddPoint(point2D);
                    return true;
                }

                if (geometry2D is Segment2D segment2D)
                {
                    for (int i = 0; i < segment2Ds.Count; i++)
                    {
                        if (segment2Ds[i].Similar(segment2D, tolerance))
                        {
                            return true;
                        }
                    }

                    segment2Ds.Add(segment2D);
                    return true;
                }

                return false;
            }

            /// <summary>
            /// Builds the final result, adopting the accumulated geometries without cloning.
            /// </summary>
            /// <returns>An <see cref="Classes.IntersectionResult2D"/> that owns the accumulated geometries.</returns>
            public IntersectionResult2D ToResult()
            {
                List<IGeometry2D> geometry2Ds = new(point2Ds.Count + segment2Ds.Count);
                for (int i = 0; i < point2Ds.Count; i++)
                {
                    geometry2Ds.Add(point2Ds[i]);
                }

                for (int i = 0; i < segment2Ds.Count; i++)
                {
                    geometry2Ds.Add(segment2Ds[i]);
                }

                return new IntersectionResult2D(geometry2Ds, false);
            }

            private void AddPoint(Point2D point2D)
            {
                if (pointBuckets != null)
                {
                    if (!ContainsSimilar(point2D))
                    {
                        point2Ds.Add(point2D);
                        AddToBucket(point2D);
                    }

                    return;
                }

                for (int i = 0; i < point2Ds.Count; i++)
                {
                    double double_Dx = point2Ds[i].X - point2D.X;
                    double double_Dy = point2Ds[i].Y - point2D.Y;
                    if (double_Dx * double_Dx + double_Dy * double_Dy <= tolerance_Squared)
                    {
                        return;
                    }
                }

                point2Ds.Add(point2D);

                if (point2Ds.Count >= HashThreshold && tolerance > 0.0)
                {
                    pointBuckets = [];
                    for (int i = 0; i < point2Ds.Count; i++)
                    {
                        AddToBucket(point2Ds[i]);
                    }
                }
            }

            private bool ContainsSimilar(Point2D point2D)
            {
                long cellX = (long)System.Math.Floor(point2D.X / tolerance);
                long cellY = (long)System.Math.Floor(point2D.Y / tolerance);

                for (long dxCell = -1; dxCell <= 1; dxCell++)
                {
                    for (long dyCell = -1; dyCell <= 1; dyCell++)
                    {
                        if (pointBuckets != null && pointBuckets.TryGetValue((cellX + dxCell, cellY + dyCell), out List<Point2D>? bucket))
                        {
                            for (int i = 0; i < bucket.Count; i++)
                            {
                                double double_Dx = bucket[i].X - point2D.X;
                                double double_Dy = bucket[i].Y - point2D.Y;
                                if (double_Dx * double_Dx + double_Dy * double_Dy <= tolerance_Squared)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }

                return false;
            }

            private void AddToBucket(Point2D point2D)
            {
                (long, long) key = ((long)System.Math.Floor(point2D.X / tolerance), (long)System.Math.Floor(point2D.Y / tolerance));
                if (pointBuckets != null)
                {
                    if (!pointBuckets.TryGetValue(key, out List<Point2D>? bucket))
                    {
                        bucket = [];
                        pointBuckets[key] = bucket;
                    }

                    bucket.Add(point2D);
                }
            }
        }

        /// <summary>
        /// Adds a point to a collection unless a point within the squared tolerance already exists.
        /// </summary>
        /// <param name="point2Ds">The accumulated points.</param>
        /// <param name="point2D">The candidate point.</param>
        /// <param name="tolerance_Squared">The squared distance tolerance used to detect duplicates.</param>
        /// <returns>True if the point was added; otherwise, false.</returns>
        private static bool AddUniqueByDistance(List<Point2D> point2Ds, Point2D point2D, double tolerance_Squared)
        {
            for (int i = 0; i < point2Ds.Count; i++)
            {
                double double_Dx = point2Ds[i].X - point2D.X;
                double double_Dy = point2Ds[i].Y - point2D.Y;
                if (double_Dx * double_Dx + double_Dy * double_Dy < tolerance_Squared)
                {
                    return false;
                }
            }

            point2Ds.Add(point2D);
            return true;
        }
    }
}

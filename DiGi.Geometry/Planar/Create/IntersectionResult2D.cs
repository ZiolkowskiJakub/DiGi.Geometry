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

            bool on_1 = segment2D_1.On(segment2D_2[0], tolerance);
            bool on_2 = segment2D_1.On(segment2D_2[1], tolerance);
            bool on_3 = segment2D_2.On(segment2D_1[0], tolerance);
            bool on_4 = segment2D_2.On(segment2D_1[1], tolerance);

            if (!on_1 && !on_2 && !on_3 && !on_4)
            {
                return new IntersectionResult2D(segment2D_1.IntersectionPoint(segment2D_2, tolerance));
            }

            if (on_1 && on_2)
            {
                return new IntersectionResult2D(segment2D_2);
            }

            if (on_3 && on_4)
            {
                return new IntersectionResult2D(segment2D_1);
            }

            if (on_2 && on_3)
            {
                if (Query.AlmostEquals(segment2D_2[1], segment2D_1[0], tolerance))
                {
                    return new IntersectionResult2D(segment2D_2[1]);
                }

                return new IntersectionResult2D(new Segment2D(segment2D_2[1], segment2D_1[0]));
            }

            if (on_1 && on_3)
            {
                if (Query.AlmostEquals(segment2D_2[0], segment2D_1[0], tolerance))
                {
                    return new IntersectionResult2D(segment2D_2[0]);
                }

                return new IntersectionResult2D(new Segment2D(segment2D_2[0], segment2D_1[0]));
            }

            if (on_2 && on_4)
            {
                if (Query.AlmostEquals(segment2D_2[1], segment2D_1[1], tolerance))
                {
                    return new IntersectionResult2D(segment2D_2[1]);
                }

                return new IntersectionResult2D(new Segment2D(segment2D_2[1], segment2D_1[1]));
            }

            if (on_1 && on_4)
            {
                if (Query.AlmostEquals(segment2D_2[0], segment2D_1[1], tolerance))
                {
                    return new IntersectionResult2D(segment2D_2[0]);
                }

                return new IntersectionResult2D(new Segment2D(segment2D_2[0], segment2D_1[1]));
            }

            return null;
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

            List<Point2D> point2Ds_Intersection = [];
            List<Segment2D> segment2Ds_Intersection = [];
            foreach (Segment2D segment2D_Temp in segment2Ds)
            {
                if (segment2D_Temp == null)
                {
                    continue;
                }

                IntersectionResult2D? intersectionResult2D = IntersectionResult2D(segment2D, segment2D_Temp);
                if (intersectionResult2D == null || !intersectionResult2D.Intersect)
                {
                    continue;
                }

                IGeometry2D? geometry2D = intersectionResult2D.GetGeometry2Ds<IGeometry2D>()?[0];
                if (geometry2D is Point2D point2D_Intersection)
                {
                    Point2D point2D_Similar = point2Ds_Intersection.Find(x => x.Similar(point2D_Intersection, tolerance));
                    if (point2D_Similar == null)
                    {
                        point2Ds_Intersection.Add(point2D_Intersection);
                    }
                }
                else if (geometry2D is Segment2D segment2D_Intersection)
                {
                    Segment2D segment2D_Similar = segment2Ds_Intersection.Find(x => x.Similar(segment2D_Intersection, tolerance));
                    if (segment2D_Similar == null)
                    {
                        segment2Ds_Intersection.Add(segment2D_Intersection);
                    }
                }
            }

            List<IGeometry2D> geometry2Ds = [];
            for (int i = 0; i < point2Ds_Intersection.Count; i++)
            {
                geometry2Ds.Add(point2Ds_Intersection[i]);
            }

            for (int i = 0; i < segment2Ds_Intersection.Count; i++)
            {
                geometry2Ds.Add(segment2Ds_Intersection[i]);
            }

            return new IntersectionResult2D(geometry2Ds);
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

            if (segment2Ds_1.Count() == 0 || segment2Ds_2.Count() == 0)
            {
                return new IntersectionResult2D();
            }

            List<Point2D> point2Ds_Intersection = [];
            List<Segment2D> segment2Ds_Intersection = [];
            foreach (Segment2D segment2D_Temp in segment2Ds_1)
            {
                if (segment2D_Temp == null)
                {
                    continue;
                }

                IntersectionResult2D? intersectionResult2D = IntersectionResult2D(segment2D_Temp, segment2Ds_2);
                if (intersectionResult2D == null || !intersectionResult2D.Intersect)
                {
                    continue;
                }

                IGeometry2D? geometry2D = intersectionResult2D?.GetGeometry2Ds<IGeometry2D>()?[0];
                if (geometry2D is Point2D point2D_Intersection)
                {
                    Point2D point2D_Similar = point2Ds_Intersection.Find(x => x.Similar(point2D_Intersection, tolerance));
                    if (point2D_Similar == null)
                    {
                        point2Ds_Intersection.Add(point2D_Intersection);
                    }
                }
                else if (geometry2D is Segment2D segment2D_Intersection)
                {
                    Segment2D segment2D_Similar = segment2Ds_Intersection.Find(x => x.Similar(segment2D_Intersection, tolerance));
                    if (segment2D_Similar == null)
                    {
                        segment2Ds_Intersection.Add(segment2D_Intersection);
                    }
                }
            }

            List<IGeometry2D> geometry2Ds = [];
            for (int i = 0; i < point2Ds_Intersection.Count; i++)
            {
                geometry2Ds.Add(point2Ds_Intersection[i]);
            }

            for (int i = 0; i < segment2Ds_Intersection.Count; i++)
            {
                geometry2Ds.Add(segment2Ds_Intersection[i]);
            }

            return new IntersectionResult2D(geometry2Ds);
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

            if (line2D.On(segment2D[0], tolerance) && line2D.On(segment2D[1]))
            {
                return new IntersectionResult2D(new Segment2D(segment2D));
            }

            Point2D? point2D = line2D.IntersectionPoint(segment2D, tolerance);
            if (point2D == null)
            {
                return new IntersectionResult2D();
            }

            return new IntersectionResult2D(point2D);
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

            List<Point2D> point2Ds_Intersection = [];
            List<Segment2D> segment2Ds_Intersection = [];
            foreach (Segment2D segment2D_Temp in segment2Ds)
            {
                if (segment2D_Temp == null)
                {
                    continue;
                }

                IntersectionResult2D? intersectionResult2D = IntersectionResult2D(line2D, segment2D_Temp);
                if (intersectionResult2D == null || !intersectionResult2D.Intersect)
                {
                    continue;
                }

                IGeometry2D? geometry2D = intersectionResult2D.GetGeometry2Ds<IGeometry2D>()?[0];
                if (geometry2D is Point2D point2D_Intersection)
                {
                    Point2D point2D_Similar = point2Ds_Intersection.Find(x => x.Similar(point2D_Intersection, tolerance));
                    if (point2D_Similar == null)
                    {
                        point2Ds_Intersection.Add(point2D_Intersection);
                    }
                }
                else if (geometry2D is Segment2D segment2D_Intersection)
                {
                    Segment2D segment2D_Similar = segment2Ds_Intersection.Find(x => x.Similar(segment2D_Intersection, tolerance));
                    if (segment2D_Similar == null)
                    {
                        segment2Ds_Intersection.Add(segment2D_Intersection);
                    }
                }
            }

            List<IGeometry2D> geometry2Ds = [];
            for (int i = 0; i < point2Ds_Intersection.Count; i++)
            {
                geometry2Ds.Add(point2Ds_Intersection[i]);
            }

            for (int i = 0; i < segment2Ds_Intersection.Count; i++)
            {
                geometry2Ds.Add(segment2Ds_Intersection[i]);
            }

            return new IntersectionResult2D(geometry2Ds);
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

            List<Point2D> point2Ds_Intersection = [];
            List<Segment2D> segment2Ds_Intersection = [];

            for (int i = 0; i < count_Segment2Ds - 1; i++)
            {
                Segment2D segment2D_1 = segment2Ds[i];

                for (int j = i + 1; j < count_Segment2Ds; j++)
                {
                    Segment2D segment2D_2 = segment2Ds[j];

                    IntersectionResult2D? intersectionResult2D = IntersectionResult2D(segment2D_1, segment2D_2, tolerance);
                    if (intersectionResult2D != null && intersectionResult2D.Intersect)
                    {
                        bool adjacent = i + 1 == j;
                        bool last = i == 0 && j == count_Segment2Ds - 1;

                        IGeometry2D? geometry2D = null;

                        if (!adjacent && !last)
                        {
                            geometry2D = intersectionResult2D.GetGeometry2Ds<IGeometry2D>()?[0];
                        }
                        else if (intersectionResult2D.Contains<Segment2D>())
                        {
                            geometry2D = intersectionResult2D.GetGeometry2Ds<Segment2D>().FirstOrDefault();
                        }
                        else
                        {
                            Point2D point2D = intersectionResult2D.GetGeometry2Ds<Point2D>().FirstOrDefault();
                            if (point2D != null)
                            {
                                if (adjacent && !Query.AlmostEquals(segment2D_1[1], point2D, tolerance))
                                {
                                    geometry2D = point2D;
                                }
                                else if (last && !Query.AlmostEquals(segment2D_1[0], point2D, tolerance))
                                {
                                    geometry2D = point2D;
                                }
                            }
                        }

                        if (geometry2D == null)
                        {
                            continue;
                        }

                        if (geometry2D is Point2D point2D_Intersection)
                        {
                            Point2D point2D_Similar = point2Ds_Intersection.Find(x => x.Similar(point2D_Intersection, tolerance));
                            if (point2D_Similar == null)
                            {
                                point2Ds_Intersection.Add(point2D_Intersection);
                            }
                            count++;
                        }
                        else if (geometry2D is Segment2D segment2D_Intersection)
                        {
                            Segment2D segment2D_Similar = segment2Ds_Intersection.Find(x => x.Similar(segment2D_Intersection, tolerance));
                            if (segment2D_Similar == null)
                            {
                                segment2Ds_Intersection.Add(segment2D_Intersection);
                            }

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

            List<IGeometry2D> geometry2Ds = [];
            for (int i = 0; i < point2Ds_Intersection.Count; i++)
            {
                geometry2Ds.Add(point2Ds_Intersection[i]);
            }

            for (int i = 0; i < segment2Ds_Intersection.Count; i++)
            {
                geometry2Ds.Add(segment2Ds_Intersection[i]);
            }

            return new IntersectionResult2D(geometry2Ds);
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

                    Point2D? point2D = null;

                    point2D = segment2D[0];
                    if (linear2D.On(point2D, tolerance))
                    {
                        DiGi.Core.Modify.Add(point2Ds!, point2D, x => x!.Distance(point2D) < tolerance);
                    }

                    point2D = segment2D[1];
                    if (linear2D.On(point2D, tolerance))
                    {
                        DiGi.Core.Modify.Add(point2Ds!, point2D, x => x!.Distance(point2D) < tolerance);
                    }

                    point2D = linear2D.IntersectionPoint(segment2D, tolerance);
                    if (point2D != null)
                    {
                        DiGi.Core.Modify.Add(point2Ds!, point2D, x => x!.Distance(point2D) < tolerance);
                    }
                }
            }

            if (point2Ds == null || point2Ds.Count == 0)
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

            return new IntersectionResult2D(geometry2Ds);
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

            return new IntersectionResult2D(geometry2Ds);
        }
    }
}
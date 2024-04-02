using DiGi.Core;
using DiGi.Geometry.Planar;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        public static PlanarIntersectionResult PlanarIntersectionResult(this Plane plane, Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(plane == null || point3D == null)
            {
                return null;
            }

            Point3D point3D_Project = plane.Project(point3D);
            if(point3D_Project == null)
            {
                return null;
            }

            if(point3D_Project.Distance(point3D) < tolerance)
            {
                return new PlanarIntersectionResult(plane);
            }

            return new PlanarIntersectionResult(plane, plane.Convert(point3D_Project));
        }

        public static PlanarIntersectionResult PlanarIntersectionResult(this Plane plane, Segment3D segment3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (plane == null || segment3D == null)
            {
                return null;
            }

            Vector3D direction = segment3D.Direction;

            Vector3D normal = plane.Normal;

            double d = normal.DotProduct(direction);
            if (System.Math.Abs(d) < tolerance)
            {
                if (System.Math.Min(plane.Distance(segment3D[0]), plane.Distance(segment3D[1])) < tolerance)
                {
                    Segment3D segment3D_Project = plane.Project(segment3D);
                    if(segment3D_Project != null)
                    {
                        return new PlanarIntersectionResult(plane, plane.Convert(segment3D_Project));
                    }
                }

                return new PlanarIntersectionResult(plane);
            }

            double u = (plane.K - normal.DotProduct((Vector3D)segment3D[0])) / d;
            Point3D point3D = segment3D[0];

            Point3D point3D_Intersection = new Point3D(point3D.X + u * direction.X, point3D.Y + u * direction.Y, point3D.Z + u * direction.Z);
            if (!segment3D.On(point3D_Intersection, tolerance))
            {
                return new PlanarIntersectionResult(plane);
            }

            return new PlanarIntersectionResult(plane, plane.Convert(point3D_Intersection));
        }

        public static PlanarIntersectionResult PlanarIntersectionResult(this Plane plane, Line3D line3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(plane == null || line3D == null)
            {
                return null;
            }

            return PlanarIntersectionResult(plane, line3D.Origin, line3D.Direction, tolerance);
        }

        public static PlanarIntersectionResult PlanarIntersectionResult(this Plane plane, Point3D point3D, Vector3D vector3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (plane == null || point3D == null || vector3D == null)
            {
                return null;
            }

            Vector3D normal = plane.Normal;

            double d = normal.DotProduct(vector3D);
            if (System.Math.Abs(d) < tolerance)
            {
                if (plane.Distance(point3D) < tolerance)
                {
                    Line3D line3D = plane.Project(new Line3D(point3D, vector3D));
                    if(line3D != null)
                    {
                        return new PlanarIntersectionResult(plane, plane.Convert(line3D));
                    }
                }

                return new PlanarIntersectionResult(plane);
            }

            double u = (plane.K - normal.DotProduct((Vector3D)point3D)) / d;

            Point3D point3D_Intersection = new Point3D(point3D.X + u * vector3D.X, point3D.Y + u * vector3D.Y, point3D.Z + u * vector3D.Z);

            return new PlanarIntersectionResult(plane, plane.Convert(point3D_Intersection));
        }

        public static PlanarIntersectionResult PlanarIntersectionResult(this Plane plane, ISegmentable3D segmentable3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(plane == null || segmentable3D == null)
            {
                return null;
            }

            List<Segment3D> segment3Ds = segmentable3D.GetSegments();
            if(segment3Ds == null)
            {
                return null;
            }

            List<Segment2D> segment2Ds = new List<Segment2D>();
            List<Point2D> point2Ds = new List<Point2D>();

            for (int i=0; i < segment3Ds.Count; i++)
            {
                PlanarIntersectionResult planarIntersectionResult = PlanarIntersectionResult(plane, segment3Ds[i], tolerance);
                if(planarIntersectionResult == null || !planarIntersectionResult.Intersect)
                {
                    continue;
                }

                foreach(IGeometry2D geometry2D in planarIntersectionResult.GetGeometry2Ds<IGeometry2D>())
                {
                    if(geometry2D is Segment2D)
                    {
                        Segment2D segment2D = (Segment2D)geometry2D;
                        DiGi.Core.Modify.Add(segment2Ds, segment2D, x => Planar.Query.Similar(x, segment2D, tolerance));
                    }
                    else if(geometry2D is Point2D)
                    {
                        Point2D point2D = (Point2D)geometry2D;
                        DiGi.Core.Modify.Add(point2Ds, point2D, x => Planar.Query.Similar(x, point2D, tolerance));
                    }

                }
            }
            List<IGeometry2D> geometry2Ds = new List<IGeometry2D>();
            for (int i = 0; i < segment2Ds.Count; i++)
            {
                geometry2Ds.Add(segment2Ds[i]);
            }

            for (int i = 0; i < point2Ds.Count; i++)
            {
                geometry2Ds.Add(point2Ds[i]);
            }

            if (geometry2Ds == null || geometry2Ds.Count == 0)
            {
                return new PlanarIntersectionResult(plane);
            }

            return new PlanarIntersectionResult(plane, geometry2Ds);
        }

        public static PlanarIntersectionResult PlanarIntersectionResult(this Plane plane_1, Plane plane_2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(plane_1 == null || plane_2 == null)
            {
                return null;
            }

            if (plane_1.Coplanar(plane_2, tolerance))
            {
                if (plane_1.Distance(plane_2.Origin) < tolerance)
                {
                    return null;
                }

                return new PlanarIntersectionResult(plane_1);
            }

            //Calculate tangent of line perpendicular to the normal of the two planes
            Vector3D tangent = plane_1.Normal.CrossProduct(plane_2.Normal).Unit;

            //d-values from plane equation: ax+by+cz+d=0
            double d1 = -plane_1.Normal.DotProduct(new Vector3D(plane_1.Origin.X, plane_1.Origin.Y, plane_1.Origin.Z));
            double d2 = -plane_2.Normal.DotProduct(new Vector3D(plane_2.Origin.X, plane_2.Origin.Y, plane_2.Origin.Z));

            Point3D orgin;

            Vector3D n1 = plane_1.Normal;
            Vector3D n2 = plane_2.Normal;

            if (System.Math.Abs(tangent.Z) >= tolerance)
            {
                double x0 = (n1.Y * d2 - n2.Y * d1) / (n1.X * n2.Y - n2.X * n1.Y);
                double y0 = (n2.X * d1 - n1.X * d2) / (n1.X * n2.Y - n2.X * n1.Y);

                orgin = new Point3D(x0, y0, 0);
            }
            else if (System.Math.Abs(tangent.Y) >= tolerance)
            {
                double x0 = (n1.Z * d2 - n2.Z * d1) / (n1.X * n2.Z - n2.X * n1.Z);
                double z0 = (n2.X * d1 - n1.X * d2) / (n1.X * n2.Z - n2.X * n1.Z);
                orgin = new Point3D(x0, 0, z0);
            }
            else
            {
                double y0 = (n1.Z * d2 - n2.Z * d1) / (n1.Y * n2.Z - n2.Y * n1.Z);
                double z0 = (n2.Y * d1 - n1.Y * d2) / (n1.Y * n2.Z - n2.Y * n1.Z);
                orgin = new Point3D(0, y0, z0);
            }

            return new PlanarIntersectionResult(plane_1, plane_1.Convert(new Line3D(orgin, tangent)));
        }

        public static PlanarIntersectionResult PlanarIntersectionResult(this Plane plane, PolygonalFace3D polygonalFace3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(plane == null || polygonalFace3D == null)
            {
                return null;
            }

            Plane plane_PolygonalFace3D = polygonalFace3D.Plane;
            if(plane_PolygonalFace3D == null)
            {
                return null;
            }

            if(plane.Coplanar(plane_PolygonalFace3D, tolerance))
            {
                if(plane.Distance(plane_PolygonalFace3D.Origin) < tolerance)
                {
                    PolygonalFace2D polygonalFace2D_Temp = plane.Convert(polygonalFace3D);
                    if(polygonalFace2D_Temp != null)
                    {
                        return new PlanarIntersectionResult(plane, polygonalFace2D_Temp);
                    }
                }

                return new PlanarIntersectionResult(plane);
            }

            BoundingBox3D boundingBox3D = polygonalFace3D.GetBoundingBox();
            if(boundingBox3D == null)
            {
                return null;
            }

            if(!boundingBox3D.InRange(plane, tolerance))
            {
                return new PlanarIntersectionResult(plane);
            }

            PlanarIntersectionResult planarIntersectionResult = PlanarIntersectionResult(plane, plane_PolygonalFace3D, tolerance);
            if (planarIntersectionResult == null || !planarIntersectionResult.Intersect)
            {
                return new PlanarIntersectionResult(plane);
            }

            Line3D line3D = planarIntersectionResult.GetGeometry3Ds<Line3D>()?.FirstOrDefault();
            if (line3D == null)
            {
                return new PlanarIntersectionResult(plane);
            }

            if (!boundingBox3D.InRange(line3D, tolerance))
            {
                return new PlanarIntersectionResult(plane);
            }

            planarIntersectionResult = PlanarIntersectionResult(polygonalFace3D, line3D, tolerance);
            if(planarIntersectionResult == null || !planarIntersectionResult.Intersect)
            {
                return new PlanarIntersectionResult(plane);
            }

            List<IGeometry2D> geometry2Ds = new List<IGeometry2D>();
            foreach(IGeometry3D geometry3D in planarIntersectionResult.GetGeometry3Ds<IGeometry3D>())
            {
                if(geometry3D is Point3D)
                {
                    geometry2Ds.Add(plane.Convert((Point3D)geometry3D));
                    continue;
                }

                if (geometry3D is Segment3D)
                {
                    geometry2Ds.Add(plane.Convert((Segment3D)geometry3D));
                    continue;
                }
            }

            return new PlanarIntersectionResult(plane, geometry2Ds);
        }

        public static PlanarIntersectionResult PlanarIntersectionResult(this Plane plane, VolatilePolygonalFace3D volatilePolygonalFace3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(plane == null || volatilePolygonalFace3D == null)
            {
                return null;
            }

            BoundingBox3D boundingBox3D = volatilePolygonalFace3D.BoundingBox;
            if(boundingBox3D == null)
            {
                return null;
            }

            if(!boundingBox3D.InRange(plane, tolerance))
            {
                return new PlanarIntersectionResult(plane);
            }

            return PlanarIntersectionResult(plane, volatilePolygonalFace3D.Geometry, tolerance);
        }

        public static PlanarIntersectionResult PlanarIntersectionResult(this Plane plane, VolatilePolyhedron volatilePolyhedron, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (plane == null || volatilePolyhedron == null)
            {
                return null;
            }

            BoundingBox3D boundingBox3D = volatilePolyhedron.BoundingBox;
            if (boundingBox3D == null)
            {
                return null;
            }

            if (!boundingBox3D.InRange(plane, tolerance))
            {
                return new PlanarIntersectionResult(plane);
            }

            return PlanarIntersectionResult(plane, volatilePolyhedron.Geometry, tolerance);
        }

        public static PlanarIntersectionResult PlanarIntersectionResult(this Plane plane, Polyhedron polyhedron, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (plane == null || polyhedron == null)
            {
                return null;
            }

            int count = polyhedron.Count;
            if (count == 0)
            {
                return null;
            }

            List<PolygonalFace2D> polygonalFace2Ds = new List<PolygonalFace2D>();
            List<Segment2D> segment2Ds = new List<Segment2D>();
            List<Point2D> point2Ds = new List<Point2D>();

            for (int i = 0; i < count; i++)
            {
                PlanarIntersectionResult planarIntersectionResult = PlanarIntersectionResult(plane, polyhedron[i], tolerance);
                if (planarIntersectionResult == null || !planarIntersectionResult.Intersect)
                {
                    continue;
                }

                foreach (IGeometry2D geometry2D in planarIntersectionResult.GetGeometry2Ds<IGeometry2D>())
                {
                    if (geometry2D is Point2D)
                    {
                        Point2D point2D = (Point2D)geometry2D;
                        DiGi.Core.Modify.Add(point2Ds, point2D, x => point2D.Similar(x, tolerance));
                    }
                    else if (geometry2D is Segment2D)
                    {
                        Segment2D segment2D = (Segment2D)geometry2D;
                        DiGi.Core.Modify.Add(segment2Ds, segment2D, x => segment2D.Similar(x, tolerance));
                    }
                    else if (geometry2D is PolygonalFace2D)
                    {
                        polygonalFace2Ds.Add((PolygonalFace2D)geometry2D);
                    }
                }

            }

            List<IGeometry2D> geometry2Ds = new List<IGeometry2D>();

            if (polygonalFace2Ds != null && polygonalFace2Ds.Count != 0)
            {
                geometry2Ds.AddRange(polygonalFace2Ds);
            }

            if (segment2Ds != null && segment2Ds.Count != 0)
            {
                if (polygonalFace2Ds != null && polygonalFace2Ds.Count != 0)
                {
                    List<Segment2D> segment2Ds_PolgonalFace2D = polygonalFace2Ds.Segment2Ds();
                    if (segment2Ds_PolgonalFace2D != null)
                    {
                        segment2Ds.AddRange(segment2Ds_PolgonalFace2D);
                    }
                }

                segment2Ds = segment2Ds.Split(tolerance);

                if (segment2Ds != null && segment2Ds.Count != 0)
                {
                    if (polygonalFace2Ds != null && polygonalFace2Ds.Count != 0)
                    {
                        foreach (PolygonalFace2D polygonalFace2D in polygonalFace2Ds)
                        {
                            for (int i = segment2Ds.Count - 1; i >= 0; i--)
                            {
                                if (polygonalFace2D.OnEdge(segment2Ds[i].Mid(), tolerance))
                                {
                                    segment2Ds.RemoveAt(i);
                                }
                            }

                            if (segment2Ds.Count == 0)
                            {
                                break;
                            }
                        }
                    }

                    if (segment2Ds != null && segment2Ds.Count != 0)
                    {
                        List<Polygon2D> polygon2Ds = segment2Ds.Polygon2Ds(tolerance);
                        if (polygon2Ds != null)
                        {
                            geometry2Ds.AddRange(polygon2Ds);

                            List<Segment2D> segment2Ds_Polygon2D = polygon2Ds.Segments();
                            foreach (Segment2D segment2D_Polygon2D in segment2Ds_Polygon2D)
                            {
                                Point2D point2D_Polygon2D = segment2D_Polygon2D.Mid();
                                for (int i = segment2Ds.Count - 1; i >= 0; i--)
                                {
                                    if (segment2Ds[i].On(point2D_Polygon2D, tolerance))
                                    {
                                        segment2Ds.RemoveAt(i);
                                        break;
                                    }
                                }

                                if (segment2Ds.Count == 0)
                                {
                                    break;
                                }
                            }
                        }

                        geometry2Ds.AddRange(segment2Ds);
                    }
                }
            }

            if (point2Ds != null && point2Ds.Count != 0)
            {
                if (polygonalFace2Ds != null && polygonalFace2Ds.Count != 0)
                {
                    for (int i = 0; i < polygonalFace2Ds.Count; i++)
                    {
                        for (int j = point2Ds.Count - 1; j >= 0; j--)
                        {
                            if (polygonalFace2Ds[i].OnEdge(point2Ds[j], tolerance))
                            {
                                point2Ds.RemoveAt(j);
                            }
                        }

                        if (point2Ds.Count == 0)
                        {
                            break;
                        }
                    }
                }

                if (point2Ds != null && point2Ds.Count != 0)
                {
                    if (segment2Ds != null && segment2Ds.Count != 0)
                    {
                        for (int i = 0; i < segment2Ds.Count; i++)
                        {
                            for (int j = point2Ds.Count - 1; j >= 0; j--)
                            {
                                if (segment2Ds[i].On(point2Ds[j], tolerance))
                                {
                                    point2Ds.RemoveAt(j);
                                }
                            }

                            if (point2Ds.Count == 0)
                            {
                                break;
                            }
                        }
                    }
                }

                geometry2Ds.AddRange(point2Ds);
            }

            return new PlanarIntersectionResult(plane, geometry2Ds);
        }

        public static PlanarIntersectionResult PlanarIntersectionResult(this PolygonalFace3D polygonalFace3D, Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(polygonalFace3D == null || point3D == null)
            {
                return null;
            }

            Plane plane = polygonalFace3D.Plane;
            if(plane == null)
            {
                return null;
            }

            if(!polygonalFace3D.InRange(point3D, tolerance))
            {
                return new PlanarIntersectionResult(plane);
            }

            return new PlanarIntersectionResult(plane, plane.Convert(point3D));
        }

        public static PlanarIntersectionResult PlanarIntersectionResult(this PolygonalFace3D polygonalFace3D, ILinear3D linear3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (polygonalFace3D == null || linear3D == null)
            {
                return null;
            }

            Plane plane = polygonalFace3D.Plane;
            if (plane == null)
            {
                return null;
            }

            PlanarIntersectionResult planarIntersectionResult = PlanarIntersectionResult(plane, linear3D as dynamic, tolerance);
            if(planarIntersectionResult == null)
            {
                return null;
            }

            if(!planarIntersectionResult.Intersect)
            {
                return new PlanarIntersectionResult(plane);
            }

            List<IGeometry2D> geometry2Ds_Plane = planarIntersectionResult.GetGeometry2Ds<IGeometry2D>();
            if(geometry2Ds_Plane == null || geometry2Ds_Plane.Count == 0)
            {
                return new PlanarIntersectionResult(plane);
            }

            PolygonalFace2D polygonalFace2D = plane.Convert(polygonalFace3D);
            if(polygonalFace2D == null)
            {
                return null;
            }

            VolatileBoundable2D<PolygonalFace2D> volatileBoundable2D = new VolatileBoundable2D<PolygonalFace2D>(polygonalFace2D);
            BoundingBox2D boundingBox2D = volatileBoundable2D.BoundingBox;

            List<IGeometry2D> geometry2Ds = new List<IGeometry2D>();
            foreach (IGeometry2D geometry2D in geometry2Ds_Plane)
            {
                if(geometry2D is Point2D)
                {
                    Point2D point2D = (Point2D)geometry2D;
                    if(boundingBox2D.InRange(point2D, tolerance))
                    {
                        if(polygonalFace2D.InRange(point2D, tolerance))
                        {
                            geometry2Ds.Add(geometry2D);
                        }
                    }
                    continue;
                }

                if(geometry2D is ILinear2D)
                {
                    IntersectionResult2D intersectionResult2D = Planar.Create.IntersectionResult2D(volatileBoundable2D, (ILinear2D)geometry2D, tolerance);
                    if(intersectionResult2D != null && intersectionResult2D.Intersect)
                    {
                        geometry2Ds.AddRange(intersectionResult2D.GetGeometry2Ds<IGeometry2D>());
                    }

                    continue;
                }
            }

            if(geometry2Ds == null || geometry2Ds.Count == 0)
            {
                return new PlanarIntersectionResult(plane);
            }

            return new PlanarIntersectionResult(plane, geometry2Ds);
        }

        public static PlanarIntersectionResult PlanarIntersectionResult(this PolygonalFace3D polygonalFace3D, ISegmentable3D segmentable3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (polygonalFace3D == null || segmentable3D == null)
            {
                return null;
            }

            Plane plane = polygonalFace3D.Plane;
            if (plane == null)
            {
                return null;
            }

            PlanarIntersectionResult planarIntersectionResult = PlanarIntersectionResult(plane, segmentable3D, tolerance);
            if (planarIntersectionResult == null)
            {
                return null;
            }

            if (!planarIntersectionResult.Intersect)
            {
                return new PlanarIntersectionResult(plane);
            }

            List<IGeometry2D> geometry2Ds_Plane = planarIntersectionResult.GetGeometry2Ds<IGeometry2D>();
            if (geometry2Ds_Plane == null || geometry2Ds_Plane.Count == 0)
            {
                return new PlanarIntersectionResult(plane);
            }

            PolygonalFace2D polygonalFace2D = plane.Convert(polygonalFace3D);
            if (polygonalFace2D == null)
            {
                return null;
            }

            VolatileBoundable2D<PolygonalFace2D> volatileBoundable2D = new VolatileBoundable2D<PolygonalFace2D>(polygonalFace2D);
            BoundingBox2D boundingBox2D = volatileBoundable2D.BoundingBox;

            List<IGeometry2D> geometry2Ds = new List<IGeometry2D>();
            foreach (IGeometry2D geometry2D in geometry2Ds_Plane)
            {
                if (geometry2D is Point2D)
                {
                    Point2D point2D = (Point2D)geometry2D;
                    if (boundingBox2D.InRange(point2D, tolerance))
                    {
                        if (polygonalFace2D.InRange(point2D, tolerance))
                        {
                            geometry2Ds.Add(geometry2D);
                        }
                    }
                    continue;
                }

                if (geometry2D is Segment2D)
                {
                    IntersectionResult2D intersectionResult2D = Planar.Create.IntersectionResult2D(volatileBoundable2D, (Segment2D)geometry2D, tolerance);
                    if (intersectionResult2D != null && intersectionResult2D.Intersect)
                    {
                        geometry2Ds.AddRange(intersectionResult2D.GetGeometry2Ds<IGeometry2D>());
                    }

                    continue;
                }
            }

            if (geometry2Ds == null || geometry2Ds.Count == 0)
            {
                return new PlanarIntersectionResult(plane);
            }

            return new PlanarIntersectionResult(plane, geometry2Ds);
        }
    
        public static PlanarIntersectionResult PlanarIntersectionResult(this VolatilePolygonalFace3D volatilePolygonalFace3D, ILinear3D linear3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(volatilePolygonalFace3D == null || linear3D == null)
            {
                return null;
            }

            BoundingBox3D boundingBox3D_Temp = volatilePolygonalFace3D.BoundingBox;
            if (boundingBox3D_Temp == null)
            {
                return null;
            }

            PolygonalFace3D polygonalFace3D = volatilePolygonalFace3D.Geometry;
            if(polygonalFace3D == null)
            {
                return null;
            }

            if (!boundingBox3D_Temp.InRange(linear3D as dynamic, tolerance))
            {
                return new PlanarIntersectionResult(polygonalFace3D.Plane);
            }


            return PlanarIntersectionResult(polygonalFace3D, linear3D, tolerance);

        }
    }
}

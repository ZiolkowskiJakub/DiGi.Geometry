using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        public static Point3D Convert(this Plane plane, Point2D point2D)
        {
            if (plane == null || point2D == null)
            {
                return null;
            }

            Vector3D axisX = plane.AxisX;
            Vector3D axisY = plane.AxisY;

            Vector3D u = new Vector3D(axisY.X * point2D.Y, axisY.Y * point2D.Y, axisY.Z * point2D.Y);
            Vector3D v = new Vector3D(axisX.X * point2D.X, axisX.Y * point2D.X, axisX.Z * point2D.X);

            Point3D origin = plane.Origin;

            return new Point3D(origin.X + u.X + v.X, origin.Y + u.Y + v.Y, origin.Z + u.Z + v.Z);
        }

        public static Vector3D Convert(this Plane plane, Vector2D vector2D)
        {
            if (plane == null || vector2D == null)
            {
                return null;
            }

            Vector3D axisX = plane.AxisX;
            Vector3D axisY = plane.AxisY;

            Vector3D u = new Vector3D(axisY.X * vector2D.Y, axisY.Y * vector2D.Y, axisY.Z * vector2D.Y);
            Vector3D v = new Vector3D(axisX.X * vector2D.X, axisX.Y * vector2D.X, axisX.Z * vector2D.X);

            return new Vector3D(u.X + v.X, u.Y + v.Y, u.Z + v.Z);
        }

        public static Segment3D Convert(this Plane plane, Segment2D segment2D)
        {
            if(plane == null || segment2D == null)
            {
                return null;
            }

            Point3D start = plane.Convert(segment2D.Start);
            if(start == null)
            {
                return null;
            }

            Point3D end = plane.Convert(segment2D.End);
            if (end == null)
            {
                return null;
            }


            return new Segment3D(start, end);
        }

        public static Line3D Convert(this Plane plane, Line2D line2D)
        {
            if (plane == null || line2D == null)
            {
                return null;
            }

            Point3D origin = plane.Convert(line2D.Origin);
            if (origin == null)
            {
                return null;
            }

            Vector3D direction = plane.Convert(line2D.Direction);
            if (direction == null)
            {
                return null;
            }

            return new Line3D(origin, direction);
        }

        public static Triangle3D Convert(this Plane plane, Triangle2D triangle2D)
        {
            if(plane == null || triangle2D == null)
            {
                return null;
            }

            List<Point2D> point2Ds = triangle2D.GetPoints();
            if(point2Ds == null)
            {
                return null;
            }

            Point3D point3D_1 = plane.Convert(point2Ds[0]);
            if(point3D_1 == null)
            {
                return null;
            }

            Point3D point3D_2 = plane.Convert(point2Ds[1]);
            if (point3D_2 == null)
            {
                return null;
            }

            Point3D point3D_3 = plane.Convert(point2Ds[2]);
            if (point3D_3 == null)
            {
                return null;
            }

            return new Triangle3D(point3D_1, point3D_2, point3D_3);
        }

        public static Polygon3D Convert(this Plane plane, Polygon2D polygon2D)
        {
            if (plane == null || polygon2D == null)
            {
                return null;
            }

            List<Point2D> point2Ds = polygon2D.GetPoints();
            if (point2Ds == null)
            {
                return null;
            }

            return new Polygon3D(plane, point2Ds);
        }

        public static IPolygonal3D Convert(this Plane plane, IPolygonal2D polygonal2D)
        {
            if(plane == null || polygonal2D == null)
            {
                return null;
            }

            return Convert(plane, polygonal2D as dynamic);
        }

        public static Point2D Convert(this Plane plane, Point3D point3D)
        {
            if (plane == null || point3D == null)
            {
                return null;
            }

            Vector3D axisX = plane.AxisX;
            Vector3D axisY = plane.AxisY;
            Point3D origin = plane.Origin;

            Vector3D vector3D = new Vector3D(point3D.X - origin.X, point3D.Y - origin.Y, point3D.Z - origin.Z);
            return new Point2D(axisX.DotProduct(vector3D), axisY.DotProduct(vector3D));
        }

        public static Vector2D Convert(this Plane plane, Vector3D vector3D)
        {
            if (plane == null || vector3D == null)
            {
                return null;
            }

            Vector3D axisX = plane.AxisX;
            Vector3D axisY = plane.AxisY;

            return new Vector2D(axisX.DotProduct(vector3D), axisY.DotProduct(vector3D));
        }

        public static Segment2D Convert(this Plane plane, Segment3D segment3D)
        {
            if (plane == null || segment3D == null)
            {
                return null;
            }

            Point2D start = plane.Convert(segment3D.Start);
            if (start == null)
            {
                return null;
            }

            Point2D end = plane.Convert(segment3D.End);
            if (end == null)
            {
                return null;
            }


            return new Segment2D(start, end);
        }

        public static Line2D Convert(this Plane plane, Line3D line3D)
        {
            if (plane == null || line3D == null)
            {
                return null;
            }

            Point2D origin = plane.Convert(line3D.Origin);
            if (origin == null)
            {
                return null;
            }

            Vector2D direction = plane.Convert(line3D.Direction);
            if (direction == null)
            {
                return null;
            }


            return new Line2D(origin, direction);
        }

        public static Triangle2D Convert(this Plane plane, Triangle3D triangle3D)
        {
            if (plane == null || triangle3D == null)
            {
                return null;
            }

            List<Point3D> point3Ds = triangle3D.GetPoints();
            if (point3Ds == null)
            {
                return null;
            }

            Point2D point2D_1 = plane.Convert(point3Ds[0]);
            if (point2D_1 == null)
            {
                return null;
            }

            Point2D point2D_2 = plane.Convert(point3Ds[1]);
            if (point2D_2 == null)
            {
                return null;
            }

            Point2D point2D_3 = plane.Convert(point3Ds[2]);
            if (point2D_3 == null)
            {
                return null;
            }

            return new Triangle2D(point2D_1, point2D_2, point2D_3);
        }

        public static Polygon2D Convert(this Plane plane, Polygon3D polygon3D)
        {
            if (plane == null || polygon3D == null)
            {
                return null;
            }

            List<Point3D> point3Ds = polygon3D.GetPoints();
            if (point3Ds == null)
            {
                return null;
            }

            List<Point2D> point2Ds = new List<Point2D>();
            for(int i=0; i < point3Ds.Count; i++)
            {
                point2Ds.Add(plane.Convert(point3Ds[i]));
            }

            return new Polygon2D(point2Ds);

        }
    
        public static IPolygonal2D Convert(this Plane plane, IPolygonal3D polygonal3D)
        {
            if(plane == null || polygonal3D == null)
            {
                return null;
            }

            return Convert(plane, polygonal3D as dynamic);
        }

        public static Polyline3D Convert(this Plane plane, Polyline2D polyline2D)
        {
            if(plane == null || polyline2D == null)
            {
                return null;
            }

            List<Point2D> point2Ds = polyline2D.GetPoints();
            if(point2Ds == null)
            {
                return null;
            }

            List<Point3D> point3Ds = new List<Point3D>();
            for(int i =0; i < point2Ds.Count; i++)
            {
                point3Ds.Add(plane.Convert(point2Ds[i]));
            }

            return new Polyline3D(point3Ds);
        }

        public static PolygonalFace2D Convert(this Plane plane, PolygonalFace3D polygonalFace3D)
        {
            if(plane == null || polygonalFace3D == null)
            {
                return null;
            }

            IPolygonal2D externalEdge = plane.Convert(polygonalFace3D.ExternalEdge);
            if(externalEdge == null)
            {
                return null;
            }

            List<IPolygonal2D> internalEdges = null;

            List<IPolygonal3D> internalEdges_3D = polygonalFace3D.InternalEdges;
            if (internalEdges_3D != null && internalEdges_3D.Count != 0)
            {
                internalEdges = new List<IPolygonal2D>();
                for (int i = 0; i < internalEdges_3D.Count; i++)
                {
                    IPolygonal2D internalEdge = plane.Convert(internalEdges_3D[i]);
                    if(internalEdge == null)
                    {
                        continue;
                    }

                    internalEdges.Add(internalEdge);
                }
            }

            return new PolygonalFace2D(externalEdge, internalEdges);
        }

        public static IGeometry3D Convert(this Plane plane, IGeometry2D geometry2D)
        {
            if(plane == null || geometry2D == null)
            {
                return null;
            }

            return Convert(plane, geometry2D as dynamic);
        }

        public static IGeometry2D Convert(IPlanar planar)
        {
            Plane plane = planar?.Plane;
            if(plane == null)
            {
                return null;
            }

            return Convert(plane, planar as dynamic);
        }
    }

}

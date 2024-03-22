using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Spatial.Classes;
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
    }

}

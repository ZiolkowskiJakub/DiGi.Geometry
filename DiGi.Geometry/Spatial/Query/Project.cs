using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        public static Point3D Project(this Plane plane, Point3D point3D)
        {
            if (plane == null || point3D == null)
            {
                return null;
            }

            return plane.ClosestPoint(point3D);
        }

        public static Segment3D Project(this Plane plane, Segment3D segment3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(plane == null || segment3D == null)
            {
                return null;
            }

            Point3D point3D_1 =  plane.ClosestPoint(segment3D[0]);
            if(point3D_1 == null)
            {
                return null;
            }

            Point3D point3D_2 = plane.ClosestPoint(segment3D[1]);
            if (point3D_2 == null)
            {
                return null;
            }

            if(point3D_1.Distance(point3D_2) < tolerance)
            {
                return null;
            }

            return new Segment3D(point3D_1, point3D_2);
        }

        public static Vector3D Project(this Plane plane, Vector3D vector3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (plane == null || vector3D == null)
            {
                return null;
            }

            Vector3D normal = plane.Normal;

            Vector3D result = vector3D - vector3D.DotProduct(normal) * normal;

            double length = result.Length;

            if(double.IsNaN(length) || length < tolerance)
            {
                return null;
            }

            return result;
        }

        public static Line3D Project(this Plane plane, Line3D line3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (plane == null || line3D == null)
            {
                return null;
            }

            Point3D origin = Project(plane, line3D.Origin);
            if(origin == null)
            {
                return null;
            }

            Vector3D direction = Project(plane, line3D.Direction, tolerance);
            if(direction == null)
            {
                return null;
            }

            return new Line3D(origin, direction);
        }
    }

}

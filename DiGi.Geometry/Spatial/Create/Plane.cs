using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        public static Plane Plane(this Point3D point3D_1, Point3D point3D_2, Point3D point3D_3)
        {
            if (point3D_1 == null || point3D_2 == null || point3D_3 == null)
            {
                return null;
            }


            Vector3D normal = Query.Normal(point3D_1, point3D_2, point3D_3);
            if (normal == null)
            {
                return null;
            }

            return new Plane((new Point3D[] { point3D_1, point3D_2, point3D_3 }).Average(), normal);
        }

        public static Plane Plane(this IEnumerable<Point3D> point3Ds, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            Vector3D normal = Query.Normal(point3Ds, tolerance);
            if (normal == null)
            {
                return null;
            }

            return new Plane(point3Ds.Average(), normal);
        }

        public static Plane Plane(Point3D origin, Vector3D axisX, Vector3D axisY)
        {
            if (origin == null || axisX == null || axisY == null)
            {
                return null;
            }

            return new Plane(origin, axisX, axisY);
        }

        public static Plane Plane(double elevation)
        {
            if(double.IsNaN(elevation))
            {
                return null;
            }

            Plane result = Constans.Plane.WorldZ;
            result.Move(Constans.Vector3D.WorldZ * elevation);

            return result;
        }

        public static Plane Plane(double value, int dimensionIndex)
        {
            Plane result = null;
            switch (dimensionIndex)
            {
                case 0:
                    result = Constans.Plane.WorldX;
                    result.Move(Constans.Vector3D.WorldX * value);
                    return result;

                case 1:
                    result = Constans.Plane.WorldY;
                    result.Move(Constans.Vector3D.WorldY * value);
                    return result;

                case 2:
                    result = Constans.Plane.WorldZ;
                    result.Move(Constans.Vector3D.WorldZ * value);
                    return result;
            }

            return null;
        }
    }
}

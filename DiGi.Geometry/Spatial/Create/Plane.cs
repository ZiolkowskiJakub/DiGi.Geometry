using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        public static Plane? Plane(this Point3D? point3D_1, Point3D? point3D_2, Point3D? point3D_3)
        {
            if (point3D_1 == null || point3D_2 == null || point3D_3 == null)
            {
                return null;
            }

            Vector3D? normal = Query.Normal(point3D_1, point3D_2, point3D_3);
            if (normal == null)
            {
                return null;
            }

            return new Plane((new Point3D[] { point3D_1, point3D_2, point3D_3 }).Average(), normal);
        }

        public static Plane? Plane(this IEnumerable<Point3D>? point3Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            Vector3D? normal = Query.Normal(point3Ds, tolerance);
            if (normal == null)
            {
                return null;
            }

            return new Plane(point3Ds.Average(), normal);
        }

        public static Plane? Plane(Point3D? origin, Vector3D? axisX, Vector3D? axisY)
        {
            if (origin == null || axisX == null || axisY == null)
            {
                return null;
            }

            return new Plane(origin, axisX, axisY);
        }

        public static Plane? Plane(double elevation)
        {
            if (double.IsNaN(elevation))
            {
                return null;
            }

            Plane result = Constants.Plane.WorldZ;
            result.Move(Constants.Vector3D.WorldZ * elevation);

            return result;
        }

        public static Plane? Plane(Point3D? origin)
        {
            if (origin == null)
            {
                return null;
            }

            return new Plane(Constants.Plane.WorldZ, origin);
        }

        public static Plane? Plane(double value, int dimensionIndex)
        {
            Plane? result;
            switch (dimensionIndex)
            {
                case 0:
                    result = Constants.Plane.WorldX;
                    result.Move(Constants.Vector3D.WorldX * value);
                    return result;

                case 1:
                    result = Constants.Plane.WorldY;
                    result.Move(Constants.Vector3D.WorldY * value);
                    return result;

                case 2:
                    result = Constants.Plane.WorldZ;
                    result.Move(Constants.Vector3D.WorldZ * value);
                    return result;
            }

            return null;
        }
    }
}
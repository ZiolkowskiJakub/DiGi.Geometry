using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        public static Point3D Max(this IEnumerable<Point3D> point3Ds)
        {
            Max(point3Ds, out Point3D result);
            return result;
        }

        public static Point3D Max(this Point3D point3D_1, Point3D point3D_2)
        {
            if(point3D_1 == null || point3D_2 == null)
            {
                return null;
            }

            return Max(new Point3D[] { point3D_1, point3D_2 }, out Point3D max);
        }

        public static Point3D Max(this IEnumerable<Point3D> point3Ds, out Point3D min)
        {
            min = Min(point3Ds, out Point3D result);
            return result;
        }
    }

}

using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static Point2D Max(this IEnumerable<Point2D> point2Ds)
        {
            Min(point2Ds, out Point2D result);
            return result;
        }

        public static Point2D Max(this Point2D point2D_1, Point2D point2D_2)
        {
            if(point2D_1 == null || point2D_2 == null)
            {
                return null;
            }

            return Max(new Point2D[] { point2D_1, point2D_2 }, out Point2D max);
        }

        public static Point2D Max(this IEnumerable<Point2D> point2Ds, out Point2D min)
        {
            min = Min(point2Ds, out Point2D result);
            return result;
        }
    }

}

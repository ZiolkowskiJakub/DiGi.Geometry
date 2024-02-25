using DiGi.Core;
using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static bool AlmostEquals(this Point2D point2D_1, Point2D point2D_2, double tolerance = Constans.Tolerance.Distance)
        {
            if(point2D_1 == point2D_2)
            {
                return true;
            }

            if(point2D_1 == null || point2D_2 == null)
            {
                return false;
            }

            return point2D_1.Distance(point2D_2) <= tolerance;
        }
    }
}

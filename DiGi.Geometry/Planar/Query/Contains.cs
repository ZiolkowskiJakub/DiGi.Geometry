using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static bool Contains(this IEnumerable<Point2D> point2Ds, Point2D point2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point2Ds == null || point2D == null)
            {
                return false;
            }

            foreach (Point2D poin2D_Temp in point2Ds)
            {
                if (poin2D_Temp != null && AlmostEquals(poin2D_Temp, point2D, tolerance))
                {
                    return true;
                }
            }

            return false;
        }
    }
}

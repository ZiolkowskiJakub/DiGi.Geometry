using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static bool Collinear(this ILinear2D linear2D_1, ILinear2D linear2D_2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            Vector2D direction_1 = linear2D_1?.Direction;
            if(direction_1 == null)
            {
                return false;
            }

            Vector2D direction_2 = linear2D_2?.Direction;
            if (direction_2 == null)
            {
                return false;
            }

            return System.Math.Abs(System.Math.Abs(direction_1 * direction_2) - 1) <= tolerance;
        }
    }

}

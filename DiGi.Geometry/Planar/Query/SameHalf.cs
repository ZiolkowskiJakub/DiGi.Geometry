using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static bool SameHalf(this Vector2D? vector2D_1, Vector2D? vector2D_2, double tolerance = DiGi.Core.Constans.Tolerance.Angle)
        {
            if (vector2D_1 == null || vector2D_2 == null)
            {
                return false;
            }

            return vector2D_1.Angle(vector2D_2) - tolerance <= vector2D_1.Angle(vector2D_1.GetInversed());
        }
    }
}
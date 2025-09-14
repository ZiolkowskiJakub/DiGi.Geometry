using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static Vector2D? Bounce(this Vector2D? vector2D_ToBeBounced, Segment2D? segment2D, double friction = 1, double restitution = 1)
        {
            if (vector2D_ToBeBounced == null || segment2D == null)
            {
                return null;
            }

            return Bounce(vector2D_ToBeBounced, segment2D?.Direction?.GetPerpendicular(), friction, restitution);
        }

        public static Vector2D? Bounce(this Vector2D? vector2D_ToBeBounced, Vector2D? vector2D, double friction = 1, double restitution = 1)
        {
            Vector2D? vector2D_1 = vector2D_ToBeBounced?.Unit;
            if(vector2D_1 is null)
            {
                return null;
            }

            Vector2D? vector2D_2 = vector2D?.Unit;
            if (vector2D_2 is null)
            {
                return null;
            }

            Vector2D? vector2D_A = vector2D_1.DotProduct(vector2D_2) * vector2D_2;
            Vector2D? vector2D_B = vector2D_1 - vector2D_A;

            Vector2D? result = (friction * vector2D_B) - (restitution * vector2D_A);

            return result * vector2D_ToBeBounced!.Length;
        }
    }

}

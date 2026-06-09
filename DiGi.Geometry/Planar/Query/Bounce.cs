using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the bounce vector of a given <see cref="Vector2D"/> against a <see cref="Segment2D"/>, accounting for friction and restitution.
        /// </summary>
/// <param name="vector2D_ToBeBounced">The <c>Vector2D?</c> representing the velocity or direction to be bounced.</param>
/// <param name="segment2D">The <see cref="Segment2D"/> representing the surface to bounce off of.</param>
        /// <param name="friction">A <see cref="double"/> value representing the friction coefficient applied during the bounce.</param>
        /// <param name="restitution">A <see cref="double"/> value representing the restitution coefficient applied during the bounce.</param>
/// <returns>The resulting <c>Vector2D?</c> after the bounce calculation, or <see langword="null"/> if either the input vector or segment is <see langword="null"/>.</returns>
        public static Vector2D? Bounce(this Vector2D? vector2D_ToBeBounced, Segment2D? segment2D, double friction = 1, double restitution = 1)
        {
            if (vector2D_ToBeBounced == null || segment2D == null)
            {
                return null;
            }

            return Bounce(vector2D_ToBeBounced, segment2D?.Direction?.GetPerpendicular(), friction, restitution);
        }

        /// <summary>
        /// Calculates the reflection of a <see cref="Vector2D"/> against another <see cref="Vector2D"/>, applying friction and restitution coefficients.
        /// </summary>
        /// <param name="vector2D_ToBeBounced">The <see cref="Vector2D"/> that is to be bounced.</param>
        /// <param name="vector2D">The <see cref="Vector2D"/> representing the surface normal or reflection axis.</param>
        /// <param name="friction">A <see cref="double"/> value representing the friction coefficient applied to the tangential component of the bounce.</param>
        /// <param name="restitution">A <see cref="double"/> value representing the restitution coefficient applied to the normal component of the bounce.</param>
        /// <returns>The resulting bounced <see cref="Vector2D"/>, or <see langword="null"/> if either input vector is <see langword="null"/>.</returns>
        public static Vector2D? Bounce(this Vector2D? vector2D_ToBeBounced, Vector2D? vector2D, double friction = 1, double restitution = 1)
        {
            Vector2D? vector2D_1 = vector2D_ToBeBounced?.Unit;
            if (vector2D_1 is null)
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
using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Checks if two vectors point in the same general direction (half-plane) within a given tolerance.
        /// </summary>
        /// <param name="vector2D_1">The first vector.</param>
        /// <param name="vector2D_2">The second vector.</param>
        /// <param name="tolerance">The angle tolerance for the comparison.</param>
        /// <returns>True if vectors are in the same half-plane, otherwise false.</returns>
        public static bool SameHalf(this Vector2D? vector2D_1, Vector2D? vector2D_2, double tolerance = DiGi.Core.Constants.Tolerance.Angle)
        {
            if (vector2D_1 == null || vector2D_2 == null)
            {
                return false;
            }

            return vector2D_1.Angle(vector2D_2) - tolerance <= vector2D_1.Angle(vector2D_1.GetInversed());
        }
    }
}
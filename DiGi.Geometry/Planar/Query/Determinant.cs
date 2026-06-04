using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the determinant of three 2D points.
        /// </summary>
        /// <param name="point2D_1">The first <see cref="Point2D"/> point.</param>
        /// <param name="point2D_2">The second <see cref="Point2D"/> point.</param>
        /// <param name="point2D_3">The third <see cref="Point2D"/> point.</param>
        /// <returns>The calculated <see cref="double"/> determinant, or <see cref="double.NaN"/> if any of the provided points are null.</returns>
        public static double Determinant(this Point2D? point2D_1, Point2D? point2D_2, Point2D? point2D_3)
        {
            if (point2D_1 is null || point2D_2 is null || point2D_3 is null)
            {
                return double.NaN;
            }

            return (point2D_2.Y - point2D_1.Y) * (point2D_3.X - point2D_2.X) - (point2D_2.X - point2D_1.X) * (point2D_3.Y - point2D_2.Y);
        }

        /// <summary>
        /// Calculates the determinant of two 2D vectors.
        /// </summary>
        /// <param name="vector2D_1">The first <see cref="Vector2D"/> instance.</param>
        /// <param name="vector2D_2">The second <see cref="Vector2D"/> instance.</param>
        /// <returns>A <see cref="double"/> representing the determinant, or <see cref="double.NaN"/> if either <see cref="Vector2D"/> is null.</returns>
        public static double Determinant(this Vector2D? vector2D_1, Vector2D? vector2D_2)
        {
            if (vector2D_1 is null || vector2D_2 is null)
            {
                return double.NaN;
            }

            return (vector2D_1.X * vector2D_2.Y) - (vector2D_1.Y * vector2D_2.X);
        }
    }
}
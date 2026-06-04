using DiGi.Geometry.Planar.Classes;
using DiGi.Math.Classes;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether the specified <see cref="Point2D"/> is above the curve of the <see cref="PolynomialEquation"/>, considering a given tolerance.
        /// </summary>
        /// <param name="polynomialEquation">The <see cref="PolynomialEquation"/> to evaluate.</param>
        /// <param name="point2D">The <see cref="Point2D"/> to check against the equation.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the tolerance for the comparison. Defaults to 0.</param>
        /// <returns>A <see cref="bool"/> indicating whether the point is above the polynomial curve; returns false if either the <see cref="PolynomialEquation"/> or <see cref="Point2D"/> is null.</returns>
        public static bool Above(this PolynomialEquation? polynomialEquation, Point2D? point2D, double tolerance = 0)
        {
            if (polynomialEquation == null || point2D == null)
                return false;

            double y = polynomialEquation.Evaluate(point2D.X);

            return point2D.Y > y - tolerance;
        }
    }
}
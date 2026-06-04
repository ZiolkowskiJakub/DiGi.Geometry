using DiGi.Geometry.Planar.Classes;
using DiGi.Math.Classes;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Evaluates the specified <see cref="PolynomialEquation"/> at a given x-coordinate and returns the result as a <see cref="Point2D"/>.
        /// </summary>
        /// <param name="polynominalEquation">The <see cref="PolynomialEquation"/> instance to evaluate.</param>
        /// <param name="x">The double value representing the x-coordinate.</param>
        /// <returns>A <see cref="Point2D"/> containing the x and y coordinates if the evaluation is successful; otherwise, null if the <see cref="PolynomialEquation"/> is null or if either the input x or the resulting y value is NaN.</returns>
        public static Point2D? Evaluate(this PolynomialEquation? polynominalEquation, double x)
        {
            if (polynominalEquation == null || double.IsNaN(x))
            {
                return null;
            }

            double y = polynominalEquation.Evaluate(x);
            if (double.IsNaN(y))
            {
                return null;
            }

            return new Point2D(x, y);
        }
    }
}
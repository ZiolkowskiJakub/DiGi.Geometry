using DiGi.Geometry.Planar.Classes;
using DiGi.Math.Classes;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static bool Above(this PolynomialEquation polynomialEquation, Point2D point2D, double tolerance = 0)
        {
            if (polynomialEquation == null || point2D == null)
                return false;

            double y = polynomialEquation.Evaluate(point2D.X);

            return point2D.Y > y - tolerance;
        }
    }
}

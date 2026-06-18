using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the square thinness ratio of a polygonal geometry based on its bounding rectangle.
        /// </summary>
        /// <param name="polygonal2D">The polygonal 2D geometry to analyze.</param>
        /// <param name="tolerance">The distance tolerance used for creating the bounding rectangle.</param>
        /// <returns>The square thinness ratio, or <see cref="System.Double.NaN"/> if the input is null, the area is not a number, or the bounding rectangle cannot be created.</returns>
        public static double SquareThinnessRatio(this IPolygonal2D polygonal2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (polygonal2D == null)
            {
                return double.NaN;
            }

            double area = polygonal2D.GetArea();
            if (double.IsNaN(area))
            {
                return double.NaN;
            }

            if (Create.Rectangle2D(polygonal2D, tolerance) is not Rectangle2D rectangle2D)
            {
                return double.NaN;
            }

            double length = System.Math.Max(rectangle2D.Width, rectangle2D.Height);

            return Core.Query.RectangularThinnessRatio(area, length * length);
        }
    }
}

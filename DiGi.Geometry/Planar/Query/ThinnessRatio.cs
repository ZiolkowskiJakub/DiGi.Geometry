using DiGi.Geometry.Planar.Interfaces;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the thinness ratio of a polygonal geometry based on its area and perimeter.
        /// </summary>
        /// <param name="polygonal2D">The polygonal geometry for which to calculate the thinness ratio.</param>
        /// <returns>The calculated thinness ratio, or <see cref="double.NaN"/> if the input is null or if the area or perimeter cannot be determined.</returns>
        public static double ThinnessRatio(this IPolygonal2D polygonal2D)
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

            double perimeter = polygonal2D.GetPerimeter();
            if (double.IsNaN(perimeter))
            {
                return double.NaN;
            }

            return Core.Query.ThinnessRatio(area, perimeter);
        }
    }
}

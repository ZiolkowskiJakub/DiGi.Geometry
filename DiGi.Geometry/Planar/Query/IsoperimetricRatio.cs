using DiGi.Geometry.Planar.Interfaces;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the isoperimetric ratio of the specified <see cref="IPolygonal2D"/> object.
        /// </summary>
        /// <param name="polygonal2D">The <see cref="IPolygonal2D"/> instance to calculate the ratio for.</param>
        /// <returns>The calculated isoperimetric ratio as a <see cref="double"/>, or <see cref="double.NaN"/> if the <see cref="IPolygonal2D"/> object is null or if its area or perimeter is <see cref="double.NaN"/>.</returns>
        public static double IsoperimetricRatio(this IPolygonal2D polygonal2D)
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

            return Core.Query.IsoperimetricRatio(area, perimeter);
        }
    }
}
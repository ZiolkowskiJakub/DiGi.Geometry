using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the rectangularity of a polygonal geometry (ratio of its area to the area of its bounding rectangle).
        /// </summary>
        /// <param name="polygonal2D">The polygonal geometry.</param>
        /// <param name="tolerance">The distance tolerance for creating the bounding rectangle.</param>
        /// <returns>The rectangularity value, or NaN if calculation is not possible.</returns>
        public static double Rectangularity(this IPolygonal2D? polygonal2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (polygonal2D == null)
            {
                return double.NaN;
            }

            double area_Polygonal2D = polygonal2D.GetArea();
            if (area_Polygonal2D == 0 || double.IsNaN(area_Polygonal2D))
            {
                return double.NaN;
            }

            Rectangle2D? rectangle2D = Create.Rectangle2D(polygonal2D, tolerance);
            if (rectangle2D == null)
            {
                return double.NaN;
            }

            double area_Rectangle2D = rectangle2D.GetArea();
            if (area_Rectangle2D == 0 || double.IsNaN(area_Rectangle2D))
            {
                return double.NaN;
            }

            return area_Polygonal2D / area_Rectangle2D;
        }
    }
}
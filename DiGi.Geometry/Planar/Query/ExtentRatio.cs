using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the ratio of the area of a shape to the area of its minimum bounding rectangle. It quantifies how much of the bounding rectangle is occupied by the shape and is commonly used in image processing and spatial analysis to assess shape compactness.
        /// </summary>
        /// <param name="polygonal2D">Polygonal2D</param>
        /// <param name="tolerance">Tolerance</param>
        /// <returns>Extent ratio [-]</returns>
        public static double ExtentRatio(this IPolygonal2D polygonal2D, double tolerance = DiGi.Core.Constans.Tolerance.MicroDistance)
        {
            if (polygonal2D == null)
            {
                return double.NaN;
            }

            double area_Polygonal2D = polygonal2D.GetArea();
            if (double.IsNaN(area_Polygonal2D))
            {
                return double.NaN;
            }

            Rectangle2D rectangle2D = Create.Rectangle2D(polygonal2D, tolerance);
            if (rectangle2D == null)
            {
                return double.NaN;
            }

            double area_Rectangle2D = rectangle2D.GetArea();
            if (double.IsNaN(area_Rectangle2D) || DiGi.Core.Query.AlmostEquals(area_Rectangle2D, 0, tolerance))
            {
                return double.NaN;
            }

            return area_Polygonal2D / area_Rectangle2D;
        }
    }
}

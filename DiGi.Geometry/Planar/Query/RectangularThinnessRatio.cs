using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static double RectangularThinnessRatio(this IPolygonal2D polygonal2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
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

            return Core.Query.RectangularThinnessRatio(area, rectangle2D.GetArea());
        }
    }
}
using DiGi.Geometry.Planar.Interfaces;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static double RectangularThinnessRatio(this IPolygonal2D polygonal2D)
        {
            if(polygonal2D == null)
            {
                return double.NaN;
            }

            double area = polygonal2D.GetArea();
            if(double.IsNaN(area))
            {
                return double.NaN;
            }

            double perimeter = polygonal2D.GetPerimeter();
            if(double.IsNaN(perimeter))
            {
                return double.NaN;
            }

            return Core.Query.RectangularThinnessRatio(area, perimeter);
        }
    }
}

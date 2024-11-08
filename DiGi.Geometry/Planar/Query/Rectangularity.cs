using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static double Rectangularity(this IPolygonal2D polygonal2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(polygonal2D == null)
            {
                return double.NaN;
            }

            double area_Polygonal2D = polygonal2D.GetArea();
            if(area_Polygonal2D == 0 || double.IsNaN(area_Polygonal2D))
            {
                return double.NaN;
            }
            
            Rectangle2D rectangle2D = Create.Rectangle2D(polygonal2D, tolerance);
            if(rectangle2D == null)
            {
                return double.NaN;
            }

            double area_Rectangle2D = rectangle2D.GetArea();
            if(area_Rectangle2D == 0 || double.IsNaN(area_Rectangle2D))
            {
                return double.NaN;
            }

            return area_Polygonal2D / area_Rectangle2D;

        }
    }
}

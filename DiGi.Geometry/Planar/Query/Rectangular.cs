using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static bool Rectangular(this IPolygonal2D polygonal2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            return Rectangular(polygonal2D, out Rectangle2D rectangle2D, tolerance);
        }

        public static bool Rectangular(this IPolygonal2D polygonal2D, out Rectangle2D rectangle2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            rectangle2D = null;
            if(polygonal2D == null)
            {
                return false;
            }

            if(polygonal2D is Rectangle2D)
            {
                rectangle2D = new Rectangle2D((Rectangle2D)polygonal2D);
                return true;
            }

            if(polygonal2D is Triangle2D)
            {
                return false;
            }

            List<Point2D> point2Ds = polygonal2D.GetPoints();
            if(point2Ds == null || point2Ds.Count < 4)
            {
                return false;
            }

            rectangle2D = Create.Rectangle2D(point2Ds);
            if (rectangle2D == null)
            {
                return false;
            }

            bool result = System.Math.Abs(polygonal2D.GetArea() - rectangle2D.GetArea()) < tolerance;
            if (!result)
            {
                rectangle2D = null;
            }

            return result;
        }
    }
}

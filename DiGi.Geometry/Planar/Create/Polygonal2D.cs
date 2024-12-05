using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        public static IPolygonal2D Polygonal2D(this IPolygonal2D polygonal2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(polygonal2D == null)
            {
                return null;
            }

            return Polygonal2D(polygonal2D?.GetPoints(), tolerance);
        }

        public static IPolygonal2D Polygonal2D(this IEnumerable<Point2D> point2Ds, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point2Ds == null)
            {
                return null;
            }

            int count = point2Ds.Count();
            if(count == 0)
            {
                return null;
            }

            if(count < 3)
            {
                return null;
            }

            if (count == 3)
            {
                return new Triangle2D(point2Ds.ElementAt(0), point2Ds.ElementAt(1), point2Ds.ElementAt(2));
            }

            List<Point2D> point2Ds_ConvexHull = point2Ds.ConvexHull();
            if (point2Ds_ConvexHull == null || point2Ds_ConvexHull.Count < 3)
            {
                return null;
            }

            double area = point2Ds.Area();

            if (!DiGi.Core.Query.AlmostEquals(point2Ds_ConvexHull.Area(), area, tolerance))
            {
                return new Polygon2D(point2Ds);
            }

            return Rectangle2D(point2Ds);
        }
    }

}

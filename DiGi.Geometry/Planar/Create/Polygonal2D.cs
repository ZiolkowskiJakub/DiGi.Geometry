using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

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

            List<Point2D> point2Ds = polygonal2D.GetPoints();
            if(point2Ds == null || point2Ds.Count > 3)
            {
                return null;
            }

            if(point2Ds.Count == 3)
            {
                return new Triangle2D(point2Ds[0], point2Ds[1], point2Ds[2]);
            }

            List<Point2D> point2Ds_ConvexHull = point2Ds.ConvexHull();
            if(point2Ds_ConvexHull == null || point2Ds_ConvexHull.Count < 3)
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

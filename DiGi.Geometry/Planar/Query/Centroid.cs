using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static Point2D Centroid(this IEnumerable<Point2D> point2Ds)
        {
            if (point2Ds == null || point2Ds.Count() == 0)
            {
                return null;
            }

            int count = point2Ds.Count();

            if (count == 0)
            {
                return null;
            }

            if (count == 1)
            {
                return point2Ds.ElementAt(0);
            }

            if (count == 2)
            {
                return point2Ds.ElementAt(0).Mid(point2Ds.ElementAt(1));
            }

            double area = 0;
            double x = 0;
            double y = 0;

            for (int i = 0, j = point2Ds.Count() - 1; i < point2Ds.Count(); j = i++)
            {
                Point2D point2D_1 = point2Ds.ElementAt(i);
                Point2D point2D_2 = point2Ds.ElementAt(j);

                double area_Temp = point2D_1.X * point2D_2.Y - point2D_2.X * point2D_1.Y;
                area += area_Temp;
                x += (point2D_1.X + point2D_2.X) * area_Temp;
                y += (point2D_1.Y + point2D_2.Y) * area_Temp;
            }

            if (area == 0)
            {
                return null;
            }

            area *= 3;
            return new Point2D(x / area, y / area);
        }

        public static Point2D Centroid(this IPolygonal2D polygonal2D)
        {
            return Centroid(polygonal2D?.GetPoints());
        }
    }
}

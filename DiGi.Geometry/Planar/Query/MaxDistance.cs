using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static double MaxDistance(this IEnumerable<Point2D> point2Ds, out Point2D point2D_1, out Point2D point2D_2)
        {
            point2D_1 = null;
            point2D_2 = null;

            if (point2Ds == null)
            {
                return double.NaN;
            }

            int count = point2Ds.Count();
            if(count == 0)
            {
                return double.NaN;
            }

            if(count == 1)
            {
                point2D_1 = point2Ds.ElementAt(0);
                point2D_2 = point2D_1;
                return 0;
            }

            double result = double.MinValue;
            for (int i = 0; i < count - 1; i++)
            {
                Point2D point2D_Temp_1 = point2Ds.ElementAt(i);
                for (int j = i + 1; j < count; j++)
                {
                    Point2D point2D_Temp_2 = point2Ds.ElementAt(j);
                    double distance_Temp = point2D_Temp_1.Distance(point2D_Temp_2);
                    if (distance_Temp > result)
                    {
                        result = distance_Temp;
                        point2D_1 = point2D_Temp_1;
                        point2D_2 = point2D_Temp_2;
                    }
                }
            }

            if(result == double.MinValue)
            {
                result = double.NaN;
            }

            return result;
        }
    }

}

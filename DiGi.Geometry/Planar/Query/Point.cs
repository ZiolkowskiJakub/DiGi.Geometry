using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static Point2D Point(this IEnumerable<Point2D> point2Ds, double parameter)
        {
            if(point2Ds == null || double.IsNaN(parameter))
            {
                return null;
            }

            int count = point2Ds.Count();
            if(count < 2)
            {
                return null;
            }

            List<double> lengths = new List<double>();
            double length = 0;
            for (int i = 1; i < count; i++)
            {
                Point2D point2D_1 = point2Ds.ElementAt(i - 1);
                Point2D point2D_2 = point2Ds.ElementAt(i);

                if (point2D_1 == null || point2D_2 == null)
                {
                    lengths.Add(0);
                    continue;
                }

                double distance = point2D_1.Distance(point2D_2);
                lengths.Add(distance);
                length += distance;
            }

            double value = length * parameter;

            Point2D result = null;

            int index = 0;
            while(value > 0)
            {
                double value_Temp = value - lengths[index];
                if(value_Temp > 0)
                {
                    value = value_Temp;
                    index++;
                    if(index >= lengths.Count)
                    {
                        index = 0;
                    }
                    continue;
                }

                Point2D point2D_1 = point2Ds.ElementAt(index);
                Point2D point2D_2 = point2Ds.ElementAt(index + 1);

                Vector2D vector2D = new Vector2D(point2D_1, point2D_2);
                vector2D.Length = value;
                
                result = new Point2D(point2D_1);
                result.Move(vector2D);

                value = value_Temp;
            }

            return result;

        }
    }
}

using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static double Parameter(this IEnumerable<Point2D> point2Ds, Point2D point2D, out Point2D point2D_Closest, out double distance)
        {
            point2D_Closest = null;
            distance = double.NaN;

            int count = point2Ds.Count();

            if (point2Ds == null || point2D == null || count < 2)
            {
                return double.NaN;
            }

            distance = double.MaxValue;
            int index = -1;

            List<double> lengths = new List<double>();
            for (int i = 1; i < count; i++)
            {
                Point2D point2D_1 = point2Ds.ElementAt(i - 1);
                Point2D point2D_2 = point2Ds.ElementAt(i);

                if(point2D_1 == null || point2D_2 == null)
                {
                    lengths.Add(0);
                    continue;
                }

                lengths.Add(point2D_1.Distance(point2D_2));

                Point2D point2D_Closest_Temp = ClosestPoint(point2D, point2D_1, point2D_2, true);
                if(point2D_Closest_Temp == null)
                {
                    continue;
                }

                double distance_Temp = point2D.Distance(point2D_Closest_Temp);
                if(distance < distance_Temp )
                {
                    continue;
                }

                distance = distance_Temp;
                point2D_Closest = point2D_Closest_Temp;
                index = i;
            }

            if(distance == double.MaxValue || index == -1 || point2D_Closest == null)
            {
                point2D_Closest = null;
                distance = double.NaN;
                return double.NaN;
            }

            double length = 0;
            for (int i = 0; i < index - 1; i++)
            {
                length += lengths[i];
            }

            length += point2Ds.ElementAt(index - 1).Distance(point2D_Closest);

            return length / lengths.Sum();

        }

        public static double Parameter(this IEnumerable<Point2D> point2Ds, Point2D point2D)
        {
            if(point2Ds == null || point2D == null)
            {
                return double.NaN;
            }

            return Parameter(point2Ds, point2D, out Point2D point2D_Closest, out double distance);
        }
    }
}

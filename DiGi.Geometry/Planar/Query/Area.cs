using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static double Area(this IEnumerable<Point2D> point2Ds)
        {
            if (point2Ds == null)
            {
                return double.NaN;
            }

            List<Point2D> point2Ds_Temp = [.. point2Ds];
            if (point2Ds_Temp.FindIndex(x => x == null) != -1)
            {
                return double.NaN;
            }

            int count = point2Ds_Temp.Count;

            if (count < 3)
            {
                return 0;
            }

            double sum = 0;
            for (int i = 0; i < count; i++)
            {
                Point2D current = point2Ds_Temp[i];
                Point2D next = point2Ds_Temp[(i + 1) % count];

                sum += (current.X * next.Y) - (next.X * current.Y);
            }

            return System.Math.Abs(sum) * 0.5;
        }
    }
}

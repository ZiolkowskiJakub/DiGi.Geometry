using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static Point2D Min(this IEnumerable<Point2D> point2Ds)
        {
            return Min(point2Ds, out Point2D max);
        }

        public static Point2D Min(this Point2D point2D_1, Point2D point2D_2)
        {
            if(point2D_1 == null || point2D_2 == null)
            {
                return null;
            }

            return Min(new Point2D[] { point2D_1, point2D_2 }, out Point2D max);
        }

        public static Point2D Min(this IEnumerable<Point2D> point2Ds, out Point2D max)
        {
            max = null;
            if(point2Ds == null || point2Ds.Count() == 0)
            {
                return null;
            }
            
            double x_Min = double.MaxValue;
            double x_Max = double.MinValue;
            double y_Min = double.MaxValue;
            double y_Max = double.MinValue;
            foreach (Point2D point2D in point2Ds)
            {
                if(point2D == null)
                {
                    continue;
                }

                if (point2D.X > x_Max)
                {
                    x_Max = point2D.X;
                }

                if (point2D.X < x_Min)
                {
                    x_Min = point2D.X;
                }

                if (point2D.Y > y_Max)
                {
                    y_Max = point2D.Y;
                }

                if (point2D.Y < y_Min)
                {
                    y_Min = point2D.Y;
                }
            }

            if(x_Min == double.MaxValue || x_Max == double.MinValue || y_Min == double.MaxValue || y_Max == double.MinValue)
            {
                return null;
            }

            max = new Point2D(x_Max, y_Max);
            return new Point2D(x_Min, y_Min);
        }
    }

}

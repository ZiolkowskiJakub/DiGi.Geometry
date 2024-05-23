using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static bool Collinear(this ILinear2D linear2D_1, ILinear2D linear2D_2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            Vector2D direction_1 = linear2D_1?.Direction;
            if(direction_1 == null)
            {
                return false;
            }

            Vector2D direction_2 = linear2D_2?.Direction;
            if (direction_2 == null)
            {
                return false;
            }

            return System.Math.Abs(System.Math.Abs(direction_1 * direction_2) - 1) <= tolerance;
        }

        public static bool Collinear(this IEnumerable<Point2D> point2Ds, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(point2Ds == null)
            {
                return false;
            }

            List<Point2D> point2Ds_Temp = new List<Point2D>();
            foreach(Point2D point2D in point2Ds)
            {
                if(point2D == null)
                {
                    continue;
                }

                point2Ds_Temp.Add(point2D);
            }


            int count = point2Ds_Temp.Count();

            if(count < 2)
            {
                return false;
            }

            if(count == 2)
            {
                return true;
            }

            Vector2D direction_1 = new Vector2D(point2Ds_Temp[0], point2Ds_Temp[1]).Unit;

            for (int i = 1; i < count - 1; i++)
            {
                Vector2D direction_2 = new Vector2D(point2Ds_Temp[i], point2Ds_Temp[i + 1]).Unit;

                if(System.Math.Abs(System.Math.Abs(direction_1 * direction_2) - 1) > tolerance)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool Collinear(this Point2D point2D_1, Point2D point2D_2, Point2D point2D_3, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point2D_1 == null || point2D_2 == null || point2D_3 == null)
            {
                return false;
            }

            return Collinear(new Point2D[] { point2D_1, point2D_2, point2D_3 }, tolerance);
        }
    }

}

using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static bool Inside(this IEnumerable<Point2D> point2Ds, Point2D point2D)
        {
            if (point2Ds == null || point2D == null)
            {
                return false;
            }

            int count = point2Ds.Count();

            if (count < 3)
            {
                return false;
            }

            bool result = false;

            int j = count - 1;
            for (int i = 0; i < count; i++)
            {
                Point2D point2D_1 = point2Ds.ElementAt(i);
                Point2D point2D_2 = point2Ds.ElementAt(j);

                if (point2D_1.Y < point2D.Y && point2D_2.Y >= point2D.Y || point2D_2.Y < point2D.Y && point2D_1.Y >= point2D.Y)
                {
                    if (point2D_1.X + (point2D.Y - point2D_1.Y) / (point2D_2.Y - point2D_1.Y) * (point2D_2.X - point2D_1.X) < point2D.X)
                    {
                        result = !result;
                    }
                }
                j = i;
            }

            return result;
        }
    }
}

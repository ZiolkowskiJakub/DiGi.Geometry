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

            if(count == 3)
            {
                return Inside(point2D, point2Ds.ElementAt(0), point2Ds.ElementAt(1), point2Ds.ElementAt(2));
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

        /// <summary>
        /// Checks if point is inside tree points (triangle)
        /// </summary>
        /// <param name="point2D">Point to be checked</param>
        /// <param name="point2D_1">Triangle point 1</param>
        /// <param name="point2D_2">Triangle point 2</param>
        /// <param name="point2D_3">Triangle point 3</param>
        /// <returns>True in point2D is inside triangle created by trheer points (point2D_1, point2D_2, point2D_3)</returns>
        public static bool Inside(this Point2D point2D, Point2D point2D_1, Point2D point2D_2, Point2D point2D_3)
        {
            // Compute vectors
            double v0x = point2D_3.X - point2D_1.X, v0y = point2D_3.Y - point2D_1.Y;
            double v1x = point2D_2.X - point2D_1.X, v1y = point2D_2.Y - point2D_1.Y;
            double v2x = point2D.X - point2D_1.X, v2y = point2D.Y - point2D_1.Y;

            // Compute dot products
            double dot00 = v0x * v0x + v0y * v0y;
            double dot01 = v0x * v1x + v0y * v1y;
            double dot02 = v0x * v2x + v0y * v2y;
            double dot11 = v1x * v1x + v1y * v1y;
            double dot12 = v1x * v2x + v1y * v2y;

            // Compute barycentric coordinates
            double denom = dot00 * dot11 - dot01 * dot01;
            double u = (dot11 * dot02 - dot01 * dot12) / denom;
            double v = (dot00 * dot12 - dot01 * dot02) / denom;

            // Check if point is inside triangle
            return (u >= 0) && (v >= 0) && (u + v <= 1);
        }
    }
}

using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the average position of a collection of <see cref="Point2D"/> objects.
        /// </summary>
        /// <param name="point2Ds">The <see cref="IEnumerable{Point2D}"/> of points to average.</param>
        /// <returns>A <see cref="Point2D"/> representing the average coordinates, or <c>null</c> if the <see cref="IEnumerable{Point2D}"/> is null or empty.</returns>
        public static Point2D? Average(this IEnumerable<Point2D>? point2Ds)
        {
            if (point2Ds == null)
            {
                return null;
            }

            int count = 0;
            double x = 0;
            double y = 0;

            foreach (Point2D point2D in point2Ds)
            {
                if (point2D == null)
                {
                    continue;
                }
                count++;
                x += point2D.X;
                y += point2D.Y;
            }

            if (count == 0)
            {
                return null;
            }

            return new Point2D(x / count, y / count);
        }
    }
}
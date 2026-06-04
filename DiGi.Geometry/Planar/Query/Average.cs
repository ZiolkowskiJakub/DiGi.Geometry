using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;
using System.Linq;

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
            if (point2Ds == null || point2Ds.Count() == 0)
            {
                return null;
            }

            int count = 0;

            double x = 0;
            double y = 0;
            foreach (Point2D point2D in point2Ds)
            {
                count++;
                x += point2D.X;
                y += point2D.Y;
            }

            return new Point2D(x / count, y / count);
        }
    }
}
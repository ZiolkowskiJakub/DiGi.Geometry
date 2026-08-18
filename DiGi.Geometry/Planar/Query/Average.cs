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

            if (point2Ds is IReadOnlyList<Point2D> point2Ds_List)
            {
                int count_List = point2Ds_List.Count;
                if (count_List == 0)
                {
                    return null;
                }

                int count_Valid = 0;
                double x_Sum = 0;
                double y_Sum = 0;

                for (int i = 0; i < count_List; i++)
                {
                    Point2D point2D = point2Ds_List[i];
                    if (point2D == null)
                    {
                        continue;
                    }

                    count_Valid++;
                    x_Sum += point2D.X;
                    y_Sum += point2D.Y;
                }

                if (count_Valid == 0)
                {
                    return null;
                }

                return new(x_Sum / count_Valid, y_Sum / count_Valid);
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

            return new(x / count, y / count);
        }
    }
}
using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the area of a polygon defined by a collection of <see cref="Point2D"/> points.
        /// </summary>
        /// <param name="point2Ds">An <see cref="IEnumerable{T}"/> of <see cref="Point2D"/> objects representing the vertices of the polygon.</param>
        /// <returns>The calculated area as a <see cref="double"/>. Returns <see cref="double.NaN"/> if the <see cref="IEnumerable{T}"/> is null or contains any null elements; returns 0 if there are fewer than three points.</returns>
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
            for (int i = 0; i < count - 1; i++)
            {
                Point2D current = point2Ds_Temp[i];
                Point2D next = point2Ds_Temp[i + 1];

                sum += (current.X * next.Y) - (next.X * current.Y);
            }

            // Handle the closing edge separately to eliminate modulo division in the loop
            Point2D last = point2Ds_Temp[count - 1];
            Point2D first = point2Ds_Temp[0];
            sum += (last.X * first.Y) - (first.X * last.Y);

            return System.Math.Abs(sum) * 0.5;
        }
    }
}
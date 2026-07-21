using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the minimum distance between any two points in the provided collection of <see cref="Point2D"/> objects.
        /// </summary>
        /// <param name="point2Ds">An <c>IEnumerable&lt;Point2D&gt;</c> containing the points to evaluate.</param>
        /// <returns>A <see cref="double"/> representing the minimum distance found, or <see cref="double.NaN"/> if the collection is null or empty.</returns>
        public static double MinDistance(this IEnumerable<Point2D>? point2Ds)
        {
            return MinDistance(point2Ds, out _, out _);
        }

        /// <summary>
        /// Calculates the minimum distance between any two points in a collection of <see cref="Point2D"/> objects.
        /// </summary>
        /// <param name="point2Ds">The <see cref="IEnumerable{T}"/> of <see cref="Point2D"/> objects to analyze.</param>
        /// <param name="point2D_1">When this method returns, contains the first <see cref="Point2D"/> of the pair with the minimum distance; otherwise, null.</param>
        /// <param name="point2D_2">When this method returns, contains the second <see cref="Point2D"/> of the pair with the minimum distance; otherwise, null.</param>
        /// <returns>The minimum distance as a <see cref="double"/>. Returns <see cref="double.NaN"/> if the collection is null or empty.</returns>
        public static double MinDistance(this IEnumerable<Point2D>? point2Ds, out Point2D? point2D_1, out Point2D? point2D_2)
        {
            point2D_1 = null;
            point2D_2 = null;

            if (point2Ds == null)
            {
                return double.NaN;
            }

            Point2D[] point2Ds_Local = point2Ds as Point2D[] ?? [.. point2Ds];
            int count = point2Ds_Local.Length;
            if (count == 0)
            {
                return double.NaN;
            }

            if (count == 1)
            {
                point2D_1 = point2Ds_Local[0];
                point2D_2 = point2D_1;
                return 0;
            }

            double resultSq = double.MaxValue;
            for (int i = 0; i < count - 1; i++)
            {
                Point2D point2D_Temp_1 = point2Ds_Local[i];
                if (point2D_Temp_1 == null)
                {
                    continue;
                }

                for (int j = i + 1; j < count; j++)
                {
                    Point2D point2D_Temp_2 = point2Ds_Local[j];
                    if (point2D_Temp_2 == null)
                    {
                        continue;
                    }

                    double dx = point2D_Temp_1.X - point2D_Temp_2.X;
                    double dy = point2D_Temp_1.Y - point2D_Temp_2.Y;
                    double distanceSq = dx * dx + dy * dy;
                    if (distanceSq < resultSq)
                    {
                        resultSq = distanceSq;
                        point2D_1 = point2D_Temp_1;
                        point2D_2 = point2D_Temp_2;
                    }
                }
            }

            if (resultSq == double.MaxValue)
            {
                return double.NaN;
            }

            return System.Math.Sqrt(resultSq);
        }
    }
}
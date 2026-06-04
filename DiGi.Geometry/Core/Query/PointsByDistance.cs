using DiGi.Geometry.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Filters a collection of points to find those within a specified distance from a given point.
        /// </summary>
        /// <typeparam name="T">The type of point, which must implement <see cref="IPoint{T}"/>.</typeparam>
        /// <param name="points">An <see cref="IEnumerable{T}"/> containing the points to evaluate.</param>
        /// <param name="point">The reference point used for distance comparison.</param>
        /// <param name="tolerance">A <see cref="double"/> representing the maximum allowable distance between points.</param>
        /// <returns>A <see cref="List{T}"/> of points within the specified tolerance, or <c>null</c> if either the source collection or the reference point is <c>null</c>.</returns>
        public static List<T>? PointsByDistance<T>(this IEnumerable<T>? points, T? point, double tolerance = DiGi.Core.Constants.Tolerance.Distance) where T : IPoint<T>
        {
            if (points == null || point == null)
            {
                return null;
            }

            List<T> result = [];
            foreach (T point_Temp in points)
            {
                if (point_Temp == null)
                {
                    continue;
                }

                if (point.Distance(point_Temp) <= tolerance)
                {
                    result.Add(point_Temp);
                }
            }
            return result;
        }
    }
}
using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether the collection of <see cref="Point2D"/> objects contains a specific <see cref="Point2D"/> within the specified tolerance.
        /// </summary>
        /// <param name="point2Ds">The <see cref="IEnumerable{T}"/> of <see cref="Point2D"/> objects to search.</param>
        /// <param name="point2D">The <see cref="Point2D"/> object to locate in the collection.</param>
        /// <param name="tolerance">The <see cref="double"/> value representing the distance tolerance for equality comparison.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the specified <see cref="Point2D"/> was found within the given tolerance; otherwise, false.</returns>
        public static bool Contains(this IEnumerable<Point2D> point2Ds, Point2D point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point2Ds == null || point2D == null)
            {
                return false;
            }

            foreach (Point2D poin2D_Temp in point2Ds)
            {
                if (poin2D_Temp != null && AlmostEquals(poin2D_Temp, point2D, tolerance))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
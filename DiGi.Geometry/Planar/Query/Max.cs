using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Returns the maximum <see cref="Point2D"/> from the specified collection.
        /// </summary>
/// <param name="point2Ds">The <c>IEnumerable&lt;Point2D&gt;</c> collection to evaluate.</param>
/// <returns>The maximum <see cref="Point2D"/> found in the collection, or null if the collection is null or empty.</returns>
        public static Point2D? Max(this IEnumerable<Point2D>? point2Ds)
        {
            Min(point2Ds, out Point2D? result);
            return result;
        }

        /// <summary>
/// Returns the maximum of two <c>Point2D?</c> values.
        /// </summary>
/// <param name="point2D_1">The first <c>Point2D?</c> value to compare.</param>
/// <param name="point2D_2">The second <c>Point2D?</c> value to compare.</param>
/// <returns>The maximum of the two <c>Point2D?</c> values, or <c>null</c> if either input is <c>null</c>.</returns>
        public static Point2D? Max(this Point2D? point2D_1, Point2D? point2D_2)
        {
            if (point2D_1 == null || point2D_2 == null)
            {
                return null;
            }

            return Max([point2D_1, point2D_2], out _);
        }

        /// <summary>
        /// Returns the maximum <see cref="Point2D"/> from the specified collection, while also retrieving the minimum <see cref="Point2D"/>.
        /// </summary>
        /// <param name="point2Ds">The <see cref="IEnumerable{T}"/> of <see cref="Point2D"/> objects to evaluate.</param>
        /// <param name="min">When this method returns, contains the <see cref="Point2D"/> with the minimum value, or null if the collection is empty.</param>
        /// <returns>The <see cref="Point2D"/> with the maximum value, or null if the collection is empty.</returns>
        public static Point2D? Max(this IEnumerable<Point2D>? point2Ds, out Point2D? min)
        {
            min = Min(point2Ds, out Point2D? result);
            return result;
        }
    }
}
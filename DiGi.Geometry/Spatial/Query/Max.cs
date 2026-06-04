using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Returns the maximum <see cref="Point3D"/> from the specified collection of nullable <see cref="Point3D"/> objects.
        /// </summary>
        /// <param name="point3Ds">The <see cref="IEnumerable{T}"/> of nullable <see cref="Point3D"/> objects to evaluate.</param>
        /// <returns>The maximum <see cref="Point3D"/> found in the collection, or null if the collection is null or empty.</returns>
        public static Point3D? Max(this IEnumerable<Point3D?>? point3Ds)
        {
            Max(point3Ds, out Point3D? result);
            return result;
        }

        /// <summary>
        /// Returns the maximum of two <see cref="Point3D?" /> points.
        /// </summary>
        /// <param name="point3D_1">The first <see cref="Point3D?" /> point to compare.</param>
        /// <param name="point3D_2">The second <see cref="Point3D?" /> point to compare.</param>
        /// <returns>The maximum of the two <see cref="Point3D?" /> points, or <c>null</c> if either input is <c>null</c>.</returns>
        public static Point3D? Max(this Point3D? point3D_1, Point3D? point3D_2)
        {
            if (point3D_1 == null || point3D_2 == null)
            {
                return null;
            }

            return Max([point3D_1, point3D_2], out _);
        }

        /// <summary>
        /// Returns the maximum <Point3D?> from the specified collection of <Point3D?> objects and outputs the minimum <Point3D?>.
        /// </summary>
        /// <param name="point3Ds">The <IEnumerable<Point3D?>?> collection to evaluate.</param>
        /// <param name="min">When this method returns, contains the minimum <Point3D?> found in the collection, if any.</param>
        /// <returns>The maximum <Point3D?> found in the collection, or null if the collection is null or empty.</returns>
        public static Point3D? Max(this IEnumerable<Point3D?>? point3Ds, out Point3D? min)
        {
            min = Min(point3Ds, out Point3D? result);
            return result;
        }
    }
}
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
        /// Returns the maximum of two <c>Point3D?</c> points.
        /// </summary>
        /// <param name="point3D_1">The first <c>Point3D?</c> point to compare.</param>
        /// <param name="point3D_2">The second <c>Point3D?</c> point to compare.</param>
        /// <returns>The maximum of the two <c>Point3D?</c> points, or <c>null</c> if either input is <c>null</c>.</returns>
        public static Point3D? Max(this Point3D? point3D_1, Point3D? point3D_2)
        {
            if (point3D_1 == null || point3D_2 == null)
            {
                return null;
            }

            return Max([point3D_1, point3D_2], out _);
        }

        /// <summary>
        /// Returns the maximum <c>Point3D?</c> from the specified collection of <c>Point3D?</c> objects and outputs the minimum <c>Point3D?</c>.
        /// </summary>
        /// <param name="point3Ds">The <c>IEnumerable&lt;Point3D?&gt;?</c> collection to evaluate.</param>
        /// <param name="min">When this method returns, contains the minimum Point3D? found in the collection, if any.</param>
        /// <returns>The maximum <see cref="Point3D"/> found in the collection, or null if the collection is null or empty.</returns>
        public static Point3D? Max(this IEnumerable<Point3D?>? point3Ds, out Point3D? min)
        {
            min = Min(point3Ds, out Point3D? result);
            return result;
        }
    }
}
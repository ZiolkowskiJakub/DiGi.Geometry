using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Checks that a point is non-null and carries finite X, Y and Z values.
        /// </summary>
        /// <param name="point3D">The point to check.</param>
        /// <returns><see langword="true"/> when the point is non-null and finite; otherwise, <see langword="false"/>.</returns>
        public static bool IsValid(this Point3D? point3D)
        {
            if (point3D is null)
            {
                return false;
            }

            double x = point3D.X;
            double y = point3D.Y;
            double z = point3D.Z;

            return !double.IsNaN(x) && !double.IsInfinity(x) && !double.IsNaN(y) && !double.IsInfinity(y) && !double.IsNaN(z) && !double.IsInfinity(z);
        }

        /// <summary>
        /// Checks that every point in the collection is non-null and carries finite X, Y and Z values.
        /// </summary>
        /// <param name="point3Ds">The collection of points to check.</param>
        /// <returns><see langword="true"/> when all points are valid; otherwise, <see langword="false"/>.</returns>
        public static bool IsValid(this IEnumerable<Point3D>? point3Ds)
        {
            if (point3Ds == null)
            {
                return false;
            }

            foreach (Point3D point3D in point3Ds)
            {
                if (!point3D.IsValid())
                {
                    return false;
                }
            }

            return true;
        }
    }
}

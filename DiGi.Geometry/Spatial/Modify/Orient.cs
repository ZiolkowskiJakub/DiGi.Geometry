using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Geometry.Spatial
{
    public static partial class Modify
    {
        /// <summary>
        /// Orients the specified <see cref="IPolygonal3D"/> to a target orientation, inverting it if necessary.
        /// </summary>
        /// <param name="polygonal3D">The <see cref="IPolygonal3D"/> instance to orient.</param>
        /// <param name="orientation">The target <see cref="Orientation"/> to achieve.</param>
        /// <param name="convexHull">A <see cref="bool"/> value indicating whether the convex hull should be used to determine the current orientation. Defaults to true.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the orientation of the <see cref="IPolygonal3D"/> was changed.</returns>
        public static bool Orient(this IPolygonal3D? polygonal3D, Orientation orientation, bool convexHull = true)
        {
            if (polygonal3D == null || orientation == Orientation.Undefined || orientation == Orientation.Collinear)
            {
                return false;
            }

            Orientation orientation_Temp = polygonal3D.Orientation(convexHull);
            if (orientation_Temp == orientation)
            {
                return false;
            }

            polygonal3D.Inverse();
            return true;
        }
    }
}
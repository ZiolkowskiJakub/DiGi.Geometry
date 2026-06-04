using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether a specified <see cref="Point3D"/> is located above a <see cref="Plane"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> to check against.</param>
        /// <param name="point3D">The <see cref="Point3D"/> to evaluate.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the point is above the plane beyond the specified tolerance; otherwise, false.</returns>
        public static bool Above(this Plane? plane, Point3D? point3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point3D == null)
            {
                return false;
            }

            Vector3D? normal = plane?.Normal;
            if (normal == null)
            {
                return false;
            }

            Point3D? origin = plane!.Origin;
            if (origin == null)
            {
                return false;
            }

            return (normal.X * (point3D.X - origin.X)) + (normal.Y * (point3D.Y - origin.Y)) + (normal.Z * (point3D.Z - origin.Z)) > 0 + tolerance;
        }

        /// <summary>
        /// Determines whether the specified <see cref="IPolygonal3D"/> is above the <see cref="Plane"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> to check against.</param>
        /// <param name="polygonal3D">The <see cref="IPolygonal3D"/> object to evaluate.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance for the calculation.</param>
        /// <returns>A <see cref="bool"/> value indicating whether all points of the <see cref="IPolygonal3D"/> are above the <see cref="Plane"/> within the specified <see cref="double"/> tolerance; otherwise, <c>false</c>.</returns>
        public static bool Above(this Plane? plane, IPolygonal3D? polygonal3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (plane == null || polygonal3D?.GetPoints() is not List<Point3D> point3Ds)
            {
                return false;
            }

            return point3Ds.All(x => plane.Above(x, tolerance));
        }
    }
}
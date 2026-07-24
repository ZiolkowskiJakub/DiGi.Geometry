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
            if (point3D == null || plane == null)
            {
                return false;
            }

            double double_A = plane.A;
            double double_B = plane.B;
            double double_C = plane.C;
            double double_D = plane.D;

            if (double.IsNaN(double_A) || double.IsNaN(double_B) || double.IsNaN(double_C) || double.IsNaN(double_D))
            {
                return false;
            }

            return (double_A * point3D.X + double_B * point3D.Y + double_C * point3D.Z + double_D) > tolerance;
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

            double double_A = plane.A;
            double double_B = plane.B;
            double double_C = plane.C;
            double double_D = plane.D;

            if (double.IsNaN(double_A) || double.IsNaN(double_B) || double.IsNaN(double_C) || double.IsNaN(double_D))
            {
                return false;
            }

            for (int int_I = 0; int_I < point3Ds.Count; int_I++)
            {
                Point3D point3D_Temp = point3Ds[int_I];
                if (point3D_Temp == null || (double_A * point3D_Temp.X + double_B * point3D_Temp.Y + double_C * point3D_Temp.Z + double_D) <= tolerance)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
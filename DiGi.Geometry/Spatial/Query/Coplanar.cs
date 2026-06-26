using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether a collection of <see cref="Point3D"/> points are coplanar within a specified tolerance.
        /// </summary>
        /// <param name="point3Ds">The <see cref="IEnumerable{Point3D}"/> of points to evaluate.</param>
        /// <param name="tolerance">The <see cref="double"/> distance tolerance used to determine if the points lie on the same plane.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the points are coplanar; returns <c>false</c> if the collection is null.</returns>
        public static bool Coplanar(this IEnumerable<Point3D>? point3Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            // Inspired by BHoM

            if (point3Ds == null)
            {
                return false;
            }

            Point3D[] point3Ds_Local = point3Ds as Point3D[] ?? point3Ds.ToArray();
            int count = point3Ds_Local.Length;

            if (count < 4)
            {
                return true;
            }

            Point3D point3D_Origin = point3Ds_Local[0];
            List<Vector3D> vector3Ds_Directions = new();
            for (int i = 0; i < count - 1; i++)
            {
                Point3D point3D_Target = point3Ds_Local[i + 1];
                if (point3D_Origin != null && point3D_Target != null)
                {
                    vector3Ds_Directions.Add(new Vector3D(point3D_Origin, point3D_Target));
                }
            }

            Math.Classes.Matrix? matrix = Create.Matrix(vector3Ds_Directions);
            if (matrix == null)
            {
                return false;
            }

            double tolerance_REF = matrix.REFTolerance(tolerance);
            Math.Classes.Matrix? matrix_REF = matrix.RowEchelonForm(true, tolerance_REF);
            if (matrix_REF is null)
            {
                return false;
            }

            int nonZeroRows = matrix_REF.CountNonZeroRows(tolerance_REF);
            return nonZeroRows < 3;
        }

        /// <summary>
        /// Determines whether two <see cref="IPlanar"/> objects are coplanar within a specified tolerance.
        /// </summary>
        /// <param name="planar_1">The first <see cref="IPlanar"/> object to evaluate.</param>
        /// <param name="planar_2">The second <see cref="IPlanar"/> object to evaluate.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance for coplanarity.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the two objects are coplanar.</returns>
        public static bool Coplanar(this IPlanar? planar_1, IPlanar? planar_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (planar_1 == planar_2)
            {
                return true;
            }

            Plane? plane_1 = planar_1?.Plane;
            if (plane_1 == null)
            {
                return false;
            }

            Plane? plane_2 = planar_2?.Plane;
            if (plane_2 == null)
            {
                return false;
            }

            return plane_1.Coplanar(plane_2, tolerance);
        }
    }
}
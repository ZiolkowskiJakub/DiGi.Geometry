using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        public static bool Coplanar(this IEnumerable<Point3D> point3Ds, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            // Inspired by BHoM

            if (point3Ds == null)
            {
                return false;
            }

            int count = point3Ds.Count();

            if (count < 4)
            {
                return true;
            }

            List<Vector3D> vector3Ds = new List<Vector3D>();
            for (int i = 0; i < count - 1; i++)
            {
                vector3Ds.Add(new Vector3D(point3Ds.ElementAt(0), point3Ds.ElementAt(i + 1)));
            }

            Math.Classes.Matrix matrix = Create.Matrix(vector3Ds);

            double tolerance_REF = matrix.REFTolerance(tolerance);
            Math.Classes.Matrix matrix_REF = matrix.RowEchelonForm(true, tolerance_REF);
            int nonZeroRows = matrix_REF.CountNonZeroRows(tolerance_REF);
            return nonZeroRows < 3;
        }

        public static bool Coplanar(this IPlanar planar_1, IPlanar planar_2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (planar_1 == planar_2)
            {
                return true;
            }

            Plane plane_1 = planar_1?.Plane;
            if (plane_1 == null)
            {
                return false;
            }

            Plane plane_2 = planar_2?.Plane;
            if (plane_2 == null)
            {
                return false;
            }

            return plane_1.Coplanar(plane_2, tolerance);
        }
    }

}

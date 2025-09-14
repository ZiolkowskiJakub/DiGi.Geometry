using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        public static bool Collinear(this Point3D? point2D_1, Point3D? point2D_2, Point3D? point2D_3, double tolerance = DiGi.Core.Constans.Tolerance.Angle)
        {
            if (point2D_1 == null || point2D_2 == null || point2D_3 == null)
            {
                return false;
            }

            return new Vector3D(point2D_2, point2D_1).MinAngle(new Vector3D(point2D_2, point2D_3)) < tolerance;
        }

        public static bool Collinear(this IEnumerable<Point3D>? point3Ds, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            // Inspired by BHoM

            if (point3Ds == null)
            {
                return false;
            }

            int count = point3Ds.Count();

            if (count < 3)
            {
                return true;
            }

            List<Vector3D> vector3Ds = [];
            for (int i = 0; i < count - 1; i++)
            {
                vector3Ds.Add(new Vector3D(point3Ds.ElementAt(0), point3Ds.ElementAt(i + 1)));
            }

            Math.Classes.Matrix? matrix = Create.Matrix(vector3Ds);
            if (matrix == null)
            {
                return false;
            }

            double tolerance_REF = matrix.REFTolerance(tolerance);
            Math.Classes.Matrix? matrix_REF = matrix.RowEchelonForm(true, tolerance_REF);
            if(matrix_REF is null)
            {
                return false;
            }

            int nonZeroRows = matrix_REF.CountNonZeroRows(tolerance_REF);
            return nonZeroRows < 2;
        }
    }
}

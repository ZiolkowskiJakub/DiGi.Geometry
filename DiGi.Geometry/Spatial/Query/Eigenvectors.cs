using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        private static Vector3D[] Eigenvectors(this Math.Classes.Matrix matrix, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            double[] eigenvalues = matrix.Eigenvalues(tolerance);
            if (eigenvalues == null)
                return null;

            double a = matrix[0, 0];
            double b = matrix[0, 1];
            double c = matrix[0, 2];
            double d = matrix[1, 1];
            double e = matrix[1, 2];
            double f = matrix[2, 2];

            double sqTolerance = tolerance * tolerance;
            Vector3D[] result = new Vector3D[6];
            for (int i = 0; i < 3; i++)
            {
                double k = eigenvalues[i];
                Math.Classes.Matrix matrix_Equations = new Math.Classes.Matrix(new double[,] { { a - k, b, c }, { b, d - k, e }, { c, e, f - k } });

                double REFTolerance = matrix_Equations.REFTolerance(tolerance);
                Math.Classes.Matrix matrix_REF = matrix_Equations.RowEchelonForm(true, REFTolerance);

                double y = -matrix_REF[1, 2];
                double x = -matrix_REF[0, 2] - y * matrix_REF[0, 1];

                result[2 * i] = x * x + y * y <= sqTolerance ? new Vector3D(0, 0, 1) : new Vector3D(x, y, 0).Unit;
                result[2 * i + 1] = new Vector3D(x, y, 1).Unit;
            }
            return result;
        }
    }

}

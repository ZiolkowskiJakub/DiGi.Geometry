using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether three 3D points are collinear within a specified angular tolerance.
        /// </summary>
        /// <param name="point2D_1">The first <see cref="Point3D"/>? point.</param>
        /// <param name="point2D_2">The second <see cref="Point3D"/>? point, acting as the vertex for the angle calculation.</param>
        /// <param name="point2D_3">The third <see cref="Point3D"/>? point.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the angular tolerance used to determine collinearity.</param>
        /// <returns>A <see cref="bool"/> indicating whether the points are collinear; returns <c>false</c> if any of the provided points are null.</returns>
        public static bool Collinear(this Point3D? point2D_1, Point3D? point2D_2, Point3D? point2D_3, double tolerance = DiGi.Core.Constants.Tolerance.Angle)
        {
            if (point2D_1 == null || point2D_2 == null || point2D_3 == null)
            {
                return false;
            }

            return new Vector3D(point2D_2, point2D_1).MinAngle(new Vector3D(point2D_2, point2D_3)) < tolerance;
        }

        /// <summary>
        /// Determines whether a collection of <see cref="Point3D"/> points are collinear within a specified tolerance.
        /// </summary>
        /// <param name="point3Ds">The <see cref="IEnumerable{T}"/> of <see cref="Point3D"/> objects to evaluate.</param>
        /// <param name="tolerance">The <see cref="double"/> value representing the distance tolerance for collinearity.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the points are collinear. Returns <see langword="true"/> if there are fewer than three points; otherwise, returns <see langword="false"/> if the collection is null or the points are not collinear.</returns>
        public static bool Collinear(this IEnumerable<Point3D>? point3Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
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
            if (matrix_REF is null)
            {
                return false;
            }

            int nonZeroRows = matrix_REF.CountNonZeroRows(tolerance_REF);
            return nonZeroRows < 2;
        }
    }
}
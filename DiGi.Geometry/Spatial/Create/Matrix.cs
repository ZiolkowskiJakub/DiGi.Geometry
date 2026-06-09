using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a <see cref="Math.Classes.Matrix"/> from a collection of <see cref="Vector3D"/>.
        /// </summary>
        /// <param name="vector3Ds">An <see cref="IEnumerable{T}"/> of <see cref="Vector3D"/> objects to be converted into a matrix.</param>
        /// <returns>A <see cref="Math.Classes.Matrix"/> containing the vectors as rows, or <see langword="null"/> if the input collection is <see langword="null"/>.</returns>
        public static Math.Classes.Matrix? Matrix(this IEnumerable<Vector3D>? vector3Ds)
        {
            if (vector3Ds == null)
            {
                return null;
            }

            int count = vector3Ds.Count();

            Math.Classes.Matrix matrix = new(count, 3);
            for (int i = 0; i < count; i++)
            {
                Vector3D vector3D = vector3Ds.ElementAt(i);
                matrix[i, 0] = vector3D[0];
                matrix[i, 1] = vector3D[1];
                matrix[i, 2] = vector3D[2];
            }

            return matrix;
        }

        /// <summary>
        /// Creates a <see cref="Math.Classes.Matrix"/> from the specified collection of <see cref="Point3D"/> points.
        /// </summary>
        /// <param name="point3Ds">The <see cref="IEnumerable{T}"/> of <see cref="Point3D"/> objects to convert.</param>
        /// <returns>A <see cref="Math.Classes.Matrix"/> containing the point coordinates, or <c>null</c> if <paramref name="point3Ds"/> is <c>null</c>.</returns>
        public static Math.Classes.Matrix? Matrix(this IEnumerable<Point3D>? point3Ds)
        {
            if (point3Ds == null)
            {
                return null;
            }

            int count = point3Ds.Count();

            Math.Classes.Matrix matrix = new(count, 3);
            for (int i = 0; i < count - 1; i++)
            {
                Point3D point3D = point3Ds.ElementAt(i);
                matrix[i, 0] = point3D[0];
                matrix[i, 1] = point3D[1];
                matrix[i, 2] = point3D[2];
            }

            return matrix;
        }
    }
}

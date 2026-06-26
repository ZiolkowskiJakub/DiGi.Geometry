using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the average of a collection of <see cref="Point3D"/> objects.
        /// </summary>
        /// <param name="point3Ds">An <see cref="IEnumerable{T}"/> of <see cref="Point3D"/> objects to be averaged.</param>
        /// <returns>A <see cref="Point3D"/> representing the average position, or <c>null</c> if the input collection is null or empty.</returns>
        public static Point3D? Average(this IEnumerable<Point3D>? point3Ds)
        {
            if (point3Ds == null)
            {
                return null;
            }

            double x = 0;
            double y = 0;
            double z = 0;
            int count = 0;

            foreach (Point3D point3D in point3Ds)
            {
                if (point3D == null)
                {
                    continue;
                }
                x += point3D.X;
                y += point3D.Y;
                z += point3D.Z;
                count++;
            }

            if (count < 1)
            {
                return null;
            }

            return new Point3D(x / count, y / count, z / count);
        }

        /// <summary>
        /// Calculates the average of a sequence of <see cref="Vector3D"/> objects.
        /// </summary>
        /// <param name="vector3Ds">The <see cref="IEnumerable{Vector3D}"/> of vectors to average.</param>
        /// <returns>A <see cref="Vector3D"/> representing the average value, or <c>null</c> if the input sequence is null or empty.</returns>
        public static Vector3D? Average(this IEnumerable<Vector3D>? vector3Ds)
        {
            if (vector3Ds == null)
            {
                return null;
            }

            double x = 0;
            double y = 0;
            double z = 0;
            int count = 0;

            foreach (Vector3D vector3D in vector3Ds)
            {
                if (vector3D == null)
                {
                    continue;
                }
                x += vector3D.X;
                y += vector3D.Y;
                z += vector3D.Z;
                count++;
            }

            if (count < 1)
            {
                return null;
            }

            return new Vector3D(x / count, y / count, z / count);
        }
    }
}
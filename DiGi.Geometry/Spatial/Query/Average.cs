using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

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

            if (point3Ds is IReadOnlyList<Point3D> point3Ds_List)
            {
                int count_List = point3Ds_List.Count;
                if (count_List == 0)
                {
                    return null;
                }

                int count_Valid = 0;
                double x_Sum = 0;
                double y_Sum = 0;
                double z_Sum = 0;

                for (int i = 0; i < count_List; i++)
                {
                    Point3D point3D = point3Ds_List[i];
                    if (point3D == null)
                    {
                        continue;
                    }

                    count_Valid++;
                    x_Sum += point3D.X;
                    y_Sum += point3D.Y;
                    z_Sum += point3D.Z;
                }

                if (count_Valid == 0)
                {
                    return null;
                }

                return new(x_Sum / count_Valid, y_Sum / count_Valid, z_Sum / count_Valid);
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

            return new(x / count, y / count, z / count);
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

            if (vector3Ds is IReadOnlyList<Vector3D> vector3Ds_List)
            {
                int count_List = vector3Ds_List.Count;
                if (count_List == 0)
                {
                    return null;
                }

                int count_Valid = 0;
                double x_Sum = 0;
                double y_Sum = 0;
                double z_Sum = 0;

                for (int i = 0; i < count_List; i++)
                {
                    Vector3D vector3D = vector3Ds_List[i];
                    if (vector3D == null)
                    {
                        continue;
                    }

                    count_Valid++;
                    x_Sum += vector3D.X;
                    y_Sum += vector3D.Y;
                    z_Sum += vector3D.Z;
                }

                if (count_Valid == 0)
                {
                    return null;
                }

                return new(x_Sum / count_Valid, y_Sum / count_Valid, z_Sum / count_Valid);
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

            return new(x / count, y / count, z / count);
        }
    }
}
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Returns the minimum <see cref="Point3D"/> from the specified collection of <see cref="Point3D"/> objects.
        /// </summary>
        /// <param name="point3Ds">The <see cref="IEnumerable{T}"/> of <see cref="Point3D"/> objects to evaluate.</param>
        /// <returns>The minimum <see cref="Point3D"/> found in the collection, or null if the collection is null or empty.</returns>
        public static Point3D? Min(this IEnumerable<Point3D?>? point3Ds)
        {
            return Min(point3Ds, out _);
        }

        /// <summary>
        /// Returns the minimum of two nullable Point3D points.
        /// </summary>
        /// <param name="point3D_1">The first nullable Point3D point to compare.</param>
        /// <param name="point3D_2">The second nullable Point3D point to compare.</param>
        /// <returns>The minimum nullable Point3D point, or null if either <paramref name="point3D_1"/> or <paramref name="point3D_2"/> is null.</returns>
        public static Point3D? Min(this Point3D? point3D_1, Point3D? point3D_2)
        {
            if (point3D_1 == null || point3D_2 == null)
            {
                return null;
            }

            return Min([point3D_1, point3D_2], out _);
        }

        /// <summary>
        /// Calculates the minimum and maximum points from a collection of nullable <see cref="Point3D"/> objects.
        /// </summary>
        /// <param name="point3Ds">The <see cref="IEnumerable{T}"/> of nullable <see cref="Point3D"/> objects to evaluate.</param>
        /// <param name="max">When this method returns, contains the maximum <see cref="Point3D"/> found in the collection, or null if no valid points were found.</param>
        /// <returns>The minimum <see cref="Point3D"/> found in the collection, or null if the collection is null or empty.</returns>
        public static Point3D? Min(this IEnumerable<Point3D?>? point3Ds, out Point3D? max)
        {
            max = null;
            if (point3Ds == null)
            {
                return null;
            }

            double x_Min = double.MaxValue;
            double x_Max = double.MinValue;
            double y_Min = double.MaxValue;
            double y_Max = double.MinValue;
            double z_Min = double.MaxValue;
            double z_Max = double.MinValue;
            int count = 0;

            foreach (Point3D? point3D in point3Ds)
            {
                if (point3D == null)
                {
                    continue;
                }

                count++;
                if (point3D.X > x_Max)
                {
                    x_Max = point3D.X;
                }

                if (point3D.X < x_Min)
                {
                    x_Min = point3D.X;
                }

                if (point3D.Y > y_Max)
                {
                    y_Max = point3D.Y;
                }

                if (point3D.Y < y_Min)
                {
                    y_Min = point3D.Y;
                }

                if (point3D.Z > z_Max)
                {
                    z_Max = point3D.Z;
                }

                if (point3D.Z < z_Min)
                {
                    z_Min = point3D.Z;
                }
            }

            if (count == 0)
            {
                return null;
            }

            max = new Point3D(x_Max, y_Max, z_Max);
            return new Point3D(x_Min, y_Min, z_Min);
        }
    }
}
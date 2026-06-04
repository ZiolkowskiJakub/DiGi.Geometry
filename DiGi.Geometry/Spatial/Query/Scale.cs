using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Scales the specified <see cref="Ray3D"/> by a given factor.
        /// </summary>
        /// <param name="ray3D">The <see cref="Ray3D"/> instance to scale.</param>
        /// <param name="factor">A <see cref="double"/> value representing the scaling factor.</param>
        /// <returns>A new scaled <see cref="Ray3D"/> instance, or <see langword="null"/> if the input ray is <see langword="null"/>, the factor is <see cref="double.NaN"/>, or the ray's origin or direction are <see langword="null"/>.</returns>
        public static Ray3D? Scale(this Ray3D? ray3D, double factor)
        {
            if (ray3D == null || double.IsNaN(factor))
            {
                return null;
            }

            if (factor == 1.0)
            {
                return new Ray3D(ray3D);
            }

            Point3D? point = ray3D.Origin;
            if (point == null)
            {
                return null;
            }

            Vector3D? vector = ray3D.Direction;
            if (vector == null)
            {
                return null;
            }

            point = point.GetMoved(vector);

            vector *= factor;

            point = point?.GetMoved(vector?.GetInversed());

            return new Ray3D(point, vector);
        }

        /// <summary>
        /// Scales a collection of <see cref="Ray3D"/> objects by the specified factor.
        /// </summary>
        /// <param name="ray3Ds">The <see cref="IEnumerable{T}"/> of <see cref="Ray3D"/> objects to scale.</param>
        /// <param name="factor">The <see cref="double"/> factor by which each ray is scaled.</param>
        /// <returns>A <see cref="List{T}"/> containing the scaled <see cref="Ray3D"/> objects, or <see langword="null"/> if the input collection is <see langword="null"/>.</returns>
        public static List<Ray3D>? Scale(this IEnumerable<Ray3D>? ray3Ds, double factor)
        {
            if (ray3Ds == null)
            {
                return null;
            }

            List<Ray3D> result = [];
            foreach (Ray3D ray3D in ray3Ds)
            {
                if (Scale(ray3D, factor) is Ray3D ray3D_Scale)
                {
                    result.Add(ray3D_Scale);
                }
            }

            return result;
        }
    }
}
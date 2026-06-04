using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        /// <summary>
        /// Calculates a single <see cref="BoundingBox3D"/> that encompasses all provided bounding boxes in the collection.
        /// </summary>
        /// <param name="boundingBox3Ds">An <see cref="IEnumerable{T}"/> of <see cref="BoundingBox3D"/> objects to process.</param>
        /// <returns>A <see cref="BoundingBox3D"/> representing the union of all input bounding boxes, or <c>null</c> if the collection is null or contains no valid bounding boxes.</returns>
        public static BoundingBox3D? BoundingBox3D(this IEnumerable<BoundingBox3D>? boundingBox3Ds)
        {
            if (boundingBox3Ds == null)
            {
                return null;
            }

            BoundingBox3D? result = null;
            foreach (BoundingBox3D boundingBox3D in boundingBox3Ds)
            {
                if (boundingBox3D == null)
                {
                    continue;
                }

                if (result == null)
                {
                    if (boundingBox3D.Min != null && boundingBox3D.Max != null)
                    {
                        result = new BoundingBox3D(boundingBox3D);
                    }
                    continue;
                }

                result.Add(boundingBox3D);
            }

            return result;
        }

        /// <summary>
        /// Creates a <see cref="BoundingBox3D"/> based on the provided X, Y, and Z ranges.
        /// </summary>
        /// <param name="x">The <see cref="Range{double}"/> for the X axis.</param>
        /// <param name="y">The <see cref="Range{double}"/> for the Y axis.</param>
        /// <param name="z">The <see cref="Range{double}"/> for the Z axis.</param>
        /// <returns>A <see cref="BoundingBox3D"/> if all provided ranges are not null; otherwise, null.</returns>
        public static BoundingBox3D? BoundingBox3D(Range<double>? x, Range<double>? y, Range<double>? z)
        {
            if (x == null || y == null || z == null)
            {
                return null;
            }

            return new BoundingBox3D(new Point3D(x.Min, y.Min, z.Min), new Point3D(x.Max, y.Max, z.Max));
        }
    }
}
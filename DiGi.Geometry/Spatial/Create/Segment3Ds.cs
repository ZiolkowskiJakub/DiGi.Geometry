using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        /// <summary>
        /// Converts a collection of <see cref="Point3D"/> objects into a list of <see cref="Segment3D"/> objects.
        /// </summary>
        /// <param name="point3Ds">The <see cref="IEnumerable{T}"/> of <see cref="Point3D"/> points to process.</param>
        /// <param name="closed">A <see cref="bool"/> value indicating whether the segment list should be closed by connecting the last point back to the first point.</param>
        /// <returns>A <see cref="List{T}"/> of <see cref="Segment3D"/> objects, or <see langword="null"/> if the provided <see cref="IEnumerable{T}"/> is null.</returns>
        public static List<Segment3D>? Segment3Ds(this IEnumerable<Point3D>? point3Ds, bool closed = false)
        {
            if (point3Ds == null)
            {
                return null;
            }

            int count = point3Ds.Count();

            List<Segment3D> result = [];

            if (count < 2)
            {
                return result;
            }

            for (int i = 1; i < count; i++)
            {
                Point3D point3D_1 = point3Ds.ElementAt(i - 1);
                if (point3D_1 == null)
                {
                    continue;
                }

                Point3D point3D_2 = point3Ds.ElementAt(i);
                if (point3D_2 == null)
                {
                    continue;
                }

                result.Add(new Segment3D(new Point3D(point3D_1), new Point3D(point3D_2)));
            }

            if (closed)
            {
                result.Add(new Segment3D(new Point3D(result[result.Count - 1][1]), new Point3D(result[0][0])));
            }

            return result;
        }
    }
}
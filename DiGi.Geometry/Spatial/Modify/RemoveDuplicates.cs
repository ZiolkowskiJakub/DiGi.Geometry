using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Modify
    {
        /// <summary>
        /// Removes every point which coincides with the point before it, so the geometry holds no zero length segment.
        /// <para>Spatial counterpart of <see cref="Planar.Modify.RemoveDuplicates(List{Planar.Classes.Point2D}?, bool, double)"/>. Trimming a ring before a plane is fitted to it also matters in its own right, because the plane takes the average of the points as its origin and a repeated point pulls that origin towards the corner it repeats.</para>
        /// <para>Set <paramref name="closed"/> for a ring, where the last point is the predecessor of the first. That is what strips the repeated closing position a gml:LinearRing carries.</para>
        /// <para>No floor is applied to how many points survive, so a ring which is nothing but repeats of one corner collapses to that single point. That is deliberate - the caller checks the count afterwards, and leaving a degenerate ring padded out to three points would let it pass a check for three corners while holding fewer.</para>
        /// </summary>
        /// <param name="point3Ds">The <see cref="List{Point3D}"/> to clean up in place.</param>
        /// <param name="closed">A <see cref="bool"/> value indicating whether the points form a closed ring, in which case the last point is compared against the first.</param>
        /// <param name="tolerance">The <see cref="double"/> distance within which two points are treated as one.</param>
        /// <returns>A <see cref="bool"/> value indicating whether any point was removed.</returns>
        public static bool RemoveDuplicates(this List<Point3D>? point3Ds, bool closed, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point3Ds == null || point3Ds.Count < 2)
            {
                return false;
            }

            bool result = false;

            for (int i = point3Ds.Count - 1; i > 0; i--)
            {
                if (Query.AlmostEquals(point3Ds[i], point3Ds[i - 1], tolerance))
                {
                    point3Ds.RemoveAt(i);
                    result = true;
                }
            }

            // The closing position is the last one to go, so the points before it have already been cleaned up
            // and the comparison is against the first point of the ring rather than against a repeat of it.
            if (closed && point3Ds.Count > 1 && Query.AlmostEquals(point3Ds[point3Ds.Count - 1], point3Ds[0], tolerance))
            {
                point3Ds.RemoveAt(point3Ds.Count - 1);
                result = true;
            }

            return result;
        }
    }
}

using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Modify
    {
        /// <summary>
        /// Removes every point which coincides with the point before it, so the geometry holds no zero length segment.
        /// <para>A repeated point contributes a segment of no length, which has no direction and no meaning - it makes a ring report as self intersecting, pushes a triangle onto the four point branch of triangulation, and produces an invalid ring once the geometry is handed to NetTopologySuite.</para>
        /// <para>Set <paramref name="closed"/> for a ring, where the last point is the predecessor of the first. That is what strips the repeated closing position a gml:LinearRing carries.</para>
        /// <para>No floor is applied to how many points survive, so a ring which is nothing but repeats of one corner collapses to that single point. That is deliberate - the caller checks the count afterwards, and leaving a degenerate ring padded out to three points would let it pass a check for three corners while holding fewer.</para>
        /// </summary>
        /// <param name="point2Ds">The <see cref="List{Point2D}"/> to clean up in place.</param>
        /// <param name="closed">A <see cref="bool"/> value indicating whether the points form a closed ring, in which case the last point is compared against the first.</param>
        /// <param name="tolerance">The <see cref="double"/> distance within which two points are treated as one.</param>
        /// <returns>A <see cref="bool"/> value indicating whether any point was removed.</returns>
        public static bool RemoveDuplicates(this List<Point2D>? point2Ds, bool closed, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point2Ds == null || point2Ds.Count < 2)
            {
                return false;
            }

            bool result = false;

            for (int i = point2Ds.Count - 1; i > 0; i--)
            {
                if (Query.AlmostEquals(point2Ds[i], point2Ds[i - 1], tolerance))
                {
                    point2Ds.RemoveAt(i);
                    result = true;
                }
            }

            // The closing position is the last one to go, so the points before it have already been cleaned up
            // and the comparison is against the first point of the ring rather than against a repeat of it.
            if (closed && point2Ds.Count > 1 && Query.AlmostEquals(point2Ds[point2Ds.Count - 1], point2Ds[0], tolerance))
            {
                point2Ds.RemoveAt(point2Ds.Count - 1);
                result = true;
            }

            return result;
        }
    }
}

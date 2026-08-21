using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a <see cref="Classes.Polygon2D"/> from a collection of <see cref="Point2D"/> objects, dropping any point which repeats the one before it.
        /// <para>Use this rather than the constructor whenever the points come from outside the library - a file, a service, a user - and are not already known to form an open ring. A polygon holds its ring open, because <see cref="Polygon2D.GetSegments"/> adds the closing segment itself, so a ring which repeats its first point as its last would otherwise carry a segment of no length. Such a segment has no direction, makes the ring report as self intersecting, and pushes a triangle onto the four point branch of triangulation where it produces a second, degenerate triangle.</para>
        /// <para>The constructor stays a plain assignment and does none of this, so a caller who already holds clean points pays nothing.</para>
        /// </summary>
        /// <param name="point2Ds">The <see cref="IEnumerable{T}"/> of <see cref="Point2D"/> objects used to define the polygon.</param>
        /// <param name="tolerance">The <see cref="double"/> distance within which two points are treated as one.</param>
        /// <returns>A <see cref="Classes.Polygon2D"/> object if a valid polygon can be created; otherwise, null.</returns>
        public static Polygon2D? Polygon2D(this IEnumerable<Point2D?>? point2Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point2Ds == null)
            {
                return null;
            }

            List<Point2D> point2Ds_Temp = [];
            foreach (Point2D? point2D in point2Ds)
            {
                if (point2D != null)
                {
                    point2Ds_Temp.Add(point2D);
                }
            }

            // The count is checked after the repeats are removed, so a ring which only reaches three positions
            // because it repeats a corner is rejected rather than turned into a polygon of two distinct points.
            point2Ds_Temp.RemoveDuplicates(true, tolerance);

            if (point2Ds_Temp.Count < 3)
            {
                return null;
            }

            return new Polygon2D(point2Ds_Temp);
        }

        /// <summary>
        /// Creates a <see cref="Classes.Polygon2D"/> from another polygonal geometry, dropping any point which repeats the one before it.
        /// </summary>
        /// <param name="polygonal2D">The <see cref="IPolygonal2D"/> whose points define the polygon.</param>
        /// <param name="tolerance">The <see cref="double"/> distance within which two points are treated as one.</param>
        /// <returns>A <see cref="Classes.Polygon2D"/> object if a valid polygon can be created; otherwise, null.</returns>
        public static Polygon2D? Polygon2D(this IPolygonal2D? polygonal2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            return Polygon2D(polygonal2D?.GetPoints(), tolerance);
        }
    }
}

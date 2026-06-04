using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Modify
    {
        /// <summary>
        /// Orients the specified <see cref="IPolygonal2D"/> to a target <see cref="Orientation"/>.
        /// </summary>
        /// <param name="polygonal2D">The <see cref="IPolygonal2D"/> instance to orient.</param>
        /// <param name="orientation">The desired <see cref="Orientation"/>.</param>
        /// <param name="convexHull">A <see cref="bool"/> value indicating whether the convex hull should be used for orientation calculation.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the polygonal object was inverted to match the target orientation.</returns>
        public static bool Orient(this IPolygonal2D? polygonal2D, Orientation orientation, bool convexHull = true)
        {
            if (polygonal2D == null || orientation == Orientation.Undefined || orientation == Orientation.Collinear)
            {
                return false;
            }

            Orientation orientation_Temp = polygonal2D.Orientation(convexHull);
            if (orientation_Temp == orientation)
            {
                return false;
            }

            polygonal2D.Inverse();
            return true;
        }

        /// <summary>
        /// Determines if the majority of point sets within the provided list exhibit the specified orientation.
        /// </summary>
        /// <param name="point2Ds">The <see cref="List{Point2D}"/> containing points to analyze.</param>
        /// <param name="orientation">The target <see cref="Orientation"/> to check for.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the majority of orientations match the specified <see cref="Orientation"/>.</returns>
        public static bool Orient(List<Point2D>? point2Ds, Orientation orientation)
        {
            if (point2Ds == null || point2Ds.Count < 3 || orientation == Orientation.Collinear)
            {
                return false;
            }

            if (orientation == Orientation.Undefined)
            {
                return false;
            }

            List<Orientation>? orienations = Query.Orientations(point2Ds);
            if (orienations is null)
            {
                return false;
            }

            if (orienations.Count(x => x == orientation) > (orienations.Count / 2))
            {
                return false;
            }

            point2Ds.Reverse();

            return true;
        }
    }
}
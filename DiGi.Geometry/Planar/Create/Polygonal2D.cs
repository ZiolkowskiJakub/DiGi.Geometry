using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        /// <summary>
        /// Simplifies or recreates the <see cref="IPolygonal2D"/> instance using a specified distance tolerance.
        /// </summary>
        /// <param name="polygonal2D">The <see cref="IPolygonal2D"/> instance to be processed.</param>
        /// <param name="tolerance">A <see cref="double"/> value specifying the distance tolerance.</param>
        /// <returns>An <see cref="IPolygonal2D"/> instance if the input is not null; otherwise, <c>null</c>.</returns>
        public static IPolygonal2D? Polygonal2D(this IPolygonal2D? polygonal2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (polygonal2D == null)
            {
                return null;
            }

            return Polygonal2D(polygonal2D?.GetPoints(), tolerance);
        }

        /// <summary>
        /// Creates an <see cref="IPolygonal2D"/> instance from a collection of <see cref="Point2D"/> points.
        /// </summary>
        /// <param name="point2Ds">The <see cref="IEnumerable{T}"/> of <see cref="Point2D"/> objects used to define the polygon.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used for distance calculations.</param>
        /// <returns>An <see cref="IPolygonal2D"/> instance if the collection is not null and contains at least three points; otherwise, <see langword="null"/>.</returns>
        public static IPolygonal2D? Polygonal2D(this IEnumerable<Point2D>? point2Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point2Ds == null)
            {
                return null;
            }

            Point2D[] point2Ds_Materialized = point2Ds as Point2D[] ?? [.. point2Ds];
            int count = point2Ds_Materialized.Length;
            if (count < 3)
            {
                return null;
            }

            if (count == 3)
            {
                return new Triangle2D(point2Ds_Materialized[0], point2Ds_Materialized[1], point2Ds_Materialized[2]);
            }

            List<Point2D>? point2Ds_ConvexHull = point2Ds_Materialized.ConvexHull();
            if (point2Ds_ConvexHull == null || point2Ds_ConvexHull.Count < 3)
            {
                return null;
            }

            double area = point2Ds_Materialized.Area();

            if (!DiGi.Core.Query.AlmostEquals(point2Ds_ConvexHull.Area(), area, tolerance))
            {
                return new Polygon2D(point2Ds_Materialized);
            }

            return Rectangle2D(point2Ds_Materialized);
        }
    }
}
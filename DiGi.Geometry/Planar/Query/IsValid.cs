using DiGi.Geometry.Planar.Classes;
using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Checks that a point is non-null and carries finite X and Y values.
        /// </summary>
        /// <param name="point2D">The point to check.</param>
        /// <returns><see langword="true"/> when the point is non-null and finite; otherwise, <see langword="false"/>.</returns>
        public static bool IsValid(this Point2D? point2D)
        {
            if (point2D is null)
            {
                return false;
            }

            double x = point2D.X;
            double y = point2D.Y;

            return !double.IsNaN(x) && !double.IsInfinity(x) && !double.IsNaN(y) && !double.IsInfinity(y);
        }

        /// <summary>
        /// Checks that every point in the collection is non-null and carries finite X and Y values.
        /// </summary>
        /// <param name="point2Ds">The collection of points to check.</param>
        /// <returns><see langword="true"/> when all points are valid; otherwise, <see langword="false"/>.</returns>
        public static bool IsValid(this IEnumerable<Point2D>? point2Ds)
        {
            if (point2Ds == null)
            {
                return false;
            }

            foreach (Point2D point2D in point2Ds)
            {
                if (!point2D.IsValid())
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Checks that a coordinate is non-null and carries finite X and Y values.
        /// </summary>
        /// <param name="coordinate">The coordinate to check.</param>
        /// <returns><see langword="true"/> when the coordinate is non-null and finite; otherwise, <see langword="false"/>.</returns>
        public static bool IsValid(this Coordinate? coordinate)
        {
            if (coordinate is null)
            {
                return false;
            }

            double x = coordinate.X;
            double y = coordinate.Y;

            return !double.IsNaN(x) && !double.IsInfinity(x) && !double.IsNaN(y) && !double.IsInfinity(y);
        }

        /// <summary>
        /// Checks that every coordinate in the collection is non-null and carries finite X and Y values.
        /// </summary>
        /// <param name="coordinates">The coordinates to be checked.</param>
        /// <returns><see langword="true"/> when all coordinates are valid; otherwise, <see langword="false"/>.</returns>
        public static bool IsValid(this IEnumerable<Coordinate>? coordinates)
        {
            if (coordinates == null)
            {
                return false;
            }

            foreach (Coordinate coordinate in coordinates)
            {
                if (!coordinate.IsValid())
                {
                    return false;
                }
            }

            return true;
        }
    }
}

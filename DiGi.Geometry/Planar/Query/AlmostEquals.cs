using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether two <c>Point2D?</c> points are approximately equal based on a specified distance tolerance.
        /// </summary>
        /// <param name="point2D_1">The first <c>Point2D?</c> point to compare.</param>
        /// <param name="point2D_2">The second <c>Point2D?</c> point to compare.</param>
        /// <param name="tolerance">The <see cref="double" /> tolerance value used to determine if the points are almost equal.</param>
        /// <returns>A <see cref="bool" /> value indicating whether the two points are considered equal within the given tolerance.</returns>
        public static bool AlmostEquals(this Point2D? point2D_1, Point2D? point2D_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point2D_1 == point2D_2)
            {
                return true;
            }

            if (point2D_1 == null || point2D_2 == null)
            {
                return false;
            }

            return point2D_1.Distance(point2D_2) <= tolerance;
        }

        /// <summary>
        /// Determines whether two <see cref="ISegmentable2D"/> instances are approximately equal based on a specified tolerance.
        /// </summary>
        /// <param name="segmentable2D_1">The first <see cref="ISegmentable2D"/> instance to compare.</param>
        /// <param name="segmentable2D_2">The second <see cref="ISegmentable2D"/> instance to compare.</param>
        /// <param name="tolerance">A <see cref="double"/> value specifying the tolerance for the equality check.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the two instances are almost equal.</returns>
        public static bool AlmostEquals(this ISegmentable2D? segmentable2D_1, ISegmentable2D? segmentable2D_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segmentable2D_1 == segmentable2D_2)
            {
                return true;
            }

            if (segmentable2D_1 == null || segmentable2D_2 == null)
            {
                return false;
            }

            if (segmentable2D_1.GetType() != segmentable2D_2.GetType())
            {
                return false;
            }

            List<Point2D>? point2Ds_1 = segmentable2D_1.GetPoints();
            List<Point2D>? point2Ds_2 = segmentable2D_2.GetPoints();

            if ((point2Ds_1 == null || point2Ds_1.Count == 0) && (point2Ds_2 == null || point2Ds_2.Count == 0))
            {
                return true;
            }

            if (point2Ds_1 == null || point2Ds_2 == null || point2Ds_1.Count != point2Ds_2.Count)
            {
                return false;
            }

            for (int i = 0; i < point2Ds_1.Count; i++)
            {
                if (!AlmostEquals(point2Ds_1[i], point2Ds_2[i], tolerance))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Checks if a point lies on a segmentable geometry within a given tolerance.
        /// </summary>
        /// <param name="segmentable2D">The segmentable geometry to check.</param>
        /// <param name="point2D">The target point.</param>
        /// <param name="tolerance">The distance tolerance for the check.</param>
        /// <returns>True if the point is on the geometry, otherwise false.</returns>
        public static bool On(this ISegmentable2D? segmentable2D, Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            return On(segmentable2D?.GetSegments(), point2D, tolerance);
        }

        /// <summary>
        /// Checks if a point lies on any of the provided segments within a given tolerance.
        /// </summary>
        /// <param name="segment2Ds">The collection of segments to check.</param>
        /// <param name="point2D">The target point.</param>
        /// <param name="tolerance">The distance tolerance for the check.</param>
        /// <returns>True if the point is on any segment, otherwise false.</returns>
        public static bool On(this IEnumerable<Segment2D?>? segment2Ds, Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point2D == null || segment2Ds == null)
            {
                return false;
            }

            foreach (Segment2D? segment2D in segment2Ds)
            {
                if (segment2D is null)
                {
                    continue;
                }

                if (segment2D.On(point2D, tolerance))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Checks if a point lies on any of the provided segmentable geometries within a given tolerance.
        /// </summary>
        /// <typeparam name="T">The type of segmentable geometry, which must implement <see cref="ISegmentable2D"/>.</typeparam>
        /// <param name="segmentable2Ds">The collection of segmentable geometries to check.</param>
        /// <param name="point2D">The target point to evaluate.</param>
        /// <param name="tolerance">The distance tolerance used to determine if the point is on the geometry.</param>
        /// <returns>True if the point lies on any of the provided geometries within the specified tolerance; otherwise, false.</returns>
        public static bool On<T>(this IEnumerable<T>? segmentable2Ds, Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance) where T : ISegmentable2D
        {
            if (point2D == null || segmentable2Ds == null || segmentable2Ds.Count() == 0)
            {
                return false;
            }

            return On(segmentable2Ds?.Segments(), point2D, tolerance);
        }
    }
}

using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        /// <summary>
        /// Traces a ray from a point in a given direction through a collection of segmentable 2D objects and returns the first intersection result.
        /// </summary>
        /// <param name="point2D">The starting <see cref="Point2D"/> for the trace operation.</param>
        /// <param name="vector2D">The <see cref="Classes.Vector2D"/> representing the direction of the trace.</param>
        /// <param name="segmentable2Ds">An <see cref="IEnumerable{ISegmentable2D}"/> containing the objects to be traced.</param>
        /// <param name="tolerance">A <see cref="double"/> value specifying the distance tolerance for the operation.</param>
        /// <returns>The first <see cref="Classes.SegmentableTraceResult2D"/> found, or null if no intersection occurs within the specified tolerance.</returns>
        public static SegmentableTraceResult2D? SegmentableTraceResult2D(this Point2D? point2D, Vector2D? vector2D, IEnumerable<ISegmentable2D>? segmentable2Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            return SegmentableTraceResult2Ds(point2D, vector2D, segmentable2Ds?.Segments(), 0, tolerance)?.FirstOrDefault();
        }

        /// <summary>
        /// Performs a segmentable trace operation and returns the first result found.
        /// </summary>
        /// <param name="point2D">The starting <see cref="Point2D"/> for the trace.</param>
        /// <param name="vector2D">The direction <see cref="Classes.Vector2D"/> of the trace.</param>
        /// <param name="segment2Ds">An <see cref="IEnumerable{Segment2D}"/> containing the segments to be traced.</param>
        /// <param name="tolerance">A <see cref="double"/> representing the distance tolerance for the operation.</param>
        /// <returns>The first <see cref="Classes.SegmentableTraceResult2D"/> found, or null if no result exists.</returns>
        public static SegmentableTraceResult2D? SegmentableTraceResult2D(this Point2D? point2D, Vector2D? vector2D, IEnumerable<Segment2D>? segment2Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            return SegmentableTraceResult2Ds(point2D, vector2D, segment2Ds, 0, tolerance)?.FirstOrDefault();
        }
    }
}
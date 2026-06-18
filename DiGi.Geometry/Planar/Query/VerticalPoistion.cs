using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Determines the vertical position of a point relative to a segmentable 2D geometry.
        /// </summary>
        /// <param name="segmentable2D">The segmentable 2D geometry to evaluate against.</param>
        /// <param name="point2D">The point whose vertical position is being determined.</param>
        /// <param name="tolerance">The distance tolerance used for the calculation.</param>
        /// <returns>A <see cref="DiGi.Geometry.Core.Enums.VerticalPosition"/> value indicating whether the point is above, below, or undefined relative to the geometry.</returns>
        public static VerticalPosition VerticalPosition(this ISegmentable2D? segmentable2D, Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segmentable2D == null || point2D == null)
            {
                return Core.Enums.VerticalPosition.Undefined;
            }

            List<Segment2D>? segment2Ds = segmentable2D.GetSegments();
            if (segment2Ds == null || segment2Ds.Count == 0)
            {
                return Core.Enums.VerticalPosition.Undefined;
            }

            List<VerticalPosition> verticalPositions = [];

            List<Segment2D>? segment2Ds_Temp = segmentable2D.GetSegments();
            if (segment2Ds_Temp != null)
            {
                foreach (Segment2D segment2D in segment2Ds_Temp)
                {
                    verticalPositions.Add(VerticalPosition(segment2D, point2D, tolerance));
                }
            }

            if (verticalPositions.TrueForAll(x => x == Core.Enums.VerticalPosition.Undefined))
            {
                return Core.Enums.VerticalPosition.Undefined;
            }

            verticalPositions.RemoveAll(x => x == Core.Enums.VerticalPosition.Undefined);

            if (verticalPositions.TrueForAll(x => x == Core.Enums.VerticalPosition.Below))
            {
                return Core.Enums.VerticalPosition.Below;
            }

            if (verticalPositions.TrueForAll(x => x == Core.Enums.VerticalPosition.Above))
            {
                return Core.Enums.VerticalPosition.Above;
            }

            if (verticalPositions.Contains(Core.Enums.VerticalPosition.On))
            {
                return Core.Enums.VerticalPosition.On;
            }

            return Core.Enums.VerticalPosition.Inside;
        }

        /// <summary>
        /// Determines the vertical position of a point relative to a 2D segment.
        /// </summary>
        /// <param name="segment2D">The 2D segment used as the reference for the vertical position check.</param>
        /// <param name="point2D">The 2D point whose vertical position is being evaluated.</param>
        /// <param name="tolerance">The distance tolerance used to determine if the point is on the segment or within its bounds.</param>
        /// <returns>A <see cref="DiGi.Geometry.Core.Enums.VerticalPosition"/> value indicating whether the point is above, below, on, or in an undefined position relative to the segment.</returns>
        public static VerticalPosition VerticalPosition(this Segment2D? segment2D, Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segment2D == null || point2D == null)
            {
                return Core.Enums.VerticalPosition.Undefined;
            }

            BoundingBox2D? boundingBox2D = segment2D.GetBoundingBox();
            if (boundingBox2D == null)
            {
                return Core.Enums.VerticalPosition.Undefined;
            }

            if (point2D.X < boundingBox2D.Min.X - tolerance || point2D.X > boundingBox2D.Max.X + tolerance)
            {
                return Core.Enums.VerticalPosition.Undefined;
            }

            SegmentableTraceResult2D? segmentableTraceResult2D = Create.SegmentableTraceResult2D(point2D, Constants.Vector2D.WorldY, [segment2D], tolerance);
            if (segmentableTraceResult2D == null)
            {
                return Core.Enums.VerticalPosition.Undefined;
            }

            Vector2D? vector2D = segmentableTraceResult2D.Vector2D;
            if (vector2D == null)
            {
                return Core.Enums.VerticalPosition.Below;
            }

            if (vector2D.Length < tolerance)
            {
                return Core.Enums.VerticalPosition.On;
            }

            return Core.Enums.VerticalPosition.Above;
        }
    }
}

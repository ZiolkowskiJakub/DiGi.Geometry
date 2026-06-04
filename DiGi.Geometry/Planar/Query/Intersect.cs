using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether two <see cref="ISegmentable2D"/> objects intersect within a specified tolerance.
        /// </summary>
        /// <param name="segmentable2D_1">The first <see cref="ISegmentable2D"/> object to check for intersection.</param>
        /// <param name="segmentable2D_2">The second <see cref="ISegmentable2D"/> object to check for intersection.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used to determine if the objects are within range of each other.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the two <see cref="ISegmentable2D"/> objects intersect; otherwise, false.</returns>
        public static bool Intersect(this ISegmentable2D segmentable2D_1, ISegmentable2D segmentable2D_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segmentable2D_1 == null || segmentable2D_2 == null)
            {
                return false;
            }

            BoundingBox2D? boundingBox2D_1 = segmentable2D_1.GetBoundingBox();
            if (boundingBox2D_1 == null)
            {
                return false;
            }

            BoundingBox2D? boundingBox2D_2 = segmentable2D_2.GetBoundingBox();
            if (boundingBox2D_2 == null)
            {
                return false;
            }

            if (!boundingBox2D_1.InRange(boundingBox2D_2, tolerance))
            {
                return false;
            }

            List<Segment2D>? segment2Ds = segmentable2D_2.GetSegments();
            if (segment2Ds == null || segment2Ds.Count == 0)
            {
                return false;
            }

            foreach (Segment2D segment2D in segment2Ds)
            {
                if (Intersect(segmentable2D_1, segment2D, tolerance))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Determines whether a <see cref="Segment2D"/> intersects with an <see cref="ISegmentable2D"/> object within a specified tolerance.
        /// </summary>
        /// <param name="segmentable2D">The <see cref="ISegmentable2D"/> object to check for intersection.</param>
        /// <param name="segment2D">The <see cref="Segment2D"/> segment to intersect with the <see cref="ISegmentable2D"/> object.</param>
        /// <param name="tolerance">A <see cref="double"/> value specifying the distance tolerance for the intersection check.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the objects intersect; otherwise, false.</returns>
        public static bool Intersect(this ISegmentable2D? segmentable2D, Segment2D? segment2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segmentable2D == null || segment2D == null)
            {
                return false;
            }

            BoundingBox2D? boundingBox2D = segmentable2D.GetBoundingBox();
            if (boundingBox2D == null)
            {
                return false;
            }

            if (!boundingBox2D.InRange(segment2D, tolerance))
            {
                return false;
            }

            List<Segment2D>? segment2Ds = segmentable2D?.GetSegments();
            if (segment2Ds == null || segment2Ds.Count == 0)
            {
                return false;
            }

            foreach (Segment2D segment2D_Temp in segment2Ds)
            {
                if (Intersect((ILinear2D)segment2D, segment2D_Temp, tolerance))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Determines whether two linear 2D objects intersect within a specified tolerance.
        /// </summary>
        /// <param name="linear2D_1">The first <see cref="ILinear2D"/> object.</param>
        /// <param name="linear_2">The second <see cref="ILinear2D"/> object.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used to determine the intersection.</param>
        /// <returns>A <see cref="bool"/> value indicating whether an intersection point exists between the two linear 2D objects within the specified tolerance.</returns>
        public static bool Intersect(this ILinear2D? linear2D_1, ILinear2D? linear_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            Point2D? point2D = IntersectionPoint(linear2D_1, linear_2, tolerance);

            return point2D != null;
        }
    }
}
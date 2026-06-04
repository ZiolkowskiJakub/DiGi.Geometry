using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Extends a 2D line segment by a specified distance at the start and/or end points.
        /// </summary>
        /// <param name="segment2D">The <see cref="Segment2D"/> instance to be extended.</param>
        /// <param name="distance">The <see cref="double"/> distance to extend the segment by.</param>
        /// <param name="extendStart">A <see cref="bool"/> value indicating whether the start of the segment should be extended. Defaults to true.</param>
        /// <param name="extendEnd">A <see cref="bool"/> value indicating whether the end of the segment should be extended. Defaults to true.</param>
        /// <returns>A new <see cref="Segment2D"/> instance representing the extended segment, or <see langword="null"/> if the input <see cref="Segment2D"/> or its endpoints are null.</returns>
        public static Segment2D? Extend(this Segment2D? segment2D, double distance, bool extendStart = true, bool extendEnd = true)
        {
            if (segment2D == null)
            {
                return null;
            }

            Point2D? start = segment2D.Start;
            if (start is null)
            {
                return null;
            }

            Point2D? end = segment2D.End;
            if (end is null)
            {
                return null;
            }

            if (!extendStart && !extendEnd)
            {
                return new(segment2D);
            }

            Vector2D? direction = segment2D.Direction;
            if (direction is null)
            {
                return null;
            }

            Vector2D? vector2D = segment2D.Direction * distance;
            if (vector2D is null)
            {
                return null;
            }

            if (extendEnd)
            {
                end.Move(vector2D);
            }

            if (extendStart)
            {
                vector2D.Inverse();
                start.Move(vector2D);
            }

            return new(start, end);
        }
    }
}
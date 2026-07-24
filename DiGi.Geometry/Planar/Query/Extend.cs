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

            if (!segment2D.TryGetCoordinates(out double x1, out double y1, out double x2, out double y2))
            {
                return null;
            }

            if (!extendStart && !extendEnd)
            {
                return new Segment2D(segment2D);
            }

            double dx = x2 - x1;
            double dy = y2 - y1;
            double length = System.Math.Sqrt(dx * dx + dy * dy);

            if (length == 0.0)
            {
                return new Segment2D(segment2D);
            }

            double ux = (dx / length) * distance;
            double uy = (dy / length) * distance;

            double newX1 = extendStart ? x1 - ux : x1;
            double newY1 = extendStart ? y1 - uy : y1;
            double newX2 = extendEnd ? x2 + ux : x2;
            double newY2 = extendEnd ? y2 + uy : y2;

            return new Segment2D(newX1, newY1, newX2, newY2);
        }
    }
}
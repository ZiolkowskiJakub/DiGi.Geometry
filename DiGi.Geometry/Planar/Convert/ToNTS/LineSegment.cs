using DiGi.Geometry.Planar.Classes;
using NetTopologySuite.Geometries;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts the specified <see cref="Segment2D"/> to an NTS <see cref="LineSegment"/>.
        /// </summary>
        /// <param name="segment2D">The <see cref="Segment2D"/> instance to convert.</param>
        /// <returns>A <see cref="LineSegment"/> if the <see cref="Segment2D"/> and its start and end points are not null; otherwise, null.</returns>
        public static LineSegment? ToNTS(this Segment2D? segment2D)
        {
            Point2D? start = segment2D?.Start;
            if (start == null)
            {
                return null;
            }

            Point2D? end = segment2D!.End;
            if (end == null)
            {
                return null;
            }

            return new LineSegment(start.ToNTS(), end.ToNTS());
        }
    }
}
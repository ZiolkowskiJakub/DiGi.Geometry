using DiGi.Geometry.Planar.Classes;
using NetTopologySuite.Geometries;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        public static LineSegment ToNTS(this Segment2D segment2D)
        {
            Point2D start = segment2D?.Start;
            if(start == null)
            {
                return null;
            }

            Point2D end = segment2D.End;
            if (end == null)
            {
                return null;
            }

            return new LineSegment(start.ToNTS(), end.ToNTS());
        }
    }
}

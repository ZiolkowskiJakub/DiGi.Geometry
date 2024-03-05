using DiGi.Geometry.Planar.Classes;
using NetTopologySuite.Geometries;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        public static Segment2D ToDiGi(this LineSegment lineSegment)
        {
            if(lineSegment == null)
            {
                return null;
            }

            Point2D point2D_1 = lineSegment?.P0?.ToDiGi();
            if(point2D_1 == null)
            {
                return null;
            }

            Point2D point2D_2 = lineSegment.P1?.ToDiGi();
            if(point2D_2 == null)
            {
                return null;
            }

            return new Segment2D(point2D_1, point2D_2);
        }
    }
}

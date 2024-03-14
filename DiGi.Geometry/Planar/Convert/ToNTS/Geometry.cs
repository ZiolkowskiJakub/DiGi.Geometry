using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Geometries;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        public static NetTopologySuite.Geometries.Geometry ToNTS(this IGeometry2D sAMGeometry2D)
        {
            if (sAMGeometry2D == null)
            {
                return null;
            }

            if(sAMGeometry2D is Point2D)
            {
                Coordinate coordinate = ToNTS((Point2D)sAMGeometry2D);
                if (coordinate == null)
                {
                    return null;
                }

                return new Point(coordinate);
            }

            if (sAMGeometry2D is IClosedSegmentable2D)
            {
                return ToNTS((IClosedSegmentable2D)sAMGeometry2D);
            }

            if(sAMGeometry2D is ISegmentableFace2D)
            {
                return ToNTS((ISegmentableFace2D)sAMGeometry2D);
            }

            if (sAMGeometry2D is Segment2D)
            {
                return ToNTS_LineString((Segment2D)sAMGeometry2D);
            }

            if (sAMGeometry2D is Polyline2D)
            {
                return ToNTS((Polyline2D)sAMGeometry2D);
            }

            return null;
        }
    }
}

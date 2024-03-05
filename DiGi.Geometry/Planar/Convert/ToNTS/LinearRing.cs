using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        public static LinearRing ToNTS(this IClosedSegmentable2D closedSegmentable2D)
        {
            List<Coordinate> cooridnates = closedSegmentable2D?.GetPoints()?.ToNTS();
            if(cooridnates == null)
            {
                return null;
            }

            return new LinearRing(cooridnates.ToArray());
        }
    }
}

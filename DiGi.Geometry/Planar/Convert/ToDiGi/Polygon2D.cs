using DiGi.Geometry.Planar.Classes;
using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        public static Polygon2D ToDiGi(this LinearRing linearRing)
        {
            List<Point2D> point2Ds = linearRing?.Coordinates?.ToDiGi();
            if(point2Ds == null || point2Ds.Count < 3)
            {
                return null;
            }

            return new Polygon2D(point2Ds);
        }
    }
}

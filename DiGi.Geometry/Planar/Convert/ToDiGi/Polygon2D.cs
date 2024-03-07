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
            if(point2Ds == null)
            {
                return null;
            }

            int count = point2Ds.Count;
            if(count < 3)
            {
                return null;
            }

            if (point2Ds[0] == point2Ds[count - 1])
            {
                point2Ds.RemoveAt(count - 1);
            }

            return new Polygon2D(point2Ds);
        }
    }
}

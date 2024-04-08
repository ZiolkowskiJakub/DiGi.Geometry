using DiGi.Geometry.Planar.Classes;
using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        public static Polyline2D ToDiGi(this LineString linearString)
        {
            List<Point2D> point2Ds = linearString?.Coordinates?.ToDiGi();
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

            return new Polyline2D(point2Ds);
        }
    }
}

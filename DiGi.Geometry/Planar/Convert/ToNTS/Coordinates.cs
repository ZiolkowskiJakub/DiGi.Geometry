using DiGi.Geometry.Planar.Classes;
using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        public static List<Coordinate> ToNTS(this IEnumerable<Point2D> point2Ds)
        {
            if (point2Ds == null)
            {
                return null;
            }

            List<Coordinate> result = new List<Coordinate>();
            foreach(Point2D point2D in point2Ds)
            {
                if(point2D == null)
                {
                    continue;
                }

                result.Add(point2D.ToNTS());
            }

            return result;
        }
    }
}

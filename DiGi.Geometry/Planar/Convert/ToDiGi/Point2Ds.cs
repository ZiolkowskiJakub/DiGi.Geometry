using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        public static List<Point2D> ToDiGi(this IEnumerable<NetTopologySuite.Geometries.Coordinate> coordinates)
        {
            if(coordinates == null)
            {
                return null;
            }

            List<Point2D> result = new List<Point2D>();
            foreach(NetTopologySuite.Geometries.Coordinate coordinate in coordinates)
            {
                Point2D point2D = coordinate.ToDiGi();
                if(point2D == null)
                {
                    continue;
                }

                result.Add(point2D);

            }

            return result;
        }
    }
}

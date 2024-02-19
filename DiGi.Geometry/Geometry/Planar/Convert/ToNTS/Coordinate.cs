using DiGi.Geometry.Planar.Classes;
using NetTopologySuite.Geometries;
using DiGi.Core;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        public static Coordinate ToNTS(this Point2D point2D)
        {
            if (point2D == null)
                return null;

            return new Coordinate(point2D.X, point2D.Y);
        }

        public static Coordinate ToNTS(this Point2D point2D, double tolerance)
        {
            if (point2D == null)
                return null;

            return new Coordinate(Query.Round(point2D.X, tolerance), Query.Round(point2D.Y, tolerance));
        }
    }
}

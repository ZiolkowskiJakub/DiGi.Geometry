using DiGi.Geometry.Core.Classes;
using DiGi.Geometry.Planar.Classes;
using System.Drawing;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        public static Point2D ToDiGi(this Point point)
        {
            return new Point2D(point.X, point.Y);
        }

        public static Point2D ToDiGi(this PointF pointF)
        {
            return new Point2D(pointF.X, pointF.Y);
        }

        public static Point2D ToDiGi(this NetTopologySuite.Geometries.Coordinate coordinate)
        {
            return new Point2D(coordinate[0], coordinate[1]);
        }

        public static Point2D ToDiGi(this NetTopologySuite.Geometries.Point point)
        {
            return new Point2D(point.X, point.Y);
        }
    }
}

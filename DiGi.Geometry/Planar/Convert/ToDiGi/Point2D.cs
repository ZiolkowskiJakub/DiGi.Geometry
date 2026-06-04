using DiGi.Geometry.Planar.Classes;
using System.Drawing;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="Point"/> instance to a <see cref="Point2D"/> instance.
        /// </summary>
        /// <param name="point">The <see cref="Point"/> instance to convert.</param>
        /// <returns>A new <see cref="Point2D"/> instance created from the provided <see cref="Point"/>.</returns>
        public static Point2D ToDiGi(this Point point)
        {
            return new Point2D(point.X, point.Y);
        }

        /// <summary>
        /// Converts a <see cref="PointF"/> instance to a <see cref="Point2D"/> instance.
        /// </summary>
        /// <param name="pointF">The <see cref="PointF"/> instance to convert.</param>
        /// <returns>A new <see cref="Point2D"/> instance created from the provided <see cref="PointF"/>.</returns>
        public static Point2D ToDiGi(this PointF pointF)
        {
            return new Point2D(pointF.X, pointF.Y);
        }

        /// <summary>
        /// Converts a <see cref="NetTopologySuite.Geometries.Coordinate"/> to a <see cref="Point2D"/>.
        /// </summary>
        /// <param name="coordinate">The <see cref="NetTopologySuite.Geometries.Coordinate"/> instance to convert.</param>
        /// <returns>A new <see cref="Point2D"/> object created from the coordinate values.</returns>
        public static Point2D ToDiGi(this NetTopologySuite.Geometries.Coordinate coordinate)
        {
            return new Point2D(coordinate[0], coordinate[1]);
        }

        /// <summary>
        /// Converts a <see cref="NetTopologySuite.Geometries.Point"/> to a <see cref="Point2D"/>.
        /// </summary>
        /// <param name="point">The <see cref="NetTopologySuite.Geometries.Point"/> instance to convert.</param>
        /// <returns>A new <see cref="Point2D"/> object created from the coordinates of the provided point.</returns>
        public static Point2D ToDiGi(this NetTopologySuite.Geometries.Point point)
        {
            return new Point2D(point.X, point.Y);
        }
    }
}
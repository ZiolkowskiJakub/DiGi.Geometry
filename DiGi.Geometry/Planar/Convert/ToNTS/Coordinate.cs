using DiGi.Geometry.Planar.Classes;
using NetTopologySuite.Geometries;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="Point2D"/> instance to an NTS <see cref="Coordinate"/>.
        /// </summary>
        /// <param name="point2D">The <see cref="Point2D"/> instance to convert.</param>
        /// <returns>A <see cref="Coordinate"/> instance if the provided <see cref="Point2D"/> is not null; otherwise, null.</returns>
        public static Coordinate? ToNTS(this Point2D? point2D)
        {
            if (point2D == null)
            {
                return null;
            }

            return new Coordinate(point2D.X, point2D.Y);
        }

        /// <summary>
        /// Converts a <see cref="Point2D"/> to an NTS <see cref="Coordinate"/>, rounding the coordinates using the specified tolerance.
        /// </summary>
        /// <param name="point2D">The <see cref="Point2D"/> instance to convert.</param>
        /// <param name="tolerance">The <see cref="double"/> value used for rounding the X and Y coordinates.</param>
        /// <returns>A <see cref="Coordinate"/> object if the provided <see cref="Point2D"/> is not null; otherwise, returns null.</returns>
        public static Coordinate? ToNTS(this Point2D? point2D, double tolerance)
        {
            if (point2D == null)
            {
                return null;
            }

            return new Coordinate(DiGi.Core.Query.Round(point2D.X, tolerance), DiGi.Core.Query.Round(point2D.Y, tolerance));
        }
    }
}
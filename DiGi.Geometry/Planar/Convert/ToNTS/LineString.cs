using DiGi.Geometry.Planar.Classes;
using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts the specified <see cref="Polyline2D"/> to an NTS <see cref="LineString"/>.
        /// </summary>
        /// <param name="polyline2D">The <see cref="Polyline2D"/> instance to convert.</param>
        /// <returns>An NTS <see cref="LineString"/> if the conversion is successful; otherwise, <c>null</c>.</returns>
        public static LineString? ToNTS(this Polyline2D? polyline2D)
        {
            List<Coordinate>? coordinates = polyline2D?.GetPoints()?.ToNTS();
            if (coordinates == null)
            {
                return null;
            }

            return new LineString([.. coordinates]);
        }

        /// <summary>
        /// Converts the specified <see cref="Segment2D"/> to an NTS <see cref="LineString"/>.
        /// </summary>
        /// <param name="segment2D">The <see cref="Segment2D"/> instance to convert.</param>
        /// <returns>An NTS <see cref="LineString"/> if the conversion is successful; otherwise, <c>null</c>.</returns>
        public static LineString? ToNTS_LineString(this Segment2D? segment2D)
        {
            List<Coordinate>? coordinates = segment2D?.GetPoints()?.ToNTS();
            if (coordinates == null)
            {
                return null;
            }

            return new LineString([.. coordinates]);
        }
    }
}
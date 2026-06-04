using DiGi.Geometry.Planar.Classes;
using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="LineString"/> to a <see cref="Polyline2D"/>.
        /// </summary>
        /// <param name="linearString">The <see cref="LineString"/> instance to convert.</param>
        /// <returns>A <see cref="Polyline2D"/> instance if the conversion is successful and contains at least 3 points; otherwise, <c>null</c>.</returns>
        public static Polyline2D? ToDiGi(this LineString? linearString)
        {
            List<Point2D>? point2Ds = linearString?.Coordinates?.ToDiGi();
            if (point2Ds == null)
            {
                return null;
            }

            int count = point2Ds.Count;
            if (count < 3)
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
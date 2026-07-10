using DiGi.Geometry.Planar.Classes;
using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="LinearRing"/> to a <see cref="Polygon2D"/>.
        /// </summary>
        /// <param name="linearRing">The <see cref="LinearRing"/> instance to convert.</param>
        /// <returns>A <see cref="Polygon2D"/> instance if the conversion is successful; otherwise, <c>null</c>.</returns>
        public static Polygon2D? ToDiGi(this LinearRing? linearRing)
        {
            List<Point2D>? point2Ds = linearRing?.Coordinates?.ToDiGi();
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

            return new Polygon2D(point2Ds, false);
        }
    }
}
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts an <see cref="IPolygonal2D"/> instance to a NetTopologySuite <see cref="LinearRing"/>.
        /// </summary>
        /// <param name="polygonal2D">The <see cref="IPolygonal2D"/> instance to convert.</param>
        /// <returns>A <see cref="LinearRing"/> if the conversion is successful; otherwise, <see langword="null"/>.</returns>
        public static LinearRing? ToNTS(this IPolygonal2D? polygonal2D)
        {
            if (polygonal2D == null)
            {
                return null;
            }

            if (polygonal2D is Segmentable2D segmentable2D)
            {
                Coordinate[]? coordinates = segmentable2D.ToNTS_Coordinates(true);
                if (coordinates == null || coordinates.Length < 4)
                {
                    return null;
                }

                return new LinearRing(coordinates);
            }

            List<Point2D>? point2Ds = polygonal2D.GetPoints();
            if (point2Ds == null || point2Ds.Count < 3)
            {
                return null;
            }

            List<Coordinate>? cooridnates = point2Ds.ToNTS();
            if (cooridnates == null)
            {
                return null;
            }

            cooridnates.Add(cooridnates[0]);

            return new LinearRing([.. cooridnates]);
        }
    }
}
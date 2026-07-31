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
                Coordinate[]? coordinates_Segmentable2D = segmentable2D.ToNTS_Coordinates(true);
                if (coordinates_Segmentable2D == null || coordinates_Segmentable2D.Length < 4)
                {
                    return null;
                }

                // A ring closed with a not-a-number coordinate is still rejected by NetTopologySuite, because
                // its closed test compares the first and the last coordinate and NaN never equals NaN. Such a
                // ring cannot describe an area, so it is reported as not convertible rather than thrown on.
                if (!coordinates_Segmentable2D.IsValid())
                {
                    return null;
                }

                return new LinearRing(coordinates_Segmentable2D);
            }

            List<Point2D>? point2Ds = polygonal2D.GetPoints();
            if (point2Ds == null || point2Ds.Count < 3)
            {
                return null;
            }

            List<Coordinate>? coordinates = point2Ds.ToNTS();
            if (coordinates == null)
            {
                return null;
            }

            coordinates.Add(coordinates[0]);

            if (!coordinates.IsValid())
            {
                return null;
            }

            return new LinearRing([.. coordinates]);
        }
    }
}
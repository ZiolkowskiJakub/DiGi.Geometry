using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Geometries;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts an <see cref="IGeometry2D"/> instance to a <see cref="NetTopologySuite.Geometries.Geometry"/> object.
        /// </summary>
        /// <param name="sAMGeometry2D">The <see cref="IGeometry2D"/> geometry to convert.</param>
        /// <returns>A <see cref="NetTopologySuite.Geometries.Geometry"/> representation of the input geometry, or <see langword="null"/> if the provided <see cref="IGeometry2D"/> is <see langword="null"/>.</returns>
        public static NetTopologySuite.Geometries.Geometry? ToNTS(this IGeometry2D? sAMGeometry2D)
        {
            if (sAMGeometry2D == null)
            {
                return null;
            }

            if (sAMGeometry2D is Point2D point2D)
            {
                Coordinate? coordinate = ToNTS(point2D);
                if (coordinate == null)
                {
                    return null;
                }

                return new Point(coordinate);
            }

            if (sAMGeometry2D is IPolygonal2D polygonal2D)
            {
                return ToNTS(polygonal2D);
            }

            if (sAMGeometry2D is IPolygonalFace2D polygonalFace2D)
            {
                return ToNTS(polygonalFace2D);
            }

            if (sAMGeometry2D is Segment2D segment2D)
            {
                return ToNTS_LineString(segment2D);
            }

            if (sAMGeometry2D is Polyline2D polyline2D)
            {
                return ToNTS(polyline2D);
            }

            return null;
        }
    }
}
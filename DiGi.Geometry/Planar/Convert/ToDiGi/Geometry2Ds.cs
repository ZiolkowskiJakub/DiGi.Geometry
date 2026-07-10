using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="NetTopologySuite.Geometries.Geometry"/> of any dimension to a flat list of <see cref="IGeometry2D"/> objects.
        /// <para>Nested <see cref="GeometryCollection"/> instances (including <see cref="MultiPolygon"/>, <see cref="MultiLineString"/> and <see cref="MultiPoint"/>) are flattened. Polygons convert to <see cref="PolygonalFace2D"/>, linear rings to <see cref="Polygon2D"/>, two-point line strings to <see cref="Segment2D"/>, longer line strings to <see cref="Polyline2D"/> and points to <see cref="Point2D"/>. Empty components are skipped.</para>
        /// </summary>
        /// <param name="geometry">The <see cref="NetTopologySuite.Geometries.Geometry"/> instance to convert.</param>
        /// <returns>A list of <see cref="IGeometry2D"/> objects (possibly empty), or <see langword="null"/> if the provided geometry is <see langword="null"/>.</returns>
        public static List<IGeometry2D>? ToDiGi_Geometry2Ds(this NetTopologySuite.Geometries.Geometry? geometry)
        {
            if (geometry == null)
            {
                return null;
            }

            List<IGeometry2D> result = [];

            Stack<NetTopologySuite.Geometries.Geometry> geometries = new();
            geometries.Push(geometry);

            while (geometries.Count > 0)
            {
                NetTopologySuite.Geometries.Geometry geometry_Current = geometries.Pop();
                if (geometry_Current == null || geometry_Current.IsEmpty)
                {
                    continue;
                }

                if (geometry_Current is Polygon polygon)
                {
                    PolygonalFace2D? polygonalFace2D = polygon.ToDiGi();
                    if (polygonalFace2D != null)
                    {
                        result.Add(polygonalFace2D);
                    }
                }
                else if (geometry_Current is LinearRing linearRing)
                {
                    Polygon2D? polygon2D = linearRing.ToDiGi();
                    if (polygon2D != null)
                    {
                        result.Add(polygon2D);
                    }
                }
                else if (geometry_Current is LineString lineString)
                {
                    Coordinate[] coordinates = lineString.Coordinates;
                    if (coordinates == null || coordinates.Length < 2)
                    {
                        continue;
                    }

                    if (coordinates.Length == 2)
                    {
                        result.Add(new Segment2D(coordinates[0].ToDiGi(), coordinates[1].ToDiGi()));
                    }
                    else
                    {
                        Polyline2D? polyline2D = lineString.ToDiGi();
                        if (polyline2D != null)
                        {
                            result.Add(polyline2D);
                        }
                    }
                }
                else if (geometry_Current is NetTopologySuite.Geometries.Point point)
                {
                    result.Add(point.ToDiGi());
                }
                else if (geometry_Current is GeometryCollection geometryCollection)
                {
                    // Push in reverse so the flattened output preserves the collection order
                    for (int i = geometryCollection.NumGeometries - 1; i >= 0; i--)
                    {
                        geometries.Push(geometryCollection.GetGeometryN(i));
                    }
                }
            }

            return result;
        }
    }
}

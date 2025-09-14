using NetTopologySuite.Geometries;
using NetTopologySuite.Geometries.Prepared;
using NetTopologySuite.Triangulate;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static List<Polygon>? Triangulate(this Polygon? polygon, double tolerance = DiGi.Core.Constans.Tolerance.MicroDistance)
        {
            if (polygon == null)
            {
                return null;
            }

            GeometryFactory geometryFactory = new(new PrecisionModel(1 / tolerance));

            GeometryCollection? geometryCollection;

            if (polygon.Holes != null && polygon.Holes.Length != 0)
            {
                Envelope envelope = polygon.Boundary.EnvelopeInternal;

                double buffer = 0.5 * envelope.MaxExtent;

                envelope = new Envelope(envelope.MinX - buffer, envelope.MaxX + buffer, envelope.MinY - buffer, envelope.MaxY + buffer);

                NetTopologySuite.Geometries.Geometry geometry = (NetTopologySuite.Geometries.Geometry?)geometryFactory.CreateGeometryCollection([polygon, geometryFactory.ToGeometry(envelope)]) ?? polygon;
                if (geometry == null)
                {
                    return null;
                }

                ConformingDelaunayTriangulationBuilder conformingDelaunayTriangulationBuilder = new ();

                conformingDelaunayTriangulationBuilder.SetSites(geometry);
                conformingDelaunayTriangulationBuilder.Constraints = geometry;

                geometryCollection = conformingDelaunayTriangulationBuilder.GetTriangles(geometryFactory);
                if (geometryCollection == null)
                {
                    return null;
                }

                List<NetTopologySuite.Geometries.Geometry> geometries_Temp = [];

                IPreparedGeometry preparedGeometry = PreparedGeometryFactory.Prepare(geometry);

                foreach (NetTopologySuite.Geometries.Geometry geometry_Temp in geometryCollection)
                {
                    if (preparedGeometry.Contains(geometry_Temp))
                    {
                        geometries_Temp.Add(geometry_Temp);
                    }
                }

                geometry = geometryFactory.BuildGeometry(geometries_Temp);

                geometryCollection = geometry is GeometryCollection geometryCollection_Temp ? geometryCollection_Temp : new GeometryCollection([geometry], geometryFactory);
            }
            else
            {
                Coordinate[] coordinates = polygon.Coordinates;
                if (coordinates == null || coordinates.Length < 3)
                {
                    return null;
                }

                if (coordinates.Length == 3)
                {
                    return [polygon];
                }

                DelaunayTriangulationBuilder delaunayTriangulationBuilder = new ();
                delaunayTriangulationBuilder.SetSites(polygon);

                geometryCollection = delaunayTriangulationBuilder.GetTriangles(geometryFactory);
            }

            if (geometryCollection == null)
            {
                return null;
            }

            List<Polygon> polygons = [];
            foreach (NetTopologySuite.Geometries.Geometry geometry_Temp in geometryCollection.Geometries)
            {
                Polygon? polygon_Temp = geometry_Temp as Polygon;
                if (polygon_Temp == null)
                {
                    continue;
                }

                polygons.Add(polygon_Temp);
            }

            List<Polygon> result = [];
            foreach (Polygon polygon_Temp in polygons)
            {
                NetTopologySuite.Geometries.Geometry geometry_Intersection = polygon.Intersection(polygon_Temp);

                List<Polygon> polygons_Intersection = [];
                if (geometry_Intersection is Polygon polygon_Temp_Temp)
                {
                    polygons_Intersection.Add(polygon_Temp_Temp);
                }
                else if (geometry_Intersection is GeometryCollection geometryCollection_Temp)
                {
                    foreach (NetTopologySuite.Geometries.Geometry geometry_Temp in geometryCollection_Temp)
                    {
                        if (geometry_Temp is Polygon polygon_Temp_Temp_Temp)
                        {
                            polygons_Intersection.Add(polygon_Temp_Temp_Temp);
                        }
                    }
                }

                foreach (Polygon polygon_Intersection in polygons_Intersection)
                {
                    if (DiGi.Core.Query.AlmostEquals(polygon_Temp.Area, polygon_Intersection.Area, tolerance))
                    {
                        result.Add(polygon_Intersection);
                        continue;
                    }

                    List<Polygon>? polygons_Temp_Temp = Triangulate(polygon_Intersection, tolerance);
                    if (polygons_Temp_Temp == null || polygons_Temp_Temp.Count == 0)
                    {
                        continue;
                    }

                    result.AddRange(polygons_Temp_Temp);
                }
            }

            return result;
        }
    }
}

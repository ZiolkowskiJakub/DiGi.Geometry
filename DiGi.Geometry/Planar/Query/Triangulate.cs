using DiGi.Geometry.Planar.Classes;
using DiGi.Math.Classes;
using NetTopologySuite.Geometries;
using NetTopologySuite.Geometries.Prepared;
using NetTopologySuite.Triangulate;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static List<Polygon> Triangulate(this Polygon polygon, double tolerance = DiGi.Core.Constans.Tolerance.MicroDistance)
        {
            if (polygon == null)
            {
                return null;
            }

            GeometryFactory geometryFactory = new GeometryFactory(new PrecisionModel(1 / tolerance));

            GeometryCollection geometryCollection = null;

            if (polygon.Holes != null && polygon.Holes.Length != 0)
            {
                Envelope envelope = polygon.Boundary.EnvelopeInternal;

                double buffer = 0.5 * envelope.MaxExtent;

                envelope = new Envelope(envelope.MinX - buffer, envelope.MaxX + buffer, envelope.MinY - buffer, envelope.MaxY + buffer);

                NetTopologySuite.Geometries.Geometry geometry = geometryFactory.CreateGeometryCollection(new[] { polygon, geometryFactory.ToGeometry(envelope) });
                if (geometry == null)
                {
                    geometry = polygon;
                }

                if (geometry == null)
                {
                    return null;
                }

                ConformingDelaunayTriangulationBuilder conformingDelaunayTriangulationBuilder = new ConformingDelaunayTriangulationBuilder();

                conformingDelaunayTriangulationBuilder.SetSites(geometry);
                conformingDelaunayTriangulationBuilder.Constraints = geometry;

                geometryCollection = conformingDelaunayTriangulationBuilder.GetTriangles(geometryFactory);
                if (geometryCollection == null)
                {
                    return null;
                }

                List<NetTopologySuite.Geometries.Geometry> geometries_Temp = new List<NetTopologySuite.Geometries.Geometry>();

                IPreparedGeometry preparedGeometry = PreparedGeometryFactory.Prepare(geometry);

                foreach (NetTopologySuite.Geometries.Geometry geometry_Temp in geometryCollection)
                {
                    if (preparedGeometry.Contains(geometry_Temp))
                    {
                        geometries_Temp.Add(geometry_Temp);
                    }
                }

                geometry = geometryFactory.BuildGeometry(geometries_Temp);

                geometryCollection = geometry is GeometryCollection ? (GeometryCollection)geometry : new GeometryCollection(new NetTopologySuite.Geometries.Geometry[] { geometry }, geometryFactory);
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
                    return new List<Polygon>() { polygon };
                }

                DelaunayTriangulationBuilder delaunayTriangulationBuilder = new DelaunayTriangulationBuilder();
                delaunayTriangulationBuilder.SetSites(polygon);

                geometryCollection = delaunayTriangulationBuilder.GetTriangles(geometryFactory);
            }

            if (geometryCollection == null)
            {
                return null;
            }

            List<Polygon> polygons = new List<Polygon>();
            foreach (NetTopologySuite.Geometries.Geometry geometry_Temp in geometryCollection.Geometries)
            {
                Polygon polygon_Temp = geometry_Temp as Polygon;
                if (polygon == null)
                {
                    continue;
                }

                polygons.Add(polygon_Temp);
            }

            List<Polygon> result = new List<Polygon>();
            foreach (Polygon polygon_Temp in polygons)
            {
                NetTopologySuite.Geometries.Geometry geometry_Intersection = polygon.Intersection(polygon_Temp);

                List<Polygon> polygons_Intersection = new List<Polygon>();
                if (geometry_Intersection is Polygon)
                {
                    polygons_Intersection.Add((Polygon)geometry_Intersection);
                }
                else if (geometry_Intersection is GeometryCollection)
                {
                    foreach (NetTopologySuite.Geometries.Geometry geometry_Temp in (GeometryCollection)geometry_Intersection)
                    {
                        if (geometry_Temp is Polygon)
                        {
                            polygons_Intersection.Add((Polygon)geometry_Temp);
                        }
                    }
                }

                foreach (Polygon polygon_Intersection in polygons_Intersection)
                {
                    if (DiGi.Core.Query.AlmostEqual(polygon_Temp.Area, polygon_Intersection.Area, tolerance))
                    {
                        result.Add(polygon_Intersection);
                        continue;
                    }

                    List<Polygon> polygons_Temp_Temp = Triangulate(polygon_Intersection, tolerance);
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

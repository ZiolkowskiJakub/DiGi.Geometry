using NetTopologySuite.Geometries;
using NetTopologySuite.Geometries.Prepared;
using NetTopologySuite.Triangulate;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Triangulates the specified polygon into a set of smaller triangle polygons.
        /// </summary>
        /// <param name="polygon">The polygon to be triangulated.</param>
        /// <param name="tolerance">The distance tolerance used for precision during the triangulation process.</param>
        /// <returns>A list of triangles that represent the original polygon, or null if the input polygon is null or the triangulation fails.</returns>
        public static List<Polygon>? Triangulate(this Polygon? polygon, double tolerance = DiGi.Core.Constants.Tolerance.MicroDistance)
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

                ConformingDelaunayTriangulationBuilder conformingDelaunayTriangulationBuilder = new();

                conformingDelaunayTriangulationBuilder.SetSites(geometry);
                conformingDelaunayTriangulationBuilder.Constraints = geometry;

                geometryCollection = conformingDelaunayTriangulationBuilder.GetTriangles(geometryFactory);
                if (geometryCollection == null)
                {
                    return null;
                }

                List<NetTopologySuite.Geometries.Geometry> geometries_Temp = [];

                // The conforming Delaunay triangulation covers the whole convex domain, so it also
                // produces triangles inside the holes and inside the envelope padding that was added
                // only to bound the triangulation. Those must be discarded, keeping just the triangles
                // that fall inside the face (outside every hole).
                //
                // The keep test uses each triangle's representative interior point against the polygon,
                // NOT a whole-triangle NetTopologySuite.Geometries.Geometry.Contains(triangle):
                //   * The Delaunay vertices are snapped to the triangulation precision grid, which does
                //     not coincide exactly with the polygon boundary. A triangle that genuinely lies
                //     inside the face but shares an edge/vertex with the boundary then fails the strict
                //     whole-triangle containment test and is dropped, punching holes in the mesh (for a
                //     courtyard footprint this discarded roughly a third of the cap area).
                //   * The interior point is guaranteed strictly inside the triangle, so it is immune to
                //     that boundary snapping. Triangles that slightly overshoot the boundary or a hole
                //     are still clipped back to the exact face by the intersection pass below.
                // The predicate is prepared over the polygon alone, not the [polygon, envelope]
                // collection used as the triangulation domain, so the hole and the padding are excluded.
                IPreparedGeometry preparedGeometry = PreparedGeometryFactory.Prepare(polygon);

                foreach (NetTopologySuite.Geometries.Geometry geometry_Temp in geometryCollection)
                {
                    if (preparedGeometry.Contains(geometry_Temp.InteriorPoint))
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

                DelaunayTriangulationBuilder delaunayTriangulationBuilder = new();
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
                    // Accept the clipped piece as-is only when it is already a triangle (a closed ring
                    // of three distinct vertices has four coordinates) and its area still matches the
                    // source triangle, i.e. the triangle sat inside the face and was not really clipped.
                    // The coordinate-count guard is essential: a triangle that overshoots the boundary
                    // by a negligible area is clipped to a quadrilateral whose area still matches, and
                    // without the guard that quadrilateral would be returned even though this method
                    // contracts to return triangles only. Callers such as PolygonalFace2D.Triangulate
                    // keep only four-coordinate triangles, so a returned quadrilateral would be dropped
                    // and leave a hole in the mesh.
                    if (polygon_Intersection.Coordinates.Length == 4 && DiGi.Core.Query.AlmostEquals(polygon_Temp.Area, polygon_Intersection.Area, tolerance))
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
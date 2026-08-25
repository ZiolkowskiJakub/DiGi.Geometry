using NetTopologySuite.Geometries;
using NetTopologySuite.Geometries.Utilities;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Triangulates the specified polygon into a set of smaller triangle polygons.
        /// </summary>
        /// <remarks>
        /// The triangles are cut from the corners the polygon already has, by ear clipping, so no corner is invented and none of the ones that were there is moved. That is what lets a triangulated shape stay flush with whatever it was cut from, and it is why a conforming Delaunay triangulation is not used here: that one inserts corners of its own, and enforcing the constraints it needs to do so does not converge on a shape carrying narrow slivers, which is exactly what subtracting the outlines of neighbouring buildings from one surface leaves behind.
        /// <para>An invalid or self-intersecting polygon is repaired (<see cref="GeometryFixer"/>) rather than rejected, and each lobe of the repaired shape is triangulated on its own, so a failure on one of them costs only that lobe. Holes are supported: they are joined onto the shell before the ring is cut up.</para>
        /// </remarks>
        /// <param name="polygon">The polygon to be triangulated.</param>
        /// <param name="tolerance">The distance tolerance used for precision during the triangulation process.</param>
        /// <returns>A list of triangles that represent the original polygon, or null if the input polygon is null or the triangulation fails.</returns>
        public static List<Polygon>? Triangulate(this Polygon? polygon, double tolerance = DiGi.Core.Constants.Tolerance.MicroDistance)
        {
            if (polygon == null || polygon.IsEmpty)
            {
                return null;
            }

            Coordinate[]? coordinates = polygon.Coordinates;
            if (coordinates == null || coordinates.Length < 3)
            {
                return null;
            }

            // A closed ring of three distinct corners has four coordinates: the polygon already is the
            // triangle being asked for, and nothing is gained by taking it apart and putting it back.
            if (polygon.NumInteriorRings == 0 && coordinates.Length == 4)
            {
                return [polygon];
            }

            // Ear clipping works on the corners of the ring as they stand, so it has no constraints to
            // enforce and nothing to fail to converge on. Holes are joined onto the shell first, which
            // leaves a ring touching itself - invalid as a polygon, but exactly what the ear clipper takes.
            List<Polygon>? EarClip(Polygon polygon_Input)
            {
                NetTopologySuite.Geometries.Geometry? geometry_Triangles;
                try
                {
                    geometry_Triangles = NetTopologySuite.Triangulate.Polygon.PolygonTriangulator.Triangulate(polygon_Input);
                }
                catch (System.Exception)
                {
                    return null;
                }

                if (geometry_Triangles == null || geometry_Triangles.IsEmpty)
                {
                    return null;
                }

                double area = 0;

                List<Polygon> polygons_Triangles = [];
                for (int i = 0; i < geometry_Triangles.NumGeometries; i++)
                {
                    if (geometry_Triangles.GetGeometryN(i) is not Polygon polygon_Triangle || polygon_Triangle.IsEmpty)
                    {
                        continue;
                    }

                    // This method contracts to return triangles only, and its callers keep just the four
                    // coordinates of a closed three corner ring. A sliver covering less than the tolerance
                    // is dropped rather than handed on.
                    if (polygon_Triangle.NumInteriorRings != 0 || polygon_Triangle.Coordinates.Length != 4 || polygon_Triangle.Area < tolerance)
                    {
                        continue;
                    }

                    area += polygon_Triangle.Area;
                    polygons_Triangles.Add(polygon_Triangle);
                }

                if (polygons_Triangles.Count == 0)
                {
                    return null;
                }

                // The triangles have to tile the whole lobe, and a ring that still crosses itself after
                // the repair is cut up into something covering the wrong area rather than into nothing at
                // all. Such a lobe is dropped: handing on triangles that do not describe the shape they came
                // from puts a visibly wrong surface in front of whoever is looking at it, which is worse
                // than losing the lobe.
                if (System.Math.Abs(area - polygon_Input.Area) > System.Math.Max(polygon_Input.Area * 1e-6, tolerance))
                {
                    return null;
                }

                return polygons_Triangles;
            }

            // The repair is what the ear clipper needs: it copes with a ring touching itself, but not with
            // one crossing itself. A repaired self-intersecting ring comes back as its lobes, and each of
            // them is cut up on its own so none of them is lost.
            NetTopologySuite.Geometries.Geometry? geometry_Repaired = polygon.IsValid ? polygon : GeometryFixer.Fix(polygon);
            if (geometry_Repaired == null || geometry_Repaired.IsEmpty)
            {
                return null;
            }

            List<Polygon> result = [];
            for (int i = 0; i < geometry_Repaired.NumGeometries; i++)
            {
                if (geometry_Repaired.GetGeometryN(i) is not Polygon polygon_Component || polygon_Component.IsEmpty || polygon_Component.Area < tolerance)
                {
                    continue;
                }

                List<Polygon>? polygons_Component = EarClip(polygon_Component);
                if (polygons_Component != null)
                {
                    result.AddRange(polygons_Component);
                }
            }

            return result;
        }
    }
}

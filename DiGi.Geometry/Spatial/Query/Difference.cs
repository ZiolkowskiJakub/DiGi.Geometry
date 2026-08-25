using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using NetTopologySuite.Geometries;
using NetTopologySuite.Geometries.Prepared;
using NetTopologySuite.Geometries.Utilities;
using NetTopologySuite.Index.Strtree;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the 3D boolean difference between two polyhedra.
        /// </summary>
        /// <remarks>
        /// The computation is delegated to <see cref="Create.DifferenceResult3D{TPolygonalFace3D}(Polyhedron{TPolygonalFace3D}?, Polyhedron{TPolygonalFace3D}?, double)"/>; only the polyhedra of the result are returned. Use the result object directly to access lower-dimensional geometry elements.
        /// </remarks>
        /// <typeparam name="TPolygonalFace3D">The type of polygonal face, which must implement <see cref="IPolygonalFace3D"/>.</typeparam>
        /// <param name="polyhedron_1">The first polyhedron (from which to subtract).</param>
        /// <param name="polyhedron_2">The second polyhedron (to subtract).</param>
        /// <param name="tolerance">The distance tolerance for boolean difference computations.</param>
        /// <returns>A list of <see cref="Polyhedron"/> objects representing the resulting difference, or <c>null</c> if either input is null.</returns>
        public static List<Polyhedron>? Difference<TPolygonalFace3D>(this Polyhedron<TPolygonalFace3D>? polyhedron_1, Polyhedron<TPolygonalFace3D>? polyhedron_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance) where TPolygonalFace3D : IPolygonalFace3D
        {
            if (polyhedron_1 == null || polyhedron_2 == null)
            {
                return null;
            }

            DifferenceResult3D? differenceResult3D = Create.DifferenceResult3D(polyhedron_1, polyhedron_2, tolerance);
            if (differenceResult3D == null)
            {
                return null;
            }

            return differenceResult3D.GetGeometry3Ds<Polyhedron>() ?? [];
        }

        /// <summary>
        /// Cuts plan view openings out of a mesh, subtracting each polygon from the mesh as seen from above while keeping the elevations of the mesh.
        /// <para>The subtraction is 2.5D, not a solid boolean: every triangle is clipped in plan and the corners of what remains are put back onto the plane of the triangle they were cut from, so a surface stays a surface and keeps its shape. This is what cuts building footprints out of a terrain surface.</para>
        /// </summary>
        /// <remarks>
        /// The operation is deliberately defensive, because it runs on measured data feeding a 3D view.
        /// <para>A triangle carrying a not-a-number corner is dropped, an invalid or self-intersecting cutting polygon is repaired (<see cref="GeometryFixer"/>) rather than rejected, and a cutting polygon smaller than the tolerance is ignored.</para>
        /// <para>A triangle with no plan area (a vertical one) is passed on exactly as it came in: no plan view polygon can take anything away from it and no elevation can be interpolated across it, so dropping it would leave a gap for no reason. A triangle whose subtraction fails on a topology error, or whose remainder cannot be triangulated, is passed on for the same reason - a stray triangle inside one building is a far smaller defect than a hole in the ground around it. Either way the failure costs that one triangle and never the surface around it.</para>
        /// </remarks>
        /// <param name="mesh3D">The mesh to cut. This value can be null.</param>
        /// <param name="polygons">The polygons to cut out, in the plan view (X, Y) coordinates of the mesh. This value can be null.</param>
        /// <param name="tolerance">The distance tolerance used for the plan view subtraction, for the triangulation of what remains and for the welding of the resulting mesh.</param>
        /// <returns>A new <see cref="Mesh3D"/> holding the mesh with the polygons cut out, a clone of the mesh when there is nothing to cut, or <see langword="null"/> when the mesh is null or nothing of it remains.</returns>
        public static Mesh3D? Difference(this Mesh3D? mesh3D, IEnumerable<Polygon>? polygons, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (mesh3D == null)
            {
                return null;
            }

            List<Point3D>? point3Ds = mesh3D.GetPoints();
            List<int[]>? indexes = mesh3D.GetIndexes();
            if (point3Ds == null || point3Ds.Count == 0 || indexes == null || indexes.Count == 0)
            {
                return new Mesh3D(mesh3D);
            }

            #region Cutters

            // Each cutting polygon is validated, repaired and prepared exactly once. The prepared form
            // carries its own segment index, which is what makes the per triangle Covers and Intersects
            // tests below cheap enough to run over a whole terrain surface.
            List<IPreparedGeometry> preparedGeometries = [];
            if (polygons != null)
            {
                foreach (Polygon polygon in polygons)
                {
                    if (polygon == null || polygon.IsEmpty || !Planar.Query.IsValid(polygon.Coordinates))
                    {
                        continue;
                    }

                    NetTopologySuite.Geometries.Geometry geometry = polygon.IsValid ? polygon : GeometryFixer.Fix(polygon);
                    if (geometry == null)
                    {
                        continue;
                    }

                    // A repaired self-intersecting polygon comes back as a multi polygon of its lobes, and
                    // each lobe is indexed on its own so none of them is lost.
                    for (int i = 0; i < geometry.NumGeometries; i++)
                    {
                        if (geometry.GetGeometryN(i) is not Polygon polygon_Cutter || polygon_Cutter.IsEmpty || polygon_Cutter.Area < tolerance)
                        {
                            continue;
                        }

                        preparedGeometries.Add(PreparedGeometryFactory.Prepare(polygon_Cutter));
                    }
                }
            }

            if (preparedGeometries.Count == 0)
            {
                return new Mesh3D(mesh3D);
            }

            STRtree<IPreparedGeometry> sTRtree = new();
            foreach (IPreparedGeometry preparedGeometry in preparedGeometries)
            {
                sTRtree.Insert(preparedGeometry.Geometry.EnvelopeInternal, preparedGeometry);
            }

            sTRtree.Build();

            #endregion Cutters

            // A remainder that is convex needs no triangulator: fanning it from its first corner is exact.
            // Most clipped triangles are exactly that, and the fan is what keeps the cost of the whole
            // operation off the general triangulator. The convexity test is what makes the fan safe - the
            // same fan applied to a concave ring folds triangles outside the shape.
            List<Coordinate[]>? ConvexFan(Polygon polygon_Convex)
            {
                if (polygon_Convex.NumInteriorRings != 0)
                {
                    return null;
                }

                Coordinate[]? coordinates_Ring = polygon_Convex.ExteriorRing?.Coordinates;
                if (coordinates_Ring == null || coordinates_Ring.Length < 4 || coordinates_Ring.Length > 7)
                {
                    return null;
                }

                int count = coordinates_Ring.Length - 1;

                int sign = 0;
                for (int i = 0; i < count; i++)
                {
                    Coordinate coordinate_1 = coordinates_Ring[i];
                    Coordinate coordinate_2 = coordinates_Ring[(i + 1) % count];
                    Coordinate coordinate_3 = coordinates_Ring[(i + 2) % count];

                    double cross = ((coordinate_2.X - coordinate_1.X) * (coordinate_3.Y - coordinate_2.Y)) - ((coordinate_2.Y - coordinate_1.Y) * (coordinate_3.X - coordinate_2.X));
                    if (System.Math.Abs(cross) < tolerance)
                    {
                        continue;
                    }

                    int sign_Corner = cross > 0 ? 1 : -1;
                    if (sign == 0)
                    {
                        sign = sign_Corner;
                    }
                    else if (sign != sign_Corner)
                    {
                        return null;
                    }
                }

                if (sign == 0)
                {
                    return null;
                }

                List<Coordinate[]> result = [];
                for (int i = 1; i < count - 1; i++)
                {
                    result.Add([coordinates_Ring[0], coordinates_Ring[i], coordinates_Ring[i + 1]]);
                }

                return result;
            }

            GeometryFactory geometryFactory = new();

            // Subtracting several cutters from the same triangle one after another leaves rings carrying
            // corners a fraction of the tolerance apart. That matters because the triangulator snaps to that
            // same tolerance: such a ring comes back out of it unchanged, which used to recurse until the
            // stack gave out. Cleaning the ring first is what keeps it out of that state, and it lets far
            // more remainders take the fan above instead of the triangulator at all.
            Polygon? Clean(Polygon polygon_Dirty)
            {
                LinearRing? CleanRing(LineString? lineString)
                {
                    Coordinate[]? coordinates_Ring = lineString?.Coordinates;
                    if (coordinates_Ring == null || coordinates_Ring.Length < 4)
                    {
                        return null;
                    }

                    List<Coordinate> coordinates_Clean = [];
                    foreach (Coordinate coordinate in coordinates_Ring)
                    {
                        if (coordinates_Clean.Count != 0 && coordinates_Clean[coordinates_Clean.Count - 1].Distance(coordinate) <= tolerance)
                        {
                            continue;
                        }

                        coordinates_Clean.Add(coordinate);
                    }

                    while (coordinates_Clean.Count > 1 && coordinates_Clean[0].Distance(coordinates_Clean[coordinates_Clean.Count - 1]) <= tolerance)
                    {
                        coordinates_Clean.RemoveAt(coordinates_Clean.Count - 1);
                    }

                    if (coordinates_Clean.Count < 3)
                    {
                        return null;
                    }

                    coordinates_Clean.Add(coordinates_Clean[0].Copy());

                    return geometryFactory.CreateLinearRing([.. coordinates_Clean]);
                }

                LinearRing? linearRing_Shell = CleanRing(polygon_Dirty.ExteriorRing);
                if (linearRing_Shell == null)
                {
                    return null;
                }

                List<LinearRing> linearRings_Holes = [];
                for (int i = 0; i < polygon_Dirty.NumInteriorRings; i++)
                {
                    LinearRing? linearRing_Hole = CleanRing(polygon_Dirty.GetInteriorRingN(i));
                    if (linearRing_Hole != null)
                    {
                        linearRings_Holes.Add(linearRing_Hole);
                    }
                }

                return geometryFactory.CreatePolygon(linearRing_Shell, [.. linearRings_Holes]);
            }

            List<Triangle3D> triangle3Ds = [];

            foreach (int[] index in indexes)
            {
                if (index == null || index.Length < 3)
                {
                    continue;
                }

                if (index[0] < 0 || index[0] >= point3Ds.Count || index[1] < 0 || index[1] >= point3Ds.Count || index[2] < 0 || index[2] >= point3Ds.Count)
                {
                    continue;
                }

                Point3D point3D_1 = point3Ds[index[0]];
                Point3D point3D_2 = point3Ds[index[1]];
                Point3D point3D_3 = point3Ds[index[2]];

                // A not-a-number corner cannot be drawn and would spoil the bounds of the whole mesh, so the
                // triangle carrying it is dropped instead of being passed on.
                if (!point3D_1.IsValid() || !point3D_2.IsValid() || !point3D_3.IsValid())
                {
                    continue;
                }

                double dX_2 = point3D_2.X - point3D_1.X;
                double dY_2 = point3D_2.Y - point3D_1.Y;
                double dZ_2 = point3D_2.Z - point3D_1.Z;

                double dX_3 = point3D_3.X - point3D_1.X;
                double dY_3 = point3D_3.Y - point3D_1.Y;
                double dZ_3 = point3D_3.Z - point3D_1.Z;

                // Twice the signed area of the triangle seen from above, and the determinant the corners of
                // the clipped shape are put back through further down.
                double denominator = (dX_2 * dY_3) - (dY_2 * dX_3);
                if (System.Math.Abs(denominator) < tolerance)
                {
                    triangle3Ds.Add(new Triangle3D(point3D_1, point3D_2, point3D_3));
                    continue;
                }

                Coordinate coordinate_1 = new(point3D_1.X, point3D_1.Y);
                Coordinate coordinate_2 = new(point3D_2.X, point3D_2.Y);
                Coordinate coordinate_3 = new(point3D_3.X, point3D_3.Y);

                Envelope envelope = new(coordinate_1, coordinate_2);
                envelope.ExpandToInclude(coordinate_3);

                IList<IPreparedGeometry>? preparedGeometries_Candidates = sTRtree.Query(envelope);
                if (preparedGeometries_Candidates == null || preparedGeometries_Candidates.Count == 0)
                {
                    triangle3Ds.Add(new Triangle3D(point3D_1, point3D_2, point3D_3));
                    continue;
                }

                Coordinate[] coordinates_Triangle = denominator > 0 ? [coordinate_1, coordinate_2, coordinate_3, coordinate_1.Copy()] : [coordinate_1, coordinate_3, coordinate_2, coordinate_1.Copy()];

                Polygon polygon_Triangle = geometryFactory.CreatePolygon(coordinates_Triangle);

                bool covered = false;
                foreach (IPreparedGeometry preparedGeometry in preparedGeometries_Candidates)
                {
                    if (preparedGeometry.Covers(polygon_Triangle))
                    {
                        covered = true;
                        break;
                    }
                }

                // A triangle sitting wholly inside a cutting polygon is dropped without any overlay at all,
                // which is the common case wherever the mesh is coarser than the polygons cut out of it.
                if (covered)
                {
                    continue;
                }

                bool failed = false;
                NetTopologySuite.Geometries.Geometry geometry_Remainder = polygon_Triangle;
                foreach (IPreparedGeometry preparedGeometry in preparedGeometries_Candidates)
                {
                    if (!preparedGeometry.Intersects(geometry_Remainder))
                    {
                        continue;
                    }

                    // Subtracting the cutters one after another gives the same result as subtracting their
                    // union, and spares a union per triangle.
                    try
                    {
                        geometry_Remainder = geometry_Remainder.Difference(preparedGeometry.Geometry);
                    }
                    catch (System.Exception)
                    {
                        failed = true;
                        break;
                    }

                    if (geometry_Remainder == null || geometry_Remainder.IsEmpty)
                    {
                        break;
                    }
                }

                if (failed)
                {
                    triangle3Ds.Add(new Triangle3D(point3D_1, point3D_2, point3D_3));
                    continue;
                }

                if (geometry_Remainder == null || geometry_Remainder.IsEmpty || geometry_Remainder.Area < tolerance)
                {
                    continue;
                }

                // Nothing was actually taken away, so the triangle is passed on rather than rebuilt through
                // the triangulator, which would only reproduce it less exactly.
                if (geometry_Remainder is Polygon polygon_Untouched && polygon_Untouched.NumInteriorRings == 0 && polygon_Untouched.ExteriorRing?.NumPoints == 4 && DiGi.Core.Query.AlmostEquals(polygon_Untouched.Area, polygon_Triangle.Area, tolerance))
                {
                    triangle3Ds.Add(new Triangle3D(point3D_1, point3D_2, point3D_3));
                    continue;
                }

                // What is left of the triangle is collected in full before any of it is kept, so a failure
                // part way through can put the triangle back as it came in rather than leaving the ground
                // half cut.
                List<Triangle3D> triangle3Ds_Remainder = [];

                bool failed_Triangulation = false;
                for (int i = 0; i < geometry_Remainder.NumGeometries; i++)
                {
                    if (geometry_Remainder.GetGeometryN(i) is not Polygon polygon_Dirty || polygon_Dirty.IsEmpty || polygon_Dirty.Area < tolerance)
                    {
                        continue;
                    }

                    Polygon? polygon_Remainder = Clean(polygon_Dirty);
                    if (polygon_Remainder == null || polygon_Remainder.IsEmpty || polygon_Remainder.Area < tolerance)
                    {
                        continue;
                    }

                    List<Coordinate[]>? coordinates_Triangles = ConvexFan(polygon_Remainder);
                    if (coordinates_Triangles == null)
                    {
                        // The tolerance is handed over rather than left to its default, so the precision the
                        // triangulator snaps to is the one this whole operation works at.
                        List<Polygon>? polygons_Triangulated;
                        try
                        {
                            polygons_Triangulated = Planar.Query.Triangulate(polygon_Remainder, tolerance);
                        }
                        catch (System.Exception)
                        {
                            failed_Triangulation = true;
                            break;
                        }

                        if (polygons_Triangulated == null)
                        {
                            continue;
                        }

                        coordinates_Triangles = [];
                        foreach (Polygon polygon_Triangulated in polygons_Triangulated)
                        {
                            Coordinate[]? coordinates_Triangulated = polygon_Triangulated?.Coordinates;
                            if (coordinates_Triangulated != null && coordinates_Triangulated.Length == 4)
                            {
                                coordinates_Triangles.Add(coordinates_Triangulated);
                            }
                        }
                    }

                    foreach (Coordinate[] coordinates_Remainder in coordinates_Triangles)
                    {
                        Point3D[] point3Ds_Remainder = new Point3D[3];

                        bool valid = true;
                        for (int j = 0; j < 3; j++)
                        {
                            Coordinate coordinate = coordinates_Remainder[j];
                            if (!Planar.Query.IsValid(coordinate))
                            {
                                valid = false;
                                break;
                            }

                            // The corner is put back onto the plane of the triangle it was cut from, by the
                            // plan view weights of that triangle taken from its first corner. Doing it this
                            // way returns the stored elevation exactly at the corners the triangle already
                            // had, which the plane equation does not, and that is what keeps a clipped
                            // triangle flush with the untouched neighbour it still shares a corner with.
                            double eX = coordinate.X - point3D_1.X;
                            double eY = coordinate.Y - point3D_1.Y;

                            double u = ((eX * dY_3) - (eY * dX_3)) / denominator;
                            double v = ((dX_2 * eY) - (dY_2 * eX)) / denominator;

                            point3Ds_Remainder[j] = new Point3D(coordinate.X, coordinate.Y, point3D_1.Z + (u * dZ_2) + (v * dZ_3));
                        }

                        if (!valid)
                        {
                            continue;
                        }

                        triangle3Ds_Remainder.Add(new Triangle3D(point3Ds_Remainder[0], point3Ds_Remainder[1], point3Ds_Remainder[2]));
                    }
                }

                if (failed_Triangulation)
                {
                    triangle3Ds.Add(new Triangle3D(point3D_1, point3D_2, point3D_3));
                    continue;
                }

                triangle3Ds.AddRange(triangle3Ds_Remainder);
            }

            if (triangle3Ds.Count == 0)
            {
                return null;
            }

            return Create.Mesh3D(triangle3Ds, tolerance);
        }

        /// <summary>
        /// Cuts plan view openings out of a mesh, subtracting each polygonal face from the mesh as seen from above while keeping the elevations of the mesh.
        /// <para>The internal edges of a face are kept, so the mesh survives inside them: the courtyard of a building keeps its ground.</para>
        /// </summary>
        /// <remarks>
        /// See <see cref="Difference(Mesh3D?, IEnumerable{Polygon}?, double)"/> for what the subtraction does with degenerate input.
        /// </remarks>
        /// <param name="mesh3D">The mesh to cut. This value can be null.</param>
        /// <param name="polygonalFace2Ds">The faces to cut out, in the plan view (X, Y) coordinates of the mesh. This value can be null.</param>
        /// <param name="tolerance">The distance tolerance used for the plan view subtraction, for the triangulation of what remains and for the welding of the resulting mesh.</param>
        /// <returns>A new <see cref="Mesh3D"/> holding the mesh with the faces cut out, a clone of the mesh when there is nothing to cut, or <see langword="null"/> when the mesh is null or nothing of it remains.</returns>
        public static Mesh3D? Difference(this Mesh3D? mesh3D, IEnumerable<IPolygonalFace2D>? polygonalFace2Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (mesh3D == null)
            {
                return null;
            }

            if (polygonalFace2Ds == null)
            {
                return new Mesh3D(mesh3D);
            }

            List<Polygon> polygons = [];
            foreach (IPolygonalFace2D polygonalFace2D in polygonalFace2Ds)
            {
                Polygon? polygon = Planar.Convert.ToNTS(polygonalFace2D);
                if (polygon != null)
                {
                    polygons.Add(polygon);
                }
            }

            return Difference(mesh3D, polygons, tolerance);
        }

        /// <summary>
        /// Cuts plan view openings out of a mesh, subtracting the area enclosed by each polygonal curve from the mesh as seen from above while keeping the elevations of the mesh.
        /// </summary>
        /// <remarks>
        /// A polygonal curve encloses one area and cannot describe an opening within it. Use <see cref="Difference(Mesh3D?, IEnumerable{IPolygonalFace2D}?, double)"/> when the shapes to cut out have openings of their own, such as courtyards.
        /// <para>See <see cref="Difference(Mesh3D?, IEnumerable{Polygon}?, double)"/> for what the subtraction does with degenerate input.</para>
        /// </remarks>
        /// <param name="mesh3D">The mesh to cut. This value can be null.</param>
        /// <param name="polygonal2Ds">The polygonal curves to cut out, in the plan view (X, Y) coordinates of the mesh. This value can be null.</param>
        /// <param name="tolerance">The distance tolerance used for the plan view subtraction, for the triangulation of what remains and for the welding of the resulting mesh.</param>
        /// <returns>A new <see cref="Mesh3D"/> holding the mesh with the areas cut out, a clone of the mesh when there is nothing to cut, or <see langword="null"/> when the mesh is null or nothing of it remains.</returns>
        public static Mesh3D? Difference(this Mesh3D? mesh3D, IEnumerable<IPolygonal2D>? polygonal2Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (mesh3D == null)
            {
                return null;
            }

            if (polygonal2Ds == null)
            {
                return new Mesh3D(mesh3D);
            }

            List<Polygon> polygons = [];
            foreach (IPolygonal2D polygonal2D in polygonal2Ds)
            {
                Polygon? polygon = Planar.Convert.ToNTS_Polygon(polygonal2D);
                if (polygon != null)
                {
                    polygons.Add(polygon);
                }
            }

            return Difference(mesh3D, polygons, tolerance);
        }
    }
}

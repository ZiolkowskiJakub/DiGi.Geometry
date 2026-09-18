using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        /// <summary>
        /// Creates the cross-section faces of a polyhedron on a plane - the faces of the solid lying on the plane, with the ring nesting of the section preserved.
        /// <para>The section loops are assembled into <see cref="Classes.PolygonalFace3D"/> instances so that a loop enclosed by another loop becomes a hole of the enclosing face rather than a solid face of its own. Converting each loop of <see cref="PlanarIntersectionResult(Plane?, IPolyhedron?, double)"/> separately (<see cref="Query.Convert{TGeometry3D}(IGeometry3D?)"/>) fills such holes: the section of a courtyard building on a storey plane came back as a solid outer face plus a solid courtyard face, and every consumer downstream lost the courtyard.</para>
        /// <para>Which loops bound the solid is decided by nesting parity: a loop enclosed by an even number of other loops is the external edge of a face, its holes are the loops enclosed by it one level deeper, and a loop enclosed by an odd number of other loops is a hole only. A plane cutting a closed surface transversally leaves and enters the solid at every section loop, so the courtyard loop (enclosed once) is a hole while a solid nested in a void (enclosed twice) is a face of its own. The rule is purely planar - it holds for a shell that is not closed as well, where a point-in-polyhedron test would not.</para>
        /// <para>The loops are rebuilt from every segment of the section together with the edges of the faces of the polyhedron lying on the plane. Such a coplanar face interrupts the section loop running through it - the intersection reports the loop as open polylines on either side of the face - and closing the loop through the edges of the face is what keeps the section whole on a plane that touches a lower roof. The region of a coplanar face is never a section face: it is bounded by the face itself, which the polyhedron already carries, so its loop is left out of the faces and only serves as a hole where the face lies inside the section. A section without nested loops and without coplanar faces yields one solid face per loop, exactly as the separate conversion did.</para>
        /// </summary>
        /// <param name="plane">The <see cref="Classes.Plane"/> cutting the polyhedron.</param>
        /// <param name="polyhedron">The <see cref="IPolyhedron"/> to be cut.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance for intersection calculations.</param>
        /// <returns>A <see cref="List{T}"/> of <see cref="Classes.PolygonalFace3D"/> section faces, or <see langword="null"/> if either input is <see langword="null"/> or the plane does not cut the polyhedron.</returns>
        public static List<PolygonalFace3D>? PolygonalFace3Ds(this Plane? plane, IPolyhedron? polyhedron, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (plane is null || polyhedron is null)
            {
                return null;
            }

            PlanarIntersectionResult? planarIntersectionResult = PlanarIntersectionResult(plane, polyhedron, tolerance);
            if (planarIntersectionResult is null || !planarIntersectionResult.Any())
            {
                return null;
            }

            // Every segment the section is made of, each of them once - the section meets a loop once per side, so the same segment arrives more than once
            List<Segment2D> segment2Ds = [];

            void AddSegment2Ds(IEnumerable<Segment2D>? segment2Ds_Temp)
            {
                if (segment2Ds_Temp is null)
                {
                    return;
                }

                foreach (Segment2D segment2D in segment2Ds_Temp)
                {
                    if (segment2D is null || segment2D.SquaredLength < tolerance * tolerance)
                    {
                        continue;
                    }

                    DiGi.Core.Modify.Add(segment2Ds, segment2D, x => Planar.Query.Similar(x, segment2D, tolerance));
                }
            }

            if (planarIntersectionResult.GetGeometry2Ds<ISegmentable2D>() is List<ISegmentable2D> segmentable2Ds)
            {
                foreach (ISegmentable2D segmentable2D in segmentable2Ds)
                {
                    AddSegment2Ds(segmentable2D?.GetSegments());
                }
            }

            List<IPolygonal2D> polygonal2Ds_Coplanar = [];
            if (planarIntersectionResult.GetGeometry2Ds<IPolygonalFace2D>() is List<IPolygonalFace2D> polygonalFace2Ds_Coplanar)
            {
                foreach (IPolygonalFace2D polygonalFace2D_Coplanar in polygonalFace2Ds_Coplanar)
                {
                    if (polygonalFace2D_Coplanar?.Edges is not List<IPolygonal2D> polygonal2Ds_Edges)
                    {
                        continue;
                    }

                    foreach (IPolygonal2D polygonal2D_Edge in polygonal2Ds_Edges)
                    {
                        AddSegment2Ds(polygonal2D_Edge?.GetSegments());
                    }

                    if (polygonalFace2D_Coplanar.ExternalEdge is IPolygonal2D polygonal2D_External)
                    {
                        polygonal2Ds_Coplanar.Add(polygonal2D_External);
                    }
                }
            }

            if (segment2Ds.Count < 3)
            {
                return null;
            }

            // Closed loops of the section, each of them once
            List<IPolygonal2D> polygonal2Ds = [];
            if (Planar.Create.Polygon2Ds(segment2Ds, tolerance) is List<Polygon2D> polygon2Ds)
            {
                foreach (Polygon2D polygon2D in polygon2Ds)
                {
                    if (polygon2D is null || polygon2D.GetArea() < tolerance * tolerance)
                    {
                        continue;
                    }

                    DiGi.Core.Modify.Add(polygonal2Ds, polygon2D, x => Planar.Query.Similar(x, polygon2D, tolerance));
                }
            }

            if (polygonal2Ds.Count == 0)
            {
                return null;
            }

            // Loops enclosing each loop - the loop is a face at even depth, a hole of the loop one level up at odd depth.
            // Tested on a vertex of the enclosed loop rather than on its internal point: the internal point of a ring
            // around a courtyard falls into the courtyard, i.e. inside the very loop it encloses.
            List<List<Point2D>?> point2Ds = polygonal2Ds.ConvertAll(x => x.GetPoints());
            List<List<int>> containers = [];
            for (int i = 0; i < polygonal2Ds.Count; i++)
            {
                List<int> containers_Temp = [];

                if (point2Ds[i] is List<Point2D> point2Ds_Temp)
                {
                    for (int j = 0; j < polygonal2Ds.Count; j++)
                    {
                        if (j == i)
                        {
                            continue;
                        }

                        IPolygonal2D polygonal2D_Container = polygonal2Ds[j];

                        // A vertex lying on the candidate loop (touching rings) decides nothing, the next one is taken
                        Point2D? point2D = point2Ds_Temp.Find(x => !polygonal2D_Container.On(x, tolerance));
                        if (point2D is not null && polygonal2D_Container.Inside(point2D, tolerance))
                        {
                            containers_Temp.Add(j);
                        }
                    }
                }

                containers.Add(containers_Temp);
            }

            List<PolygonalFace3D> result = [];
            for (int i = 0; i < polygonal2Ds.Count; i++)
            {
                int depth = containers[i].Count;
                if (depth % 2 != 0)
                {
                    continue;
                }

                IPolygonal2D polygonal2D = polygonal2Ds[i];

                // The region of a face lying on the plane is bounded by that face, not by a section face
                if (polygonal2Ds_Coplanar.Exists(x => Planar.Query.Similar(x, polygonal2D, tolerance)))
                {
                    continue;
                }

                List<IPolygonal2D> polygonal2Ds_Internal = [];
                for (int j = 0; j < polygonal2Ds.Count; j++)
                {
                    if (j != i && containers[j].Count == depth + 1 && containers[j].Contains(i))
                    {
                        polygonal2Ds_Internal.Add(polygonal2Ds[j]);
                    }
                }

                PolygonalFace2D? polygonalFace2D = Planar.Create.PolygonalFace2D(polygonal2D, polygonal2Ds_Internal, tolerance);
                if (plane.Convert(polygonalFace2D) is not PolygonalFace3D polygonalFace3D)
                {
                    continue;
                }

                result.Add(polygonalFace3D);
            }

            return result.Count == 0 ? null : result;
        }
    }
}

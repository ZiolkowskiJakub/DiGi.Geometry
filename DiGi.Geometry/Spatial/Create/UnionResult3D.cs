using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Linq;
using DiGi.Geometry.Core.Enums;
using System;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        /// <summary>
        /// Calculates the 3D boolean union between two polyhedra defined by TPolygonalFace3D faces.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The boundary of the union polyhedron <c>A U B</c> is composed of:
        /// <list type="bullet">
        /// <item>Faces of A that lie outside the volume of B.</item>
        /// <item>Faces of B that lie outside the volume of A.</item>
        /// </list>
        /// </para>
        /// <para>
        /// If the remaining boundary pieces do not form a closed solid volume (less than 4 faces, or non-closed shell),
        /// the method falls back to returning the individual <see cref="Classes.PolygonalFace3D"/> elements representing the 
        /// remaining boundary surfaces.
        /// </para>
        /// </remarks>
        /// <typeparam name="TPolygonalFace3D">The type of polygonal face, which must implement <see cref="IPolygonalFace3D"/>.</typeparam>
        /// <param name="polyhedron_1">The first polyhedron.</param>
        /// <param name="polyhedron_2">The second polyhedron.</param>
        /// <param name="tolerance">The distance tolerance for boolean union computations.</param>
        /// <returns>A <see cref="Classes.UnionResult3D"/> containing the union geometry (either a Polyhedron, multiple disjoint Polyhedrons, or individual face/segment elements), or null if both inputs are null.</returns>
        public static UnionResult3D? UnionResult3D<TPolygonalFace3D>(
            this Polyhedron<TPolygonalFace3D>? polyhedron_1, 
            Polyhedron<TPolygonalFace3D>? polyhedron_2, 
            double tolerance = DiGi.Core.Constants.Tolerance.Distance) 
            where TPolygonalFace3D : IPolygonalFace3D
        {
            if (polyhedron_1 == null && polyhedron_2 == null)
            {
                return null;
            }

            if (polyhedron_1 == null)
            {
                return new UnionResult3D(polyhedron_2);
            }

            if (polyhedron_2 == null)
            {
                return new UnionResult3D(polyhedron_1);
            }

            // Early-out Axis-Aligned Bounding Box (AABB) intersection check
            BoundingBox3D? boundingBox3D_1 = polyhedron_1.GetBoundingBox();
            BoundingBox3D? boundingBox3D_2 = polyhedron_2.GetBoundingBox();
            if (boundingBox3D_1 == null || boundingBox3D_2 == null || !boundingBox3D_1.InRange(boundingBox3D_2, tolerance))
            {
                // Disjoint union consists of both disjoint solid volumes
                return new UnionResult3D(new IGeometry3D[] { polyhedron_1, polyhedron_2 });
            }

            // Retrieve and collect all faces of both polyhedra
            List<IPolygonalFace3D> polygonalFace3Ds_1 = [];
            for (int i = 0; i < polyhedron_1.Count; i++)
            {
                if (polyhedron_1.GetPolygonalFace3D<IPolygonalFace3D>(i) is IPolygonalFace3D face)
                {
                    polygonalFace3Ds_1.Add(face);
                }
            }

            List<IPolygonalFace3D> polygonalFace3Ds_2 = [];
            for (int i = 0; i < polyhedron_2.Count; i++)
            {
                if (polyhedron_2.GetPolygonalFace3D<IPolygonalFace3D>(i) is IPolygonalFace3D face)
                {
                    polygonalFace3Ds_2.Add(face);
                }
            }

            if (polygonalFace3Ds_1.Count == 0 && polygonalFace3Ds_2.Count == 0)
            {
                return new UnionResult3D();
            }

            if (polygonalFace3Ds_1.Count == 0)
            {
                return new UnionResult3D(polyhedron_2);
            }

            if (polygonalFace3Ds_2.Count == 0)
            {
                return new UnionResult3D(polyhedron_1);
            }

            // Cache outward normals of the original faces using ray-casting based solver
            Vector3D[] vector3Ds_OutwardNormals_1 = new Vector3D[polygonalFace3Ds_1.Count];
            for (int i = 0; i < polygonalFace3Ds_1.Count; i++)
            {
                vector3Ds_OutwardNormals_1[i] = polyhedron_1.GetNormal(i, out bool _, Side.External, tolerance) ?? polygonalFace3Ds_1[i].Plane?.Normal ?? new Vector3D(0, 0, 1);
            }

            Vector3D[] vector3Ds_OutwardNormals_2 = new Vector3D[polygonalFace3Ds_2.Count];
            for (int i = 0; i < polygonalFace3Ds_2.Count; i++)
            {
                vector3Ds_OutwardNormals_2[i] = polyhedron_2.GetNormal(i, out bool _, Side.External, tolerance) ?? polygonalFace3Ds_2[i].Plane?.Normal ?? new Vector3D(0, 0, 1);
            }

            // Build Bounding Volume Hierarchy (BVH) trees for spatial culling
            BVHNode bvhNode_1 = new(polygonalFace3Ds_1);
            BVHNode bvhNode_2 = new(polygonalFace3Ds_2);

            // Candidates list: Tuple<face, parentFaceIndex, parentPolyhedronIndex>
            List<Tuple<IPolygonalFace3D, int, int>> tuples_Candidates = [];

            // Split faces of polyhedron 1 using overlapping faces of polyhedron 2
            for (int i = 0; i < polygonalFace3Ds_1.Count; i++)
            {
                IPolygonalFace3D face = polygonalFace3Ds_1[i];
                BoundingBox3D? bbox = face.GetBoundingBox();
                if (bbox == null)
                {
                    continue;
                }

                List<IPolygonalFace3D> list_Overlapping = [];
                list_Overlapping.AddOverlappingFaces(bvhNode_2, bbox, tolerance);

                if (list_Overlapping.Count == 0)
                {
                    tuples_Candidates.Add(new Tuple<IPolygonalFace3D, int, int>(face, i, 1));
                }
                else
                {
                    if (Query.TrySplit(face, list_Overlapping, out List<PolygonalFace3D>? splitResult, tolerance) && splitResult != null && splitResult.Count > 0)
                    {
                        foreach (PolygonalFace3D splitFace in splitResult)
                        {
                            tuples_Candidates.Add(new Tuple<IPolygonalFace3D, int, int>(splitFace, i, 1));
                        }
                    }
                    else
                    {
                        tuples_Candidates.Add(new Tuple<IPolygonalFace3D, int, int>(face, i, 1));
                    }
                }
            }

            // Split faces of polyhedron 2 using overlapping faces of polyhedron 1
            for (int i = 0; i < polygonalFace3Ds_2.Count; i++)
            {
                IPolygonalFace3D face = polygonalFace3Ds_2[i];
                BoundingBox3D? bbox = face.GetBoundingBox();
                if (bbox == null)
                {
                    continue;
                }

                List<IPolygonalFace3D> list_Overlapping = [];
                list_Overlapping.AddOverlappingFaces(bvhNode_1, bbox, tolerance);

                if (list_Overlapping.Count == 0)
                {
                    tuples_Candidates.Add(new Tuple<IPolygonalFace3D, int, int>(face, i, 2));
                }
                else
                {
                    if (Query.TrySplit(face, list_Overlapping, out List<PolygonalFace3D>? splitResult, tolerance) && splitResult != null && splitResult.Count > 0)
                    {
                        foreach (PolygonalFace3D splitFace in splitResult)
                        {
                            tuples_Candidates.Add(new Tuple<IPolygonalFace3D, int, int>(splitFace, i, 2));
                        }
                    }
                    else
                    {
                        tuples_Candidates.Add(new Tuple<IPolygonalFace3D, int, int>(face, i, 2));
                    }
                }
            }

            // Classify split/unsplit candidate faces (keep if outside the other volume)
            List<IPolygonalFace3D> list_KeptFaces = [];
            double double_Epsilon = tolerance * 2.0;

            foreach (Tuple<IPolygonalFace3D, int, int> candidate in tuples_Candidates)
            {
                IPolygonalFace3D face = candidate.Item1;
                int parentIndex = candidate.Item2;
                int parentPoly = candidate.Item3;

                Point3D? point3D_Internal = face.GetInternalPoint(tolerance) ?? face.ExternalEdge?.GetCentroid();
                if (point3D_Internal == null)
                {
                    continue;
                }

                bool keep = false;
                if (parentPoly == 1)
                {
                    // Keep if outside polyhedron 2
                    if (!polyhedron_2.Inside(point3D_Internal, tolerance) && !polyhedron_2.On(point3D_Internal, tolerance))
                    {
                        keep = true;
                    }
                    else if (polyhedron_2.On(point3D_Internal, tolerance))
                    {
                        // For coplanar boundaries, offset inward. If it goes inside polyhedron 2, they share same normal orientation (outer boundary).
                        Vector3D normal = vector3Ds_OutwardNormals_1[parentIndex];
                        Point3D? point3D_Inward = point3D_Internal - double_Epsilon * normal;
                        if (point3D_Inward != null && polyhedron_2.Inside(point3D_Inward, tolerance))
                        {
                            keep = true;
                        }
                    }
                }
                else
                {
                    // Keep if outside polyhedron 1
                    if (!polyhedron_1.Inside(point3D_Internal, tolerance) && !polyhedron_1.On(point3D_Internal, tolerance))
                    {
                        keep = true;
                    }
                    else if (polyhedron_1.On(point3D_Internal, tolerance))
                    {
                        // For coplanar boundaries, offset inward. If it goes inside polyhedron 1, they share same normal orientation (outer boundary).
                        Vector3D normal = vector3Ds_OutwardNormals_2[parentIndex];
                        Point3D? point3D_Inward = point3D_Internal - double_Epsilon * normal;
                        if (point3D_Inward != null && polyhedron_1.Inside(point3D_Inward, tolerance))
                        {
                            keep = true;
                        }
                    }
                }

                if (keep)
                {
                    list_KeptFaces.Add(face);
                }
            }

            // Deduplicate overlapping boundaries
            List<IPolygonalFace3D> list_UniqueFaces = [];
            foreach (IPolygonalFace3D face in list_KeptFaces)
            {
                bool duplicate = false;
                Point3D? centroid = face.ExternalEdge?.GetCentroid() ?? face.GetInternalPoint(tolerance);
                if (centroid == null)
                {
                    continue;
                }

                foreach (IPolygonalFace3D existing in list_UniqueFaces)
                {
                    Point3D? existingCentroid = existing.ExternalEdge?.GetCentroid() ?? existing.GetInternalPoint(tolerance);
                    if (existingCentroid != null && centroid.Similar(existingCentroid, tolerance))
                    {
                        if (face.Plane != null && existing.Plane != null && face.Plane.Coplanar(existing.Plane, tolerance))
                        {
                            duplicate = true;
                            break;
                        }
                    }
                }

                if (!duplicate)
                {
                    list_UniqueFaces.Add(face);
                }
            }

            // Assemble solid union volume if valid (requires >= 4 faces for a solid closed polyhedron)
            if (list_UniqueFaces.Count >= 4)
            {
                Polyhedron? resultPoly = Create.Polyhedron(list_UniqueFaces);
                if (resultPoly != null)
                {
                    return new UnionResult3D((IGeometry3D)resultPoly);
                }
            }

            // Fallback for non-solid remnants or individual surface components (like standalone PolygonalFace3D)
            if (list_UniqueFaces.Count > 0)
            {
                List<IGeometry3D> lowerGeometries = [];
                foreach (IPolygonalFace3D face in list_UniqueFaces)
                {
                    lowerGeometries.Add(face);
                }
                return new UnionResult3D(lowerGeometries);
            }

            return new UnionResult3D();
        }
    }
}

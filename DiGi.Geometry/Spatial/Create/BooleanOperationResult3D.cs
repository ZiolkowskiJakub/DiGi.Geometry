using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        /// <summary>
        /// Calculates the 3D boolean operation result between two polyhedra based on the specified operation type.
        /// </summary>
        /// <typeparam name="TPolygonalFace3D">The type of polygonal face, which must implement <see cref="IPolygonalFace3D"/>.</typeparam>
        /// <param name="booleanOpertaionType">The type of the boolean operation.</param>
        /// <param name="polyhedron_1">The first polyhedron.</param>
        /// <param name="polyhedron_2">The second polyhedron.</param>
        /// <param name="tolerance">The distance tolerance for the boolean computations.</param>
        /// <returns>A <see cref="Classes.BooleanOperationResult3D"/> containing the result of the operation, or null if the operation type is not supported.</returns>
        public static BooleanOperationResult3D? BooleanOperationResult3D<TPolygonalFace3D>(
            this BooleanOpertaionType booleanOpertaionType,
            Polyhedron<TPolygonalFace3D>? polyhedron_1,
            Polyhedron<TPolygonalFace3D>? polyhedron_2,
            double tolerance = DiGi.Core.Constants.Tolerance.Distance)
            where TPolygonalFace3D : IPolygonalFace3D
        {
            return booleanOpertaionType switch
            {
                BooleanOpertaionType.Intersection => IntersectionResult3D(polyhedron_1, polyhedron_2, tolerance),
                BooleanOpertaionType.Difference => DifferenceResult3D(polyhedron_1, polyhedron_2, tolerance),
                BooleanOpertaionType.Union => UnionResult3D(polyhedron_1, polyhedron_2, tolerance),
                _ => null,
            };
        }

        /// <summary>
        /// Candidate boundary fragment produced by the face-splitting stage of a 3D boolean operation.
        /// Value type - avoids the per-candidate heap allocations a Tuple-based candidate list would incur.
        /// </summary>
        private readonly struct BooleanOperationCandidate
        {
            /// <summary>
            /// The candidate face fragment.
            /// </summary>
            public readonly IPolygonalFace3D PolygonalFace3D;

            /// <summary>
            /// The index of the parent face in the source polyhedron the fragment originates from.
            /// </summary>
            public readonly int ParentIndex;

            /// <summary>
            /// True when the fragment originates from the first polyhedron; false for the second polyhedron.
            /// </summary>
            public readonly bool FromFirst;

            public BooleanOperationCandidate(IPolygonalFace3D polygonalFace3D, int parentIndex, bool fromFirst)
            {
                PolygonalFace3D = polygonalFace3D;
                ParentIndex = parentIndex;
                FromFirst = fromFirst;
            }
        }

        /// <summary>
        /// Extracts the faces of the given polyhedron without cloning them.
        /// </summary>
        /// <typeparam name="TPolygonalFace3D">The type of polygonal face, which must implement <see cref="IPolygonalFace3D"/>.</typeparam>
        /// <param name="polyhedron">The source polyhedron.</param>
        /// <returns>A list of the polyhedron faces (never null; possibly empty).</returns>
        private static List<IPolygonalFace3D> PolygonalFace3Ds<TPolygonalFace3D>(Polyhedron<TPolygonalFace3D> polyhedron) where TPolygonalFace3D : IPolygonalFace3D
        {
            int count = polyhedron.Count;

            List<IPolygonalFace3D> result = new(count);
            for (int i = 0; i < count; i++)
            {
                if (polyhedron.GetPolygonalFace3D<IPolygonalFace3D>(i) is IPolygonalFace3D polygonalFace3D)
                {
                    result.Add(polygonalFace3D);
                }
            }

            return result;
        }

        /// <summary>
        /// Shared core of the 3D boolean operations (Union, Intersection, Difference): splits the faces of each
        /// polyhedron by the overlapping faces of the other, classifies every resulting fragment against the other
        /// volume with a single BVH-accelerated point-relation query, and deduplicates coplanar overlapping
        /// fragments via a spatial hash.
        /// </summary>
        /// <typeparam name="TPolygonalFace3D">The type of polygonal face, which must implement <see cref="IPolygonalFace3D"/>.</typeparam>
        /// <param name="booleanOpertaionType">The boolean operation deciding which fragments are kept.</param>
        /// <param name="polyhedron_1">The first polyhedron (used only for the rare exact outward-normal fallback).</param>
        /// <param name="polyhedron_2">The second polyhedron (used only for the rare exact outward-normal fallback).</param>
        /// <param name="polygonalFace3Ds_1">The faces of the first polyhedron (non-empty).</param>
        /// <param name="polygonalFace3Ds_2">The faces of the second polyhedron (non-empty).</param>
        /// <param name="bVHNode_2">The Bounding Volume Hierarchy (BVH) built for the second polyhedron, reusable by the caller.</param>
        /// <param name="tolerance">The distance tolerance for the boolean computations.</param>
        /// <returns>The deduplicated boundary faces of the result volume (never null; possibly empty). Difference results have the retained second-polyhedron fragments inverted.</returns>
        internal static List<IPolygonalFace3D> BooleanOperationPolygonalFace3Ds<TPolygonalFace3D>(
            BooleanOpertaionType booleanOpertaionType,
            Polyhedron<TPolygonalFace3D> polyhedron_1,
            Polyhedron<TPolygonalFace3D> polyhedron_2,
            List<IPolygonalFace3D> polygonalFace3Ds_1,
            List<IPolygonalFace3D> polygonalFace3Ds_2,
            out BVHNode bVHNode_2,
            double tolerance) where TPolygonalFace3D : IPolygonalFace3D
        {
            // Build Bounding Volume Hierarchy (BVH) trees for spatial culling
            BVHNode bVHNode_1 = new(polygonalFace3Ds_1);
            bVHNode_2 = new(polygonalFace3Ds_2);

            // Point classifiers answering Inside/On/Outside in a single BVH-accelerated ray cast
            BVHNodePointRelationSolver bVHNodePointRelationSolver_1 = new(bVHNode_1, tolerance);
            BVHNodePointRelationSolver bVHNodePointRelationSolver_2 = new(bVHNode_2, tolerance);

            // Split faces of each polyhedron using overlapping faces of the other
            List<BooleanOperationCandidate> booleanOperationCandidates = new(polygonalFace3Ds_1.Count + polygonalFace3Ds_2.Count);
            AddBooleanOperationCandidates(booleanOperationCandidates, polygonalFace3Ds_1, bVHNode_2, true, tolerance);
            AddBooleanOperationCandidates(booleanOperationCandidates, polygonalFace3Ds_2, bVHNode_1, false, tolerance);

            // Classify split/unsplit candidate faces
            List<IPolygonalFace3D> polygonalFace3Ds_Kept = [];
            for (int i = 0; i < booleanOperationCandidates.Count; i++)
            {
                BooleanOperationCandidate booleanOperationCandidate = booleanOperationCandidates[i];
                IPolygonalFace3D polygonalFace3D = booleanOperationCandidate.PolygonalFace3D;

                Point3D? point3D_Internal = polygonalFace3D.GetInternalPoint(tolerance) ?? polygonalFace3D.ExternalEdge?.GetCentroid();
                if (point3D_Internal == null)
                {
                    continue;
                }

                BVHNodePointRelationSolver bVHNodePointRelationSolver_Other = booleanOperationCandidate.FromFirst ? bVHNodePointRelationSolver_2 : bVHNodePointRelationSolver_1;
                BVHNodePointRelationSolver bVHNodePointRelationSolver_Parent = booleanOperationCandidate.FromFirst ? bVHNodePointRelationSolver_1 : bVHNodePointRelationSolver_2;

                bVHNodePointRelationSolver_Other.Input = point3D_Internal;
                bVHNodePointRelationSolver_Other.Solve();
                PointRelation pointRelation = bVHNodePointRelationSolver_Other.Output;

                bool keep = false;
                switch (booleanOpertaionType)
                {
                    case BooleanOpertaionType.Intersection:
                        // Keep fragments inside the other volume; on shared coplanar boundaries keep the fragment
                        // when the parent-interior side of the boundary lies inside the other volume.
                        keep = pointRelation == PointRelation.Inside
                            || (pointRelation == PointRelation.On && InteriorSideInsideOther(booleanOperationCandidate, point3D_Internal, bVHNodePointRelationSolver_Parent, bVHNodePointRelationSolver_Other, polyhedron_1, polyhedron_2, tolerance));
                        break;

                    case BooleanOpertaionType.Union:
                        // Keep fragments outside the other volume; on shared coplanar boundaries keep the fragment
                        // once (from the volume whose interior side lies inside the other volume).
                        keep = pointRelation == PointRelation.Outside
                            || (pointRelation == PointRelation.On && InteriorSideInsideOther(booleanOperationCandidate, point3D_Internal, bVHNodePointRelationSolver_Parent, bVHNodePointRelationSolver_Other, polyhedron_1, polyhedron_2, tolerance));
                        break;

                    case BooleanOpertaionType.Difference:
                        if (booleanOperationCandidate.FromFirst)
                        {
                            // A \ B keeps A-boundary outside B; coplanar boundaries are kept when the A-interior
                            // side is not covered by B.
                            keep = pointRelation == PointRelation.Outside
                                || (pointRelation == PointRelation.On && !InteriorSideInsideOther(booleanOperationCandidate, point3D_Internal, bVHNodePointRelationSolver_Parent, bVHNodePointRelationSolver_Other, polyhedron_1, polyhedron_2, tolerance));
                        }
                        else
                        {
                            // A \ B keeps B-boundary strictly inside A
                            keep = pointRelation == PointRelation.Inside;
                        }
                        break;
                }

                if (!keep)
                {
                    continue;
                }

                if (booleanOpertaionType == BooleanOpertaionType.Difference && !booleanOperationCandidate.FromFirst)
                {
                    // Invert B-boundary fragments retained inside A so their normals face outward from A \ B
                    if (polygonalFace3D.Clone() is IPolygonalFace3D polygonalFace3D_Inverted)
                    {
                        polygonalFace3D_Inverted.Inverse();
                        polygonalFace3Ds_Kept.Add(polygonalFace3D_Inverted);
                    }

                    continue;
                }

                polygonalFace3Ds_Kept.Add(polygonalFace3D);
            }

            // Deduplicate overlapping coplanar boundaries
            return UniquePolygonalFace3Ds(polygonalFace3Ds_Kept, tolerance);
        }

        /// <summary>
        /// Splits every face of <paramref name="polygonalFace3Ds"/> by the faces of the other polyhedron that
        /// overlap it (culled through <paramref name="bVHNode"/>) and appends the resulting fragments (or the
        /// unsplit face) to <paramref name="booleanOperationCandidates"/>.
        /// </summary>
        private static void AddBooleanOperationCandidates(List<BooleanOperationCandidate> booleanOperationCandidates, List<IPolygonalFace3D> polygonalFace3Ds, BVHNode bVHNode, bool fromFirst, double tolerance)
        {
            List<IPolygonalFace3D> polygonalFace3Ds_Overlapping = [];
            for (int i = 0; i < polygonalFace3Ds.Count; i++)
            {
                IPolygonalFace3D polygonalFace3D = polygonalFace3Ds[i];

                BoundingBox3D? boundingBox3D = polygonalFace3D.GetBoundingBox();
                if (boundingBox3D == null)
                {
                    continue;
                }

                polygonalFace3Ds_Overlapping.Clear();
                polygonalFace3Ds_Overlapping.AddOverlappingFaces(bVHNode, boundingBox3D, tolerance);

                if (polygonalFace3Ds_Overlapping.Count > 0 && Query.TrySplit(polygonalFace3D, polygonalFace3Ds_Overlapping, out List<PolygonalFace3D>? polygonalFace3Ds_Split, tolerance) && polygonalFace3Ds_Split != null && polygonalFace3Ds_Split.Count > 0)
                {
                    for (int j = 0; j < polygonalFace3Ds_Split.Count; j++)
                    {
                        booleanOperationCandidates.Add(new BooleanOperationCandidate(polygonalFace3Ds_Split[j], i, fromFirst));
                    }
                }
                else
                {
                    booleanOperationCandidates.Add(new BooleanOperationCandidate(polygonalFace3D, i, fromFirst));
                }
            }
        }

        /// <summary>
        /// For a candidate fragment lying on the other volume's boundary, determines whether the parent-volume
        /// interior side of the (coplanar) boundary lies inside the other volume.
        /// <para>
        /// The probe is evaluated on both sides of the face plane, so the sign of the face normal is irrelevant -
        /// this avoids the expensive outward-normal orientation ray cast of
        /// <see cref="Polyhedron{TPolygonalFace3D}.GetNormal(int, out bool, Side?, double)"/> in the common case.
        /// The exact outward normal is only computed as a rare fallback (very thin parent volume or a probe near
        /// a parent edge).
        /// </para>
        /// </summary>
        private static bool InteriorSideInsideOther<TPolygonalFace3D>(
            BooleanOperationCandidate booleanOperationCandidate,
            Point3D point3D,
            BVHNodePointRelationSolver bVHNodePointRelationSolver_Parent,
            BVHNodePointRelationSolver bVHNodePointRelationSolver_Other,
            Polyhedron<TPolygonalFace3D> polyhedron_1,
            Polyhedron<TPolygonalFace3D> polyhedron_2,
            double tolerance) where TPolygonalFace3D : IPolygonalFace3D
        {
            Vector3D vector3D_Normal = booleanOperationCandidate.PolygonalFace3D.Plane?.Normal ?? new Vector3D(0, 0, 1);

            double offset = tolerance * 2.0;

            Point3D? point3D_Interior = point3D - (offset * vector3D_Normal);

            bVHNodePointRelationSolver_Parent.Input = point3D_Interior;
            bVHNodePointRelationSolver_Parent.Solve();

            if (point3D_Interior == null || bVHNodePointRelationSolver_Parent.Output != PointRelation.Inside)
            {
                Point3D? point3D_Opposite = point3D + (offset * vector3D_Normal);

                bVHNodePointRelationSolver_Parent.Input = point3D_Opposite;
                bVHNodePointRelationSolver_Parent.Solve();

                if (point3D_Opposite != null && bVHNodePointRelationSolver_Parent.Output == PointRelation.Inside)
                {
                    point3D_Interior = point3D_Opposite;
                }
                else
                {
                    // Rare fallback: orient by the ray-cast outward normal of the parent face
                    Polyhedron<TPolygonalFace3D> polyhedron_Parent = booleanOperationCandidate.FromFirst ? polyhedron_1 : polyhedron_2;
                    Vector3D vector3D_Normal_External = polyhedron_Parent.GetNormal(booleanOperationCandidate.ParentIndex, out bool _, Side.External, tolerance) ?? vector3D_Normal;
                    point3D_Interior = point3D - (offset * vector3D_Normal_External);
                }
            }

            if (point3D_Interior == null)
            {
                return false;
            }

            bVHNodePointRelationSolver_Other.Input = point3D_Interior;
            bVHNodePointRelationSolver_Other.Solve();

            return bVHNodePointRelationSolver_Other.Output == PointRelation.Inside;
        }

        /// <summary>
        /// Deduplicates coplanar faces with coincident centroids using a spatial hash on the centroid coordinates,
        /// replacing the quadratic all-pairs comparison with an expected linear-time pass. Centroids are computed
        /// once per face instead of once per comparison.
        /// </summary>
        private static List<IPolygonalFace3D> UniquePolygonalFace3Ds(List<IPolygonalFace3D> polygonalFace3Ds, double tolerance)
        {
            List<IPolygonalFace3D> result = [];
            if (polygonalFace3Ds.Count == 0)
            {
                return result;
            }

            double cellSize = tolerance > 0.0 ? tolerance * 2.0 : DiGi.Core.Constants.Tolerance.Distance;

            List<Point3D> point3Ds_Centroid = new(polygonalFace3Ds.Count);
            Dictionary<(long, long, long), List<int>> dictionary = [];

            for (int i = 0; i < polygonalFace3Ds.Count; i++)
            {
                IPolygonalFace3D polygonalFace3D = polygonalFace3Ds[i];

                Point3D? point3D_Centroid = polygonalFace3D.ExternalEdge?.GetCentroid() ?? polygonalFace3D.GetInternalPoint(tolerance);
                if (point3D_Centroid == null)
                {
                    continue;
                }

                long x = (long)System.Math.Floor(point3D_Centroid.X / cellSize);
                long y = (long)System.Math.Floor(point3D_Centroid.Y / cellSize);
                long z = (long)System.Math.Floor(point3D_Centroid.Z / cellSize);

                // Faces within tolerance can only land in a directly neighboring cell (cellSize >= tolerance)
                bool duplicate = false;
                for (long dX = -1; dX <= 1 && !duplicate; dX++)
                {
                    for (long dY = -1; dY <= 1 && !duplicate; dY++)
                    {
                        for (long dZ = -1; dZ <= 1 && !duplicate; dZ++)
                        {
                            if (!dictionary.TryGetValue((x + dX, y + dY, z + dZ), out List<int>? indexes))
                            {
                                continue;
                            }

                            for (int j = 0; j < indexes.Count; j++)
                            {
                                int index = indexes[j];
                                if (!point3D_Centroid.Similar(point3Ds_Centroid[index], tolerance))
                                {
                                    continue;
                                }

                                if (polygonalFace3D.Plane != null && result[index].Plane != null && polygonalFace3D.Plane.Coplanar(result[index].Plane, tolerance))
                                {
                                    duplicate = true;
                                    break;
                                }
                            }
                        }
                    }
                }

                if (duplicate)
                {
                    continue;
                }

                int resultIndex = result.Count;
                result.Add(polygonalFace3D);
                point3Ds_Centroid.Add(point3D_Centroid);

                if (!dictionary.TryGetValue((x, y, z), out List<int>? indexes_Cell))
                {
                    indexes_Cell = [];
                    dictionary[(x, y, z)] = indexes_Cell;
                }

                indexes_Cell.Add(resultIndex);
            }

            return result;
        }

        /// <summary>
        /// Assembles the final boolean operation geometry from the deduplicated boundary faces: a single solid
        /// <see cref="Classes.Polyhedron"/> when the faces form a valid closed volume, the individual faces as a
        /// fallback for non-solid remnants, or null when no geometry remains.
        /// </summary>
        private static List<IGeometry3D>? BooleanOperationGeometry3Ds(List<IPolygonalFace3D> polygonalFace3Ds)
        {
            // A solid closed polyhedron requires at least 4 faces
            if (polygonalFace3Ds.Count >= 4 && Polyhedron(polygonalFace3Ds) is Polyhedron polyhedron)
            {
                return [polyhedron];
            }

            if (polygonalFace3Ds.Count > 0)
            {
                List<IGeometry3D> result = new(polygonalFace3Ds.Count);
                for (int i = 0; i < polygonalFace3Ds.Count; i++)
                {
                    result.Add(polygonalFace3Ds[i]);
                }

                return result;
            }

            return null;
        }
    }
}
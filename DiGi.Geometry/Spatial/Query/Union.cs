using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the 3D boolean union between two polyhedra.
        /// </summary>
        /// <remarks>
        /// The computation is delegated to <see cref="Create.UnionResult3D{TPolygonalFace3D}(Polyhedron{TPolygonalFace3D}?, Polyhedron{TPolygonalFace3D}?, double)"/>; only the polyhedra of the result are returned. Use the result object directly to access lower-dimensional geometry elements.
        /// </remarks>
        /// <typeparam name="TPolygonalFace3D">The type of polygonal face, which must implement <see cref="IPolygonalFace3D"/>.</typeparam>
        /// <param name="polyhedron_1">The first polyhedron to unify.</param>
        /// <param name="polyhedron_2">The second polyhedron to unify.</param>
        /// <param name="tolerance">The distance tolerance for boolean union computations.</param>
        /// <returns>A list of <see cref="Polyhedron"/> objects representing the resulting union, or <c>null</c> if either input is null.</returns>
        public static List<Polyhedron>? Union<TPolygonalFace3D>(this Polyhedron<TPolygonalFace3D>? polyhedron_1, Polyhedron<TPolygonalFace3D>? polyhedron_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance) where TPolygonalFace3D : IPolygonalFace3D
        {
            if (polyhedron_1 == null || polyhedron_2 == null)
            {
                return null;
            }

            UnionResult3D? unionResult3D = Create.UnionResult3D(polyhedron_1, polyhedron_2, tolerance);
            if (unionResult3D == null)
            {
                return null;
            }

            return unionResult3D.GetGeometry3Ds<Polyhedron>() ?? [];
        }

        /// <summary>
        /// Calculates the geometric union of a collection of 3D polyhedra, optimizing performance via spatial partitioning and binary pairwise reduction.
        /// </summary>
        /// <typeparam name="TPolyhedron">The type of polyhedron, which must implement <see cref="IPolyhedron"/>.</typeparam>
        /// <param name="polyhedrons">The collection of 3D polyhedra to unify.</param>
        /// <param name="tolerance">The distance tolerance for boolean union computations.</param>
        /// <returns>A list of <see cref="Polyhedron"/> objects representing the resulting union, or <c>null</c> if the input collection is null.</returns>
        public static List<Polyhedron>? Union<TPolyhedron>(this IEnumerable<TPolyhedron>? polyhedrons, double tolerance = DiGi.Core.Constants.Tolerance.Distance) where TPolyhedron : IPolyhedron
        {
            if (polyhedrons == null)
            {
                return null;
            }

            List<Polyhedron> validPolyhedrons = [];
            List<BoundingBox3D> boundingBoxes = [];

            foreach (TPolyhedron item in polyhedrons)
            {
                if (item == null)
                {
                    continue;
                }

                Polyhedron? polyhedron = item is Polyhedron poly ? poly : Create.Polyhedron(item);
                if (polyhedron == null)
                {
                    continue;
                }

                BoundingBox3D? boundingBox3D = polyhedron.GetBoundingBox();
                if (boundingBox3D == null)
                {
                    continue;
                }

                validPolyhedrons.Add(polyhedron);
                boundingBoxes.Add(boundingBox3D);
            }

            int count = validPolyhedrons.Count;
            if (count == 0)
            {
                return [];
            }

            if (count == 1)
            {
                return [validPolyhedrons[0]];
            }

            static List<List<Polyhedron>> PartitionIntoClusters(List<Polyhedron> polyhedrons_Cluster, List<BoundingBox3D> boundingBoxes_Cluster, double tolerance_Cluster)
            {
                int clusterCount = polyhedrons_Cluster.Count;
                int[] parent = new int[clusterCount];
                for (int i = 0; i < clusterCount; i++)
                {
                    parent[i] = i;
                }

                int Find(int i)
                {
                    while (i != parent[i])
                    {
                        parent[i] = parent[parent[i]];
                        i = parent[i];
                    }
                    return i;
                }

                void UnionSets(int i, int j)
                {
                    int rootI = Find(i);
                    int rootJ = Find(j);
                    if (rootI != rootJ)
                    {
                        parent[rootI] = rootJ;
                    }
                }

                for (int i = 0; i < clusterCount; i++)
                {
                    BoundingBox3D bboxI = boundingBoxes_Cluster[i];
                    for (int j = i + 1; j < clusterCount; j++)
                    {
                        if (bboxI.InRange(boundingBoxes_Cluster[j], tolerance_Cluster))
                        {
                            UnionSets(i, j);
                        }
                    }
                }

                Dictionary<int, List<Polyhedron>> componentMap = [];
                for (int i = 0; i < clusterCount; i++)
                {
                    int root = Find(i);
                    if (!componentMap.TryGetValue(root, out List<Polyhedron>? list))
                    {
                        list = [];
                        componentMap[root] = list;
                    }

                    list.Add(polyhedrons_Cluster[i]);
                }

                return [.. componentMap.Values];
            }

            static List<Polyhedron> UnifyCluster(List<Polyhedron> cluster, double tolerance_Unify)
            {
                List<Polyhedron> current = cluster;

                while (current.Count > 1)
                {
                    List<Polyhedron> nextPass = [];
                    bool[] merged = new bool[current.Count];
                    bool mergedAny = false;

                    for (int i = 0; i < current.Count; i++)
                    {
                        if (merged[i])
                        {
                            continue;
                        }

                        Polyhedron poly1 = current[i];
                        BoundingBox3D? bbox1 = poly1.GetBoundingBox();

                        int bestMatchIndex = -1;

                        if (bbox1 != null)
                        {
                            for (int j = i + 1; j < current.Count; j++)
                            {
                                if (merged[j])
                                {
                                    continue;
                                }

                                BoundingBox3D? bbox2 = current[j].GetBoundingBox();
                                if (bbox2 != null && bbox1.InRange(bbox2, tolerance_Unify))
                                {
                                    bestMatchIndex = j;
                                    break;
                                }
                            }
                        }

                        if (bestMatchIndex != -1)
                        {
                            Polyhedron poly2 = current[bestMatchIndex];
                            merged[i] = true;
                            merged[bestMatchIndex] = true;

                            List<Polyhedron>? unionResult = Union(poly1, poly2, tolerance_Unify);
                            if (unionResult != null && unionResult.Count > 0)
                            {
                                nextPass.AddRange(unionResult);
                                mergedAny = true;
                            }
                            else
                            {
                                nextPass.Add(poly1);
                                nextPass.Add(poly2);
                            }
                        }
                        else
                        {
                            merged[i] = true;
                            nextPass.Add(poly1);
                        }
                    }

                    if (!mergedAny || nextPass.Count >= current.Count)
                    {
                        return nextPass;
                    }

                    current = nextPass;
                }

                return current;
            }

            List<List<Polyhedron>> clusters = PartitionIntoClusters(validPolyhedrons, boundingBoxes, tolerance);
            List<Polyhedron> result = [];

            for (int i = 0; i < clusters.Count; i++)
            {
                List<Polyhedron> cluster = clusters[i];
                if (cluster.Count == 1)
                {
                    result.Add(cluster[0]);
                    continue;
                }

                List<Polyhedron> unifiedCluster = UnifyCluster(cluster, tolerance);
                result.AddRange(unifiedCluster);
            }

            return result;
        }
    }
}

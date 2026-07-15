using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        /// <summary>
        /// Decomposes the specified mesh into its connected components.
        /// </summary>
        /// <param name="mesh3D">The <see cref="Classes.Mesh3D"/> to decompose.</param>
        /// <returns>A <see cref="List{T}"/> of <see cref="Classes.Mesh3D"/> instances, each representing a connected component, or <c>null</c> if the input is <c>null</c> or empty.</returns>
        public static List<Mesh3D>? Mesh3Ds(this Mesh3D? mesh3D)
        {
            if (mesh3D == null)
            {
                return null;
            }

            List<Point3D>? point3Ds = mesh3D.GetPoints();
            List<int[]>? indexes = mesh3D.GetIndexes();
            if (point3Ds == null || indexes == null || point3Ds.Count == 0 || indexes.Count == 0)
            {
                return null;
            }

            int triangleCount = indexes.Count;

            static (int, int) EdgeKey(int index_1, int index_2)
            {
                return index_1 < index_2 ? (index_1, index_2) : (index_2, index_1);
            }

            Dictionary<(int, int), List<int>> edgeToTriangles = new(triangleCount * 3 / 2 + 1);
            for (int i = 0; i < triangleCount; i++)
            {
                int[] indexes_Triangle = indexes[i];
                if (indexes_Triangle == null || indexes_Triangle.Length < 3)
                {
                    continue;
                }

                (int, int) key_0 = EdgeKey(indexes_Triangle[0], indexes_Triangle[1]);
                if (!edgeToTriangles.TryGetValue(key_0, out List<int>? triangles_0) || triangles_0 == null)
                {
                    triangles_0 = [];
                    edgeToTriangles[key_0] = triangles_0;
                }
                triangles_0.Add(i);

                (int, int) key_1 = EdgeKey(indexes_Triangle[1], indexes_Triangle[2]);
                if (!edgeToTriangles.TryGetValue(key_1, out List<int>? triangles_1) || triangles_1 == null)
                {
                    triangles_1 = [];
                    edgeToTriangles[key_1] = triangles_1;
                }
                triangles_1.Add(i);

                (int, int) key_2 = EdgeKey(indexes_Triangle[2], indexes_Triangle[0]);
                if (!edgeToTriangles.TryGetValue(key_2, out List<int>? triangles_2) || triangles_2 == null)
                {
                    triangles_2 = [];
                    edgeToTriangles[key_2] = triangles_2;
                }
                triangles_2.Add(i);
            }

            bool[] visited = new bool[triangleCount];
            List<List<int>> componentTriangleIndices = [];
            Queue<int> queue = new();

            for (int i = 0; i < triangleCount; i++)
            {
                if (visited[i])
                {
                    continue;
                }

                int[] indexes_Triangle = indexes[i];
                if (indexes_Triangle == null || indexes_Triangle.Length < 3)
                {
                    continue;
                }

                List<int> componentIndices = [];
                queue.Clear();
                queue.Enqueue(i);
                visited[i] = true;

                while (queue.Count > 0)
                {
                    int triangleIndex = queue.Dequeue();
                    componentIndices.Add(triangleIndex);

                    indexes_Triangle = indexes[triangleIndex];
                    if (indexes_Triangle == null || indexes_Triangle.Length < 3)
                    {
                        continue;
                    }

                    (int, int)[] edgeKeys = [EdgeKey(indexes_Triangle[0], indexes_Triangle[1]), EdgeKey(indexes_Triangle[1], indexes_Triangle[2]), EdgeKey(indexes_Triangle[2], indexes_Triangle[0])];

                    foreach ((int, int) edgeKey in edgeKeys)
                    {
                        if (edgeToTriangles.TryGetValue(edgeKey, out List<int>? neighborTriangles) && neighborTriangles != null)
                        {
                            foreach (int neighborIndex in neighborTriangles)
                            {
                                if (!visited[neighborIndex])
                                {
                                    visited[neighborIndex] = true;
                                    queue.Enqueue(neighborIndex);
                                }
                            }
                        }
                    }
                }

                if (componentIndices.Count > 0)
                {
                    componentTriangleIndices.Add(componentIndices);
                }
            }

            if (componentTriangleIndices.Count == 0)
            {
                return null;
            }

            List<Mesh3D> result = new(componentTriangleIndices.Count);
            foreach (List<int> componentIndices in componentTriangleIndices)
            {
                Dictionary<int, int> indexRemap = new();
                List<Point3D> componentPoint3Ds = [];
                List<int[]> componentIndexes = new(componentIndices.Count);

                foreach (int triangleIndex in componentIndices)
                {
                    int[] indexes_Triangle = indexes[triangleIndex];
                    int[] indexes_Remapped = new int[3];

                    for (int j = 0; j < 3; j++)
                    {
                        int originalIndex = indexes_Triangle[j];
                        if (!indexRemap.TryGetValue(originalIndex, out int remappedIndex))
                        {
                            remappedIndex = componentPoint3Ds.Count;
                            componentPoint3Ds.Add(new Point3D(point3Ds[originalIndex]));
                            indexRemap[originalIndex] = remappedIndex;
                        }
                        indexes_Remapped[j] = remappedIndex;
                    }

                    componentIndexes.Add(indexes_Remapped);
                }

                result.Add(new Mesh3D(componentPoint3Ds, componentIndexes, false));
            }

            return result;
        }
    }
}

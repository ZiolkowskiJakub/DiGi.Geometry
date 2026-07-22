using DiGi.Core.Classes;
using DiGi.Geometry.Core.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Core.Classes
{
    /// <summary>
    /// Represents an abstract base class for a mesh structure consisting of points and indices.
    /// </summary>
    /// <typeparam name="TPoint">The type of point used in the mesh, which must implement <see cref="IPoint{TPoint}"/>.</typeparam>
    public abstract class Mesh<TPoint> : SerializableObject, IMesh where TPoint : IPoint<TPoint>
    {
        [JsonInclude, JsonPropertyName("Indexes")]
        protected List<int[]>? indexes;

        [JsonInclude, JsonPropertyName("Points")]
        protected List<TPoint>? points;

        /// <summary>
        /// Initializes a new instance of the <see cref="Mesh{TPoint}"/> class using the provided <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data used to initialize the mesh. This value can be null.</param>
        public Mesh(JsonObject? jsonObject)
        {
            FromJsonObject(jsonObject);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mesh{TPoint}"/> class by cloning points from an existing <see cref="Mesh{TPoint}"/> object.
        /// </summary>
        /// <param name="mesh">The source <see cref="Mesh{TPoint}"/> object to clone points from.</param>
        public Mesh(Mesh<TPoint>? mesh)
        {
            if (mesh != null)
            {
                List<TPoint>? points_Source = mesh.points;
                if (points_Source != null)
                {
                    points = new List<TPoint>(points_Source.Count);
                    for (int i = 0; i < points_Source.Count; i++)
                    {
                        TPoint point = points_Source[i];
                        if (point == null)
                        {
                            continue;
                        }

                        if (point.Clone() is TPoint point_Temp)
                        {
                            points.Add(point_Temp);
                        }
                    }
                }

                List<int[]>? indexes_Source = mesh.indexes;
                if (indexes_Source != null)
                {
                    indexes = new List<int[]>(indexes_Source.Count);
                    for (int i = 0; i < indexes_Source.Count; i++)
                    {
                        int[] vertices = indexes_Source[i];
                        indexes.Add([vertices[0], vertices[1], vertices[2]]);
                    }
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mesh{TPoint}"/> class with the specified points and indexes.
        /// </summary>
        /// <param name="points">An <see cref="IEnumerable{TPoint}"/> containing the vertices of the mesh. This value can be null.</param>
        /// <param name="indexes">An <see cref="IEnumerable{Int32}"/> of integer arrays defining the indices for the mesh faces. This value can be null.</param>
        public Mesh(IEnumerable<TPoint>? points, IEnumerable<int[]>? indexes)
        {
            if (points == null || indexes == null)
            {
                return;
            }

            this.points = points is ICollection<TPoint> points_Collection ? new List<TPoint>(points_Collection.Count) : [];
            foreach (TPoint point in points)
            {
                if (point == null)
                {
                    continue;
                }

                if (point.Clone() is TPoint point_Temp)
                {
                    this.points.Add(point_Temp);
                }
            }

            int count = this.points.Count;

            this.indexes = indexes is ICollection<int[]> indexes_Collection ? new List<int[]>(indexes_Collection.Count) : [];
            foreach (int[] vertices in indexes)
            {
                if (vertices == null || vertices.Length < 3)
                {
                    continue;
                }

                int index_1 = vertices[0];
                int index_2 = vertices[1];
                int index_3 = vertices[2];

                if (index_1 < 0 || index_1 >= count || index_2 < 0 || index_2 >= count || index_3 < 0 || index_3 >= count)
                {
                    continue;
                }

                this.indexes.Add([index_1, index_2, index_3]);
            }
        }

        /// <summary>
        /// Gets the number of points in the collection. Returns -1 if the point collection is null.
        /// </summary>
        /// <value>An int representing the count of points, or -1 if the collection is null.</value>
        [JsonIgnore]
        public int PointsCount
        {
            get
            {
                if (points == null)
                {
                    return -1;
                }

                return points.Count;
            }
        }

        /// <summary>
        /// Gets the total number of triangles.
        /// </summary>
        /// <value>
        /// An <see cref="int"/> representing the count of triangles, or -1 if the index collection is null.
        /// </value>
        [JsonIgnore]
        public int TrianglesCount
        {
            get
            {
                if (indexes == null)
                {
                    return -1;
                }

                return indexes.Count;
            }
        }

        /// <summary>
        /// Retrieves the set of indexes connected to the specified index.
        /// </summary>
        /// <param name="index">The int index for which to find connections.</param>
        /// <returns>A <c>HashSet&lt;int&gt;</c> containing all connected indexes, or <see langword="null"/> if the internal collection is <see langword="null"/> or the provided int index is negative.</returns>
        public HashSet<int>? GetConnectedIndexes(int index)
        {
            if (indexes == null || index < 0)
            {
                return null;
            }

            HashSet<int> result = [];
            for (int i = 0; i < indexes.Count; i++)
            {
                int[] indexes_Temp = indexes[i];
                if (indexes_Temp[0] != index && indexes_Temp[1] != index && indexes_Temp[2] != index)
                {
                    continue;
                }

                if (indexes_Temp[0] != index)
                {
                    result.Add(indexes_Temp[0]);
                }

                if (indexes_Temp[1] != index)
                {
                    result.Add(indexes_Temp[1]);
                }

                if (indexes_Temp[2] != index)
                {
                    result.Add(indexes_Temp[2]);
                }
            }

            return result;
        }

        /// <summary>
        /// Retrieves a set of points connected to the point at the specified index.
        /// </summary>
        /// <param name="index">The <see cref="int"/> index of the point.</param>
        /// <returns>A <see cref="HashSet{TPoint}"/> containing the connected points, or <c>null</c> if the internal points collection is null or no connected indexes are found.</returns>
        public HashSet<TPoint>? GetConnectedPoints(int index)
        {
            if (points == null)
            {
                return null;
            }

            HashSet<int>? indexes_Temp = GetConnectedIndexes(index);
            if (indexes_Temp == null)
            {
                return null;
            }

            HashSet<TPoint> result = [];
            foreach (int index_Temp in indexes_Temp)
            {
                if (points[index_Temp]?.Clone() is TPoint point_Temp)
                {
                    result.Add(point_Temp);
                }
            }

            return result;
        }

        /// <summary>
        /// Retrieves a list of integer arrays containing the indexes.
        /// </summary>
        /// <returns>A <see cref="List{T}"/> of <c>int[]</c> if the indexes are available; otherwise, null.</returns>
        public List<int[]>? GetIndexes()
        {
            if (indexes == null)
            {
                return null;
            }

            List<int[]> result = new(indexes.Count);
            for (int i = 0; i < indexes.Count; i++)
            {
                int[] indexes_Triangle = indexes[i];
                result.Add([indexes_Triangle[0], indexes_Triangle[1], indexes_Triangle[2]]);
            }

            return result;
        }

        /// <summary>
        /// Retrieves the indices for the element at the specified index.
        /// </summary>
        /// <param name="index">The <see cref="int"/> index of the element to retrieve.</param>
        /// <returns>An <c>int[]</c> containing the indices if available; otherwise, <see langword="null"/>.</returns>
        public int[]? GetIndexes(int index)
        {
            if (indexes == null)
            {
                return null;
            }

            int[] indexes_Triangle = indexes[index];

            return [indexes_Triangle[0], indexes_Triangle[1], indexes_Triangle[2]];
        }

        /// <summary>
        /// Retrieves a list of cloned <typeparamref name="TPoint"/> objects.
        /// </summary>
        /// <returns>A List&lt;TPoint&gt; containing the cloned points, or null if the internal collection is null.</returns>
        public List<TPoint>? GetPoints()
        {
            if (points == null)
            {
                return null;
            }

            List<TPoint> result = new(points.Count);
            for (int i = 0; i < points.Count; i++)
            {
                TPoint point = points[i];
                if (point == null)
                {
                    continue;
                }

                if (point.Clone() is TPoint point_Temp)
                {
                    result.Add(point_Temp);
                }
            }

            return result;
        }

        /// <summary>
        /// Returns the zero-based index of the first occurrence of the specified <typeparamref name="TPoint"/> object in the collection.
        /// </summary>
        /// <param name="point">The <typeparamref name="TPoint"/> object to locate in the collection.</param>
        /// <returns>The zero-based index of the first occurrence of the specified <typeparamref name="TPoint"/> object if found; otherwise, -1.</returns>
        public int IndexOf(TPoint? point)
        {
            if (point == null || points == null)
            {
                return -1;
            }

            for (int i = 0; i < points.Count; i++)
            {
                if (point.Equals(points[i]))
                {
                    return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Determines whether the mesh forms a closed (watertight, manifold) surface, i.e. every edge is shared by exactly two triangles.
        /// <para>Runs in a single pass over the triangles, keying each edge on its ordered pair of vertex indices, and exits early when a non-manifold edge (shared by more than two triangles) or a degenerate triangle is found.</para>
        /// <para>This is the index-based counterpart of <c>DiGi.Geometry.Spatial.Query.IsClosed</c> for a polyhedron, which has no shared vertex table and so must weld coincident vertices within a tolerance before it can count edges the same way.</para>
        /// </summary>
        /// <returns><see langword="true"/> if every edge of the mesh is shared by exactly two triangles; otherwise, <see langword="false"/>. Returns <see langword="false"/> if the indexes are unavailable or the mesh has fewer than four triangles.</returns>
        public bool IsClosed()
        {
            if (indexes == null || indexes.Count < 4)
            {
                return false;
            }

            // ValueTuple keys are used deliberately: their seeded rotate-combine hash distributes the highly regular edge index pairs
            // of structured meshes far better than a packed 64-bit integer key, whose default hash (low ^ high) degenerates into long collision chains.
            static (int, int) edgeKey(int index_1, int index_2)
            {
                return index_1 < index_2 ? (index_1, index_2) : (index_2, index_1);
            }

            Dictionary<(int, int), int> edgeCounts = new(indexes.Count * 3 / 2 + 1);
            for (int i = 0; i < indexes.Count; i++)
            {
                int[] indexes_Triangle = indexes[i];
                if (indexes_Triangle == null || indexes_Triangle.Length < 3)
                {
                    return false;
                }

                int index_1 = indexes_Triangle[0];
                int index_2 = indexes_Triangle[1];
                int index_3 = indexes_Triangle[2];

                if (index_1 == index_2 || index_2 == index_3 || index_3 == index_1)
                {
                    return false;
                }

                (int, int) key_1 = edgeKey(index_1, index_2);
                edgeCounts.TryGetValue(key_1, out int count_1);
                if (count_1 >= 2)
                {
                    return false;
                }
                edgeCounts[key_1] = count_1 + 1;

                (int, int) key_2 = edgeKey(index_2, index_3);
                edgeCounts.TryGetValue(key_2, out int count_2);
                if (count_2 >= 2)
                {
                    return false;
                }
                edgeCounts[key_2] = count_2 + 1;

                (int, int) key_3 = edgeKey(index_3, index_1);
                edgeCounts.TryGetValue(key_3, out int count_3);
                if (count_3 >= 2)
                {
                    return false;
                }
                edgeCounts[key_3] = count_3 + 1;
            }

            foreach (KeyValuePair<(int, int), int> keyValuePair in edgeCounts)
            {
                if (keyValuePair.Value != 2)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Retrieves the sorted boundary points based on the available indexes and point data.
        /// </summary>
        /// <returns>A <see cref="List{T}"/> of <see cref="List{T}"/> containing <typeparamref name="TPoint"/> objects representing the sorted boundaries, or <c>null</c> if the internal indexes or points are null, or if the boundary index query fails.</returns>
        public List<List<TPoint>>? GetSortedBoundaryPoints()
        {
            if (indexes is null || points is null)
            {
                return null;
            }

            List<List<int>>? sortedBoudaryIndexes = Query.SortedBoundaryIndexes(indexes);
            if (sortedBoudaryIndexes is null)
            {
                return null;
            }

            List<List<TPoint>> result = [];
            foreach (List<int> indexes in sortedBoudaryIndexes)
            {
                result.Add(indexes.ConvertAll(x => points[x]));
            }

            return result;
        }
    }
}
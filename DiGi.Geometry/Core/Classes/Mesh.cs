using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Geometry.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;
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
                List<TPoint?>? points_Temp = mesh?.points?.Clone();
                if (points_Temp != null)
                {
                    points = [];
                    foreach (TPoint? point in points_Temp)
                    {
                        if (point == null)
                        {
                            continue;
                        }

                        TPoint? point_Temp = point.Clone<TPoint>();
                        if (point_Temp == null)
                        {
                            continue;
                        }

                        points.Add(point_Temp);
                    }
                }

                if (mesh?.indexes != null)
                {
                    indexes = [];
                    foreach (int[] vertices in mesh.indexes)
                    {
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

            List<TPoint?>? points_Temp = points?.Clone();
            if (points_Temp != null)
            {
                this.points = [];
                foreach (TPoint? point in points_Temp)
                {
                    if (point == null)
                    {
                        continue;
                    }

                    TPoint? point_Temp = point.Clone<TPoint>();
                    if (point_Temp == null)
                    {
                        continue;
                    }

                    this.points.Add(point_Temp);
                }
            }

            int count = this.points?.Count ?? 0;

            this.indexes = [];
            foreach (int[] vertices in indexes)
            {
                if (vertices == null || vertices.Length < 3)
                {
                    continue;
                }

                if (vertices[0] >= count || vertices[1] >= count || vertices[2] >= count)
                {
                    continue;
                }

                this.indexes.Add([vertices[0], vertices[1], vertices[2]]);
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
            foreach (int[] indexes_Temp in indexes)
            {
                if (indexes_Temp.Contains(index))
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (indexes_Temp[0] != index)
                        {
                            result.Add(indexes_Temp[0]);
                        }
                    }
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
                TPoint? t = points[index_Temp].Clone<TPoint>();
                if (t != null)
                {
                    result.Add(t);
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

            List<int[]> result = [];
            for (int i = 0; i < indexes.Count; i++)
            {
                result.Add([indexes[i][0], indexes[i][1], indexes[i][2]]);
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

            List<TPoint> result = [];
            foreach (TPoint point in points)
            {
                if (point == null)
                {
                    continue;
                }

                TPoint? point_Temp = point.Clone<TPoint>();
                if (point_Temp == null)
                {
                    continue;
                }

                result.Add(point_Temp);
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
using System.Collections.Generic;

namespace DiGi.Geometry.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Returns the sorted boundary indexes derived from the provided collection of <c>int[]</c>.
        /// </summary>
        /// <param name="indexes">The <see cref="IEnumerable{T}"/> of <c>int[]</c> representing the input indexes.</param>
        /// <returns>A <see cref="List{T}"/> containing <see cref="List{T}"/> of <see cref="int"/> if successful; otherwise, <see langword="null"/>.</returns>
        public static List<List<int>>? SortedBoundaryIndexes(this IEnumerable<int[]>? indexes)
        {
            return SortedBoundaryIndexes(indexes, out _);
        }

        /// <summary>
        /// Sorts the boundary indexes into continuous loops of vertex indices.
        /// </summary>
        /// <param name="indexes">The IEnumerable&lt;int[]&gt; containing the mesh index arrays.</param>
        /// <param name="auxiliaryIndexes">When this method returns, contains a List&lt;int[]&gt; of auxiliary indexes used during boundary detection.</param>
        /// <returns>A List&lt;List&lt;int&gt;&gt; where each inner list represents a sorted loop of boundary vertex indices; returns null if the input IEnumerable&lt;int[]&gt; is null.</returns>
        public static List<List<int>>? SortedBoundaryIndexes(this IEnumerable<int[]>? indexes, out List<int[]>? auxiliaryIndexes)
        {
            // 1. Get raw boundary edges (from the previous method)
            List<int[]>? edges = BoundaryIndexes(indexes, out auxiliaryIndexes);
            if (edges == null)
            {
                return null;
            }

            if (edges.Count == 0)
            {
                return [];
            }

            // 2. Build an adjacency map for quick lookup
            // Each boundary vertex will have exactly 2 boundary neighbors in a manifold mesh
            Dictionary<int, List<int>> adjacency = [];
            for (int int_I = 0; int_I < edges.Count; int_I++)
            {
                int[] intArray_Edge = edges[int_I];
                if (intArray_Edge == null || intArray_Edge.Length < 2)
                {
                    continue;
                }

                int int_V1 = intArray_Edge[0];
                int int_V2 = intArray_Edge[1];

                if (!adjacency.TryGetValue(int_V1, out List<int>? neighbors1) || neighbors1 is null)
                {
                    neighbors1 = [];
                    adjacency[int_V1] = neighbors1;
                }
                if (!adjacency.TryGetValue(int_V2, out List<int>? neighbors2) || neighbors2 is null)
                {
                    neighbors2 = [];
                    adjacency[int_V2] = neighbors2;
                }

                neighbors1.Add(int_V2);
                neighbors2.Add(int_V1);
            }

            List<List<int>> results = [];
            HashSet<int> visitedVertices = [];

            // 3. Traverse the adjacency map to form loops
            foreach (int int_StartVertex in adjacency.Keys)
            {
                if (visitedVertices.Contains(int_StartVertex))
                {
                    continue;
                }

                List<int> currentLoop = [];
                int int_Current = int_StartVertex;
                bool bool_Closed = false;

                while (!bool_Closed)
                {
                    visitedVertices.Add(int_Current);
                    currentLoop.Add(int_Current);

                    List<int> neighbors = adjacency[int_Current];
                    int int_Next = -1;

                    for (int int_J = 0; int_J < neighbors.Count; int_J++)
                    {
                        int int_Neighbor = neighbors[int_J];
                        if (int_Neighbor == int_StartVertex && currentLoop.Count > 2)
                        {
                            // Loop is closed
                            bool_Closed = true;
                            break;
                        }
                        if (!visitedVertices.Contains(int_Neighbor))
                        {
                            int_Next = int_Neighbor;
                            break;
                        }
                    }

                    if (int_Next != -1)
                    {
                        int_Current = int_Next;
                    }
                    else
                    {
                        // If we can't find a next vertex and it's not closed,
                        // it might be an open boundary (non-manifold)
                        bool_Closed = true;
                    }
                }

                if (currentLoop.Count > 0)
                {
                    results.Add(currentLoop);
                }
            }

            return results;
        }
    }
}
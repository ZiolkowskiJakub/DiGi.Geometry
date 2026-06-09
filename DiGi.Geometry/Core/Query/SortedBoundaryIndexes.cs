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
            foreach (int[] edge in edges)
            {
                if (!adjacency.ContainsKey(edge[0])) adjacency[edge[0]] = [];
                if (!adjacency.ContainsKey(edge[1])) adjacency[edge[1]] = [];

                adjacency[edge[0]].Add(edge[1]);
                adjacency[edge[1]].Add(edge[0]);
            }

            List<List<int>> result = [];
            HashSet<int> visitedVertices = [];

            // 3. Traverse the adjacency map to form loops
            foreach (int startVertex in adjacency.Keys)
            {
                if (visitedVertices.Contains(startVertex))
                {
                    continue;
                }

                List<int> currentLoop = [];
                int current = startVertex;
                bool closed = false;

                while (!closed)
                {
                    visitedVertices.Add(current);
                    currentLoop.Add(current);

                    List<int> neighbors = adjacency[current];
                    int next = -1;

                    foreach (int neighbor in neighbors)
                    {
                        if (neighbor == startVertex && currentLoop.Count > 2)
                        {
                            // Loop is closed
                            closed = true;
                            break;
                        }
                        if (!visitedVertices.Contains(neighbor))
                        {
                            next = neighbor;
                            break;
                        }
                    }

                    if (next != -1)
                    {
                        current = next;
                    }
                    else
                    {
                        // If we can't find a next vertex and it's not closed,
                        // it might be an open boundary (non-manifold)
                        closed = true;
                    }
                }

                if (currentLoop.Count > 0)
                {
                    result.Add(currentLoop);
                }
            }

            return result;
        }
    }
}
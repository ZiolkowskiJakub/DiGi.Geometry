using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Creates an adjacency dictionary from a collection of indexes.
        /// </summary>
        /// <param name="indexes">The <see cref="IEnumerable{T}"/> of <see cref="int[]"/> representing the indexes to process.</param>
        /// <returns>A <see cref="Dictionary{TKey, TValue}"/> mapping each node index to a <see cref="List{T}"/> of its adjacent <see cref="int[]"/> edges, or <c>null</c> if the input is <c>null</c>.</returns>
        public static Dictionary<int, List<int[]>>? AdjacencyIndexes(this IEnumerable<int[]>? indexes)
        {
            if (indexes == null)
            {
                return null;
            }

            if (!indexes.Any())
            {
                return [];
            }

            // Dictionary to store edge as a sorted tuple and its occurrence count
            // Using (int, int) where Item1 < Item2 to ensure edge direction doesn't matter
            Dictionary<(int, int), int> edgeCount = [];

            static (int, int) createSortedEdge(int v1, int v2)
            {
                return v1 < v2 ? (v1, v2) : (v2, v1);
            }

            foreach (int[] triangle in indexes)
            {
                if (triangle.Length < 3)
                {
                    continue;
                }

                // Each triangle has 3 edges: (0,1), (1,2), (2,0)
                (int, int)[] edges =
                [
                    createSortedEdge(triangle[0], triangle[1]),
                    createSortedEdge(triangle[1], triangle[2]),
                    createSortedEdge(triangle[2], triangle[0])
                ];

                foreach ((int, int) edge in edges)
                {
                    if (edgeCount.ContainsKey(edge))
                    {
                        edgeCount[edge]++;
                    }
                    else
                    {
                        edgeCount[edge] = 1;
                    }
                }
            }

            Dictionary<int, List<int[]>> result = [];
            foreach (KeyValuePair<(int, int), int> entry in edgeCount)
            {
                if (!result.TryGetValue(entry.Value, out List<int[]> edges) || edges is null)
                {
                    edges = [];
                    result[entry.Value] = edges;
                }

                edges.Add([entry.Key.Item1, entry.Key.Item2]);
            }

            return result;
        }
    }
}
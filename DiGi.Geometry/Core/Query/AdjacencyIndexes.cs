using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Creates an adjacency dictionary from a collection of indexes.
        /// </summary>
        /// <param name="indexes">The <see cref="IEnumerable{T}"/> of <c>int[]</c> representing the indexes to process.</param>
        /// <returns>A <see cref="Dictionary{TKey, TValue}"/> mapping each node index to a <see cref="List{T}"/> of its adjacent <c>int[]</c> edges, or <c>null</c> if the input is <c>null</c>.</returns>
        public static Dictionary<int, List<int[]>>? AdjacencyIndexes(this IEnumerable<int[]>? indexes)
        {
            if (indexes == null)
            {
                return null;
            }

            int[][] indexes_Cached = indexes as int[][] ?? indexes.ToArray();
            if (indexes_Cached.Length == 0)
            {
                return [];
            }

            // Dictionary to store edge as a sorted tuple and its occurrence count
            // Using (int, int) where Item1 < Item2 to ensure edge direction doesn't matter
            Dictionary<(int, int), int> edgeCounts = [];

            static (int, int) createSortedEdge(int v1, int v2)
            {
                return v1 < v2 ? (v1, v2) : (v2, v1);
            }

            for (int int_I = 0; int_I < indexes_Cached.Length; int_I++)
            {
                int[] intArray_Triangle = indexes_Cached[int_I];
                if (intArray_Triangle == null || intArray_Triangle.Length < 3)
                {
                    continue;
                }

                // Edge 1
                (int, int) tuple_Edge1 = createSortedEdge(intArray_Triangle[0], intArray_Triangle[1]);
                if (edgeCounts.TryGetValue(tuple_Edge1, out int int_Count1))
                {
                    edgeCounts[tuple_Edge1] = int_Count1 + 1;
                }
                else
                {
                    edgeCounts[tuple_Edge1] = 1;
                }

                // Edge 2
                (int, int) tuple_Edge2 = createSortedEdge(intArray_Triangle[1], intArray_Triangle[2]);
                if (edgeCounts.TryGetValue(tuple_Edge2, out int int_Count2))
                {
                    edgeCounts[tuple_Edge2] = int_Count2 + 1;
                }
                else
                {
                    edgeCounts[tuple_Edge2] = 1;
                }

                // Edge 3
                (int, int) tuple_Edge3 = createSortedEdge(intArray_Triangle[2], intArray_Triangle[0]);
                if (edgeCounts.TryGetValue(tuple_Edge3, out int int_Count3))
                {
                    edgeCounts[tuple_Edge3] = int_Count3 + 1;
                }
                else
                {
                    edgeCounts[tuple_Edge3] = 1;
                }
            }

            Dictionary<int, List<int[]>> results = [];
            foreach (KeyValuePair<(int, int), int> keyValuePair_Entry in edgeCounts)
            {
                if (!results.TryGetValue(keyValuePair_Entry.Value, out List<int[]>? edges) || edges is null)
                {
                    edges = [];
                    results[keyValuePair_Entry.Value] = edges;
                }

                edges.Add([keyValuePair_Entry.Key.Item1, keyValuePair_Entry.Key.Item2]);
            }

            return results;
        }
    }
}
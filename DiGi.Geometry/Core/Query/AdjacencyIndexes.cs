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

            int[][] indexes_Cached = indexes as int[][] ?? [.. indexes];
            if (indexes_Cached.Length == 0)
            {
                return [];
            }

            // Edges are undirected, so each edge key stores the smaller index first.
            // ValueTuple keys are used deliberately: their seeded rotate-combine hash distributes the highly regular edge index pairs
            // of structured meshes far better than a packed 64-bit integer key, whose default hash (low ^ high) degenerates into long collision chains.
            static (int, int) edgeKey(int index_1, int index_2)
            {
                return index_1 < index_2 ? (index_1, index_2) : (index_2, index_1);
            }

            Dictionary<(int, int), int> edgeCounts = new(indexes_Cached.Length * 3 / 2 + 1);
            for (int i = 0; i < indexes_Cached.Length; i++)
            {
                int[] indexes_Triangle = indexes_Cached[i];
                if (indexes_Triangle == null || indexes_Triangle.Length < 3)
                {
                    continue;
                }

                (int, int) key_1 = edgeKey(indexes_Triangle[0], indexes_Triangle[1]);
                edgeCounts.TryGetValue(key_1, out int count_1);
                edgeCounts[key_1] = count_1 + 1;

                (int, int) key_2 = edgeKey(indexes_Triangle[1], indexes_Triangle[2]);
                edgeCounts.TryGetValue(key_2, out int count_2);
                edgeCounts[key_2] = count_2 + 1;

                (int, int) key_3 = edgeKey(indexes_Triangle[2], indexes_Triangle[0]);
                edgeCounts.TryGetValue(key_3, out int count_3);
                edgeCounts[key_3] = count_3 + 1;
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
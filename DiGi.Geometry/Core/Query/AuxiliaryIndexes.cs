using System.Collections.Generic;

namespace DiGi.Geometry.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Computes the auxiliary indexes based on the provided collection of index arrays.
        /// </summary>
        /// <param name="indexes">The <see cref="IEnumerable{T}"/> of <c>int[]</c> containing the original indexes.</param>
        /// <returns>A <see cref="List{T}"/> of <c>int[]</c> representing the auxiliary indexes, or <see langword="null"/> if the input is <see langword="null"/>.</returns>
        public static List<int[]>? AuxiliaryIndexes(this IEnumerable<int[]>? indexes)
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

            if (AdjacencyIndexes(indexes_Cached) is not Dictionary<int, List<int[]>> dictionary)
            {
                return [];
            }

            List<int[]> intArrays_Result = [];

            foreach (int adjacency in dictionary.Keys)
            {
                if (adjacency > 1)
                {
                    intArrays_Result.AddRange(dictionary[adjacency]);
                }
            }

            return intArrays_Result;
        }
    }
}
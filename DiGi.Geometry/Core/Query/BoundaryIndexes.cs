using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Identifies the boundary indexes from a collection of indexes and extracts auxiliary indexes.
        /// </summary>
        /// <param name="indexes">The <see cref="IEnumerable{T}"/> of <c>int[]</c> representing the input indexes.</param>
        /// <param name="auxiliaryIndexes">When this method returns, contains a <see cref="List{T}"/> of <c>int[]</c> representing the auxiliary indexes, or null if none were identified.</param>
        /// <returns>A <see cref="List{T}"/> of <c>int[]</c> containing the boundary indexes, or null if the input <see cref="IEnumerable{T}"/> is null.</returns>
        public static List<int[]>? BoundaryIndexes(this IEnumerable<int[]>? indexes, out List<int[]>? auxiliaryIndexes)
        {
            auxiliaryIndexes = null;

            if (indexes == null)
            {
                return null;
            }

            int[][] indexes_Cached = indexes as int[][] ?? indexes.ToArray();
            if (indexes_Cached.Length == 0)
            {
                return [];
            }

            if (AdjacencyIndexes(indexes_Cached) is not Dictionary<int, List<int[]>> dictionary)
            {
                return [];
            }

            List<int[]> intArrays_Result = [];
            auxiliaryIndexes = [];

            foreach (KeyValuePair<int, List<int[]>> keyValuePair in dictionary)
            {
                List<int[]> indexes_Temp = keyValuePair.Value;

                if (keyValuePair.Key > 1)
                {
                    auxiliaryIndexes.AddRange(indexes_Temp);
                }
                else
                {
                    intArrays_Result.AddRange(indexes_Temp);
                }
            }

            return intArrays_Result;
        }

        /// <summary>
        /// Identifies and returns the boundary indexes from the provided collection of integer arrays.
        /// </summary>
        /// <param name="indexes">The <see cref="IEnumerable{T}"/> of <c>int[]</c> representing the indexes to evaluate.</param>
        /// <returns>A <see cref="List{T}"/> of <c>int[]</c> containing the boundary indexes, or <see langword="null"/> if the input collection is <see langword="null"/>.</returns>
        public static List<int[]>? BoundaryIndexes(this IEnumerable<int[]>? indexes)
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

            if (AdjacencyIndexes(indexes_Cached) is not Dictionary<int, List<int[]>> dictionary)
            {
                return [];
            }

            if (dictionary.TryGetValue(1, out List<int[]> intArrays_Result))
            {
                return intArrays_Result;
            }

            return [];
        }
    }
}
using System.Collections.Generic;
using System.Linq;

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

            if (!indexes.Any())
            {
                return [];
            }

            if (AdjacencyIndexes(indexes) is not Dictionary<int, List<int[]>> dictionary)
            {
                return [];
            }

            List<int[]> result = [];

            foreach (int adjacency in dictionary.Keys)
            {
                if (adjacency > 1)
                {
                    result.AddRange(dictionary[adjacency]);
                }
            }

            return result;
        }
    }
}
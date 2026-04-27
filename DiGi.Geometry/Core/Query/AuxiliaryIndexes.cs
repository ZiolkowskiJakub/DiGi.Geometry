using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Core
{
    public static partial class Query
    {
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
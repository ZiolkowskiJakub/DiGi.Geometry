using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Core
{
    public static partial class Query
    {
        public static List<int[]>? BoundaryIndexes(this IEnumerable<int[]>? indexes, out List<int[]>? auxiliaryIndexes)
        {
            auxiliaryIndexes = null;

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
                    result.AddRange(indexes_Temp);
                }
            }

            return result;
        }

        public static List<int[]>? BoundaryIndexes(this IEnumerable<int[]>? indexes)
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

            if (dictionary.TryGetValue(1, out List<int[]> result))
            {
                return result;
            }

            return [];
        }
    }
}
using System.Collections.Generic;

namespace DiGi.Geometry.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether the provided collection of indices represents a non-manifold mesh.
        /// </summary>
        /// <param name="indexes">The <see cref="IEnumerable{T}"/> of <c>int[]</c> containing the vertex indices for each face.</param>
        /// <returns>A <see cref="bool"/> value indicating <c>true</c> if the mesh is non-manifold; otherwise, <c>false</c>.</returns>
        public static bool IsNonManifold(this IEnumerable<int[]>? indexes)
        {
            if (indexes == null)
            {
                return false;
            }

            int[][] indexes_Cached = indexes as int[][] ?? [.. indexes];
            if (indexes_Cached.Length == 0)
            {
                return false;
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
                    int int_NewCount = int_Count1 + 1;
                    if (int_NewCount > 2)
                    {
                        return true;
                    }
                    edgeCounts[tuple_Edge1] = int_NewCount;
                }
                else
                {
                    edgeCounts[tuple_Edge1] = 1;
                }

                // Edge 2
                (int, int) tuple_Edge2 = createSortedEdge(intArray_Triangle[1], intArray_Triangle[2]);
                if (edgeCounts.TryGetValue(tuple_Edge2, out int int_Count2))
                {
                    int int_NewCount = int_Count2 + 1;
                    if (int_NewCount > 2)
                    {
                        return true;
                    }
                    edgeCounts[tuple_Edge2] = int_NewCount;
                }
                else
                {
                    edgeCounts[tuple_Edge2] = 1;
                }

                // Edge 3
                (int, int) tuple_Edge3 = createSortedEdge(intArray_Triangle[2], intArray_Triangle[0]);
                if (edgeCounts.TryGetValue(tuple_Edge3, out int int_Count3))
                {
                    int int_NewCount = int_Count3 + 1;
                    if (int_NewCount > 2)
                    {
                        return true;
                    }
                    edgeCounts[tuple_Edge3] = int_NewCount;
                }
                else
                {
                    edgeCounts[tuple_Edge3] = 1;
                }
            }

            return false;
        }
    }
}
using System.Collections.Generic;
using System.Linq;

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

            int[][] indexes_Cached = indexes as int[][] ?? indexes.ToArray();
            if (indexes_Cached.Length == 0)
            {
                return false;
            }

            // Dictionary to store edge as a sorted tuple and its occurrence count
            // Using (int, int) where Item1 < Item2 to ensure edge direction doesn't matter
            Dictionary<(int, int), int> edgeCount = [];

            static (int, int) createSortedEdge(int v1, int v2)
            {
                return v1 < v2 ? (v1, v2) : (v2, v1);
            }

            foreach (int[] triangle in indexes_Cached)
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
                        if (edgeCount[edge] > 2)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        edgeCount[edge] = 1;
                    }
                }
            }

            return false;
        }
    }
}
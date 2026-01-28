using DiGi.Geometry.Core.Classes;
using DiGi.Geometry.Core.Interfaces;
using System;
using System.Collections.Generic;

namespace DiGi.Geometry.Core
{
    public static partial class Create
    {
        public static DensityBasedSpatialClusteringResult<T>? DensityBasedSpatialClusteringResult<T>(this IEnumerable<T>? points, double tolerance, int pointCount) where T : IPoint<T>
        {
            if (points == null)
            {
                return null;
            }

            Dictionary<T, bool> visited = [];
            Dictionary<T, int> dictionary = [];

            Action<T, List<T>?, int> expandCluster = new((point, neighbors, clusterId) =>
            {
                dictionary[point] = clusterId;
                Queue<T> queue = new(neighbors);
                while (queue.Count > 0)
                {
                    T current = queue.Dequeue();
                    if (!visited.ContainsKey(current))
                    {
                        visited[current] = true;
                        List<T>? currentNeighbors = Query.PointsByDistance(points, current, tolerance);
                        if (currentNeighbors != null && currentNeighbors.Count >= pointCount)
                        {
                            foreach (var neighbor in currentNeighbors)
                            {
                                if (!queue.Contains(neighbor))
                                {
                                    queue.Enqueue(neighbor);
                                }
                            }
                        }
                    }

                    if (!dictionary.ContainsKey(current))
                    {
                        dictionary[current] = clusterId;
                    }
                }
            });

            int clusterId = 0;
            foreach (T point in points)
            {
                if (visited.ContainsKey(point))
                {
                    continue;
                }

                visited[point] = true;
                List<T>? neighbors = Query.PointsByDistance(points, point, tolerance);
                if (neighbors != null && neighbors.Count < pointCount)
                {
                    dictionary[point] = -1; // Mark as noise
                }
                else
                {
                    clusterId++;
                    expandCluster(point, neighbors, clusterId);
                }
            }

            return new DensityBasedSpatialClusteringResult<T>(tolerance, pointCount, dictionary);
        }
    }
}
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using QuikGraph;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        /// <summary>
        /// Creates an adjacency graph from a collection of segmentable geometries.
        /// </summary>
        /// <param name="segmentable2Ds">The collection of segmentable geometries.</param>
        /// <param name="tolerance">The distance tolerance used for rounding points.</param>
        /// <returns>An adjacency graph representing the connectivity; otherwise, null if input is null.</returns>
        public static AdjacencyGraph<Point2D, Edge<Point2D>>? AdjacencyGraph(this IEnumerable<ISegmentable2D>? segmentable2Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segmentable2Ds == null)
                return null;

            AdjacencyGraph<Point2D, Edge<Point2D>> result = new();

            HashSet<Point2D> point2Ds = [];
            foreach (ISegmentable2D segmentable2D in segmentable2Ds)
            {
                List<Segment2D>? segment2Ds = segmentable2D?.GetSegments();
                if (segment2Ds == null)
                {
                    continue;
                }

                foreach (Segment2D segment2D in segment2Ds)
                {
                    Point2D? point2D_1 = segment2D[0];
                    if (point2D_1 is null)
                    {
                        continue;
                    }

                    Point2D? point2D_2 = segment2D[1];
                    if (point2D_2 is null)
                    {
                        continue;
                    }

                    point2D_1.Round(tolerance);
                    if (!point2Ds.Contains(point2D_1))
                    {
                        point2Ds.Add(point2D_1);
                        result.AddVertex(point2D_1);
                    }

                    point2D_2.Round(tolerance);
                    if (!point2Ds.Contains(point2D_2))
                    {
                        point2Ds.Add(point2D_2);
                        result.AddVertex(point2D_2);
                    }

                    result.AddEdge(new Edge<Point2D>(point2D_1, point2D_2));
                    result.AddEdge(new Edge<Point2D>(point2D_2, point2D_1));
                }
            }

            return result;
        }
    }
}
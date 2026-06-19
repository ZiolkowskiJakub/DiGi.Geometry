using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using QuikGraph;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        /// <summary>
        /// Creates an undirected graph from a collection of segmentable 2D objects using a specified distance tolerance.
        /// </summary>
        /// <param name="segmentable2Ds">The <see cref="IEnumerable{ISegmentable2D}"/> collection of objects to be converted into a graph.</param>
        /// <param name="tolerance">The <see cref="double"/> distance tolerance used for point comparison.</param>
        /// <returns>An <c>UndirectedGraph&lt;Point2D, Edge&lt;Point2D&gt;&gt;</c> representing the network of points and edges, or <c>null</c> if the <paramref name="segmentable2Ds"/> collection is <c>null</c>.</returns>
        public static UndirectedGraph<Point2D, Edge<Point2D>>? UndirectedGraph(this IEnumerable<ISegmentable2D>? segmentable2Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segmentable2Ds == null)
            {
                return null;
            }

            List<Edge<Point2D>> edges = [];
            foreach (ISegmentable2D segmentable2D in segmentable2Ds)
            {
                List<Segment2D>? segment2Ds = segmentable2D?.GetSegments();
                if (segment2Ds != null)
                {
                    foreach (Segment2D segment2D in segment2Ds)
                    {
                        if (segment2D != null)
                        {
                            Point2D? point2D_1 = segment2D[0];
                            if (point2D_1 == null)
                            {
                                continue;
                            }

                            Point2D? point2D_2 = segment2D[1];
                            if (point2D_2 == null)
                            {
                                continue;
                            }

                            point2D_1.Round(tolerance);
                            point2D_2.Round(tolerance);

                            edges.Add(new Edge<Point2D>(point2D_1, point2D_2));
                        }
                    }
                }
            }

            return edges.ToUndirectedGraph<Point2D, Edge<Point2D>>();
        }
    }
}
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using QuikGraph;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        public static UndirectedGraph<Point2D, Edge<Point2D>> UndirectedGraph(this IEnumerable<ISegmentable2D> segmentable2Ds, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (segmentable2Ds == null)
                return null;

            List<Edge<Point2D>> edges = new List<Edge<Point2D>>();
            foreach (ISegmentable2D segmentable2D in segmentable2Ds)
            {
                List<Segment2D> segment2Ds = segmentable2D?.GetSegments();
                if (segment2Ds != null)
                {
                    foreach (Segment2D segment2D in segment2Ds)
                    {
                        if (segment2D != null)
                        {
                            Point2D point2D_1 = segment2D[0];
                            point2D_1.Round(tolerance);

                            Point2D point2D_2 = segment2D[1];
                            point2D_2.Round(tolerance);

                            edges.Add(new Edge<Point2D>(point2D_1, point2D_2));
                        }
                    }
                }
            }

            return edges.ToUndirectedGraph<Point2D, Edge<Point2D>>(); ;
        }
    }

}

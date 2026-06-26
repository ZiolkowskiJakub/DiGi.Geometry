using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using QuikGraph;
using QuikGraph.Algorithms.Observers;
using QuikGraph.Algorithms.ShortestPath;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a list of polylines from a collection of segmentable geometries.
        /// </summary>
        /// <typeparam name="T">A type that implements ISegmentable2D.</typeparam>
        /// <param name="segmentable2Ds">The collection of segmentable geometries to convert into polylines.</param>
        /// <param name="point2D_Start">Optional starting point for the first polyline.</param>
        /// <param name="split">Whether to split segmentable geometries into basic segments before processing.</param>
        /// <param name="tolerance">The distance tolerance for connecting segments.</param>
        /// <returns>A list of Polyline2D objects; otherwise, null if the input is empty or invalid.</returns>
        public static List<Polyline2D>? Polyline2Ds<T>(this IEnumerable<T>? segmentable2Ds, Point2D? point2D_Start = null, bool split = true, double tolerance = DiGi.Core.Constants.Tolerance.Distance) where T : ISegmentable2D
        {
            if (segmentable2Ds == null)
            {
                return null;
            }

            IReadOnlyList<T> segmentable2Ds_List = segmentable2Ds as IReadOnlyList<T> ?? [.. segmentable2Ds];
            if (segmentable2Ds_List.Count == 0)
            {
                return null;
            }

            List<Segment2D>? segment2Ds = null;
            if (split)
            {
                segment2Ds = segmentable2Ds_List.Split(tolerance);
            }
            else
            {
                segment2Ds = [];
                foreach (ISegmentable2D segmentable2D in segmentable2Ds_List)
                {
                    List<Segment2D>? segment2Ds_Temp = segmentable2D.GetSegments();
                    if (segment2Ds_Temp == null)
                    {
                        continue;
                    }

                    segment2Ds.AddRange(segment2Ds_Temp);
                }
            }

            if (segment2Ds is null)
            {
                return null;
            }

            AdjacencyGraph<Point2D, Edge<Point2D>>? adjacencyGraph = segment2Ds.AdjacencyGraph(tolerance);
            if (adjacencyGraph == null || adjacencyGraph.Vertices == null)
            {
                return null;
            }

            Point2D[] vertices_All = adjacencyGraph.Vertices as Point2D[] ?? [.. adjacencyGraph.Vertices];
            if (vertices_All.Length == 0)
            {
                return null;
            }

            if (point2D_Start == null)
            {
                List<Point2D> point2Ds_Temp = [];
                foreach (Point2D point2D in vertices_All)
                {
                    if (!adjacencyGraph.TryGetOutEdges(point2D, out IEnumerable<Edge<Point2D>> edges_Temp) || edges_Temp == null)
                    {
                        continue;
                    }

                    using IEnumerator<Edge<Point2D>> enumerator = edges_Temp.GetEnumerator();
                    if (!enumerator.MoveNext() || enumerator.MoveNext())
                    {
                        continue;
                    }

                    point2Ds_Temp.Add(point2D);
                }

                if (point2Ds_Temp != null && point2Ds_Temp.Count != 0)
                {
                    double maxDistance_Vertex = Query.MaxDistance(point2Ds_Temp, out Point2D? point2D_1, out Point2D? point2D_2);
                    point2D_Start = point2D_1;
                }
            }
            else
            {
                double distance = double.MaxValue;
                Point2D? point2D = null;
                foreach (Point2D point_Temp in vertices_All)
                {
                    double distance_Temp = point_Temp.Distance(point2D_Start);
                    if (distance_Temp < distance)
                    {
                        distance = distance_Temp;
                        point2D = point_Temp;
                    }
                }

                if (point2D != null)
                    point2D_Start = point2D;
            }

            if (point2D_Start == null)
            {
                double maxDistance_Vertex = Query.MaxDistance(vertices_All, out Point2D? point2D_1, out Point2D? point2D_2);
                point2D_Start = point2D_1;
            }

            if (point2D_Start == null)
            {
                point2D_Start = vertices_All[0];
            }

            if (point2D_Start == null)
            {
                return null;
            }

            AStarShortestPathAlgorithm<Point2D, Edge<Point2D>> aStarShortestPathAlgorithm = new(adjacencyGraph, edge => edge.Source.Distance(edge.Target), point2D => point2D.Distance(point2D_Start));

            VertexPredecessorRecorderObserver<Point2D, Edge<Point2D>> vertexPredecessorRecorderObserver = new();
            vertexPredecessorRecorderObserver.Attach(aStarShortestPathAlgorithm);

            VertexDistanceRecorderObserver<Point2D, Edge<Point2D>> vertexDistanceRecorderObserver = new(edge => edge.Source.Distance(edge.Target));
            vertexDistanceRecorderObserver.Attach(aStarShortestPathAlgorithm);

            aStarShortestPathAlgorithm.Compute(point2D_Start);

            Point2D? point2D_End = null;
            double maxDistance = double.MinValue;
            foreach (KeyValuePair<Point2D, double> keyValuePair in vertexDistanceRecorderObserver.Distances)
            {
                if (keyValuePair.Value > maxDistance)
                {
                    point2D_End = keyValuePair.Key;
                    maxDistance = keyValuePair.Value;
                }
            }

            if (point2D_End == null)
            {
                return null;
            }

            vertexPredecessorRecorderObserver.TryGetPath(point2D_End, out IEnumerable<Edge<Point2D>> edges);

            if (edges == null)
            {
                return null;
            }

            List<Point2D> point2Ds = [];
            foreach (Edge<Point2D> edge in edges)
            {
                point2Ds.Add(edge.Source);
                int index = segment2Ds.FindIndex(x => (Query.AlmostEquals(x[0], edge.Source, tolerance) && Query.AlmostEquals(x[1], edge.Target, tolerance)) || (Query.AlmostEquals(x[1], edge.Source, tolerance) && Query.AlmostEquals(x[0], edge.Target, tolerance)));
                if (index != -1)
                {
                    segment2Ds.RemoveAt(index);
                }
            }

            point2Ds.Add(edges.Last().Target);

            List<Polyline2D> polyline2Ds_Result = [];
            polyline2Ds_Result.Add(new Polyline2D(point2Ds));

            if (segment2Ds.Count > 0)
            {
                List<Polyline2D>? polyline2Ds = Polyline2Ds(segment2Ds, null, false, tolerance);
                if (polyline2Ds != null && polyline2Ds.Count != 0)
                {
                    polyline2Ds_Result.AddRange(polyline2Ds);
                }
            }

            return polyline2Ds_Result;
        }
    }
}
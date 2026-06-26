using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using QuikGraph;
using QuikGraph.Algorithms.Observers;
using QuikGraph.Algorithms.ShortestPath;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Returns longest path in given segmentable2Ds with exclusion of loops. If loops exists method will find shortest path through the loop
        /// </summary>
        /// <param name="segmentable2Ds">Segmentable2Ds</param>
        /// <param name="point2D_Start">Point to start from. If null then Method will find points with the longest paths</param>
        /// <param name="tolerance">Tolerance</param>
        /// <returns>List of Point2Ds representing the longest path</returns>
        public static List<Point2D>? LongestPath(this IEnumerable<ISegmentable2D>? segmentable2Ds, Point2D? point2D_Start = null, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segmentable2Ds == null)
            {
                return null;
            }

            HashSet<Point2D> point2Ds_Unique = [];
            List<Segment2D>? segment2Ds = [];
            foreach (ISegmentable2D segmentable2D in segmentable2Ds)
            {
                List<Segment2D>? segment2Ds_Temp = segmentable2D?.GetSegments();
                if (segment2Ds_Temp == null || segment2Ds_Temp.Count == 0)
                {
                    continue;
                }

                for (int i = 0; i < segment2Ds_Temp.Count; i++)
                {
                    //segment2Ds_Temp[i].Round(tolerance);
                    segment2Ds.Add(segment2Ds_Temp[i]);
                }

                segmentable2D?.GetPoints()?.ForEach(x => point2Ds_Unique.Add(x));
            }

            segment2Ds = segment2Ds?.Split(tolerance);
            if (segment2Ds == null)
            {
                return null;
            }

            AdjacencyGraph<Point2D, Edge<Point2D>>? adjacencyGraph = null;

            IEnumerable<Edge<Point2D>> edges;

            List<Point2D> point2Ds = [];
            if (point2D_Start != null)
            {
                Point2D point2D_Start_Temp = point2D_Start;
                if (point2D_Start_Temp != null)
                {
                    List<Segment2D>? segment2Ds_Connected = segment2Ds.Connect(point2D_Start_Temp, PointConnectMethod.Projection, tolerance);
                    if (segment2Ds_Connected != null)
                    {
                        Point2D? point2D = (segment2Ds_Connected.Find(x => AlmostEquals(x[0], point2D_Start_Temp, tolerance))?[0]) ?? (segment2Ds_Connected.Find(x => AlmostEquals(x[1], point2D_Start_Temp, tolerance))?[1]);
                        if (point2D == null)
                        {
                            return null;
                        }

                        point2D_Start_Temp = point2D;
                    }
                }

                if (point2D_Start_Temp is null)
                {
                    return null;
                }

                point2Ds.Add(point2D_Start_Temp);

                adjacencyGraph = Create.AdjacencyGraph(segment2Ds, tolerance);
                if (adjacencyGraph == null)
                {
                    return null;
                }
            }
            else
            {
                adjacencyGraph = Create.AdjacencyGraph(segment2Ds, tolerance);
                if (adjacencyGraph == null)
                {
                    return null;
                }

                Point2D[] point2Ds_All = adjacencyGraph.Vertices as Point2D[] ?? [.. adjacencyGraph.Vertices];
                if (point2Ds_All == null || point2Ds_All.Length == 0)
                {
                    return null;
                }

                foreach (Point2D point2D in point2Ds_All)
                {
                    if (!adjacencyGraph.TryGetOutEdges(point2D, out edges) || edges == null)
                    {
                        continue;
                    }

                    using IEnumerator<Edge<Point2D>> enumerator = edges.GetEnumerator();
                    if (!enumerator.MoveNext() || enumerator.MoveNext())
                    {
                        continue;
                    }

                    point2Ds.Add(point2D);
                }

                if (point2Ds.Count == 0)
                {
                    point2Ds.Add(point2Ds_All[0]);
                }
            }

            List<System.Tuple<double, Point2D, Point2D>?> tuples = [.. Enumerable.Repeat<System.Tuple<double, Point2D, Point2D>?>(null, point2Ds.Count)];
            Parallel.For(0, point2Ds.Count, i =>
            {
                Point2D point2D = point2Ds[i];

                AStarShortestPathAlgorithm<Point2D, Edge<Point2D>> starShortestPathAlgorithm_Temp = new(adjacencyGraph, edge => edge.Source.Distance(edge.Target), point2D_Temp => point2D.Distance(point2D_Temp));

                VertexDistanceRecorderObserver<Point2D, Edge<Point2D>> vertexDistanceRecorderObserver = new(edge => edge.Source.Distance(edge.Target));
                vertexDistanceRecorderObserver.Attach(starShortestPathAlgorithm_Temp);

                starShortestPathAlgorithm_Temp.Compute(point2D);

                double distance = double.MinValue;

                foreach (KeyValuePair<Point2D, double> keyValuePair in vertexDistanceRecorderObserver.Distances)
                {
                    if (keyValuePair.Value > distance)
                    {
                        tuples[i] = new System.Tuple<double, Point2D, Point2D>(keyValuePair.Value, point2D, keyValuePair.Key);
                        distance = keyValuePair.Value;
                    }
                }
            });

            tuples.RemoveAll(x => x == null || x.Item2 == null || x.Item3 == null);

            if (tuples.Count > 1)
            {
                tuples.Sort((x, y) => y!.Item1.CompareTo(x!.Item1));
            }

            if (point2D_Start == null)
            {
                point2D_Start = tuples[0]?.Item2;
            }

            Point2D? point2D_End = tuples[0]?.Item3;

            if (point2D_Start == null || point2D_End == null)
            {
                return null;
            }

            AStarShortestPathAlgorithm<Point2D, Edge<Point2D>> aStarShortestPathAlgorithm = new(adjacencyGraph, edge => edge.Source.Distance(edge.Target), point2D_Temp => point2D_Start.Distance(point2D_Temp));

            VertexPredecessorRecorderObserver<Point2D, Edge<Point2D>> vertexPredecessorRecorderObserver = new();
            vertexPredecessorRecorderObserver.Attach(aStarShortestPathAlgorithm);

            aStarShortestPathAlgorithm.Compute(point2D_Start);

            if (!vertexPredecessorRecorderObserver.TryGetPath(point2D_End, out edges) || edges == null)
            {
                return null;
            }

            List<Point2D> point2Ds_Result = [];
            if (!edges.Any())
            {
                return point2Ds_Result;
            }

            foreach (Edge<Point2D> edge_Temp in edges)
            {
                Point2D point2D = edge_Temp.Source;

                foreach (Point2D point2D_Unique in point2Ds_Unique)
                {
                    if (AlmostEquals(point2D_Unique, point2D))
                    {
                        point2D = point2D_Unique;
                        break;
                    }
                }

                point2Ds_Result.Add(point2D);
            }

            foreach (Point2D point2D_Unique in point2Ds_Unique)
            {
                if (AlmostEquals(point2D_Unique, point2D_End))
                {
                    point2D_End = point2D_Unique;
                    break;
                }
            }

            point2Ds_Result.Add(point2D_End);

            return point2Ds_Result;
        }
    }
}
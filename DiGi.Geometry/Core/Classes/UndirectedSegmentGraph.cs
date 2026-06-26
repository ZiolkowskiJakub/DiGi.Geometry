using DiGi.Core.Classes;
using DiGi.Geometry.Core.Interfaces;
using QuikGraph;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Core.Classes
{
    /// <summary>
    /// Represents an abstract base class for an undirected graph composed of segments.
    /// </summary>
    /// <typeparam name="T">The type of point in the graph, which must implement <see cref="IPoint{T}"/>.</typeparam>
    /// <typeparam name="X">The type of segment in the graph, which must implement <see cref="ISegment{T}"/>.</typeparam>
    public abstract class UndirectedSegmentGraph<T, X> : SerializableObject where T : IPoint<T> where X : ISegment<T>
    {
        [JsonIgnore]
        private UndirectedGraph<T, Edge<T>>? undirectedGraph = new();

        /// <summary>
        /// Gets or sets the list of <typeparamref name="X"/> segments.
        /// </summary>
        [JsonInclude, JsonPropertyName("Segments")]
        public abstract List<X>? Segments { get; set; }

        /// <summary>
        /// Adds a segment to the collection.
        /// </summary>
        /// <param name="segment">The <typeparamref name="X"/> segment to be added.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the segment was successfully added; returns false if the <typeparamref name="X"/> segment is null or if its start or end points are null.</returns>
        public bool Add(X? segment)
        {
            if (segment == null)
            {
                return false;
            }

            int index;

            T? point_Start = segment.Start;
            if (point_Start is null)
            {
                return false;
            }

            T? point_End = segment.End;
            if (point_End is null)
            {
                return false;
            }

            if (undirectedGraph != null && undirectedGraph.TryGetEdge(point_Start, point_End, out _))
            {
                return false;
            }

            undirectedGraph ??= new UndirectedGraph<T, Edge<T>>();

            index = GetIndex(point_Start);
            if (index == -1)
            {
                undirectedGraph.AddVertex(point_Start);
            }

            index = GetIndex(point_End);
            if (index == -1)
            {
                undirectedGraph.AddVertex(point_End);
            }

            return undirectedGraph.AddEdge(new Edge<T>(point_Start, point_End));
        }

        /// <summary>
        /// Retrieves the index of the specified point within the vertices of the undirected graph.
        /// </summary>
        /// <param name="point">The <typeparamref name="T"/> point to locate.</param>
        /// <returns>An <see cref="int"/> representing the zero-based index of the point if it is found; otherwise, -1.</returns>
        public int GetIndex(T? point)
        {
            if (point == null || undirectedGraph?.Vertices == null)
            {
                return -1;
            }

            int index = 0;
            foreach (T vertex in undirectedGraph.Vertices)
            {
                if (point.Equals(vertex))
                {
                    return index;
                }
                index++;
            }

            return -1;
        }
    }
}
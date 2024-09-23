using DiGi.Core.Classes;
using DiGi.Geometry.Core.Interfaces;
using QuikGraph;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Core.Classes
{
    public abstract class UndirectedSegmentGraph<T, X> : SerializableObject where T: IPoint<T> where X: ISegment<T>
    {
        [JsonIgnore]
        private UndirectedGraph<T, Edge<T>> undirectedGraph;

        public bool Add(X segment)
        {
            if(segment == null)
            {
                return false;
            }

            int index;

            T point_Start = segment.Start;
            T point_End = segment.End;

            if (undirectedGraph.TryGetEdge(point_Start, point_End, out Edge<T> edge))
            {
                return false;
            }

            index = GetIndex(point_Start);
            if(index == -1)
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

        public int GetIndex(T point)
        {
            if(point == null || undirectedGraph?.Vertices == null)
            {
                return -1;
            }

            int count = undirectedGraph.Vertices.Count();

            for (int i = 0; i < count; i++)
            {
                if(point.Equals(undirectedGraph.Vertices.ElementAt(i)))
                {
                    return i;
                }
            }

            return -1;
        }

        [JsonInclude, JsonPropertyName("Segments")]
        public abstract List<X> Segments { get; set; }
    }
}

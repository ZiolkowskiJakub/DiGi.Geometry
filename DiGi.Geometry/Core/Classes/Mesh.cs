using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Geometry.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Core.Classes
{
    public abstract class Mesh<T> : SerializableObject, IMesh where T : IPoint<T>
    {
        [JsonInclude, JsonPropertyName("Indexes")]
        protected List<int[]>? indexes;

        [JsonInclude, JsonPropertyName("Points")]
        protected List<T>? points;

        public Mesh(JsonObject? jsonObject)
        {
            FromJsonObject(jsonObject);
        }

        public Mesh(Mesh<T>? mesh)
        {
            if (mesh != null)
            {
                List<T?>? points_Temp = mesh?.points?.Clone();
                if (points_Temp != null)
                {
                    points = [];
                    foreach (T? point in points_Temp)
                    {
                        if (point == null)
                        {
                            continue;
                        }

                        T? point_Temp = point.Clone<T>();
                        if (point_Temp == null)
                        {
                            continue;
                        }

                        points.Add(point_Temp);
                    }
                }

                if (mesh?.indexes != null)
                {
                    indexes = [];
                    foreach (int[] vertices in mesh.indexes)
                    {
                        indexes.Add([vertices[0], vertices[1], vertices[2]]);
                    }
                }
            }
        }

        public Mesh(IEnumerable<T>? points, IEnumerable<int[]>? indexes)
        {
            if (points == null || indexes == null)
            {
                return;
            }

            List<T?>? points_Temp = points?.Clone();
            if (points_Temp != null)
            {
                this.points = [];
                foreach (T? point in points_Temp)
                {
                    if (point == null)
                    {
                        continue;
                    }

                    T? point_Temp = point.Clone<T>();
                    if (point_Temp == null)
                    {
                        continue;
                    }

                    this.points.Add(point_Temp);
                }
            }

            int count = this.points.Count();

            this.indexes = [];
            foreach (int[] vertices in indexes)
            {
                if (vertices == null || vertices.Length < 3)
                {
                    continue;
                }

                if (vertices[0] >= count || vertices[1] >= count || vertices[2] >= count)
                {
                    continue;
                }

                this.indexes.Add([vertices[0], vertices[1], vertices[2]]);
            }
        }

        [JsonIgnore]
        public int PointsCount
        {
            get
            {
                if (points == null)
                {
                    return -1;
                }

                return points.Count;
            }
        }

        [JsonIgnore]
        public int TrianglesCount
        {
            get
            {
                if (indexes == null)
                {
                    return -1;
                }

                return indexes.Count;
            }
        }

        public HashSet<int>? GetConnectedIndexes(int index)
        {
            if (indexes == null || index < 0)
            {
                return null;
            }

            HashSet<int> result = [];
            foreach (int[] indexes_Temp in indexes)
            {
                if (indexes_Temp.Contains(index))
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (indexes_Temp[0] != index)
                        {
                            result.Add(indexes_Temp[0]);
                        }
                    }
                }
            }

            return result;
        }

        public HashSet<T>? GetConnectedPoints(int index)
        {
            if (points == null)
            {
                return null;
            }

            HashSet<int>? indexes_Temp = GetConnectedIndexes(index);
            if (indexes_Temp == null)
            {
                return null;
            }

            HashSet<T> result = [];
            foreach (int index_Temp in indexes_Temp)
            {
                T? t = points[index_Temp].Clone<T>();
                if (t != null)
                {
                    result.Add(t);
                }
            }

            return result;
        }

        public List<int[]>? GetIndexes()
        {
            if (indexes == null)
            {
                return null;
            }

            List<int[]> result = [];
            for (int i = 0; i < indexes.Count; i++)
            {
                result.Add([indexes[i][0], indexes[i][1], indexes[i][2]]);
            }

            return result;
        }

        public int[]? GetIndexes(int index)
        {
            if (indexes == null)
            {
                return null;
            }

            int[] indexes_Triangle = indexes[index];

            return [indexes_Triangle[0], indexes_Triangle[1], indexes_Triangle[2]];
        }

        public List<T>? GetPoints()
        {
            if (points == null)
            {
                return null;
            }

            List<T> result = [];
            foreach (T point in points)
            {
                if (point == null)
                {
                    continue;
                }

                T? point_Temp = point.Clone<T>();
                if (point_Temp == null)
                {
                    continue;
                }

                result.Add(point_Temp);
            }

            return result;
        }

        public int IndexOf(T? point)
        {
            if (point == null || points == null)
            {
                return -1;
            }

            for (int i = 0; i < points.Count; i++)
            {
                if (point.Equals(points[i]))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
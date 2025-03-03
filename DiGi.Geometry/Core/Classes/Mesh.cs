using DiGi.Core.Classes;
using System.Text.Json.Serialization;
using DiGi.Core;
using DiGi.Geometry.Core.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Linq;

namespace DiGi.Geometry.Core.Classes
{
    public abstract class Mesh<T> : SerializableObject, IMesh where T: IPoint<T>
    {
        [JsonInclude, JsonPropertyName("Indexes")]
        protected List<int[]> indexes;

        [JsonInclude, JsonPropertyName("Points")]
        protected List<T> points;

        public Mesh(JsonObject jsonObject)
        {
            FromJsonObject(jsonObject);
        }

        public Mesh(Mesh<T> mesh)
        {
            if(mesh != null)
            {
                points = mesh.points?.Clone();
                if(mesh.indexes != null)
                {
                    indexes = new List<int[]>();
                    foreach (int[] vertices in mesh.indexes)
                    {
                        indexes.Add(new int[] { vertices[0], vertices[1], vertices[2] });
                    }
                }
            }
        }

        public Mesh(IEnumerable<T> points, IEnumerable<int[]> indexes)
        {
            if(points == null || indexes == null)
            {
                return;
            }

            this.points = points.Clone();

            int count = this.points.Count();

            this.indexes = new List<int[]>();
            foreach (int[] vertices in indexes)
            {
                if(vertices == null || vertices.Length < 3)
                {
                    continue;
                }

                if (vertices[0] >= count || vertices[1] >= count || vertices[2] >= count)
                {
                    continue;
                }

                this.indexes.Add(new int[] { vertices[0], vertices[1], vertices[2] });
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

        public List<T> GetPoints()
        {
            return points?.ConvertAll(x => x.Clone<T>());
        }

        public int IndexOf(T point)
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

        public List<int[]> GetIndexes()
        {
            if (indexes == null)
            {
                return null;
            }

            List<int[]> result = new List<int[]>();
            for (int i = 0; i < indexes.Count; i++)
            {
                result.Add(new int[] { indexes[i][0], indexes[i][1], indexes[i][2] });
            }

            return result;
        }

        public int[] GetIndexes(int index)
        {
            int[] indexes_Triangle = indexes[index];

            return new int[] { indexes_Triangle[0], indexes_Triangle[1], indexes_Triangle[2] };
        }

        public HashSet<int> GetConnectedIndexes(int index)
        {
            if(indexes == null || index < 0)
            {
                return null;
            }

            HashSet<int> result = new HashSet<int>();
            foreach (int[] indexes_Temp in indexes)
            {
                if(indexes_Temp.Contains(index))
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if(indexes_Temp[0] != index)
                        {
                            result.Add(indexes_Temp[0]);
                        }
                    }
                }
            }

            return result;
        }

        public HashSet<T> GetConnectedPoints(int index)
        {
            HashSet<int> indexes_Temp = GetConnectedIndexes(index);
            if(indexes_Temp == null)
            {
                return null;
            }

            HashSet<T> result = new HashSet<T>();
            foreach(int index_Temp in indexes_Temp)
            {
                T t = points[index_Temp];
                if(t != null)
                {
                    result.Add(t.Clone<T>());
                }
            }

            return result;
        }
    }
}

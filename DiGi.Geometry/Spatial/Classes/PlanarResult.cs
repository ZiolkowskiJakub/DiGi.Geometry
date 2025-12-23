using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    public abstract class PlanarResult : SerializableObject, ISerializableResult
    {
        [JsonInclude, JsonPropertyName("Geometry2Ds")]
        private readonly List<IGeometry2D>? geometry2Ds;

        [JsonInclude, JsonPropertyName("Plane")]
        private readonly Plane? plane;
        public PlanarResult()
            : base()
        {

        }

        public PlanarResult(Plane? plane)
            : base()
        {
            this.plane = plane == null ? null : new(plane);
        }

        public PlanarResult(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public PlanarResult(PlanarResult? planarResult)
            : base()
        {
            if (planarResult != null)
            {
                geometry2Ds = DiGi.Core.Query.Clone(planarResult.geometry2Ds)?.FilterNulls();
                plane = planarResult.plane == null ? null : new Plane(planarResult.plane);
            }
        }

        public PlanarResult(Plane? plane, IEnumerable<IGeometry2D>? geometry2Ds)
        {
            this.plane = plane == null ? null : new Plane(plane);
            this.geometry2Ds = DiGi.Core.Query.Clone(geometry2Ds)?.FilterNulls();

        }

        public PlanarResult(Plane? plane, IGeometry2D? geometry2D)
        {
            this.plane = plane == null ? null : new(plane);
            if (geometry2D != null && DiGi.Core.Query.Clone(geometry2D) is IGeometry2D geometry2D_Temp)
            {
                geometry2Ds = [geometry2D_Temp];
            }
        }

        [JsonIgnore]
        public int Count
        {
            get
            {
                return geometry2Ds == null ? 0 : geometry2Ds.Count;
            }
        }

        [JsonIgnore]
        public Plane? Plane
        {
            get
            {
                return plane == null ? null : new Plane(plane);
            }
        }

        public bool Contains<T>() where T : IGeometry2D
        {
            return geometry2Ds != null && geometry2Ds.Find(x => x is T) != null;
        }

        public List<T>? GetGeometry2Ds<T>() where T : IGeometry2D
        {
            if (geometry2Ds == null)
            {
                return null;
            }

            List<T> result = [];
            for (int i = 0; i < geometry2Ds.Count; i++)
            {
                if (geometry2Ds[i] is T t)
                {
                    T? t_Temp = DiGi.Core.Query.Clone(t);
                    if (t_Temp == null)
                    {
                        continue;
                    }

                    result.Add(t_Temp);
                }
            }

            return result;
        }

        public List<T>? GetGeometry3Ds<T>() where T : IGeometry3D
        {
            if (geometry2Ds == null)
            {
                return null;
            }

            List<T> result = [];
            for (int i = 0; i < geometry2Ds.Count; i++)
            {
                if (Query.Convert(plane, geometry2Ds[i] as dynamic) is not IGeometry3D geometry3D)
                {
                    continue;
                }

                if (Query.Convert<T>(geometry3D) is not List<T> ts)
                {
                    continue;
                }

                result.AddRange(ts);
            }

            return result;
        }
    }
}

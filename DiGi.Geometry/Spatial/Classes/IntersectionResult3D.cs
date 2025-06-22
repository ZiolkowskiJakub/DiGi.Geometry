using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    public class IntersectionResult3D : SerializableObject, IIntersectionResult3D
    {
        [JsonInclude, JsonPropertyName("Geometry3Ds")]
        private List<IGeometry3D> geometry3Ds;

        public IntersectionResult3D()
        {
            
        }
        
        public IntersectionResult3D(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public IntersectionResult3D(IntersectionResult3D intersectionResult3D)
            : this(intersectionResult3D?.geometry3Ds)
        {

        }

        public IntersectionResult3D(IGeometry3D geometry3D)
        {
            if(geometry3D != null)
            {
                geometry3Ds = new List<IGeometry3D>() { geometry3D.Clone<IGeometry3D>() };
            }
        }

        public IntersectionResult3D(IEnumerable<IGeometry3D> geometry3Ds)
        {
            if(geometry3Ds != null)
            {
                this.geometry3Ds = new List<IGeometry3D>();
                foreach(IGeometry3D geometry3D in geometry3Ds)
                {
                    if(geometry3D == null)
                    {
                        continue;
                    }

                    this.geometry3Ds.Add(geometry3D.Clone<IGeometry3D>());
                }
            }
        }

        [JsonIgnore]
        public bool Intersect
        {
            get
            {
                return geometry3Ds != null && geometry3Ds.Count != 0;
            }
        }

        [JsonIgnore]
        public int Count
        {
            get
            {
                return geometry3Ds == null ? 0 : geometry3Ds.Count;
            }
        }

        [JsonIgnore]
        public IGeometry3D this[int index]
        {
            get
            {
                if(geometry3Ds == null || geometry3Ds.Count <= index)
                {
                    return null;
                }

                return geometry3Ds[index].Clone<IGeometry3D>();
            }
        }

        public List<T> GetGeometry3Ds<T>() where T : IGeometry3D
        {
            if(geometry3Ds == null)
            {
                return null;
            }

            List<T> result = new List<T>();
            for (int i =0; i < geometry3Ds.Count; i++)
            {
                if (geometry3Ds[i] is T)
                {
                    result.Add((T)geometry3Ds[i].Clone());
                }
            }

            return result;
        }

        public bool Contains<T>() where T: IGeometry3D
        {
            return geometry3Ds != null && geometry3Ds.Find(x => x is T) != null;
        }

        public override ISerializableObject Clone()
        {
            return new IntersectionResult3D(this);
        }

    }
}

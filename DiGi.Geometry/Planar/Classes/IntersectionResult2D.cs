using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    public class IntersectionResult2D : SerializableObject, IIntersectionResult
    {
        [JsonInclude, JsonPropertyName("Geometry2Ds")]
        private List<IGeometry2D> geometry2Ds;

        public IntersectionResult2D()
        {
            
        }
        
        public IntersectionResult2D(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public IntersectionResult2D(IntersectionResult2D intersectionResult2D)
            : this(intersectionResult2D?.geometry2Ds)
        {

        }

        internal IntersectionResult2D(IGeometry2D geometry2D)
        {
            if(geometry2D != null)
            {
                geometry2Ds = new List<IGeometry2D>() { geometry2D.Clone<IGeometry2D>() };
            }
        }

        internal IntersectionResult2D(IEnumerable<IGeometry2D> geometry2Ds)
        {
            if(geometry2Ds != null)
            {
                this.geometry2Ds = new List<IGeometry2D>();
                foreach(IGeometry2D geometry2D in geometry2Ds)
                {
                    if(geometry2D == null)
                    {
                        continue;
                    }

                    this.geometry2Ds.Add(geometry2D.Clone<IGeometry2D>());
                }
            }
        }

        [JsonIgnore]
        public bool Intersect
        {
            get
            {
                return geometry2Ds != null && geometry2Ds.Count != 0;
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
        public IGeometry2D this[int index]
        {
            get
            {
                if(geometry2Ds == null || geometry2Ds.Count <= index)
                {
                    return null;
                }

                return geometry2Ds[index].Clone<IGeometry2D>();
            }
        }

        public List<T> GetGeometry2Ds<T>() where T : IGeometry2D
        {
            if(geometry2Ds == null)
            {
                return null;
            }

            List<T> result = new List<T>();
            for (int i =0; i < geometry2Ds.Count; i++)
            {
                if (geometry2Ds[i] is T)
                {
                    result.Add((T)geometry2Ds[i].Clone());
                }
            }

            return result;
        }

        public override ISerializableObject Clone()
        {
            return new IntersectionResult2D(this);
        }

    }
}

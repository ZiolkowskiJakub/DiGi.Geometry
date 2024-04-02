using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    public class PlanarIntersectionResult : SerializableObject, IIntersectionResult3D
    {
        [JsonInclude, JsonPropertyName("Plane")]
        private Plane plane;
        
        [JsonInclude, JsonPropertyName("Geometry2Ds")]
        private List<IGeometry2D> geometry2Ds;

        public PlanarIntersectionResult()
            : base()
        {

        }

        public PlanarIntersectionResult(Plane plane)
            : base()
        {
            this.plane = plane == null ? null : new Plane(plane);
        }

        public PlanarIntersectionResult(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public PlanarIntersectionResult(PlanarIntersectionResult planarIntersectionResult)
            : base()
        {
            if(planarIntersectionResult != null)
            {
                geometry2Ds = DiGi.Core.Query.Clone(planarIntersectionResult.geometry2Ds);
                plane = planarIntersectionResult.plane == null ? null : new Plane(planarIntersectionResult.plane);
            }
        }

        public PlanarIntersectionResult(Plane plane, IEnumerable<IGeometry2D> geometry2Ds)
        {
            this.plane = plane == null ? null : new Plane(plane);
            this.geometry2Ds = DiGi.Core.Query.Clone(geometry2Ds);

        }

        public PlanarIntersectionResult(Plane plane, IGeometry2D geometry2D)
        {
            this.plane = plane == null ? null : new Plane(plane);
            if(geometry2D != null)
            {
                geometry2Ds = new List<IGeometry2D>() { DiGi.Core.Query.Clone(geometry2D) };
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
        public Plane Plane
        {
            get
            {
                return plane == null ? null : new Plane(plane);
            }
        }

        public override ISerializableObject Clone()
        {
            return new PlanarIntersectionResult(this);
        }

        public List<T> GetGeometry2Ds<T>() where T : IGeometry2D
        {
            if (geometry2Ds == null)
            {
                return null;
            }

            List<T> result = new List<T>();
            for (int i = 0; i < geometry2Ds.Count; i++)
            {
                if (geometry2Ds[i] is T)
                {
                    result.Add((T)geometry2Ds[i].Clone());
                }
            }

            return result;
        }

        public List<T> GetGeometry3Ds<T>() where T : IGeometry3D
        {
            if (geometry2Ds == null)
            {
                return null;
            }

            List<T> result = new List<T>();
            for (int i = 0; i < geometry2Ds.Count; i++)
            {
                IGeometry3D geometry3D = Query.Convert(plane, geometry2Ds[i] as dynamic);
                
                if (geometry3D is T)
                {
                    result.Add((T)geometry3D);
                }
            }

            return result;
        }
    }
}

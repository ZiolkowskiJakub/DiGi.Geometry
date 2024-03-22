using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    public abstract class Planar<T> : Geometry3D, IPlanar<T> where T : IGeometry2D
    {
        [JsonInclude, JsonPropertyName("Plane")]
        protected Plane plane;

        [JsonInclude, JsonPropertyName("Geometry2D")]
        protected T geometry2D; 

        public Planar(Plane plane)
            : base()
        {
            this.plane = plane == null ? null : new Plane(plane);
        }

        public Planar(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Planar(Planar<T> planar)
            : base(planar)
        {
            if(planar != null)
            {
                plane = DiGi.Core.Query.Clone(planar.plane);
                geometry2D = DiGi.Core.Query.Clone(geometry2D);
            }
        }

        public Planar(Plane plane, T geometry2D)
            : base()
        {
            this.plane = plane == null ? null : new Plane(plane);
            this.geometry2D = DiGi.Core.Query.Clone(geometry2D);
        }

        [JsonIgnore]
        public T Geometry2D
        {
            get
            {
                return DiGi.Core.Query.Clone(geometry2D);
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

        public override bool Move(Vector3D vector3D)
        {
            if(vector3D == null || plane == null)
            {
                return false;
            }

            return plane.Move(vector3D);
        }
    }
}

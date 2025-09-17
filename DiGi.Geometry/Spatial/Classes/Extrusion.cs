using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    public abstract class Extrusion<TSurface3D> : Geometry3D, IBoundable3D where TSurface3D : ISurface3D
    {
        [JsonInclude, JsonPropertyName("Surface")]
        private readonly TSurface3D? surface;

        [JsonInclude, JsonPropertyName("Vector")]
        private readonly Vector3D? vector;

        public Extrusion(Extrusion<TSurface3D>? extrusion)
            : base(extrusion)
        {
            if(extrusion is not null)
            {
                surface = DiGi.Core.Query.Clone(extrusion.surface);
                vector = DiGi.Core.Query.Clone(extrusion.vector);
            }
        }

        public Extrusion(JsonObject? jsonObject)
            :base(jsonObject)
        {

        }

        public Extrusion(TSurface3D? surface, Vector3D? vector)
            :base()
        {
            if (surface is not null)
            {
                this.surface = DiGi.Core.Query.Clone(surface);
                this.vector = DiGi.Core.Query.Clone(vector);
            }
        }

        [JsonIgnore]
        public TSurface3D? Surface
        {
            get
            {
                return  DiGi.Core.Query.Clone(surface);
            }
        }

        [JsonIgnore]
        public Vector3D? Vector
        {
            get
            {
                return DiGi.Core.Query.Clone(vector);
            }
        }

        public BoundingBox3D? GetBoundingBox()
        {
            BoundingBox3D? result = surface?.GetBoundingBox();
            if(result is null)
            {
                return result;
            }

            if(vector != null && result.GetPoints() is List<Point3D> point3Ds)
            {
                foreach(Point3D point3D in point3Ds)
                {
                    result.Add(point3D);
                }
            }

            return result;
        }

        public override bool Move(Vector3D? vector3D)
        {
            if(surface is null)
            {
                return false;
            }

            return surface.Move(vector);
        }
    }
}

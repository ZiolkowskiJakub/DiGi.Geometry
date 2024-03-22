using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Spatial.Classes
{
    public abstract class Geometry3D : SerializableObject, IGeometry3D
    {
        public Geometry3D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Geometry3D()
        {

        }

        public Geometry3D(Geometry3D geometry3D)
        {

        }

        public abstract bool Move(Vector3D vector3D);
    }
}

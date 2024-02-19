using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Planar.Classes
{
    public abstract class Geometry2D : SerializableObject, IGeometry2D
    {
        public Geometry2D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Geometry2D()
        {

        }
    }
}

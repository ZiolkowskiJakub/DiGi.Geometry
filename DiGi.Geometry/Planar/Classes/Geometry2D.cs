using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Planar.Classes
{
    public abstract class Geometry2D : SerializableObject, ICollectable2D
    {
        public Geometry2D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Geometry2D()
        {

        }

        public Geometry2D(Geometry2D geometry2D)
        {

        }

        public abstract bool Move(Vector2D vector2D);

        public abstract bool Transform(ITransform2D transform);
    }
}

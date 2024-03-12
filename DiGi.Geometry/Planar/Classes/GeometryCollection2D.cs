using DiGi.Geometry.Core.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Text.Json.Nodes;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar.Classes
{
    public class GeometryCollection2D : GeometryCollection<ICollectable2D>, IGeometryCollection2D
    {
        public GeometryCollection2D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public GeometryCollection2D()
        {

        }

        public GeometryCollection2D(IEnumerable<ICollectable2D> collectable2Ds)
            : base(collectable2Ds)
        {

        }

        public bool Move(Vector2D vector2D)
        {
            if(vector2D == null)
            {
                return false;
            }

            foreach(ICollectable2D collectable2D in this)
            {
                collectable2D?.Move(vector2D);
            }

            return true;
        }

        public bool Transform(ITransform2D transform)
        {
            if (transform == null)
            {
                return false;
            }

            foreach (ICollectable2D collectable2D in this)
            {
                collectable2D?.Transform(transform);
            }

            return true;
        }
    }
}

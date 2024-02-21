using DiGi.Geometry.Core.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Spatial.Classes
{
    public abstract class Coordinate3D : Coordinate, IGeometry3D
    {
        public Coordinate3D(JsonObject jsonObject)
            : base(jsonObject, 3)
        {

        }

        public Coordinate3D(double x, double y, double z)
            : base(x, y, z)
        {

        }
    }
}

using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Spatial.Classes
{
    public class BoundingBox3D : IGeometry3D, IBoundingBox
    {
        public ISerializableObject Clone()
        {
            throw new NotImplementedException();
        }

        public bool FromJsonObject(JsonObject jsonObject)
        {
            throw new NotImplementedException();
        }

        public JsonObject ToJsonObject()
        {
            throw new NotImplementedException();
        }
    }
}

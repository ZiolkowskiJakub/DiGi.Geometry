using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Core.Classes
{
    public abstract class GeometryCollection<T> : SerializableObjectCollection<T>, IGeometryCollection<T> where T : ICollectable
    {
        public GeometryCollection() 
        { 
        }

        public GeometryCollection(IEnumerable<T> collectables)
            :base(collectables)
        {

        }

        public GeometryCollection(JsonObject jsonObject)
            : base(jsonObject) 
        {

        }

        public GeometryCollection(GeometryCollection<T> geometryCollection)
            : base(geometryCollection)
        {

        }

        public override ISerializableObject Clone()
        {
            JsonObject jsonObject = ToJsonObject();
            if (jsonObject == null)
            {
                return null;
            }

            return DiGi.Core.Create.SerializableObject<ISerializableObject>(jsonObject);
        }
    }
}

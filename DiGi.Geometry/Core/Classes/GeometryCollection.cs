using DiGi.Core;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Interfaces;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Core.Classes
{
    public abstract class GeometryCollection<T> : Collection<T>, IGeometryCollection<T> where T : ICollectable
    {
        public GeometryCollection() 
        { 
        }

        public GeometryCollection(IEnumerable<T> collectables)
            :base(collectables == null ? new List<T>() : collectables.ToList())
        {

        }

        public GeometryCollection(JsonObject jsonObject)
        {
            FromJsonObject(jsonObject);
        }

        public ISerializableObject Clone()
        {
            JsonObject jsonObject = ToJsonObject();
            if (jsonObject == null)
            {
                return null;
            }

            return Create.SerializableObject<ISerializableObject>(jsonObject);
        }

        public bool FromJsonObject(JsonObject jsonObject)
        {
            if(jsonObject == null)
            {
                return false;
            }

            if(jsonObject.ContainsKey("Values"))
            {
                JsonNode jsonNode = jsonObject["Values"];

                foreach (JsonObject jsonObject_Value in jsonObject["Values"].AsArray())
                {
                    T value = Create.SerializableObject<T>(jsonObject_Value);
                    Add(value);
                }
            }

            return true;
        }

        public JsonObject ToJsonObject()
        {
            JsonObject result = new JsonObject();
            
            result[Constans.Serialization.PropertyName.Type] = Query.FullTypeName(GetType());
            
            result["Values"] = DiGi.Core.Convert.ToJson<T>(this);

            return result;
        }
    }
}

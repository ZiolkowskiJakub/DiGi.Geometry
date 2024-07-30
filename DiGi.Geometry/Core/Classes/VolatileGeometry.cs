using DiGi.Core.Classes;
using System.Text.Json.Serialization;
using DiGi.Core;
using DiGi.Geometry.Core.Interfaces;
using System.Text.Json.Nodes;
using DiGi.Core.Interfaces;

namespace DiGi.Geometry.Core.Classes
{
    public class VolatileGeometry<T> : VolatileObject<T> where T: IGeometry
    {
        [JsonIgnore]
        public T Geometry
        {
            get
            {
                return DiGi.Core.Query.Clone(@object);
            }
        }

        public VolatileGeometry(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public VolatileGeometry(VolatileGeometry<T> volatileGeometry)
            :base(volatileGeometry)
        {

        }

        public VolatileGeometry(T geometry)
            : base(geometry)
        {

        }

        public override ISerializableObject Clone()
        {
            return new VolatileGeometry<T>(this);
        }
    }
}

using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    public class VolatileBoundable3D<T> : VolatileGeometry<T> where T : IBoundable3D
    {
        private BoundingBox3D boundingBox;

        public VolatileBoundable3D(JsonObject JsonObject)
            : base(JsonObject)
        {

        }

        public VolatileBoundable3D(T boudable3D)
            :base(boudable3D)
        {

        }

        public VolatileBoundable3D(VolatileBoundable3D<T> volatileBoundable3D)
            :base(volatileBoundable3D)
        {
            if(volatileBoundable3D != null)
            {
                boundingBox = volatileBoundable3D.boundingBox == null ? null : new BoundingBox3D(volatileBoundable3D.boundingBox);
            }
        }

        [JsonIgnore]
        public BoundingBox3D BoundingBox
        {
            get
            {
                if (boundingBox == null)
                {
                    boundingBox = @object.GetBoundingBox();
                }

                return boundingBox == null ? null : new BoundingBox3D(boundingBox);
            }
        }

        public static implicit operator VolatileBoundable3D<T>(T boundable3D)
        {
            if (boundable3D == null)
            {
                return default;
            }

            return new VolatileBoundable3D<T>(boundable3D);
        }

        public override ISerializableObject Clone()
        {
            return new VolatileBoundable3D<T>(this);
        }
    }
}

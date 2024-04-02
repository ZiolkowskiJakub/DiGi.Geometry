using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    public class VolatileBoundable2D<T> : VolatileGeometry<T> where T : IBoundable2D
    {
        private BoundingBox2D boundingBox;

        public VolatileBoundable2D(JsonObject JsonObject)
            : base(JsonObject)
        {

        }

        public VolatileBoundable2D(T boudable2D)
            :base(boudable2D)
        {

        }

        public VolatileBoundable2D(VolatileBoundable2D<T> volatileBoundable2D)
            :base(volatileBoundable2D)
        {
            if(volatileBoundable2D != null)
            {
                boundingBox = volatileBoundable2D.boundingBox == null ? null : new BoundingBox2D(volatileBoundable2D.boundingBox);
            }
        }

        [JsonIgnore]
        public BoundingBox2D BoundingBox
        {
            get
            {
                if (boundingBox == null)
                {
                    boundingBox = @object.GetBoundingBox();
                }

                return boundingBox == null ? null : new BoundingBox2D(boundingBox);
            }
        }

        public static implicit operator VolatileBoundable2D<T>(T boundable2D)
        {
            if (boundable2D == null)
            {
                return default;
            }

            return new VolatileBoundable2D<T>(boundable2D);
        }

        public override ISerializableObject Clone()
        {
            return new VolatileBoundable2D<T>(this);
        }
    }
}

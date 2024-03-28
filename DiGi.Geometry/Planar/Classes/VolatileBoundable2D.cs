using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Planar.Classes
{
    public class VolatileBoundable2D<T> : VolatileObject<T> where T : IBoundable2D
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

        public override ISerializableObject Clone()
        {
            return new VolatileBoundable2D<T>(this);
        }
    }
}

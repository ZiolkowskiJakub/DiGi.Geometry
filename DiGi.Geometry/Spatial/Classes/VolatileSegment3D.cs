using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Spatial.Classes
{
    public class VolatileSegment3D : VolatileBoundable3D<Segment3D>
    {
        private double? length = null;

        public VolatileSegment3D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public VolatileSegment3D(Segment3D segment3D)
            : base(segment3D)
        {

        }

        public VolatileSegment3D(VolatileSegment3D volatileSegment3D)
            : base(volatileSegment3D as VolatileBoundable3D<Segment3D>)
        {
            if (volatileSegment3D != null)
            {
                if (volatileSegment3D.length != null)
                {
                    length = volatileSegment3D.length;
                }
            }
        }

        public double GetLength()
        {
            if(length != null && length.HasValue)
            {
                return length.Value;
            }

            length = @object.Length;
            return length.Value;
        }

        public static implicit operator VolatileSegment3D(Segment3D segment3D)
        {
            if (segment3D == null)
            {
                return default;
            }

            return new VolatileSegment3D(segment3D);
        }

        public override ISerializableObject Clone()
        {
            return new VolatileSegment3D(this);
        }
    }
}

using DiGi.Geometry.Core.Enums;

namespace DiGi.Geometry.Core
{
    public static partial class Query
    {
        public static Alignment Opposite(this Alignment alignment)
        {
            return alignment switch
            {
                Alignment.Horizontal => Alignment.Vertical,

                Alignment.Vertical => Alignment.Horizontal,

                _ => Alignment.Undefined,
            };
        }

        public static Orientation Opposite(this Orientation orientation)
        {
            return orientation switch
            {
                Orientation.Clockwise => Orientation.CounterClockwise,

                Orientation.CounterClockwise => Orientation.Clockwise,

                Orientation.Undefined => Orientation.Undefined,

                Orientation.Collinear => Orientation.Undefined,

                _ => Orientation.Undefined,
            };
        }
    }
}
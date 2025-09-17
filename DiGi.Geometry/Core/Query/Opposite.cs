using DiGi.Geometry.Core.Enums;

namespace DiGi.Geometry.Core
{
    public static partial class Query
    {
        public static Alignment Opposite(this Alignment alignment)
        {
            switch (alignment)
            {
                case Alignment.Horizontal:
                    return Alignment.Vertical;

                case Alignment.Vertical:
                    return Alignment.Horizontal;

                default:
                    return Alignment.Undefined;
            }
        }

        public static Orientation Opposite(this Orientation orientation)
        {
            switch (orientation)
            {
                case Orientation.Clockwise:
                    return Orientation.CounterClockwise;

                case Orientation.CounterClockwise:
                    return Orientation.Clockwise;

                default:
                    return Orientation.Undefined;
            }
        }
    }
}

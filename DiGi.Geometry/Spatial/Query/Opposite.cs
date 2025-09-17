using DiGi.Geometry.Spatial.Enums;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        public static Side Opposite(this Side side)
        {
            switch (side)
            {
                case Side.Internal:
                    return Side.External;

                case Side.External:
                    return Side.Internal;

                default:
                    return Side.Undefined;
            }
        }
    }
}

using DiGi.Geometry.Core.Enums;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        public static Side Opposite(this Side side)
        {
            return side switch
            {
                Side.Internal => Side.External,

                Side.External => Side.Internal,
                
                Side.Undefined => Side.Undefined,
                
                _ => Side.Undefined,
            };
        }
    }
}

using DiGi.Geometry.Core.Enums;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Returns the opposite of the specified <see cref="Side"/>.
        /// </summary>
        /// <param name="side">The <see cref="Side"/> value to invert.</param>
        /// <returns>The opposite <see cref="Side"/> value.</returns>
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
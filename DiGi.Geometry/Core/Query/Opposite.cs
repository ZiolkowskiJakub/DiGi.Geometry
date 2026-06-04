using DiGi.Geometry.Core.Enums;

namespace DiGi.Geometry.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Returns the opposite <see cref="Alignment"/> value.
        /// </summary>
        /// <param name="alignment">The <see cref="Alignment"/> value to invert.</param>
        /// <returns>The opposite <see cref="Alignment"/> value, or <see cref="Alignment.Undefined"/> if no opposite is defined.</returns>
        public static Alignment Opposite(this Alignment alignment)
        {
            return alignment switch
            {
                Alignment.Horizontal => Alignment.Vertical,

                Alignment.Vertical => Alignment.Horizontal,

                _ => Alignment.Undefined,
            };
        }

        /// <summary>
        /// Returns the opposite of the specified <see cref="Orientation"/>.
        /// </summary>
        /// <param name="orientation">The <see cref="Orientation"/> value to invert.</param>
        /// <returns>The opposite <see cref="Orientation"/> value, or <see cref="Orientation.Undefined"/> if the input is undefined or collinear.</returns>
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
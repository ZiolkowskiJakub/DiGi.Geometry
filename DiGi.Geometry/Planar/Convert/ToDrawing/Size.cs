using DiGi.Core.Enums;
using DiGi.Geometry.Planar.Classes;
using System.Drawing;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="Vector2D"/> to a <see cref="Size"/> using the specified rounding method.
        /// </summary>
        /// <param name="vector2D">The <see cref="Vector2D"/> instance to convert.</param>
        /// <param name="roundingMethod">The <see cref="RoundingMethod"/> used to round the values. Defaults to <see cref="RoundingMethod.Nearest"/>.</param>
        /// <returns>A <see cref="Size"/> object if the conversion is successful and the rounding method is not <see cref="RoundingMethod.Undefined"/>; otherwise, <c>null</c>.</returns>
        public static Size? ToDrawing_Size(this Vector2D vector2D, RoundingMethod roundingMethod = RoundingMethod.Nearest)
        {
            if (roundingMethod == RoundingMethod.Undefined)
            {
                return null;
            }

            SizeF? sizeF = ToDrawing(vector2D);
            if (sizeF == null || !sizeF.HasValue)
            {
                return null;
            }

            switch (roundingMethod)
            {
                case RoundingMethod.Nearest:
                    return Size.Round(sizeF.Value);

                case RoundingMethod.Ceiling:
                    return Size.Ceiling(sizeF.Value);

                case RoundingMethod.Truncate:
                    return Size.Truncate(sizeF.Value);

                case RoundingMethod.Undefined:
                    break;

                default:
                    break;
            }

            return null;
        }
    }
}
using DiGi.Core.Enums;
using DiGi.Geometry.Planar.Classes;
using System.Drawing;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="BoundingBox2D"/> to a <see cref="Rectangle"/> using the specified rounding method.
        /// </summary>
        /// <param name="boundingBox2D">The <see cref="BoundingBox2D"/> instance to convert.</param>
        /// <param name="roundingMethod">The <see cref="RoundingMethod"/> used to round the coordinates. Defaults to <see cref="RoundingMethod.Nearest"/>.</param>
        /// <returns>A <see cref="Rectangle"/> if the conversion is successful; otherwise, <c>null</c> if the <paramref name="roundingMethod"/> is <see cref="RoundingMethod.Undefined"/> or the internal conversion fails.</returns>
        public static Rectangle? ToDrawing_Rectangle(this BoundingBox2D boundingBox2D, RoundingMethod roundingMethod = RoundingMethod.Nearest)
        {
            if (roundingMethod == RoundingMethod.Undefined)
            {
                return null;
            }

            RectangleF? rectangleF = ToDrawing(boundingBox2D);
            if (rectangleF == null || !rectangleF.HasValue)
            {
                return null;
            }

            switch (roundingMethod)
            {
                case RoundingMethod.Nearest:
                    return Rectangle.Round(rectangleF.Value);

                case RoundingMethod.Ceiling:
                    return Rectangle.Ceiling(rectangleF.Value);

                case RoundingMethod.Truncate:
                    return Rectangle.Truncate(rectangleF.Value);

                case RoundingMethod.Undefined:
                    break;

                default:
                    break;
            }

            return null;
        }
    }
}

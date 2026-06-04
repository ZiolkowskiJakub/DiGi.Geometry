using DiGi.Core.Enums;
using DiGi.Geometry.Planar.Classes;
using System.Drawing;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="Point2D"/> to a <see cref="Point"/> using the specified rounding method.
        /// </summary>
        /// <param name="point2D">The <see cref="Point2D"/> instance to convert.</param>
        /// <param name="roundingMethod">The <see cref="RoundingMethod"/> used to round the coordinates. Defaults to <see cref="RoundingMethod.Nearest"/>.</param>
        /// <returns>A <see cref="Point"/> object if the conversion is successful and the rounding method is not undefined; otherwise, <see langword="null"/>.</returns>
        public static Point? ToDrawing_Point(this Point2D point2D, RoundingMethod roundingMethod = RoundingMethod.Nearest)
        {
            if (roundingMethod == RoundingMethod.Undefined)
            {
                return null;
            }

            PointF? pointF = ToDrawing(point2D);
            if (pointF == null || !pointF.HasValue)
            {
                return null;
            }

            switch (roundingMethod)
            {
                case RoundingMethod.Nearest:
                    return Point.Round(pointF.Value);

                case RoundingMethod.Ceiling:
                    return Point.Ceiling(pointF.Value);

                case RoundingMethod.Truncate:
                    return Point.Truncate(pointF.Value);

                case RoundingMethod.Undefined:
                    break;

                default:
                    break;
            }

            return null;
        }
    }
}
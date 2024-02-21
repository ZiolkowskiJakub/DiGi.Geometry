using DiGi.Core.Enums;
using DiGi.Geometry.Planar.Classes;
using System.Drawing;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        public static Size? ToDrawing_Size(this Vector2D vector2D, RoundingMethod roundingMethod = RoundingMethod.Nearest)
        {
            if(roundingMethod == RoundingMethod.Undefined)
            {
                return null;
            }

            SizeF? sizeF = ToDrawing(vector2D);
            if(sizeF == null || !sizeF.HasValue)
            {
                return null;
            }

            switch(roundingMethod)
            {
                case RoundingMethod.Nearest:
                    return Size.Round(sizeF.Value);

                case RoundingMethod.Ceiling:
                    return Size.Ceiling(sizeF.Value);

                case RoundingMethod.Truncate:
                    return Size.Truncate(sizeF.Value);
            }

            return null;
        }
    }
}

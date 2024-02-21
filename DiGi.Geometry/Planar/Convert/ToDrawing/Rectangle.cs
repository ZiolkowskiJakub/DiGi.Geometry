using DiGi.Core.Enums;
using DiGi.Geometry.Planar.Classes;
using System.Drawing;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        public static Rectangle? ToDrawing_Rectangle(this BoundingBox2D boundingBox2D, RoundingMethod roundingMethod = RoundingMethod.Nearest)
        {
            if(roundingMethod == RoundingMethod.Undefined)
            {
                return null;
            }

            RectangleF? rectangleF = ToDrawing(boundingBox2D);
            if(rectangleF == null || !rectangleF.HasValue)
            {
                return null;
            }

            switch(roundingMethod)
            {
                case RoundingMethod.Nearest:
                    return Rectangle.Round(rectangleF.Value);

                case RoundingMethod.Ceiling:
                    return Rectangle.Ceiling(rectangleF.Value);

                case RoundingMethod.Truncate:
                    return Rectangle.Truncate(rectangleF.Value);
            }

            return null;
        }
    }
}

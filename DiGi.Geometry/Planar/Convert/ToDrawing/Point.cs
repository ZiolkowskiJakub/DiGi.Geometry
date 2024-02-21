using DiGi.Core.Enums;
using DiGi.Geometry.Planar.Classes;
using System.Drawing;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        public static Point? ToDrawing_Point(this Point2D point2D, RoundingMethod roundingMethod = RoundingMethod.Nearest)
        {
            if(roundingMethod == RoundingMethod.Undefined)
            {
                return null;
            }

            PointF? pointF = ToDrawing(point2D);
            if(pointF == null || !pointF.HasValue)
            {
                return null;
            }

            switch(roundingMethod)
            {
                case RoundingMethod.Nearest:
                    return Point.Round(pointF.Value);

                case RoundingMethod.Ceiling:
                    return Point.Ceiling(pointF.Value);

                case RoundingMethod.Truncate:
                    return Point.Truncate(pointF.Value);
            }

            return null;
        }
    }
}

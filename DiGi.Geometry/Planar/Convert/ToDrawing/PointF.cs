using DiGi.Geometry.Planar.Classes;
using System.Drawing;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        public static PointF? ToDrawing(this Point2D point2D)
        {
            if (point2D == null)
            {
                return null;
            }

            return new PointF(System.Convert.ToSingle(point2D.X), System.Convert.ToSingle(point2D.Y));
        }
    }
}

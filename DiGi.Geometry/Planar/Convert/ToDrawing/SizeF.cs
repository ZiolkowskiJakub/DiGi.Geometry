using DiGi.Geometry.Planar.Classes;
using System.Drawing;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        public static SizeF? ToDrawing(this Vector2D vector2D)
        {
            if (vector2D == null)
            {
                return null;
            }

            return new SizeF(System.Convert.ToSingle(vector2D.X), System.Convert.ToSingle(vector2D.Y));
        }
    }
}

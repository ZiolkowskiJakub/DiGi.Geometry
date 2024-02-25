using DiGi.Geometry.Planar.Classes;
using System.Drawing;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        public static Vector2D ToDiGi(this System.Drawing.Size size)
        {
            return new Vector2D(size.Width, size.Height);
        }

        public static Vector2D ToDiGi(this SizeF sizeF)
        {
            return new Vector2D(sizeF.Width, sizeF.Height);
        }
    }
}

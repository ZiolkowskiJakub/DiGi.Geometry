using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;
using System.Drawing;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        public static BoundingBox2D ToDiGi(this Rectangle rectangle)
        {
            return new BoundingBox2D(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
        }

        public static BoundingBox2D ToDiGi(this RectangleF rectangleF)
        {
            return new BoundingBox2D(rectangleF.X, rectangleF.Y, rectangleF.Width, rectangleF.Height);
        }
    }
}

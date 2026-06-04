using DiGi.Geometry.Planar.Classes;
using System.Drawing;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="Rectangle"/> to a <see cref="BoundingBox2D"/>.
        /// </summary>
        /// <param name="rectangle">The <see cref="Rectangle"/> instance to convert.</param>
        /// <returns>A new <see cref="BoundingBox2D"/> created from the provided <see cref="Rectangle"/>.</returns>
        public static BoundingBox2D ToDiGi(this Rectangle rectangle)
        {
            return new BoundingBox2D(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
        }

        /// <summary>
        /// Converts a <see cref="RectangleF"/> to a <see cref="BoundingBox2D"/>.
        /// </summary>
        /// <param name="rectangleF">The <see cref="RectangleF"/> instance to convert.</param>
        /// <returns>A new <see cref="BoundingBox2D"/> instance created from the provided <see cref="RectangleF"/>.</returns>
        public static BoundingBox2D ToDiGi(this RectangleF rectangleF)
        {
            return new BoundingBox2D(rectangleF.X, rectangleF.Y, rectangleF.Width, rectangleF.Height);
        }
    }
}
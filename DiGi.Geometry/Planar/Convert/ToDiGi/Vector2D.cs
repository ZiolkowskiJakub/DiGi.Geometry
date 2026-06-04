using DiGi.Geometry.Planar.Classes;
using System.Drawing;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="Size"/> object to a <see cref="Vector2D"/>.
        /// </summary>
        /// <param name="size">The <see cref="Size"/> instance to convert.</param>
        /// <returns>A new <see cref="Vector2D"/> representing the dimensions of the provided <see cref="Size"/>.</returns>
        public static Vector2D ToDiGi(this Size size)
        {
            return new Vector2D(size.Width, size.Height);
        }

        /// <summary>
        /// Converts a <see cref="SizeF"/> instance to a <see cref="Vector2D"/>.
        /// </summary>
        /// <param name="sizeF">The <see cref="SizeF"/> instance to convert.</param>
        /// <returns>A new <see cref="Vector2D"/> created from the width and height of the <see cref="SizeF"/> instance.</returns>
        public static Vector2D ToDiGi(this SizeF sizeF)
        {
            return new Vector2D(sizeF.Width, sizeF.Height);
        }
    }
}
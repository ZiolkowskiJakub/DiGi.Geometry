using DiGi.Geometry.Planar.Classes;
using System.Drawing;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="Vector2D"/> instance to a <see cref="SizeF"/> object.
        /// </summary>
        /// <param name="vector2D">The <see cref="Vector2D"/> instance to convert.</param>
        /// <returns>A <see cref="SizeF"/> representation of the <see cref="Vector2D"/>, or <see langword="null"/> if the provided <see cref="Vector2D"/> is <see langword="null"/>.</returns>
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
using DiGi.Geometry.Planar.Classes;
using System.Numerics;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="Coordinate2D"/> instance to a nullable <see cref="Vector2"/>.
        /// </summary>
        /// <param name="coordinate2D">The <see cref="Coordinate2D"/> instance to convert.</param>
        /// <returns>A <see cref="Vector2"/> containing the X and Y coordinates, or <see langword="null"/> if the <paramref name="coordinate2D"/> is <see langword="null"/>.</returns>
        public static Vector2? ToNumerics(this Coordinate2D coordinate2D)
        {
            if (coordinate2D == null)
            {
                return null;
            }

            return new Vector2((float)coordinate2D.X, (float)coordinate2D.Y);
        }
    }
}
using DiGi.Geometry.Planar.Classes;
using System.Numerics;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
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

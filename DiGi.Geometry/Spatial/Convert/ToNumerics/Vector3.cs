using DiGi.Geometry.Spatial.Classes;
using System.Numerics;

namespace DiGi.Geometry.Spatial
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="Coordinate3D"/> instance to a nullable <see cref="Vector3"/>.
        /// </summary>
        /// <param name="coordinate3D">The <see cref="Coordinate3D"/> instance to convert.</param>
        /// <returns>A <see cref="Vector3"/> containing the converted coordinates, or <c>null</c> if the provided <see cref="Coordinate3D"/> is <c>null</c>.</returns>
        public static Vector3? ToNumerics(this Coordinate3D coordinate3D)
        {
            if (coordinate3D == null)
            {
                return null;
            }

            return new Vector3((float)coordinate3D.X, (float)coordinate3D.Y, (float)coordinate3D.Z);
        }
    }
}
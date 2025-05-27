using DiGi.Geometry.Spatial.Classes;
using System.Numerics;

namespace DiGi.Geometry.Spatial
{
    public static partial class Convert
    {
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

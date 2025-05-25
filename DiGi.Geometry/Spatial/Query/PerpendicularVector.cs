using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        public static Vector3D PerpendicularVector(this Vector3D vector3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (vector3D == null)
            {
                return null;
            }

            Vector3D vector3D_Temp = System.Math.Abs(vector3D.X) > 1 - tolerance && System.Math.Abs(vector3D.Y) < tolerance && System.Math.Abs(vector3D.Z) < tolerance ? Constans.Vector3D.WorldY : Constans.Vector3D.WorldX;

            return vector3D.CrossProduct(vector3D_Temp);
        }
    }

}

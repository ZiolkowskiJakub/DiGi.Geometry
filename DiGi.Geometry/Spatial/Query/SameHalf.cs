using DiGi.Geometry.Spatial.Classes;


namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        public static bool SameHalf(this Vector3D vector3D_1, Vector3D vector3D_2, double tolerance = DiGi.Core.Constans.Tolerance.Angle)
        {
            if (vector3D_1 == null || vector3D_2 == null)
            {
                return false;
            }

            return vector3D_1.Angle(vector3D_2) - tolerance <= vector3D_1.Angle(vector3D_1.GetInversed());
        }
    }
}

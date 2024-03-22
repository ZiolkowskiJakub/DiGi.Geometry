using DiGi.Geometry.Spatial.Classes;


namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        public static bool Similar(this Vector3D vector3D_1, Vector3D vector3D_2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (vector3D_1 == vector3D_2)
            {
                return true;
            }

            if (vector3D_1 == null || vector3D_2 == null)
            {
                return false;
            }

            Vector3D vector3D_3 = new Vector3D(vector3D_2);
            vector3D_3.Inverse();

            return vector3D_1.AlmostEqual(vector3D_2, tolerance) || vector3D_1.AlmostEqual(vector3D_3, tolerance);
        }
    }
}

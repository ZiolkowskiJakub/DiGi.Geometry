using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        public static Vector3D Vector3D(Vector3D vector3D, bool normalize = false)
        {
            if(vector3D == null)
            {
                return null;
            }

            Vector3D result = new Vector3D(vector3D);
            if(normalize)
            {
                result.Normalize();
            }

            return result;
        }
    }
}

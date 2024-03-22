using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        public static Vector3D AxisY(this Vector3D normal)
        {
            if (normal == null)
            {
                return null;
            }

            return AxisY(normal, AxisX(normal));
        }

        public static Vector3D AxisY(this Vector3D normal, Vector3D axisX)
        {
            if (normal == null || axisX == null)
            {
                return null;
            }

            return normal.CrossProduct(axisX).Unit;
        }
    }

}

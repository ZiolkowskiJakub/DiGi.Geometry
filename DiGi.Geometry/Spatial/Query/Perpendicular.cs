using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        public static bool Perpendicular(this Vector3D vector3D_1, Vector3D vector3D_2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (vector3D_1 == vector3D_2)
            {
                return false;
            }

            if (vector3D_1 == null || vector3D_2 == null)
            {
                return false;
            }

            return System.Math.Abs(vector3D_1.Unit.DotProduct(vector3D_2.Unit)) <= tolerance;
        }

        public static bool Perpendicular(this Plane plane_1, Plane plane_2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            return Perpendicular(plane_1?.Normal, plane_2?.Normal, tolerance);
        }
    }

}

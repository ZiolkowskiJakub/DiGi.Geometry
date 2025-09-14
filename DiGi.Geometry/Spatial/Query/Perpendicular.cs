using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        public static bool Perpendicular(this Vector3D? vector3D_1, Vector3D? vector3D_2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (vector3D_1 == vector3D_2)
            {
                return false;
            }

            if (vector3D_1?.Unit is not Vector3D unit_1 || vector3D_2?.Unit is not Vector3D unit_2)
            {
                return false;
            }

            return System.Math.Abs(unit_1.DotProduct(unit_2)) <= tolerance;
        }

        public static bool Perpendicular(this Plane? plane_1, Plane? plane_2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            return Perpendicular(plane_1?.Normal, plane_2?.Normal, tolerance);
        }
    }

}

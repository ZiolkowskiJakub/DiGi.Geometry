using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        public static bool Parallel(this Vector3D vector3D_1, Vector3D vector3D_2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            // Calculate cross product
            double crossX = vector3D_1.Y * vector3D_2.Z - vector3D_1.Z * vector3D_2.Y;
            double crossY = vector3D_1.Z * vector3D_2.X - vector3D_1.X * vector3D_2.Z;
            double crossZ = vector3D_1.X * vector3D_2.Y - vector3D_1.Y * vector3D_2.X;

            // Check if the cross product is (almost) zero vector
            return System.Math.Abs(crossX) < tolerance && System.Math.Abs(crossY) < tolerance && System.Math.Abs(crossZ) < tolerance;
        }
    }

}

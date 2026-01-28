using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        public static double Determinant(this Point3D? point3D_1, Point3D? point3D_2, Point3D? point3D_3, Vector3D? normal)
        {
            if (point3D_1 == null || point3D_2 == null || point3D_3 == null || normal == null)
            {
                return double.NaN;
            }

            return (point3D_2.X - point3D_1.X) * ((point3D_3.Y - point3D_1.Y) * normal.Z - (point3D_3.Z - point3D_1.Z) * normal.Y) - (point3D_2.Y - point3D_1.Y) * ((point3D_3.X - point3D_1.X) * normal.Z - (point3D_3.Z - point3D_1.Z) * normal.X) + (point3D_2.Z - point3D_1.Z) * ((point3D_3.X - point3D_1.X) * normal.Y - (point3D_3.Y - point3D_1.Y) * normal.X);
        }

        public static double Determinant(this Vector3D? vector3D_1, Vector3D? vector3D_2, Vector3D? normal)
        {
            if (vector3D_1 == null || vector3D_2 == null || normal == null)
            {
                return double.NaN;
            }

            return vector3D_1.X * (vector3D_2.Y * normal.Z - vector3D_2.Z * normal.Y) - vector3D_1.Y * (vector3D_2.X * normal.Z - vector3D_2.Z * normal.X) + vector3D_1.Z * (vector3D_2.X * normal.Y - vector3D_2.Y * normal.X);
        }
    }
}
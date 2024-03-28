using DiGi.Geometry.Spatial.Classes;


namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        public static bool Similar(this Point3D point3D_1, Point3D point3D_2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            return AlmostEquals(point3D_1, point3D_2, tolerance);
        }

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

            return vector3D_1.AlmostEquals(vector3D_2, tolerance) || vector3D_1.AlmostEquals(vector3D_3, tolerance);
        }

        public static bool Similar(this Segment3D segment3D_1, Segment3D segment3D_2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (segment3D_1 == segment3D_2)
            {
                return true;
            }

            if (segment3D_1 == null || segment3D_2 == null)
            {
                return false;
            }

            Segment3D segment3D_3 = new Segment3D(segment3D_2);
            segment3D_3.Inverse();

            return segment3D_1.AlmostEquals(segment3D_2, tolerance) || segment3D_1.AlmostEquals(segment3D_3, tolerance);
        }
    }
}

using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        public static Point3D Project(this Plane plane, Point3D point3D)
        {
            if (plane == null || point3D == null)
            {
                return null;
            }

            return plane.ClosestPoint(point3D);
        }
    }

}

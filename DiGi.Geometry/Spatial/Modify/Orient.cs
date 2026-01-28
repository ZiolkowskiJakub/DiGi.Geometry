using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Geometry.Spatial
{
    public static partial class Modify
    {
        public static bool Orient(this IPolygonal3D? polygonal3D, Orientation orientation, bool convexHull = true)
        {
            if (polygonal3D == null || orientation == Orientation.Undefined || orientation == Orientation.Collinear)
            {
                return false;
            }

            Orientation orientation_Temp = polygonal3D.Orientation(convexHull);
            if (orientation_Temp == orientation)
            {
                return false;
            }

            polygonal3D.Inverse();
            return true;
        }
    }
}
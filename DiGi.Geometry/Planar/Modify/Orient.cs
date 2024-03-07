using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Planar.Interfaces;

namespace DiGi.Geometry.Planar
{
    public static partial class Modify
    {
        public static bool Orient(this IClosedSegmentable2D closedSegmentable2D, Orientation orientation)
        {
            if(closedSegmentable2D == null || orientation == Orientation.Undefined || orientation == Orientation.Collinear)
            {
                return false;
            }

            Orientation orientation_Temp = closedSegmentable2D.Orientation();
            if(orientation_Temp == orientation)
            {
                return false;
            }

            closedSegmentable2D.Inverse();
            return true;
        }
    }
}

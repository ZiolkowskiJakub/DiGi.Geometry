using DiGi.Geometry.Planar.Interfaces;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static bool EqualsTopologically(this ISegmentable2D segmentable2D_1, ISegmentable2D segmentable2D_2)
        {
            if (segmentable2D_1 == segmentable2D_2)
            {
                return true;
            }

            if (segmentable2D_1 == null || segmentable2D_2 == null)
            {
                return false;
            }

            NetTopologySuite.Geometries.Geometry geometry_1 = segmentable2D_1.ToNTS();
            if(geometry_1 == null)
            {
                return false;
            }

            NetTopologySuite.Geometries.Geometry geometry_2 = segmentable2D_2.ToNTS();
            if(geometry_2 == null)
            {
                return false;
            }

            if (geometry_1 == null || geometry_2 == null)
            {
                return false;
            }

            return geometry_1.EqualsTopologically(geometry_2);
        }
    }
}

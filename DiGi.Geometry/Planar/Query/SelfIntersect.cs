using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static bool SelfIntersect(this ISegmentable2D segmentable2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            IntersectionResult2D intersectionResult2D = Create.IntersectionResult2D(segmentable2D, 1, tolerance);

            return intersectionResult2D != null && intersectionResult2D.Intersect;
        }
    }
}

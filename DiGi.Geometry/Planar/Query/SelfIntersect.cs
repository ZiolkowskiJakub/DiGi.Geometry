using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Checks if a segmentable geometry self-intersects within a given tolerance.
        /// </summary>
        /// <param name="segmentable2D">The segmentable geometry to check.</param>
        /// <param name="tolerance">The distance tolerance for intersection detection.</param>
        /// <returns>True if the geometry self-intersects, otherwise false.</returns>
        public static bool SelfIntersect(this ISegmentable2D? segmentable2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            IntersectionResult2D? intersectionResult2D = Create.IntersectionResult2D(segmentable2D, 1, tolerance);

            return intersectionResult2D != null && intersectionResult2D.Any();
        }
    }
}
using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar.Interfaces
{
    public interface IPolygonal2D : IClosedCurve2D, ISegmentable2D
    {
        /// <summary>
        /// Gets the centroid of the polygonal geometry.
        /// </summary>
        /// <returns>The centroid point if found; otherwise, null.</returns>
        Point2D? GetCentroid();

        /// <summary>
        /// Determines whether the polygonal geometry is within range of the specified bounding box.
        /// </summary>
        /// <param name="boundingBox2D">The bounding box to check.</param>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>True if in range; otherwise, false.</returns>
        bool InRange(BoundingBox2D? boundingBox2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance);

        /// <summary>
        /// Determines whether the polygonal geometry is within range of the specified segmentable geometry.
        /// </summary>
        /// <param name="segmentable2D">The segmentable geometry to check.</param>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>True if in range; otherwise, false.</returns>
        bool InRange(ISegmentable2D? segmentable2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance);

        /// <summary>
        /// Determines whether the specified segmentable geometry is inside the polygonal geometry.
        /// </summary>
        /// <param name="segmentable2D">The segmentable geometry to check.</param>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>True if inside; otherwise, false.</returns>
        bool Inside(ISegmentable2D? segmentable2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance);

        /// <summary>
        /// Triangulates the polygonal geometry into a list of triangles.
        /// </summary>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>A list of triangles representing the triangulation; otherwise, null.</returns>
        List<Triangle2D>? Triangulate(double tolerance = DiGi.Core.Constants.Tolerance.MicroDistance);
    }
}
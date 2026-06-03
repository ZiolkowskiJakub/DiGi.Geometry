using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar.Interfaces
{
    public interface IPolygonalFace2D : IFace2D<IPolygonal2D>, IInvertible2D
    {
        /// <summary>
        /// Gets the list of polygonal edges that define the face.
        /// </summary>
        List<IPolygonal2D>? Edges { get; }

        /// <summary>
        /// Determines whether the specified point lies on an edge of the face.
        /// </summary>
        /// <param name="point2D">The point to check.</param>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>True if the point is on an edge; otherwise, false.</returns>
        bool OnEdge(Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance);

        /// <summary>
        /// Triangulates the polygonal face into a list of triangles.
        /// </summary>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>A list of triangles representing the triangulation; otherwise, null.</returns>
        List<Triangle2D>? Triangulate(double tolerance = DiGi.Core.Constants.Tolerance.MicroDistance);

        /// <summary>
        /// Orients the edges of the face based on the specified orientations for external and internal edges.
        /// </summary>
        /// <param name="externalEdgeOrientation">The orientation for the external edge.</param>
        /// <param name="internalEdgeOrientation">The orientation for internal edges (holes).</param>
        /// <returns>True if orientation was successful; otherwise, false.</returns>
        bool Orient(Orientation? externalEdgeOrientation, Orientation? internalEdgeOrientation);
    }
}
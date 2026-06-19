using DiGi.Geometry.Core.Classes;
using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar.Classes
{
    /// <summary>
    /// Updates the normalization of a 2D polygonal face based on specified edge orientations.
    /// </summary>
    public class PolygonalFace2DNormalizationUpdater : GeometryUpdater<IPolygonalFace2D>, Core.Interfaces.INormalizationUpdater<IPolygonalFace2D>
    {
        private readonly Orientation? externalEdgeOrientation;
        private readonly Orientation? internalEdgeOrientation;

        /// <summary>
        /// Initializes a new instance of the <see cref="PolygonalFace2DNormalizationUpdater"/> class using the specified <see cref="Orientation"/> for both external and internal edges.
        /// </summary>
        /// <param name="orientation">The <see cref="Orientation"/> to be used for normalization of both external and internal edges.</param>
        public PolygonalFace2DNormalizationUpdater(Orientation orientation)
        {
            externalEdgeOrientation = orientation;
            internalEdgeOrientation = orientation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolygonalFace2DNormalizationUpdater"/> class with the specified orientations for external and internal edges.
        /// </summary>
        /// <param name="externalEdgeOrientation">The optional <see cref="Orientation"/> used to validate the normalization of the external edge.</param>
        /// <param name="internalEdgeOrientation">The optional <see cref="Orientation"/> used to validate the normalization of internal edges.</param>
        public PolygonalFace2DNormalizationUpdater(Orientation? externalEdgeOrientation, Orientation? internalEdgeOrientation)
        {
            this.externalEdgeOrientation = externalEdgeOrientation;
            this.internalEdgeOrientation = internalEdgeOrientation;
        }

        /// <summary>
        /// Determines whether the current value is normalized based on the external and internal edge orientations.
        /// </summary>
        /// <returns>A <see cref="bool"/> value indicating whether the value is normalized.</returns>
        public bool Normalized()
        {
            if (Value is null)
            {
                return false;
            }

            if (externalEdgeOrientation != null)
            {
                if (Value.ExternalEdge is IPolygonal2D externalEdge && externalEdge.Orientation() != externalEdgeOrientation)
                {
                    return false;
                }
            }

            if (internalEdgeOrientation != null)
            {
                if (Value.InternalEdges is List<IPolygonal2D> internalEdges)
                {
                    foreach (IPolygonal2D internalEdge in internalEdges)
                    {
                        if (internalEdge != null && internalEdge.Orientation() != externalEdgeOrientation)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Updates the orientation of the value based on the external and internal edge orientations.
        /// </summary>
        /// <returns>A <see cref="bool"/> indicating whether the update was successful; returns <c>false</c> if the value is null.</returns>
        public override bool Update()
        {
            if (Value is null)
            {
                return false;
            }

            return Value.Orient(externalEdgeOrientation, internalEdgeOrientation);
        }
    }
}
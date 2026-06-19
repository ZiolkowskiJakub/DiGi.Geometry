using DiGi.Geometry.Core.Classes;
using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Provides functionality to update and normalize the orientation of a 3D polygonal face.
    /// </summary>
    public class PolygonalFace3DNormalizationUpdater : GeometryUpdater<IPolygonalFace3D>, Core.Interfaces.INormalizationUpdater<IPolygonalFace3D>
    {
        private readonly Orientation? externalEdgeOrientation;
        private readonly Orientation? internalEdgeOrientation;

        /// <summary>
        /// Initializes a new instance of the <see cref="PolygonalFace3DNormalizationUpdater"/> class using the specified <see cref="Orientation"/> for both internal and external edges.
        /// </summary>
        /// <param name="orientation">The <see cref="Orientation"/> to be applied to both internal and external edge orientations.</param>
        public PolygonalFace3DNormalizationUpdater(Orientation orientation)
        {
            externalEdgeOrientation = orientation;
            internalEdgeOrientation = orientation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolygonalFace3DNormalizationUpdater"/> class with the specified orientation requirements for external and internal edges.
        /// </summary>
        /// <param name="externalEdgeOrientation">The required <see cref="Orientation"/> for external edges, or null if no specific orientation is required.</param>
        /// <param name="internalEdgeOrientation">The required <see cref="Orientation"/> for internal edges, or null if no specific orientation is required.</param>
        public PolygonalFace3DNormalizationUpdater(Orientation? externalEdgeOrientation, Orientation? internalEdgeOrientation)
        {
            this.externalEdgeOrientation = externalEdgeOrientation;
            this.internalEdgeOrientation = internalEdgeOrientation;
        }

        /// <summary>
        /// Determines whether the value is normalized based on the external and internal edge orientations.
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
                if (Value.ExternalEdge is IPolygonal3D externalEdge && externalEdge.Orientation() != externalEdgeOrientation)
                {
                    return false;
                }
            }

            if (internalEdgeOrientation != null)
            {
                if (Value.InternalEdges is List<IPolygonal3D> internalEdges)
                {
                    foreach (IPolygonal3D internalEdge in internalEdges)
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
        /// Updates the orientation of the value using the external and internal edge orientations.
        /// </summary>
        /// <returns>A <see cref="bool"/> indicating whether the update was successfully performed.</returns>
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
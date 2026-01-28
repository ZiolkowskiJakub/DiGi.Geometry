using DiGi.Geometry.Core.Classes;
using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial.Classes
{
    public class PolygonalFace3DNormalizationUpdater : GeometryUpdater<IPolygonalFace3D>, Core.Interfaces.INormalizationUpdater<IPolygonalFace3D>
    {
        private readonly Orientation? externalEdgeOrientation;
        private readonly Orientation? internalEdgeOrientation;

        public PolygonalFace3DNormalizationUpdater(Orientation orientation)
        {
            externalEdgeOrientation = orientation;
            internalEdgeOrientation = orientation;
        }

        public PolygonalFace3DNormalizationUpdater(Orientation? externalEdgeOrientation, Orientation? internalEdgeOrientation)
        {
            this.externalEdgeOrientation = externalEdgeOrientation;
            this.internalEdgeOrientation = internalEdgeOrientation;
        }

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
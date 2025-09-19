using DiGi.Geometry.Core.Classes;
using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;


namespace DiGi.Geometry.Planar.Classes
{
    public class PolygonalFace2DNormalizationUpdater : GeometryUpdater<IPolygonalFace2D>, Core.Interfaces.INormalizationUpdater<IPolygonalFace2D>
    {
        private readonly Orientation? externalEdgeOrientation;
        private readonly Orientation? internalEdgeOrientation;

        public PolygonalFace2DNormalizationUpdater(Orientation orientation)
        {
            externalEdgeOrientation = orientation;
            internalEdgeOrientation = orientation;
        }

        public PolygonalFace2DNormalizationUpdater(Orientation? externalEdgeOrientation, Orientation? internalEdgeOrientation)
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

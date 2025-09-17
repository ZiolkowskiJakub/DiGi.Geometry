using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;


namespace DiGi.Geometry.Planar.Classes
{
    public class PolygonalFace2DNormalizationSolver : Core.Interfaces.INormalizationSolver
    {
        private readonly IPolygonalFace2D? polygonalFace2D;

        private readonly Orientation? externalEdgeOrientation;
        private readonly Orientation? internalEdgeOrientation;

        public PolygonalFace2DNormalizationSolver(IPolygonalFace2D? polygonalFace2D, Orientation orientation)
        {
            this.polygonalFace2D = DiGi.Core.Query.Clone(polygonalFace2D);
            externalEdgeOrientation = orientation;
            internalEdgeOrientation = orientation;
        }

        public PolygonalFace2DNormalizationSolver(IPolygonalFace2D? polygonalFace2D, Orientation? externalEdgeOrientation, Orientation? internalEdgeOrientation)
        {
            this.polygonalFace2D = DiGi.Core.Query.Clone(polygonalFace2D);
            this.externalEdgeOrientation = externalEdgeOrientation;
            this.internalEdgeOrientation = internalEdgeOrientation;
        }

        public IPolygonalFace2D? PolygonalFace2D
        {
            get
            {
                return DiGi.Core.Query.Clone(polygonalFace2D);
            }
        }

        public bool Solve()
        {
            if(polygonalFace2D is null)
            {
                return false;
            }

            return polygonalFace2D.Orient(externalEdgeOrientation, internalEdgeOrientation);
        }

        public bool Normalized()
        {
            if(polygonalFace2D is null)
            {
                return false;
            }

            if(externalEdgeOrientation != null)
            {
                if(polygonalFace2D.ExternalEdge is IPolygonal2D externalEdge && externalEdge.Orientation() != externalEdgeOrientation)
                {
                    return false;
                }
            }

            if(internalEdgeOrientation != null)
            {
                if(polygonalFace2D.InternalEdges is List<IPolygonal2D> internalEdges)
                {
                    foreach (IPolygonal2D internalEdge in internalEdges)
                    {
                        if(internalEdge != null && internalEdge.Orientation() != externalEdgeOrientation)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

    }
}

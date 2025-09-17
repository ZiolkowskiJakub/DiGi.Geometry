using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;


namespace DiGi.Geometry.Spatial.Classes
{
    public class PolygonalFace3DNormalizationSolver : Core.Interfaces.INormalizationSolver
    {
        private readonly IPolygonalFace3D? polygonalFace3D;

        private readonly Orientation? externalEdgeOrientation;
        private readonly Orientation? internalEdgeOrientation;

        public PolygonalFace3DNormalizationSolver(IPolygonalFace3D? polygonalFace3D, Orientation orientation)
        {
            this.polygonalFace3D = DiGi.Core.Query.Clone(polygonalFace3D);
            externalEdgeOrientation = orientation;
            internalEdgeOrientation = orientation;
        }

        public PolygonalFace3DNormalizationSolver(IPolygonalFace3D? polygonalFace3D, Orientation? externalEdgeOrientation, Orientation? internalEdgeOrientation)
        {
            this.polygonalFace3D = DiGi.Core.Query.Clone(polygonalFace3D);
            this.externalEdgeOrientation = externalEdgeOrientation;
            this.internalEdgeOrientation = internalEdgeOrientation;
        }

        public IPolygonalFace3D? PolygonalFace3D
        {
            get
            {
                return DiGi.Core.Query.Clone(polygonalFace3D);
            }
        }

        public bool Solve()
        {
            if(polygonalFace3D is null)
            {
                return false;
            }

            return polygonalFace3D.Orient(externalEdgeOrientation, internalEdgeOrientation);
        }

        public bool Normalized()
        {
            if(polygonalFace3D is null)
            {
                return false;
            }

            if(externalEdgeOrientation != null)
            {
                if(polygonalFace3D.ExternalEdge is IPolygonal3D externalEdge && externalEdge.Orientation() != externalEdgeOrientation)
                {
                    return false;
                }
            }

            if(internalEdgeOrientation != null)
            {
                if(polygonalFace3D.InternalEdges is List<IPolygonal3D> internalEdges)
                {
                    foreach (IPolygonal3D internalEdge in internalEdges)
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

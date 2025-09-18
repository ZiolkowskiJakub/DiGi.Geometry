using DiGi.Core.Constans;
using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Spatial.Enums;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;


namespace DiGi.Geometry.Spatial.Classes
{
    public class PolyhedronNormalizationSolver : Core.Interfaces.INormalizationSolver
    {
        private readonly double tolerance = Tolerance.Distance;

        private readonly Polyhedron? polyhedron;

        private readonly Side? normalSide;
        private readonly Orientation? externalEdgeOrientation;
        private readonly Orientation? internalEdgeOrientation;

        public PolyhedronNormalizationSolver(Polyhedron? polyhedron, Orientation orientation)
        {
            this.polyhedron = DiGi.Core.Query.Clone(polyhedron);
            externalEdgeOrientation = orientation;
            internalEdgeOrientation = orientation;
        }

        public PolyhedronNormalizationSolver(Polyhedron? polyhedron, Side? normalSide, Orientation? externalEdgeOrientation, Orientation? internalEdgeOrientation, double tolerance = Tolerance.Distance)
        {
            this.tolerance = tolerance; 

            this.polyhedron = DiGi.Core.Query.Clone(polyhedron);
            this.externalEdgeOrientation = externalEdgeOrientation;
            this.internalEdgeOrientation = internalEdgeOrientation;
            this.normalSide = normalSide;
        }

        public Polyhedron? Polyhedron
        {
            get
            {
                return DiGi.Core.Query.Clone(polyhedron);
            }
        }

        public bool Solve()
        {
            if(polyhedron is null)
            {
                return false;
            }

            throw new System.NotImplementedException();

            //return polyhedron.Orient(externalEdgeOrientation, internalEdgeOrientation);
        }

        public bool Normalized()
        {
            if(polyhedron is null)
            {
                return false;
            }

            if (externalEdgeOrientation is not null || internalEdgeOrientation is not null)
            {
                if (polyhedron.PolygonalFaces is not List<IPolygonalFace3D> polygonalFace3Ds || polygonalFace3Ds.Count == 0)
                {
                    return false;
                }

                foreach (IPolygonalFace3D polygonalFace3D in polygonalFace3Ds)
                {
                    PolygonalFace3DNormalizationSolver polygonalFace3DNormalizationSolver = new (polygonalFace3D, externalEdgeOrientation, internalEdgeOrientation);
                    if(!polygonalFace3DNormalizationSolver.Normalized())
                    {
                        return false;
                    }
                }
            }

            if(normalSide is not null)
            {
                for (int i = 0; i < polyhedron.Count; i++)
                {
                    polyhedron.GetNormal(i, out bool inversed, normalSide , tolerance);
                    if(inversed)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

    }
}

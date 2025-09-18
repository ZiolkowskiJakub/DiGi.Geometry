using DiGi.Core.Constans;
using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Spatial.Enums;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;


namespace DiGi.Geometry.Spatial.Classes
{
    public class PolyhedronNormalizationSolver : PolyhedronNormalizationSolver<Polyhedron>
    {
        public PolyhedronNormalizationSolver(Polyhedron? polyhedron, Orientation orientation)
            : base(polyhedron, orientation)
        {

        }

        public PolyhedronNormalizationSolver(Polyhedron? polyhedron, Side? normalSide, Orientation? externalEdgeOrientation, Orientation? internalEdgeOrientation, double tolerance = Tolerance.Distance)
            : base(polyhedron, normalSide, externalEdgeOrientation, internalEdgeOrientation)
        {

        }
    }

    public class PolyhedronNormalizationSolver<TPolyhedron> : Core.Interfaces.INormalizationSolver  where TPolyhedron : IPolyhedron
    {
        private readonly double tolerance = Tolerance.Distance;

        private readonly Side? normalSide;
        private readonly Orientation? externalEdgeOrientation;
        private readonly Orientation? internalEdgeOrientation;
        
        private readonly TPolyhedron? polyhedron;

        public PolyhedronNormalizationSolver(TPolyhedron? polyhedron, Orientation orientation)
        {
            this.polyhedron = DiGi.Core.Query.Clone(polyhedron);
            externalEdgeOrientation = orientation;
            internalEdgeOrientation = orientation;
        }

        public PolyhedronNormalizationSolver(TPolyhedron? polyhedron, Side? normalSide, Orientation? externalEdgeOrientation, Orientation? internalEdgeOrientation, double tolerance = Tolerance.Distance)
        {
            this.tolerance = tolerance; 

            this.polyhedron = DiGi.Core.Query.Clone(polyhedron);
            this.externalEdgeOrientation = externalEdgeOrientation;
            this.internalEdgeOrientation = internalEdgeOrientation;
            this.normalSide = normalSide;
        }

        public TPolyhedron? Polyhedron
        {
            get
            {
                return DiGi.Core.Query.Clone(polyhedron);
            }
        }

        public bool Normalized()
        {
            if (polyhedron is null)
            {
                return false;
            }

            if (externalEdgeOrientation is not null || internalEdgeOrientation is not null)
            {
                for (int i = 0; i < polyhedron.Count; i++)
                {
                    if(!polyhedron.Normalized(i, externalEdgeOrientation, internalEdgeOrientation, tolerance))
                    {
                        return false;
                    }
                }
            }

            if (normalSide is not null)
            {
                for (int i = 0; i < polyhedron.Count; i++)
                {
                    polyhedron.GetNormal(i, out bool inversed, normalSide, tolerance);
                    if (inversed)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool Solve()
        {
            if(polyhedron is null)
            {
                return false;
            }

            bool result = false;

            if (normalSide is not null)
            {
                for (int i = 0; i < polyhedron.Count; i++)
                {
                    if (polyhedron.SetNormal(i, normalSide.Value, tolerance))
                    {
                        result = true;
                    }
                }
            }

            if (externalEdgeOrientation is not null || internalEdgeOrientation is not null)
            {
                if (polyhedron.Orient(externalEdgeOrientation, internalEdgeOrientation))
                {
                    result = true;
                }
            }

            return result;
        }
    }
}

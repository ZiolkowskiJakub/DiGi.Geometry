using DiGi.Core.Constans;
using DiGi.Geometry.Core.Classes;
using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;


namespace DiGi.Geometry.Spatial.Classes
{
    public class PolyhedronNormalizationUpdater : PolyhedronNormalizationUpdater<Polyhedron>
    {
        public PolyhedronNormalizationUpdater(Orientation orientation)
            : base(orientation)
        {

        }

        public PolyhedronNormalizationUpdater(Side? normalSide, Orientation? externalEdgeOrientation, Orientation? internalEdgeOrientation, double tolerance = Tolerance.Distance)
            : base(normalSide, externalEdgeOrientation, internalEdgeOrientation, tolerance)
        {

        }
    }

    public class PolyhedronNormalizationUpdater<TPolyhedron> : GeometryUpdater<TPolyhedron>, Core.Interfaces.INormalizationUpdater<TPolyhedron>  where TPolyhedron : IPolyhedron
    {
        private readonly double tolerance = Tolerance.Distance;

        private readonly Side? normalSide;
        private readonly Orientation? externalEdgeOrientation;
        private readonly Orientation? internalEdgeOrientation;

        public PolyhedronNormalizationUpdater(Orientation orientation)
        {
            externalEdgeOrientation = orientation;
            internalEdgeOrientation = orientation;
        }

        public PolyhedronNormalizationUpdater(Side? normalSide, Orientation? externalEdgeOrientation, Orientation? internalEdgeOrientation, double tolerance = Tolerance.Distance)
        {
            this.tolerance = tolerance; 

            this.externalEdgeOrientation = externalEdgeOrientation;
            this.internalEdgeOrientation = internalEdgeOrientation;
            this.normalSide = normalSide;
        }

        public bool Normalized()
        {
            if (Value is null)
            {
                return false;
            }

            if (externalEdgeOrientation is not null || internalEdgeOrientation is not null)
            {
                for (int i = 0; i < Value.Count; i++)
                {
                    if (!Value.Normalized(i, externalEdgeOrientation, internalEdgeOrientation, tolerance))
                    {
                        return false;
                    }
                }
            }

            if (normalSide is not null)
            {
                for (int i = 0; i < Value.Count; i++)
                {
                    Value.GetNormal(i, out bool inversed, normalSide, tolerance);
                    if (inversed)
                    {
                        return false;
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

            bool result = false;

            if (normalSide is not null)
            {
                for (int i = 0; i < Value.Count; i++)
                {
                    if (Value.SetNormal(i, normalSide.Value, tolerance))
                    {
                        result = true;
                    }
                }
            }

            if (externalEdgeOrientation is not null || internalEdgeOrientation is not null)
            {
                if (Value.Orient(externalEdgeOrientation, internalEdgeOrientation))
                {
                    result = true;
                }
            }

            return result;
        }
    }
}

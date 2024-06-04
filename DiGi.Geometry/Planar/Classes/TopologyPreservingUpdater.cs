using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Simplify;

namespace DiGi.Geometry.Planar.Classes
{
    public class TopologyPreservingUpdater : IGeometry2DUpdater
    {
        private double tolerance = DiGi.Core.Constans.Tolerance.Distance;

        public TopologyPreservingUpdater()
        {

        }

        public TopologyPreservingUpdater(double tolerance)
        {
            this.tolerance = tolerance;
        }

        public bool TryUpdate(IGeometry2D input, out IGeometry2D output)
        {
            output = null;

            NetTopologySuite.Geometries.Geometry geometry = input?.ToNTS();
            if(geometry == null)
            {
                return false;
            }

            output = TopologyPreservingSimplifier.Simplify(geometry, tolerance)?.ToDiGi();

            return output != null;
        }
    }
}

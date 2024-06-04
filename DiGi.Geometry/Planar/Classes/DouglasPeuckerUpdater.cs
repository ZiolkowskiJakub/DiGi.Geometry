using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Simplify;

namespace DiGi.Geometry.Planar.Classes
{
    public class DouglasPeuckerUpdater : IGeometry2DUpdater
    {
        private double tolerance = DiGi.Core.Constans.Tolerance.Distance;

        public DouglasPeuckerUpdater()
        {

        }

        public DouglasPeuckerUpdater(double tolerance)
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

            output = DouglasPeuckerSimplifier.Simplify(geometry, tolerance)?.ToDiGi();

            return output != null;
        }
    }
}

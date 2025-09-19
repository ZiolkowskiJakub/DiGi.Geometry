using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Simplify;

namespace DiGi.Geometry.Planar.Classes
{
    public class TopologyPreservingUpdater : IGeometryUpdater<IGeometry2D>
    {
        private readonly double tolerance = DiGi.Core.Constans.Tolerance.Distance;
        public TopologyPreservingUpdater()
        {

        }

        public TopologyPreservingUpdater(double tolerance)
        {
            this.tolerance = tolerance;
        }

        public IGeometry2D Value { get; set; }

        public bool Update()
        {
            if(Value is null)
            {
                return false;
            }

            NetTopologySuite.Geometries.Geometry? geometry = Value?.ToNTS();
            if (geometry == null)
            {
                return false;
            }

            IGeometry2D? value_Temp = TopologyPreservingSimplifier.Simplify(geometry, tolerance)?.ToDiGi();
            if(value_Temp is null)
            {
                return false;
            }

            Value = value_Temp;
            return true;
        }
    }
}

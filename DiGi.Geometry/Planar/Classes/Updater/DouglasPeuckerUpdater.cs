using DiGi.Geometry.Core.Classes;
using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Simplify;

namespace DiGi.Geometry.Planar.Classes
{
    public class DouglasPeuckerUpdater : GeometryUpdater<IGeometry2D>
    {
        private readonly double tolerance = DiGi.Core.Constans.Tolerance.Distance;

        public DouglasPeuckerUpdater()
        {

        }

        public DouglasPeuckerUpdater(double tolerance)
        {
            this.tolerance = tolerance;
        }

        public override bool Update()
        {
            if (Value == null)
            {
                return false;
            }

            NetTopologySuite.Geometries.Geometry? geometry = Value?.ToNTS();
            if (geometry == null)
            {
                return false;
            }

            IGeometry2D? value_Temp = DouglasPeuckerSimplifier.Simplify(geometry, tolerance)?.ToDiGi();
            if (value_Temp is null)
            {
                return false;
            }

            Value = value_Temp;
            return true;
        }
    }
}

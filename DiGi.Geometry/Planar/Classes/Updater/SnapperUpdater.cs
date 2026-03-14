using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;

namespace DiGi.Geometry.Planar.Classes
{
    public class SnapperUpdater : IGeometryUpdater<IGeometry2D>
    {
        private readonly double tolerance = DiGi.Core.Constans.Tolerance.Distance;

        public SnapperUpdater()
        {
        }

        public SnapperUpdater(double tolerance)
        {
            this.tolerance = tolerance;
        }

        public IGeometry2D? Value { get; set; }

        public bool Update()
        {
            if (Value is null)
            {
                return false;
            }

            NetTopologySuite.Geometries.Geometry? geometry = Value?.ToNTS();
            if (geometry == null)
            {
                return false;
            }

            IGeometry2D? geometry2D = NetTopologySuite.Operation.Overlay.Snap.GeometrySnapper.SnapToSelf(geometry, tolerance, true)?.ToDiGi();
            if (geometry2D == null)
            {
                return false;
            }

            Value = geometry2D;

            return true;
        }
    }
}
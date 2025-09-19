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

        public IGeometry2D Value { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public bool Update(ref IGeometry2D? value)
        {
            if(value is null)
            {
                return false;
            }

            NetTopologySuite.Geometries.Geometry? geometry = value?.ToNTS();
            if (geometry == null)
            {
                return false;
            }

            IGeometry2D? result = NetTopologySuite.Operation.Overlay.Snap.GeometrySnapper.SnapToSelf(geometry, tolerance, true)?.ToDiGi();
            if (result == null)
            {
                return false;
            }

            return result != null;
        }

        public bool Update()
        {
            throw new System.NotImplementedException();
        }
    }
}

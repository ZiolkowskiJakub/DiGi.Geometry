using DiGi.Geometry.Planar.Interfaces;

namespace DiGi.Geometry.Planar.Classes
{
    public class SnapperUpdater : IGeometry2DUpdater
    {
        private double tolerance = DiGi.Core.Constans.Tolerance.Distance;

        public SnapperUpdater()
        {

        }

        public SnapperUpdater(double tolerance)
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
            output = NetTopologySuite.Operation.Overlay.Snap.GeometrySnapper.SnapToSelf(geometry, tolerance, true)?.ToDiGi();
            if (output == null)
            {
                return false;
            }

            return output != null;
        }
    }
}

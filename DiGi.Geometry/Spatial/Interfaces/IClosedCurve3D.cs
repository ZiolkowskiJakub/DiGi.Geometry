using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial.Interfaces
{
    public interface IClosedCurve3D : IClosedCurve, IGeometry3D, ICurve3D
    {
        Point3D GetInternalPoint(double tolerance = DiGi.Core.Constans.Tolerance.Distance);

        public bool InRange(Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance);

        public bool Inside(Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance);
    }
}

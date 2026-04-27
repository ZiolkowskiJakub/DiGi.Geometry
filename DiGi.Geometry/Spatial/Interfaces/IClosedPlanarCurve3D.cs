using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial.Interfaces
{
    public interface IClosedPlanarCurve3D : IClosedCurve3D
    {
        Point3D? GetInternalPoint(double tolerance = DiGi.Core.Constants.Tolerance.Distance);

        public bool InRange(Point3D? point3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance);

        public bool Inside(Point3D? point3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance);

        double GetArea();
    }
}
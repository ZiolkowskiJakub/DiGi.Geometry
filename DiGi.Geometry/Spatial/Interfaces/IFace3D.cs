using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial.Interfaces
{
    public interface IFace3D : IFace, IGeometry3D, IBoundable3D, ISurface3D, IPlanar
    {
        Point3D GetInternalPoint(double tolerance = DiGi.Core.Constans.Tolerance.Distance);

        Point3D ClosestPoint(Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance);

        public bool InRange(Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance);

        public bool Inside(Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance);
    }

    public interface IFace3D<T> : IFace3D, IFace<T> where T : IClosedCurve3D
    {

    }
}

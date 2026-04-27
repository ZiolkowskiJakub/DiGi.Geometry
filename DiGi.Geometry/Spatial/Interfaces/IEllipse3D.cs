using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial.Interfaces
{
    public interface IEllipse3D : IGeometry3D, IBoundable3D, IClosedPlanarCurve3D, IPlanar
    {
        Point3D? Center { get; }
    }
}
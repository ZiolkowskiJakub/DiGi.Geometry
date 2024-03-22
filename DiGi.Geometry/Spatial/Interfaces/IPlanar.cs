using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial.Interfaces
{
    public interface IPlanar : IGeometry3D
    {
        Plane Plane { get; }
    }

    public interface IPlanar<T> : IPlanar where T : IGeometry2D
    {
        T Geometry2D { get; }
    }
}

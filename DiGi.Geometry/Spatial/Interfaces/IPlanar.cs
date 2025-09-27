using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial.Interfaces
{
    public interface IPlanar : IGeometry3D
    {
        Plane? Plane { get; }
    }

    public interface IPlanar<TGeometry2D> : IPlanar where TGeometry2D : IGeometry2D
    {
        TGeometry2D? Geometry2D { get; }
    }
}

using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial.Interfaces
{
    public interface IPlanarGeometry : IGeometry3D
    {
        Plane Plane { get; }
    }

    public interface IPlanarGeometry<T> : IPlanarGeometry where T : IGeometry2D
    {
        T Geometry2D { get; }
    }
}

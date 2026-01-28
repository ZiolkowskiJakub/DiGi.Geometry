using DiGi.Geometry.Object.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;

namespace DiGi.Geometry.Object.Planar.Interfaces
{
    public interface IGeometry2DObject : IGeometryObject
    {
    }

    public interface IGeometry2DObject<TGeometry2D> : IGeometry2DObject where TGeometry2D : IGeometry2D
    {
    }
}
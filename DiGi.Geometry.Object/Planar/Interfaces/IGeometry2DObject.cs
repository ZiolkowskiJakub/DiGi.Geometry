using DiGi.Geometry.Object.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;

namespace DiGi.Geometry.Object.Planar.Interfaces
{
    public interface IGeometry2DObject : IGeometryObject
    {
    }

    public interface IGeometry2DObject<T> : IGeometry2DObject where T : IGeometry2D
    {
    }
}

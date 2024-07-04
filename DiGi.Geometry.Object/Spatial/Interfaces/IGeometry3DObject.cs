using DiGi.Geometry.Object.Core.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Geometry.Object.Spatial.Interfaces
{
    public interface IGeometry3DObject : IGeometryObject
    {

    }

    public interface IGeometry3DObject<T> : IGeometry3DObject where T : IGeometry3D
    {

    }
}

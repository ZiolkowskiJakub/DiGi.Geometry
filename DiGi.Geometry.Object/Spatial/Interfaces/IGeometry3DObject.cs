using DiGi.Geometry.Object.Core.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;

namespace DiGi.Geometry.Object.Spatial.Interfaces
{
    public interface IGeometry3DObject : IGeometryObject
    {

    }

    public interface IGeometry3DObject<TGeometry3D> : IGeometry3DObject where TGeometry3D : IGeometry3D
    {

    }
}

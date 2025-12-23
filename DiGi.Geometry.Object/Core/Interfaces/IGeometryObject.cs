using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Interfaces;

namespace DiGi.Geometry.Object.Core.Interfaces
{
    public interface IGeometryObject : IUniqueObject
    {

    }

    public interface IGeometryObject<TGeometry> : IGeometryObject where TGeometry : IGeometry
    {
        TGeometry? Geometry { get; }
    }
}

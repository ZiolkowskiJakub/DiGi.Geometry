using DiGi.Core.Interfaces;

namespace DiGi.Geometry.Core.Interfaces
{
    public interface IGeometryUpdater : IUpdater
    {

    }

    public interface IGeometryUpdater<TGeometry> : IGeometryUpdater, IUpdater<TGeometry> where TGeometry : IGeometry
    {

    }
}

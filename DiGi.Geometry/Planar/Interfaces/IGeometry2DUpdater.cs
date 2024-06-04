using DiGi.Geometry.Core.Interfaces;

namespace DiGi.Geometry.Planar.Interfaces
{
    public interface IGeometry2DUpdater<T, X> : IGeometryUpdater<T, X> where T : IGeometry2D where X : IGeometry2D
    {
    }

    public interface IGeometry2DUpdater : IGeometry2DUpdater<IGeometry2D, IGeometry2D>
    {

    }
}

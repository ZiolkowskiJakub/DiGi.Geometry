namespace DiGi.Geometry.Core.Interfaces
{
    public interface IGeometryUpdater
    {
    }

    public interface IGeometryUpdater<T, X> where T : IGeometry where X : IGeometry
    {
        bool TryUpdate(T input, out X output);
    }
}

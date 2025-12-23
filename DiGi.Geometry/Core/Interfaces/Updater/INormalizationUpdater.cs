namespace DiGi.Geometry.Core.Interfaces
{
    public interface INormalizationUpdater<TGeometry> : IGeometryUpdater<TGeometry> where TGeometry : IGeometry
    {
        bool Normalized();
    }
}

namespace DiGi.Geometry.Core.Interfaces
{
    public interface IInternalPointSolver<TGeometry, TPoint> : IGeometrySolver, IOneToManyGeometrySolver<TGeometry, TPoint> where TPoint : IPoint where TGeometry : IGeometry
    {
        int MaxCount { get; set; }
    }
}
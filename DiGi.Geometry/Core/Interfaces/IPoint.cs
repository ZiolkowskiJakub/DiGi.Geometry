namespace DiGi.Geometry.Core.Interfaces
{
    public interface IPoint : IGeometry
    {
    }

    public interface IPoint<T> : IPoint where T : IPoint
    {
        double Distance(T point);

        T Mid(T point);
    }
}

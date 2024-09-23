namespace DiGi.Geometry.Core.Interfaces
{
    public interface IPoint : IGeometry
    {
    }

    public interface IPoint<T> : IPoint where T : IPoint
    {
        bool InDistance(T point, double distance, double tolerance = DiGi.Core.Constans.Tolerance.Distance);
        
        double Distance(T point);

        T Mid(T point);
    }
}

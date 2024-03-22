namespace DiGi.Geometry.Core.Interfaces
{
    public interface IBoundingBox : IGeometry
    {

    }

    public interface IBoundingBox<T> : IBoundingBox where T: IPoint
    {
        T Max { get; }

        T Min { get; }

    }
}

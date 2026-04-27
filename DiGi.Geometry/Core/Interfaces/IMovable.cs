namespace DiGi.Geometry.Core.Interfaces
{
    public interface IMovable : IGeometry
    {
    }

    public interface IMovable<TVector> : IMovable where TVector : IVector
    {
        bool Move(TVector vector);
    }
}
namespace DiGi.Geometry.Core.Interfaces
{
    public interface ISegment : IGeometry, IInvertible, ICurve
    {
    }

    public interface ISegment<T> : ISegment where T : IPoint<T>
    {
        public T Start { get; }

        public T End { get; }
    }
}

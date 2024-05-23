using DiGi.Core.Interfaces;

namespace DiGi.Geometry.Core.Interfaces
{
    public interface IIntersectionResult : ISerializableResult
    {
        bool Intersect { get; }
    }
}

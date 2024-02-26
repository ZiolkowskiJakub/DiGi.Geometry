using DiGi.Core.Interfaces;

namespace DiGi.Geometry.Core.Interfaces
{
    public interface IIntersectionResult : ISerializableObject
    {
        bool Intersect { get; }
    }
}

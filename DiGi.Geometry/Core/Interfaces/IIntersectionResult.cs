using DiGi.Core.Interfaces;

namespace DiGi.Geometry.Core.Interfaces
{
    public interface IIntersectionResult : ISerializableResult
    {
        /// <summary>
        /// Determines whether an intersection exists.
        /// </summary>
        /// <returns><c>true</c> if any geometries are present; otherwise, <c>false</c>.</returns>
        bool Any();
    }
}
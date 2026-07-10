using DiGi.Core.Interfaces;

namespace DiGi.Geometry.Core.Interfaces
{
    public interface IBooleanOperationResult : ISerializableResult
    {
        /// <summary>
        /// Determines whether boolean operation geometries exist.
        /// </summary>
        /// <returns><c>true</c> if any geometries are present; otherwise, <c>false</c>.</returns>
        bool Any();
    }
}
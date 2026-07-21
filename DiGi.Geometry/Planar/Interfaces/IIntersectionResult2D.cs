using DiGi.Geometry.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar.Interfaces
{
    /// <summary>
    /// Defines a contract for a 2D intersection operation result.
    /// </summary>
    public interface IIntersectionResult2D : IIntersectionResult
    {
        /// <summary>
        /// Retrieves a list of 2D geometries of the specified type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of geometry to retrieve, which must implement the <see cref="IGeometry2D"/> interface.</typeparam>
        /// <returns>A list of geometries of type <typeparamref name="T"/>, or <see langword="null"/> if no geometries are present.</returns>
        List<T>? GetGeometry2Ds<T>() where T : IGeometry2D;
    }
}
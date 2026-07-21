using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Enums;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar.Interfaces
{
    /// <summary>
    /// Defines a contract for a 2D boolean operation result.
    /// </summary>
    public interface IBooleanOperationResult2D : ISerializableResult
    {
        /// <summary>
        /// Gets the type of the boolean operation.
        /// </summary>
        BooleanOpertaionType BooleanOpertaionType { get; }

        /// <summary>
        /// Determines whether any 2D geometries are present in the result.
        /// </summary>
        /// <returns><c>true</c> if any geometries are present; otherwise, <c>false</c>.</returns>
        bool Any();

        /// <summary>
        /// Gets the total number of 2D geometries in the result.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Gets the 2D geometry at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the geometry to retrieve.</param>
        /// <returns>The <see cref="IGeometry2D"/> at the specified index, or <see langword="null"/> if the index is out of range.</returns>
        IGeometry2D? this[int index] { get; }

        /// <summary>
        /// Retrieves a list of 2D geometries of the specified type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of geometry to retrieve, which must implement the <see cref="IGeometry2D"/> interface.</typeparam>
        /// <returns>A list of geometries of type <typeparamref name="T"/>, or <see langword="null"/> if no geometries are present.</returns>
        List<T>? GetGeometry2Ds<T>() where T : IGeometry2D;

        /// <summary>
        /// Determines whether the result contains any geometry of type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of geometry to search for, which must implement the <see cref="IGeometry2D"/> interface.</typeparam>
        /// <returns><c>true</c> if an object of type <typeparamref name="T"/> is present; otherwise, <c>false</c>.</returns>
        bool Contains<T>() where T : IGeometry2D;
    }
}
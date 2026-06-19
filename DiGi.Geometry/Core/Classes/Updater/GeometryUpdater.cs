using DiGi.Geometry.Core.Interfaces;

namespace DiGi.Geometry.Core.Classes
{
    /// <summary>
    /// Provides an abstract base class for updating a geometry object of type <typeparamref name="TGeometry"/>.
    /// </summary>
    /// <typeparam name="TGeometry">The type of geometry to be updated, which must implement the <see cref="IGeometry"/>.</typeparam>
    public abstract class GeometryUpdater<TGeometry> : IGeometryUpdater<TGeometry> where TGeometry : IGeometry
    {
        /// <summary>
        /// Gets or sets the geometry value of type <typeparamref name="TGeometry"/>.
        /// </summary>
        public TGeometry? Value { get; set; }

        /// <summary>
        /// Updates the state of the object.
        /// </summary>
        /// <returns>A <see cref="bool"/> value indicating whether the update was successful.</returns>
        public abstract bool Update();
    }
}
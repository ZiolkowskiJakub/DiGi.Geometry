using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Planar.Classes
{
    /// <summary>
    /// Represents a base class for all two-dimensional geometric objects.
    /// </summary>
    public abstract class Geometry2D : SerializableObject, ICollectable2D
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Geometry2D"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing geometry data.</param>
        public Geometry2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Geometry2D"/> class.
        /// </summary>
        public Geometry2D()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Geometry2D"/> class by cloning an existing geometry.
        /// </summary>
        /// <param name="geometry2D">The source geometry to clone.</param>
        public Geometry2D(Geometry2D? geometry2D)
            : base(geometry2D)
        {
        }

        /// <summary>
        /// Moves the geometry by the specified vector.
        /// </summary>
        /// <param name="vector2D">The translation vector.</param>
        /// <returns>True if the move was successful.</returns>
        public abstract bool Move(Vector2D? vector2D);

        /// <summary>
        /// Transforms the geometry using the specified transformation.
        /// </summary>
        /// <param name="transform">The transformation to apply.</param>
        /// <returns>True if the transformation was successful.</returns>
        public abstract bool Transform(ITransform2D? transform);
    }
}
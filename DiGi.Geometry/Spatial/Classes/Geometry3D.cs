using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents an abstract base class for 3D geometry objects.
    /// </summary>
    /// <summary>
    /// Initializes a new instance of the <see cref="Geometry3D"/> class using the specified <see cref="JsonObject"/>.
    /// </summary>
    /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the object.</param>
    /// <summary>
    /// Initializes a new instance of the <see cref="Geometry3D"/> class.
    /// </summary>
    /// <summary>
    /// Initializes a new instance of the <see cref="Geometry3D"/> class by copying an existing <see cref="Geometry3D"/> object.
    /// </summary>
    /// <param name="geometry3D">The <see cref="Geometry3D"/> object to copy from.</param>
    /// <summary>
    /// Moves the 3D geometry by the specified <see cref="Vector3D"/>.
    /// </summary>
    /// <param name="vector3D">The <see cref="Vector3D"/> representing the translation vector.</param>
    /// <returns>A <see cref="bool"/> value indicating whether the move operation was successful.</returns>
    public abstract class Geometry3D : SerializableObject, IGeometry3D
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Geometry3D"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the instance.</param>
        public Geometry3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Geometry3D"/> class.
        /// </summary>
        public Geometry3D()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Geometry3D"/> class using the specified <see cref="Geometry3D"/> instance.
        /// </summary>
        /// <param name="geometry3D">The <see cref="Geometry3D"/> instance to copy from.</param>
        public Geometry3D(Geometry3D? geometry3D)
            : base(geometry3D)
        {
        }

        /// <summary>
        /// Moves the object by the specified <see cref="Vector3D"/>.
        /// </summary>
        /// <param name="vector3D">The optional <see cref="Vector3D"/> representing the displacement vector.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the move operation was successful.</returns>
        public abstract bool Move(Vector3D? vector3D);
    }
}
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Core.Classes
{
    /// <summary>
    /// Represents an abstract collection of geometry objects that implements the <see cref="IGeometryCollection{T}"/> interface.
    /// </summary>
    /// <typeparam name="T">The type of elements in the collection, which must implement <see cref="ICollectable"/>.</typeparam>
    public abstract class GeometryCollection<T> : SerializableObjectCollection<T>, IGeometryCollection<T> where T : ICollectable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeometryCollection{T}"/> class.
        /// </summary>
        public GeometryCollection()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeometryCollection{T}"/> class using the specified collection of items.
        /// </summary>
        /// <param name="collectables">An <see cref="IEnumerable{T}"/> containing the items to be added to the geometry collection.</param>
        public GeometryCollection(IEnumerable<T>? collectables)
            : base(collectables)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeometryCollection{T}"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the collection.</param>
        public GeometryCollection(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeometryCollection{T}"/> class using the specified <see cref="GeometryCollection{T}"/> object.
        /// </summary>
        /// <param name="geometryCollection">The <see cref="GeometryCollection{T}"/> object to copy from. This value can be null.</param>
        public GeometryCollection(GeometryCollection<T>? geometryCollection)
            : base(geometryCollection)
        {
        }

        /// <summary>
        /// Creates a deep copy of the current object by converting it to a <see cref="JsonObject"/> and recreating it as an <see cref="ISerializableObject"/>.
        /// </summary>
        /// <returns>A new <see cref="ISerializableObject"/> instance that is a clone of the current object, or <see langword="null"/> if the conversion to <see cref="JsonObject"/> fails.</returns>
        public override ISerializableObject? Clone()
        {
            JsonObject? jsonObject = ToJsonObject();
            if (jsonObject == null)
            {
                return null;
            }

            return DiGi.Core.Create.SerializableObject<ISerializableObject>(jsonObject);
        }
    }
}
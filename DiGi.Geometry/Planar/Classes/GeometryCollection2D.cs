using DiGi.Geometry.Core.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Planar.Classes
{
    public class GeometryCollection2D : GeometryCollection<ICollectable2D>, IGeometryCollection2D
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeometryCollection2D"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing collection data.</param>
        public GeometryCollection2D(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeometryCollection2D"/> class.
        /// </summary>
        public GeometryCollection2D()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeometryCollection2D"/> class from a collection of geometries.
        /// </summary>
        /// <param name="collectable2Ds">The collection of geometries.</param>
        public GeometryCollection2D(IEnumerable<ICollectable2D> collectable2Ds)
            : base(collectable2Ds)
        {
        }

        /// <summary>
        /// Moves all geometries in the collection by the specified vector.
        /// </summary>
        /// <param name="vector2D">The translation vector.</param>
        /// <returns>True if the move was successful.</returns>
        public bool Move(Vector2D vector2D)
        {
            if (vector2D == null)
            {
                return false;
            }

            foreach (ICollectable2D collectable2D in this)
            {
                collectable2D?.Move(vector2D);
            }

            return true;
        }

        /// <summary>
        /// Transforms all geometries in the collection using the specified transformation.
        /// </summary>
        /// <param name="transform">The transformation to apply.</param>
        /// <returns>True if the transformation was successful.</returns>
        public bool Transform(ITransform2D transform)
        {
            if (transform == null)
            {
                return false;
            }

            foreach (ICollectable2D collectable2D in this)
            {
                collectable2D?.Transform(transform);
            }

            return true;
        }
    }
}
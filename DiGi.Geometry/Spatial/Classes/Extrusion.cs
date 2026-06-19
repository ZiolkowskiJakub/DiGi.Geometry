using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents an abstract base class for a 3D geometry created by extruding a surface along a specific vector.
    /// </summary>
    /// <typeparam name="TSurface3D">The type of the surface being extruded, which must implement <see cref="ISurface3D"/>.</typeparam>
    public abstract class Extrusion<TSurface3D> : Geometry3D, IBoundable3D where TSurface3D : ISurface3D
    {
        [JsonInclude, JsonPropertyName("Surface")]
        private readonly TSurface3D? surface;

        [JsonInclude, JsonPropertyName("Vector")]
        private readonly Vector3D? vector;

        /// <summary>
        /// Initializes a new instance of the <see cref="Extrusion{TSurface3D}"/> class by cloning an existing <see cref="Extrusion{TSurface3D}"/> object.
        /// </summary>
        /// <param name="extrusion">The <see cref="Extrusion{TSurface3D}"/> object to clone from.</param>
        public Extrusion(Extrusion<TSurface3D>? extrusion)
            : base(extrusion)
        {
            if (extrusion is not null)
            {
                surface = DiGi.Core.Query.Clone(extrusion.surface);
                vector = DiGi.Core.Query.Clone(extrusion.vector);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Extrusion{TSurface3D}"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the extrusion.</param>
        public Extrusion(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Extrusion{TSurface3D}"/> class with the specified <typeparamref name="TSurface3D"/> surface and <see cref="Vector3D"/> vector.
        /// </summary>
        /// <param name="surface">The <typeparamref name="TSurface3D"/> surface to extrude.</param>
        /// <param name="vector">The <see cref="Vector3D"/> vector defining the extrusion direction and distance.</param>
        public Extrusion(TSurface3D? surface, Vector3D? vector)
            : base()
        {
            if (surface is not null)
            {
                this.surface = DiGi.Core.Query.Clone(surface);
                this.vector = DiGi.Core.Query.Clone(vector);
            }
        }

        /// <summary>
        /// Gets the 3D surface.
        /// </summary>
        /// <value>
        /// The <typeparamref name="TSurface3D"/> instance representing the surface, or null if it is not defined.
        /// </value>
        [JsonIgnore]
        public TSurface3D? Surface
        {
            get
            {
                return DiGi.Core.Query.Clone(surface);
            }
        }

        /// <summary>
        /// Gets the associated <see cref="Vector3D"/>.
        /// </summary>
        /// <value>
        /// A <see cref="Vector3D"/> object, or null if no vector is defined.
        /// </value>
        [JsonIgnore]
        public Vector3D? Vector
        {
            get
            {
                return DiGi.Core.Query.Clone(vector);
            }
        }

        /// <summary>
        /// Calculates the bounding box of the object, incorporating the surface and any associated vector points.
        /// </summary>
        /// <returns>A <see cref="BoundingBox3D"/> representing the calculated bounding box, or <see langword="null"/> if no bounding box is available.</returns>
        public BoundingBox3D? GetBoundingBox()
        {
            BoundingBox3D? result = surface?.GetBoundingBox();
            if (result is null)
            {
                return result;
            }

            if (vector != null && result.GetPoints() is List<Point3D> point3Ds)
            {
                foreach (Point3D point3D in point3Ds)
                {
                    result.Add(point3D);
                }
            }

            return result;
        }

        /// <summary>
        /// Moves the object by the specified Vector3D? vector.
        /// </summary>
        /// <param name="vector3D">The Vector3D? value representing the displacement.</param>
        /// <returns>A bool indicating whether the move operation was successful.</returns>
        public override bool Move(Vector3D? vector3D)
        {
            if (surface is null)
            {
                return false;
            }

            return surface.Move(vector);
        }
    }
}
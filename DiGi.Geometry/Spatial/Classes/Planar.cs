using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Enums;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents an abstract 3D geometry that exists on a plane and is associated with a corresponding 2D geometry of type <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The type of the 2D geometry, which must implement the <see cref="IGeometry2D"/> interface.</typeparam>
    public abstract class Planar<T> : Geometry3D, IPlanar<T>, IFlippable where T : IGeometry2D
    {
        [JsonInclude, JsonPropertyName("Geometry2D")]
        protected T? geometry2D;

        [JsonInclude, JsonPropertyName("Plane")]
        protected Plane? plane;

        /// <summary>
        /// Initializes a new instance of the <see cref="Planar{T}"/> class using the specified <see cref="Plane"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used to initialize the planar object.</param>
        public Planar(Plane? plane)
            : base()
        {
            this.plane = plane == null ? null : new(plane);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Planar{T}"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the instance.</param>
        public Planar(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Planar{T}"/> class by cloning an existing <see cref="Planar{T}"/> instance.
        /// </summary>
        /// <param name="planar">The source <see cref="Planar{T}"/> instance to copy from.</param>
        public Planar(Planar<T>? planar)
            : base(planar)
        {
            if (planar != null)
            {
                plane = DiGi.Core.Query.Clone(planar.plane);
                geometry2D = DiGi.Core.Query.Clone(planar.geometry2D);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Planar{T}"/> class.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> that defines the planar surface.</param>
        /// <param name="geometry2D">The 2D geometry of type <typeparam ref="T"/> to be associated with this instance.</param>
        public Planar(Plane? plane, T? geometry2D)
            : base()
        {
            this.plane = plane == null ? null : new(plane);
            this.geometry2D = DiGi.Core.Query.Clone(geometry2D);
        }

        /// <summary> Gets the 2D geometry representation. </summary>
        [JsonIgnore]
        public T? Geometry2D
        {
            get
            {
                return DiGi.Core.Query.Clone(geometry2D);
            }
        }

        /// <summary>
        /// Gets the <see cref="Plane"/> associated with this object.
        /// </summary>
        /// <value>
        /// A <see cref="Plane"/> instance if one exists; otherwise, null.
        /// </value>
        [JsonIgnore]
        public Plane? Plane
        {
            get
            {
                return plane == null ? null : new(plane);
            }
        }

        /// <summary>
        /// Flips the orientation of the plane based on the specified primary and secondary axes.
        /// </summary>
        /// <param name="prmiaryAxis">The <see cref="SpatialAxis"/> representing the primary axis for the flip operation.</param>
        /// <param name="secondaryAxis">The <see cref="SpatialAxis"/> representing the secondary axis for the flip operation.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the flip operation was successful.</returns>
        public bool Flip(SpatialAxis prmiaryAxis = SpatialAxis.Z, SpatialAxis secondaryAxis = SpatialAxis.X)
        {
            if (plane is null)
            {
                return false;
            }

            bool result = plane.Flip(prmiaryAxis, secondaryAxis);

            if (result)
            {
            }

            return result;
        }

        /// <summary>
        /// Moves the object based on the provided Vector3D vector.
        /// </summary>
        /// <param name="vector3D">The optional Vector3D value specifying the direction and distance to move.</param>
        /// <returns>A boolean value indicating whether the movement was successful.</returns>
        public override bool Move(Vector3D? vector3D)
        {
            if (vector3D == null || plane == null)
            {
                return false;
            }

            return plane.Move(vector3D);
        }
    }
}


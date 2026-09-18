using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Enums;
using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Math.Classes;
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

        /// <summary>
        /// Initializes a new instance of the <see cref="Planar{T}"/> class from a prebuilt plane and 2D geometry.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> that defines the planar surface.</param>
        /// <param name="geometry2D">The 2D geometry of type <typeparamref name="T"/> to be associated with this instance.</param>
        /// <param name="clone">When <see langword="true"/>, the inputs are defensively cloned; when <see langword="false"/>, the supplied instances are adopted directly without cloning. Use <see langword="false"/> only when the caller owns freshly created instances that are not shared.</param>
        internal Planar(Plane? plane, T? geometry2D, bool clone)
            : base()
        {
            if (clone)
            {
                this.plane = plane == null ? null : new(plane);
                this.geometry2D = DiGi.Core.Query.Clone(geometry2D);
                return;
            }

            this.plane = plane;
            this.geometry2D = geometry2D;
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
        /// Flips the orientation of the plane based on the specified primary and secondary axes, keeping the geometry where it is.
        /// <para>The 2D geometry is held in the plane's own axes, so flipping the plane alone would mirror or turn the geometry in space. The geometry is therefore re-expressed in the flipped axes, which reverses its winding as seen from the new normal, so that every 3D point stays where it was: a face flipped twice is the face it started as.</para>
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

            Vector3D? axisX_Before = plane.AxisX;
            Vector3D? axisY_Before = plane.AxisY;

            if (!plane.Flip(prmiaryAxis, secondaryAxis))
            {
                return false;
            }

            if (geometry2D is null || axisX_Before is null || axisY_Before is null)
            {
                return true;
            }

            Vector3D? axisX_After = plane.AxisX;
            Vector3D? axisY_After = plane.AxisY;
            if (axisX_After is null || axisY_After is null)
            {
                return true;
            }

            // The origin does not move, so the new 2D coordinates of a point are its old ones projected onto the new axes.
            Matrix3D matrix3D = Math.Create.Matrix3D.Identity();
            matrix3D[0, 0] = axisX_Before * axisX_After;
            matrix3D[0, 1] = axisY_Before * axisX_After;
            matrix3D[1, 0] = axisX_Before * axisY_After;
            matrix3D[1, 1] = axisY_Before * axisY_After;

            return geometry2D.Transform(new Transform2D(matrix3D));
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
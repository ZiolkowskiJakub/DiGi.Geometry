using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents a three-dimensional coordinate system defined by an origin and axes.
    /// </summary>
    /// <summary>
    /// Initializes a new instance of the <see cref="CoordinateSystem3D"/> class using the provided <see cref="JsonObject"/>.
    /// </summary>
    /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data to initialize the coordinate system.</param>
    /// <summary>
    /// Initializes a new instance of the <see cref="CoordinateSystem3D"/> class by copying an existing <see cref="CoordinateSystem3D"/> instance.
    /// </summary>
    /// <param name="coordinateSystem3D">The <see cref="CoordinateSystem3D"/> instance to copy from.</param>
    public class CoordinateSystem3D : Geometry3D, ICoordinateSystem3D
    {
        [JsonInclude, JsonPropertyName("AxisY")]
        private readonly Vector3D? axisY;

        [JsonInclude, JsonPropertyName("AxisZ")]
        private readonly Vector3D? axisZ;

        [JsonInclude, JsonPropertyName("Origin")]
        private Point3D? origin;

        /// <summary>
        /// Initializes a new instance of the <see cref="CoordinateSystem3D"/> class using the provided <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data used to initialize this instance.</param>
        public CoordinateSystem3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoordinateSystem3D"/> class by copying the properties from an existing <see cref="CoordinateSystem3D"/> object.
        /// </summary>
        /// <param name="coordinateSystem3D">The source <see cref="CoordinateSystem3D"/> object to copy data from.</param>
        public CoordinateSystem3D(CoordinateSystem3D? coordinateSystem3D)
        {
            if (coordinateSystem3D != null)
            {
                axisZ = new Vector3D(coordinateSystem3D.axisZ);
                origin = new Point3D(coordinateSystem3D.origin);
                axisY = new Vector3D(coordinateSystem3D.axisY);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoordinateSystem3D"/> class using the axes from an existing <see cref="CoordinateSystem3D"/> and a specified <see cref="Point3D"/> as the origin.
        /// </summary>
        /// <param name="coordinateSystem3D">The <see cref="CoordinateSystem3D"/> from which to copy the axis vectors.</param>
        /// <param name="origin">The <see cref="Point3D"/> that defines the origin of the coordinate system.</param>
        public CoordinateSystem3D(CoordinateSystem3D? coordinateSystem3D, Point3D? origin)
        {
            if (coordinateSystem3D != null)
            {
                axisZ = new Vector3D(coordinateSystem3D.axisZ);
                axisY = new Vector3D(coordinateSystem3D.axisY);
            }

            if (origin != null)
            {
                this.origin = new Point3D(origin);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoordinateSystem3D"/> class with the specified origin and Z-axis.
        /// </summary>
        /// <param name="origin">The optional <see cref="Point3D"/> that defines the origin of the coordinate system.</param>
        /// <param name="axisZ">The optional <see cref="Vector3D"/> that defines the direction of the Z-axis.</param>
        public CoordinateSystem3D(Point3D? origin, Vector3D? axisZ)
        {
            if (axisZ != null)
            {
                this.axisZ = axisZ.Unit;
                axisY = axisZ.AxisY();
            }

            if (origin != null)
            {
                this.origin = new Point3D(origin);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoordinateSystem3D"/> class using the specified origin, X-axis, and Y-axis.
        /// </summary>
        /// <param name="origin">The <see cref="Point3D"/> representing the origin of the coordinate system.</param>
        /// <param name="axisX">The <see cref="Vector3D"/> representing the direction of the X-axis.</param>
        /// <param name="axisY">The <see cref="Vector3D"/> representing the direction of the Y-axis.</param>
        public CoordinateSystem3D(Point3D? origin, Vector3D? axisX, Vector3D? axisY)
        {
            this.origin = origin == null ? null : new Point3D(origin);

            this.axisY = axisY?.Unit;

            if (axisX != null && this.axisY != null)
            {
                axisZ = Query.Normal(axisX.Unit, this.axisY);
            }
        }

        /// <summary>
        /// Gets the X-axis vector.
        /// </summary>
        /// <value>
        /// A <see cref="Vector3D"/> representing the X-axis, or null if it is not defined.
        /// </value>
        [JsonIgnore]
        public Vector3D? AxisX
        {
            get
            {
                return Query.AxisX(axisZ, axisY);
            }
        }

        /// <summary>
        /// Gets the Y-axis vector.
        /// </summary>
        /// <value>A <see cref="Vector3D"/> representing the Y-axis, or null if it is not defined.</value>
        [JsonIgnore]
        public Vector3D? AxisY
        {
            get
            {
                return axisY == null ? null : new Vector3D(axisY);
            }
        }

        /// <summary>
        /// Gets the Z-axis vector.
        /// </summary>
        /// <value>
        /// A <see cref="Vector3D"/> representing the Z-axis, or null if it is not defined.
        /// </value>
        [JsonIgnore]
        public Vector3D? AxisZ
        {
            get
            {
                return axisZ == null ? null : new Vector3D(axisZ);
            }
        }

        /// <summary>
        /// Gets or sets the origin <see cref="Point3D"/>.
        /// </summary>
        [JsonIgnore]
        public Point3D? Origin
        {
            get
            {
                return origin == null ? null : new Point3D(origin);
            }
            set
            {
                origin = value;
            }
        }

        /// <summary>
        /// Calculates the closest point on the line to the specified <see cref="Point3D"/>.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> for which the closest point is calculated.</param>
        /// <returns>The closest <see cref="Point3D"/> on the line, or null if the provided <see cref="Point3D"/>, origin, or axis Z is null.</returns>
        public Point3D? ClosestPoint(Point3D? point3D)
        {
            if (point3D is null || origin is null || axisZ is null)
            {
                return null;
            }

            double factor = ((Vector3D)point3D!).DotProduct(axisZ) - axisZ.DotProduct((Vector3D)origin!);
            return new Point3D(point3D.X - (axisZ.X * factor), point3D.Y - (axisZ.Y * factor), point3D.Z - (axisZ.Z * factor));
        }

        /// <summary>
        /// Calculates the distance between the specified <see cref="Point3D"/> and the closest point on this object.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> to calculate the distance from.</param>
        /// <returns>The distance as a <see cref="double"/>, or <see cref="double.NaN"/> if no closest point is found.</returns>
        public double Distance(Point3D? point3D)
        {
            Point3D? closestPoint = ClosestPoint(point3D);
            if (closestPoint is null)
            {
                return double.NaN;
            }

            return closestPoint.Distance(point3D);
        }

        /// <summary>
        /// Retrieves the <see cref="Vector3D"/> associated with the specified <see cref="Enums.SpatialAxis"/>.
        /// </summary>
        /// <param name="axis">The <see cref="Enums.SpatialAxis"/> to retrieve.</param>
        /// <returns>A <see cref="Vector3D"/> representing the axis, or null if the axis is undefined or invalid.</returns>
        public Vector3D? GetAxis(Enums.SpatialAxis axis)
        {
            return axis switch
            {
                Enums.SpatialAxis.X => AxisX,

                Enums.SpatialAxis.Y => AxisY,

                Enums.SpatialAxis.Z => AxisZ,

                Enums.SpatialAxis.Undefined => null,

                _ => null,
            };
        }

        /// <summary>
        /// Inverts the direction of the Z and Y axes.
        /// </summary>
        public void Inverse()
        {
            axisZ?.Inverse();
            axisY?.Inverse();
        }

        /// <summary>
        /// Moves the object using the specified Vector3D? vector.
        /// </summary>
        /// <param name="vector3D">The Vector3D? value representing the displacement.</param>
        /// <returns>A bool indicating whether the move operation was successful.</returns>
        public override bool Move(Vector3D? vector3D)
        {
            if (vector3D == null || origin == null)
            {
                return false;
            }

            origin.Move(vector3D);
            return true;
        }
    }
}
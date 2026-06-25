using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents a plane in 3D space, inheriting from <see cref="Geometry3D"/> and implementing <see cref="IFlippable"/>.
    /// </summary>
    public class Plane : Geometry3D, IFlippable
    {
        [JsonInclude, JsonPropertyName("AxisY")]
        private Vector3D? axisY;

        [JsonInclude, JsonPropertyName("Normal")]
        private Vector3D? normal;

        [JsonInclude, JsonPropertyName("Origin")]
        private Point3D? origin;

        /// <summary>
        /// Initializes a new instance of the <see cref="Plane"/> class using the provided <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data used to initialize the plane.</param>
        public Plane(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Plane"/> class by copying the values from an existing <see cref="Plane"/> object.
        /// </summary>
        /// <param name="plane">The source <see cref="Plane"/> object to copy data from. If null, the current instance remains uninitialized.</param>
        public Plane(Plane? plane)
        {
            if (plane != null)
            {
                normal = plane.normal == null ? null : new Vector3D(plane.normal);
                origin = plane.origin == null ? null : new Point3D(plane.origin);
                axisY = plane.axisY == null ? null : new Vector3D(plane.axisY);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Plane"/> class using an existing <see cref="Plane"/> for orientation and an optional <see cref="Point3D"/> for the origin.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> object to copy the normal and axisY vectors from. Can be null.</param>
        /// <param name="origin">The <see cref="Point3D"/> object to set as the origin of the plane. Can be null.</param>
        public Plane(Plane? plane, Point3D? origin)
        {
            if (plane != null)
            {
                normal = plane.normal == null ? null : new Vector3D(plane.normal);
                axisY = plane.axisY == null ? null : new Vector3D(plane.axisY);
            }

            if (origin != null)
            {
                this.origin = new Point3D(origin);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Plane"/> class using three points to define the plane's origin and orientation.
        /// </summary>
        /// <param name="point3D_1">The first <c>Point3D?</c>, which is used as the origin of the plane.</param>
        /// <param name="point3D_2">The second <c>Point3D?</c> used to determine the normal vector of the plane.</param>
        /// <param name="point3D_3">The third <c>Point3D?</c> used to determine the normal vector of the plane.</param>
        public Plane(Point3D? point3D_1, Point3D? point3D_2, Point3D? point3D_3)
        {
            if (point3D_1 is not null)
            {
                origin = new Point3D(point3D_1);
            }

            normal = Query.Normal(point3D_1, point3D_2, point3D_3);

            if (normal is not null)
            {
                axisY = normal.AxisY();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Plane"/> class using the specified origin point and normal vector.
        /// </summary>
        /// <param name="origin">The optional <see cref="Point3D"/> that defines the origin of the plane.</param>
        /// <param name="normal">The optional <see cref="Vector3D"/> that defines the normal vector of the plane.</param>
        public Plane(Point3D? origin, Vector3D? normal)
        {
            if (normal != null)
            {
                this.normal = normal.Unit;
                axisY = normal.AxisY();
            }

            if (origin != null)
            {
                this.origin = new Point3D(origin);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Plane"/> class using an origin point and two basis vectors.
        /// </summary>
        /// <param name="origin">The <c>Point3D?</c> representing the origin point of the plane.</param>
        /// <param name="axisX">The <c>Vector3D?</c> representing the X-axis vector of the plane.</param>
        /// <param name="axisY">The <see cref="Vector3D"/> representing the Y-axis vector of the plane.</param>
        public Plane(Point3D? origin, Vector3D? axisX, Vector3D? axisY)
        {
            this.origin = origin == null ? null : new Point3D(origin);

            this.axisY = axisY?.Unit;

            if (axisX != null && this.axisY != null)
            {
                normal = Query.Normal(axisX.Unit, this.axisY);
            }
        }

        /// <summary>
        /// A factor for point-normal equation A(x−a)+B(y−b)+C(z−c) = 0 where origin(a,b,c), normal(A,B,C)
        /// </summary>
        /// <value>A value for point-normal equation</value>
        [JsonIgnore]
        public double A
        {
            get
            {
                if (normal is null)
                {
                    return double.NaN;
                }

                return normal.X;
            }
        }

        /// <summary>
        /// Gets the X-axis vector of the coordinate system.
        /// </summary>
        /// <value>
        /// A <see cref="Vector3D"/> representing the X-axis, or null if it cannot be determined.
        /// </value>
        [JsonIgnore]
        public Vector3D? AxisX
        {
            get
            {
                return Query.AxisX(normal, axisY);
            }
        }

        /// <summary>
        /// Gets the Y-axis as a <see cref="Vector3D"/>.
        /// </summary>
        /// <value>
        /// A <see cref="Vector3D"/> representing the Y-axis, or null if it is not defined.
        /// </value>
        [JsonIgnore]
        public Vector3D? AxisY
        {
            get
            {
                return axisY == null ? null : new(axisY);
            }
        }

        /// <summary>
        /// Gets the Z-axis vector derived from the normal.
        /// </summary>
        /// <value>A <see cref="Vector3D"/> representing the Z-axis if the normal is defined; otherwise, null.</value>
        [JsonIgnore]
        public Vector3D? AxisZ
        {
            get
            {
                return normal == null ? null : new(normal);
            }
        }

        /// <summary>
        /// B factor for point-normal equation A(x−a)+B(y−b)+C(z−c) = 0 where origin(a,b,c), normal(A,B,C)
        /// </summary>
        /// <value>B value for point-normal equation</value>
        [JsonIgnore]
        public double B
        {
            get
            {
                if (normal is null)
                {
                    return double.NaN;
                }

                return normal.Y;
            }
        }

        /// <summary>
        /// C factor for point-normal equation A(x−a)+B(y−b)+C(z−c) = 0 where origin(a,b,c), normal(A,B,C)
        /// </summary>
        /// <value>C value for point-normal equation</value>
        [JsonIgnore]
        public double C
        {
            get
            {
                if (normal is null)
                {
                    return double.NaN;
                }

                return normal.Z;
            }
        }

        /// <summary>
        /// D factor for point-normal equation Ax+By+Cz = D where origin(a,b,c), normal(A,B,C)
        /// </summary>
        /// <value>D value for point-normal equation</value>
        [JsonIgnore]
        public double D
        {
            get
            {
                if (normal is null || origin is null)
                {
                    return double.NaN;
                }

                return -(normal.X * origin.X + normal.Y * origin.Y + normal.Z * origin.Z);
            }
        }

        /// <summary>
        /// Scalar constant relating origin point to normal vector.
        /// </summary>
        [JsonIgnore]
        public double K
        {
            get
            {
                if (normal is null || origin is null)
                {
                    return double.NaN;
                }

                return normal.DotProduct((Vector3D)origin!);
            }
        }

        /// <summary>
        /// Gets the normal vector of the object.
        /// </summary>
        /// <value>
        /// A <see cref="Vector3D"/> representing the normal vector, or null if it is not defined.
        /// </value>
        [JsonIgnore]
        public Vector3D? Normal
        {
            get
            {
                return normal == null ? null : new(normal);
            }
        }

        /// <summary>
        /// Gets or sets the origin point in 3D space.
        /// </summary>
        /// <value>A <c>Point3D?</c> representing the origin coordinates.</value>
        [JsonIgnore]
        public Point3D? Origin
        {
            get
            {
                return origin == null ? null : new(origin);
            }
            set
            {
                origin = value;
            }
        }

        /// <summary>
        /// Calculates the closest point on the plane to the specified <see cref="Point3D"/>.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> for which the closest point is calculated.</param>
        /// <returns>The closest <see cref="Point3D"/> on the plane, or null if the provided <see cref="Point3D"/> or the plane normal is null.</returns>
        public Point3D? ClosestPoint(Point3D? point3D)
        {
            if (point3D is null || normal is null)
            {
                return null;
            }

            double factor = ((Vector3D)point3D!).DotProduct(normal) - K;
            return new(point3D.X - (normal.X * factor), point3D.Y - (normal.Y * factor), point3D.Z - (normal.Z * factor));
        }

        /// <summary>
        /// Determines whether this plane is coplanar with the specified <see cref="Plane"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> to compare against.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance used for the comparison.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the planes are coplanar.</returns>
        public bool Coplanar(Plane? plane, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (plane?.normal is null || normal is null)
            {
                return false;
            }

            return normal.AlmostEquals(plane?.normal, tolerance) || normal.AlmostEquals(-plane?.normal, tolerance);
        }

        /// <summary>
        /// Calculates the distance between the current object and the specified <see cref="Point3D"/>.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> to calculate the distance to. This value can be null.</param>
        /// <returns>A <see cref="double"/> representing the distance, or <see cref="double.NaN"/> if the provided point is null or a closest point cannot be determined.</returns>
        public double Distance(Point3D? point3D)
        {
            if (point3D is null)
            {
                return double.NaN;
            }

            Point3D? closestPoint = ClosestPoint(point3D);
            if (closestPoint == null)
            {
                return double.NaN;
            }

            return closestPoint.Distance(point3D);
        }

        /// <summary>
        /// Retrieves the <see cref="Vector3D"/> associated with the specified <see cref="Enums.SpatialAxis"/>.
        /// </summary>
        /// <param name="axis">The <see cref="Enums.SpatialAxis"/> to retrieve.</param>
        /// <returns>A <see cref="Vector3D"/> representing the axis, or null if the <see cref="Enums.SpatialAxis"/> is undefined.</returns>
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
        /// Flips the orientation based on the specified primary and secondary spatial axes.
        /// </summary>
        /// <param name="prmiaryAxis">The <see cref="Enums.SpatialAxis"/> representing the primary axis.</param>
        /// <param name="secondaryAxis">The <see cref="Enums.SpatialAxis"/> representing the secondary axis.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the flip operation was successfully performed.</returns>
        public bool Flip(Enums.SpatialAxis prmiaryAxis = Enums.SpatialAxis.Z, Enums.SpatialAxis secondaryAxis = Enums.SpatialAxis.X)
        {
            if (prmiaryAxis == secondaryAxis)
            {
                return false;
            }

            if (prmiaryAxis == Enums.SpatialAxis.Z)
            {
                if (secondaryAxis == Enums.SpatialAxis.X)
                {
                    Vector3D? axisX = AxisX;
                    normal?.Inverse();
                    axisY = normal?.CrossProduct(axisX);

                    return true;
                }
                else if (secondaryAxis == Enums.SpatialAxis.Y)
                {
                    normal?.Inverse();

                    return true;
                }
            }
            else if (prmiaryAxis == Enums.SpatialAxis.Y)
            {
                if (secondaryAxis == Enums.SpatialAxis.X)
                {
                    Vector3D? axisX = AxisX;
                    axisY?.Inverse();
                    normal = Query.Normal(axisX, axisY);

                    return true;
                }
                else if (secondaryAxis == Enums.SpatialAxis.Z)
                {
                    axisY?.Inverse();

                    return true;
                }
            }
            else if (prmiaryAxis == Enums.SpatialAxis.X)
            {
                if (secondaryAxis == Enums.SpatialAxis.Y)
                {
                    Vector3D? axisX = AxisX?.GetInversed();
                    normal = Query.Normal(axisX, axisY);

                    return true;
                }
                else if (secondaryAxis == Enums.SpatialAxis.Z)
                {
                    Vector3D? axisX = AxisX?.GetInversed();
                    axisY = normal?.CrossProduct(axisX);

                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Moves the object by the specified Vector3D? vector.
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
using DiGi.Core;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents a spheroid geometry in 3D space, which is a special case of an ellipsoid where two axes are equal.
    /// </summary>
    /// <summary>
    /// Initializes a new instance of the <see cref="Spheroid"/> class using a center point and axis lengths.
    /// </summary>
    /// <param name="center">The <see cref="Point3D"/> representing the center of the spheroid.</param>
    /// <param name="a">The <see cref="double"/> value for the semi-major axis length.</param>
    /// <param name="b">The <see cref="double"/> value for the semi-minor axis length.</param>
    /// <summary>
    /// Initializes a new instance of the <see cref="Spheroid"/> class using a plane and axis lengths.
    /// </summary>
    /// <param name="plane">The <see cref="Plane"/> defining the orientation and center of the spheroid.</param>
    /// <param name="a">The <see cref="double"/> value for the semi-major axis length.</param>
    /// <param name="b">The <see cref="double"/> value for the semi-minor axis length.</param>
    public class Spheroid : Geometry3D, IEllipsoid
    {
        [JsonInclude, JsonPropertyName("A")]
        private readonly double a;

        [JsonInclude, JsonPropertyName("B")]
        private readonly double b;

        [JsonInclude, JsonPropertyName("Plane")]
        private readonly Plane? plane;

        /// <summary>
        /// Initializes a new instance of the <see cref="Spheroid"/> class using a specified center point and semi-axis lengths.
        /// </summary>
        /// <param name="center">The <see cref="Point3D"/> that defines the center of the spheroid.</param>
        /// <param name="a">A <see cref="double"/> representing the first semi-axis length.</param>
        /// <param name="b">A <see cref="double"/> representing the second semi-axis length.</param>
        public Spheroid(Point3D? center, double a, double b)
        {
            plane = Create.Plane(center);
            this.a = a;
            this.b = b;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Spheroid"/> class with the specified plane and axis lengths.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> that defines the orientation of the spheroid, or null.</param>
        /// <param name="a">The first semi-axis length as a <see cref="double"/>.</param>
        /// <param name="b">The second semi-axis length as a <see cref="double"/>.</param>
        public Spheroid(Plane? plane, double a, double b)
        {
            this.plane = plane?.Clone<Plane>();
            this.a = a;
            this.b = b;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Spheroid"/> class by copying the properties from an existing <see cref="Spheroid"/> object.
        /// </summary>
        /// <param name="spheroid">The <see cref="Spheroid"/> object to copy data from.</param>
        public Spheroid(Spheroid? spheroid)
            : base(spheroid)
        {
            if (spheroid != null)
            {
                plane = spheroid.plane?.Clone<Plane>();
                a = spheroid.a;
                b = spheroid.b;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Spheroid"/> class.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the current instance.</param>
        public Spheroid(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the double value of A.
        /// </summary>
        [JsonIgnore]
        public double A
        {
            get
            {
                return a;
            }
        }

        /// <summary>
        /// Gets the double value of B.
        /// </summary>
        [JsonIgnore]
        public double B
        {
            get
            {
                return b;
            }
        }

        /// <summary>
        /// Gets the center point of the plane.
        /// </summary>
        /// <value>The <see cref="Point3D"/> representing the center, or null if no plane is defined.</value>
        [JsonIgnore]
        public Point3D? Center
        {
            get
            {
                return plane?.Origin;
            }
        }

        /// <summary>
        /// Gets the primary direction vector (<see cref="Vector3D"/>) representing the X-axis of the plane.
        /// </summary>
        /// <value>The <see cref="Vector3D"/> value of the X-axis, or null if no plane is associated.</value>
        [JsonIgnore]
        public Vector3D? DirectionA
        {
            get
            {
                return plane?.AxisX;
            }
        }

        /// <summary>
        /// Gets the second direction vector, which corresponds to the Y-axis of the associated plane.
        /// </summary>
        /// <value>A nullable <see cref="Vector3D"/> representing the Y-axis of the plane.</value>
        [JsonIgnore]
        public Vector3D? DirectionB
        {
            get
            {
                return plane?.AxisY;
            }
        }

        /// <summary>
        /// Gets the direction vector C, which corresponds to the Z-axis of the plane.
        /// </summary>
        /// <returns>A <see cref="Vector3D"/> representing the Z-axis of the plane, or null if the plane is not defined.</returns>
        [JsonIgnore]
        public Vector3D? DirectionC
        {
            get
            {
                return plane?.AxisZ;
            }
        }

        /// <summary>
        /// Gets the extent of the object. Returns a <see cref="Vector3D"/> if the plane is defined; otherwise, returns null.
        /// </summary>
        /// <value>A <see cref="Vector3D"/> representing the calculated extent, or null.</value>
        [JsonIgnore]
        public Vector3D? Extent
        {
            get
            {
                if (plane is null)
                {
                    return null;
                }

                return (System.Math.Abs(a) * plane.AxisX * a) + (System.Math.Abs(b) * plane.AxisY * b) + (System.Math.Abs(b) * plane.AxisZ * b);
            }
        }

        /// <summary>
        /// Gets the <see cref="Plane"/> associated with this instance.
        /// </summary>
        /// <value>The <see cref="Plane"/>, or <c>null</c> if no plane is defined.</value>
        [JsonIgnore]
        public Plane? Plane
        {
            get
            {
                return plane;
            }
        }

        public static implicit operator Spheroid?(Sphere? sphere)
        {
            return sphere == null ? null : new Spheroid(sphere.Center, sphere.Radius, sphere.Radius);
        }

        /// <summary>
        /// Calculates and returns the 3D bounding box of the object based on its center and extent.
        /// </summary>
        /// <returns>A <see cref="BoundingBox3D"/> representing the bounding box, or <see langword="null"/> if the center or extent is not defined.</returns>
        public BoundingBox3D? GetBoundingBox()
        {
            Vector3D? extent = Extent;
            if (extent is null)
            {
                return null;
            }

            Point3D? center = Center;
            if (center is null)
            {
                return null;
            }

            return new BoundingBox3D(center - Extent, center + Extent);
        }

        /// <summary>
        /// Calculates a point on the surface of the ellipsoid based on the provided spherical coordinates.
        /// </summary>
        /// <param name="theta">The azimuthal angle as a double.</param>
        /// <param name="phi">The polar angle as a double.</param>
        /// <returns>A Point3D? representing the calculated point in 3D space, or null if the plane is not defined.</returns>
        public Point3D? GetPoint(double theta, double phi)
        {
            if (plane is null)
            {
                return null;
            }

            // Unrotated local point on the ellipsoid
            double x = a * System.Math.Sin(phi) * System.Math.Cos(theta);
            double y = b * System.Math.Sin(phi) * System.Math.Sin(theta);
            double z = b * System.Math.Cos(phi);

            // Rotate using basis vectors and translate to center
            return Center + x * plane.AxisX + y * plane.AxisY + z * plane.AxisZ;
        }

        /// <summary>
        /// Calculates the volume of the ellipsoid.
        /// </summary>
        /// <returns>The calculated volume as a <see cref="double"/>.</returns>
        public double GetVolume()
        {
            return (4.0 / 3.0) * System.Math.PI * a * b * b;
        }

        /// <summary>
        /// Determines whether the specified <see cref="Point3D"/> is inside the boundaries of the object within a given tolerance.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> to check.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance used for the boundary calculation.</param>
        /// <returns>A <see cref="bool"/> value indicating <c>true</c> if the point is inside; otherwise, <c>false</c>.</returns>
        public bool Inside(Point3D? point3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point3D == null || plane?.Origin == null)
            {
                return false;
            }

            Vector3D? vector3D = point3D - plane.Origin;
            if (vector3D is null)
            {
                return false;
            }

            double x = vector3D.DotProduct(DirectionA) / a;
            double y = vector3D.DotProduct(DirectionB) / b;

            return x * x + y * y + y * y <= 1.0 + tolerance;
        }

        /// <summary>
        /// Moves the object by the specified Vector3D? vector.
        /// </summary>
        /// <param name="vector3D">The Vector3D? value representing the movement vector.</param>
        /// <returns>True if the move operation was successful; otherwise, false.</returns>
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
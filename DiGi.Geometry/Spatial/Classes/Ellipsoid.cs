using DiGi.Core;
using DiGi.Geometry.Spatial.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents an ellipsoid geometry in 3D space.
    /// </summary>
    /// <summary>
    /// Initializes a new instance of the <see cref="Ellipsoid"/> class.
    /// </summary>
    /// <param name="center">The <see cref="Point3D"/> representing the center point of the ellipsoid.</param>
    /// <param name="a">The <see cref="double"/> value for the semi-axis length along the first axis.</param>
    /// <param name="b">The <see cref="double"/> value for the semi-axis length along the second axis.</param>
    /// <param name="c">The <see cref="double"/> value for the semi-axis length along the third axis.</param>
    public class Ellipsoid : Geometry3D, IEllipsoid
    {
        [JsonInclude, JsonPropertyName("A")]
        private readonly double a;

        [JsonInclude, JsonPropertyName("B")]
        private readonly double b;

        [JsonInclude, JsonPropertyName("C")]
        private readonly double c;

        [JsonInclude, JsonPropertyName("Plane")]
        private readonly Plane? plane;

        /// <summary>
        /// Initializes a new instance of the <see cref="Ellipsoid"/> class with the specified center and semi-axes lengths.
        /// </summary>
        /// <param name="center">The <see cref="Point3D?"/> coordinates of the center point.</param>
        /// <param name="a">The <see cref="double"/> length of the first semi-axis.</param>
        /// <param name="b">The <see cref="double"/> length of the second semi-axis.</param>
        /// <param name="c">The <see cref="double"/> length of the third semi-axis.</param>
        public Ellipsoid(Point3D? center, double a, double b, double c)
        {
            plane = Create.Plane(center);
            this.a = a;
            this.b = b;
            this.c = c;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ellipsoid"/> class with the specified plane and semi-axis lengths.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> that defines the ellipsoid's orientation, or null.</param>
        /// <param name="a">The length of the first semi-axis as a <see cref="double"/>.</param>
        /// <param name="b">The length of the second semi-axis as a <see cref="double"/>.</param>
        /// <param name="c">The length of the third semi-axis as a <see cref="double"/>.</param>
        public Ellipsoid(Plane? plane, double a, double b, double c)
        {
            this.plane = plane?.Clone<Plane>();
            this.a = a;
            this.b = b;
            this.c = c;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ellipsoid"/> class by copying the properties from an existing <see cref="Ellipsoid"/> object.
        /// </summary>
        /// <param name="ellipsoid">The <see cref="Ellipsoid"/> object to copy data from, or null to initialize a default instance.</param>
        public Ellipsoid(Ellipsoid? ellipsoid)
            : base(ellipsoid)
        {
            if (ellipsoid != null)
            {
                plane = ellipsoid.plane?.Clone<Plane>();
                a = ellipsoid.a;
                b = ellipsoid.b;
                c = ellipsoid.c;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ellipsoid"/> class using the provided <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data used to initialize this instance.</param>
        public Ellipsoid(JsonObject? jsonObject)
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
        /// Gets the C constant of the plane equation as a <see cref="double"/>.
        /// </summary>
        [JsonIgnore]
        public double C
        {
            get
            {
                return c;
            }
        }

        /// <summary>
        /// Gets the center point of the plane as a <see cref="Point3D"/>.
        /// </summary>
        [JsonIgnore]
        public Point3D? Center
        {
            get
            {
                return plane?.Origin;
            }
        }

        /// <summary>
        /// Gets the X-axis direction vector of the plane.
        /// </summary>
        /// <value>
        /// A <see cref="Vector3D"/> representing the first direction axis, or null if the plane is not defined.
        /// </value>
        [JsonIgnore]
        public Vector3D? DirectionA
        {
            get
            {
                return plane?.AxisX;
            }
        }

        /// <summary>
        /// Gets the direction vector B, which represents the Y-axis of the associated plane.
        /// </summary>
        /// <value>A <see cref="Vector3D"/> representing the Y-axis of the plane, or null if no plane is defined.</value>
        [JsonIgnore]
        public Vector3D? DirectionB
        {
            get
            {
                return plane?.AxisY;
            }
        }

        /// <summary>
        /// Gets the direction vector for axis C, typically corresponding to the Z-axis of the associated plane.
        /// </summary>
        /// <value>A <see cref="Vector3D"/>? representing the direction of axis C, or null if no plane is defined.</value>
        [JsonIgnore]
        public Vector3D? DirectionC
        {
            get
            {
                return plane?.AxisZ;
            }
        }

        /// <summary>
        /// Gets the extent of the ellipsoid as a <see cref="Vector3D"/>.
        /// </summary>
        /// <value>A <see cref="Vector3D"/> representing the spatial extent, or null if not defined.</value>
        [JsonIgnore]
        public Vector3D? Extent
        {
            get
            {
                return (System.Math.Abs(a) * DirectionA * a) + (System.Math.Abs(b) * DirectionB * b) + (System.Math.Abs(c) * DirectionC * c);
            }
        }

        public static implicit operator Ellipsoid?(Sphere? sphere)
        {
            return sphere == null ? null : new Ellipsoid(sphere.Center, sphere.Radius, sphere.Radius, sphere.Radius);
        }

        public static implicit operator Ellipsoid?(Spheroid? spheroid)
        {
            return spheroid == null ? null : new Ellipsoid(spheroid.Plane, spheroid.A, spheroid.B, spheroid.B);
        }

        /// <summary>
        /// Calculates the bounding box of the object based on its center and extent.
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

            return new(center - extent, center + extent);
        }

        /// <summary>
        /// Calculates the focal points of the object.
        /// </summary>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used for calculations.</param>
        /// <returns>An array of <see cref="Point3D"/> objects representing the focal points, or <see langword="null"/> if the center or directions are not defined.</returns>
        public Point3D[]? GetFocalPoints(double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            Point3D? center = Center;
            if (center is null)
            {
                return null;
            }

            Vector3D? directionA = DirectionA;
            if (directionA is null)
            {
                return null;
            }

            Vector3D? directionB = DirectionB;
            if (directionB is null)
            {
                return null;
            }

            Vector3D? directionC = DirectionC;
            if (directionC is null)
            {
                return null;
            }

            // Store axis lengths and their corresponding direction vectors
            var axes = new List<Tuple<double, Vector3D>>
            {
                Tuple.Create(a, directionA),
                Tuple.Create(b, directionB),
                Tuple.Create(c, directionC)
            };

            // Sort by axis length in descending order
            axes = [.. axes.OrderByDescending(a => a.Item1)];

            double longestSemiAxis = axes[0].Item1;
            Vector3D longestAxisDirection = axes[0].Item2;

            double secondLongestSemiAxis = axes[1].Item1;
            // Vector3 secondLongestAxisDirection = axes[1].Item2; // Not directly used for simple foci

            double shortestSemiAxis = axes[2].Item1;
            // Vector3 shortestAxisDirection = axes[2].Item2; // Not directly used for simple foci

            // Check if it's a sphere (all axes equal)
            if (System.Math.Abs(longestSemiAxis - shortestSemiAxis) < tolerance) // Use a small tolerance for double comparison
            {
                // It's a sphere, foci are at the center. No distinct foci.
                return null; // Or return (Center, Center) if you prefer
            }

            // Calculate linear eccentricity (focal distance from center)
            // This calculation applies to the *major axis* of the ellipse that was rotated.
            // For a prolate spheroid, the foci are on the longest axis.
            // For an oblate spheroid, it's more complex (focal circle), but if interpreted
            // as foci of the generating ellipse, they'd be in the plane perpendicular to the shortest axis.
            // We'll calculate for the *longest principal axis* of the ellipsoid.

            double f_squared = longestSemiAxis * longestSemiAxis - secondLongestSemiAxis * secondLongestSemiAxis;

            if (f_squared <= 0) // This means longestSemiAxis <= secondLongestSemiAxis (e.g., oblate or sphere)
            {
                // If longestSemiAxis == secondLongestSemiAxis, it's either a sphere (already handled)
                // or an oblate spheroid. For an oblate spheroid, the "foci" are often conceptualized
                // as a focal *circle* in the equatorial plane, or you might consider the foci of the
                // generating ellipse if rotated about its minor axis.
                // This simple formula for point foci primarily works for prolate spheroids.
                // To handle oblate case for point foci, you'd calculate f_squared based on the
                // major and minor axes of the generating ellipse.
                // For a typical ellipsoid defined by 3 axes, if it's oblate, the two largest axes are equal,
                // and the shortest one is the rotational axis. The "foci" are then on the longest two axes.
                // Let's refine this: the definition for 'f' is for the ellipse that generates the spheroid.
                // The major axis of that ellipse is the *longest* axis of the spheroid.
                // The minor axis of that ellipse is the *second longest* axis of the spheroid.
                f_squared = longestSemiAxis * longestSemiAxis - shortestSemiAxis * shortestSemiAxis; // Use longest and shortest for general case of spheroid foci

                // Re-evaluate the dominant axis for foci.
                // If AxisX is longest and unique, foci are along VectorX.
                // If AxisY is longest and unique, foci are along VectorY.
                // If AxisZ is longest and unique, foci are along VectorZ.
                // If two axes are equal and longest (oblate), the foci are problematic as points.

                // Let's stick to the convention that foci are on the *single longest* axis.
                // If there's no single longest axis (e.g., oblate spheroid like a=b>c), then there are no unique point foci.
                // The concept of a focal circle emerges.
                // For practical purposes in geometry, if it's oblate, there are no distinct point foci in the same way as a prolate.
                return null; // Or handle the focal circle case if needed.
            }

            double f = System.Math.Sqrt(f_squared);

            // The foci lie along the direction of the longest semi-axis
            Point3D? focalPoint_1 = center - (f * longestAxisDirection)!;
            if (focalPoint_1 is null)
            {
                return null;
            }

            Point3D? focalPoint_2 = center + (f * longestAxisDirection)!;
            if (focalPoint_2 is null)
            {
                return null;
            }

            return [focalPoint_1, focalPoint_2];
        }

        /// <summary>
        /// Calculates a point in 3D space based on the specified theta and phi angles.
        /// </summary>
        /// <param name="theta">The theta angle as a <see cref="double"/>.</param>
        /// <param name="phi">The phi angle as a <see cref="double"/>.</param>
        /// <returns>A <see cref="Point3D"/> if the plane axes are defined; otherwise, <c>null</c>.</returns>
        public Point3D? GetPoint(double theta, double phi)
        {
            Vector3D? axisX = plane?.AxisX;
            if (axisX is null)
            {
                return null;
            }

            Vector3D? axisY = plane!.AxisY;
            if (axisY is null)
            {
                return null;
            }

            Vector3D? axisZ = plane!.AxisZ;
            if (axisZ is null)
            {
                return null;
            }

            Point3D? center = Center;
            if (center is null)
            {
                return null;
            }

            // Unrotated local point on the ellipsoid
            double x = a * System.Math.Sin(phi) * System.Math.Cos(theta);
            double y = b * System.Math.Sin(phi) * System.Math.Sin(theta);
            double z = c * System.Math.Cos(phi);

            // Rotate using basis vectors and translate to center
            return center + (x * axisX)! + (y * axisY)! + (z * axisZ)!;
        }

        /// <summary>
        /// Calculates the volume of the ellipsoid.
        /// </summary>
        /// <returns>A <see cref="double"/> representing the calculated volume.</returns>
        public double GetVolume()
        {
            return (4.0 / 3.0) * System.Math.PI * a * b * c;
        }

        /// <summary>
        /// Determines whether the specified <see cref="Point3D"/> is inside the boundary within a given tolerance.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> to evaluate.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance for the check.</param>
        /// <returns>A <see cref="bool"/> indicating whether the point is inside the boundary.</returns>
        public bool Inside(Point3D? point3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point3D == null || plane?.Origin == null)
            {
                return false;
            }

            Vector3D? directionA = DirectionA;
            if (directionA is null)
            {
                return false;
            }

            Vector3D? directionB = DirectionB;
            if (directionB is null)
            {
                return false;
            }

            Vector3D? directionC = DirectionC;
            if (directionC is null)
            {
                return false;
            }

            Vector3D? vector3D = point3D - plane.Origin;
            if (vector3D is null)
            {
                return false;
            }

            double x = vector3D.DotProduct(directionA) / a;
            double y = vector3D.DotProduct(directionB) / b;
            double z = vector3D.DotProduct(directionC) / c;

            return x * x + y * y + z * z <= 1.0 + tolerance;
        }

        /// <summary>
        /// Moves the object using the specified Vector3D? vector.
        /// </summary>
        /// <param name="vector3D">The Vector3D? instance representing the movement vector.</param>
        /// <returns>A boolean value indicating whether the move operation was successful.</returns>
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
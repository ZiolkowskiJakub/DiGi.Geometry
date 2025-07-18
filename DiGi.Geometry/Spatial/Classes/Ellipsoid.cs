using DiGi.Core;
using DiGi.Geometry.Spatial.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    public class Ellipsoid : Geometry3D, IEllipsoid
    {
        [JsonInclude, JsonPropertyName("A")]
        private double a;

        [JsonInclude, JsonPropertyName("B")]
        private double b;

        [JsonInclude, JsonPropertyName("C")]
        private double c;

        [JsonInclude, JsonPropertyName("Plane")]
        private Plane plane;
        
        public Ellipsoid(Point3D center, double a, double b, double c)
        {
            plane = Create.Plane(center);
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public Ellipsoid(Plane plane, double a, double b, double c)
        {
            this.plane = plane?.Clone<Plane>();
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public Ellipsoid(Ellipsoid ellipsoid)
            : base(ellipsoid)
        {
            if(ellipsoid != null)
            {
                plane = ellipsoid.plane?.Clone<Plane>();
                a = ellipsoid.a;
                b = ellipsoid.b;
                c = ellipsoid.c;
            }
        }

        public Ellipsoid(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonIgnore]
        public double A
        {
            get
            {
                return a;
            }
        }

        [JsonIgnore]
        public double B
        {
            get
            {
                return b;
            }
        }

        [JsonIgnore]
        public double C
        {
            get
            {
                return c;
            }
        }

        [JsonIgnore]
        public Point3D Center
        {
            get 
            { 
                return plane?.Origin; 
            }
        }

        [JsonIgnore]
        public Vector3D DirectionA
        {
            get
            {
                return plane.AxisX;
            }
        }

        [JsonIgnore]
        public Vector3D DirectionB
        {
            get
            {
                return plane.AxisY;
            }
        }

        [JsonIgnore]
        public Vector3D DirectionC
        {
            get
            {
                return plane.AxisZ;
            }
        }

        [JsonIgnore]
        public Vector3D Extent
        {
            get
            {
                return (System.Math.Abs(a) * DirectionA * a) + (System.Math.Abs(b) * DirectionB * b) + (System.Math.Abs(c) * DirectionC * c);
            }
        }

        public static implicit operator Ellipsoid(Sphere sphere)
        {
            return sphere == null ? null : new Ellipsoid(sphere.Center, sphere.Radius, sphere.Radius, sphere.Radius);
        }

        public static implicit operator Ellipsoid(Spheroid spheroid)
        {
            return spheroid == null ? null : new Ellipsoid(spheroid.Plane, spheroid.A, spheroid.B, spheroid.B);
        }

        public BoundingBox3D GetBoundingBox()
        {
            Vector3D extent = Extent;

            Point3D center = Center;

            return new BoundingBox3D(center - Extent, center + Extent);
        }

        public Point3D GetPoint(double theta, double phi)
        {
            // Unrotated local point on the ellipsoid
            double x = a * System.Math.Sin(phi) * System.Math.Cos(theta);
            double y = b * System.Math.Sin(phi) * System.Math.Sin(theta);
            double z = c * System.Math.Cos(phi);

            // Rotate using basis vectors and translate to center
            return Center + x * plane.AxisX + y * plane.AxisY + z * plane.AxisZ;
        }

        public double GetVolume()
        {
            return (4.0 / 3.0) * System.Math.PI * a * b * c;
        }

        public bool Inside(Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point3D == null || plane?.Origin == null)
            {
                return false;
            }

            Vector3D vector3D = point3D - plane.Origin;

            double x = vector3D.DotProduct(DirectionA) / a;
            double y = vector3D.DotProduct(DirectionB) / b;
            double z = vector3D.DotProduct(DirectionC) / c;

            return x * x + y * y + z * z <= 1.0 + tolerance;
        }

        public override bool Move(Vector3D vector3D)
        {
            if(vector3D == null || plane == null)
            {
                return false;
            }

            return plane.Move(vector3D);
        }

        public Point3D[] GetFocalPoints(double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            // Store axis lengths and their corresponding direction vectors
            var axes = new List<Tuple<double, Vector3D>>
            {
                Tuple.Create(A, DirectionA),
                Tuple.Create(B, DirectionB),
                Tuple.Create(C, DirectionC)
            };

            // Sort by axis length in descending order
            axes = axes.OrderByDescending(a => a.Item1).ToList();

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
            Point3D focalPoint1 = Center - f * longestAxisDirection;
            Point3D focalPoint2 = Center + f * longestAxisDirection;

            return new Point3D[] { focalPoint1, focalPoint2 };
        }
    }
}

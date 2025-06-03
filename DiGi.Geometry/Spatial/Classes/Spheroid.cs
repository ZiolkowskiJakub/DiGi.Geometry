using DiGi.Core;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    public class Spheroid : Geometry3D, IEllipsoid
    {
        [JsonInclude, JsonPropertyName("A")]
        private double a;

        [JsonInclude, JsonPropertyName("B")]
        private double b;

        [JsonInclude, JsonPropertyName("Plane")]
        private Plane plane;
        
        public Spheroid(Point3D center, double a, double b)
        {
            plane = Create.Plane(center);
            this.a = a;
            this.b = b;
        }

        public Spheroid(Plane plane, double a, double b, double c)
        {
            this.plane = plane?.Clone<Plane>();
            this.a = a;
            this.b = b;
        }

        public Spheroid(Spheroid spheroid)
            : base(spheroid)
        {
            if(spheroid != null)
            {
                plane = spheroid.plane?.Clone<Plane>();
                a = spheroid.a;
                b = spheroid.b;
            }
        }

        public Spheroid(JsonObject jsonObject)
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
                return (System.Math.Abs(a) * plane.AxisX * a) + (System.Math.Abs(b) * plane.AxisY * b) + (System.Math.Abs(b) * plane.AxisZ * b);
            }
        }
        
        [JsonIgnore]
        public Plane Plane
        {
            get
            {
                return plane;
            }
        }

        public static implicit operator Spheroid(Sphere sphere)
        {
            return sphere == null ? null : new Spheroid(sphere.Center, sphere.Radius, sphere.Radius);
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
            double z = b * System.Math.Cos(phi);

            // Rotate using basis vectors and translate to center
            return Center + x * plane.AxisX + y * plane.AxisY + z * plane.AxisZ;
        }

        public double GetVolume()
        {
            return (4.0 / 3.0) * System.Math.PI * a * b * b;
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

            return x * x + y * y + y * y <= 1.0 + tolerance;
        }

        public override bool Move(Vector3D vector3D)
        {
            if(vector3D == null || plane == null)
            {
                return false;
            }

            return plane.Move(vector3D);
        }
    }
}

using DiGi.Core;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    public class Sphere : Geometry3D, IEllipsoid
    {
        [JsonInclude, JsonPropertyName("Center")]
        private Point3D center;

        [JsonInclude, JsonPropertyName("Radius")]
        private double radius;

        public Sphere(Point3D center, double radius)
        {
            this.center = center;
            this.radius = radius;
        }

        public Sphere(Sphere sphere)
            : base(sphere)
        {
            if(sphere != null)
            {
                center = sphere.center?.Clone<Point3D>();
                radius = sphere.radius;
            }
        }

        public Sphere(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonIgnore]
        public Point3D Center
        {
            get 
            { 
                return center; 
            }
        }

        [JsonIgnore]
        public Vector3D Extent
        {
            get
            {
                return new Vector3D(radius, radius, radius);
            }
        }

        [JsonIgnore]
        public double Radius
        {
            get 
            { 
                return radius; 
            }
        }

        public BoundingBox3D GetBoundingBox()
        {
            if(center == null || double.IsNaN(radius))
            {
                return null;
            }

            Vector3D extent = Extent;

            return new BoundingBox3D(center - extent, center + extent);
        }

        public Point3D GetPoint(double theta, double phi)
        {
            double x = radius * System.Math.Sin(phi) * System.Math.Cos(theta);
            double y = radius * System.Math.Sin(phi) * System.Math.Sin(theta);
            double z = radius * System.Math.Cos(phi); 

            return new Point3D(x + center.X, y + center.Y, z + center.Z);
        }

        public double GetVolume()
        {
            return (4.0 / 3.0) * System.Math.PI * radius * radius * radius;
        }

        public bool Inside(Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            double dx = point3D.X - center.X;
            double dy = point3D.Y - center.Y;
            double dz = point3D.Z - center.Z;

            double distanceSquared = dx * dx + dy * dy + dz * dz;
            double effectiveRadius = radius + tolerance;
            double effectiveRadiusSquared = effectiveRadius * effectiveRadius;

            return distanceSquared <= effectiveRadiusSquared;
        }

        public bool Inside(ISegmentable3D segmentable3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            List<Point3D> point3Ds = segmentable3D?.GetPoints();
            if(point3Ds == null || point3Ds.Count == 0)
            {
                return false;
            }

            foreach(Point3D point3D in point3Ds)
            {
                if(!Inside(point3D, tolerance))
                {
                    return false;
                }
            }

            return true;
        }

        public bool Inside(IPolygonalFace3D polygonalFace3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            return Inside(polygonalFace3D?.ExternalEdge, tolerance);
        }

        public override bool Move(Vector3D vector3D)
        {
            if (vector3D == null || center == null)
            {
                return false;
            }

            return center.Move(vector3D);
        }

        public bool On(Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            double dx = point3D.X - center.X;
            double dy = point3D.Y - center.Y;
            double dz = point3D.Z - center.Z;

            double distanceSquared = dx * dx + dy * dy + dz * dz;
            double radiusSquared = radius * radius;

            return System.Math.Abs(distanceSquared - radiusSquared) <= tolerance;
        }
    }
}

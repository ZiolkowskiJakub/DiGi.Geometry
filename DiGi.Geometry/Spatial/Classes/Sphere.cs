using DiGi.Core;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents a sphere in three-dimensional space.
    /// </summary>
    public class Sphere : Geometry3D, IEllipsoid
    {
        [JsonInclude, JsonPropertyName("Center")]
        private readonly Point3D? center;

        [JsonInclude, JsonPropertyName("Radius")]
        private readonly double radius;

        /// <summary>
        /// Initializes a new instance of the <see cref="Sphere"/> class with the specified center and radius.
        /// </summary>
        /// <param name="center">The <see cref="Point3D"/> representing the center of the sphere.</param>
        /// <param name="radius">The <see cref="double"/> value representing the radius of the sphere.</param>
        public Sphere(Point3D? center, double radius)
        {
            this.center = center;
            this.radius = radius;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sphere"/> class by copying the properties from an existing <see cref="Sphere"/> object.
        /// </summary>
        /// <param name="sphere">The <see cref="Sphere"/> object to copy from.</param>
        public Sphere(Sphere? sphere)
            : base(sphere)
        {
            if (sphere != null)
            {
                center = sphere.center?.Clone<Point3D>();
                radius = sphere.radius;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sphere"/> class using the provided <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the sphere data.</param>
        public Sphere(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the center point of the object as a <see cref="Point3D"/>.
        /// </summary>
        /// <value>The <see cref="Point3D"/> representing the center, or null if it is not specified.</value>
        [JsonIgnore]
        public Point3D? Center
        {
            get
            {
                return center;
            }
        }

        /// <summary>
        /// Gets the extent of the object as a <see cref="Vector3D"/>.
        /// </summary>
        /// <value>
        /// A <see cref="Vector3D"/> representing the dimensions of the object, or null.
        /// </value>
        [JsonIgnore]
        public Vector3D? Extent
        {
            get
            {
                return new Vector3D(radius, radius, radius);
            }
        }

        /// <summary>
        /// Gets the radius of the object as a <see cref="double"/>.
        /// </summary>
        [JsonIgnore]
        public double Radius
        {
            get
            {
                return radius;
            }
        }

        /// <summary>
        /// Calculates the axis-aligned bounding box of the object.
        /// </summary>
        /// <returns>A <see cref="BoundingBox3D"/> representing the bounding box, or <see langword="null"/> if the center is null, the radius is NaN, or the extent cannot be determined.</returns>
        public BoundingBox3D? GetBoundingBox()
        {
            if (center is null || double.IsNaN(radius))
            {
                return null;
            }

            Vector3D? extent = Extent;
            if (extent is null)
            {
                return null;
            }

            return new BoundingBox3D((center - extent)!, (center + extent)!);
        }

        /// <summary>
        /// Calculates a 3D point on the surface of the sphere based on the provided spherical coordinates.
        /// </summary>
        /// <param name="theta">The azimuthal angle as a <see cref="double"/>.</param>
        /// <param name="phi">The polar angle as a <see cref="double"/>.</param>
        /// <returns>A <see cref="Point3D"/> representing the calculated point, or <c>null</c> if the center is null or the radius is NaN.</returns>
        public Point3D? GetPoint(double theta, double phi)
        {
            if (center is null || double.IsNaN(radius))
            {
                return null;
            }

            double x = radius * System.Math.Sin(phi) * System.Math.Cos(theta);
            double y = radius * System.Math.Sin(phi) * System.Math.Sin(theta);
            double z = radius * System.Math.Cos(phi);

            return new Point3D(x + center.X, y + center.Y, z + center.Z);
        }

        /// <summary>
        /// Calculates the volume of the sphere.
        /// </summary>
        /// <returns>A double value representing the calculated volume.</returns>
        public double GetVolume()
        {
            return (4.0 / 3.0) * System.Math.PI * radius * radius * radius;
        }

        /// <summary>
        /// Determines whether the specified 3D point is located within the volume, considering a distance tolerance.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/>? point to evaluate.</param>
        /// <param name="tolerance">The <see cref="double"/> distance tolerance to be added to the radius.</param>
        /// <returns>A <see cref="bool"/> value indicating <see langword="true"/> if the point is inside or on the boundary of the volume; otherwise, <see langword="false"/>.</returns>
        public bool Inside(Point3D? point3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point3D is null || center is null)
            {
                return false;
            }

            double dx = point3D.X - center.X;
            double dy = point3D.Y - center.Y;
            double dz = point3D.Z - center.Z;

            double distanceSquared = dx * dx + dy * dy + dz * dz;
            double effectiveRadius = radius + tolerance;
            double effectiveRadiusSquared = effectiveRadius * effectiveRadius;

            return distanceSquared <= effectiveRadiusSquared;
        }

        /// <summary>
        /// Determines whether the specified <see cref="ISegmentable3D"/> object is inside, using a given tolerance.
        /// </summary>
        /// <param name="segmentable3D">The <see cref="ISegmentable3D"/> object to evaluate.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance for the check.</param>
        /// <returns>A <see cref="bool"/> value indicating whether all points of the <see cref="ISegmentable3D"/> object are inside; otherwise, false.</returns>
        public bool Inside(ISegmentable3D? segmentable3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            List<Point3D>? point3Ds = segmentable3D?.GetPoints();
            if (point3Ds == null || point3Ds.Count == 0)
            {
                return false;
            }

            foreach (Point3D point3D in point3Ds)
            {
                if (!Inside(point3D, tolerance))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Determines whether the current object is inside the specified <see cref="IPolygonalFace3D"/>.
        /// </summary>
        /// <param name="polygonalFace3D">The <see cref="IPolygonalFace3D"/> to check against.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used for the distance calculation.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the object is inside the specified polygonal face.</returns>
        public bool Inside(IPolygonalFace3D? polygonalFace3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            return Inside(polygonalFace3D?.ExternalEdge, tolerance);
        }

        /// <summary>
        /// Moves the object by the specified <see cref="Vector3D"/> vector.
        /// </summary>
        /// <param name="vector3D">The <see cref="Vector3D"/> vector to move the object by. This parameter can be null.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the movement was successful.</returns>
        public override bool Move(Vector3D? vector3D)
        {
            if (vector3D == null || center == null)
            {
                return false;
            }

            return center.Move(vector3D);
        }

        /// <summary>
        /// Determines whether the specified <see cref="Point3D"/> lies on the surface of the object within a given tolerance.
        /// </summary>
        /// <param name="point3D">The nullable <see cref="Point3D"/> to evaluate.</param>
        /// <param name="tolerance">The <see cref="double"/> value representing the distance tolerance for the check.</param>
        /// <returns>A <see cref="bool"/> value indicating <c>true</c> if the point is on the surface; otherwise, <c>false</c>.</returns>
        public bool On(Point3D? point3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point3D is null || center is null)
            {
                return false;
            }

            double dx = point3D.X - center.X;
            double dy = point3D.Y - center.Y;
            double dz = point3D.Z - center.Z;

            double distanceSquared = dx * dx + dy * dy + dz * dz;
            double radiusSquared = radius * radius;

            return System.Math.Abs(distanceSquared - radiusSquared) <= tolerance;
        }
    }
}
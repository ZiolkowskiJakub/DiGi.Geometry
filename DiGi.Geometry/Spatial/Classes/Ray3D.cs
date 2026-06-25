using DiGi.Core;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents a ray in three-dimensional space, defined by an origin point and a direction vector.
    /// </summary>
    public class Ray3D : Geometry3D, ILinear3D, IInvertible3D
    {
        [JsonInclude, JsonPropertyName("Direction")]
        private Vector3D? direction;

        [JsonInclude, JsonPropertyName("Origin")]
        private Point3D? origin;

        /// <summary>
        /// Initializes a new instance of the <see cref="Ray3D"/> class by cloning an existing <see cref="Ray3D"/> object.
        /// </summary>
        /// <param name="ray3D">The source <see cref="Ray3D"/> object to clone.</param>
        public Ray3D(Ray3D? ray3D)
        {
            if (ray3D is not null)
            {
                origin = DiGi.Core.Query.Clone(ray3D.origin);
                direction = DiGi.Core.Query.Clone(ray3D.direction);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ray3D"/> class with the specified origin and direction.
        /// </summary>
        /// <param name="origin">The <see cref="Point3D"/> that defines the starting point of the ray.</param>
        /// <param name="direction">The <see cref="Vector3D"/> that defines the direction of the ray.</param>
        public Ray3D(Point3D? origin, Vector3D? direction)
        {
            this.origin = DiGi.Core.Query.Clone(origin);
            this.direction = direction?.Unit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ray3D"/> class using two <see cref="Point3D"/> points to define the origin and direction.
        /// </summary>
        /// <param name="point3D_1">The <see cref="Point3D"/> that defines the origin of the ray.</param>
        /// <param name="point3D_2">The <see cref="Point3D"/> used to calculate the unit direction vector from the origin.</param>
        public Ray3D(Point3D? point3D_1, Point3D? point3D_2)
        {
            origin = DiGi.Core.Query.Clone(point3D_1);
            direction = new Vector3D(point3D_1, point3D_2).Unit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ray3D"/> class from the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the <see cref="Ray3D"/> instance.</param>
        public Ray3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the direction as a <see cref="Vector3D"/>.
        /// </summary>
        /// <value>The <see cref="Vector3D"/> representing the direction, or null if not specified.</value>
        [JsonIgnore]
        public Vector3D? Direction
        {
            get
            {
                return direction?.Clone<Vector3D>();
            }

            set
            {
                direction = value?.Clone<Vector3D>();
            }
        }

        /// <summary>
        /// Gets or sets the origin point of the ray as a <see cref="Point3D"/> object.
        /// </summary>
        /// <value>
        /// A <see cref="Point3D"/> representing the origin, or null if not specified.
        /// </value>
        [JsonIgnore]
        public Point3D? Origin
        {
            get
            {
                return origin?.Clone<Point3D>();
            }

            set
            {
                origin = value?.Clone<Point3D>();
            }
        }

        /// <summary>
        /// Indicates whether the two specified <see cref="Ray3D"/> objects are not equal.
        /// </summary>
        /// <param name="ray3D_1">The first <see cref="Ray3D"/> to compare.</param>
        /// <param name="ray3D_2">The second <see cref="Ray3D"/> to compare.</param>
        /// <returns><see langword="true"/> if the objects are not equal; otherwise, <see langword="false"/>.</returns>
        public static bool operator !=(Ray3D? ray3D_1, Ray3D? ray3D_2)
        {
            return !(ray3D_1 == ray3D_2);
        }

        /// <summary>
        /// Indicates whether the two specified <see cref="Ray3D"/> objects are equal.
        /// </summary>
        /// <param name="ray3D_1">The first <see cref="Ray3D"/> to compare.</param>
        /// <param name="ray3D_2">The second <see cref="Ray3D"/> to compare.</param>
        /// <returns><see langword="true"/> if the objects are equal; otherwise, <see langword="false"/>.</returns>
        public static bool operator ==(Ray3D? ray3D_1, Ray3D? ray3D_2)
        {
            if (ray3D_1 is null && ray3D_2 is null)
            {
                return true;
            }

            if (ray3D_1 is null || ray3D_2 is null)
            {
                return false;
            }

            return ray3D_1.origin == ray3D_2.origin && ray3D_1.direction == ray3D_2.direction;
        }

        /// <summary>
        /// Creates a copy of the current object.
        /// </summary>
        /// <returns>A new <see cref="ISerializableObject"/> that is a copy of the current instance, or <see langword="null"/>.</returns>
        public override ISerializableObject? Clone()
        {
            return new Ray3D(this);
        }

        /// <summary>
        /// Calculates the closest point on the linear entity to the specified <see cref="Point3D"/>.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> for which the closest point is calculated.</param>
        /// <returns>The closest <see cref="Point3D"/> if found; otherwise, null.</returns>
        public Point3D? ClosestPoint(Point3D? point3D)
        {
            if (origin is null || direction is null)
            {
                return null;
            }

            return Query.ClosestPoint(point3D, origin, origin.GetMoved(direction), true, false);
        }

        /// <summary>
        /// Determines whether this linear object is collinear with the specified <see cref="ILinear3D"/> object within a given tolerance.
        /// </summary>
        /// <param name="linear3D">The <see cref="ILinear3D"/> object to check for collinearity.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used to determine if the directions are collinear.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the objects are collinear; otherwise, false if either direction is null.</returns>
        public bool Collinear(ILinear3D? linear3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (direction is null || linear3D?.Direction is not Vector3D direction_Temp)
            {
                return false;
            }

            return direction.Collinear(direction_Temp, tolerance);
        }

        /// <summary>
        /// Calculates the distance between the specified <see cref="Point3D"/> and this object.
        /// </summary>
        /// <param name="point3D">The <c>Point3D?</c> point to calculate the distance from.</param>
        /// <returns>The distance as a <see cref="double"/>, or <see cref="double.NaN"/> if the provided <c>Point3D?</c> is null or cannot be projected.</returns>
        public double Distance(Point3D? point3D)
        {
            if (point3D == null)
            {
                return double.NaN;
            }

            Point3D? point3D_Project = Project(point3D);
            if (point3D_Project == null)
            {
                return double.NaN;
            }

            return point3D_Project.Distance(point3D);
        }

        /// <summary>
        /// Indicates whether the specified object is equal to the current <see cref="Ray3D"/>.
        /// </summary>
        /// <param name="obj">The object to compare with the current instance.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the specified object is equal to the current instance.</returns>
        public override bool Equals(object obj)
        {
            if (obj is not Ray3D ray3D)
            {
                return false;
            }

            return ray3D.origin == origin && ray3D.direction == direction;
        }

        /// <summary>
        /// Returns a hash code for the current object based on its origin and direction.
        /// </summary>
        /// <returns>An <see cref="int"/> representing the hash code of the object.</returns>
        public override int GetHashCode()
        {
            int hashCode = -1652769719;
            hashCode = hashCode * -1521134295 + EqualityComparer<Vector3D?>.Default.GetHashCode(direction);
            hashCode = hashCode * -1521134295 + EqualityComparer<Point3D?>.Default.GetHashCode(origin);
            return hashCode;
        }

        /// <summary>
        /// Calculates the intersection point between this ray and another <see cref="Ray3D"/>.
        /// </summary>
        /// <param name="line3D">The <see cref="Ray3D"/> to intersect with this ray.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance for the intersection calculation.</param>
        /// <returns>A <see cref="Point3D"/> representing the intersection point if one exists; otherwise, null.</returns>
        public Point3D? IntersectionPoint(Ray3D? line3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (line3D == null)
            {
                return null;
            }

            return Query.IntersectionPoint(origin, direction, line3D.origin, line3D.direction, false, tolerance);
        }

        /// <summary>
        /// Calculates the intersection point between this object and a specified 3D segment.
        /// </summary>
        /// <param name="segment3D">The <see cref="Segment3D"/> to intersect with.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance used for the intersection calculation.</param>
        /// <returns>A <see cref="Point3D"/> representing the intersection point if it exists and lies on the segment; otherwise, <c>null</c>.</returns>
        public Point3D? IntersectionPoint(Segment3D? segment3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segment3D == null || origin == null || direction == null)
            {
                return null;
            }

            Point3D? result = Query.IntersectionPoint(origin, direction, segment3D.Start, segment3D.Vector, false, tolerance);
            if (!segment3D.On(result))
            {
                return null;
            }

            return result;
        }

        /// <summary>
        /// Inverts the current direction.
        /// </summary>
        /// <returns>A <see cref="bool"/> value indicating whether the inversion was successful.</returns>
        public bool Inverse()
        {
            if (direction is null)
            {
                return false;
            }

            return direction.Inverse();
        }

        /// <summary>
        /// Moves the object by the specified <see cref="Vector3D"/>.
        /// </summary>
        /// <param name="vector3D">The <see cref="Vector3D"/> translation vector.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the move operation was successful.</returns>
        public override bool Move(Vector3D? vector3D)
        {
            if (vector3D == null || origin == null)
            {
                return false;
            }

            origin.Move(vector3D);
            return true;
        }

        /// <summary>
        /// Determines whether the specified <see cref="Point3D"/> lies on the object within a given tolerance.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> to evaluate.</param>
        /// <param name="tolerance">The <see cref="double"/> distance tolerance used to determine if the point is on the object.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the point is within the specified tolerance of the object.</returns>
        public bool On(Point3D? point3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point3D == null)
            {
                return false;
            }

            Point3D? point3D_Project = Project(point3D);
            if (point3D_Project == null)
            {
                return false;
            }

            return point3D_Project.Distance(point3D) < tolerance;
        }

        /// <summary>
        /// Projects a <see cref="Point3D"/> onto the ray, clamping points behind the origin to the origin.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> to project.</param>
        /// <returns>The projected <see cref="Point3D"/> on the ray, or null if the input point is null or the ray is not properly defined.</returns>
        public Point3D? Project(Point3D? point3D)
        {
            if (point3D is null || origin is null || direction is null)
            {
                return null;
            }

            Point3D? point3D_Projected = Query.ClosestPoint(point3D, origin, origin.GetMoved(direction), false);
            if (point3D_Projected is null)
            {
                return null;
            }

            Vector3D vector3D_Proj = new(origin, point3D_Projected);
            if (vector3D_Proj.DotProduct(direction) < 0.0)
            {
                return new Point3D(origin);
            }

            return point3D_Projected;
        }

        /// <summary>
        /// Transforms the origin and direction of the object using the specified 3D transformation.
        /// </summary>
        /// <param name="transform">The <see cref="ITransform3D"/> instance to apply for the transformation.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the transformation was successfully applied; returns false if the <see cref="ITransform3D"/> transform, origin, or direction is null.</returns>
        public bool Transform(ITransform3D? transform)
        {
            if (transform == null || origin == null || direction == null)
            {
                return false;
            }

            Point3D point3D_Temp = new(origin);
            point3D_Temp.Move(direction);

            Point3D point3D_OriginClone = new(origin);
            Point3D point3D_EndClone = new(point3D_Temp);

            if (!point3D_OriginClone.Transform(transform))
            {
                return false;
            }

            if (!point3D_EndClone.Transform(transform))
            {
                return false;
            }

            origin = point3D_OriginClone;
            direction = new Vector3D(origin, point3D_EndClone);
            direction.Normalize();

            return true;
        }
    }
}
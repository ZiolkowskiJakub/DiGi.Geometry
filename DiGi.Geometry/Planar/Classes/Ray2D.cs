using DiGi.Core;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    /// <summary>
    /// Represents a ray in two-dimensional space, defined by an origin point and a direction vector.
    /// </summary>
    public class Ray2D : Geometry2D, ILinear2D, IInvertible2D
    {
        [JsonInclude, JsonPropertyName("Direction")]
        private Vector2D? direction;

        [JsonInclude, JsonPropertyName("Origin")]
        private Point2D? origin;

        /// <summary>
        /// Initializes a new instance of the <see cref="Ray2D"/> class with the specified origin and direction.
        /// </summary>
        /// <param name="origin">The <see cref="Point2D"/> that represents the starting point of the ray.</param>
        /// <param name="direction">The <see cref="Vector2D"/> that represents the direction of the ray.</param>
        public Ray2D(Point2D? origin, Vector2D? direction)
        {
            this.origin = origin?.Clone<Point2D>();
            this.direction = direction?.Unit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ray2D"/> class by copying the values from an existing <see cref="Ray2D"/> instance.
        /// </summary>
        /// <param name="ray2D">The <see cref="Ray2D"/> instance to copy from.</param>
        public Ray2D(Ray2D? ray2D)
        {
            if (ray2D is not null)
            {
                origin = ray2D.Origin;
                direction = ray2D.Direction;
            }
        }

        /// <summary>
        /// Gets or sets the <see cref="Vector2D"/> representing the direction.
        /// </summary>
        /// <value>
        /// A nullable <see cref="Vector2D"/> that specifies the direction.
        /// </value>
        [JsonIgnore]
        public Vector2D? Direction
        {
            get
            {
                return direction?.Clone<Vector2D>();
            }

            set
            {
                direction = value?.Clone<Vector2D>();
            }
        }

        /// <summary>
        /// Gets or sets the origin <see cref="Point2D"/>.
        /// </summary>
        /// <value>The <see cref="Point2D"/> representing the origin, or null if it is not specified.</value>
        [JsonIgnore]
        public Point2D? Origin
        {
            get
            {
                return origin?.Clone<Point2D>();
            }

            set
            {
                origin = value?.Clone<Point2D>();
            }
        }

        /// <summary>
        /// Explicitly converts a <see cref="Segment2D"/> instance to a <see cref="Ray2D"/> instance.
        /// </summary>
        /// <param name="segment2D">The <see cref="Segment2D"/> instance to convert.</param>
        /// <returns>A <see cref="Ray2D"/> instance derived from the specified segment, or <see langword="null"/> if the input is <see langword="null"/>.</returns>
        public static explicit operator Ray2D?(Segment2D? segment2D)
        {
            if (segment2D is null)
            {
                return null;
            }

            return new Ray2D(segment2D.Start, segment2D.Vector);
        }

        /// <summary>
        /// Indicates whether the two specified <see cref="Ray2D"/> instances are not equal.
        /// </summary>
        /// <param name="ray2D_1">The first <see cref="Ray2D"/> instance to compare.</param>
        /// <param name="ray2D_2">The second <see cref="Ray2D"/> instance to compare.</param>
        /// <returns><see langword="true"/> if the two rays are not equal; otherwise, <see langword="false"/>.</returns>
        public static bool operator !=(Ray2D? ray2D_1, Ray2D? ray2D_2)
        {
            return !(ray2D_1 == ray2D_2);
        }

        /// <summary>
        /// Indicates whether the two specified <see cref="Ray2D"/> instances are equal.
        /// </summary>
        /// <param name="ray2D_1">The first <see cref="Ray2D"/> instance to compare.</param>
        /// <param name="ray2D_2">The second <see cref="Ray2D"/> instance to compare.</param>
        /// <returns><see langword="true"/> if the two rays are equal; otherwise, <see langword="false"/>.</returns>
        public static bool operator ==(Ray2D? ray2D_1, Ray2D? ray2D_2)
        {
            if (ray2D_1 is null && ray2D_2 is null)
            {
                return true;
            }

            if (ray2D_1 is null || ray2D_2 is null)
            {
                return false;
            }

            return ray2D_1.origin == ray2D_2.origin && ray2D_1.direction == ray2D_2.direction;
        }

        /// <summary>
        /// Creates a copy of the current <see cref="Ray2D"/> instance.
        /// </summary>
        /// <returns>A new <see cref="ISerializableObject"/> that is a clone of the current instance.</returns>
        public override ISerializableObject? Clone()
        {
            return new Ray2D(this);
        }

        /// <summary>
        /// Calculates the closest <see cref="Point2D"/> on the line to the specified <see cref="Point2D"/>.
        /// </summary>
        /// <param name="point2D">The <see cref="Point2D"/> for which the closest point is calculated.</param>
        /// <returns>The closest <see cref="Point2D"/>, or <see langword="null"/> if the origin or direction is not defined.</returns>
        public Point2D? ClosestPoint(Point2D? point2D)
        {
            if (origin == null || direction is null)
            {
                return null;
            }

            return Query.ClosestPoint(point2D, origin, origin + direction, true, false);
        }

        /// <summary>
        /// Determines whether this linear 2D object is collinear with the specified <see cref="ILinear2D"/> object within a given tolerance.
        /// </summary>
        /// <param name="linear2D">The <see cref="ILinear2D"/> object to check for collinearity.</param>
        /// <param name="tolerance">The <see cref="double"/> value representing the distance tolerance used to determine collinearity.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the two linear 2D objects are collinear.</returns>
        public bool Collinear(ILinear2D? linear2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            return Query.Collinear(this, linear2D, tolerance);
        }

        /// <summary>
        /// Calculates the distance from a specified <see cref="Point2D"/> to the ray.
        /// </summary>
        /// <param name="point2D">The <see cref="Point2D"/> instance for which the distance is calculated.</param>
        /// <returns>The shortest distance as a <see cref="double"/>, or <see cref="double.NaN"/> if the provided <see cref="Point2D"/> is null, or if the ray's origin or direction are not defined.</returns>
        public double Distance(Point2D? point2D)
        {
            if (point2D == null || origin == null || direction is null)
            {
                return double.NaN;
            }

            Point2D? point2D_Project = ClosestPoint(point2D);
            if (point2D_Project is null)
            {
                return double.NaN;
            }

            return point2D_Project.Distance(point2D);
        }

        /// <summary>
        /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="Ray2D"/>.
        /// </summary>
        /// <param name="obj">The <see cref="object"/> to compare with the current <see cref="Ray2D"/>.</param>
        /// <returns><see langword="true"/> if the specified <see cref="object"/> is a <see cref="Ray2D"/> and has the same origin and direction as the current instance; otherwise, <see langword="false"/>.</returns>
        public override bool Equals(object? obj)
        {
            if (obj is not Ray2D ray2D)
            {
                return false;
            }

            return ray2D.origin == origin && ray2D.direction == direction;
        }

        /// <summary>
        /// Returns a hash code for the current object based on the origin and direction.
        /// </summary>
        /// <returns>An <see cref="int"/> representing the hash code of the instance.</returns>
        public override int GetHashCode()
        {
            int hashCode = -1652769719;
            hashCode = hashCode * -1521134295 + EqualityComparer<Vector2D?>.Default.GetHashCode(direction);
            hashCode = hashCode * -1521134295 + EqualityComparer<Point2D?>.Default.GetHashCode(origin);
            return hashCode;
        }

        /// <summary>
        /// Calculates the intersection point between this ray and another specified <see cref="Ray2D"/>.
        /// </summary>
        /// <param name="ray2D">The other <see cref="Ray2D"/> to intersect with.</param>
        /// <param name="tolerance">A <see cref="double"/> value specifying the distance tolerance for the intersection calculation and verification.</param>
        /// <returns>A <see cref="Point2D"/> representing the intersection point if it exists within the specified tolerance; otherwise, null.</returns>
        public Point2D? IntersectionPoint(Ray2D? ray2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (ray2D is null || origin == null || direction is null)
            {
                return null;
            }

            Point2D? point2D_1 = Origin;
            point2D_1?.Move(direction);

            Point2D? point2D_2 = ray2D.Origin;
            point2D_2?.Move(ray2D.direction);

            Point2D? result = Query.IntersectionPoint(origin, point2D_1, ray2D.origin, point2D_2, false, tolerance);
            if (!ray2D.On(result, tolerance) || !On(result, tolerance))
            {
                return null;
            }

            return result;
        }

        /// <summary>
        /// Calculates the intersection point between this segment and another <see cref="Segment2D"/>.
        /// </summary>
        /// <param name="segment2D">The <see cref="Segment2D"/> to check for an intersection.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance used for the intersection calculation.</param>
        /// <returns>A <see cref="Point2D"/> if an intersection point exists and lies on both segments; otherwise, <c>null</c>.</returns>
        public Point2D? IntersectionPoint(Segment2D? segment2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segment2D is null || origin is null || direction is null)
            {
                return null;
            }

            Point2D? point2D = Origin;
            point2D?.Move(direction);

            Point2D? result = Query.IntersectionPoint(origin, point2D, segment2D.Start, segment2D.End, false, tolerance);
            if (!segment2D.On(result) || !On(result))
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
        /// Moves the object by the specified Vector2D.
        /// </summary>
        /// <param name="vector2D">The Vector2D that defines the movement offset.</param>
        /// <returns>True if the move operation was successful; otherwise, false.</returns>
        public override bool Move(Vector2D? vector2D)
        {
            if (vector2D is null || origin is null)
            {
                return false;
            }

            origin.Move(vector2D);
            return true;
        }

        /// <summary>
        /// Determines whether the specified <see cref="Point2D"/> is on the object within a given tolerance.
        /// </summary>
        /// <param name="point2D">The <see cref="Point2D"/> to evaluate.</param>
        /// <param name="tolerance">The <see cref="double"/> value representing the distance tolerance.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the point is on the object within the specified tolerance.</returns>
        public bool On(Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (origin == null || direction is null || point2D == null)
            {
                return false;
            }

            return Distance(point2D) < tolerance;
        }

        /// <summary>
        /// Projects the specified <see cref="Point2D"/> onto the line.
        /// </summary>
        /// <param name="point2D">The <see cref="Point2D"/> to project.</param>
        /// <returns>The projected <see cref="Point2D"/>, or null if the projection could not be calculated.</returns>
        public Point2D? Project(Point2D? point2D)
        {
            return Query.ClosestPoint(point2D, origin, origin + direction, false);
        }

        /// <summary>
        /// Transforms the object's origin and direction using the provided 2D transformation.
        /// </summary>
        /// <param name="transform">The <see cref="ITransform2D"/> instance used to perform the transformation.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the transformation was successfully applied; returns <c>false</c> if the <see cref="ITransform2D"/> transform, origin, or direction is null.</returns>
        public override bool Transform(ITransform2D? transform)
        {
            if (transform is null || origin is null || direction is null)
            {
                return false;
            }

            Point2D point2D = new(origin);
            point2D.Move(direction);

            origin.Transform(transform);

            point2D.Transform(transform);
            direction = new(origin, point2D);
            direction.Normalize();

            return true;
        }
    }
}
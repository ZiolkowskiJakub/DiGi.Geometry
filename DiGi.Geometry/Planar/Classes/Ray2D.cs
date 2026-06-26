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
            if (point2D == null || origin == null || direction == null)
            {
                return null;
            }

            double double_Dx = point2D.X - origin.X;
            double double_Dy = point2D.Y - origin.Y;

            double double_T = double_Dx * direction.X + double_Dy * direction.Y;
            if (double_T < 0.0)
            {
                return new Point2D(origin);
            }

            return new Point2D(
                origin.X + double_T * direction.X,
                origin.Y + double_T * direction.Y
            );
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
            if (point2D == null || origin == null || direction == null)
            {
                return double.NaN;
            }

            double double_Dx = point2D.X - origin.X;
            double double_Dy = point2D.Y - origin.Y;

            double double_T = double_Dx * direction.X + double_Dy * direction.Y;
            if (double_T < 0.0)
            {
                return System.Math.Sqrt(double_Dx * double_Dx + double_Dy * double_Dy);
            }

            double double_ProjX = origin.X + double_T * direction.X;
            double double_ProjY = origin.Y + double_T * direction.Y;

            double double_Rx = point2D.X - double_ProjX;
            double double_Ry = point2D.Y - double_ProjY;

            return System.Math.Sqrt(double_Rx * double_Rx + double_Ry * double_Ry);
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
            if (ray2D is null || origin == null || direction == null || ray2D.origin == null || ray2D.direction == null)
            {
                return null;
            }

            double double_Det = direction.Y * ray2D.direction.X - direction.X * ray2D.direction.Y;
            if (System.Math.Abs(double_Det) < 1e-12)
            {
                return null;
            }

            double double_Dx = ray2D.origin.X - origin.X;
            double double_Dy = ray2D.origin.Y - origin.Y;

            double double_T1 = (double_Dy * ray2D.direction.X - double_Dx * ray2D.direction.Y) / double_Det;
            double double_T2 = (double_Dy * direction.X - double_Dx * direction.Y) / double_Det;

            double double_Len1 = System.Math.Sqrt(direction.X * direction.X + direction.Y * direction.Y);
            double double_Len2 = System.Math.Sqrt(ray2D.direction.X * ray2D.direction.X + ray2D.direction.Y * ray2D.direction.Y);

            double double_ParamTolerance1 = double_Len1 > 1e-9 ? tolerance / double_Len1 : tolerance;
            double double_ParamTolerance2 = double_Len2 > 1e-9 ? tolerance / double_Len2 : tolerance;

            if (double_T1 < -double_ParamTolerance1 || double_T2 < -double_ParamTolerance2)
            {
                return null;
            }

            return new Point2D(
                origin.X + double_T1 * direction.X,
                origin.Y + double_T1 * direction.Y
            );
        }

        /// <summary>
        /// Calculates the intersection point between this segment and another <see cref="Segment2D"/>.
        /// </summary>
        /// <param name="segment2D">The <see cref="Segment2D"/> to check for an intersection.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance used for the intersection calculation.</param>
        /// <returns>A <see cref="Point2D"/> if an intersection point exists and lies on both segments; otherwise, <c>null</c>.</returns>
        public Point2D? IntersectionPoint(Segment2D? segment2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segment2D is null || origin == null || direction == null || segment2D.Start is not Point2D point2D_Start || segment2D.Vector is not Vector2D vector2D_Vector)
            {
                return null;
            }

            double double_Det = direction.Y * vector2D_Vector.X - direction.X * vector2D_Vector.Y;
            if (System.Math.Abs(double_Det) < 1e-12)
            {
                return null;
            }

            double double_Dx = point2D_Start.X - origin.X;
            double double_Dy = point2D_Start.Y - origin.Y;

            double double_T = (double_Dy * vector2D_Vector.X - double_Dx * vector2D_Vector.Y) / double_Det;
            double double_U = (double_Dy * direction.X - double_Dx * direction.Y) / double_Det;

            double double_LenRay = System.Math.Sqrt(direction.X * direction.X + direction.Y * direction.Y);
            double double_LenSeg = System.Math.Sqrt(vector2D_Vector.X * vector2D_Vector.X + vector2D_Vector.Y * vector2D_Vector.Y);

            double double_ParamToleranceRay = double_LenRay > 1e-9 ? tolerance / double_LenRay : tolerance;
            double double_ParamToleranceSeg = double_LenSeg > 1e-9 ? tolerance / double_LenSeg : tolerance;

            if (double_T < -double_ParamToleranceRay || double_U < -double_ParamToleranceSeg || double_U > 1.0 + double_ParamToleranceSeg)
            {
                return null;
            }

            return new Point2D(
                origin.X + double_T * direction.X,
                origin.Y + double_T * direction.Y
            );
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
            if (point2D == null || origin == null || direction == null)
            {
                return false;
            }

            double double_Dx = point2D.X - origin.X;
            double double_Dy = point2D.Y - origin.Y;

            double double_T = double_Dx * direction.X + double_Dy * direction.Y;
            double double_Rx;
            double double_Ry;

            if (double_T < 0.0)
            {
                double_Rx = double_Dx;
                double_Ry = double_Dy;
            }
            else
            {
                double double_ProjX = origin.X + double_T * direction.X;
                double double_ProjY = origin.Y + double_T * direction.Y;

                double_Rx = point2D.X - double_ProjX;
                double_Ry = point2D.Y - double_ProjY;
            }

            double double_DistSq = double_Rx * double_Rx + double_Ry * double_Ry;

            return double_DistSq < tolerance * tolerance;
        }

        /// <summary>
        /// Projects the specified <see cref="Point2D"/> onto the ray, clamping points behind the origin to the origin.
        /// </summary>
        /// <param name="point2D">The <see cref="Point2D"/> to project.</param>
        /// <returns>The projected <see cref="Point2D"/> on the ray, or null if the input point or the ray is not properly defined.</returns>
        public Point2D? Project(Point2D? point2D)
        {
            return ClosestPoint(point2D);
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

            Point2D point2D_Temp = new(origin);
            point2D_Temp.Move(direction);

            Point2D point2D_OriginClone = new(origin);
            Point2D point2D_EndClone = new(point2D_Temp);

            if (!point2D_OriginClone.Transform(transform))
            {
                return false;
            }

            if (!point2D_EndClone.Transform(transform))
            {
                return false;
            }

            origin = point2D_OriginClone;
            direction = new(origin, point2D_EndClone);
            direction.Normalize();

            return true;
        }
    }
}
using DiGi.Core;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    /// <summary>
    /// Represents an infinite line in 2D space defined by an origin point and a direction vector.
    /// </summary>
    public class Line2D : Geometry2D, ILinear2D
    {
        [JsonInclude, JsonPropertyName("Direction")]
        private Vector2D? direction;

        [JsonInclude, JsonPropertyName("Origin")]
        private Point2D? origin;

        /// <summary>
        /// Initializes a new instance of the <see cref="Line2D"/> class with a specified origin and direction.
        /// </summary>
        /// <param name="origin">The origin point of the line.</param>
        /// <param name="direction">The direction vector of the line.</param>
        public Line2D(Point2D? origin, Vector2D? direction)
        {
            this.origin = origin?.Clone<Point2D>();
            this.direction = direction?.Unit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Line2D"/> class by cloning an existing line.
        /// </summary>
        /// <param name="line2D">The source line to clone.</param>
        public Line2D(Line2D? line2D)
        {
            if (line2D is not null)
            {
                origin = line2D.Origin;
                direction = line2D.Direction;
            }
        }

        /// <summary>
        /// Gets or sets the unit direction vector of the line.
        /// </summary>
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
        /// Gets or sets the origin point of the line.
        /// </summary>
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
        /// Explicitly converts a segment to a line that extends infinitely in both directions along the segment's axis.
        /// </summary>
        /// <param name="segment2D">The source segment.</param>
        /// <returns>A Line2D representation of the infinite line containing the segment.</returns>
        public static explicit operator Line2D?(Segment2D? segment2D)
        {
            if (segment2D is null)
            {
                return null;
            }

            return new Line2D(segment2D.Start, segment2D.Vector);
        }

        /// <summary>
        /// Determines whether two lines are not equal.
        /// </summary>
        /// <param name="line2D_1">The first line.</param>
        /// <param name="line2D_2">The second line.</param>
        /// <returns>True if the lines are not equal; otherwise, false.</returns>
        public static bool operator !=(Line2D? line2D_1, Line2D? line2D_2)
        {
            return !(line2D_1 == line2D_2);
        }

        /// <summary>
        /// Determines whether two lines are equal.
        /// </summary>
        /// <param name="line2D_1">The first line.</param>
        /// <param name="line2D_2">The second line.</param>
        /// <returns>True if the lines are equal; otherwise, false.</returns>
        public static bool operator ==(Line2D? line2D_1, Line2D? line2D_2)
        {
            if (line2D_1 is null && line2D_2 is null)
            {
                return true;
            }

            if (line2D_1 is null || line2D_2 is null)
            {
                return false;
            }

            return line2D_1.origin == line2D_2.origin && line2D_1.direction == line2D_2.direction;
        }

        /// <summary>
        /// Creates a clone of the current line.
        /// </summary>
        /// <returns>A cloned instance of the line.</returns>
        public override ISerializableObject? Clone()
        {
            return new Line2D(this);
        }

        /// <summary>
        /// Finds the point on the line closest to the given point.
        /// </summary>
        /// <param name="point2D">The target point.</param>
        /// <returns>The projected point on the line.</returns>
        public Point2D? ClosestPoint(Point2D? point2D)
        {
            if (point2D == null || origin == null || direction == null)
            {
                return null;
            }

            double dx = point2D.X - origin.X;
            double dy = point2D.Y - origin.Y;

            double t = dx * direction.X + dy * direction.Y;

            return new Point2D(
                origin.X + t * direction.X,
                origin.Y + t * direction.Y
            );
        }

        /// <summary>
        /// Checks if another linear geometry is collinear with this line.
        /// </summary>
        /// <param name="linear2D">The linear geometry to check.</param>
        /// <param name="tolerance">The distance tolerance for the check.</param>
        /// <returns>True if they are collinear; otherwise, false.</returns>
        public bool Collinear(ILinear2D? linear2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            return Query.Collinear(this, linear2D, tolerance);
        }

        /// <summary>
        /// Calculates the shortest distance from a point to the line.
        /// </summary>
        /// <param name="point2D">The target point.</param>
        /// <returns>The perpendicular distance to the line.</returns>
        public double Distance(Point2D? point2D)
        {
            if (point2D == null || origin == null || direction == null)
            {
                return double.NaN;
            }

            double dx = point2D.X - origin.X;
            double dy = point2D.Y - origin.Y;

            double t = dx * direction.X + dy * direction.Y;

            double projX = origin.X + t * direction.X;
            double projY = origin.Y + t * direction.Y;

            double rx = point2D.X - projX;
            double ry = point2D.Y - projY;

            return System.Math.Sqrt(rx * rx + ry * ry);
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current line.
        /// </summary>
        /// <param name="obj">The object to compare with the current line.</param>
        /// <returns>True if the objects are equal; otherwise, false.</returns>
        public override bool Equals(object? obj)
        {
            if (obj is not Line2D line2D)
            {
                return false;
            }

            return line2D.origin == origin && line2D.direction == direction;
        }

        /// <summary>
        /// Gets the hash code for this line.
        /// </summary>
        /// <returns>A 32-bit signed integer hash code.</returns>
        public override int GetHashCode()
        {
            int hashCode = -1652769719;
            hashCode = hashCode * -1521134295 + EqualityComparer<Vector2D?>.Default.GetHashCode(direction);
            hashCode = hashCode * -1521134295 + EqualityComparer<Point2D?>.Default.GetHashCode(origin);
            return hashCode;
        }

        /// <summary>
        /// Calculates the intersection point of two lines.
        /// </summary>
        /// <param name="line2D">The other line to intersect with.</param>
        /// <param name="tolerance">The distance tolerance for the check.</param>
        /// <returns>The intersection point, or null if they are parallel or collinear.</returns>
        public Point2D? IntersectionPoint(Line2D? line2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (line2D is null || origin == null || direction == null || line2D.origin == null || line2D.direction == null)
            {
                return null;
            }

            double det = direction.Y * line2D.direction.X - direction.X * line2D.direction.Y;
            if (System.Math.Abs(det) < 1e-12)
            {
                return null;
            }

            double dx = line2D.origin.X - origin.X;
            double dy = line2D.origin.Y - origin.Y;

            double t1 = (dy * line2D.direction.X - dx * line2D.direction.Y) / det;

            return new Point2D(
                origin.X + t1 * direction.X,
                origin.Y + t1 * direction.Y
            );
        }

        /// <summary>
        /// Calculates the intersection point of a line and a segment.
        /// </summary>
        /// <param name="segment2D">The segment to intersect with.</param>
        /// <param name="tolerance">The distance tolerance for the check.</param>
        /// <returns>The intersection point, or null if no intersection exists within the segment boundaries.</returns>
        public Point2D? IntersectionPoint(Segment2D? segment2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segment2D is null || origin == null || direction == null || segment2D.Start is not Point2D start || segment2D.Vector is not Vector2D vector)
            {
                return null;
            }

            double det = direction.Y * vector.X - direction.X * vector.Y;
            if (System.Math.Abs(det) < 1e-12)
            {
                return null;
            }

            double dx = start.X - origin.X;
            double dy = start.Y - origin.Y;

            double t2 = (dy * direction.X - dx * direction.Y) / det;
            double length = System.Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
            double paramTolerance = length > 1e-9 ? tolerance / length : tolerance;
            if (t2 < -paramTolerance || t2 > 1.0 + paramTolerance)
            {
                return null;
            }

            return new Point2D(
                start.X + t2 * vector.X,
                start.Y + t2 * vector.Y
            );
        }

        /// <summary>
        /// Reverses the direction of the line.
        /// </summary>
        /// <returns>True if the direction was successfully reversed.</returns>
        public bool Inverse()
        {
            if (direction is null)
            {
                return false;
            }

            return direction.Inverse();
        }

        /// <summary>
        /// Moves the line by translating its origin point.
        /// </summary>
        /// <param name="vector2D">The translation vector.</param>
        /// <returns>True if the move was successful.</returns>
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
        /// Checks if a point lies on the line within the specified tolerance.
        /// </summary>
        /// <param name="point2D">The point to check.</param>
        /// <param name="tolerance">The distance tolerance for the check.</param>
        /// <returns>True if the point is on the line; otherwise, false.</returns>
        public bool On(Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point2D == null || origin == null || direction == null)
            {
                return false;
            }

            double dx = point2D.X - origin.X;
            double dy = point2D.Y - origin.Y;

            double t = dx * direction.X + dy * direction.Y;

            double projX = origin.X + t * direction.X;
            double projY = origin.Y + t * direction.Y;

            double rx = point2D.X - projX;
            double ry = point2D.Y - projY;

            double distSq = rx * rx + ry * ry;

            return distSq < tolerance * tolerance;
        }

        /// <summary>
        /// Projects a point onto the line.
        /// </summary>
        /// <param name="point2D">The target point.</param>
        /// <returns>The projected point on the line.</returns>
        public Point2D? Project(Point2D? point2D)
        {
            return ClosestPoint(point2D);
        }

        /// <summary>
        /// Transforms the line using the specified transformation.
        /// </summary>
        /// <param name="transform">The transformation to apply.</param>
        /// <returns>True if the transformation was successful.</returns>
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
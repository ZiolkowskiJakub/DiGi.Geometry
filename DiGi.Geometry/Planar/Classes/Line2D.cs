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
            if (origin is null || direction is null)
            {
                return null;
            }

            return Query.ClosestPoint(point2D, origin, origin + direction, false);
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
            if (point2D == null || origin == null || direction is null)
            {
                return double.NaN;
            }

            Point2D? point2D_Project = Project(point2D);
            if (point2D_Project is null)
            {
                return double.NaN;
            }

            return point2D_Project.Distance(point2D);
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
            if (line2D is null || origin == null || direction is null)
            {
                return null;
            }

            Point2D? point2D_1 = Origin;
            point2D_1?.Move(direction);

            Point2D? point2D_2 = line2D.Origin;
            point2D_2?.Move(line2D.direction);

            return Query.IntersectionPoint(origin, point2D_1, line2D.origin, point2D_2, false, tolerance);
        }

        /// <summary>
        /// Calculates the intersection point of a line and a segment.
        /// </summary>
        /// <param name="segment2D">The segment to intersect with.</param>
        /// <param name="tolerance">The distance tolerance for the check.</param>
        /// <returns>The intersection point, or null if no intersection exists within the segment boundaries.</returns>
        public Point2D? IntersectionPoint(Segment2D? segment2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segment2D is null || origin is null || direction is null)
            {
                return null;
            }

            Point2D? point2D = Origin;
            point2D?.Move(direction);

            Point2D? result = Query.IntersectionPoint(origin, point2D, segment2D.Start, segment2D.End, false, tolerance);
            if (!segment2D.On(result))
            {
                return null;
            }

            return result;
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
            if (origin == null || direction is null || point2D == null)
            {
                return false;
            }

            return Distance(point2D) < tolerance;
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
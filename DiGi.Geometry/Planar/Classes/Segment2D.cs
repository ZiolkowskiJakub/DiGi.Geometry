using DiGi.Core;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    public class Segment2D : Geometry2D, ISegmentable2D, ILinear2D, ISegment<Point2D>
    {
        private Point2D? start;
        private Vector2D? vector;

        /// <summary>
        /// Initializes a new instance of the <see cref="Segment2D"/> class defined by start and end coordinates.
        /// </summary>
        /// <param name="x_1">The X coordinate of the start point.</param>
        /// <param name="y_1">The Y coordinate of the start point.</param>
        /// <param name="x_2">The X coordinate of the end point.</param>
        /// <param name="y_2">The Y coordinate of the end point.</param>
        public Segment2D(double x_1, double y_1, double x_2, double y_2)
        {
            start = new(x_1, y_1);
            vector = new(start, new Point2D(x_2, y_2));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Segment2D"/> class using a start point and a vector.
        /// </summary>
        /// <param name="start">The start point of the segment.</param>
        /// <param name="vector">The vector defining the direction and length of the segment.</param>
        public Segment2D(Point2D? start, Vector2D? vector)
        {
            this.start = start?.Clone<Point2D>();
            this.vector = vector?.Clone<Vector2D>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Segment2D"/> class using start and end points.
        /// </summary>
        /// <param name="start">The start point of the segment.</param>
        /// <param name="end">The end point of the segment.</param>
        public Segment2D(Point2D? start, Point2D? end)
        {
            if (start != null && end != null)
            {
                this.start = start?.Clone<Point2D>();
                vector = new(start, end);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Segment2D"/> class by cloning an existing segment.
        /// </summary>
        /// <param name="segment2D">The source segment to clone.</param>
        public Segment2D(Segment2D? segment2D)
            : this(segment2D?.start, segment2D?.vector)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Segment2D"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing segment data.</param>
        public Segment2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the unit direction vector of the segment.
        /// </summary>
        [JsonIgnore]
        public Vector2D? Direction
        {
            get
            {
                return vector?.Unit;
            }

            set
            {
                vector = value?.Unit * Length;
            }
        }

        /// <summary>
        /// Gets or sets the end point of the segment.
        /// </summary>
        [JsonIgnore]
        public Point2D? End
        {
            get
            {
                if (vector is null || start == null)
                {
                    return null;
                }

                Point2D result = new(start);
                result.Move(vector);

                return result;
            }

            set
            {
                if (value == null || start == null)
                {
                    return;
                }

                vector = new Vector2D(start, value);
            }
        }

        /// <summary>
        /// Gets or sets the length of the segment.
        /// </summary>
        [JsonIgnore]
        public double Length
        {
            get
            {
                if (vector is null)
                {
                    return double.NaN;
                }

                return vector.Length;
            }

            set
            {
                vector = Direction * value;
            }
        }

        /// <summary>
        /// Gets the squared length of the segment.
        /// </summary>
        [JsonIgnore]
        public double SquaredLength
        {
            get
            {
                if (vector is null)
                {
                    return double.NaN;
                }

                return vector.SquaredLength;
            }
        }

        /// <summary>
        /// Gets or sets the start point of the segment.
        /// </summary>
        [JsonPropertyName("Start")]
        public Point2D? Start
        {
            get
            {
                return start?.Clone<Point2D>();
            }

            set
            {
                start = value?.Clone<Point2D>();
            }
        }

        /// <summary>
        /// Gets or sets the vector defining the segment.
        /// </summary>
        [JsonPropertyName("Vector")]
        public Vector2D? Vector
        {
            get
            {
                return vector?.Clone<Vector2D>();
            }

            set
            {
                vector = value?.Clone<Vector2D>();
            }
        }

        /// <summary>
        /// Gets the point at the specified index (0 for start, 1 for end).
        /// </summary>
        public Point2D? this[int index]
        {
            get
            {
                return index switch
                {
                    0 => Start,
                    1 => End,
                    _ => null,
                };
            }
        }

        /// <summary>
        /// Implicitly converts a tuple of coordinate pairs to a Segment2D.
        /// </summary>
        /// <param name="object">The tuple containing start and end coordinates.</param>
        /// <returns>A new Segment2D instance.</returns>
        public static implicit operator Segment2D?(((double x, double y), (double x, double y)) @object)
        {
            return new Segment2D(new Point2D(@object.Item1.x, @object.Item1.y), new Point2D(@object.Item2.x, @object.Item2.y));
        }

        /// <summary>
        /// Implicitly converts a tuple of start and end points to a Segment2D.
        /// </summary>
        /// <param name="object">The tuple containing the start and end points.</param>
        /// <returns>A new Segment2D instance.</returns>
        public static implicit operator Segment2D?((Point2D? start, Point2D? end) @object)
        {
            return new Segment2D(@object.start, @object.end);
        }

        /// <summary>
        /// Checks if two segments are not equal.
        /// </summary>
        /// <param name="segment2D_1">The first segment.</param>
        /// <param name="segment2D_2">The second segment.</param>
        /// <returns>True if the segments are different; otherwise, false.</returns>
        public static bool operator !=(Segment2D? segment2D_1, Segment2D? segment2D_2)
        {
            return !(segment2D_1 == segment2D_2);
        }

        /// <summary>
        /// Checks if two segments are equal.
        /// </summary>
        /// <param name="segment2D_1">The first segment.</param>
        /// <param name="segment2D_2">The second segment.</param>
        /// <returns>True if the segments have the same start point and vector; otherwise, false.</returns>
        public static bool operator ==(Segment2D? segment2D_1, Segment2D? segment2D_2)
        {
            if (segment2D_1 is null && segment2D_2 is null)
            {
                return true;
            }

            if (segment2D_1?.start is not Point2D start)
            {
                return false;
            }

            if (segment2D_1?.vector is not Vector2D vector)
            {
                return false;
            }

            return start.Equals(segment2D_2?.start) && vector.Equals(segment2D_2.vector);
        }

        /// <summary>
        /// Creates a clone of the current segment.
        /// </summary>
        /// <returns>A cloned <see cref="ISerializableObject"/>.</returns>
        public override ISerializableObject? Clone()
        {
            return new Segment2D(this);
        }

        /// <summary>
        /// Finds the point on the segment closest to the specified point.
        /// </summary>
        /// <param name="point2D">The target point.</param>
        /// <returns>The closest <see cref="Point2D"/> on the segment, or null if input is null.</returns>
        public Point2D? ClosestPoint(Point2D? point2D)
        {
            return Query.ClosestPoint(point2D, start, End, true);
        }

        /// <summary>
        /// Checks if the segment is collinear with another linear geometry.
        /// </summary>
        /// <param name="linear2D">The other linear geometry.</param>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>True if they are collinear; otherwise, false.</returns>
        public bool Collinear(ILinear2D? linear2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            return Query.Collinear(this, linear2D, tolerance);
        }

        /// <summary>
        /// Calculates the minimum distance from a point to the segment.
        /// </summary>
        /// <param name="point2D">The target point.</param>
        /// <returns>The distance result, or NaN if input is null.</returns>
        public double Distance(Point2D? point2D)
        {
            if (point2D == null)
            {
                return double.NaN;
            }

            return point2D.Distance(ClosestPoint(point2D));
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current segment.
        /// </summary>
        /// <param name="obj">The object to compare with.</param>
        /// <returns>True if the objects are equal; otherwise, false.</returns>
        public override bool Equals(object? obj)
        {
            Segment2D? segment2D = obj as Segment2D;
            if (segment2D == null)
            {
                return false;
            }

            if (segment2D.start is null && start is null && segment2D.vector is null && vector is null)
            {
                return true;
            }

            if (segment2D.start is null || start is null || segment2D.vector is null || vector is null)
            {
                return false;
            }

            return segment2D.start.Equals(start) && segment2D.vector.Equals(vector);
        }

        /// <summary>
        /// Calculates the axis-aligned bounding box of the segment.
        /// </summary>
        /// <returns>A new <see cref="BoundingBox2D"/>, or null if start or vector is null.</returns>
        public BoundingBox2D? GetBoundingBox()
        {
            if (start is null || vector is null)
            {
                return null;
            }

            return new BoundingBox2D(start, End);
        }

        /// <summary>
        /// Gets the hash code for this segment.
        /// </summary>
        /// <returns>A 32-bit signed integer hash code.</returns>
        public override int GetHashCode()
        {
            int hashCode = 1695988409;
            hashCode = hashCode * -1521134295 + EqualityComparer<Point2D?>.Default.GetHashCode(start);
            hashCode = hashCode * -1521134295 + EqualityComparer<Vector2D?>.Default.GetHashCode(vector);
            return hashCode;
        }

        /// <summary>
        /// Returns a list containing the start and end points of the segment.
        /// </summary>
        /// <returns>A list of two points, or null if endpoints are missing.</returns>
        public List<Point2D>? GetPoints()
        {
            if (Start is not Point2D start || End is not Point2D end)
            {
                return null;
            }

            return [start, end];
        }

        /// <summary>
        /// Returns a list containing the current segment as its only element.
        /// </summary>
        /// <returns>A list of one <see cref="Segment2D"/>.</returns>
        public List<Segment2D>? GetSegments()
        {
            return [new(this)];
        }

        /// <summary>
        /// Finds the intersection point between this segment and another.
        /// </summary>
        /// <param name="segment2D">The other segment.</param>
        /// <param name="tolerance">The distance tolerance for detecting an intersection.</param>
        /// <returns>The <see cref="Point2D"/> of intersection, or null if no intersection is found.</returns>
        public Point2D? IntersectionPoint(Segment2D? segment2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segment2D == null)
            {
                return null;
            }

            return Query.IntersectionPoint(start, End, segment2D.start, segment2D.End, true, tolerance);
        }

        /// <summary>
        /// Inverts the direction of the segment by swapping start and end points.
        /// </summary>
        /// <returns>True if inversion was successful; otherwise, false.</returns>
        public bool Inverse()
        {
            if (vector is null)
            {
                return false;
            }

            return vector.Inverse();
        }

        /// <summary>
        /// Calculates the midpoint of the segment.
        /// </summary>
        /// <returns>The midpoint as a <see cref="Point2D"/>, or null if start or vector is missing.</returns>
        public Point2D? Mid()
        {
            if (start is null || vector is null)
            {
                return null;
            }

            return start.Mid(End);
        }

        /// <summary>
        /// Moves the segment by the specified translation vector.
        /// </summary>
        /// <param name="vector2D">The movement vector.</param>
        /// <returns>True if move was successful; otherwise, false.</returns>
        public override bool Move(Vector2D? vector2D)
        {
            if (vector2D is null || start is null)
            {
                return false;
            }

            start.Move(vector2D);
            return true;
        }

        /// <summary>
        /// Checks if the specified point lies on the segment within a given tolerance.
        /// </summary>
        /// <param name="point2D">The target point.</param>
        /// <param name="tolerance">The distance tolerance for the check.</param>
        /// <returns>True if the point is on the segment; otherwise, false.</returns>
        public bool On(Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            double distance = Distance(point2D);
            if (double.IsNaN(distance))
            {
                return false;
            }

            return distance < tolerance;
        }

        /// <summary>
        /// Projects a point onto the line containing the segment, without clamping to the segment boundaries.
        /// </summary>
        /// <param name="point2D">The target point.</param>
        /// <returns>The projected <see cref="Point2D"/> on the infinite line, or null if input is missing.</returns>
        public Point2D? Project(Point2D? point2D)
        {
            if (point2D is null || start is null)
            {
                return null;
            }

            return Query.ClosestPoint(point2D, start, End, false);
        }

        /// <summary>
        /// Applies a 2D transformation to the segment's endpoints and vector.
        /// </summary>
        /// <param name="transform">The transform to apply.</param>
        /// <returns>True if transformation was successful; otherwise, false.</returns>
        public override bool Transform(ITransform2D? transform)
        {
            if (transform is null || start is null || vector is null)
            {
                return false;
            }

            Point2D? end = End;

            start.Transform(transform);
            end?.Transform(transform);

            vector = new(start, end);
            return true;
        }
    }
}
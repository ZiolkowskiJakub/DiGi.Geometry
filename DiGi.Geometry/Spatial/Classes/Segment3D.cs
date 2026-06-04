using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents a three-dimensional line segment defined by two points in 3D space.
    /// </summary>
    /// <summary>
    /// Initializes a new instance of the <see cref="Segment3D"/> class using a <see cref="JsonObject"/>.
    /// </summary>
    /// <param name="jsonObject">The <see cref="JsonObject"/> containing the segment data.</param>
    /// <summary>
    /// Initializes a new instance of the <see cref="Segment3D"/> class using the coordinates of the start and end points.
    /// </summary>
    /// <param name="x_1">The X coordinate of the starting point.</param>
    /// <param name="y_1">The Y coordinate of the starting point.</param>
    /// <param name="z_1">The Z coordinate of the starting point.</param>
    /// <param name="x_2">The X coordinate of the ending point.</param>
    /// <param name="y_2">The Y coordinate of the ending point.</param>
    /// <param name="z_2">The Z coordinate of the ending point.</param>
    /// <summary>
    /// Initializes a new instance of the <see cref="Segment3D"/> class using start and end points.
    /// </summary>
    /// <param name="start">The starting <see cref="Point3D"/> of the segment.</param>
    /// <param name="end">The ending <see cref="Point3D"/> of the segment.</param>
    public class Segment3D : Geometry3D, ISegmentable3D, ILinear3D, ISegment<Point3D>
    {
        private Point3D? start;
        private Vector3D? vector;

        /// <summary>
        /// Initializes a new instance of the <see cref="Segment3D"/> class from the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data used to initialize this instance.</param>
        public Segment3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Segment3D"/> class using the coordinates of two points.
        /// </summary>
        /// <param name="x_1">The double x-coordinate of the first point.</param>
        /// <param name="y_1">The double y-coordinate of the first point.</param>
        /// <param name="z_1">The double z-coordinate of the first point.</param>
        /// <param name="x_2">The double x-coordinate of the second point.</param>
        /// <param name="y_2">The double y-coordinate of the second point.</param>
        /// <param name="z_2">The double z-coordinate of the second point.</param>
        public Segment3D(double x_1, double y_1, double z_1, double x_2, double y_2, double z_2)
            : this(new Point3D(x_1, y_1, z_1), new Point3D(x_2, y_2, z_2))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Segment3D"/> class using a starting point and an ending point.
        /// </summary>
        /// <param name="start">The <see cref="Point3D"/> representing the start of the segment.</param>
        /// <param name="end">The <see cref="Point3D"/> representing the end of the segment.</param>
        public Segment3D(Point3D? start, Point3D? end)
            : base()
        {
            if (start != null && end != null)
            {
                this.start = DiGi.Core.Query.Clone(start);
                vector = new Vector3D(start, end);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Segment3D"/> class using the specified <see cref="Point3D"/> start point and <see cref="Vector3D"/> vector.
        /// </summary>
        /// <param name="start">The <see cref="Point3D"/> that defines the starting point of the segment.</param>
        /// <param name="vector">The <see cref="Vector3D"/> that defines the direction and length of the segment.</param>
        public Segment3D(Point3D? start, Vector3D? vector)
        {
            this.start = DiGi.Core.Query.Clone(start);
            this.vector = DiGi.Core.Query.Clone(vector);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Segment3D"/> class based on an existing <see cref="Segment3D"/> object.
        /// </summary>
        /// <param name="segment3D">The <see cref="Segment3D"/> object to copy from.</param>
        public Segment3D(Segment3D? segment3D)
        : this(segment3D?.start, segment3D?.vector)
        {
        }

        /// <summary>
        /// Gets the normalized direction as a <see cref="Vector3D"/>.
        /// Returns null if the underlying vector is not defined.
        /// </summary>
        [JsonIgnore]
        public Vector3D? Direction
        {
            get
            {
                return vector?.Unit;
            }
        }

        /// <summary>
        /// Gets or sets the end point of the line segment.
        /// </summary>
        /// <value>
        /// A <see cref="Point3D"/> representing the calculated end point, or <c>null</c> if the start point or vector is not defined.
        /// </value>
        [JsonIgnore]
        public Point3D? End
        {
            get
            {
                if (vector == null || start == null)
                {
                    return null;
                }

                Point3D result = new(start);
                result.Move(vector);

                return result;
            }

            set
            {
                if (value == null || start == null)
                {
                    return;
                }

                vector = new Vector3D(start, value);
            }
        }

        /// <summary>
        /// Gets the length of the segment.
        /// </summary>
        /// <value>
        /// A <see cref="double"/> representing the distance between the start and end points, or <see cref="double.NaN"/> if either point is null.
        /// </value>
        [JsonIgnore]
        public double Length
        {
            get
            {
                if (start is null)
                {
                    return double.NaN;
                }

                Point3D? end = End;
                if (end == null)
                {
                    return double.NaN;
                }

                return start.Distance(end);
            }
        }

        /// <summary>
        /// Gets the squared length of the vector.
        /// </summary>
        /// <value>
        /// A <see cref="double"/> representing the squared length, or <see cref="double.NaN"/> if the vector is null.
        /// </value>
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
        /// Gets or sets the starting <Point3D> position.
        /// </summary>
        [JsonPropertyName("Start")]
        public Point3D? Start
        {
            get
            {
                return DiGi.Core.Query.Clone(start);
            }

            set
            {
                start = DiGi.Core.Query.Clone(value);
            }
        }

        /// <summary>
        /// Gets or sets the <see cref="Vector3D"/> value.
        /// </summary>
        [JsonPropertyName("Vector")]
        public Vector3D? Vector
        {
            get
            {
                return DiGi.Core.Query.Clone(vector);
            }

            set
            {
                vector = DiGi.Core.Query.Clone(value);
            }
        }

        public Point3D? this[int index]
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
        /// Creates a copy of the current instance.
        /// </summary>
        /// <returns>An <see cref="ISerializableObject"/> that is a copy of the current instance, or null.</returns>
        public override ISerializableObject? Clone()
        {
            return new Segment3D(this);
        }

        /// <summary>
        /// Calculates the closest <see cref="Point3D"/> on the object to the specified <see cref="Point3D"/>.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> for which the closest point is calculated.</param>
        /// <returns>The closest <see cref="Point3D"/> found, or null if it cannot be determined.</returns>
        public Point3D? ClosestPoint(Point3D? point3D)
        {
            return Query.ClosestPoint(point3D, start, End, true);
        }

        /// <summary>
        /// Determines whether this linear object is collinear with the specified <see cref="ILinear3D"/> object within a given tolerance.
        /// </summary>
        /// <param name="linear3D">The <see cref="ILinear3D"/> object to check for collinearity.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used to determine if the directions are collinear.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the objects are collinear; otherwise, false.</returns>
        public bool Collinear(ILinear3D? linear3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (Direction is not Vector3D direction_1 || linear3D?.Direction is not Vector3D direction_2)
            {
                return false;
            }

            return direction_1.Collinear(direction_2, tolerance);
        }

        /// <summary>
        /// Calculates the distance between this object and the specified <see cref="Point3D"/>.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> to calculate the distance to.</param>
        /// <returns>A <see cref="double"/> representing the calculated distance.</returns>
        public double Distance(Point3D? point3D)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Calculates and returns the 3D bounding box for the current object.
        /// </summary>
        /// <returns>A <see cref="BoundingBox3D"/> representing the bounding box, or <see langword="null"/> if the start point or vector is not defined.</returns>
        public BoundingBox3D? GetBoundingBox()
        {
            if (start == null || vector == null)
            {
                return null;
            }

            return new BoundingBox3D(start, End);
        }

        /// <summary>
        /// Retrieves the list of <see cref="Point3D"/> points defining the segment.
        /// </summary>
        /// <returns>A <see cref="List{T}"/> of <see cref="Point3D"/> objects containing the start and end points if they are valid; otherwise, null.</returns>
        public List<Point3D>? GetPoints()
        {
            if (start is null || vector is null || End is not Point3D end)
            {
                return null;
            }

            return [new Point3D(start), end];
        }

        /// <summary>
        /// Retrieves a list of <see cref="Segment3D"/> segments.
        /// </summary>
        /// <returns>A <see cref="List{T}"/> containing the <see cref="Segment3D"/> instances, or null.</returns>
        public List<Segment3D>? GetSegments()
        {
            return [new Segment3D(this)];
        }

        /// <summary>
        /// Inverts the direction of the vector and swaps the start point with the end point.
        /// </summary>
        /// <returns>A <see cref="bool"/> value indicating whether the inversion was successful. Returns true if the end point is a <see cref="Point3D"/> and the vector is not null; otherwise, false.</returns>
        public bool Inverse()
        {
            if (End is not Point3D end || vector is null)
            {
                return false;
            }

            vector.Inverse();
            start = end;

            return true;
        }

        /// <summary>
        /// Calculates the midpoint of the segment.
        /// </summary>
        /// <returns>A <see cref="Point3D"/> representing the midpoint if the starting point and vector are valid; otherwise, <see langword="null"/>.</returns>
        public Point3D? Mid()
        {
            if (start == null || vector == null)
            {
                return null;
            }

            return start.Mid(End);
        }

        /// <summary>
        /// Moves the object by the specified <see cref="Vector3D"/>.
        /// </summary>
        /// <param name="vector3D">The <see cref="Vector3D"/> translation vector.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the move operation was successful.</returns>
        public override bool Move(Vector3D? vector3D)
        {
            if (start == null || vector3D == null)
            {
                return false;
            }

            return start.Move(vector3D);
        }

        /// <summary>
        /// Determines whether the specified <see cref="Point3D"/> is located on the entity within a given tolerance.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> to evaluate.</param>
        /// <param name="tolerance">The <see cref="double"/> distance tolerance used to determine if the point is on the entity.</param>
        /// <returns>A <see cref="bool"/> value indicating <c>true</c> if the point is within the specified tolerance; otherwise, <c>false</c>.</returns>
        public bool On(Point3D? point3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            Point3D? point3D_Temp = ClosestPoint(point3D);
            if (point3D_Temp == null)
            {
                return false;
            }

            return point3D!.Distance(point3D_Temp) < tolerance;
        }

        /// <summary>
        /// Projects the specified <see cref="Point3D"/> onto the line segment.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> to project.</param>
        /// <returns>The projected <see cref="Point3D"/>, or null if the projection cannot be determined.</returns>
        public Point3D? Project(Point3D? point3D)
        {
            return Query.ClosestPoint(point3D, start, End, false);
        }

        /// <summary>
        /// Transforms the object using the specified 3D transformation.
        /// </summary>
        /// <param name="transform">The <see cref="ITransform3D"/> instance used to perform the transformation.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the transformation was successfully applied.</returns>
        public bool Transform(ITransform3D? transform)
        {
            throw new System.NotImplementedException();
        }
    }
}
using DiGi.Core;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents a line in 3D space defined by an origin point and a direction vector.
    /// </summary>
    public class Line3D : Geometry3D, ILinear3D
    {
        [JsonInclude, JsonPropertyName("Direction")]
        private Vector3D? direction;

        [JsonInclude, JsonPropertyName("Origin")]
        private Point3D? origin;

        /// <summary>
        /// Initializes a new instance of the <see cref="Line3D"/> class by cloning an existing <see cref="Line3D"/> object.
        /// </summary>
        /// <param name="line3D">The source <see cref="Line3D"/> object to clone.</param>
        public Line3D(Line3D? line3D)
        {
            if (line3D is not null)
            {
                origin = DiGi.Core.Query.Clone(line3D.origin);
                direction = DiGi.Core.Query.Clone(line3D.direction);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Line3D"/> class with the specified origin point and direction vector.
        /// </summary>
        /// <param name="origin">The <see cref="Point3D"/> that defines the origin of the line.</param>
        /// <param name="direction">The <see cref="Vector3D"/> that defines the direction of the line.</param>
        public Line3D(Point3D? origin, Vector3D? direction)
        {
            this.origin = DiGi.Core.Query.Clone(origin);
            this.direction = direction?.Unit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Line3D"/> class using two <see cref="Point3D"/> points to define the origin and direction.
        /// </summary>
        /// <param name="point3D_1">The <see cref="Point3D"/> that defines the origin of the line.</param>
        /// <param name="point3D_2">The <see cref="Point3D"/> used to determine the unit direction vector from the origin.</param>
        public Line3D(Point3D? point3D_1, Point3D? point3D_2)
        {
            origin = DiGi.Core.Query.Clone(point3D_1);
            direction = new Vector3D(point3D_1, point3D_2).Unit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Line3D"/> class.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the instance.</param>
        public Line3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the <see cref="Vector3D"/> representing the direction.
        /// </summary>
        /// <value>A nullable <see cref="Vector3D"/> that defines the direction.</value>
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
        /// Gets or sets the origin point of the 3D line.
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
        /// Indicates whether the two specified <see cref="Line3D"/> objects are not equal.
        /// </summary>
        /// <param name="line3D_1">The first <see cref="Line3D"/> object to compare.</param>
        /// <param name="line3D_2">The second <see cref="Line3D"/> object to compare.</param>
        /// <returns><see langword="true"/> if the objects are not equal; otherwise, <see langword="false"/>.</returns>
        public static bool operator !=(Line3D? line3D_1, Line3D? line3D_2)
        {
            return !(line3D_1 == line3D_2);
        }

        /// <summary>
        /// Indicates whether the two specified <see cref="Line3D"/> objects are equal.
        /// </summary>
        /// <param name="line3D_1">The first <see cref="Line3D"/> object to compare.</param>
        /// <param name="line3D_2">The second <see cref="Line3D"/> object to compare.</param>
        /// <returns><see langword="true"/> if the objects are equal; otherwise, <see langword="false"/>.</returns>
        public static bool operator ==(Line3D? line3D_1, Line3D? line3D_2)
        {
            if (line3D_1 is null && line3D_2 is null)
            {
                return true;
            }

            if (line3D_1 is null || line3D_2 is null)
            {
                return false;
            }

            return line3D_1.origin == line3D_2.origin && line3D_1.direction == line3D_2.direction;
        }

        /// <summary>
        /// Creates a copy of the current object.
        /// </summary>
        /// <returns>A new <see cref="ISerializableObject"/> instance that is a clone of the current object, or <see langword="null"/>.</returns>
        public override ISerializableObject? Clone()
        {
            return new Line3D(this);
        }

        /// <summary>
        /// Calculates the closest point on the geometry to the specified <see cref="Point3D"/>.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> for which the closest point is calculated.</param>
        /// <returns>The closest <see cref="Point3D"/> on the geometry, or null if it cannot be determined.</returns>
        public Point3D? ClosestPoint(Point3D? point3D)
        {
            return Project(point3D);
        }

        /// <summary>
        /// Determines whether this linear object is collinear with the specified <see cref="ILinear3D"/> object within a given tolerance.
        /// </summary>
        /// <param name="linear3D">The <see cref="ILinear3D"/> object to check for collinearity.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the tolerance used for the comparison.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the objects are collinear; returns false if either linear object is null.</returns>
        public bool Collinear(ILinear3D? linear3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (direction is null || linear3D?.Direction is not Vector3D direction_Temp)
            {
                return false;
            }

            return direction.Collinear(direction_Temp, tolerance);
        }

        /// <summary>
        /// Calculates the distance between a specified <see cref="Point3D"/> and this object.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> instance to calculate the distance from.</param>
        /// <returns>A <see cref="double"/> representing the distance, or <see cref="double.NaN"/> if the provided <see cref="Point3D"/> is null or cannot be projected.</returns>
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
        /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="Line3D"/>.
        /// </summary>
        /// <param name="obj">The <see cref="object"/> to compare with the current <see cref="Line3D"/>.</param>
        /// <returns><see langword="true"/> if the specified <see cref="object"/> is a <see cref="Line3D"/> and has the same origin and direction as the current instance; otherwise, <see langword="false"/>.</returns>
        public override bool Equals(object obj)
        {
            if (obj is not Line3D line3D)
            {
                return false;
            }

            return line3D.origin == origin && line3D.direction == direction;
        }

        /// <summary>
        /// Returns a hash code for the current object based on its origin and direction.
        /// </summary>
        /// <returns>An <see cref="int"/> representing the hash code of the instance.</returns>
        public override int GetHashCode()
        {
            int hashCode = -1652769719;
            hashCode = hashCode * -1521134295 + EqualityComparer<Vector3D?>.Default.GetHashCode(direction);
            hashCode = hashCode * -1521134295 + EqualityComparer<Point3D?>.Default.GetHashCode(origin);
            return hashCode;
        }

        /// <summary>
        /// Calculates the intersection point between this object and the specified <see cref="Line3D"/>.
        /// </summary>
        /// <param name="line3D">The <see cref="Line3D"/> to intersect with.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance for the intersection calculation.</param>
        /// <returns>A <see cref="Point3D"/> representing the intersection point if one exists; otherwise, null.</returns>
        public Point3D? IntersectionPoint(Line3D? line3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (line3D == null)
            {
                return null;
            }

            return Query.IntersectionPoint(origin, direction, line3D.origin, line3D.direction, false, tolerance);
        }

        /// <summary>
        /// Calculates the intersection point between this object and a specified <see cref="Segment3D"/>.
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
        /// Moves the object by the specified <see cref="Vector3D"/>.
        /// </summary>
        /// <param name="vector3D">The <see cref="Vector3D"/> that defines the translation.</param>
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
        /// Determines whether the specified <see cref="Point3D"/> is located on the object within a given tolerance.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> to evaluate.</param>
        /// <param name="tolerance">The <see cref="double"/> value representing the maximum allowable distance for the point to be considered on the object.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the <see cref="Point3D"/> is within the specified tolerance of the object.</returns>
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
        /// Projects a given <see cref="Point3D"/> onto the line defined by the origin and direction.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> to project.</param>
        /// <returns>The projected <see cref="Point3D"/>, or null if the projection cannot be determined.</returns>
        public Point3D? Project(Point3D? point3D)
        {
            return Query.ClosestPoint(point3D, origin, origin + direction, false);
        }

        /// <summary>
        /// Transforms the origin and direction of the object using the specified <see cref="ITransform3D"/> transformation.
        /// </summary>
/// <param name="transform">The <see cref="ITransform3D"/> instance to apply for the transformation.</param>
/// <returns>A <see cref="bool"/> value indicating whether the transformation was successfully applied; returns <c>false</c> if the <see cref="ITransform3D"/> transform, origin, or direction is null.</returns>
        public bool Transform(ITransform3D? transform)
        {
            if (transform == null || origin == null || direction == null)
            {
                return false;
            }

            Point3D point2D = new(origin);
            point2D.Move(direction);

            origin.Transform(transform);

            point2D.Transform(transform);
            direction = new(origin, point2D);
            direction.Normalize();

            return true;
        }
    }
}

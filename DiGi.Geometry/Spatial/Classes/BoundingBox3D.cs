using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents a three-dimensional bounding box defined by minimum and maximum <see cref="Point3D"/> points.
    /// </summary>
    /// <summary>
    /// Initializes a new instance of the <see cref="BoundingBox3D"/> class using two <see cref="Point3D"/> points to determine the boundaries.
    /// </summary>
    /// <param name="point2D_1">The first <see cref="Point3D"/> point used to calculate the bounding box.</param>
    /// <param name="point2D_2">The second <see cref="Point3D"/> point used to calculate the bounding box.</param>
    /// <summary>
    /// Initializes a new instance of the <see cref="BoundingBox3D"/> class using a collection of <see cref="Point3D"/> points.
    /// </summary>
    /// <param name="point3Ds">An <see cref="IEnumerable{T}"/> of <see cref="Point3D"/> points used to determine the boundaries.</param>
    public class BoundingBox3D : Geometry3D, IBoundingBox<Point3D>
    {
        [JsonInclude, JsonPropertyName("Max")]
        private Point3D? max;

        [JsonInclude, JsonPropertyName("Min")]
        private Point3D? min;

        /// <summary>
        /// Initializes a new instance of the <see cref="BoundingBox3D"/> class using two <see cref="Point3D?"/> points to define the boundaries.
        /// </summary>
        /// <param name="point2D_1">The first <see cref="Point3D?"/> point used to calculate the minimum and maximum bounds.</param>
        /// <param name="point2D_2">The second <see cref="Point3D?"/> point used to calculate the minimum and maximum bounds.</param>
        public BoundingBox3D(Point3D? point2D_1, Point3D? point2D_2)
            : base()
        {
            min = Query.Min([point2D_1, point2D_2], out max);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoundingBox3D"/> class using a collection of nullable <see cref="Point3D"/> objects.
        /// </summary>
        /// <param name="point3Ds">An <see cref="IEnumerable{T}"/> of nullable <see cref="Point3D"/> objects used to determine the minimum and maximum boundaries of the bounding box.</param>
        public BoundingBox3D(IEnumerable<Point3D?>? point3Ds)
        {
            if (point3Ds is not null)
            {
                min = Query.Min(point3Ds, out max);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoundingBox3D"/> class using a collection of <see cref="Point3D"/> points and a specified offset.
        /// </summary>
        /// <param name="point3Ds">The <see cref="IEnumerable{T}"/> of <see cref="Point3D"/> objects used to determine the minimum and maximum boundaries.</param>
        /// <param name="offset">The <see cref="double"/> value to apply as an offset to the bounding box.</param>
        public BoundingBox3D(IEnumerable<Point3D?>? point3Ds, double offset)
        {
            min = Query.Min(point3Ds, out max);

            Offset(offset);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoundingBox3D"/> class using a specified <see cref="Point3D"/> and an offset value.
        /// </summary>
        /// <param name="point3D">The optional <see cref="Point3D"/> to serve as the center point for the bounding box.</param>
        /// <param name="offset">The <see cref="double"/> offset used to determine the extent of the bounding box from the center point.</param>
        public BoundingBox3D(Point3D? point3D, double offset)
        {
            min = point3D == null ? null : new Point3D(point3D);
            max = point3D == null ? null : new Point3D(point3D);

            Offset(offset);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoundingBox3D"/> class using an existing <see cref="BoundingBox3D"/> object.
        /// </summary>
        /// <param name="boundingBox3D">The <see cref="BoundingBox3D"/> object to copy values from.</param>
        public BoundingBox3D(BoundingBox3D? boundingBox3D)
            : base(boundingBox3D)
        {
            if (boundingBox3D != null)
            {
                min = boundingBox3D.Min;
                max = boundingBox3D.Max;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoundingBox3D"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data to initialize the bounding box. This value can be null.</param>
        public BoundingBox3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the depth value, calculated as the difference between the Y-coordinate of the maximum point and the Y-coordinate of the minimum point.
        /// Returns a <see cref="double.NaN"/> if either the maximum or minimum points are null.
        /// </summary>
        /// <value>A <see cref="double"/> representing the depth.</value>
        [JsonIgnore]
        public double Depth
        {
            get
            {
                if (max == null || min == null)
                {
                    return double.NaN;
                }

                return max.Y - min.Y;
            }
        }

        /// <summary>
        /// Gets the height of the object, calculated as the difference between the Z-coordinate of the maximum point and the Z-coordinate of the minimum point.
        /// </summary>
        /// <value>
        /// A <see cref="double"/> representing the height, or <see cref="double.NaN"/> if the bounds are not defined.
        /// </value>
        [JsonIgnore]
        public double Height
        {
            get
            {
                if (max == null || min == null)
                {
                    return double.NaN;
                }

                return max.Z - min.Z;
            }
        }

        /// <summary>
        /// Gets or sets the maximum boundary point of the bounding volume.
        /// Setting this value expands the bounds to include the specified <see cref="Point3D"/>.
        /// </summary>
        /// <value>The <see cref="Point3D"/> representing the maximum coordinates.</value>
        [JsonIgnore]
        public Point3D Max
        {
            get
            {
                return new Point3D(max);
            }
            set
            {
                if (min == null)
                {
                    max = new Point3D(value);
                    min = new Point3D(value);
                }
                else
                {
                    max = Query.Max(min, value);
                    min = Query.Min(min, value);
                }
            }
        }

        /// <summary>
        /// Gets or sets the minimum <see cref="Point3D"/> point of the boundary.
        /// </summary>
        /// <value>The <see cref="Point3D"/> representing the minimum coordinates.</value>
        [JsonIgnore]
        public Point3D Min
        {
            get
            {
                return new Point3D(min);
            }
            set
            {
                if (max == null)
                {
                    max = new Point3D(value);
                    min = new Point3D(value);
                }
                else
                {
                    max = Query.Max(max, value);
                    min = Query.Min(max, value);
                }
            }
        }

        /// <summary>
        /// Gets the width of the bounding area.
        /// </summary>
        /// <value>A <double> representing the difference between the maximum X coordinate and the minimum X coordinate, or <double.NaN> if either point is null.</value>
        [JsonIgnore]
        public double Width
        {
            get
            {
                if (max == null || min == null)
                {
                    return double.NaN;
                }

                return max.X - min.X;
            }
        }

        /// <summary>
        /// Adds a <Point3D> to the bounding volume and updates the minimum and maximum bounds.
        /// </summary>
        /// <param name="point3D">The <Point3D> instance to add.</param>
        /// <returns>A <bool> value indicating whether the point was successfully added; returns false if the provided <Point3D> is null.</returns>
        public bool Add(Point3D? point3D)
        {
            if (point3D == null)
            {
                return false;
            }

            max = new(Query.Max(max, point3D));
            min = new(Query.Min(min, point3D));
            return true;
        }

        /// <summary>
        /// Adds a <see cref="BoundingBox3D"/> to the collection.
        /// </summary>
        /// <param name="boundingBox3D">The <see cref="BoundingBox3D"/> instance to add.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the <see cref="BoundingBox3D"/> was successfully added; returns <c>false</c> if the provided <see cref="BoundingBox3D"/> or its minimum and maximum points are null.</returns>
        public bool Add(BoundingBox3D? boundingBox3D)
        {
            if (boundingBox3D == null)
            {
                return false;
            }

            Point3D min = boundingBox3D.Min;
            if (min == null)
            {
                return false;
            }

            Point3D max = boundingBox3D.Max;
            if (max == null)
            {
                return false;
            }

            Add(min);
            Add(max);
            return true;
        }

        /// <summary>
        /// Creates a copy of the current <see cref="BoundingBox3D"/> instance.
        /// </summary>
        /// <returns>An <see cref="ISerializableObject"/> that is a clone of the current instance.</returns>
        public override ISerializableObject Clone()
        {
            return new BoundingBox3D(this);
        }

        /// <summary>
        /// Calculates the centroid of the object.
        /// </summary>
        /// <returns>A <see cref="Point3D"/> representing the centroid, or null if it cannot be calculated.</returns>
        public Point3D? GetCentroid()
        {
            return min?.Mid(max);
        }

        /// <summary>
        /// Retrieves a list of <see cref="Point3D"/> objects representing the corners of the volume.
        /// </summary>
        /// <returns>A <see cref="List{Point3D}"/> containing the calculated points, or <see langword="null"/> if the minimum or maximum bounds are not defined.</returns>
        public List<Point3D>? GetPoints()
        {
            if (min == null || max == null)
            {
                return null;
            }

            double x = Width;
            double y = Depth;

            return
            [
                new (min),
                new (min.X + x, min.Y, Min.Z),
                new (min.X + x, min.Y + y, Min.Z),
                new (min.X, min.Y + y, Min.Z),

                new (max),
                new (max.X + x, max.Y, max.Z),
                new (max.X + x, max.Y + y, max.Z),
                new (max.X, max.Y + y, max.Z),
            ];
        }

        /// <summary>
        /// Calculates the volume based on the width, height, and depth properties.
        /// </summary>
        /// <returns>The calculated volume as a <see cref="double"/>, or <see cref="double.NaN"/> if any of the dimensions are <see cref="double.NaN"/>.</returns>
        public double GetVolume()
        {
            double width = Width;
            if (double.IsNaN(width))
            {
                return double.NaN;
            }

            double height = Height;
            if (double.IsNaN(height))
            {
                return double.NaN;
            }

            double depth = Depth;
            if (double.IsNaN(depth))
            {
                return double.NaN;
            }

            return width * height * depth;
        }

        /// <summary>
        /// Determines whether the range defined by two points intersects any of the associated planes within a specified tolerance.
        /// </summary>
        /// <param name="point3D_1">The first <see cref="Point3D?"> point defining the range.</param>
        /// <param name="point3D_2">The second <see cref="Point3D?"> point defining the range.</param>
        /// <param name="bounded_1">A <see cref="bool"/> value indicating whether the first point is bounded.</param>
        /// <param name="bounded_2">A <see cref="bool"/> value indicating whether the second point is bounded.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance used for distance calculations.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the range is within the specified criteria.</returns>
        public bool InRange(Point3D? point3D_1, Point3D? point3D_2, bool bounded_1, bool bounded_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point3D_1 is null || point3D_2 is null)
            {
                return false;
            }

            List<Plane>? planes = Create.Planes(this);
            if (planes == null || planes.Count == 0)
            {
                return false;
            }

            for (int i = 0; i < planes.Count; i++)
            {
                PlanarIntersectionResult? planarIntersectionResult = Create.PlanarIntersectionResult(planes[i], point3D_1, point3D_2, bounded_1, bounded_2, tolerance);
                if (planarIntersectionResult == null || !planarIntersectionResult.Intersect)
                {
                    continue;
                }

                Point3D? point3D_Intersection = planarIntersectionResult.GetGeometry3Ds<Point3D>()?.FirstOrDefault();
                if (point3D_Intersection == null)
                {
                    continue;
                }

                if (On(point3D_Intersection, tolerance))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Determines whether the specified <see cref="Ray3D"/> is within the range, considering a given tolerance.
        /// </summary>
        /// <param name="ray3D">The <see cref="Ray3D"/> to check for being in range.</param>
        /// <param name="tolerance">The <see cref="double"/> value representing the distance tolerance.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the <see cref="Ray3D"/> is within the range.</returns>
        public bool InRange(Ray3D? ray3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (ray3D?.Origin is not Point3D origin || ray3D.Direction is not Vector3D direction)
            {
                return false;
            }

            return InRange(origin, origin + direction, true, false, tolerance);
        }

        /// <summary>
        /// Determines whether the specified <see cref="Point3D"/> is within the defined range, considering a given tolerance.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> to evaluate.</param>
        /// <param name="tolerance">The <see cref="double"/> value representing the allowed distance tolerance.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the point is within the range.</returns>
        public bool InRange(Point3D? point3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point3D is null || min is null || max is null)
            {
                return false;
            }

            return (point3D.X >= min.X - tolerance && point3D.X <= max.X + tolerance && point3D.Y >= min.Y - tolerance && point3D.Y <= max.Y + tolerance && point3D.Z >= min.Z - tolerance && point3D.Z <= max.Z + tolerance);
        }

        /// <summary>
        /// Determines whether the object is within a specified tolerance of the given <see cref="Line3D"/>.
        /// </summary>
        /// <param name="line3D">The <see cref="Line3D"/> to check against.</param>
        /// <param name="tolerance">The <see cref="double"/> value representing the distance tolerance.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the object is within range of the line.</returns>
        public bool InRange(Line3D? line3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (line3D?.Origin is not Point3D origin || line3D.Direction is not Vector3D direction)
            {
                return false;
            }

            return InRange(origin, origin + direction, false, false, tolerance);
        }

        /// <summary>
        /// Determines whether the specified <see cref="Segment3D"/> is within the range.
        /// </summary>
        /// <param name="segment3D">The <see cref="Segment3D"/> to evaluate.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used for the distance calculation.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the <see cref="Segment3D"/> is within the range.</returns>
        public bool InRange(Segment3D? segment3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segment3D?.Start is not Point3D origin || segment3D.End is not Point3D end)
            {
                return false;
            }

            return InRange(origin, end, true, true, tolerance);
        }

        /// <summary>
        /// Determines whether the specified <see cref="BoundingBox3D"/> is within range, considering a given tolerance.
        /// </summary>
        /// <param name="boundingBox3D">The <see cref="BoundingBox3D"/> to check.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance for the range check.</param>
        /// <returns>A <see cref="bool"/> value indicating <c>true</c> if the bounding box is within range; otherwise, <c>false</c>.</returns>
        public bool InRange(BoundingBox3D? boundingBox3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (boundingBox3D?.min is null || boundingBox3D?.max is null || max is null || min is null)
            {
                return false;
            }

            double max_1;
            double min_1;

            double max_2;
            double min_2;

            max_1 = max.X + tolerance;
            min_1 = min.X - tolerance;

            max_2 = boundingBox3D.max.X;
            min_2 = boundingBox3D.min.X;

            if (max_1 < min_2 || min_1 > max_2)
            {
                return false;
            }

            max_1 = max.Y + tolerance;
            min_1 = min.Y - tolerance;

            max_2 = boundingBox3D.max.Y;
            min_2 = boundingBox3D.min.Y;

            if (max_1 < min_2 || min_1 > max_2)
            {
                return false;
            }

            max_1 = max.Z + tolerance;
            min_1 = min.Z - tolerance;

            max_2 = boundingBox3D.max.Z;
            min_2 = boundingBox3D.min.Z;

            if (max_1 < min_2 || min_1 > max_2)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Determines whether the specified <see cref="ISegmentable3D"/> object is within the defined range, considering a distance tolerance.
        /// </summary>
        /// <param name="segmentable3D">The <see cref="ISegmentable3D"/> object to evaluate.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance used for the range check.</param>
        /// <returns>A <see cref="bool"/> value indicating <c>true</c> if the <see cref="ISegmentable3D"/> object is within range; otherwise, <c>false</c>.</returns>
        public bool InRange(ISegmentable3D? segmentable3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (min == null || max == null || segmentable3D == null)
            {
                return false;
            }

            BoundingBox3D? boundingBox3D = segmentable3D.GetBoundingBox();
            if (boundingBox3D == null)
            {
                return false;
            }

            List<Segment3D>? segment3Ds = segmentable3D.GetSegments();
            if (segment3Ds == null || segment3Ds.Count == 0)
            {
                return false;
            }

            if (!InRange(boundingBox3D, tolerance))
            {
                return false;
            }

            for (int i = 0; i < segment3Ds.Count; i++)
            {
                if (InRange(segment3Ds[i], tolerance))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Determines whether the object is within a specified tolerance of the given plane.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> to check against. If null, the method returns false.</param>
        /// <param name="tolerance">The <see cref="double"/> distance tolerance used to determine if the object is in range.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the object is within the specified tolerance of the plane.</returns>
        public bool InRange(Plane? plane, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (plane == null)
            {
                return false;
            }

            List<Point3D>? point3Ds = GetPoints();
            if (point3Ds == null || point3Ds.Count == 0)
            {
                return false;
            }

            if (InRange(point3Ds[0], tolerance))
            {
                return true;
            }

            bool above = Query.Above(plane, point3Ds[0], tolerance);
            for (int i = 1; i < point3Ds.Count; i++)
            {
                if (InRange(point3Ds[0], tolerance))
                {
                    return true;
                }

                if (Query.Above(plane, point3Ds[i], tolerance) != above)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Determines whether a specified <see cref="Point3D"/> is inside the bounding volume, accounting for a given tolerance.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> to check.</param>
        /// <param name="tolerance">The <see cref="double"/> value representing the distance tolerance used to shrink the boundary.</param>
        /// <returns>A <see cref="bool"/> indicating whether the <see cref="Point3D"/> is inside the volume; returns <c>false</c> if the point or bounding limits are null.</returns>
        public bool Inside(Point3D? point3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point3D == null || min is null || max is null)
            {
                return false;
            }

            return (point3D.X > min.X + tolerance && point3D.X < max.X - tolerance && point3D.Y > min.Y + tolerance && point3D.Y < max.Y - tolerance && point3D.Z > min.Z + tolerance && point3D.Z < max.Z - tolerance);
        }

        /// <summary>
        /// Moves the object by the specified Vector3D vector.
        /// </summary>
        /// <param name="vector3D">The Vector3D? vector to use for the movement.</param>
        /// <returns>A bool indicating whether the move operation was successful.</returns>
        public override bool Move(Vector3D? vector3D)
        {
            if (vector3D == null || min == null || max == null)
            {
                return false;
            }

            min.Move(vector3D);
            max.Move(vector3D);
            return true;
        }

        /// <summary>
        /// Offsets the minimum and maximum points of the bounding box by the specified double value.
        /// </summary>
        /// <param name="value">The double value to offset the boundaries by.</param>
        public void Offset(double value)
        {
            if (double.IsNaN(value) || min == null || max == null)
            {
                return;
            }

            min = new Point3D(min.X - value, min.Y - value, min.Z - value);
            max = new Point3D(max.X + value, max.Y + value, max.Z + value);
        }

        /// <summary>
        /// Determines whether the specified <see cref="Point3D"/> is located on the entity within the given tolerance.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> to evaluate.</param>
        /// <param name="tolerance">The <see cref="double"/> distance tolerance used for the calculation.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the point is on the entity.</returns>
        public bool On(Point3D? point3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point3D == null)
            {
                return false;
            }

            if (Inside(point3D, tolerance))
            {
                return false;
            }

            return InRange(point3D, tolerance);
        }
    }
}
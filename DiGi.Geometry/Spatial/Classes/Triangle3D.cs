using DiGi.Core;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents a three-dimensional triangle geometry.
    /// </summary>
    public class Triangle3D : Geometry3D, IPlanar<Triangle2D>, IPolygonal3D<Triangle2D>
    {
        [JsonInclude, JsonPropertyName("Points")]
        private readonly Point3D?[] points = new Point3D?[3];

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle3D"/> class using the provided <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data used to initialize this instance.</param>
        public Triangle3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle3D"/> class using another <see cref="Triangle3D"/> instance.
        /// </summary>
        /// <param name="triangle3D">The <see cref="Triangle3D"/> instance to copy from.</param>
        public Triangle3D(Triangle3D? triangle3D)
            : base(triangle3D)
        {
            if (triangle3D != null)
            {
                points[0] = triangle3D.points[0];
                points[1] = triangle3D.points[1];
                points[2] = triangle3D.points[2];
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle3D"/> class using three specified 3D points.
        /// </summary>
        /// <param name="point2D_1">The first <see cref="Point3D"/> point of the triangle.</param>
        /// <param name="point2D_2">The second <see cref="Point3D"/> point of the triangle.</param>
        /// <param name="point2D_3">The third <see cref="Point3D"/> point of the triangle.</param>
        public Triangle3D(Point3D? point2D_1, Point3D? point2D_2, Point3D? point2D_3)
            : base()
        {
            points[0] = point2D_1;
            points[1] = point2D_2;
            points[2] = point2D_3;
        }

        /// <summary>
        /// Gets the 2D geometry representation of the triangle.
        /// </summary>
        /// <value>
        /// A <see cref="Triangle2D"/> representing the projected coordinates if the plane is available and conversion succeeds; otherwise, null.
        /// </value>
        [JsonIgnore]
        public Triangle2D? Geometry2D
        {
            get
            {
                Plane? plane = Plane;
                if (plane is null)
                {
                    return null;
                }

                Point2D? point2D_1 = plane.Convert(points[0]);
                if (point2D_1 is null)
                {
                    return null;
                }

                Point2D? point2D_2 = plane.Convert(points[1]);
                if (point2D_2 is null)
                {
                    return null;
                }

                Point2D? point2D_3 = plane.Convert(points[2]);
                if (point2D_3 is null)
                {
                    return null;
                }

                return new Triangle2D(point2D_1, point2D_2, point2D_3);
            }
        }

        /// <summary>
        /// Gets the total length of the perimeter formed by the three points.
        /// Returns <see cref="double.NaN"/> if the points collection is null or any individual point is null.
        /// </summary>
        /// <value>A <see cref="double"/> representing the calculated length.</value>
        [JsonIgnore]
        public double Length
        {
            get
            {
                if (points == null)
                {
                    return double.NaN;
                }

                if (points[0] is null || points[1] is null || points[2] is null)
                {
                    return double.NaN;
                }

                return points[0]!.Distance(points[1]) + points[1]!.Distance(points[2]) + points[2]!.Distance(points[0]);
            }
        }

        /// <summary>
        /// Gets the <see cref="Plane"/> defined by the first three points of the collection.
        /// </summary>
        /// <value>The calculated <see cref="Plane"/> instance, or null.</value>
        [JsonIgnore]
        public Plane? Plane
        {
            get
            {
                return Create.Plane(points[0], points[1], points[2]);
            }
        }

        [JsonIgnore]
        public Point3D? this[int index]
        {
            get
            {
                return DiGi.Core.Query.Clone(points[index]);
            }
        }

        /// <summary>
        /// Creates a copy of the current object.
        /// </summary>
        /// <returns>An <see cref="ISerializableObject"/> that is a copy of the current instance, or null.</returns>
        public override ISerializableObject? Clone()
        {
            return new Triangle3D(this);
        }

        /// <summary>
        /// Finds the closest <see cref="Point3D"/> to the specified point.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> used as the reference for finding the nearest neighbor.</param>
        /// <returns>The closest <see cref="Point3D"/> found, or <see langword="null"/> if the provided point is <see langword="null"/> or no points are available.</returns>
        public Point3D? ClosestPoint(Point3D? point3D)
        {
            if (point3D == null || points == null)
            {
                return null;
            }

            return Query.ClosestPoint(point3D, this);
        }

        /// <summary>
        /// Calculates the distance from the specified <see cref="Point3D"/> to the closest point in the collection.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> instance used as the reference point for the distance calculation.</param>
        /// <returns>A <see cref="double"/> representing the distance to the closest point, or <see cref="double.NaN"/> if the provided <see cref="Point3D"/> is null, the internal points collection is null, or no closest point is found.</returns>
        public double Distance(Point3D? point3D)
        {
            if (point3D == null || points == null)
            {
                return double.NaN;
            }

            Point3D? point3D_Closest = Query.ClosestPoint(point3D, this, out double result);
            if (point3D_Closest == null)
            {
                return double.NaN;
            }

            return result;
        }

        /// <summary>
        /// Calculates the area of the triangle formed by the points using Heron's formula.
        /// </summary>
        /// <returns>A <see cref="double"/> representing the calculated area, or <see cref="double.NaN"/> if the points array is null or contains null elements.</returns>
        public double GetArea()
        {
            if (points == null)
            {
                return double.NaN;
            }

            if (points[0] is null || points[1] is null || points[2] is null)
            {
                return double.NaN;
            }

            double a = points[0]!.Distance(points[1]);
            double b = points[1]!.Distance(points[2]);
            double c = points[2]!.Distance(points[0]);

            double s = (a + b + c) / 2;
            return System.Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        /// <summary>
        /// Calculates the bounding box for the set of points.
        /// </summary>
        /// <returns>A <see cref="BoundingBox3D"/> representing the bounding box, or <see langword="null"/> if the points are null.</returns>
        public BoundingBox3D? GetBoundingBox()
        {
            if (points == null)
            {
                return null;
            }

            return new BoundingBox3D(points);
        }

        /// <summary>
        /// Calculates the centroid of the point collection.
        /// </summary>
        /// <returns>A <see cref="Point3D"/> representing the centroid, or <see langword="null"/> if it cannot be calculated.</returns>
        public Point3D? GetCentroid()
        {
            return Query.Centroid(points?.FilterNulls());
        }

        /// <summary>
        /// Gets an internal point of the object.
        /// </summary>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used for calculations.</param>
        /// <returns>A <see cref="Point3D"/> representing the internal point, or <see langword="null"/> if no points are available.</returns>
        public Point3D? GetInternalPoint(double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (points == null)
            {
                return null;
            }

            return points[0]?.Mid(points[1])?.Mid(points[2]);
        }

        /// <summary>
        /// Gets the perimeter of the object.
        /// </summary>
        /// <returns>A <see cref="double"/> value representing the total length of the perimeter.</returns>
        public double GetPerimeter()
        {
            return Length;
        }

        /// <summary>
        /// Retrieves a list of <see cref="Point3D"/> points, filtering out any null entries.
        /// </summary>
/// <returns>A <c>List&lt;Point3D&gt;</c> containing the filtered points, or <see langword="null"/> if the source is <see langword="null"/>.</returns>
        public List<Point3D>? GetPoints()
        {
            return DiGi.Core.Query.Clone(points)?.FilterNulls();
        }

        /// <summary>
        /// Retrieves the list of <see cref="Segment3D"/> objects that define the segments of the object.
        /// </summary>
        /// <returns>A <see cref="List{Segment3D}"/> containing the segments if points are available; otherwise, null.</returns>
        public List<Segment3D>? GetSegments()
        {
            if (points == null)
            {
                return null;
            }

            return [new Segment3D(points[0], points[1]), new Segment3D(points[1], points[2]), new Segment3D(points[2], points[0])];
        }

        /// <summary>
        /// Determines whether the points of the specified <see cref="ISegmentable3D"/> object are within a given distance tolerance.
        /// </summary>
        /// <param name="segmentable3D">The <see cref="ISegmentable3D"/> object to evaluate.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance for the range check.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the points are within the specified range; returns false if the <see cref="ISegmentable3D"/> object or internal points are null.</returns>
        public bool InRange(ISegmentable3D? segmentable3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segmentable3D == null || points == null)
            {
                return false;
            }

            List<Point3D>? point3Ds = segmentable3D.GetPoints();
            if (point3Ds == null)
            {
                return false;
            }

            return Query.InRange(this, point3Ds, tolerance);
        }

        /// <summary>
        /// Determines whether the specified <see cref="Point3D"/> is within the given tolerance distance.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> to check for proximity.</param>
        /// <param name="tolerance">The <see cref="double"/> value representing the allowed distance tolerance.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the point is within range; otherwise, false if the <see cref="Point3D"/> or internal points are null.</returns>
        public bool InRange(Point3D? point3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point3D == null || points == null)
            {
                return false;
            }

            return Query.InRange(this, point3D, tolerance);
        }

        /// <summary>
        /// Determines whether the specified <see cref="ISegmentable3D"/> object is inside within a given tolerance.
        /// </summary>
        /// <param name="segmentable3D">The <see cref="ISegmentable3D"/> object to check.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance for the operation.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the <see cref="ISegmentable3D"/> object is inside.</returns>
        public bool Inside(ISegmentable3D? segmentable3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segmentable3D == null || points == null)
            {
                return false;
            }

            List<Point3D>? point3Ds = segmentable3D.GetPoints();
            if (point3Ds == null)
            {
                return false;
            }

            return Query.Inside(this, point3Ds, tolerance);
        }

        /// <summary>
        /// Determines whether the specified <see cref="Point3D"/> is located inside the current object within a given tolerance.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> to check for containment.</param>
        /// <param name="tolerance">The <see cref="double"/> distance tolerance used for the calculation.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the point is inside; returns false if the point or internal points are null.</returns>
        public bool Inside(Point3D? point3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point3D == null || points == null)
            {
                return false;
            }

            return Query.Inside(this, point3D, tolerance);
        }

        /// <summary>
        /// Inverts the points by swapping the first and third elements.
        /// </summary>
        /// <returns>A <see cref="bool"/> value indicating whether the inversion was successful.</returns>
        public bool Inverse()
        {
            if (points == null)
            {
                return false;
            }

            (points[2], points[0]) = (points[0], points[2]);
            return true;
        }

        /// <summary>
        /// Moves the object by the specified Vector3D.
        /// </summary>
        /// <param name="vector3D">The Vector3D? value to move the points by.</param>
        /// <returns>A bool indicating whether the movement was successful.</returns>
        public override bool Move(Vector3D? vector3D)
        {
            if (vector3D == null || points == null)
            {
                return false;
            }

            for (int i = 0; i < points.Length; i++)
            {
                points[i]?.Move(vector3D);
            }

            return true;
        }

        /// <summary>
        /// Determines whether the specified <see cref="Point3D"/> is located on this object within a given tolerance.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> to evaluate.</param>
        /// <param name="tolerance">The <see cref="double"/> distance tolerance used for the check.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the point is on this object.</returns>
        public bool On(Point3D? point3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point3D == null || points == null)
            {
                return false;
            }

            return Query.On(this, point3D, tolerance);
        }

        /// <summary>
        /// Triangulates the object into a list of 3D triangles using the specified tolerance.
        /// </summary>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance used for triangulation.</param>
        /// <returns>A <see cref="List{Triangle3D}"/> containing the generated triangles, or <c>null</c> if the object cannot be triangulated.</returns>
        public List<Triangle3D>? Triangulate(double tolerance = DiGi.Core.Constants.Tolerance.MicroDistance)
        {
            List<Point3D>? point3Ds = GetPoints();
            if (point3Ds == null || point3Ds.Count != 3)
            {
                return null;
            }

            return [new Triangle3D(points[0], points[1], points[2])];
        }
    }
}

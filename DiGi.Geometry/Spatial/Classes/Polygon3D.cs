using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents a three-dimensional polygon defined on a specific plane.
    /// </summary>
    public class Polygon3D : Planar<Polygon2D>, IPolygonal3D<Polygon2D>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Polygon3D"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the polygon.</param>
        public Polygon3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Polygon3D"/> class using the specified <see cref="Plane"/> and <see cref="Polygon2D"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> on which the polygon is defined.</param>
        /// <param name="polygon2D">The <see cref="Polygon2D"/> that defines the 2D shape of the polygon.</param>
        public Polygon3D(Plane? plane, Polygon2D? polygon2D)
            : base(plane, polygon2D)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Polygon3D"/> class using the specified <see cref="Plane"/> and a collection of <see cref="Point2D"/> points.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> on which the polygon is defined. This value can be null.</param>
        /// <param name="point2Ds">An <see cref="IEnumerable{Point2D}"/> containing the 2D points that define the vertices of the polygon. This value can be null.</param>
        public Polygon3D(Plane? plane, IEnumerable<Point2D>? point2Ds)
            : base(plane, point2Ds == null ? null : new(point2Ds))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Polygon3D"/> class by copying an existing <see cref="Polygon3D"/> object.
        /// </summary>
        /// <param name="polygon3D">The <see cref="Polygon3D"/> object to copy from.</param>
        public Polygon3D(Polygon3D? polygon3D)
            : base(polygon3D)
        {
        }

        /// <summary>
        /// Gets the length of the geometry.
        /// </summary>
        /// <value>A <see cref="double"/> representing the length, or <see cref="double.NaN"/> if the underlying geometry is null.</value>
        [JsonIgnore]
        public double Length
        {
            get
            {
                if (geometry2D is null)
                {
                    return double.NaN;
                }

                return geometry2D.Length;
            }
        }

        /// <summary>
        /// Creates a copy of the current instance.
        /// </summary>
        /// <returns>A new <see cref="ISerializableObject"/> that is a clone of the current instance, or <see langword="null"/>.</returns>
        public override ISerializableObject? Clone()
        {
            return new Polygon3D(this);
        }

        /// <summary>
        /// Calculates the closest point on the geometry to the specified <see cref="Point3D"/>.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> for which the closest point is sought.</param>
        /// <returns>The closest <see cref="Point3D"/> found, or null if the input <see cref="Point3D"/> is null or the geometry is not available.</returns>
        public Point3D? ClosestPoint(Point3D? point3D)
        {
            if (point3D == null || geometry2D == null)
            {
                return null;
            }

            return Query.ClosestPoint(point3D, this);
        }

        /// <summary>
        /// Calculates the distance between the specified <see cref="Point3D"/> and this object.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> to calculate the distance from.</param>
        /// <returns>The distance as a <see cref="double"/>, or <see cref="double.NaN"/> if the <see cref="Point3D"/> is null, geometry is missing, or no closest point can be found.</returns>
        public double Distance(Point3D? point3D)
        {
            if (point3D == null || geometry2D == null)
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
        /// Calculates the area of the 2D geometry.
        /// </summary>
        /// <returns>A <see cref="double"/> representing the area, or <see cref="double.NaN"/> if the 2D geometry is null.</returns>
        public double GetArea()
        {
            if (geometry2D == null)
            {
                return double.NaN;
            }

            return geometry2D.GetArea();
        }

        /// <summary>
        /// Calculates the 3D bounding box for the current geometry based on its points.
        /// </summary>
        /// <returns>A <see cref="BoundingBox3D"/> containing all points, or <see langword="null"/> if no points are available.</returns>
        public BoundingBox3D? GetBoundingBox()
        {
            List<Point3D>? point3Ds = GetPoints();
            if (point3Ds == null)
            {
                return null;
            }

            return new BoundingBox3D(point3Ds);
        }

        /// <summary>
        /// Calculates the centroid of the geometry and converts it to a 3D point.
        /// </summary>
        /// <returns>A <see cref="Point3D"/> representing the centroid, or <see langword="null"/> if the plane or geometry is not available.</returns>
        public Point3D? GetCentroid()
        {
            if (plane == null || geometry2D == null)
            {
                return null;
            }

            return plane.Convert(geometry2D.GetCentroid());
        }

        /// <summary>
        /// Gets an internal point of the geometry converted to 3D space.
        /// </summary>
        /// <param name="tolerance">The <see cref="double"/> tolerance used for the calculation.</param>
        /// <returns>A <see cref="Point3D"/> representing the internal point, or <see langword="null"/> if the plane or geometry is not available.</returns>
        public Point3D? GetInternalPoint(double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (plane == null || geometry2D == null)
            {
                return null;
            }

            return plane.Convert(geometry2D.GetInternalPoint());
        }

        /// <summary>
        /// Gets the perimeter of the geometry.
        /// </summary>
        /// <returns>A <see cref="double"/> value representing the total length of the perimeter.</returns>
        public double GetPerimeter()
        {
            return Length;
        }

        /// <summary>
        /// Retrieves a list of <see cref="Point3D"/> objects by converting the 2D points from the geometry using the associated plane.
        /// </summary>
        /// <returns>A <see cref="List{Point3D}"/> containing the converted points, or <see langword="null"/> if the plane, geometry, or source points are unavailable.</returns>
        public List<Point3D>? GetPoints()
        {
            if (plane == null || geometry2D == null)
            {
                return null;
            }

            List<Point2D>? point2Ds = geometry2D.GetPoints();
            if (point2Ds == null)
            {
                return null;
            }

            List<Point3D> result = [];
            for (int i = 0; i < point2Ds.Count; i++)
            {
                Point3D? point3D = plane.Convert(point2Ds[i]);
                if (point3D is null)
                {
                    continue;
                }

                result.Add(point3D);
            }

            return result;
        }

        /// <summary>
        /// Retrieves a list of <see cref="Segment3D"/> segments.
        /// </summary>
        /// <returns>A <see cref="List{T}"/> of <see cref="Segment3D"/> objects if points are available; otherwise, null.</returns>
        public List<Segment3D>? GetSegments()
        {
            List<Point3D>? point3Ds = GetPoints();
            if (point3Ds == null)
            {
                return null;
            }

            return Create.Segment3Ds(point3Ds, true);
        }

        /// <summary>
        /// Determines whether the specified <see cref="ISegmentable3D"/> object is within a given distance tolerance.
        /// </summary>
        /// <param name="segmentable3D">The <see cref="ISegmentable3D"/> object to check.</param>
        /// <param name="tolerance">The <see cref="double"/> value representing the distance tolerance.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the object is within range; otherwise, false if any required components are null.</returns>
        public bool InRange(ISegmentable3D? segmentable3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segmentable3D == null || geometry2D == null || plane == null)
            {
                return false;
            }

            return Query.InRange(this, segmentable3D, tolerance);
        }

        /// <summary>
        /// Determines whether the specified <see cref="Point3D"/> is within range based on the provided tolerance.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> to evaluate.</param>
        /// <param name="tolerance">The <see cref="double"/> distance tolerance used for the range check.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the point is within range; otherwise, false if the point or required internal geometry is null.</returns>
        public bool InRange(Point3D? point3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point3D == null || geometry2D == null || plane == null)
            {
                return false;
            }

            return Query.InRange(this, point3D, tolerance);
        }

        /// <summary>
        /// Determines whether the specified <see cref="ISegmentable3D"/> object is inside the geometry.
        /// </summary>
        /// <param name="segmentable3D">The <see cref="ISegmentable3D"/> object to check.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used for the distance calculation.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the <see cref="ISegmentable3D"/> object is inside the geometry.</returns>
        public bool Inside(ISegmentable3D? segmentable3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segmentable3D == null || geometry2D == null || plane == null)
            {
                return false;
            }

            return Query.Inside(this, segmentable3D, tolerance);
        }

        /// <summary>
        /// Determines whether the specified <see cref="Point3D"/> is inside the geometry within the given tolerance.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> to evaluate.</param>
        /// <param name="tolerance">The <see cref="double"/> distance tolerance used for the check.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the point is inside; returns false if the <see cref="Point3D"/>, geometry, or plane is null.</returns>
        public bool Inside(Point3D? point3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point3D == null || geometry2D == null || plane == null)
            {
                return false;
            }

            return Query.Inside(this, point3D, tolerance);
        }

        /// <summary>
        /// Inverts the geometry.
        /// </summary>
        /// <returns>A <see cref="bool"/> value indicating whether the inversion was successful.</returns>
        public bool Inverse()
        {
            if (geometry2D is null)
            {
                return false;
            }

            return geometry2D.Inverse();
        }

        /// <summary>
        /// Determines whether the specified <see cref="Point3D"/> is on the geometry within the given tolerance.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> to check.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used for the distance calculation.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the point is on the geometry.</returns>
        public bool On(Point3D? point3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point3D == null || geometry2D == null)
            {
                return false;
            }

            return Query.On(this, point3D, tolerance);
        }

        /// <summary>
        /// Triangulates the geometry into a list of <see cref="Triangle3D"/> objects.
        /// </summary>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used for the triangulation process.</param>
        /// <returns>A <see cref="List{Triangle3D}"/> containing the resulting 3D triangles, or <c>null</c> if the plane is null or the 2D triangulation fails.</returns>
        public List<Triangle3D>? Triangulate(double tolerance = DiGi.Core.Constants.Tolerance.MicroDistance)
        {
            if (plane == null)
            {
                return null;
            }

            List<Triangle2D>? triangle2Ds = geometry2D?.Triangulate(tolerance);
            if (triangle2Ds == null)
            {
                return null;
            }

            List<Triangle3D> result = [];
            for (int i = 0; i < triangle2Ds.Count; i++)
            {
                Triangle3D? triangle3D = plane.Convert(triangle2Ds[i]);
                if (triangle3D is null)
                {
                    continue;
                }

                result.Add(triangle3D);
            }

            return result;
        }
    }
}
using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents a three-dimensional rectangle defined on a specific plane.
    /// </summary>
    /// <summary>
    /// Initializes a new instance of the <see cref="Rectangle3D"/> class from a JSON object.
    /// </summary>
    /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data to initialize the rectangle.</param>
    /// <summary>
    /// Initializes a new instance of the <see cref="Rectangle3D"/> class using a plane and a 2D rectangle.
    /// </summary>
    /// <param name="plane">The <see cref="Plane"/> on which the rectangle is located.</param>
    /// <param name="rectangle2D">The <see cref="Rectangle2D"/> defining the dimensions and position of the rectangle on the plane.</param>
    /// <summary>
    /// Initializes a new instance of the <see cref="Rectangle3D"/> class using a plane, width, and height.
    /// </summary>
    /// <param name="plane">The <see cref="Plane"/> on which the rectangle is located.</param>
    /// <param name="width">The <see cref="double"/> value representing the width of the rectangle.</param>
    /// <param name="height">The <see cref="double"/> value representing the height of the rectangle.</param>
    /// <summary>
    /// Initializes a new instance of the <see cref="Rectangle3D"/> class using a plane and a collection of 2D points.
    /// </summary>
    /// <param name="plane">The <see cref="Plane"/> on which the rectangle is located.</param>
    /// <param name="point2Ds">An <see cref="IEnumerable{Point2D}"/> containing the points used to define the rectangle.</param>
    public class Rectangle3D : Planar<Rectangle2D>, IPolygonal3D<Rectangle2D>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle3D"/> class using the provided <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data to initialize the rectangle.</param>
        public Rectangle3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle3D"/> class using the specified <see cref="Plane"/> and <see cref="Rectangle2D"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> on which the rectangle is defined.</param>
        /// <param name="rectangle2D">The <see cref="Rectangle2D"/> that defines the dimensions and position of the rectangle within the plane.</param>
        public Rectangle3D(Plane? plane, Rectangle2D? rectangle2D)
            : base(plane, rectangle2D)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle3D"/> class with the specified plane, width, and height.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> on which the rectangle is defined.</param>
        /// <param name="width">The width of the rectangle as a <see cref="double"/>.</param>
        /// <param name="height">The height of the rectangle as a <see cref="double"/>.</param>
        public Rectangle3D(Plane? plane, double width, double height)
            : base(plane, new Rectangle2D(width, height))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle3D"/> class using the specified <see cref="Plane"/> and a collection of <see cref="Point2D"/> points.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> on which the rectangle is located.</param>
        /// <param name="point2Ds">An <see cref="IEnumerable{Point2D}"/> containing the points that define the 2D geometry of the rectangle.</param>
        public Rectangle3D(Plane? plane, IEnumerable<Point2D>? point2Ds)
            : base(plane, Planar.Create.Rectangle2D(point2Ds))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle3D"/> class using an existing <see cref="Rectangle3D"/> instance.
        /// </summary>
        /// <param name="rectangle3D">The <see cref="Rectangle3D"/> instance to copy from.</param>
        public Rectangle3D(Rectangle3D? rectangle3D)
            : base(rectangle3D)
        {
        }

        /// <summary>
        /// Gets the height of the object.
        /// </summary>
        /// <value>A <see cref="double"/> representing the height, or <see cref="double.NaN"/> if the underlying 2D geometry is null.</value>
        [JsonIgnore]
        public double Height
        {
            get
            {
                if (geometry2D is null)
                {
                    return double.NaN;
                }

                return geometry2D.Height;
            }
        }

        /// <summary>
        /// Gets the length of the 2D geometry. Returns <see cref="double.NaN"/> if the geometry is null.
        /// </summary>
        /// <value>
        /// A <see cref="double"/> representing the length.
        /// </value>
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
        /// Gets the width of the rectangle.
        /// </summary>
        /// <value>
        /// A <see cref="double"/> value representing the width, or <see cref="double.NaN"/> if the geometry is not defined.
        /// </value>
        [JsonIgnore]
        public double Width
        {
            get
            {
                if (geometry2D is null)
                {
                    return double.NaN;
                }

                return geometry2D.Width;
            }
        }

        /// <summary>
        /// Creates a copy of the current object.
        /// </summary>
        /// <returns>A new <see cref="ISerializableObject"/> instance that is a clone of the current object, or <see langword="null"/>.</returns>
        public override ISerializableObject? Clone()
        {
            return new Rectangle3D(this);
        }

        /// <summary>
        /// Calculates the closest <Point3D> on the geometry to the specified <Point3D>.
        /// </summary>
        /// <param name="point3D">The <Point3D> for which the closest point is sought.</param>
        /// <returns>The closest <Point3D> found, or null if the provided <Point3D> is null or the geometry is not available.</returns>
        public Point3D? ClosestPoint(Point3D? point3D)
        {
            if (point3D == null || geometry2D == null)
            {
                return null;
            }

            return Query.ClosestPoint(point3D, this);
        }

        /// <summary>
        /// Calculates the distance from the specified <see cref="Point3D"/> to the geometry.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> point used to calculate the distance.</param>
        /// <returns>The distance as a <see cref="double"/>, or <see cref="double.NaN"/> if the provided <see cref="Point3D"/> is null, the geometry is null, or no closest point can be determined.</returns>
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
        /// <returns>A <see cref="double"/> representing the calculated area, or <see cref="double.NaN"/> if the 2D geometry is null.</returns>
        public double GetArea()
        {
            if (geometry2D == null)
            {
                return double.NaN;
            }

            return geometry2D.GetArea();
        }

        /// <summary>
        /// Calculates and returns the bounding box for the current object in 3D space.
        /// </summary>
        /// <returns>A <see cref="BoundingBox3D"/> representing the bounding box, or <see langword="null"/> if no points are available.</returns>
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
        /// <returns>A <see cref="Point3D"/> representing the centroid if both the plane and geometry are available; otherwise, null.</returns>
        public Point3D? GetCentroid()
        {
            if (plane == null || geometry2D == null)
            {
                return null;
            }

            return plane.Convert(geometry2D.GetCentroid());
        }

        /// <summary>
        /// Gets an internal point of the geometry.
        /// </summary>
        /// <param name="tolerance">The <double> tolerance value used for calculations.</param>
        /// <returns>A <Point3D> representing the internal point if successful; otherwise, null.</returns>
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
        /// <returns>The perimeter as a <see cref="double"/>.</returns>
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
        /// Retrieves the list of <see cref="Segment3D"/> objects.
        /// </summary>
        /// <returns>A <see cref="List{T}"/> of <see cref="Segment3D"/> if segments are available; otherwise, null.</returns>
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
        /// <param name="segmentable3D">The <see cref="ISegmentable3D"/> object to evaluate.</param>
        /// <param name="tolerance">The <see cref="double"/> value representing the distance tolerance.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the object is within range; returns <c>false</c> if the <see cref="ISegmentable3D"/> object, geometry2D, or plane is null.</returns>
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
        /// <param name="point3D">The <see cref="Point3D"/> to check.</param>
        /// <param name="tolerance">The <see cref="double"/> value representing the distance tolerance.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the point is within range; otherwise, <see langword="false"/>.</returns>
        public bool InRange(Point3D? point3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point3D == null || geometry2D == null || plane == null)
            {
                return false;
            }

            return Query.InRange(this, point3D, tolerance);
        }

        /// <summary>
        /// Determines whether the specified <see cref="ISegmentable3D"/> object is inside the geometry within a given tolerance.
        /// </summary>
        /// <param name="segmentable3D">The <see cref="ISegmentable3D"/> object to check.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance for the operation.</param>
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
        /// Determines whether the specified Point3D is inside the geometry within a given tolerance.
        /// </summary>
        /// <param name="point3D">The Point3D object to check.</param>
        /// <param name="tolerance">The double value representing the distance tolerance for the operation.</param>
        /// <returns>A bool indicating whether the point is inside the geometry; returns false if the point, geometry, or plane is null.</returns>
        public bool Inside(Point3D? point3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point3D == null || geometry2D == null || plane == null)
            {
                return false;
            }

            return Query.Inside(this, point3D, tolerance);
        }

        /// <summary>
        /// Inverts the current geometry.
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
        /// Determines whether the specified <see cref="Point3D"/> is located on the geometry within the given tolerance.
        /// </summary>
        /// <param name="point3D">The nullable <see cref="Point3D"/> to check.</param>
        /// <param name="tolerance">The <see cref="double"/> distance tolerance used for the calculation.</param>
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
        /// Triangulates the geometry into a list of 3D triangles using the specified tolerance.
        /// </summary>
        /// <param name="tolerance">The double value representing the distance tolerance used during the triangulation process.</param>
        /// <returns>A List<Triangle3D> containing the resulting 3D triangles, or null if the plane is not defined or the 2D triangulation fails.</returns>
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
                if (triangle3D == null)
                {
                    continue;
                }

                result.Add(triangle3D);
            }

            return result;
        }
    }
}
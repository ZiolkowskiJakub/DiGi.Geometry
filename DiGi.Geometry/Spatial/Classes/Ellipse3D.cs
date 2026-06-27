using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents a three-dimensional ellipse defined on a plane.
    /// </summary>
    public class Ellipse3D : Planar<Ellipse2D>, IEllipse3D
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ellipse3D"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the instance.</param>
        public Ellipse3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ellipse3D"/> class using the specified <see cref="Plane"/> and <see cref="Ellipse2D"/>.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> on which the ellipse is located.</param>
        /// <param name="ellipse2D">The <see cref="Ellipse2D"/> that defines the geometry of the ellipse.</param>
        public Ellipse3D(Plane? plane, Ellipse2D? ellipse2D)
            : base(plane, ellipse2D)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ellipse3D"/> class using an existing <see cref="Ellipse3D"/> instance.
        /// </summary>
        /// <param name="ellipse3D">The <see cref="Ellipse3D"/> instance to copy from.</param>
        public Ellipse3D(Ellipse3D? ellipse3D)
            : base(ellipse3D)
        {
        }

        /// <summary>
        /// Gets or sets the A value of the 2D geometry. Returns <see cref="double.NaN"/> if the underlying geometry is null.
        /// </summary>
        /// <value>A <see cref="double"/> representing the A component.</value>
        [JsonIgnore]
        public double A
        {
            get
            {
                if (geometry2D is null)
                {
                    return double.NaN;
                }

                return geometry2D.A;
            }

            set
            {
                if (geometry2D is null)
                {
                    return;
                }

                geometry2D.A = value;
            }
        }

        /// <summary>
        /// Gets or sets the double value for B from the associated 2D geometry.
        /// Returns double.NaN if the underlying geometry is null.
        /// </summary>
        [JsonIgnore]
        public double B
        {
            get
            {
                if (geometry2D is null)
                {
                    return double.NaN;
                }

                return geometry2D.B;
            }

            set
            {
                if (geometry2D is null)
                {
                    return;
                }

                geometry2D.B = value;
            }
        }

        /// <summary>
        /// Gets the center point of the geometry converted to a <see cref="Point3D"/>.
        /// </summary>
        /// <value>
        /// A <see cref="Point3D"/> representing the center, or null if the conversion cannot be performed.
        /// </value>
        [JsonIgnore]
        public Point3D? Center
        {
            get
            {
                return plane?.Convert(geometry2D?.Center);
            }
        }

        /// <summary>
        /// Gets the direction of the ellipse as a <see cref="Vector3D"/>.
        /// </summary>
        /// <value>
        /// The <see cref="Vector3D"/> representing the direction, or null if it cannot be determined.
        /// </value>
        [JsonIgnore]
        public Vector3D? Direction
        {
            get
            {
                return plane?.Convert(geometry2D?.DirectionA);
            }
        }

        /// <summary>
        /// Creates a copy of the current object.
        /// </summary>
        /// <returns>An <see cref="ISerializableObject"/> that is a clone of the current instance.</returns>
        public override ISerializableObject? Clone()
        {
            return new Ellipse3D(this);
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
        /// Calculates the 3D bounding box of the geometry based on the associated plane.
        /// </summary>
        /// <returns>A <see cref="BoundingBox3D"/> representing the bounding box, or <see langword="null"/> if the geometry is empty or the plane is not defined.</returns>
        public BoundingBox3D? GetBoundingBox()
        {
            if (plane == null || geometry2D == null)
            {
                return null;
            }

            List<Point2D>? point2Ds = geometry2D.GetBoundingBox()?.GetPoints();
            if (point2Ds == null || point2Ds.Count == 0)
            {
                return null;
            }

            List<Point3D> resultPoints = [];
            for (int i = 0; i < point2Ds.Count; i++)
            {
                Point3D? point3D_Converted = plane.Convert(point2Ds[i]);
                if (point3D_Converted != null)
                {
                    resultPoints.Add(point3D_Converted);
                }
            }

            return new BoundingBox3D(resultPoints);
        }

        /// <summary>
        /// Retrieves the focal points of the geometry converted to 3D space.
        /// </summary>
        /// <returns>An array of <see cref="Point3D"/> objects representing the focal points, or <see langword="null"/> if the plane or geometry is not defined or no focal points exist.</returns>
        public Point3D[]? GetFocalPoints()
        {
            if (plane == null || geometry2D == null)
            {
                return null;
            }

            Point2D[]? point2Ds = geometry2D.GetFocalPoints();
            if (point2Ds == null)
            {
                return null;
            }

            Point3D[] result = new Point3D[point2Ds.Length];
            for (int i = 0; i < point2Ds.Length; i++)
            {
                if (plane.Convert(point2Ds[i]) is Point3D point3D)
                {
                    result[i] = point3D;
                }
            }

            return result;
        }

        /// <summary>
        /// Gets an internal point of the geometry converted to 3D space.
        /// </summary>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used for the calculation.</param>
        /// <returns>A <see cref="Point3D"/> representing the internal point if the plane and geometry are available; otherwise, null.</returns>
        public Point3D? GetInternalPoint(double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (plane == null || geometry2D == null)
            {
                return null;
            }

            return plane.Convert(geometry2D.GetInternalPoint());
        }

        /// <summary>
        /// Calculates and returns the perimeter of the 2D geometry.
        /// </summary>
        /// <returns>A <see cref="double"/> representing the perimeter, or <see cref="double.NaN"/> if the underlying geometry is null.</returns>
        public double GetPerimeter()
        {
            if (geometry2D is null)
            {
                return double.NaN;
            }

            return geometry2D.GetPerimeter();
        }

        /// <summary>
        /// Determines whether the specified <see cref="Point3D"/> is within range of the geometry, given a specific tolerance.
        /// </summary>
        /// <param name="point3D">The nullable <see cref="Point3D"/> to evaluate.</param>
        /// <param name="tolerance">The <see cref="double"/> distance tolerance used for the calculation.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the point is within range.</returns>
        public bool InRange(Point3D? point3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point3D is null || geometry2D is null || plane is null || tolerance < 0.0)
            {
                return false;
            }

            if (!plane.On(point3D, tolerance))
            {
                return false;
            }

            Vector3D? vector3D_AxisX = plane.AxisX;
            Vector3D? vector3D_AxisY = plane.AxisY;
            Point3D? point3D_Origin = plane.Origin;
            if (vector3D_AxisX is null || vector3D_AxisY is null || point3D_Origin is null)
            {
                return false;
            }

            double double_Dx = point3D.X - point3D_Origin.X;
            double double_Dy = point3D.Y - point3D_Origin.Y;
            double double_Dz = point3D.Z - point3D_Origin.Z;

            double double_U = vector3D_AxisX.X * double_Dx + vector3D_AxisX.Y * double_Dy + vector3D_AxisX.Z * double_Dz;
            double double_V = vector3D_AxisY.X * double_Dx + vector3D_AxisY.Y * double_Dy + vector3D_AxisY.Z * double_Dz;

            Point2D point2D_Local = new Point2D(double_U, double_V);
            return geometry2D.InRange(point2D_Local, tolerance);
        }

        /// <summary>
        /// Determines whether the specified Point3D is inside the geometry within a given tolerance.
        /// </summary>
        /// <param name="point3D">The Point3D object to check.</param>
        /// <param name="tolerance">The double value representing the distance tolerance for the operation.</param>
        /// <returns>A bool indicating whether the point is inside the geometry.</returns>
        public bool Inside(Point3D? point3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point3D is null || geometry2D is null || plane is null)
            {
                return false;
            }

            if (!plane.On(point3D, tolerance))
            {
                return false;
            }

            Vector3D? vector3D_AxisX = plane.AxisX;
            Vector3D? vector3D_AxisY = plane.AxisY;
            Point3D? point3D_Origin = plane.Origin;
            if (vector3D_AxisX is null || vector3D_AxisY is null || point3D_Origin is null)
            {
                return false;
            }

            double double_Dx = point3D.X - point3D_Origin.X;
            double double_Dy = point3D.Y - point3D_Origin.Y;
            double double_Dz = point3D.Z - point3D_Origin.Z;

            double double_U = vector3D_AxisX.X * double_Dx + vector3D_AxisX.Y * double_Dy + vector3D_AxisX.Z * double_Dz;
            double double_V = vector3D_AxisY.X * double_Dx + vector3D_AxisY.Y * double_Dy + vector3D_AxisY.Z * double_Dz;

            Point2D point2D_Local = new Point2D(double_U, double_V);
            return geometry2D.Inside(point2D_Local, tolerance);
        }

        /// <summary>
        /// Inverts the underlying 2D geometry if it is not null.
        /// </summary>
        public void Inverse()
        {
            if (geometry2D is null)
            {
                return;
            }

            geometry2D.Inverse();
        }
    }
}
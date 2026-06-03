using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    public class Circle2D : Geometry2D, IEllipse2D, IBoundable2D
    {
        [JsonInclude, JsonPropertyName("Center")]
        private Point2D? center;

        [JsonInclude, JsonPropertyName("Radius")]
        private double radius;

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle2D"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing circle data.</param>
        public Circle2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle2D"/> class with a specified center and radius.
        /// </summary>
        /// <param name="center">The center point of the circle.</param>
        /// <param name="radius">The radius of the circle.</param>
        public Circle2D(Point2D? center, double radius)
        {
            this.center = DiGi.Core.Query.Clone(center);
            this.radius = radius;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle2D"/> class.
        /// </summary>
        public Circle2D()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle2D"/> class by cloning an existing circle.
        /// </summary>
        /// <param name="circle2D">The source circle to clone.</param>
        public Circle2D(Circle2D? circle2D)
        {
            if (circle2D != null)
            {
                center = DiGi.Core.Query.Clone(circle2D.center);
                radius = circle2D.radius;
            }
        }

        /// <summary>
        /// Gets or sets the center point of the circle.
        /// </summary>
        [JsonIgnore]
        public Point2D? Center
        {
            get
            {
                return center == null ? null : new Point2D(center);
            }
            set
            {
                center = value;
            }
        }

        /// <summary>
        /// Gets or sets the diameter of the circle.
        /// </summary>
        [JsonIgnore]
        public double Diameter
        {
            get
            {
                return radius * 2;
            }
            set
            {
                radius = value / 2;
            }
        }

        /// <summary>
        /// Gets the circumference (length) of the circle.
        /// </summary>
        [JsonIgnore]
        public double Length
        {
            get
            {
                return 2 * System.Math.PI * radius;
            }
        }

        /// <summary>
        /// Gets or sets the radius of the circle.
        /// </summary>
        [JsonIgnore]
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        /// <summary>
        /// Creates a clone of the current circle.
        /// </summary>
        /// <returns>A cloned instance of the circle.</returns>
        public override ISerializableObject? Clone()
        {
            return new Circle2D(this);
        }

        /// <summary>
        /// Calculates the area of the circle.
        /// </summary>
        /// <returns>The area of the circle.</returns>
        public double GetArea()
        {
            return System.Math.PI * radius * radius;
        }

        /// <summary>
        /// Gets the axis-aligned bounding box of the circle.
        /// </summary>
        /// <returns>The bounding box encompassing the circle.</returns>
        public BoundingBox2D? GetBoundingBox()
        {
            if (center == null)
            {
                return null;
            }

            return new BoundingBox2D(new Point2D(center[0] - radius, center[1] - radius), new Point2D(center[0] + radius, center[1] + radius));
        }

        /// <summary>
        /// Gets a point guaranteed to be inside the circle.
        /// </summary>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>An internal point of the circle.</returns>
        public Point2D? GetInternalPoint(double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (center == null)
            {
                return null;
            }

            return new Point2D(center);
        }

        /// <summary>
        /// Gets the perimeter (circumference) of the circle.
        /// </summary>
        /// <returns>The length of the boundary.</returns>
        public double GetPerimeter()
        {
            return Length;
        }

        /// <summary>
        /// Checks if a point is within or on the boundary of the circle.
        /// </summary>
        /// <param name="point2D">The point to check.</param>
        /// <param name="tolerance">The distance tolerance for the check.</param>
        /// <returns>True if the point is in range of the circle.</returns>
        public bool InRange(Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point2D == null || center == null || double.IsNaN(radius))
            {
                return false;
            }

            return center.Distance(point2D) < radius + tolerance;
        }

        /// <summary>
        /// Checks if a segmentable geometry is within or intersects the circle.
        /// </summary>
        /// <param name="segmentable2D">The geometry to check.</param>
        /// <param name="tolerance">The distance tolerance for the check.</param>
        /// <returns>True if any part of the geometry is in range of the circle.</returns>
        public bool InRange(ISegmentable2D? segmentable2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segmentable2D == null || center == null)
            {
                return false;
            }

            List<Point2D>? point2Ds = segmentable2D.GetPoints();
            if (point2Ds == null || point2Ds.Count == 0)
            {
                return false;
            }

            foreach (Point2D point2D in point2Ds)
            {
                if (InRange(point2D, tolerance))
                {
                    return true;
                }
            }

            Point2D? point2D_Closest = segmentable2D.ClosestPoint(center);
            if (InRange(point2D_Closest, tolerance))
            {
                return true;
            }

            if (segmentable2D is IClosedCurve2D closedCurve2D && closedCurve2D.Inside(center, tolerance))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Checks if a point is strictly inside the circle boundaries.
        /// </summary>
        /// <param name="point2D">The point to check.</param>
        /// <param name="tolerance">The distance tolerance for the check.</param>
        /// <returns>True if the point is strictly inside.</returns>
        public bool Inside(Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point2D == null || center == null || double.IsNaN(radius))
            {
                return false;
            }

            return center.Distance(point2D) < radius - tolerance;
        }

        /// <summary>
        /// Checks if a segmentable geometry is strictly inside the circle boundaries.
        /// </summary>
        /// <param name="segmentable2D">The geometry to check.</param>
        /// <param name="tolerance">The distance tolerance for the check.</param>
        /// <returns>True if all points of the geometry are strictly inside.</returns>
        public bool Inside(ISegmentable2D? segmentable2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            List<Point2D>? point2Ds = segmentable2D?.GetPoints();
            if (point2Ds == null || point2Ds.Count == 0)
            {
                return false;
            }

            foreach (Point2D point2D in point2Ds)
            {
                if (!Inside(point2D, tolerance))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Moves the circle by the specified vector.
        /// </summary>
        /// <param name="vector2D">The translation vector.</param>
        /// <returns>True if the move was successful.</returns>
        public override bool Move(Vector2D? vector2D)
        {
            if (vector2D is null || center == null)
            {
                return false;
            }

            center.Move(vector2D);
            return true;
        }

        /// <summary>
        /// Checks if a point lies on the boundary of the circle.
        /// </summary>
        /// <param name="point2D">The point to check.</param>
        /// <param name="tolerance">The distance tolerance for the check.</param>
        /// <returns>True if the point is on the boundary.</returns>
        public bool On(Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point2D == null || center == null || double.IsNaN(radius))
            {
                return false;
            }

            return System.Math.Abs(center.Distance(point2D) - radius) <= tolerance;
        }

        /// <summary>
        /// Transforms the circle using the specified transformation.
        /// </summary>
        /// <param name="transform">The transformation to apply.</param>
        /// <returns>True if the transformation was successful.</returns>
        public override bool Transform(ITransform2D? transform)
        {
            if (transform == null || center == null || double.IsNaN(radius))
            {
                return false;
            }

            Point2D point2D = new(center);
            point2D.Move(new Vector2D(1, 1) * radius);

            center.Transform(transform);

            point2D.Transform(transform);

            radius = new Vector2D(center, point2D).Length;

            return true;
        }
    }
}
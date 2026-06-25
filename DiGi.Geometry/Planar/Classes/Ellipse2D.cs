using DiGi.Core;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    /// <summary>
    /// Represents a 2D ellipse defined by its center, semi-axes lengths, and the direction of the major axis.
    /// </summary>
    public class Ellipse2D : Geometry2D, IEllipse2D, IBoundable2D
    {
        [JsonInclude, JsonPropertyName("A")]
        private double a;

        [JsonInclude, JsonPropertyName("B")]
        private double b;

        [JsonInclude, JsonPropertyName("Center")]
        private Point2D? center;

        [JsonInclude, JsonPropertyName("DirectionA")]
        private Vector2D? directionA;

        /// <summary>
        /// Initializes a new instance of the <see cref="Ellipse2D"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing ellipse data.</param>
        public Ellipse2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ellipse2D"/> class with center and semi-axes lengths.
        /// </summary>
        /// <param name="center">The center point of the ellipse.</param>
        /// <param name="a">The length of the semi-major axis.</param>
        /// <param name="b">The length of the semi-minor axis.</param>
        public Ellipse2D(Point2D? center, double a, double b)
        {
            this.center = DiGi.Core.Query.Clone(center);
            this.a = a;
            this.b = b;
            directionA = Constants.Vector2D.WorldX;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ellipse2D"/> class by cloning an existing ellipse.
        /// </summary>
        /// <param name="ellipse2D">The source ellipse to clone.</param>
        public Ellipse2D(Ellipse2D? ellipse2D)
        {
            if (ellipse2D is not null)
            {
                center = ellipse2D.Center;
                a = ellipse2D.a;
                b = ellipse2D.b;
                directionA = ellipse2D.DirectionA;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ellipse2D"/> class with center, semi-axes lengths and major axis direction.
        /// </summary>
        /// <param name="center">The center point of the ellipse.</param>
        /// <param name="a">The length of the semi-major axis.</param>
        /// <param name="b">The length of the semi-minor axis.</param>
        /// <param name="directionA">The direction vector of the major axis.</param>
        public Ellipse2D(Point2D? center, double a, double b, Vector2D? directionA)
        {
            this.center = DiGi.Core.Query.Clone(center);
            this.a = a;
            this.b = b;
            this.directionA = DiGi.Core.Query.Clone(directionA)?.Unit;
        }

        /// <summary>
        /// Gets or sets the length of the semi-major axis.
        /// </summary>
        [JsonIgnore]
        public double A
        {
            get
            {
                return a;
            }

            set
            {
                a = value;
            }
        }

        /// <summary>
        /// Gets or sets the length of the semi-minor axis.
        /// </summary>
        [JsonIgnore]
        public double B
        {
            get
            {
                return b;
            }

            set
            {
                b = value;
            }
        }

        /// <summary>
        /// Gets the linear eccentricity of the ellipse.
        /// </summary>
        [JsonIgnore]
        public double C
        {
            get
            {
                return System.Math.Sqrt((a * a) - (b * b));
            }
        }

        /// <summary>
        /// Gets or sets the center point of the ellipse.
        /// </summary>
        [JsonIgnore]
        public Point2D? Center
        {
            get
            {
                return center?.Clone<Point2D>();
            }

            set
            {
                center = value?.Clone<Point2D>();
            }
        }

        /// <summary>
        /// Gets or sets the direction vector of the major axis.
        /// </summary>
        [JsonIgnore]
        public Vector2D? DirectionA
        {
            get
            {
                return directionA?.Clone<Vector2D>();
            }

            set
            {
                directionA = value?.Clone<Vector2D>();
            }
        }

        /// <summary>
        /// Gets the direction vector of the minor axis.
        /// </summary>
        [JsonIgnore]
        public Vector2D? DirectionB
        {
            get
            {
                return directionA?.GetPerpendicular().Clone<Vector2D>();
            }
        }

        /// <summary>
        /// Converts a <see cref="Circle2D"/> to an <see cref="Ellipse2D"/>.
        /// </summary>
        /// <param name="circle2D">The source circle.</param>
        /// <returns>An ellipse equivalent to the circle.</returns>
        public static explicit operator Ellipse2D?(Circle2D? circle2D)
        {
            if (circle2D == null)
            {
                return null;
            }

            return new Ellipse2D(circle2D.Center, circle2D.Radius, circle2D.Radius);
        }

        /// <summary>
        /// Determines whether two ellipses are not equal.
        /// </summary>
        /// <param name="ellipse2D_1">The first ellipse.</param>
        /// <param name="ellipse2D_2">The second ellipse.</param>
        /// <returns>True if the ellipses are not equal; otherwise, false.</returns>
        public static bool operator !=(Ellipse2D? ellipse2D_1, Ellipse2D? ellipse2D_2)
        {
            return !(ellipse2D_1 == ellipse2D_2);
        }

        /// <summary>
        /// Determines whether two ellipses are equal.
        /// </summary>
        /// <param name="ellipse2D_1">The first ellipse.</param>
        /// <param name="ellipse2D_2">The second ellipse.</param>
        /// <returns>True if the ellipses are equal; otherwise, false.</returns>
        public static bool operator ==(Ellipse2D? ellipse2D_1, Ellipse2D? ellipse2D_2)
        {
            if (ellipse2D_1 is null && ellipse2D_2 is null)
            {
                return true;
            }

            if (ellipse2D_1 is null || ellipse2D_2 is null)
            {
                return false;
            }

            return ellipse2D_1.center == ellipse2D_2.center && ellipse2D_1.directionA == ellipse2D_2.directionA && ellipse2D_1.a == ellipse2D_2.a && ellipse2D_1.b == ellipse2D_2.b;
        }

        /// <summary>
        /// Creates a clone of the current ellipse.
        /// </summary>
        /// <returns>A cloned instance of the ellipse.</returns>
        public override ISerializableObject? Clone()
        {
            return new Ellipse2D(this);
        }

        /// <summary>
        /// Calculates the shortest distance from a point to the ellipse boundary.
        /// </summary>
        /// <param name="point2D">The target point.</param>
        /// <returns>The minimum distance to the boundary.</returns>
        public double Distance(Point2D? point2D)
        {
            Point2D? point2D_Project = Project(point2D);
            if (point2D_Project == null)
            {
                return double.NaN;
            }

            return point2D!.Distance(point2D_Project);
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current ellipse.
        /// </summary>
        /// <param name="obj">The object to compare with the current ellipse.</param>
        /// <returns>True if the objects are equal; otherwise, false.</returns>
        public override bool Equals(object? obj)
        {
            Ellipse2D? ellipse2D = obj as Ellipse2D;
            if (ellipse2D == null)
            {
                return false;
            }

            return center == ellipse2D.center && directionA == ellipse2D.directionA && a == ellipse2D.a && b == ellipse2D.b;
        }

        /// <summary>
        /// Calculates the area of the ellipse.
        /// </summary>
        /// <returns>The area of the ellipse.</returns>
        public double GetArea()
        {
            return System.Math.PI * a * b;
        }

        /// <summary>
        /// Gets the axis-aligned bounding box of the ellipse.
        /// </summary>
        /// <returns>The bounding box encompassing the ellipse.</returns>
        public BoundingBox2D? GetBoundingBox()
        {
            if (directionA is null || center is null)
            {
                return null;
            }

            // Unit vectors of major and minor axes
            double ux = directionA.X;
            double uy = directionA.Y;
            double vx = -uy;
            double vy = ux;

            // Projections of semi-axes onto X and Y axes
            double dx = System.Math.Sqrt(System.Math.Pow(A * ux, 2) + System.Math.Pow(B * vx, 2));
            double dy = System.Math.Sqrt(System.Math.Pow(A * uy, 2) + System.Math.Pow(B * vy, 2));

            // Bounding box
            double minX = center.X - dx;
            double maxX = center.X + dx;
            double minY = center.Y - dy;
            double maxY = center.Y + dy;

            return new(new Point2D(minX, minY), new Point2D(maxX, maxY));
        }

        /// <summary>
        /// Calculates the distance between the foci of the ellipse.
        /// </summary>
        /// <returns>The focal length.</returns>
        public double GetFocalLength()
        {
            double c = C;
            if (double.IsNaN(c))
            {
                return double.NaN;
            }

            return c * c;
        }

        /// <summary>
        /// Gets the focal points of the ellipse.
        /// </summary>
        /// <returns>An array containing the two foci.</returns>
        public Point2D[]? GetFocalPoints()
        {
            if (directionA == null || center is null || double.IsNaN(a) || double.IsNaN(b))
            {
                return null;
            }

            Vector2D? vector2D = (a > b ? directionA : DirectionB) * C;
            if (vector2D is null)
            {
                return null;
            }

            Point2D? point2D_1 = center.GetMoved(vector2D);
            if (point2D_1 is null)
            {
                return null;
            }

            Point2D? point2D_2 = center.GetMoved(vector2D.GetInversed());
            if (point2D_2 is null)
            {
                return null;
            }

            return [point2D_1, point2D_2];
        }

        /// <summary>
        /// Gets the hash code for this ellipse.
        /// </summary>
        /// <returns>A 32-bit signed integer hash code.</returns>
        public override int GetHashCode()
        {
            int hashCode = -203223210;
            hashCode = hashCode * -1521134295 + a.GetHashCode();
            hashCode = hashCode * -1521134295 + b.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Point2D?>.Default.GetHashCode(center);
            hashCode = hashCode * -1521134295 + EqualityComparer<Vector2D?>.Default.GetHashCode(directionA);
            return hashCode;
        }

        /// <summary>
        /// Gets a point guaranteed to be inside the ellipse.
        /// </summary>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>An internal point of the ellipse.</returns>
        public Point2D? GetInternalPoint(double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (center == null)
            {
                return null;
            }

            return new Point2D(center);
        }

        /// <summary>
        /// Calculates the approximate perimeter of the ellipse using Ramanujan's formula.
        /// </summary>
        /// <returns>The circumference of the ellipse.</returns>
        public double GetPerimeter()
        {
            double h = System.Math.Pow(a - b, 2) / System.Math.Pow(a + b, 2);
            return System.Math.PI * (a + b) * (1 + (3 * h) / (10 + System.Math.Sqrt(4 - 3 * h)));
        }

        /// <summary>
        /// Gets the point on the ellipse boundary in a given direction from the center.
        /// </summary>
        /// <param name="vector2D">The direction vector.</param>
        /// <returns>The corresponding point on the ellipse boundary.</returns>
        public Point2D? GetPoint(Vector2D? vector2D)
        {
            if (vector2D == null || directionA == null || center == null)
            {
                return null;
            }

            // Normalize input direction vector
            double len = System.Math.Sqrt(vector2D.X * vector2D.X + vector2D.Y * vector2D.Y);
            if (len == 0)
            {
                return null;
            }

            double dx = vector2D.X / len;
            double dy = vector2D.Y / len;

            // Rotate direction into ellipse-aligned coordinates
            double ux = directionA.X;
            double uy = directionA.Y;
            double vx = -uy;
            double vy = ux;

            double dxRot = dx * ux + dy * uy; // component along major axis
            double dyRot = dx * vx + dy * vy; // component along minor axis

            // Scale to match ellipse shape (a, b)
            double scale = 1 / System.Math.Sqrt((dxRot * dxRot) / (a * a) + (dyRot * dyRot) / (b * b));
            double xr = dxRot * scale;
            double yr = dyRot * scale;

            // Rotate back to global coordinates
            double xGlobal = xr * ux + yr * vx + center.X;
            double yGlobal = xr * uy + yr * vy + center.Y;

            return new Point2D(xGlobal, yGlobal);
        }

        /// <summary>
        /// Checks if a point is within or on the boundary of the ellipse.
        /// </summary>
        /// <param name="point2D">The point to check.</param>
        /// <param name="tolerance">The distance tolerance for the check.</param>
        /// <returns>True if the point is in range of the ellipse.</returns>
        public bool InRange(Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point2D is null || center is null || directionA is null)
            {
                return false;
            }

            double dx = point2D.X - center.X;
            double dy = point2D.Y - center.Y;

            // Create perpendicular vector (minor axis direction)
            double majorX = directionA.X;
            double majorY = directionA.Y;
            double minorX = -majorY;
            double minorY = majorX;

            // Project point onto major/minor axes
            double xr = dx * majorX + dy * majorY; // projection onto major axis
            double yr = dx * minorX + dy * minorY; // projection onto minor axis

            return (xr / a) * (xr / a) + (yr / b) * (yr / b) <= 1.0 + tolerance;
        }

        /// <summary>
        /// Checks if a point is strictly inside the ellipse boundaries.
        /// </summary>
        /// <param name="point2D">The point to check.</param>
        /// <param name="tolerance">The distance tolerance for the check.</param>
        /// <returns>True if the point is strictly inside.</returns>
        public bool Inside(Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            return InRange(point2D, -tolerance);
        }

        /// <summary>
        /// Inverts the direction of the major axis.
        /// </summary>
        public void Inverse()
        {
            directionA?.Inverse();
        }

        /// <summary>
        /// Moves the ellipse by the specified vector.
        /// </summary>
        /// <param name="vector2D">The translation vector.</param>
        /// <returns>True if the move was successful.</returns>
        public override bool Move(Vector2D? vector2D)
        {
            if (vector2D == null || center == null)
            {
                return false;
            }

            center.Move(vector2D);
            return true;
        }

        /// <summary>
        /// Checks if a point lies on the boundary of the ellipse.
        /// </summary>
        /// <param name="point2D">The point to check.</param>
        /// <param name="tolerance">The distance tolerance for the check.</param>
        /// <returns>True if the point is on the boundary.</returns>
        public bool On(Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point2D is null || center is null || directionA is null)
            {
                return false;
            }

            double dx = point2D.X - center.X;
            double dy = point2D.Y - center.Y;

            // Major axis direction (u) and minor axis direction (v)
            double ux = directionA.X;
            double uy = directionA.Y;
            double vx = -uy;
            double vy = ux;

            // Project point into rotated coordinate system
            double xr = dx * ux + dy * uy; // component along major axis
            double yr = dx * vx + dy * vy; // component along minor axis

            // Evaluate normalized ellipse equation
            double value = (xr / a) * (xr / a) + (yr / b) * (yr / b);

            return System.Math.Abs(value - 1.0) <= tolerance;
        }

        /// <summary>
        /// Projects a point onto the ellipse boundary using an iterative approach.
        /// </summary>
        /// <param name="point2D">The target point.</param>
        /// <returns>The projected point on the ellipse boundary.</returns>
        public Point2D? Project(Point2D? point2D)
        {
            if (point2D == null || center == null)
            {
                return null;
            }

            Vector2D vector2D = new(center, point2D);

            vector2D.Scale(System.Math.Max(a, b) * 2);

            return Query.IntersectionPoints(this, new Segment2D(center, vector2D), 0)?.FirstOrDefault();
        }

        /// <summary>
        /// Projects a point onto the ellipse boundary with a specified tolerance for convergence.
        /// </summary>
        /// <param name="point2D">The target point.</param>
        /// <param name="tolerance">The convergence tolerance.</param>
        /// <returns>The projected point on the ellipse boundary.</returns>
        public Point2D? Project(Point2D? point2D, double tolerance)
        {
            if (point2D is null || center is null || directionA is null)
            {
                return null;
            }

            // Translate point to ellipse-centered coordinates
            double px = point2D.X - center.X;
            double py = point2D.Y - center.Y;

            // Build orthonormal basis: major (u) and minor (v) axes
            double ux = directionA.X;
            double uy = directionA.Y;
            double vx = -uy;
            double vy = ux;

            // Rotate point into ellipse-aligned space
            double xr = px * ux + py * uy; // coordinate in major axis direction
            double yr = px * vx + py * vy; // coordinate in minor axis direction

            // Newton-Raphson to find projection on ellipse
            double tx = xr;
            double ty = yr;

            double deltaTx = double.MaxValue;
            double deltaTy = double.MaxValue;

            while (System.Math.Min(deltaTx, deltaTy) > tolerance)
            {
                double ex = a * tx / System.Math.Sqrt(tx * tx + (b * b / (a * a)) * ty * ty);
                double ey = b * ty / System.Math.Sqrt((a * a / (b * b)) * tx * tx + ty * ty);

                double norm = System.Math.Sqrt(ex * ex + ey * ey);
                if (DiGi.Core.Query.AlmostEquals(norm, 0, tolerance))
                {
                    break;
                }

                double x = xr * ex / norm;
                double y = yr * ey / norm;

                deltaTx = System.Math.Abs(tx - x);
                deltaTy = System.Math.Abs(ty - y);

                tx = x;
                ty = y;
            }

            // Scale ellipse to get unit circle projection
            double normProj = System.Math.Sqrt((xr * xr) / (a * a) + (yr * yr) / (b * b));
            double prx = xr / normProj;
            double pry = yr / normProj;

            // Map back to global coordinates
            double gx = prx * ux + pry * vx + center.X;
            double gy = prx * uy + pry * vy + center.Y;

            return new Point2D(gx, gy);
        }

        /// <summary>
        /// Transforms the ellipse using the specified transformation.
        /// </summary>
        /// <param name="transform">The transformation to apply.</param>
        /// <returns>True if the transformation was successful.</returns>
        public override bool Transform(ITransform2D? transform)
        {
            if (transform == null || center == null || directionA is null)
            {
                return false;
            }

            // Construct perpendicular direction for semi-minor axis
            Vector2D vector2D_DirectionB = new(-directionA.Y, directionA.X);

            Point2D point2D_A = new(center);
            point2D_A.Move(directionA * a);

            Point2D point2D_B = new(center);
            point2D_B.Move(vector2D_DirectionB * b);

            Point2D point2D_CenterClone = new(center);
            Point2D point2D_AClone = new(point2D_A);
            Point2D point2D_BClone = new(point2D_B);

            if (!point2D_CenterClone.Transform(transform))
            {
                return false;
            }

            if (!point2D_AClone.Transform(transform))
            {
                return false;
            }

            if (!point2D_BClone.Transform(transform))
            {
                return false;
            }

            Vector2D vector2D_NewA = new(point2D_CenterClone, point2D_AClone);
            Vector2D vector2D_NewB = new(point2D_CenterClone, point2D_BClone);

            center = point2D_CenterClone;
            a = vector2D_NewA.Length;
            b = vector2D_NewB.Length;
            directionA = vector2D_NewA.Unit;

            return true;
        }
    }
}
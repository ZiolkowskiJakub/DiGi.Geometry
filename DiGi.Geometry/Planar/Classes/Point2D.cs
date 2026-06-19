using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Planar.Classes
{
    /// <summary>
    /// Represents a point in 2D space defined by X and Y coordinates.
    /// </summary>
    public class Point2D : Coordinate2D, IMovable2D, IPoint<Point2D>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Point2D"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing point data.</param>
        public Point2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Point2D"/> class with specified X and Y coordinates.
        /// </summary>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        public Point2D(double x, double y)
            : base(x, y)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Point2D"/> class using an array of values.
        /// </summary>
        /// <param name="values">The array containing coordinate values.</param>
        public Point2D(double[]? values)
            : base(values)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Point2D"/> class by cloning an existing point.
        /// </summary>
        /// <param name="point2D">The source point to clone.</param>
        public Point2D(Point2D? point2D)
            : base(point2D)
        {
        }

        /// <summary>
        /// Implicitly converts a tuple of two doubles to a Point2D.
        /// </summary>
        /// <param name="object">The tuple containing X and Y coordinates.</param>
        /// <returns>A new Point2D instance.</returns>
        public static implicit operator Point2D((double x, double y) @object)
        {
            return new(@object.x, @object.y);
        }

        /// <summary>
        /// Subtracts a vector from a point to produce a new point.
        /// </summary>
        /// <param name="point2D">The origin point.</param>
        /// <param name="vector2D">The translation vector.</param>
        /// <returns>A new Point2D shifted by the negative of the vector, or null if either input is null.</returns>
        public static Point2D? operator -(Point2D? point2D, Vector2D? vector2D)
        {
            if (point2D is null || vector2D is null)
            {
                return null;
            }

            return new(point2D.values[0] - vector2D[0], point2D.values[1] - vector2D[1]);
        }

        /// <summary>
        /// Adds a vector to a point to produce a new point.
        /// </summary>
        /// <param name="point2D">The origin point.</param>
        /// <param name="vector2D">The translation vector.</param>
        /// <returns>A new Point2D shifted by the vector, or null if either input is null.</returns>
        public static Point2D? operator +(Point2D? point2D, Vector2D? vector2D)
        {
            if (point2D is null || vector2D is null)
            {
                return null;
            }

            return new(point2D.values[0] + vector2D[0], point2D.values[1] + vector2D[1]);
        }

        /// <summary>
        /// Creates a clone of the current point.
        /// </summary>
        /// <returns>A cloned <see cref="ISerializableObject"/>.</returns>
        public override ISerializableObject? Clone()
        {
            return new Point2D(values);
        }

        /// <summary>
        /// Calculates the distance between this point and another point.
        /// </summary>
        /// <param name="point2D">The other point.</param>
        /// <returns>The distance result, or NaN if the input is null.</returns>
        public double Distance(Point2D? point2D)
        {
            if (point2D == null)
            {
                return double.NaN;
            }

            double dx = X - point2D.X;
            double dy = Y - point2D.Y;
            return System.Math.Sqrt((dx * dx) + (dy * dy));
        }

        /// <summary>
        /// Gets a new point with absolute values of the coordinates.
        /// </summary>
        /// <returns>A new <see cref="Point2D"/> with absolute coordinate values.</returns>
        public Point2D? GetAbs()
        {
            Point2D result = new(this);

            result.Abs();

            return result;
        }

        /// <summary>
        /// Returns a new point moved by the specified vector.
        /// </summary>
        /// <param name="vector3D">The movement vector.</param>
        /// <returns>A new <see cref="Point2D"/> shifted by the vector, or null if input is null.</returns>
        public Point2D? GetMoved(Vector2D? vector3D)
        {
            if (vector3D is null)
            {
                return null;
            }

            Point2D result = new(this);
            result.Move(vector3D);

            return result;
        }

        /// <summary>
        /// Checks if another point is within a specified distance from this point.
        /// </summary>
        /// <param name="point2D">The other point to check.</param>
        /// <param name="distance">The maximum distance.</param>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>True if the point is within the specified distance; otherwise, false.</returns>
        public bool InDistance(Point2D? point2D, double distance, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point2D == null)
            {
                return false;
            }

            if (System.Math.Abs(X - point2D.X) > distance + tolerance)
            {
                return false;
            }

            if (System.Math.Abs(Y - point2D.Y) > distance + tolerance)
            {
                return false;
            }

            return Distance(point2D) < distance - tolerance;
        }

        /// <summary>
        /// Calculates the midpoint between this point and another point.
        /// </summary>
        /// <param name="point2D">The other point.</param>
        /// <returns>A new <see cref="Point2D"/> representing the midpoint, or null if input is null.</returns>
        public Point2D? Mid(Point2D? point2D)
        {
            if (point2D == null)
            {
                return null;
            }

            return new Point2D((point2D[0] + values[0]) / 2, (point2D[1] + values[1]) / 2);
        }
    }
}
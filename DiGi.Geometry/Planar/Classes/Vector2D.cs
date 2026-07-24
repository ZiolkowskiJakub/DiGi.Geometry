using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Core.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    /// <summary>
    /// Represents a two-dimensional vector that inherits from <see cref="Coordinate2D"/> and implements the <see cref="IVector"/> interface.
    /// </summary>
    public class Vector2D : Coordinate2D, IVector
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Vector2D"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing vector data.</param>
        public Vector2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector2D"/> class by cloning an existing vector.
        /// </summary>
        /// <param name="vector2D">The source vector to clone.</param>
        public Vector2D(Vector2D? vector2D)
            : base(vector2D)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector2D"/> class defined by two points.
        /// </summary>
        /// <param name="start">The start point of the vector.</param>
        /// <param name="end">The end point of the vector.</param>
        public Vector2D(Point2D? start, Point2D? end)
            : base(2)
        {
            if (start != null && end != null)
            {
                values[0] = end[0] - start[0];
                values[1] = end[1] - start[1];
            }
            else
            {
                values[0] = double.NaN;
                values[1] = double.NaN;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector2D"/> class with specified X and Y components.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="y">The Y component.</param>
        public Vector2D(double x, double y)
            : base(x, y)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector2D"/> class using an array of values.
        /// </summary>
        /// <param name="values">The array containing coordinate values.</param>
        public Vector2D(double[]? values)
            : base(values)
        {
        }

        /// <summary>
        /// Gets or sets the length of the vector.
        /// </summary>
        [JsonIgnore]
        public double Length
        {
            get
            {
                return System.Math.Sqrt(SquaredLength);
            }
            set
            {
                double length = Length;
                if (length == 0 || double.IsNaN(length))
                {
                    return;
                }

                double factor = value / length;
                values[0] *= factor;
                values[1] *= factor;
            }
        }

        /// <summary>
        /// Gets the squared length of the vector.
        /// </summary>
        [JsonIgnore]
        public double SquaredLength
        {
            get
            {
                return (values[0] * values[0]) + (values[1] * values[1]);
            }
        }

        /// <summary>
        /// Gets the unit vector in the same direction as this vector.
        /// </summary>
        [JsonIgnore]
        public Vector2D? Unit
        {
            get
            {
                Vector2D result = new(this);
                result.Normalize();

                return result;
            }
        }

        /// <summary>
        /// Explicitly converts a Point2D to a Vector2D.
        /// </summary>
        /// <param name="point2D">The point to convert.</param>
        /// <returns>A new Vector2D with the same coordinates as the point, or null if the point is null.</returns>
        public static explicit operator Vector2D?(Point2D? point2D)
        {
            if (point2D == null)
            {
                return null;
            }

            return new(point2D.X, point2D.Y);
        }

        /// <summary>
        /// Implicitly converts a tuple of two doubles to a Vector2D.
        /// </summary>
        /// <param name="object">The tuple containing X and Y components.</param>
        /// <returns>A new Vector2D instance.</returns>
        public static implicit operator Vector2D?((double x, double y) @object)
        {
            return new(@object.x, @object.y);
        }

        /// <summary>
        /// Implicitly converts a tuple of start and end points to a Vector2D.
        /// </summary>
        /// <param name="object">The tuple containing the start and end points.</param>
        /// <returns>A new Vector2D defined by the two points, or null if either point is null.</returns>
        public static implicit operator Vector2D?((Point2D? start, Point2D? end) @object)
        {
            return new(@object.start, @object.end);
        }

        /// <summary>
        /// Subtracts one vector from another.
        /// </summary>
        /// <param name="vector2D_1">The first vector.</param>
        /// <param name="vector2D_2">The second vector to subtract.</param>
        /// <returns>A new Vector2D result, or null if either input is null.</returns>
        public static Vector2D? operator -(Vector2D? vector2D_1, Vector2D? vector2D_2)
        {
            if (vector2D_1 is null || vector2D_2 is null)
            {
                return null;
            }

            return new(vector2D_1.values[0] - vector2D_2.values[0], vector2D_1.values[1] - vector2D_2.values[1]);
        }

        /// <summary>
        /// Checks if two vectors are not equal.
        /// </summary>
        /// <param name="vector2D_1">The first vector.</param>
        /// <param name="vector2D_2">The second vector.</param>
        /// <returns>True if the vectors are different; otherwise, false.</returns>
        public static bool operator !=(Vector2D? vector2D_1, Vector2D? vector2D_2)
        {
            if (ReferenceEquals(vector2D_1, vector2D_2))
            {
                return false;
            }

            if (vector2D_1 is null || vector2D_2 is null)
            {
                return true;
            }

            return vector2D_1.values[0] != vector2D_2.values[0] || vector2D_1.values[1] != vector2D_2.values[1];
        }

        /// <summary>
        /// Calculates the dot product of two vectors.
        /// </summary>
        /// <param name="vector2D_1">The first vector.</param>
        /// <param name="vector2D_2">The second vector.</param>
        /// <returns>The scalar result of the dot product, or NaN if either input is null.</returns>
        public static double operator *(Vector2D? vector2D_1, Vector2D? vector2D_2)
        {
            if (vector2D_1 is null || vector2D_2 is null)
            {
                return double.NaN;
            }

            return vector2D_1.values[0] * vector2D_2.values[0] + vector2D_1.values[1] * vector2D_2.values[1];
        }

        /// <summary>
        /// Scales a vector by a numeric factor.
        /// </summary>
        /// <param name="vector2D">The vector to scale.</param>
        /// <param name="factor">The scaling factor.</param>
        /// <returns>A new scaled Vector2D, or null if the vector is null.</returns>
        public static Vector2D? operator *(Vector2D? vector2D, double factor)
        {
            if (vector2D is null)
            {
                return null;
            }

            return new(vector2D.values[0] * factor, vector2D.values[1] * factor);
        }

        /// <summary>
        /// Scales a vector by a numeric factor.
        /// </summary>
        /// <param name="factor">The scaling factor.</param>
        /// <param name="vector2D">The vector to scale.</param>
        /// <returns>A new scaled Vector2D, or null if the vector is null.</returns>
        public static Vector2D? operator *(double factor, Vector2D? vector2D)
        {
            if (vector2D is null)
            {
                return null;
            }

            return new(vector2D.values[0] * factor, vector2D.values[1] * factor);
        }

        /// <summary>
        /// Divides a vector by a numeric factor.
        /// </summary>
        /// <param name="vector2D">The vector to divide.</param>
        /// <param name="factor">The divisor factor.</param>
        /// <returns>A new scaled Vector2D, or null if the vector is null.</returns>
        public static Vector2D? operator /(Vector2D? vector2D, double factor)
        {
            if (vector2D is null)
            {
                return null;
            }

            double invFactor = 1.0 / factor;
            return new(vector2D.values[0] * invFactor, vector2D.values[1] * invFactor);
        }

        /// <summary>
        /// Adds two vectors together.
        /// </summary>
        /// <param name="vector2D_1">The first vector.</param>
        /// <param name="vector2D_2">The second vector to add.</param>
        /// <returns>A new Vector2D result, or null if either input is null.</returns>
        public static Vector2D? operator +(Vector2D? vector2D_1, Vector2D? vector2D_2)
        {
            if (vector2D_1 is null || vector2D_2 is null)
            {
                return null;
            }

            return new(vector2D_1.values[0] + vector2D_2.values[0], vector2D_1.values[1] + vector2D_2.values[1]);
        }

        /// <summary>
        /// Checks if two vectors are equal.
        /// </summary>
        /// <param name="vector2D_1">The first vector.</param>
        /// <param name="vector2D_2">The second vector.</param>
        /// <returns>True if the vectors are identical; otherwise, false.</returns>
        public static bool operator ==(Vector2D? vector2D_1, Vector2D? vector2D_2)
        {
            if (ReferenceEquals(vector2D_1, vector2D_2))
            {
                return true;
            }

            if (vector2D_1 is null || vector2D_2 is null)
            {
                return false;
            }

            return vector2D_1.values[0] == vector2D_2.values[0] && vector2D_1.values[1] == vector2D_2.values[1];
        }

        /// <summary>
        /// Calculate the dot product as an angle. Use SignedAngle if performance is priority
        /// Source: https://wiki.unity3d.com/index.php/3d_Math_functions
        /// </summary>
        /// <param name="vector2D">Vector2D</param>
        /// <returns>Angle in radians</returns>
        public double Angle(Vector2D? vector2D)
        {
            if (vector2D is null)
            {
                return double.NaN;
            }

            double dotProduct = DotProduct(vector2D);
            double length = System.Math.Sqrt(SquaredLength * vector2D.SquaredLength);

            if (length == 0 || double.IsNaN(length))
            {
                return double.NaN;
            }

            double cosAngle = dotProduct / length;
            if (cosAngle < -1)
            {
                cosAngle = -1;
            }
            else if (cosAngle > 1)
            {
                cosAngle = 1;
            }

            return System.Math.Acos(cosAngle);
        }

        /// <summary>
        /// Creates a clone of the current vector.
        /// </summary>
        /// <returns>A cloned <see cref="ISerializableObject"/>.</returns>
        public override ISerializableObject Clone()
        {
            return new Vector2D(this);
        }

        /// <summary>
        /// Checks if this vector is collinear with another vector within a given tolerance.
        /// </summary>
        /// <param name="vector2D">The vector to check for collinearity.</param>
        /// <param name="tolerance">The angle tolerance.</param>
        /// <returns>True if the vectors are collinear; otherwise, false.</returns>
        public bool Collinear(Vector2D vector2D, double tolerance = DiGi.Core.Constants.Tolerance.Angle)
        {
            if (vector2D == null)
            {
                return false;
            }

            return System.Math.Abs(System.Math.Abs(this * vector2D) - (Length * vector2D.Length)) <= tolerance;
        }

        /// <summary>
        /// Calculates the dot product of this vector and another vector.
        /// </summary>
        /// <param name="vector2D">The other vector.</param>
        /// <returns>The dot product result, or NaN if the input is null.</returns>
        public double DotProduct(Vector2D? vector2D)
        {
            if (vector2D == null)
            {
                return double.NaN;
            }

            return (values[0] * vector2D.values[0]) + (values[1] * vector2D.values[1]);
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current vector.
        /// </summary>
        /// <param name="obj">The object to compare with the current vector.</param>
        /// <returns>True if the objects are equal; otherwise, false.</returns>
        public override bool Equals(object? obj)
        {
            return obj is Vector2D d &&
                   base.Equals(obj) &&
                   EqualityComparer<double[]>.Default.Equals(values, d.values);
        }

        /// <summary>
        /// Gets a new vector with absolute values of the components.
        /// </summary>
        /// <returns>A new <see cref="Vector2D"/> with absolute component values.</returns>
        public Vector2D GetAbs()
        {
            Vector2D result = new(this);

            result.Abs();

            return result;
        }

        /// <summary>
        /// Gets the hash code for this vector.
        /// </summary>
        /// <returns>A 32-bit signed integer hash code.</returns>
        public override int GetHashCode()
        {
            int hashCode = 1501109969;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<double[]>.Default.GetHashCode(values);
            return hashCode;
        }

        /// <summary>
        /// Gets a new vector that is the inverse of this vector.
        /// </summary>
        /// <returns>A new <see cref="Vector2D"/> representing the opposite direction.</returns>
        public Vector2D GetInversed()
        {
            Vector2D result = new(this);
            result.Inverse();

            return result;
        }

        /// <summary>
        /// Gets a perpendicular vector to the current vector based on the specified orientation.
        /// </summary>
        /// <param name="orientation">The desired orientation of the perpendicular vector.</param>
        /// <returns>A perpendicular <see cref="Vector2D"/>, or null if the orientation is undefined or collinear.</returns>
        public Vector2D? GetPerpendicular(Orientation orientation = Orientation.Clockwise)
        {
            return orientation switch
            {
                Orientation.Clockwise => new Vector2D(values[1], -values[0]),
                Orientation.CounterClockwise => new Vector2D(-values[1], values[0]),
                Orientation.Undefined => null,
                Orientation.Collinear => null,
                _ => null,
            };
        }

        /// <summary>
        /// Normalizes the current vector to have a length of 1.
        /// </summary>
        public void Normalize()
        {
            double squaredLength = SquaredLength;
            if (squaredLength == 0 || double.IsNaN(squaredLength))
            {
                return;
            }

            double invLength = 1.0 / System.Math.Sqrt(squaredLength);
            values[0] *= invLength;
            values[1] *= invLength;
        }

        /// <summary>
        /// Projects a point onto the line defined by this vector passing through the origin.
        /// </summary>
        /// <param name="point2D">The target point to project.</param>
        /// <returns>The projected <see cref="Point2D"/>, or null if the input is null.</returns>
        public Point2D? Project(Point2D? point2D)
        {
            if (point2D == null)
            {
                return null;
            }

            if (values[0] == 0)
            {
                return new Point2D(0, point2D.Y);
            }

            if (values[1] == 0)
            {
                return new Point2D(point2D.X, 0);
            }

            double m = values[1] / values[0];

            double x = (m * point2D.Y + point2D.X - m * 0) / (m * m + 1);
            double y = (m * m * point2D.Y + m * point2D.X) / (m * m + 1);

            return new Point2D(x, y);
        }

        /// <summary>
        /// Project input Vector onto this Vector
        /// </summary>
        /// <param name="vector2D">Vector to be projected</param>
        /// <returns>Projection vector</returns>
        public Vector2D? Project(Vector2D? vector2D)
        {
            if (vector2D == null)
            {
                return null;
            }

            Vector2D result = new(this);
            result.Scale(vector2D.DotProduct(this) / DotProduct(this));
            return result;
        }

        /// <summary>
        /// Calculates the signed angle between this vector and another vector.
        /// </summary>
        /// <param name="vector2D">The other vector.</param>
        /// <returns>The signed angle in radians, or NaN if the input is null.</returns>
        public double SignedAngle(Vector2D? vector2D)
        {
            if (vector2D is null)
            {
                return double.NaN;
            }

            double dot = X * vector2D.X + Y * vector2D.Y;      // x1 * x2 + y1 * y2
            double cross = X * vector2D.Y - Y * vector2D.X;    // x1 * y2 - y1 * x2

            return System.Math.Atan2(cross, dot);
        }
    }
}

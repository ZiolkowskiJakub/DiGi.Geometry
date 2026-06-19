using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents a three-dimensional vector.
    /// </summary>
    public class Vector3D : Coordinate3D, IVector
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3D"/> class using the provided <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data to initialize the vector.</param>
        public Vector3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3D"/> class using the values from an existing <see cref="Vector3D"/>.
        /// </summary>
        /// <param name="vector3D">The <see cref="Vector3D"/> object to copy the values from.</param>
        public Vector3D(Vector3D? vector3D)
            : base(vector3D)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3D"/> class based on two points.
        /// </summary>
        /// <param name="start">The starting <see cref="Point3D"/> point.</param>
        /// <param name="end">The ending <see cref="Point3D"/> point.</param>
        public Vector3D(Point3D? start, Point3D? end)
            : base()
        {
            values = [double.NaN, double.NaN, double.NaN];
            if (start != null && end != null)
            {
                values[0] = end[0] - start[0];
                values[1] = end[1] - start[1];
                values[2] = end[2] - start[2];
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3D"/> class with the specified x, y, and z coordinates.
        /// </summary>
        /// <param name="x">The x-coordinate as a double.</param>
        /// <param name="y">The y-coordinate as a double.</param>
        /// <param name="z">The z-coordinate as a double.</param>
        public Vector3D(double x, double y, double z)
            : base(x, y, z)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector3D"/> class using the specified array of <see cref="double"/>.
        /// </summary>
        /// <param name="values">An optional array of <see cref="double"/> values to initialize the vector coordinates.</param>
        public Vector3D(double[]? values)
            : base(values)
        {
        }

        /// <summary>
        /// Gets or sets the length (magnitude) of the vector.
        /// </summary>
        /// <value>A <see cref="double"/> representing the length of the vector.</value>
        [JsonIgnore]
        public double Length
        {
            get
            {
                return System.Math.Sqrt(SquaredLength);
            }
            set
            {
                Vector3D? vector3D = Unit;
                vector3D?.Scale(value);
                if (vector3D is not null)
                {
                    values = [vector3D![0], vector3D[1], vector3D[2]];
                }
            }
        }

        /// <summary>
        /// Gets the squared length of the vector.
        /// </summary>
        /// <value>The squared length as a <see cref="double"/>.</value>
        [JsonIgnore]
        public double SquaredLength
        {
            get
            {
                return (values[0] * values[0]) + (values[1] * values[1]) + (values[2] * values[2]);
            }
        }

        /// <summary>
        /// Gets the unit vector of the current instance.
        /// </summary>
        /// <value>A <see cref="Vector3D"/> representing the normalized direction, or null.</value>
        [JsonIgnore]
        public Vector3D? Unit
        {
            get
            {
                Vector3D result = new(this);
                result.Normalize();

                return result;
            }
        }

        /// <summary>
        /// Explicitly converts a nullable <see cref="Point3D"/> to a nullable <see cref="Vector3D"/>.
        /// </summary>
        /// <param name="point3D">The nullable <see cref="Point3D"/> instance to convert.</param>
        /// <returns>A nullable <see cref="Vector3D"/> representing the coordinates of the point, or null if the provided point is null.</returns>
        public static explicit operator Vector3D?(Point3D? point3D)
        {
            if (point3D == null)
            {
                return null;
            }

            return new Vector3D(point3D.X, point3D.Y, point3D.Z);
        }

        /// <summary>
        /// Implicitly converts a tuple of three <see cref="double"/> values into a <see cref="Vector3D"/>.
        /// </summary>
        /// <param name="object">The tuple containing the x, y, and z coordinates of the vector.</param>
        /// <returns>A new <see cref="Vector3D"/> instance created from the provided coordinates.</returns>
        public static implicit operator Vector3D((double x, double y, double z) @object)
        {
            return new Vector3D(@object.x, @object.y, @object.z);
        }

        /// <summary>
        /// Implicitly converts a tuple of two <see cref="Point3D"/> objects into a <see cref="Vector3D"/>.
        /// </summary>
        /// <param name="object">The tuple containing the start and end <see cref="Point3D"/> points that define the vector.</param>
        /// <returns>A new <see cref="Vector3D"/> instance representing the displacement from the start point to the end point.</returns>
        public static implicit operator Vector3D((Point3D start, Point3D end) @object)
        {
            return new Vector3D(@object.start, @object.end);
        }

        /// <summary>
        /// Subtracts one <see cref="Vector3D"/> vector from another.
        /// </summary>
        /// <param name="vector3D_1">The first <see cref="Vector3D"/> vector.</param>
        /// <param name="vector3D_2">The second <see cref="Vector3D"/> vector to subtract from the first.</param>
        /// <returns>A new <see cref="Vector3D"/> representing the difference, or <see langword="null"/> if either operand is <see langword="null"/>.</returns>
        public static Vector3D? operator -(Vector3D? vector3D_1, Vector3D? vector3D_2)
        {
            if (vector3D_1 is null || vector3D_2 is null)
            {
                return null;
            }

            return new Vector3D(vector3D_1.values[0] - vector3D_2.values[0], vector3D_1.values[1] - vector3D_2.values[1], vector3D_1.values[2] - vector3D_2.values[2]);
        }

        /// <summary>
        /// Negates the components of the specified <see cref="Vector3D"/> vector.
        /// </summary>
        /// <param name="vector3D">The <see cref="Vector3D"/> to negate.</param>
        /// <returns>A new <see cref="Vector3D"/> with negated components, or <see langword="null"/> if the input is <see langword="null"/>.</returns>
        public static Vector3D? operator -(Vector3D? vector3D)
        {
            Vector3D result = new(vector3D);
            result.Inverse();
            return result;
        }

        /// <summary>
        /// Indicates whether two <see cref="Vector3D"/> instances are not equal.
        /// </summary>
        /// <param name="vector3D_1">The first <see cref="Vector3D"/> to compare.</param>
        /// <param name="vector3D_2">The second <see cref="Vector3D"/> to compare.</param>
        /// <returns><see langword="true"/> if the vectors are not equal; otherwise, <see langword="false"/>.</returns>
        public static bool operator !=(Vector3D? vector3D_1, Vector3D? vector3D_2)
        {
            return vector3D_1?.values[0] != vector3D_2?.values[0] || vector3D_1?.values[1] != vector3D_2?.values[1] || vector3D_1?.values[2] != vector3D_2?.values[2];
        }

        /// <summary>
        /// Calculates the dot product of two <see cref="Vector3D"/> vectors.
        /// </summary>
        /// <param name="vector3D_1">The first <see cref="Vector3D"/>.</param>
        /// <param name="vector3D_2">The second <see cref="Vector3D"/>.</param>
        /// <returns>The dot product of the two vectors, or <see cref="double.NaN"/> if either vector is <see langword="null"/>.</returns>
        public static double operator *(Vector3D? vector3D_1, Vector3D? vector3D_2)
        {
            if (vector3D_1 is null || vector3D_2 is null)
            {
                return double.NaN;
            }

            return vector3D_1.values[0] * vector3D_2.values[0] + vector3D_1.values[1] * vector3D_2.values[1] + vector3D_1.values[2] * vector3D_2.values[2];
        }

        /// <summary>
        /// Multiplies the components of a <see cref="Vector3D"/> by a specified scalar factor.
        /// </summary>
        /// <param name="vector3D_1">The <see cref="Vector3D"/> to scale.</param>
        /// <param name="factor">The scalar factor to multiply by.</param>
        /// <returns>A new <see cref="Vector3D"/> that is the result of the multiplication, or <see langword="null"/> if the input vector is <see langword="null"/>.</returns>
        public static Vector3D? operator *(Vector3D? vector3D_1, double factor)
        {
            if (vector3D_1 is null)
            {
                return null;
            }

            return new Vector3D(vector3D_1.values[0] * factor, vector3D_1.values[1] * factor, vector3D_1.values[2] * factor);
        }

        /// <summary>
        /// Multiplies the components of a <see cref="Vector3D"/> by a specified scalar factor.
        /// </summary>
        /// <param name="factor">The scalar factor to multiply by.</param>
        /// <param name="vector3D_1">The <see cref="Vector3D"/> to scale.</param>
        /// <returns>A new <see cref="Vector3D"/> that is the result of the multiplication, or <see langword="null"/> if the input vector is <see langword="null"/>.</returns>
        public static Vector3D? operator *(double factor, Vector3D? vector3D_1)
        {
            if (vector3D_1 is null)
            {
                return null;
            }

            return new Vector3D(vector3D_1.values[0] * factor, vector3D_1.values[1] * factor, vector3D_1.values[2] * factor);
        }

        /// <summary>
        /// Divides the components of a <see cref="Vector3D"/> by a specified scalar factor.
        /// </summary>
        /// <param name="vector3D">The <see cref="Vector3D"/> to divide.</param>
        /// <param name="factor">The scalar factor to divide by.</param>
        /// <returns>A new <see cref="Vector3D"/> that is the result of the division, or <see langword="null"/> if the input vector is <see langword="null"/>.</returns>
        public static Vector3D? operator /(Vector3D? vector3D, double factor)
        {
            if (vector3D is null)
            {
                return null;
            }

            return new Vector3D(vector3D.X / factor, vector3D.Y / factor, vector3D.Z / factor);
        }

        /// <summary>
        /// Adds two <see cref="Vector3D"/> instances together using component-wise addition.
        /// </summary>
        /// <param name="vector3D_1">The first <see cref="Vector3D"/> to add.</param>
        /// <param name="vector3D_2">The second <see cref="Vector3D"/> to add.</param>
        /// <returns>A new <see cref="Vector3D"/> that is the sum of the two vectors, or <see langword="null"/> if either operand is <see langword="null"/>.</returns>
        public static Vector3D? operator +(Vector3D? vector3D_1, Vector3D? vector3D_2)
        {
            if (vector3D_1 is null || vector3D_2 is null)
            {
                return null;
            }

            return new Vector3D(vector3D_1.values[0] + vector3D_2.values[0], vector3D_1.values[1] + vector3D_2.values[1], vector3D_1.values[2] + vector3D_2.values[2]);
        }

        /// <summary>
        /// Indicates whether the two specified <see cref="Vector3D"/> instances are equal.
        /// </summary>
        /// <param name="vector3D_1">The first <see cref="Vector3D"/> to compare.</param>
        /// <param name="vector3D_2">The second <see cref="Vector3D"/> to compare.</param>
        /// <returns><see langword="true"/> if the vectors are equal; otherwise, <see langword="false"/>.</returns>
        public static bool operator ==(Vector3D? vector3D_1, Vector3D? vector3D_2)
        {
            if (vector3D_1 is null && vector3D_2 is null)
            {
                return true;
            }

            if (vector3D_1 is null || vector3D_2 is null)
            {
                return false;
            }

            return vector3D_1?.values[0] == vector3D_2?.values[0] && vector3D_1?.values[1] == vector3D_2?.values[1] && vector3D_1?.values[2] == vector3D_2?.values[2];
        }

        //Calculate the dot product as an angle
        //Source: https://wiki.unity3d.com/index.php/3d_Math_functions
        /// <summary>
        /// Calculates the angle between this vector and another <see cref="Vector3D"/>.
        /// </summary>
        /// <param name="vector3D">The other <see cref="Vector3D"/> to calculate the angle with.</param>
        /// <returns>The angle in radians as a <see cref="double"/>, or <see cref="double.NaN"/> if the provided <see cref="Vector3D"/> is null.</returns>
        public double Angle(Vector3D? vector3D)
        {
            if (vector3D is null)
            {
                return double.NaN;
            }

            double dotProduct = DotProduct(vector3D);
            double length = Length * vector3D.Length;

            return (System.Math.Abs(dotProduct) < length) ? System.Math.Acos(dotProduct / length) : (dotProduct < 0) ? System.Math.PI : 0;
        }

        /// <summary>
        /// Creates a copy of the current <see cref="Vector3D"/> instance.
        /// </summary>
        /// <returns>A new <see cref="ISerializableObject"/> that is a clone of the current instance.</returns>
        public override ISerializableObject? Clone()
        {
            return new Vector3D(this);
        }

        /// <summary>
        /// Determines whether this vector is collinear with the specified <see cref="Vector3D"/> within a given tolerance.
        /// </summary>
        /// <param name="vector3D">The <see cref="Vector3D"/> to check for collinearity.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the maximum allowed difference to consider the vectors collinear.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the vectors are collinear; returns false if the provided <see cref="Vector3D"/> is null.</returns>
        public bool Collinear(Vector3D? vector3D, double tolerance = DiGi.Core.Constants.Tolerance.Angle)
        {
            if (vector3D == null)
            {
                return false;
            }

            return System.Math.Abs(System.Math.Abs(this * vector3D) - (Length * vector3D.Length)) <= tolerance;
        }

        /// <summary>
        /// Calculates the cross product of this vector and the specified <see cref="Vector3D"/>. The resulting vector is orthogonal to both original vectors.
        /// </summary>
        /// <param name="vector3D">The <see cref="Vector3D"/> to calculate the cross product with.</param>
        /// <returns>A new <see cref="Vector3D"/> representing the cross product, or <c>null</c> if either vector is null.</returns>
        public Vector3D? CrossProduct(Vector3D? vector3D)
        {
            if (vector3D == null || values == null)
            {
                return null;
            }

            return new Vector3D((values[1] * vector3D.values[2]) - (values[2] * vector3D.values[1]), (values[2] * vector3D.values[0]) - (values[0] * vector3D.values[2]), (values[0] * vector3D.values[1]) - (values[1] * vector3D.values[0]));
        }

        /// <summary>
        /// Calculates the dot product of this vector and the specified <see cref="Vector3D"/>.
        /// </summary>
        /// <param name="vector3D">The <see cref="Vector3D"/> to calculate the dot product with.</param>
        /// <returns>A <see cref="double"/> representing the dot product, or <see cref="double.NaN"/> if either vector is null.</returns>
        public double DotProduct(Vector3D? vector3D)
        {
            if (vector3D == null || values == null)
            {
                return double.NaN;
            }

            return (values[0] * vector3D.values[0]) + (values[1] * vector3D.values[1]) + (values[2] * vector3D.values[2]);
        }

        /// <summary>
        /// Returns a new <see cref="Vector3D"/> containing the absolute values of the current vector's components.
        /// </summary>
        /// <returns>A new <see cref="Vector3D"/> representing the absolute value of the current vector.</returns>
        public Vector3D GetAbs()
        {
            Vector3D result = new(this);

            result.Abs();

            return result;
        }

        /// <summary>
        /// Returns a new <see cref="Vector3D"/> instance that is the inverse of the current vector.
        /// </summary>
        /// <returns>A <see cref="Vector3D"/> representing the inversed vector.</returns>
        public Vector3D GetInversed()
        {
            Vector3D result = new(this);
            result.Inverse();

            return result;
        }

        /// <summary>
        /// Calculates the minimum angle between this vector and the specified <see cref="Vector3D"/>.
        /// </summary>
        /// <param name="vector3D">The <see cref="Vector3D"/> to calculate the angle against.</param>
        /// <returns>A <see cref="double"/> representing the smallest angular distance in radians.</returns>
        public double MinAngle(Vector3D? vector3D)
        {
            double value = System.Math.Abs(Angle(vector3D));
            if (value == 0)
            {
                return value;
            }

            return System.Math.Min(System.Math.PI - value, value);
        }

        /// <summary>
        /// Normalizes the vector to a unit length of 1.0.
        /// </summary>
        public void Normalize()
        {
            double length = Length;

            values[0] = values[0] / length;
            values[1] = values[1] / length;
            values[2] = values[2] / length;
        }

        /// <summary>
        /// Project input Vector onto this Vector
        /// </summary>
        /// <param name="vector3D">Vector to be projected</param>
        /// <returns>Projection vector</returns>
        public Vector3D? Project(Vector3D? vector3D)
        {
            if (vector3D == null)
            {
                return null;
            }

            Vector3D result = new(this);
            result.Scale(vector3D.DotProduct(this) / DotProduct(this));
            return result;
        }

        /// <summary>
        /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="Vector3D"/>.
        /// </summary>
        /// <param name="obj">The <see cref="object"/> to compare with the current <see cref="Vector3D"/>.</param>
        /// <returns><see langword="true"/> if the specified <see cref="object"/> is equal to the current <see cref="Vector3D"/>; otherwise, <see langword="false"/>.</returns>
        public override bool Equals(object? obj)
        {
            return obj is Vector3D d &&
                   base.Equals(obj) &&
                   EqualityComparer<double[]>.Default.Equals(values, d.values);
        }

        /// <summary>
        /// Returns a hash code for the current object.
        /// </summary>
        /// <returns>An <see cref="int"/> that is the hash code for the current object.</returns>
        public override int GetHashCode()
        {
            int hashCode = 1501109969;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<double[]>.Default.GetHashCode(values);
            return hashCode;
        }
    }
}
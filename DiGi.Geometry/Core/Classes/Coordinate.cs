using DiGi.Core.Classes;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Math.Classes;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Core.Classes
{
    /// <summary>
    /// Represents an abstract base class for a coordinate system that is serializable, geometric, and invertible.
    /// </summary>
    public abstract class Coordinate : SerializableObject, IGeometry, IInvertible
    {
        protected double[] values;

        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinate"/> class with the specified internal values array length.
        /// </summary>
        /// <param name="length">The length of the values array.</param>
        protected Coordinate(int length)
        {
            values = new double[length];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinate"/> class using a variable number of <see cref="double"/> values.
        /// </summary>
        /// <param name="values">An optional array of <see cref="double"/> values to initialize the coordinate.</param>
        public Coordinate(params double[]? values)
        {
            if (values != null && values.Length > 0)
            {
                int length = values.Length;
                this.values = new double[length];
                Array.Copy(values, this.values, length);
            }
            else
            {
                this.values = [];
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinate"/> class using a <see cref="JsonObject"/> and a specified length.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing coordinate data, or null if no data is provided.</param>
        /// <param name="length">The <see cref="int"/> specifying the number of elements for the internal values array.</param>
        public Coordinate(JsonObject? jsonObject, int length)
            : base()
        {
            values = new double[length];
            FromJsonObject(jsonObject);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinate"/> class using the values from an existing <see cref="Coordinate"/> instance.
        /// </summary>
        /// <param name="coordinate">The <see cref="Coordinate"/> instance to copy values from. This parameter can be null.</param>
        public Coordinate(Coordinate? coordinate)
        {
            double[]? values_Source = coordinate?.values;
            if (values_Source != null && values_Source.Length > 0)
            {
                int length = values_Source.Length;
                values = new double[length];
                Array.Copy(values_Source, values, length);
            }
            else
            {
                values = [];
            }
        }

        /// <summary>
        /// Gets the augmented matrix representation of the current values.
        /// </summary>
        /// <value>
        /// A <see cref="Matrix"/> object representing the augmented matrix, or <see langword="null"/> if the underlying values are null.
        /// </value>
        [JsonIgnore]
        public Matrix? ArgumentedMatrix
        {
            get
            {
                double[]? values_Local = values;
                if (values_Local == null)
                {
                    return null;
                }

                int length = values_Local.Length;
                if (length == 2)
                {
                    return new Matrix(new double[3, 1] { { values_Local[0] }, { values_Local[1] }, { 1 } });
                }

                if (length == 3)
                {
                    return new Matrix(new double[4, 1] { { values_Local[0] }, { values_Local[1] }, { values_Local[2] }, { 1 } });
                }

                double[,] values_Temp = new double[length + 1, 1];
                for (int i = 0; i < length; i++)
                {
                    values_Temp[i, 0] = values_Local[i];
                }

                values_Temp[length, 0] = 1;

                return new Matrix(values_Temp);
            }
        }

        /// <summary>
        /// Gets or sets the coordinate value at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the coordinate value to get or set.</param>
        /// <returns>The <see cref="double"/> value located at the specified index.</returns>
        [JsonIgnore]
        public double this[int index]
        {
            get
            {
                return values[index];
            }

            set
            {
                values[index] = value;
            }
        }

        /// <summary>
        /// Compares two <see cref="Coordinate"/> instances to determine if they are not equal based on their types and the values they contain.
        /// </summary>
        /// <param name="coordinate_1">The first coordinate to compare.</param>
        /// <param name="coordinate_2">The second coordinate to compare.</param>
        /// <returns><see langword="true"/> if the coordinates are not equal; otherwise, <see langword="false"/>.</returns>
        public static bool operator !=(Coordinate? coordinate_1, Coordinate? coordinate_2)
        {
            return !(coordinate_1 == coordinate_2);
        }

        /// <summary>
        /// Compares two <see cref="Coordinate"/> instances for equality based on their types and the values they contain.
        /// </summary>
        /// <param name="coordinate_1">The first coordinate to compare.</param>
        /// <param name="coordinate_2">The second coordinate to compare.</param>
        /// <returns><see langword="true"/> if the coordinates are equal; otherwise, <see langword="false"/>.</returns>
        public static bool operator ==(Coordinate? coordinate_1, Coordinate? coordinate_2)
        {
            if (ReferenceEquals(coordinate_1, coordinate_2))
            {
                return true;
            }

            if (coordinate_1 is null || coordinate_2 is null)
            {
                return false;
            }

            if (coordinate_1.GetType() != coordinate_2.GetType())
            {
                return false;
            }

            double[]? values_1 = coordinate_1.values;
            double[]? values_2 = coordinate_2.values;

            if (ReferenceEquals(values_1, values_2))
            {
                return true;
            }

            if (values_1 == null || values_2 == null)
            {
                return false;
            }

            int length = values_1.Length;
            if (length != values_2.Length)
            {
                return false;
            }

            if (length == 2)
            {
                return values_1[0] == values_2[0] && values_1[1] == values_2[1];
            }

            if (length == 3)
            {
                return values_1[0] == values_2[0] && values_1[1] == values_2[1] && values_1[2] == values_2[2];
            }

            for (int i = 0; i < length; i++)
            {
                if (values_1[i] != values_2[i])
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Computes the absolute value for each element in the values array.
        /// </summary>
        public void Abs()
        {
            double[]? values_Local = values;
            if (values_Local == null)
            {
                return;
            }

            int length = values_Local.Length;
            if (length == 2)
            {
                values_Local[0] = System.Math.Abs(values_Local[0]);
                values_Local[1] = System.Math.Abs(values_Local[1]);
                return;
            }

            if (length == 3)
            {
                values_Local[0] = System.Math.Abs(values_Local[0]);
                values_Local[1] = System.Math.Abs(values_Local[1]);
                values_Local[2] = System.Math.Abs(values_Local[2]);
                return;
            }

            for (int i = 0; i < length; i++)
            {
                values_Local[i] = System.Math.Abs(values_Local[i]);
            }
        }

        /// <summary>
        /// Determines whether the current instance is approximately equal to the specified <see cref="Coordinate"/>.
        /// </summary>
        /// <param name="coordinate">The <see cref="Coordinate"/> instance to compare with the current instance.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the maximum allowed difference for two coordinates to be considered equal.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the coordinates are almost equal based on the specified tolerance.</returns>
        public bool AlmostEquals(Coordinate? coordinate, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (ReferenceEquals(this, coordinate))
            {
                return true;
            }

            if (coordinate is null)
            {
                return false;
            }

            if (coordinate.GetType() != GetType())
            {
                return false;
            }

            double[]? values_Other = coordinate.values;
            double[]? values_Self = values;

            if (ReferenceEquals(values_Self, values_Other))
            {
                return true;
            }

            if (values_Self == null || values_Other == null)
            {
                return false;
            }

            int length = values_Self.Length;
            if (length != values_Other.Length)
            {
                return false;
            }

            if (length == 2)
            {
                return DiGi.Core.Query.AlmostEquals(values_Self[0], values_Other[0], tolerance) &&
                       DiGi.Core.Query.AlmostEquals(values_Self[1], values_Other[1], tolerance);
            }

            if (length == 3)
            {
                return DiGi.Core.Query.AlmostEquals(values_Self[0], values_Other[0], tolerance) &&
                       DiGi.Core.Query.AlmostEquals(values_Self[1], values_Other[1], tolerance) &&
                       DiGi.Core.Query.AlmostEquals(values_Self[2], values_Other[2], tolerance);
            }

            for (int i = 0; i < length; i++)
            {
                if (!DiGi.Core.Query.AlmostEquals(values_Self[i], values_Other[i], tolerance))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="Coordinate"/>.
        /// </summary>
        /// <param name="object">The <see cref="object"/> to compare with the current instance.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the specified object is equal to the current instance.</returns>
        public override bool Equals(object? @object)
        {
            if (GetType() != @object?.GetType())
            {
                return false;
            }

            return this == (Coordinate)@object;
        }

        /// <summary>
        /// Returns a hash code for the current object based on its internal values.
        /// </summary>
        /// <returns>An int representing the hash code of the current object.</returns>
        public override int GetHashCode()
        {
            double[]? values_Local = values;
            if (values_Local == null)
            {
                return -1;
            }

            int length = values_Local.Length;
            unchecked
            {
                if (length == 2)
                {
                    int result_2D = 19;
                    result_2D = result_2D * 31 + values_Local[0].GetHashCode();
                    result_2D = result_2D * 31 + values_Local[1].GetHashCode();
                    return result_2D;
                }

                if (length == 3)
                {
                    int result_3D = 19;
                    result_3D = result_3D * 31 + values_Local[0].GetHashCode();
                    result_3D = result_3D * 31 + values_Local[1].GetHashCode();
                    result_3D = result_3D * 31 + values_Local[2].GetHashCode();
                    return result_3D;
                }

                int result = 19;
                for (int i = 0; i < length; i++)
                {
                    result = result * 31 + values_Local[i].GetHashCode();
                }
                return result;
            }
        }

        /// <summary>
        /// Inverts the signs of all elements in the values array.
        /// </summary>
        /// <returns>A <see cref="bool"/> value indicating whether the inversion was successful.</returns>
        public bool Inverse()
        {
            double[]? values_Local = values;
            if (values_Local == null)
            {
                return false;
            }

            int length = values_Local.Length;
            if (length == 2)
            {
                values_Local[0] = -values_Local[0];
                values_Local[1] = -values_Local[1];
                return true;
            }

            if (length == 3)
            {
                values_Local[0] = -values_Local[0];
                values_Local[1] = -values_Local[1];
                values_Local[2] = -values_Local[2];
                return true;
            }

            for (int i = 0; i < length; i++)
            {
                values_Local[i] = -values_Local[i];
            }

            return true;
        }

        /// <summary>
        /// Rounds each value in the collection using the specified double tolerance.
        /// </summary>
        /// <param name="tolerance">The double value representing the precision used for rounding.</param>
        public void Round(double tolerance)
        {
            double[]? values_Local = values;
            if (values_Local == null)
            {
                return;
            }

            int length = values_Local.Length;
            if (length == 2)
            {
                values_Local[0] = DiGi.Core.Query.Round(values_Local[0], tolerance);
                values_Local[1] = DiGi.Core.Query.Round(values_Local[1], tolerance);
                return;
            }

            if (length == 3)
            {
                values_Local[0] = DiGi.Core.Query.Round(values_Local[0], tolerance);
                values_Local[1] = DiGi.Core.Query.Round(values_Local[1], tolerance);
                values_Local[2] = DiGi.Core.Query.Round(values_Local[2], tolerance);
                return;
            }

            for (int i = 0; i < length; i++)
            {
                values_Local[i] = DiGi.Core.Query.Round(values_Local[i], tolerance);
            }
        }

        /// <summary>
        /// Scales all elements of the values array by the specified multiplier.
        /// </summary>
        /// <param name="value">The <see cref="double"/> value to multiply each element by.</param>
        public void Scale(double value)
        {
            double[]? values_Local = values;
            if (double.IsNaN(value) || values_Local == null)
            {
                return;
            }

            int length = values_Local.Length;
            if (length == 2)
            {
                values_Local[0] *= value;
                values_Local[1] *= value;
                return;
            }

            if (length == 3)
            {
                values_Local[0] *= value;
                values_Local[1] *= value;
                values_Local[2] *= value;
                return;
            }

            for (int i = 0; i < length; i++)
            {
                values_Local[i] *= value;
            }
        }

        /// <summary>
        /// Returns a string representation of the current object, formatting the internal values as a semicolon-separated list enclosed in square brackets.
        /// </summary>
        /// <returns>A string containing the formatted values, or an empty string if the values are null.</returns>
        public override string ToString()
        {
            double[]? values_Local = values;
            if (values_Local == null)
            {
                return string.Empty;
            }

            return string.Format("[{0}]", string.Join(";", values_Local));
        }
    }
}

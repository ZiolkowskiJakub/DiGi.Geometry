using DiGi.Core.Classes;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Math.Classes;
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
        /// Initializes a new instance of the <see cref="Coordinate"/> class using a variable number of <see cref="double"/> values.
        /// </summary>
        /// <param name="values">An optional array of <see cref="double"/> values to initialize the coordinate.</param>
        public Coordinate(params double[]? values)
        {
            if (values != null)
            {
                this.values = new double[values.Length];
                for (int i = 0; i < values.Length; i++)
                {
                    this.values[i] = values[i];
                }
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
            : this(coordinate?.values)
        {
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
                if (values == null)
                {
                    return null;
                }

                int length = values.Length;

                double[,] values_Temp = new double[length + 1, 1];
                for (int i = 0; i < length; i++)
                {
                    values_Temp[i, 0] = values[i];
                }

                values_Temp[length, 0] = 1;

                return new Matrix(values_Temp);

                //return new Matrix(new double[,] { { coordinates[0] }, { coordinates[1] }, { coordinates[2] }, { 1 } });
            }
        }

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

        public static bool operator !=(Coordinate? coordinate_1, Coordinate? coordinate_2)
        {
            return !(coordinate_1 == coordinate_2);
        }

        public static bool operator ==(Coordinate? coordinate_1, Coordinate? coordinate_2)
        {
            if (coordinate_1?.GetType() != coordinate_2?.GetType())
            {
                return false;
            }

            double[]? values_1 = coordinate_1?.values;
            double[]? values_2 = coordinate_2?.values;

            if (values_1 == values_2)
            {
                return true;
            }

            if (values_1 == null || values_2 == null)
            {
                return false;
            }

            if (values_1.Length != values_2.Length)
            {
                return false;
            }

            for (int i = 0; i < values_1.Length; i++)
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
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = System.Math.Abs(values[i]);
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
            if (coordinate is null)
            {
                return false;
            }

            if (this == coordinate)
            {
                return true;
            }

            if (coordinate?.GetType() == GetType())
            {
                return false;
            }

            double[]? values = coordinate?.values;
            if (this.values == values)
            {
                return true;
            }

            if (values == null)
            {
                return false;
            }

            for (int i = 0; i < values.Length; i++)
            {
                if (DiGi.Core.Query.AlmostEquals(this.values[i], values[i], tolerance))
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
            unchecked
            {
                if (values == null)
                {
                    return -1;
                }

                int result = 19;
                for (int i = 0; i < values.Length; i++)
                {
                    result = result * 31 + values[i].GetHashCode();
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
            if (values == null)
            {
                return false;
            }

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = -values[i];
            }

            return true;
        }

        /// <summary>
        /// Rounds each value in the collection using the specified double tolerance.
        /// </summary>
        /// <param name="tolerance">The double value representing the precision used for rounding.</param>
        public void Round(double tolerance)
        {
            if (values == null)
            {
                return;
            }

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = DiGi.Core.Query.Round(values[i], tolerance);
            }
        }

        /// <summary>
        /// Scales all elements of the values array by the specified multiplier.
        /// </summary>
        /// <param name="value">The <see cref="double"/> value to multiply each element by.</param>
        public void Scale(double value)
        {
            if (double.IsNaN(value) || values == null)
            {
                return;
            }

            for (int i = 0; i < values.Length; i++)
            {
                values[i] *= value;
            }
        }

        /// <summary>
        /// Returns a string representation of the current object, formatting the internal values as a semicolon-separated list enclosed in square brackets.
        /// </summary>
        /// <returns>A string containing the formatted values, or an empty string if the values are null.</returns>
        public override string ToString()
        {
            if (values == null)
            {
                return string.Empty;
            }

            return string.Format("[{0}]", string.Join(";", values));
        }
    }
}

using DiGi.Geometry.Core.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Math.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents a three-dimensional coordinate in space.
    /// </summary>
    public abstract class Coordinate3D : Coordinate, IGeometry3D, ITransformable3D
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinate3D"/> class with the specified internal values array length.
        /// </summary>
        /// <param name="length">The length of the values array.</param>
        protected Coordinate3D(int length)
            : base(length)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinate3D"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the coordinate. This value can be null.</param>
        public Coordinate3D(JsonObject? jsonObject)
            : base(jsonObject, 3)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinate3D"/> class with specified X, Y, and Z coordinates.
        /// </summary>
        /// <param name="x">The X coordinate as a double value.</param>
        /// <param name="y">The Y coordinate as a double value.</param>
        /// <param name="z">The Z coordinate as a double value.</param>
        public Coordinate3D(double x, double y, double z)
            : base(3)
        {
            values[0] = x;
            values[1] = y;
            values[2] = z;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinate3D"/> class.
        /// </summary>
        public Coordinate3D()
            : base(3)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinate3D"/> class using an existing <see cref="Coordinate3D"/> object.
        /// </summary>
        /// <param name="coordinate3D">The <see cref="Coordinate3D"/> instance to copy values from.</param>
        public Coordinate3D(Coordinate3D? coordinate3D)
            : this(coordinate3D?.values)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinate3D"/> class using an array of <see cref="double"/> values.
        /// </summary>
        /// <param name="values">An optional array of double values. If the array is null or contains fewer than three elements, all coordinates are initialized to <see cref="double.NaN"/>.</param>
        public Coordinate3D(double[]? values)
            : base(3)
        {
            if (values == null || values.Length < 3)
            {
                this.values[0] = double.NaN;
                this.values[1] = double.NaN;
                this.values[2] = double.NaN;
            }
            else
            {
                this.values[0] = values[0];
                this.values[1] = values[1];
                this.values[2] = values[2];
            }
        }

        /// <summary>
        /// Gets or sets the X-coordinate value as a double.
        /// </summary>
        public double X
        {
            get
            {
                return values[0];
            }

            set
            {
                values[0] = value;
            }
        }

        /// <summary>
        /// Gets or sets the Y-coordinate value as a double.
        /// </summary>
        public double Y
        {
            get
            {
                return values[1];
            }

            set
            {
                values[1] = value;
            }
        }

        /// <summary>
        /// Gets or sets the Z-coordinate value as a double.
        /// </summary>
        public double Z
        {
            get
            {
                return values[2];
            }

            set
            {
                values[2] = value;
            }
        }

        /// <summary>
        /// Moves the object by adding the specified Vector3D offset to its current values.
        /// </summary>
        /// <param name="vector3D">The Vector3D? vector used for translation.</param>
        /// <returns>A bool value indicating whether the movement was successfully applied.</returns>
        public bool Move(Vector3D? vector3D)
        {
            if (vector3D == null || values == null || values.Length < 2)
            {
                return false;
            }

            values[0] += vector3D[0];
            values[1] += vector3D[1];
            values[2] += vector3D[2];
            return true;
        }

        /// <summary>
        /// Transforms the current values using the specified 3D transformation.
        /// </summary>
        /// <param name="transform">The <see cref="ITransform3D"/> object used to perform the transformation.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the transformation was successfully applied; otherwise, false.</returns>
        public virtual bool Transform(ITransform3D? transform)
        {
            if (transform == null || values == null || values.Length < 2)
            {
                return false;
            }

            if (transform is Transform3D transform3D)
            {
                Matrix4D? matrix4D = transform3D.Matrix4D;
                if (matrix4D == null)
                {
                    return false;
                }

                Matrix? matrix = matrix4D * ArgumentedMatrix;
                if (matrix == null)
                {
                    return false;
                }

                values[0] = matrix[0, 0];
                values[1] = matrix[1, 0];
                values[2] = matrix[2, 0];
                return true;
            }

            if (transform is TransformGroup3D transformGroup3D)
            {
                foreach (ITransform3D transform_Temp in transformGroup3D)
                {
                    if (transform_Temp == null)
                    {
                        continue;
                    }

                    Transform(transform_Temp);
                }

                return true;
            }

            return false;
        }
    }
}
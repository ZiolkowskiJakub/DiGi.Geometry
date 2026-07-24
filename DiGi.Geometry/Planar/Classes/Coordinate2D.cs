using DiGi.Geometry.Core.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Math.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Planar.Classes
{
    /// <summary>
    /// Base class for 2D coordinates providing basic transformation and movement functionality.
    /// </summary>
    public abstract class Coordinate2D : Coordinate, ICollectable2D, ITransformable2D
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinate2D"/> class with the specified internal values array length.
        /// </summary>
        /// <param name="length">The length of the values array.</param>
        protected Coordinate2D(int length)
            : base(length)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinate2D"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing coordinate data.</param>
        public Coordinate2D(JsonObject? jsonObject)
            : base(jsonObject, 2)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinate2D"/> class with specified X and Y coordinates.
        /// </summary>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        public Coordinate2D(double x, double y)
            : base(2)
        {
            values[0] = x;
            values[1] = y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinate2D"/> class from an array of values.
        /// </summary>
        /// <param name="values">The coordinate values.</param>
        public Coordinate2D(double[]? values)
            : base(2)
        {
            if (values == null || values.Length < 2)
            {
                this.values[0] = double.NaN;
                this.values[1] = double.NaN;
            }
            else
            {
                this.values[0] = values[0];
                this.values[1] = values[1];
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinate2D"/> class by cloning an existing coordinate.
        /// </summary>
        /// <param name="coordinate2D">The source coordinate to clone.</param>
        public Coordinate2D(Coordinate2D? coordinate2D)
            : this(coordinate2D?.values)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinate2D"/> class.
        /// </summary>
        public Coordinate2D()
            : base(2)
        {
        }

        /// <summary>
        /// Gets or sets the X coordinate.
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
        /// Gets or sets the Y coordinate.
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
        /// Transforms the coordinate using the specified transformation.
        /// </summary>
        /// <param name="transform">The transformation to apply.</param>
        /// <returns>True if the transformation was successful.</returns>
        public bool Transform(ITransform2D? transform)
        {
            if (transform == null || values == null || values.Length < 2)
            {
                return false;
            }

            if (transform is Transform2D transform2D)
            {
                double m00 = transform2D[0, 0];
                if (double.IsNaN(m00))
                {
                    return false;
                }

                double x = values[0];
                double y = values[1];

                values[0] = m00 * x + transform2D[0, 1] * y + transform2D[0, 2];
                values[1] = transform2D[1, 0] * x + transform2D[1, 1] * y + transform2D[1, 2];
                return true;
            }

            if (transform is TransformGroup2D transformGroup2D)
            {
                foreach (ITransform2D transform_Temp in transformGroup2D)
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

        /// <summary>
        /// Moves the coordinate by the specified vector.
        /// </summary>
        /// <param name="vector2D">The translation vector.</param>
        /// <returns>True if the move was successful.</returns>
        public bool Move(Vector2D? vector2D)
        {
            if (vector2D is null || values == null || values.Length < 2)
            {
                return false;
            }

            values[0] += vector2D[0];
            values[1] += vector2D[1];
            return true;
        }
    }
}
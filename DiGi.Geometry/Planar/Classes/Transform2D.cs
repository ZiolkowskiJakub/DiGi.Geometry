using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Math.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    /// <summary>
    /// Represents a two-dimensional transformation defined by a <see cref="Matrix3D"/>.
    /// </summary>
    public class Transform2D : SerializableObject, ITransform2D
    {
        [JsonInclude, JsonPropertyName("Matrix3D")]
        private readonly Matrix3D? matrix3D;

        /// <summary>
        /// Initializes a new instance of the <see cref="Transform2D"/> class using the specified <see cref="Matrix3D"/>.
        /// </summary>
        /// <param name="matrix3D">The <see cref="Matrix3D"/> to initialize the transform with.</param>
        public Transform2D(Matrix3D? matrix3D)
        {
            this.matrix3D = matrix3D == null ? null : new Matrix3D(matrix3D);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Transform2D"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the <see cref="Transform2D"/> instance.</param>
        public Transform2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Transform2D"/> class by copying the properties of an existing <see cref="Transform2D"/> object.
        /// </summary>
        /// <param name="transform2D">The source <see cref="Transform2D"/> object to copy from, or null.</param>
        public Transform2D(Transform2D? transform2D)
        {
            matrix3D = transform2D?.matrix3D == null ? null : new Matrix3D(transform2D.matrix3D);
        }

        /// <summary>
        /// Gets the 3D transformation matrix.
        /// </summary>
        /// <value>
        /// A <see cref="Matrix3D"/> object if a matrix is defined; otherwise, null.
        /// </value>
        [JsonIgnore]
        public Matrix3D? Matrix3D
        {
            get
            {
                return matrix3D == null ? null : new Matrix3D(matrix3D);
            }
        }

        [JsonIgnore]
        public double this[int row, int column]
        {
            get
            {
                if (matrix3D == null)
                {
                    return double.NaN;
                }

                return matrix3D[row, column];
            }
        }

        public static Transform2D? operator *(Transform2D? transform2D_1, Transform2D? transform2D_2)
        {
            if (transform2D_1 == null || transform2D_2 == null)
            {
                return null;
            }

            return new Transform2D(transform2D_1.matrix3D * transform2D_2.matrix3D);
        }

        /// <summary>
        /// Computes the inverse of the underlying 3D matrix.
        /// </summary>
        public void Inverse()
        {
            matrix3D?.Inverse();
        }

        /// <summary>
        /// Transposes the 3D matrix.
        /// </summary>
        public void Transpose()
        {
            matrix3D?.Transpose();
        }
    }
}

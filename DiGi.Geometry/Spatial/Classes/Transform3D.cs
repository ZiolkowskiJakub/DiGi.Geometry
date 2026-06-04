using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Math.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    /// <summary>
    /// Represents a 3D transformation.
    /// </summary>
    /// <summary>
    /// Initializes a new instance of the <see cref="Transform3D"/> class using the specified <see cref="Matrix4D"/>.
    /// </summary>
    /// <param name="matrix4D">The <see cref="Matrix4D"/> to use for the transformation.</param>
    /// <summary>
    /// Initializes a new instance of the <see cref="Transform3D"/> class from the specified <see cref="JsonObject"/>.
    /// </summary>
    /// <param name="jsonObject">The <see cref="JsonObject"/> containing transformation data.</param>
    /// <summary>
    /// Initializes a new instance of the <see cref="Transform3D"/> class by copying the specified <see cref="Transform3D"/> instance.
    /// </summary>
    /// <param name="transform3D">The <see cref="Transform3D"/> instance to copy.</param>
    public class Transform3D : SerializableObject, ITransform3D
    {
        [JsonInclude, JsonPropertyName("Matrix4D")]
        private readonly Matrix4D? matrix4D;

        /// <summary>
        /// Initializes a new instance of the <see cref="Transform3D"/> class using the specified <see cref="Matrix4D"/>.
        /// </summary>
        /// <param name="matrix4D">The <see cref="Matrix4D"/> to initialize the transform with.</param>
        public Transform3D(Matrix4D? matrix4D)
        {
            this.matrix4D = matrix4D;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Transform3D"/> class using the provided <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data used to initialize this instance.</param>
        public Transform3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Transform3D"/> class by copying another <see cref="Transform3D"/> instance.
        /// </summary>
        /// <param name="transform3D">The source <see cref="Transform3D"/> object to copy from.</param>
        public Transform3D(Transform3D? transform3D)
        {
            matrix4D = transform3D?.matrix4D == null ? null : new Matrix4D(transform3D.matrix4D);
        }

        /// <summary>
        /// Gets the 4x4 transformation matrix.
        /// </summary>
        /// <value>
        /// A <see cref="Matrix4D"/> instance, or <c>null</c> if the matrix is not defined.
        /// </value>
        [JsonIgnore]
        public Matrix4D? Matrix4D
        {
            get
            {
                return matrix4D == null ? null : new Matrix4D(matrix4D);
            }
        }

        [JsonIgnore]
        public double this[int row, int column]
        {
            get
            {
                if (matrix4D == null)
                {
                    return double.NaN;
                }

                return matrix4D[row, column];
            }

            set
            {
                if (matrix4D == null || row >= 4 || column >= 4)
                {
                    return;
                }

                matrix4D[row, column] = value;
            }
        }

        public static Transform3D? operator *(Transform3D? transform3D_1, Transform3D? transform3D_2)
        {
            if (transform3D_1 == null || transform3D_2 == null)
            {
                return null;
            }

            return new Transform3D(transform3D_1.matrix4D * transform3D_2.matrix4D);
        }

        /// <summary>
        /// Inverts the current matrix.
        /// </summary>
        public void Inverse()
        {
            matrix4D?.Inverse();
        }

        /// <summary>
        /// Transposes the internal 4D matrix.
        /// </summary>
        public void Transpose()
        {
            matrix4D?.Transpose();
        }
    }
}
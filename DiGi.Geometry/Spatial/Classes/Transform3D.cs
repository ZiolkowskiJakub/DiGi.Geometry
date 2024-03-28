using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Math.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    public class Transform3D : SerializableObject, ITransform3D
    {
        [JsonInclude, JsonPropertyName("Matrix4D")]
        private Matrix4D matrix4D;

        public Transform3D(Matrix4D matrix4D)
        {
            this.matrix4D = matrix4D;
        }

        public Transform3D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Transform3D(Transform3D transform3D)
        {
            matrix4D = transform3D?.matrix4D == null ? null : new Matrix4D(transform3D.matrix4D);
        }

        [JsonIgnore]
        public Matrix4D Matrix4D
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
        }

        public static Transform3D operator *(Transform3D transform3D_1, Transform3D transform3D_2)
        {
            if (transform3D_1 == null || transform3D_2 == null)
                return null;

            return new Transform3D(transform3D_1.matrix4D * transform3D_2.matrix4D);
        }

        public void Inverse()
        {
            matrix4D?.Inverse();
        }

        public void Transpose()
        {
            matrix4D?.Transpose();
        }
    }
}

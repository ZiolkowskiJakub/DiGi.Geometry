using DiGi.Core.Classes;
using DiGi.Math.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using DiGi.Geometry.Planar.Interfaces;

namespace DiGi.Geometry.Planar.Classes
{
    public class Transform2D : SerializableObject, ITransform2D
    {
        [JsonInclude, JsonPropertyName("Matrix3D")]
        private Matrix3D matrix3D;

        public Transform2D(Matrix3D matrix3D)
        {
            this.matrix3D = matrix3D == null ? null : new Matrix3D(matrix3D);
        }

        public Transform2D(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public Transform2D(Transform2D transform2D)
        {
            matrix3D = transform2D?.matrix3D == null ? null : new Matrix3D(transform2D.matrix3D);
        }

        [JsonIgnore]
        public Matrix3D Matrix3D
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

        public static Transform2D operator *(Transform2D transform2D_1, Transform2D transform2D_2)
        {
            if (transform2D_1 == null || transform2D_2 == null)
                return null;

            return new Transform2D(transform2D_1.matrix3D * transform2D_2.matrix3D);
        }

        public void Inverse()
        {
            matrix3D?.Inverse();
        }

        public void Transpose()
        {
            matrix3D?.Transpose();
        }
    }
}

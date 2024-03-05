﻿using DiGi.Geometry.Core.Interfaces;
using DiGi.Core.Classes;
using DiGi.Math.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Runtime.CompilerServices;

namespace DiGi.Geometry.Planar.Classes
{
    public class Transform2D : SerializableObject, ITransform
    {
        [JsonInclude, JsonPropertyName("Matrix3D")]
        private Matrix3D matrix3D;

        public Transform2D(Matrix3D matrix3D)
        {
            this.matrix3D = matrix3D;
        }

        public Transform2D(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public Transform2D(Transform2D transform2D)
        {
            matrix3D = new Matrix3D(transform2D.matrix3D);
        }

        [JsonIgnore]
        public Matrix3D Matrix3D
        {
            get
            {
                return new Matrix3D(matrix3D);
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

        public static Transform2D GetIdentity()
        {
            return new Transform2D(Matrix3D.GetIdentity());
        }

        public static Transform2D GetScale(double factor)
        {
            Transform2D result = GetIdentity();
            result.matrix3D[0, 0] = factor;
            result.matrix3D[1, 1] = factor;
            result.matrix3D[2, 2] = factor;

            return result;
        }

        public static Transform2D GetScale(double x, double y)
        {
            Transform2D result = GetIdentity();
            result.matrix3D[0, 0] = x;
            result.matrix3D[1, 1] = y;

            return result;
        }

        public static Transform2D GetTranslation(Vector2D vector2D)
        {
            Transform2D result = GetIdentity();
            result.matrix3D[0, 2] = vector2D[0];
            result.matrix3D[1, 2] = vector2D[1];

            return result;
        }

        public static Transform2D GetTranslation(double x, double y)
        {
            Transform2D result = GetIdentity();
            result.matrix3D[0, 2] = x;
            result.matrix3D[1, 2] = y;

            return result;
        }

        public static Transform2D GetRotation(double angle)
        {
            Transform2D result = GetIdentity();
            result.matrix3D[0, 0] = System.Math.Cos(angle);
            result.matrix3D[0, 1] = -System.Math.Sin(angle);
            result.matrix3D[1, 0] = System.Math.Sin(angle);
            result.matrix3D[1, 1] = System.Math.Cos(angle);

            return result;
        }

        public static Transform2D GetCoordinateSystem2DToOrigin(CoordinateSystem2D coordinateSystem2D)
        {
            if (coordinateSystem2D == null)
            {
                return null;
            }

            Point2D origin = coordinateSystem2D.Origin;
            Vector2D axisX = coordinateSystem2D.AxisX;
            Vector2D axisY = coordinateSystem2D.AxisY;

            Matrix3D matrix3D = Matrix3D.GetIdentity();
            matrix3D[0, 0] = Constans.Vector2D.WorldX.DotProduct(axisX);
            matrix3D[0, 1] = Constans.Vector2D.WorldX.DotProduct(axisY);
            matrix3D[0, 2] = origin.X;

            matrix3D[1, 0] = Constans.Vector2D.WorldY.DotProduct(axisX);
            matrix3D[1, 1] = Constans.Vector2D.WorldY.DotProduct(axisY);
            matrix3D[1, 2] = origin.Y;

            return new Transform2D(matrix3D);
        }

        public static Transform2D GetMirrorX()
        {
            Transform2D result = GetIdentity();
            result.matrix3D[1, 1] = -result.matrix3D[1, 1];

            return result;
        }

        public static Transform2D GetMirrorY()
        {
            Transform2D result = GetIdentity();
            result.matrix3D[0, 0] = -result.matrix3D[0, 0];

            return result;
        }

        public static Transform2D GetOriginToCoordinateSystem2D(CoordinateSystem2D coordinateSystem2D)
        {
            Transform2D result = GetCoordinateSystem2DToOrigin(coordinateSystem2D);
            result.Inverse();
            return result;
        }

        public static Transform2D GetCoordinateSystem2DToCoordinateSystem2D(CoordinateSystem2D coordinateSystem2D_From, CoordinateSystem2D coordinateSystem2D_To)
        {
            Transform2D transform2D_From = GetCoordinateSystem2DToOrigin(coordinateSystem2D_From);
            Transform2D transform2D_To = GetOriginToCoordinateSystem2D(coordinateSystem2D_To);

            return transform2D_To * transform2D_From;
        }

        public void Inverse()
        {
            matrix3D?.Inverse();
        }

        public void Transpose()
        {
            matrix3D?.Transpose();
        }

        public static Transform2D operator *(Transform2D transform2D_1, Transform2D transform2D_2)
        {
            if (transform2D_1 == null || transform2D_2 == null)
                return null;

            return new Transform2D(transform2D_1.matrix3D * transform2D_2.matrix3D);
        }
    }
}

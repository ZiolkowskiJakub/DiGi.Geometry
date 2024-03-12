using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Math.Classes;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        public static partial class Transform2D
        {
            public static Classes.Transform2D Identity()
            {
                return new Classes.Transform2D(Math.Create.Matrix3D.Identity());
            }

            public static Classes.Transform2D Scale(double factor)
            {
                Matrix3D matrix3D = Math.Create.Matrix3D.Identity();
                matrix3D[0, 0] = factor;
                matrix3D[1, 1] = factor;
                matrix3D[2, 2] = factor;

                return new Classes.Transform2D(matrix3D);
            }

            public static Classes.Transform2D Scale(double x, double y)
            {
                Matrix3D matrix3D = Math.Create.Matrix3D.Identity();
                matrix3D[0, 0] = x;
                matrix3D[1, 1] = y;

                return new Classes.Transform2D(matrix3D);
            }

            public static Classes.Transform2D Translation(Vector2D vector2D)
            {
                Matrix3D matrix3D = Math.Create.Matrix3D.Identity();
                matrix3D[0, 2] = vector2D[0];
                matrix3D[1, 2] = vector2D[1];

                return new Classes.Transform2D(matrix3D);
            }

            public static Classes.Transform2D Translation(double x, double y)
            {
                Matrix3D matrix3D = Math.Create.Matrix3D.Identity();
                matrix3D[0, 2] = x;
                matrix3D[1, 2] = y;

                return new Classes.Transform2D(matrix3D);
            }

            public static Classes.Transform2D Rotation(double angle)
            {
                Matrix3D matrix3D = Math.Create.Matrix3D.Identity();
                matrix3D[0, 0] = System.Math.Cos(angle);
                matrix3D[0, 1] = -System.Math.Sin(angle);
                matrix3D[1, 0] = System.Math.Sin(angle);
                matrix3D[1, 1] = System.Math.Cos(angle);

                return new Classes.Transform2D(matrix3D);
            }

            public static Classes.Transform2D Rotation(Point2D origin, double angle)
            {
                if(origin == null || double.IsNaN(angle))
                {
                    return null;
                }

                return Translation(origin.X, origin.Y) * Rotation(angle) * Translation(-origin.X, -origin.Y);
            }

            public static Classes.Transform2D CoordinateSystem2DToOrigin(CoordinateSystem2D coordinateSystem2D)
            {
                if (coordinateSystem2D == null)
                {
                    return null;
                }

                Point2D origin = coordinateSystem2D.Origin;
                Vector2D axisX = coordinateSystem2D.AxisX;
                Vector2D axisY = coordinateSystem2D.AxisY;

                Matrix3D matrix3D = Math.Create.Matrix3D.Identity();
                matrix3D[0, 0] = Constans.Vector2D.WorldX.DotProduct(axisX);
                matrix3D[0, 1] = Constans.Vector2D.WorldX.DotProduct(axisY);
                matrix3D[0, 2] = origin.X;

                matrix3D[1, 0] = Constans.Vector2D.WorldY.DotProduct(axisX);
                matrix3D[1, 1] = Constans.Vector2D.WorldY.DotProduct(axisY);
                matrix3D[1, 2] = origin.Y;

                return new Classes.Transform2D(matrix3D);
            }

            public static Classes.Transform2D MirrorX()
            {
                Matrix3D matrix3D = Math.Create.Matrix3D.Identity();
                matrix3D[1, 1] = -matrix3D[1, 1];

                return new Classes.Transform2D(matrix3D);
            }

            public static ITransform2D MirrorX(Point2D point2D)
            {
                if (point2D == null)
                {
                    return null;
                }

                if(point2D.Y == 0)
                {
                    return MirrorX();
                }

                CoordinateSystem2D coordinateSystem2D = new CoordinateSystem2D(point2D);

                return new TransformGroup2D(new Classes.Transform2D[] { OriginToCoordinateSystem2D(coordinateSystem2D), MirrorX(), CoordinateSystem2DToOrigin(coordinateSystem2D) });
            }

            public static Classes.Transform2D MirrorY()
            {
                Matrix3D matrix3D = Math.Create.Matrix3D.Identity();
                matrix3D[0, 0] = -matrix3D[0, 0];

                return new Classes.Transform2D(matrix3D);
            }

            public static ITransform2D MirrorY(Point2D point2D)
            {
                if (point2D == null)
                {
                    return null;
                }

                if (point2D.X == 0)
                {
                    return MirrorY();
                }

                CoordinateSystem2D coordinateSystem2D = new CoordinateSystem2D(point2D);

                return new TransformGroup2D(new Classes.Transform2D[] { OriginToCoordinateSystem2D(coordinateSystem2D), MirrorY(), CoordinateSystem2DToOrigin(coordinateSystem2D) });
            }

            public static Classes.Transform2D OriginToCoordinateSystem2D(CoordinateSystem2D coordinateSystem2D)
            {
                Classes.Transform2D result = CoordinateSystem2DToOrigin(coordinateSystem2D);
                result.Inverse();
                return result;
            }

            public static Classes.Transform2D CoordinateSystem2DToCoordinateSystem2D(CoordinateSystem2D coordinateSystem2D_From, CoordinateSystem2D coordinateSystem2D_To)
            {
                Classes.Transform2D transform2D_From = CoordinateSystem2DToOrigin(coordinateSystem2D_From);
                Classes.Transform2D transform2D_To = OriginToCoordinateSystem2D(coordinateSystem2D_To);

                return transform2D_To * transform2D_From;
            }
        }
    }

}

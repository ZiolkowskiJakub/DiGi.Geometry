using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Math.Classes;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        public static partial class Transform2D
        {
            /// <summary>
            /// Creates a transformation that converts points from one coordinate system to another.
            /// </summary>
            /// <param name="coordinateSystem2D_From">The source coordinate system.</param>
            /// <param name="coordinateSystem2D_To">The target coordinate system.</param>
            /// <returns>A transformation that maps the source system to the target system; otherwise, null.</returns>
            public static Classes.Transform2D? CoordinateSystem2DToCoordinateSystem2D(CoordinateSystem2D? coordinateSystem2D_From, CoordinateSystem2D? coordinateSystem2D_To)
            {
                Classes.Transform2D? transform2D_From = CoordinateSystem2DToOrigin(coordinateSystem2D_From);
                Classes.Transform2D? transform2D_To = OriginToCoordinateSystem2D(coordinateSystem2D_To);

                return transform2D_To * transform2D_From;
            }

            /// <summary>Creates a 2D transformation that maps coordinates from the specified coordinate system back to the origin.</summary>
            /// <param name="coordinateSystem2D">The source coordinate system to convert into a transformation.</param>
            /// <returns>A <see cref="Classes.Transform2D"/> object representing the transformation, or <c>null</c> if the provided coordinate system or its origin is null.</returns>
            public static Classes.Transform2D? CoordinateSystem2DToOrigin(CoordinateSystem2D? coordinateSystem2D)
            {
                if (coordinateSystem2D == null)
                {
                    return null;
                }

                Point2D? origin = coordinateSystem2D.Origin;
                if (origin is null)
                {
                    return null;
                }

                Vector2D? axisX = coordinateSystem2D.AxisX;
                Vector2D? axisY = coordinateSystem2D.AxisY;

                Matrix3D matrix3D = Math.Create.Matrix3D.Identity();
                matrix3D[0, 0] = Constants.Vector2D.WorldX.DotProduct(axisX);
                matrix3D[0, 1] = Constants.Vector2D.WorldX.DotProduct(axisY);
                matrix3D[0, 2] = origin.X;

                matrix3D[1, 0] = Constants.Vector2D.WorldY.DotProduct(axisX);
                matrix3D[1, 1] = Constants.Vector2D.WorldY.DotProduct(axisY);
                matrix3D[1, 2] = origin.Y;

                return new Classes.Transform2D(matrix3D);
            }

            /// <summary>Creates an identity 2D transformation that does not alter the coordinates of any point it is applied to.</summary>
            /// <returns>A <see cref="Classes.Transform2D"/> object representing the identity transformation.</returns>
            public static Classes.Transform2D Identity()
            {
                return new Classes.Transform2D(Math.Create.Matrix3D.Identity());
            }

            /// <summary>Creates a 2D transformation that mirrors across the horizontal axis (X-axis) passing through the origin.</summary>
            /// <returns>A <see cref="Classes.Transform2D"/> object representing the mirroring transformation.</returns>
            public static Classes.Transform2D MirrorX()
            {
                Matrix3D matrix3D = Math.Create.Matrix3D.Identity();
                matrix3D[1, 1] = -matrix3D[1, 1];

                return new Classes.Transform2D(matrix3D);
            }

            /// <summary>Creates a 2D transformation that mirrors across the horizontal axis (X-axis) passing through the specified point.</summary>
            /// <param name="point2D">The point that defines the position of the mirroring axis.</param>
            /// <returns>An <see cref="ITransform2D"/> object representing the mirroring transformation, or <see langword="null"/> if the provided point is null.</returns>
            public static ITransform2D? MirrorX(Point2D? point2D)
            {
                if (point2D == null)
                {
                    return null;
                }

                if (point2D.Y == 0)
                {
                    return MirrorX();
                }

                CoordinateSystem2D coordinateSystem2D = new(point2D);

                ITransform2D? transform2D_1 = OriginToCoordinateSystem2D(coordinateSystem2D);
                if (transform2D_1 is null)
                {
                    return null;
                }

                ITransform2D? transform2D_3 = CoordinateSystem2DToOrigin(coordinateSystem2D);
                if (transform2D_3 is null)
                {
                    return null;
                }

                ITransform2D transform2D_2 = MirrorX();

                return new TransformGroup2D([transform2D_1, transform2D_2, transform2D_3]);
            }

            /// <summary>Creates a 2D transformation that mirrors across the vertical axis (Y-axis) passing through the origin.</summary>
            /// <returns>A <see cref="Classes.Transform2D"/> object representing the mirroring transformation.</returns>
            public static Classes.Transform2D MirrorY()
            {
                Matrix3D matrix3D = Math.Create.Matrix3D.Identity();
                matrix3D[0, 0] = -matrix3D[0, 0];

                return new Classes.Transform2D(matrix3D);
            }

            /// <summary>Creates a 2D transformation that mirrors across the vertical axis passing through the specified point.</summary>
            /// <param name="point2D">The point defining the mirror axis. If null, the method returns null.</param>
            /// <returns>An <see cref="ITransform2D"/> object representing the mirroring transformation, or null if the provided point is null.</returns>
            public static ITransform2D? MirrorY(Point2D? point2D)
            {
                if (point2D == null)
                {
                    return null;
                }

                if (point2D.X == 0)
                {
                    return MirrorY();
                }

                CoordinateSystem2D coordinateSystem2D = new(point2D);

                ITransform2D? transform2D_3 = CoordinateSystem2DToOrigin(coordinateSystem2D);
                if (transform2D_3 is null)
                {
                    return null;
                }

                ITransform2D? transform2D_1 = OriginToCoordinateSystem2D(coordinateSystem2D);
                if (transform2D_1 is null)
                {
                    return null;
                }

                ITransform2D transform2D_2 = MirrorY();

                return new TransformGroup2D([transform2D_1, transform2D_2, transform2D_3]);
            }

            /// <summary>Creates a 2D transformation that maps the origin to the specified coordinate system.</summary>
            /// <param name="coordinateSystem2D">The target coordinate system. If null, the method returns null.</param>
            /// <returns>A <see cref="Classes.Transform2D"/> object representing the transformation from the origin to the coordinate system, or null if the provided coordinate system is null.</returns>
            public static Classes.Transform2D? OriginToCoordinateSystem2D(CoordinateSystem2D? coordinateSystem2D)
            {
                Classes.Transform2D? result = CoordinateSystem2DToOrigin(coordinateSystem2D);
                result?.Inverse();
                return result;
            }

            /// <summary>Creates a 2D rotation transformation around the origin by the specified angle.</summary>
            /// <param name="angle">The angle of rotation.</param>
            /// <returns>A <see cref="Classes.Transform2D"/> object representing the rotation transformation.</returns>
            public static Classes.Transform2D Rotation(double angle)
            {
                Matrix3D matrix3D = Math.Create.Matrix3D.Identity();
                matrix3D[0, 0] = System.Math.Cos(angle);
                matrix3D[0, 1] = -System.Math.Sin(angle);
                matrix3D[1, 0] = System.Math.Sin(angle);
                matrix3D[1, 1] = System.Math.Cos(angle);

                return new Classes.Transform2D(matrix3D);
            }

            /// <summary>Creates a 2D rotation transformation around a specified origin point by the given angle.</summary>
            /// <param name="origin">The center point of the rotation. If null, the method returns null.</param>
            /// <param name="angle">The angle of rotation. If NaN, the method returns null.</param>
            /// <returns>A <see cref="Classes.Transform2D"/> object representing the rotation transformation, or null if the origin is null or the angle is NaN.</returns>
            public static Classes.Transform2D? Rotation(Point2D? origin, double angle)
            {
                if (origin == null || double.IsNaN(angle))
                {
                    return null;
                }

                return Translation(origin.X, origin.Y) * Rotation(angle) * Translation(-origin.X, -origin.Y);
            }

            /// <summary>Creates a 2D transformation that scales coordinates uniformly by the specified factor.</summary>
            /// <param name="factor">The scale factor to apply to both the X and Y axes.</param>
            /// <returns>A <see cref="Classes.Transform2D"/> object representing the uniform scaling transformation.</returns>
            public static Classes.Transform2D Scale(double factor)
            {
                Matrix3D matrix3D = Math.Create.Matrix3D.Identity();
                matrix3D[0, 0] = factor;
                matrix3D[1, 1] = factor;
                matrix3D[2, 2] = factor;

                return new Classes.Transform2D(matrix3D);
            }

            /// <summary>Creates a 2D transformation that scales coordinates by the specified factors along the X and Y axes.</summary>
            /// <param name="x">The scale factor for the X-axis.</param>
            /// <param name="y">The scale factor for the Y-axis.</param>
            /// <returns>A <see cref="Classes.Transform2D"/> object representing the scaling transformation.</returns>
            public static Classes.Transform2D Scale(double x, double y)
            {
                Matrix3D matrix3D = Math.Create.Matrix3D.Identity();
                matrix3D[0, 0] = x;
                matrix3D[1, 1] = y;

                return new Classes.Transform2D(matrix3D);
            }

            /// <summary>Creates a 2D transformation that translates coordinates by the specified vector.</summary>
            /// <param name="vector2D">The translation vector containing the X and Y offsets.</param>
            /// <returns>A <see cref="Classes.Transform2D"/> object representing the translation transformation.</returns>
            public static Classes.Transform2D Translation(Vector2D vector2D)
            {
                Matrix3D matrix3D = Math.Create.Matrix3D.Identity();
                matrix3D[0, 2] = vector2D[0];
                matrix3D[1, 2] = vector2D[1];

                return new Classes.Transform2D(matrix3D);
            }

            /// <summary>Creates a 2D transformation that translates coordinates by the specified x and y offsets.</summary>
            /// <param name="x">The translation distance along the X-axis.</param>
            /// <param name="y">The translation distance along the Y-axis.</param>
            /// <returns>A <see cref="Classes.Transform2D"/> object representing the translation transformation.</returns>
            public static Classes.Transform2D Translation(double x, double y)
            {
                Matrix3D matrix3D = Math.Create.Matrix3D.Identity();
                matrix3D[0, 2] = x;
                matrix3D[1, 2] = y;

                return new Classes.Transform2D(matrix3D);
            }
        }
    }
}
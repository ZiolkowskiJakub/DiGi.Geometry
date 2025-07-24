using DiGi.Geometry.Spatial.Classes;
using DiGi.Math.Classes;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        public static partial class Transform3D
        {
            public static Classes.Transform3D CoordinateSystem3DToCoordinateSystem3D(CoordinateSystem3D coordinateSystem3D_From, CoordinateSystem3D coordinateSystem3D_To)
            {
                Classes.Transform3D transform3D_From = CoordinateSystem3DToOrigin(coordinateSystem3D_From);
                Classes.Transform3D transform3D_To = OriginToCoordinateSystem3D(coordinateSystem3D_To);

                return transform3D_To * transform3D_From;
            }

            public static Classes.Transform3D CoordinateSystem3DToOrigin(CoordinateSystem3D coordinateSystem3D)
            {
                if (coordinateSystem3D == null)
                {
                    return null;
                }

                return PlaneToOrigin(coordinateSystem3D.Origin, coordinateSystem3D.AxisX, coordinateSystem3D.AxisY, coordinateSystem3D.AxisZ);
            }

            public static Classes.Transform3D Identity()
            {
                return new Classes.Transform3D(Math.Create.Matrix4D.Identity());
            }

            public static Classes.Transform3D MirrorXY()
            {
                Classes.Transform3D result = Identity();
                result[2, 2] = -result[2, 2];

                return result;
            }

            public static Classes.Transform3D MirrorXZ()
            {
                Classes.Transform3D result = Identity();
                result[1, 1] = -result[1, 1];

                return result;
            }

            public static Classes.Transform3D MirrorYZ()
            {
                Classes.Transform3D result = Identity();
                result[0, 0] = -result[0, 0];

                return result;
            }

            public static Classes.Transform3D OriginToCoordinateSystem3D(CoordinateSystem3D coordinateSystem3D)
            {
                Classes.Transform3D result = CoordinateSystem3DToOrigin(coordinateSystem3D);
                result.Inverse();
                return result;
            }

            public static Classes.Transform3D OriginToPlane(Plane plane)
            {
                Classes.Transform3D result = PlaneToOrigin(plane);
                result.Inverse();
                return result;
            }

            public static Classes.Transform3D OriginTranslation(Point3D point3D)
            {
                Classes.Transform3D result = Identity();
                result[0, 3] = point3D[0];
                result[1, 3] = point3D[1];
                result[2, 3] = point3D[2];

                return result;
            }

            public static Classes.Transform3D PlaneToOrigin(Point3D origin, Vector3D axisX, Vector3D axisY, Vector3D axisZ)
            {
                if (origin == null || axisX == null || axisY == null || axisZ == null)
                {
                    return null;
                }

                Matrix4D matrix4D = Math.Create.Matrix4D.Identity();
                matrix4D[0, 0] = Constans.Vector3D.WorldX.DotProduct(axisX);
                matrix4D[0, 1] = Constans.Vector3D.WorldX.DotProduct(axisY);
                matrix4D[0, 2] = Constans.Vector3D.WorldX.DotProduct(axisZ);
                matrix4D[0, 3] = origin.X;

                matrix4D[1, 0] = Constans.Vector3D.WorldY.DotProduct(axisX);
                matrix4D[1, 1] = Constans.Vector3D.WorldY.DotProduct(axisY);
                matrix4D[1, 2] = Constans.Vector3D.WorldY.DotProduct(axisZ);
                matrix4D[1, 3] = origin.Y;

                matrix4D[2, 0] = Constans.Vector3D.WorldZ.DotProduct(axisX);
                matrix4D[2, 1] = Constans.Vector3D.WorldZ.DotProduct(axisY);
                matrix4D[2, 2] = Constans.Vector3D.WorldZ.DotProduct(axisZ);
                matrix4D[2, 3] = origin.Z;

                return new Classes.Transform3D(matrix4D);

            }

            public static Classes.Transform3D PlaneToOrigin(Plane plane)
            {
                if (plane == null)
                {
                    return null;
                }

                return PlaneToOrigin(plane.Origin, plane.AxisX, plane.AxisY, plane.AxisZ);
            }

            public static Classes.Transform3D PlaneToPlane(Plane plane_From, Plane plane_To)
            {
                Classes.Transform3D transform3D_From = OriginToPlane(plane_From);
                Classes.Transform3D transform3D_To = PlaneToOrigin(plane_To);

                return transform3D_To * transform3D_From;
            }

            public static Classes.Transform3D ProjectionXY()
            {
                Classes.Transform3D result = Identity();
                result[2, 2] = 0;

                return result;
            }

            public static Classes.Transform3D ProjectionXZ()
            {
                Classes.Transform3D result = Identity();
                result[1, 1] = 0;

                return result;
            }

            public static Classes.Transform3D ProjectionYZ()
            {
                Classes.Transform3D result = Identity();
                result[0, 0] = 0;

                return result;
            }

            /// <summary>
            /// Rotation Transform3D around the axis. Method to be revised
            /// </summary>
            /// <param name="axis">rotation axis Vector3D</param>
            /// <param name="angle">Angle in radians</param>
            /// <returns>Transform3D</returns>
            public static Classes.Transform3D Rotation(Vector3D axis, double angle)
            {
                //TODO: Revise this method

                if (axis == null)
                {
                    return null;
                }

                Classes.Transform3D result = Identity();

                Vector3D axis_Unit = axis.Unit;

                result[0, 0] = System.Math.Cos(angle) + System.Math.Pow(axis_Unit.X, 2) * (1 - System.Math.Cos(angle));
                result[1, 0] = axis_Unit.X * axis_Unit.Y * (1 - System.Math.Cos(angle)) - axis_Unit.Z * System.Math.Sin(angle);
                result[2, 0] = axis_Unit.X * axis_Unit.Z * (1 - System.Math.Cos(angle)) - axis_Unit.Y * System.Math.Sin(angle);

                result[0, 1] = axis_Unit.X * axis_Unit.Y * (1 - System.Math.Cos(angle)) + axis_Unit.Z * System.Math.Sin(angle);
                result[1, 1] = System.Math.Cos(angle) + System.Math.Pow(axis_Unit.Y, 2) * (1 - System.Math.Cos(angle));
                result[2, 1] = axis_Unit.Y * axis_Unit.Z * (1 - System.Math.Cos(angle)) - axis_Unit.X * System.Math.Sin(angle);

                result[0, 2] = axis_Unit.X * axis_Unit.Z * (1 - System.Math.Cos(angle)) - axis_Unit.Y * System.Math.Sin(angle);
                result[1, 2] = axis_Unit.Y * axis_Unit.Z * (1 - System.Math.Cos(angle)) + axis_Unit.X * System.Math.Sin(angle);
                result[2, 2] = System.Math.Cos(angle) + System.Math.Pow(axis_Unit.Z, 2) * (1 - System.Math.Cos(angle));

                return result;
            }

            /// <summary>
            /// Rotation Transform around given axis and origin by angle. Method to be revised
            /// </summary>
            /// <param name="origin">Origin Point</param>
            /// <param name="axis">Axis</param>
            /// <param name="angle">Angle</param>
            /// <returns></returns>
            public static Classes.Transform3D Rotation(Point3D origin, Vector3D axis, double angle)
            {
                //TODO: Revise this method

                if (origin == null)
                    return null;

                Classes.Transform3D transform3D_Translation_1 = Translation(origin.X, origin.Y, origin.Z);
                Classes.Transform3D transform3D_Rotation = Rotation(axis, angle);
                Classes.Transform3D transform3D_Translation_2 = Translation(-origin.X, -origin.Y, -origin.Z);

                return transform3D_Translation_1 * transform3D_Rotation * transform3D_Translation_2;
            }

            /// <summary>
            /// Gets Rotation Transform3D around the x-axis
            /// </summary>
            /// <param name="angle">Angle in radians</param>
            /// <returns>Transform3D</returns>
            public static Classes.Transform3D RotationX(double angle)
            {
                Classes.Transform3D result = Identity();
                result[1, 1] = System.Math.Cos(angle);
                result[1, 2] = -System.Math.Sin(angle);
                result[2, 1] = System.Math.Sin(angle);
                result[2, 2] = System.Math.Cos(angle);

                return result;
            }

            /// <summary>
            /// Gets Rotation Transform3D around the y-axis
            /// </summary>
            /// <param name="angle">Angle in radians</param>
            /// <returns>Transform3D</returns>
            public static Classes.Transform3D RotationY(double angle)
            {
                Classes.Transform3D result = Identity();
                result[0, 0] = System.Math.Cos(angle);
                result[0, 2] = System.Math.Sin(angle);
                result[2, 0] = -System.Math.Sin(angle);
                result[2, 2] = System.Math.Cos(angle);

                return result;
            }

            /// <summary>
            /// Gets Rotation Transform3D around the z-axis
            /// </summary>
            /// <param name="angle">Angle in radians</param>
            /// <returns>Transform3D</returns>
            public static Classes.Transform3D RotationZ(double angle)
            {
                Classes.Transform3D result = Identity();
                result[0, 0] = System.Math.Cos(angle);
                result[0, 1] = -System.Math.Sin(angle);
                result[1, 0] = System.Math.Sin(angle);
                result[1, 1] = System.Math.Cos(angle);

                return result;
            }

            public static Classes.Transform3D Scale(double factor)
            {
                Classes.Transform3D result = Identity();
                result[0, 0] = factor;
                result[1, 1] = factor;
                result[2, 2] = factor;

                return result;
            }

            public static Classes.Transform3D Scale(double x, double y, double z)
            {
                Classes.Transform3D result = Identity();
                result[0, 0] = x;
                result[1, 1] = y;
                result[2, 2] = z;

                return result;
            }

            public static Classes.Transform3D Scale(Point3D origin, double factor)
            {
                Classes.Transform3D transform3D_Translation_1 = Translation(origin.X, origin.Y, origin.Z);
                Classes.Transform3D transform3D_Scale = Scale(factor);
                Classes.Transform3D transform3D_Translation_2 = Translation(-origin.X, -origin.Y, -origin.Z);

                return transform3D_Translation_1 * transform3D_Scale * transform3D_Translation_2;
            }

            public static Classes.Transform3D Translation(Vector3D vector3D)
            {
                Classes.Transform3D result = Identity();
                result[0, 3] = vector3D[0];
                result[1, 3] = vector3D[1];
                result[2, 3] = vector3D[2];

                return result;
            }

            public static Classes.Transform3D Translation(double x, double y, double z)
            {
                Classes.Transform3D result = Identity();
                result[0, 3] = x;
                result[1, 3] = y;
                result[2, 3] = z;

                return result;
            }

            public static Classes.Transform3D Unset()
            {
                return new Classes.Transform3D(Math.Create.Matrix4D.Unset());
            }

            /// <summary>
            /// Zero Transform3D Diagonal = (0,0,0,1)
            /// </summary>
            /// <returns>Transform3D</returns>
            public static Classes.Transform3D Zero()
            {
                Math.Classes.Matrix4D matrix4D = new Math.Classes.Matrix4D();
                matrix4D[3, 3] = 1;
                return new Classes.Transform3D(matrix4D);
            }
        }


    }
}

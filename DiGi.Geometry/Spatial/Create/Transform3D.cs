using DiGi.Geometry.Spatial.Classes;
using DiGi.Math.Classes;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        public static partial class Transform3D
        {
            /// <summary>
            /// Calculates the transformation from one 3D coordinate system to another 3D coordinate system.
            /// </summary>
            /// <param name="coordinateSystem3D_From">The source <see cref="CoordinateSystem3D"/> coordinate system.</param>
            /// <param name="coordinateSystem3D_To">The destination <see cref="CoordinateSystem3D"/> coordinate system.</param>
            /// <returns>A <see cref="Classes.Transform3D"/> representing the transformation from the source to the destination, or null if either input is null.</returns>
            public static Classes.Transform3D? CoordinateSystem3DToCoordinateSystem3D(CoordinateSystem3D? coordinateSystem3D_From, CoordinateSystem3D? coordinateSystem3D_To)
            {
                Classes.Transform3D? transform3D_From = CoordinateSystem3DToOrigin(coordinateSystem3D_From);
                if (transform3D_From == null)
                {
                    return null;
                }

                Classes.Transform3D? transform3D_To = OriginToCoordinateSystem3D(coordinateSystem3D_To);
                if (transform3D_To == null)
                {
                    return null;
                }

                return transform3D_To * transform3D_From;
            }

            /// <summary>
            /// Converts a <see cref="CoordinateSystem3D"/> to a <see cref="Classes.Transform3D"/> that transforms the coordinate system to the origin.
            /// </summary>
            /// <param name="coordinateSystem3D">The <see cref="CoordinateSystem3D"/> to convert. This value can be null.</param>
            /// <returns>A <see cref="Classes.Transform3D"/> representing the transformation to the origin, or null if the provided <see cref="CoordinateSystem3D"/> is null.</returns>
            public static Classes.Transform3D? CoordinateSystem3DToOrigin(CoordinateSystem3D? coordinateSystem3D)
            {
                if (coordinateSystem3D == null)
                {
                    return null;
                }

                return PlaneToOrigin(coordinateSystem3D.Origin, coordinateSystem3D.AxisX, coordinateSystem3D.AxisY, coordinateSystem3D.AxisZ);
            }

            /// <summary>
            /// Creates a new <see cref="Classes.Transform3D"/> representing the identity transformation.
            /// </summary>
            /// <returns>A <see cref="Classes.Transform3D"/> instance initialized with an identity matrix.</returns>
            public static Classes.Transform3D Identity()
            {
                return new Classes.Transform3D(Math.Create.Matrix4D.Identity());
            }

            /// <summary>
            /// Creates a transformation matrix that mirrors coordinates across the XY plane.
            /// </summary>
            /// <returns>A <see cref="Classes.Transform3D"/> representing the mirroring transformation.</returns>
            public static Classes.Transform3D MirrorXY()
            {
                Classes.Transform3D result = Identity();
                result[2, 2] = -result[2, 2];

                return result;
            }

            /// <summary>
            /// Creates a <see cref="Classes.Transform3D"/> that mirrors coordinates across the XZ plane.
            /// </summary>
            /// <returns>A <see cref="Classes.Transform3D"/> representing the mirroring transformation.</returns>
            public static Classes.Transform3D MirrorXZ()
            {
                Classes.Transform3D? result = Identity();
                result[1, 1] = -result[1, 1];

                return result;
            }

            /// <summary>
            /// Creates a <see cref="Classes.Transform3D"/> that mirrors coordinates across the YZ plane.
            /// </summary>
            /// <returns>A <see cref="Classes.Transform3D"/> representing the mirroring transformation.</returns>
            public static Classes.Transform3D MirrorYZ()
            {
                Classes.Transform3D? result = Identity();
                result[0, 0] = -result[0, 0];

                return result;
            }

            /// <summary>
            /// Creates a <see cref="Classes.Transform3D"/> that represents the transformation from the origin to the specified <see cref="CoordinateSystem3D"/>.
            /// </summary>
            /// <param name="coordinateSystem3D">The <see cref="CoordinateSystem3D"/> to transform to.</param>
            /// <returns>A <see cref="Classes.Transform3D"/> representing the transformation from the origin to the coordinate system, or null if the provided <see cref="CoordinateSystem3D"/> is null.</returns>
            public static Classes.Transform3D? OriginToCoordinateSystem3D(CoordinateSystem3D? coordinateSystem3D)
            {
                Classes.Transform3D? result = CoordinateSystem3DToOrigin(coordinateSystem3D);
                result?.Inverse();
                return result;
            }

            /// <summary>
            /// Calculates the transformation from the origin to the specified <see cref="Classes.Plane"/>.
            /// </summary>
            /// <param name="plane">The <see cref="Classes.Plane"/> to which the origin is transformed.</param>
            /// <returns>A <see cref="Classes.Transform3D"/> representing the transformation, or null if the provided <see cref="Classes.Plane"/> is null.</returns>
            public static Classes.Transform3D? OriginToPlane(Plane? plane)
            {
                Classes.Transform3D? result = PlaneToOrigin(plane);
                result?.Inverse();
                return result;
            }

            /// <summary>
            /// Creates a transformation matrix that translates the origin to the specified <see cref="Point3D"/>.
            /// </summary>
            /// <param name="point3D">The <see cref="Point3D"/> specifying the translation coordinates.</param>
            /// <returns>A <see cref="Classes.Transform3D"/> representing the translation, or null if the provided <see cref="Point3D"/> is null.</returns>
            public static Classes.Transform3D? OriginTranslation(Point3D? point3D)
            {
                if (point3D is null)
                {
                    return null;
                }

                Classes.Transform3D result = Identity();
                result[0, 3] = point3D[0];
                result[1, 3] = point3D[1];
                result[2, 3] = point3D[2];

                return result;
            }

            /// <summary>
            /// Creates a transformation that maps a plane defined by an origin and three axes to the coordinate system's origin.
            /// </summary>
            /// <param name="origin">The <see cref="Point3D"/> representing the origin of the plane.</param>
            /// <param name="axisX">The <see cref="Vector3D"/> representing the X-axis of the plane.</param>
            /// <param name="axisY">The <see cref="Vector3D"/> representing the Y-axis of the plane.</param>
            /// <param name="axisZ">The <see cref="Vector3D"/> representing the Z-axis of the plane.</param>
            /// <returns>A <see cref="Classes.Transform3D"/> object if all parameters are provided; otherwise, <c>null</c>.</returns>
            public static Classes.Transform3D? PlaneToOrigin(Point3D? origin, Vector3D? axisX, Vector3D? axisY, Vector3D? axisZ)
            {
                if (origin == null || axisX == null || axisY == null || axisZ == null)
                {
                    return null;
                }

                Matrix4D? matrix4D = Math.Create.Matrix4D.Identity();
                matrix4D[0, 0] = Constants.Vector3D.WorldX.DotProduct(axisX);
                matrix4D[0, 1] = Constants.Vector3D.WorldX.DotProduct(axisY);
                matrix4D[0, 2] = Constants.Vector3D.WorldX.DotProduct(axisZ);
                matrix4D[0, 3] = origin.X;

                matrix4D[1, 0] = Constants.Vector3D.WorldY.DotProduct(axisX);
                matrix4D[1, 1] = Constants.Vector3D.WorldY.DotProduct(axisY);
                matrix4D[1, 2] = Constants.Vector3D.WorldY.DotProduct(axisZ);
                matrix4D[1, 3] = origin.Y;

                matrix4D[2, 0] = Constants.Vector3D.WorldZ.DotProduct(axisX);
                matrix4D[2, 1] = Constants.Vector3D.WorldZ.DotProduct(axisY);
                matrix4D[2, 2] = Constants.Vector3D.WorldZ.DotProduct(axisZ);
                matrix4D[2, 3] = origin.Z;

                return new Classes.Transform3D(matrix4D);
            }

            /// <summary>
            /// Calculates the <see cref="Classes.Transform3D"/> required to transform a specified <see cref="Classes.Plane"/> to the origin.
            /// </summary>
/// <param name="plane">The <see cref="Classes.Plane"/> to be transformed to the origin.</param>
/// <returns>A <see cref="Classes.Transform3D"/> representing the transformation from the plane to the origin, or <see langword="null"/> if the provided <see cref="Classes.Plane"/> is <see langword="null"/>.</returns>
            public static Classes.Transform3D? PlaneToOrigin(Plane? plane)
            {
                if (plane == null)
                {
                    return null;
                }

                return PlaneToOrigin(plane.Origin, plane.AxisX, plane.AxisY, plane.AxisZ);
            }

            /// <summary>
            /// Calculates a <see cref="Classes.Transform3D"/> that transforms coordinates from one <see cref="Classes.Plane"/> to another.
            /// </summary>
            /// <param name="plane_From">The source <see cref="Classes.Plane"/>.</param>
            /// <param name="plane_To">The destination <see cref="Classes.Plane"/>.</param>
            /// <returns>A <see cref="Classes.Transform3D"/> representing the transformation from the source plane to the destination plane, or null if either input plane is null.</returns>
            public static Classes.Transform3D? PlaneToPlane(Plane? plane_From, Plane? plane_To)
            {
                Classes.Transform3D? transform3D_From = OriginToPlane(plane_From);
                if (transform3D_From is null)
                {
                    return null;
                }

                Classes.Transform3D? transform3D_To = PlaneToOrigin(plane_To);
                if (transform3D_To is null)
                {
                    return null;
                }

                return transform3D_To * transform3D_From;
            }

            /// <summary>
            /// Creates a transformation matrix that projects coordinates onto the XY plane by setting the Z component to zero.
            /// </summary>
            /// <returns>A <see cref="Classes.Transform3D"/> representing the projection onto the XY plane.</returns>
            public static Classes.Transform3D ProjectionXY()
            {
                Classes.Transform3D result = Identity();
                result[2, 2] = 0;

                return result;
            }

            /// <summary>
            /// Creates a transformation matrix that projects coordinates onto the XZ plane.
            /// </summary>
            /// <returns>A <see cref="Classes.Transform3D"/> representing the projection onto the XZ plane.</returns>
            public static Classes.Transform3D ProjectionXZ()
            {
                Classes.Transform3D result = Identity();
                result[1, 1] = 0;

                return result;
            }

            /// <summary>
            /// Creates a transformation matrix that projects points onto the YZ plane by removing the X component.
            /// </summary>
            /// <returns>A <see cref="Classes.Transform3D"/> representing the projection onto the YZ plane.</returns>
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
            public static Classes.Transform3D? Rotation(Vector3D? axis, double angle)
            {
                //TODO: Revise this method

                Vector3D? axis_Unit = axis?.Unit;
                if (axis_Unit is null)
                {
                    return null;
                }

                Classes.Transform3D result = Identity();

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
            public static Classes.Transform3D? Rotation(Point3D? origin, Vector3D? axis, double angle)
            {
                //TODO: Revise this method

                if (origin == null)
                {
                    return null;
                }

                Classes.Transform3D? transform3D_Translation_1 = Translation(origin.X, origin.Y, origin.Z);
                if (transform3D_Translation_1 is null)
                {
                    return null;
                }

                Classes.Transform3D? transform3D_Rotation = Rotation(axis, angle);
                if (transform3D_Rotation is null)
                {
                    return null;
                }

                Classes.Transform3D? transform3D_Translation_2 = Translation(-origin.X, -origin.Y, -origin.Z);
                if (transform3D_Translation_2 is null)
                {
                    return null;
                }

                return transform3D_Translation_1 * transform3D_Rotation * transform3D_Translation_2;
            }

            /// <summary>
            /// Gets Rotation Transform3D around the x-axis
            /// </summary>
            /// <param name="angle">Angle in radians</param>
            /// <returns>Transform3D</returns>
            public static Classes.Transform3D RotationX(double angle)
            {
                Classes.Transform3D? result = Identity();
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

            /// <summary>
            /// Creates a uniform scaling transformation matrix using the specified scale factor.
            /// </summary>
            /// <param name="factor">The double value to use as the scale factor for all axes.</param>
            /// <returns>A Classes.Transform3D object representing the uniform scaling transformation.</returns>
            public static Classes.Transform3D Scale(double factor)
            {
                Classes.Transform3D result = Identity();
                result[0, 0] = factor;
                result[1, 1] = factor;
                result[2, 2] = factor;

                return result;
            }

            /// <summary>
            /// Creates a scaling transformation matrix with specified factors for the X, Y, and Z axes.
            /// </summary>
            /// <param name="x">The scale factor for the X axis as a double.</param>
            /// <param name="y">The scale factor for the Y axis as a double.</param>
            /// <param name="z">The scale factor for the Z axis as a double.</param>
            /// <returns>A <see cref="Classes.Transform3D"/> representing the scaling transformation.</returns>
            public static Classes.Transform3D Scale(double x, double y, double z)
            {
                Classes.Transform3D result = Identity();
                result[0, 0] = x;
                result[1, 1] = y;
                result[2, 2] = z;

                return result;
            }

            /// <summary>
            /// Creates a scaling transformation relative to a specified origin point.
            /// </summary>
            /// <param name="origin">The <see cref="Point3D"/> representing the center of the scale operation.</param>
            /// <param name="factor">The double value used as the scaling factor.</param>
            /// <returns>A <see cref="Classes.Transform3D"/> object that performs the scaling, or null if the origin is null.</returns>
            public static Classes.Transform3D? Scale(Point3D? origin, double factor)
            {
                if (origin is null)
                {
                    return null;
                }

                Classes.Transform3D transform3D_Translation_1 = Translation(origin.X, origin.Y, origin.Z);

                Classes.Transform3D? transform3D_Scale = Scale(factor);
                Classes.Transform3D? transform3D_Translation_2 = Translation(-origin.X, -origin.Y, -origin.Z);

                return transform3D_Translation_1 * transform3D_Scale * transform3D_Translation_2;
            }

            /// <summary>
            /// Creates a translation transformation based on the specified <see cref="Vector3D"/>.
            /// </summary>
            /// <param name="vector3D">The <see cref="Vector3D"/> that defines the translation offset.</param>
            /// <returns>A <see cref="Classes.Transform3D"/> representing the translation, or null if the provided <see cref="Vector3D"/> is null.</returns>
            public static Classes.Transform3D? Translation(Vector3D? vector3D)
            {
                if (vector3D is null)
                {
                    return null;
                }

                Classes.Transform3D result = Identity();
                result[0, 3] = vector3D[0];
                result[1, 3] = vector3D[1];
                result[2, 3] = vector3D[2];

                return result;
            }

            /// <summary>
            /// Creates a translation transformation matrix based on the specified coordinates.
            /// </summary>
            /// <param name="x">The translation distance along the X axis as a double.</param>
            /// <param name="y">The translation distance along the Y axis as a double.</param>
            /// <param name="z">The translation distance along the Z axis as a double.</param>
            /// <returns>A Classes.Transform3D representing the translation transformation.</returns>
            public static Classes.Transform3D Translation(double x, double y, double z)
            {
                Classes.Transform3D result = Identity();
                result[0, 3] = x;
                result[1, 3] = y;
                result[2, 3] = z;

                return result;
            }

            /// <summary>
            /// Creates a <see cref="Classes.Transform3D"/> with an unset matrix.
            /// </summary>
            /// <returns>A <see cref="Classes.Transform3D"/> instance.</returns>
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
                Matrix4D matrix4D = new();
                matrix4D[3, 3] = 1;
                return new Classes.Transform3D(matrix4D);
            }
        }
    }
}

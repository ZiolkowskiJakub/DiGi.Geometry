using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the normal vector of a <see cref="Plane"/> based on a collection of <see cref="Planar.Classes.Point2D"/> points.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> instance.</param>
        /// <param name="point2Ds">An <c>IEnumerable&lt;Planar.Classes.Point2D&gt;</c> containing the points used to calculate the normal vector.</param>
        /// <returns>A <see cref="Vector3D"/> representing the normal vector, or null if the plane is null, the point collection is null, or there are fewer than three points.</returns>
        public static Vector3D? Normal(this Plane? plane, IEnumerable<Planar.Classes.Point2D>? point2Ds)
        {
            if (plane == null || point2Ds == null)
            {
                return null;
            }

            Planar.Classes.Point2D[] point2Ds_Local = point2Ds as Planar.Classes.Point2D[] ?? point2Ds.ToArray();
            int count = point2Ds_Local.Length;

            if (count < 3)
            {
                return null;
            }

            Vector3D? vector3D_AxisX = plane.AxisX;
            Vector3D? vector3D_AxisY = plane.AxisY;
            Point3D? point3D_Origin = plane.Origin;
            if (vector3D_AxisX == null || vector3D_AxisY == null || point3D_Origin == null)
            {
                return null;
            }

            double double_AxisXX = vector3D_AxisX.X;
            double double_AxisXY = vector3D_AxisX.Y;
            double double_AxisXZ = vector3D_AxisX.Z;

            double double_AxisYX = vector3D_AxisY.X;
            double double_AxisYY = vector3D_AxisY.Y;
            double double_AxisYZ = vector3D_AxisY.Z;

            double double_OriginX = point3D_Origin.X;
            double double_OriginY = point3D_Origin.Y;
            double double_OriginZ = point3D_Origin.Z;

            for (int int_I = 0; int_I < count; int_I++)
            {
                int int_Index1 = int_I;
                int int_Index2 = DiGi.Core.Query.Next(count, int_Index1);
                int int_Index3 = DiGi.Core.Query.Next(count, int_Index2);

                Planar.Classes.Point2D point2D_1 = point2Ds_Local[int_Index1];
                Planar.Classes.Point2D point2D_2 = point2Ds_Local[int_Index2];
                Planar.Classes.Point2D point2D_3 = point2Ds_Local[int_Index3];

                if (point2D_1 == null || point2D_2 == null || point2D_3 == null)
                {
                    continue;
                }

                Point3D point3D_1 = new(
                    double_OriginX + (double_AxisYX * point2D_1.Y) + (double_AxisXX * point2D_1.X),
                    double_OriginY + (double_AxisYY * point2D_1.Y) + (double_AxisXY * point2D_1.X),
                    double_OriginZ + (double_AxisYZ * point2D_1.Y) + (double_AxisXZ * point2D_1.X)
                );

                Point3D point3D_2 = new(
                    double_OriginX + (double_AxisYX * point2D_2.Y) + (double_AxisXX * point2D_2.X),
                    double_OriginY + (double_AxisYY * point2D_2.Y) + (double_AxisXY * point2D_2.X),
                    double_OriginZ + (double_AxisYZ * point2D_2.Y) + (double_AxisXZ * point2D_2.X)
                );

                Point3D point3D_3 = new(
                    double_OriginX + (double_AxisYX * point2D_3.Y) + (double_AxisXX * point2D_3.X),
                    double_OriginY + (double_AxisYY * point2D_3.Y) + (double_AxisXY * point2D_3.X),
                    double_OriginZ + (double_AxisYZ * point2D_3.Y) + (double_AxisXZ * point2D_3.X)
                );

                Vector3D? normal = Normal(point3D_1, point3D_2, point3D_3);
                if (normal is null)
                {
                    continue;
                }

                return normal;
            }

            return null;
        }

        /// <summary>
        /// Calculates the normal vector of a plane defined by a collection of 3D points.
        /// </summary>
        /// <param name="point3Ds">The <see cref="IEnumerable{Point3D}"/> collection of points used to determine the normal vector.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used to check if the points are collinear.</param>
        /// <returns>A <see cref="Vector3D"/> representing the normal vector, or <c>null</c> if the collection is null, contains fewer than three points, or the points are collinear within the specified tolerance.</returns>
        public static Vector3D? Normal(this IEnumerable<Point3D>? point3Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point3Ds == null)
            {
                return null;
            }

            Point3D[] point3Ds_Local = point3Ds as Point3D[] ?? point3Ds.ToArray();
            if (point3Ds_Local.Collinear(tolerance))
            {
                return null;
            }

            int count = point3Ds_Local.Length;

            if (count < 3)
            {
                return null;
            }

            if (count == 3)
            {
                return Normal(point3Ds_Local[0], point3Ds_Local[1], point3Ds_Local[2]);
            }

            Point3D? origin = point3Ds_Local.Average();
            if (origin is null)
            {
                return null;
            }

            Vector3D? normal = Constants.Vector3D.Zero;
            if (point3Ds_Local.Coplanar(tolerance))
            {
                double double_Nx = 0;
                double double_Ny = 0;
                double double_Nz = 0;
                double double_Ox = origin.X;
                double double_Oy = origin.Y;
                double double_Oz = origin.Z;

                for (int int_I = 0; int_I < count - 1; int_I++)
                {
                    Point3D point3D_Current = point3Ds_Local[int_I];
                    Point3D point3D_Next = point3Ds_Local[int_I + 1];
                    if (point3D_Current == null || point3D_Next == null)
                    {
                        continue;
                    }

                    double double_Ux = point3D_Current.X - double_Ox;
                    double double_Uy = point3D_Current.Y - double_Oy;
                    double double_Uz = point3D_Current.Z - double_Oz;

                    double double_Vx = point3D_Next.X - double_Ox;
                    double double_Vy = point3D_Next.Y - double_Oy;
                    double double_Vz = point3D_Next.Z - double_Oz;

                    double_Nx += double_Uy * double_Vz - double_Uz * double_Vy;
                    double_Ny += double_Uz * double_Vx - double_Ux * double_Vz;
                    double_Nz += double_Ux * double_Vy - double_Uy * double_Vx;
                }

                double double_LenSq = double_Nx * double_Nx + double_Ny * double_Ny + double_Nz * double_Nz;
                if (double_LenSq > 0.0)
                {
                    double double_Len = System.Math.Sqrt(double_LenSq);
                    return new(double_Nx / double_Len, double_Ny / double_Len, double_Nz / double_Len);
                }
                return Constants.Vector3D.Zero;
            }

            Math.Classes.Matrix matrix = new(3, 3);
            double[,] normalizedPoints = new double[count, 3];

            for (int i = 0; i < count; i++)
            {
                Point3D point3D = point3Ds_Local[i];
                if (point3D != null)
                {
                    normalizedPoints[i, 0] = point3D.X - origin.X;
                    normalizedPoints[i, 1] = point3D.Y - origin.Y;
                    normalizedPoints[i, 2] = point3D.Z - origin.Z;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    double value = 0;
                    for (int k = 0; k < count; k++)
                    {
                        value += normalizedPoints[k, i] * normalizedPoints[k, j];
                    }
                    matrix[i, j] = value;
                }
            }

            Vector3D[]? eigenvectors = Eigenvectors(matrix, tolerance);
            if (eigenvectors == null)
            {
                return null;
            }

            Vector3D? result = null;
            double leastSquares = double.PositiveInfinity;
            foreach (Vector3D eigenvector in eigenvectors)
            {
                double squares = 0;
                for (int i = 0; i < count; i++)
                {
                    squares += System.Math.Pow(eigenvector.X * normalizedPoints[i, 0] + eigenvector.Y * normalizedPoints[i, 1] + eigenvector.Z * normalizedPoints[i, 2], 2);
                }

                if (squares <= leastSquares)
                {
                    leastSquares = squares;
                    result = eigenvector;
                }
            }

            if (result is null)
            {
                return null;
            }

            result = result.Unit;

            Plane plane = new(origin, result);

            bool invalid = false;
            foreach (Point3D point3D in point3Ds_Local)
            {
                if (point3D != null && plane.Distance(point3D) > tolerance)
                {
                    invalid = true;
                    break;
                }
            }

            if (invalid)
            {
                double double_Nx = 0;
                double double_Ny = 0;
                double double_Nz = 0;
                double double_Ox = origin.X;
                double double_Oy = origin.Y;
                double double_Oz = origin.Z;

                for (int int_I = 0; int_I < count - 1; int_I++)
                {
                    Point3D point3D_Current = point3Ds_Local[int_I];
                    Point3D point3D_Next = point3Ds_Local[int_I + 1];
                    if (point3D_Current == null || point3D_Next == null)
                    {
                        continue;
                    }

                    double double_Ux = point3D_Current.X - double_Ox;
                    double double_Uy = point3D_Current.Y - double_Oy;
                    double double_Uz = point3D_Current.Z - double_Oz;

                    double double_Vx = point3D_Next.X - double_Ox;
                    double double_Vy = point3D_Next.Y - double_Oy;
                    double double_Vz = point3D_Next.Z - double_Oz;

                    double_Nx += double_Uy * double_Vz - double_Uz * double_Vy;
                    double_Ny += double_Uz * double_Vx - double_Ux * double_Vz;
                    double_Nz += double_Ux * double_Vy - double_Uy * double_Vx;
                }

                double double_LenSq = double_Nx * double_Nx + double_Ny * double_Ny + double_Nz * double_Nz;
                if (double_LenSq > 0.0)
                {
                    double double_Len = System.Math.Sqrt(double_LenSq);
                    normal = new(double_Nx / double_Len, double_Ny / double_Len, double_Nz / double_Len);
                }
                else
                {
                    normal = Constants.Vector3D.Zero;
                }

                Plane plane_Temp = new(origin, normal);

                double max = double.MinValue;
                double max_Temp = double.MinValue;
                foreach (Point3D point3D in point3Ds_Local)
                {
                    if (point3D == null)
                    {
                        continue;
                    }

                    double distance = double.NaN;

                    distance = plane.Distance(point3D);
                    if (distance > max)
                    {
                        max = distance;
                    }

                    distance = plane_Temp.Distance(point3D);
                    if (distance > max_Temp)
                    {
                        max_Temp = distance;
                    }
                }

                if (max_Temp < max)
                {
                    result = normal;
                }
            }

            return result;
        }

        /// <summary>
        /// Calculates the unit normal vector of a plane defined by three points.
        /// </summary>
        /// <param name="point3D_1">The first <see cref="Point3D" /> point.</param>
        /// <param name="point3D_2">The second <c>Point3D?</c> point.</param>
        /// <param name="point3D_3">The third <c>Point3D?</c> point.</param>
        /// <returns>A <c>Vector3D?</c> representing the unit normal vector, or <c>null</c> if any of the provided points are <c>null</c> or if the points are collinear.</returns>
        public static Vector3D? Normal(this Point3D? point3D_1, Point3D? point3D_2, Point3D? point3D_3)
        {
            if (point3D_1 == null || point3D_2 == null || point3D_3 == null)
            {
                return null;
            }

            if (point3D_1.Collinear(point3D_2, point3D_3))
            {
                return null;
            }

            double double_Ux = point3D_2.X - point3D_1.X;
            double double_Uy = point3D_2.Y - point3D_1.Y;
            double double_Uz = point3D_2.Z - point3D_1.Z;

            double double_Vx = point3D_3.X - point3D_1.X;
            double double_Vy = point3D_3.Y - point3D_1.Y;
            double double_Vz = point3D_3.Z - point3D_1.Z;

            double double_Nx = double_Uy * double_Vz - double_Uz * double_Vy;
            double double_Ny = double_Uz * double_Vx - double_Ux * double_Vz;
            double double_Nz = double_Ux * double_Vy - double_Uy * double_Vx;

            double double_LengthSq = double_Nx * double_Nx + double_Ny * double_Ny + double_Nz * double_Nz;
            if (double_LengthSq == 0.0)
            {
                return null;
            }

            double double_Length = System.Math.Sqrt(double_LengthSq);
            return new(double_Nx / double_Length, double_Ny / double_Length, double_Nz / double_Length);
        }

        /// <summary>
        /// Calculates the normal vector perpendicular to the two specified axes.
        /// </summary>
        /// <param name="axisX">The first Vector3D? axis.</param>
        /// <param name="axisY">The second <c>Vector3D?</c> axis.</param>
        /// <returns>A normalized <c>Vector3D?</c> representing the cross product of the two axes, or null if either <c>Vector3D?</c> parameter is null.</returns>
        public static Vector3D? Normal(this Vector3D? axisX, Vector3D? axisY)
        {
            if (axisX is null || axisY is null)
            {
                return null;
            }

            double double_Nx = axisX.Y * axisY.Z - axisX.Z * axisY.Y;
            double double_Ny = axisX.Z * axisY.X - axisX.X * axisY.Z;
            double double_Nz = axisX.X * axisY.Y - axisX.Y * axisY.X;

            double double_LengthSq = double_Nx * double_Nx + double_Ny * double_Ny + double_Nz * double_Nz;
            if (double_LengthSq == 0.0)
            {
                return null;
            }

            double double_Length = System.Math.Sqrt(double_LengthSq);
            return new(double_Nx / double_Length, double_Ny / double_Length, double_Nz / double_Length);
        }
    }
}
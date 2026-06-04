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
        /// <param name="point2Ds">An <IEnumerable<Planar.Classes.Point2D>> containing the points used to calculate the normal vector.</param>
        /// <returns>A <see cref="Vector3D"/> representing the normal vector, or null if the plane is null, the point collection is null, or there are fewer than three points.</returns>
        public static Vector3D? Normal(this Plane? plane, IEnumerable<Planar.Classes.Point2D>? point2Ds)
        {
            if (plane == null || point2Ds == null)
            {
                return null;
            }

            int count = point2Ds.Count();

            if (count < 3)
            {
                return null;
            }

            for (int i = 0; i < count; i++)
            {
                int index_1 = i;
                int index_2 = DiGi.Core.Query.Next(count, index_1);
                int index_3 = DiGi.Core.Query.Next(count, index_2);

                Point3D? point3D_1 = plane.Convert(point2Ds.ElementAt(index_1));
                Point3D? point3D_2 = plane.Convert(point2Ds.ElementAt(index_2));
                Point3D? point3D_3 = plane.Convert(point2Ds.ElementAt(index_3));

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
            if (point3Ds == null || point3Ds.Collinear(tolerance))
            {
                return null;
            }

            int count = point3Ds.Count();

            if (count < 3)
            {
                return null;
            }

            if (count == 3)
            {
                return Normal(point3Ds.ElementAt(0), point3Ds.ElementAt(1), point3Ds.ElementAt(2));
            }

            Point3D? origin = point3Ds.Average();
            if (origin is null)
            {
                return null;
            }

            Vector3D? normal = Constants.Vector3D.Zero;
            if (point3Ds.Coplanar(tolerance))
            {
                Vector3D? vector3D_Origin = (Vector3D?)origin;

                for (int i = 0; i < count - 1; i++)
                {
                    Vector3D? vector3D = ((Vector3D?)point3Ds.ElementAt(i) - vector3D_Origin)?.CrossProduct((Vector3D?)point3Ds.ElementAt(i + 1) - vector3D_Origin);
                    if (vector3D is null)
                    {
                        continue;
                    }

                    normal += vector3D;
                }

                return normal!.Unit;
            }

            Math.Classes.Matrix matrix = new(3, 3);
            double[,] normalizedPoints = new double[count, 3];

            for (int i = 0; i < count; i++)
            {
                normalizedPoints[i, 0] = point3Ds.ElementAt(i).X - origin.X;
                normalizedPoints[i, 1] = point3Ds.ElementAt(i).Y - origin.Y;
                normalizedPoints[i, 2] = point3Ds.ElementAt(i).Z - origin.Z;
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
            foreach (Point3D point3D in point3Ds)
            {
                if (plane.Distance(point3D) > tolerance)
                {
                    invalid = true;
                    break;
                }
            }

            if (invalid)
            {
                normal = Constants.Vector3D.Zero;

                Vector3D? vector3D_Origin = (Vector3D?)origin;

                for (int i = 0; i < count - 1; i++)
                {
                    Vector3D? vector3D = ((Vector3D?)point3Ds.ElementAt(i) - vector3D_Origin)?.CrossProduct((Vector3D?)point3Ds.ElementAt(i + 1) - vector3D_Origin);
                    if (vector3D is null)
                    {
                        continue;
                    }

                    normal += vector3D;
                }

                normal = normal!.Unit;

                Plane plane_Temp = new(origin, normal);

                double max = double.MinValue;
                double max_Temp = double.MinValue;
                foreach (Point3D point3D in point3Ds)
                {
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
        /// <param name="point3D_1">The first <see cref="Point3D?" /> point.</param>
        /// <param name="point3D_2">The second <see cref="Point3D?" /> point.</param>
        /// <param name="point3D_3">The third <see cref="Point3D?" /> point.</param>
        /// <returns>A <see cref="Vector3D?" /> representing the unit normal vector, or <c>null</c> if any of the provided points are <c>null</c>.</returns>
        public static Vector3D? Normal(this Point3D? point3D_1, Point3D? point3D_2, Point3D? point3D_3)
        {
            if (point3D_1 == null || point3D_2 == null || point3D_3 == null)
            {
                return null;
            }

            return new Vector3D(point3D_1, point3D_2).CrossProduct(new Vector3D(point3D_1, point3D_3))?.Unit;
        }

        /// <summary>
        /// Calculates the normal vector perpendicular to the two specified axes.
        /// </summary>
        /// <param name="axisX">The first <Vector3D?> axis.</param>
        /// <param name="axisY">The second <Vector3D?> axis.</param>
        /// <returns>A normalized <Vector3D?> representing the cross product of the two axes, or null if either <Vector3D?> parameter is null.</returns>
        public static Vector3D? Normal(this Vector3D? axisX, Vector3D? axisY)
        {
            if (axisX is null || axisY is null)
            {
                return null;
            }

            return axisX.CrossProduct(axisY)?.Unit;
        }
    }
}
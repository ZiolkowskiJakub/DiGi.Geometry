using DiGi.Core;
using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Determines the orientation of three <see cref="Point3D" /> points relative to a specified <see cref="Vector3D" /> normal vector.
        /// </summary>
        /// <param name="point3D_1">The first <c>Point3D?</c> point.</param>
        /// <param name="point3D_2">The second <c>Point3D?</c> point.</param>
        /// <param name="point3D_3">The third <c>Point3D?</c> point.</param>
        /// <param name="normal">The <c>Vector3D?</c> normal vector used to determine the orientation.</param>
        /// <returns>An <see cref="Core.Enums.Orientation" /> value indicating if the points are clockwise, counter-clockwise, collinear, or undefined.</returns>
        public static Orientation Orientation(this Point3D? point3D_1, Point3D? point3D_2, Point3D? point3D_3, Vector3D? normal)
        {
            double determinant = Determinant(point3D_1, point3D_2, point3D_3, normal);
            if (double.IsNaN(determinant))
            {
                return Core.Enums.Orientation.Undefined;
            }

            if (determinant == 0)
            {
                return Core.Enums.Orientation.Collinear;
            }

            return determinant > 0 ? Core.Enums.Orientation.CounterClockwise : Core.Enums.Orientation.Clockwise;
        }

        /// <summary>
        /// Determines the orientation of two vectors relative to a normal vector in 3D space.
        /// </summary>
        /// <param name="vector3D_1">The first <see cref="Vector3D"/>? vector.</param>
        /// <param name="vector3D_2">The second <see cref="Vector3D"/>? vector.</param>
        /// <param name="normal">The normal <see cref="Vector3D"/>? vector used to determine the orientation.</param>
        /// <returns>An <see cref="Core.Enums.Orientation"/> value indicating whether the vectors are collinear, clockwise, or counter-clockwise.</returns>
        public static Orientation Orientation(this Vector3D? vector3D_1, Vector3D? vector3D_2, Vector3D? normal)
        {
            double determinant = Determinant(vector3D_1, vector3D_2, normal);

            if (determinant == 0)
            {
                return Core.Enums.Orientation.Collinear;
            }

            return determinant > 0 ? Core.Enums.Orientation.Clockwise : Core.Enums.Orientation.CounterClockwise;
        }

        /// <summary>
        /// Determines the orientation of the specified 3D polygonal object.
        /// </summary>
        /// <param name="polygonal3D">The <see cref="IPolygonal3D"/> object to evaluate.</param>
        /// <param name="convexHull">A <see cref="bool"/> value indicating whether the convex hull should be used for orientation calculation. Defaults to true.</param>
        /// <returns>An <see cref="Core.Enums.Orientation"/> value representing the orientation of the polygonal object, or <see cref="Orientation.Undefined"/> if the plane is not defined.</returns>
        public static Orientation Orientation(this IPolygonal3D? polygonal3D, bool convexHull = true)
        {
            if (polygonal3D?.Plane is not Plane plane)
            {
                return Core.Enums.Orientation.Undefined;
            }

            List<Point2D>? point2Ds = null;

            if (polygonal3D is Polygon3D polygon3D)
            {
                point2Ds = polygon3D.Geometry2D?.GetPoints();
            }
            else if (polygonal3D is Triangle3D triangle3D)
            {
                point2Ds = triangle3D.Geometry2D?.GetPoints();
            }
            else
            {
                point2Ds = polygonal3D.GetPoints()?.ConvertAll(plane.Convert).FilterNulls();
            }

            return Orientation(plane, point2Ds, convexHull);
        }

        /// <summary>
        /// Determines the orientation of a polygonal shape on a specified plane.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> on which the orientation is calculated.</param>
        /// <param name="polygonal2D">The <see cref="IPolygonal2D"/> object whose orientation is to be determined.</param>
        /// <param name="convexHull">A <see cref="bool"/> value indicating whether to calculate the orientation based on the convex hull of the points.</param>
        /// <returns>An <see cref="Core.Enums.Orientation"/> value representing the orientation of the polygonal shape.</returns>
        public static Orientation Orientation(this Plane? plane, IPolygonal2D? polygonal2D, bool convexHull = true)
        {
            return Orientation(plane, polygonal2D?.GetPoints(), convexHull);
        }

        /// <summary>
        /// Determines the orientation of a collection of 2D points on a specified plane.
        /// </summary>
        /// <param name="plane">The <see cref="Plane"/> used to convert 2D points into 3D space.</param>
        /// <param name="point2Ds">An <see cref="IEnumerable{Point2D}"/> containing the points to evaluate.</param>
        /// <param name="convexHull">A <see cref="bool"/> value indicating whether to compute the convex hull of the points before determining orientation. Defaults to true.</param>
        /// <returns>The calculated <see cref="Core.Enums.Orientation"/>, or <see cref="Orientation.Undefined"/> if the plane is null, the point collection is empty, or there are fewer than three valid points.</returns>
        public static Orientation Orientation(this Plane? plane, IEnumerable<Point2D>? point2Ds, bool convexHull = true)
        {
            if (plane?.Normal is not Vector3D normal || point2Ds is null)
            {
                return Core.Enums.Orientation.Undefined;
            }

            Point2D[] point2Ds_Cached = point2Ds as Point2D[] ?? [.. point2Ds];
            if (point2Ds_Cached.Length == 0)
            {
                return Core.Enums.Orientation.Undefined;
            }

            List<Point2D>? point2Ds_Temp = convexHull ? Planar.Query.ConvexHull(point2Ds_Cached, true) : [.. point2Ds_Cached];
            if (point2Ds_Temp == null || point2Ds_Temp.Count < 3)
            {
                return Core.Enums.Orientation.Undefined;
            }

            List<Point3D>? point3Ds = point2Ds_Temp.ConvertAll(plane.Convert).FilterNulls();
            if (point3Ds == null || point3Ds.Count < 3)
            {
                return Core.Enums.Orientation.Undefined;
            }

            point3Ds.Add(point3Ds[0]);
            point3Ds.Add(point3Ds[1]);

            for (int i = 0; i < point3Ds.Count - 2; i++)
            {
                Orientation orientation = Orientation(point3Ds[i], point3Ds[i + 1], point3Ds[i + 2], normal);
                if (orientation != Core.Enums.Orientation.Collinear && orientation != Core.Enums.Orientation.Undefined)
                {
                    return orientation;
                }
            }

            return Core.Enums.Orientation.Undefined;
        }
    }
}
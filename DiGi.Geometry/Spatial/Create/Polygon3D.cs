using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a <see cref="Classes.Polygon3D"/> from a collection of <see cref="Point3D"/> objects.
        /// </summary>
        /// <param name="point3Ds">The <see cref="IEnumerable{T}"/> of <see cref="Point3D"/> objects used to define the polygon.</param>
        /// <param name="tolerace">The <see cref="double"/> value representing the distance tolerance for plane calculation.</param>
        /// <returns>A <see cref="Classes.Polygon3D"/> object if a valid polygon can be created; otherwise, null.</returns>
        public static Polygon3D? Polygon3D(this IEnumerable<Point3D?>? point3Ds, double tolerace = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point3Ds == null)
            {
                return null;
            }

            List<Point3D> point3Ds_Temp = [];
            foreach (Point3D? point3D in point3Ds)
            {
                if (point3D != null)
                {
                    point3Ds_Temp.Add(point3D);
                }
            }

            if (point3Ds_Temp.Count < 3)
            {
                return null;
            }

            Plane? plane = Plane(point3Ds_Temp, tolerace);
            if (plane == null)
            {
                return null;
            }

            List<Point2D> point2Ds = [];
            foreach (Point3D point3D in point3Ds_Temp)
            {
                Point2D? point2D = Query.Convert(plane, plane.Project(point3D));
                if (point2D == null)
                {
                    continue;
                }

                point2Ds.Add(point2D);
            }

            return new Polygon3D(plane, point2Ds);
        }

        /// <summary>
        /// Creates a <see cref="Classes.Polygon3D"/> from the specified normal vector and a collection of 3D points.
        /// </summary>
        /// <param name="normal">The <see cref="Vector3D"/> representing the normal vector of the plane.</param>
        /// <param name="point3Ds">An <see cref="IEnumerable{Point3D}"/> containing the vertices to be used for the polygon.</param>
        /// <returns>A <see cref="Classes.Polygon3D"/> if a valid polygon can be constructed; otherwise, <c>null</c>.</returns>
        public static Polygon3D? Polygon3D(this Vector3D? normal, IEnumerable<Point3D?>? point3Ds)
        {
            if (normal == null || point3Ds == null)
            {
                return null;
            }

            Point3D?[] point3Ds_Materialized = point3Ds as Point3D?[] ?? [.. point3Ds];
            if (point3Ds_Materialized.Length < 3)
            {
                return null;
            }

            Point3D? point3D_First = point3Ds_Materialized[0];
            if (point3D_First == null)
            {
                return null;
            }

            Plane plane = new(point3D_First, normal);

            List<Point2D> point2Ds = [];
            foreach (Point3D? point3D in point3Ds_Materialized)
            {
                Point2D? point2D = Query.Convert(plane, plane.Project(point3D));
                if (point2D is not null)
                {
                    point2Ds.Add(point2D);
                }
            }

            if (point2Ds.Count < 3)
            {
                return null;
            }

            return new Polygon3D(plane, point2Ds);
        }

        /// <summary>
        /// Creates a <see cref="Classes.Polygon3D"/> from the specified <see cref="Segment3D"/> with a given height.
        /// </summary>
        /// <param name="segment3D">The <see cref="Segment3D"/> to be converted into a polygon.</param>
        /// <param name="height">The <see cref="double"/> height of the resulting polygon.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance used to determine if the segment is parallel to the Z-axis.</param>
        /// <returns>A <see cref="Classes.Polygon3D"/> instance, or null if the <see cref="Segment3D"/> is null, height is NaN, or the segment direction is parallel to the WorldZ axis within the specified tolerance.</returns>
        public static Polygon3D? Polygon3D(this Segment3D? segment3D, double height, double tolerance = DiGi.Core.Constants.Tolerance.Angle)
        {
            if (segment3D == null || double.IsNaN(height))
            {
                return null;
            }

            Vector3D? direction = segment3D.Direction;
            if (direction == null)
            {
                return null;
            }

            Vector3D direction_Z = Constants.Vector3D.WorldZ;

            if (direction.MinAngle(direction_Z) <= tolerance || direction.GetInversed().MinAngle(direction_Z) <= tolerance)
            {
                return null;
            }

            Vector3D? vector3D = direction_Z * height;

            return Polygon3D([segment3D[0], segment3D[1], segment3D[1]?.GetMoved(vector3D), segment3D[0]?.GetMoved(vector3D)]);
        }

        /// <summary>
        /// Creates a <see cref="Classes.Polygon3D"/> from a <see cref="Segment3D"/> and a <see cref="Vector3D"/>.
        /// </summary>
        /// <param name="segment3D">The <see cref="Segment3D"/> to use as the base for the polygon.</param>
        /// <param name="vector3D">The <see cref="Vector3D"/> used to define the polygon's extent or direction.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used for length and similarity comparisons.</param>
        /// <returns>A <see cref="Classes.Polygon3D"/> if a valid polygon can be created; otherwise, <c>null</c>.</returns>
        public static Polygon3D? Polygon3D(this Segment3D? segment3D, Vector3D? vector3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segment3D == null || vector3D == null)
            {
                return null;
            }

            double length = vector3D.Length;
            if (double.IsNaN(length) || length < tolerance)
            {
                return null;
            }

            if (segment3D.Direction.Similar(vector3D.Unit, tolerance))
            {
                return null;
            }

            Point3D? point3D_1 = segment3D[0];
            Point3D? point3D_2 = segment3D[1];
            Point3D? point3D_3 = segment3D[1]?.GetMoved(vector3D);

            Plane? plane = Plane(point3D_1, point3D_2, point3D_3);
            if (plane == null)
            {
                return null;
            }

            Point3D? point3D_4 = segment3D[0]?.GetMoved(vector3D);

            Point2D? point2D_1 = plane.Convert(point3D_1);
            if (point2D_1 is null)
            {
                return null;
            }

            Point2D? point2D_2 = plane.Convert(point3D_2);
            if (point2D_2 is null)
            {
                return null;
            }

            Point2D? point2D_3 = plane.Convert(point3D_3);
            if (point2D_3 is null)
            {
                return null;
            }

            Point2D? point2D_4 = plane.Convert(point3D_4);
            if (point2D_4 is null)
            {
                return null;
            }

            return new Polygon3D(plane, [point2D_1, point2D_2, point2D_3, point2D_4]);
        }

        /// <summary>
        /// Converts a planar object to a <see cref="Classes.Polygon3D"/>.
        /// </summary>
        /// <typeparam name="T">The type of the 2D polygonal geometry, which must implement <see cref="IPolygonal2D"/>.</typeparam>
        /// <param name="planar">The <see cref="IPlanar{T}"/> object to convert.</param>
        /// <returns>A <see cref="Classes.Polygon3D"/> if the <see cref="IPlanar{T}"/> object, its geometry, and its plane are not null; otherwise, null.</returns>
        public static Polygon3D? Polygon3D<T>(this IPlanar<T>? planar) where T : IPolygonal2D
        {
            if (planar == null)
            {
                return null;
            }

            T? geometry2D = planar.Geometry2D;
            if (geometry2D == null)
            {
                return null;
            }

            Plane? plane = planar.Plane;
            if (plane == null)
            {
                return null;
            }

            List<Point2D>? point2Ds = geometry2D.GetPoints();
            if (point2Ds == null || point2Ds.Count < 3)
            {
                return null;
            }

            return new Polygon3D(plane, point2Ds);
        }

        /// <summary>
        /// Creates a <see cref="Classes.Polygon3D"/> instance based on the provided <see cref="Classes.Plane"/> and a collection of <see cref="Point2D"/> points.
        /// </summary>
        /// <param name="plane">The <see cref="Classes.Plane"/> that defines the surface of the polygon.</param>
        /// <param name="point2Ds">A variable number of <see cref="Point2D"/> objects representing the vertices of the polygon.</param>
        /// <returns>A new <see cref="Classes.Polygon3D"/> instance if a valid <see cref="Classes.Plane"/> is provided and there are at least three non-null <see cref="Point2D"/> points; otherwise, null.</returns>
        public static Polygon3D? Polygon3D(Plane? plane, params Point2D?[]? point2Ds)
        {
            if (plane == null || point2Ds == null || point2Ds.Length < 3)
            {
                return null;
            }

            List<Point2D> point2Ds_Temp = [];
            foreach (Point2D? point2D in point2Ds)
            {
                if (point2D is null)
                {
                    continue;
                }

                point2Ds_Temp.Add(point2D);
            }

            return new Polygon3D(plane, point2Ds_Temp);
        }
    }
}
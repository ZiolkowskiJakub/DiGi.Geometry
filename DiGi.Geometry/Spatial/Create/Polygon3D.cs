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
        public static Polygon3D? Polygon3D(this IEnumerable<Point3D?>? point3Ds, double tolerace = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point3Ds == null || point3Ds.Count() < 3)
            {
                return null;
            }

            List<Point3D> point3Ds_Temp = [];
            foreach (Point3D? point3D in point3Ds)
            {
                if (point3D == null)
                {
                    continue;
                }

                point3Ds_Temp.Add(point3D);
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

        public static Polygon3D? Polygon3D(this Vector3D? normal, IEnumerable<Point3D?>? point3Ds)
        {
            if (normal == null || point3Ds == null || point3Ds.Count() < 3)
            {
                return null;
            }

            Plane plane = new(point3Ds.ElementAt(0), normal);

            List<Point2D> point2Ds = [];
            foreach (Point3D? point3D in point3Ds)
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
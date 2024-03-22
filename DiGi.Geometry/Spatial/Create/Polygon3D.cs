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
        public static Polygon3D Polygon3D(this IEnumerable<Point3D> point3Ds, double tolerace = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point3Ds == null || point3Ds.Count() < 3)
            {
                return null;
            }

            Plane plane = Plane(point3Ds, tolerace);
            if (plane == null)
            {
                return null;
            }

            List<Point2D> point2Ds = new List<Point2D>();
            foreach (Point3D point3D in point3Ds)
            {
                Point2D point2D = Query.Convert(plane, plane.Project(point3D));
                if (point2D == null)
                {
                    continue;
                }

                point2Ds.Add(point2D);
            }

            return new Polygon3D(plane, point2Ds);
        }

        public static Polygon3D Polygon3D(this Vector3D normal, IEnumerable<Point3D> point3Ds)
        {
            if (normal == null || point3Ds == null || point3Ds.Count() < 3)
            {
                return null;
            }

            Plane plane = new Plane(point3Ds.ElementAt(0), normal);

            List<Point2D> point2Ds = new List<Point2D>();
            foreach (Point3D point3D in point3Ds)
            {
                point2Ds.Add(plane.Convert(plane.Project(point3D)));
            }

            return new Polygon3D(plane, point2Ds);
        }

        public static Polygon3D Polygon3D(this Segment3D segment3D, double height, double tolerance = DiGi.Core.Constans.Tolerance.Angle)
        {
            if (segment3D == null || double.IsNaN(height))
            {
                return null;
            }

            Vector3D direction = segment3D.Direction;
            if (direction == null)
            {
                return null;
            }

            Vector3D direction_Z = Constans.Vector3D.WorldZ;

            if (direction.MinAngle(direction_Z) <= tolerance || direction.GetInversed().MinAngle(direction_Z) <= tolerance)
            {
                return null;
            }

            Vector3D vector3D = direction_Z * height;

            return Polygon3D(new Point3D[] { segment3D[0], segment3D[1], segment3D[1].GetMoved(vector3D), segment3D[0].GetMoved(vector3D) });
        }

        public static Polygon3D Polygon3D(this Segment3D segment3D, Vector3D vector3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (segment3D == null ||  vector3D == null)
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

            Point3D point3D_1 = segment3D[0];
            Point3D point3D_2 = segment3D[1];
            Point3D point3D_3 = segment3D[1].GetMoved(vector3D) as Point3D;

            Plane plane = Plane(point3D_1, point3D_2, point3D_3);
            if (plane == null)
            {
                return null;
            }

            Point3D point3D_4 = segment3D[0].GetMoved(vector3D) as Point3D;

            return new Polygon3D(plane, new Point2D[] { plane.Convert(point3D_1), plane.Convert(point3D_2), plane.Convert(point3D_3), plane.Convert(point3D_4) });
        }

        public static Polygon3D Polygon3D<T>(this IPlanar<T> planar) where T: IPolygonal2D
        {
            if(planar == null)
            {
                return null;
            }

            T geometry2D = planar.Geometry2D;
            if(geometry2D == null)
            {
                return null;
            }

            Plane plane = planar.Plane;
            if (plane == null)
            {
                return null;
            }

            List<Point2D> point2Ds = geometry2D.GetPoints();
            if (point2Ds == null || point2Ds.Count < 3)
            {
                return null;
            }

            return new Polygon3D(plane, point2Ds);
        }
    }
}

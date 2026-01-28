using DiGi.Core;
using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
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

        public static Orientation Orientation(this Vector3D? vector3D_1, Vector3D? vector3D_2, Vector3D? normal)
        {
            double determinant = Determinant(vector3D_1, vector3D_2, normal);

            if (determinant == 0)
            {
                return Core.Enums.Orientation.Collinear;
            }

            return determinant > 0 ? Core.Enums.Orientation.Clockwise : Core.Enums.Orientation.CounterClockwise;
        }

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

        public static Orientation Orientation(this Plane? plane, IPolygonal2D? polygonal2D, bool convexHull = true)
        {
            return Orientation(plane, polygonal2D?.GetPoints(), convexHull);
        }

        public static Orientation Orientation(this Plane? plane, IEnumerable<Point2D>? point2Ds, bool convexHull = true)
        {
            if (plane?.Normal is not Vector3D normal || point2Ds is null || !point2Ds.Any())
            {
                return Core.Enums.Orientation.Undefined;
            }

            List<Point2D>? point2Ds_Temp = convexHull ? Planar.Query.ConvexHull(point2Ds, true) : [.. point2Ds];
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
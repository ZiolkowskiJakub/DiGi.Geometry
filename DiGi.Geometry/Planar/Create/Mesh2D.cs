using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Geometries;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        public static Mesh2D Mesh2D(this IEnumerable<Triangle2D> triangle2Ds, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (triangle2Ds == null || triangle2Ds.Count() == 0)
            {
                return null;
            }

            List<Point2D> point2Ds = new List<Point2D>();

            List<int[]> indexes = new List<int[]>();

            foreach (Triangle2D triangle2D in triangle2Ds)
            {
                if (triangle2D == null || triangle2D.GetArea() < tolerance)
                {
                    continue;
                }

                List<Point2D> point2Ds_Triangle = triangle2D.GetPoints();
                if (point2Ds_Triangle == null || point2Ds_Triangle.Count < 3)
                {
                    continue;
                }

                int index_1 = -1;
                index_1 = point2Ds.FindIndex(x => Query.AlmostEquals(x, point2Ds_Triangle[0], tolerance));
                if (index_1 == -1)
                {
                    index_1 = point2Ds.Count;
                    point2Ds.Add(point2Ds_Triangle[0]);
                }

                int index_2 = -1;
                index_2 = point2Ds.FindIndex(x => Query.AlmostEquals(x, point2Ds_Triangle[1], tolerance));
                if (index_2 == -1)
                {
                    index_2 = point2Ds.Count;
                    point2Ds.Add(point2Ds_Triangle[1]);
                }

                int index_3 = -1;
                index_3 = point2Ds.FindIndex(x => Query.AlmostEquals(x, point2Ds_Triangle[2], tolerance));
                if (index_3 == -1)
                {
                    index_3 = point2Ds.Count;
                    point2Ds.Add(point2Ds_Triangle[2]);
                }

                indexes.Add(new int[] { index_1, index_2, index_3 });
            }

            return new Mesh2D(point2Ds, indexes);
        }

        public static Mesh2D Mesh2D(this IPolygonalFace2D polygonalFace2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            IPolygonal2D externalEdge = polygonalFace2D?.ExternalEdge;
            if(externalEdge == null)
            {
                return null;
            }

            List<IPolygonal2D> internalEdges = polygonalFace2D.InternalEdges;
            if(internalEdges == null || internalEdges.Count == 0)
            {
                List<Point2D> point2Ds = externalEdge.GetPoints();
                if(point2Ds == null || point2Ds.Count < 3)
                {
                    return null;
                }

                if (point2Ds.Count == 3)
                {
                    return new Mesh2D(point2Ds, new List<int[]> { new int[] { 0, 1, 2 } });
                }

                if(point2Ds.Count == 4)
                {
                    return new Mesh2D(point2Ds, new List<int[]> { new int[] { 0, 1, 2 } , new int[] { 2, 3 ,0 } });
                }
            }

            List<Polygon> polygons = polygonalFace2D.ToNTS()?.Triangulate(tolerance);
            if(polygons == null)
            {
                return null;
            }

            List<Triangle2D> triangle2Ds = new List<Triangle2D>();
            foreach(Polygon polygon in polygons)
            {
                List<Point2D> point2Ds = polygon?.ExteriorRing?.ToDiGi()?.GetPoints();
                if(point2Ds == null || point2Ds.Count < 3)
                {
                    continue;
                }

                triangle2Ds.Add(new Triangle2D(point2Ds[0], point2Ds[1], point2Ds[2]));
            }

            return Mesh2D(triangle2Ds, tolerance);

        }
    }

}

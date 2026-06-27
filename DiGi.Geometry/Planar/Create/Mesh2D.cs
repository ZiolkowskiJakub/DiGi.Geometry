using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Geometries;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a <see cref="Classes.Mesh2D"/> from a collection of <see cref="Triangle2D"/> objects.
        /// </summary>
        /// <param name="triangle2Ds">The <see cref="IEnumerable{T}"/> of <see cref="Triangle2D"/> objects to be converted into a mesh.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the minimum area threshold; triangles with an area smaller than this value are ignored.</param>
        /// <returns>A <see cref="Classes.Mesh2D"/> object if valid triangles are provided; otherwise, null.</returns>
        public static Mesh2D? Mesh2D(this IEnumerable<Triangle2D>? triangle2Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (triangle2Ds == null)
            {
                return null;
            }

            Triangle2D[] triangle2Ds_Cached = triangle2Ds as Triangle2D[] ?? triangle2Ds.ToArray();
            if (triangle2Ds_Cached.Length == 0)
            {
                return null;
            }

            List<Point2D> point2Ds = [];

            List<int[]> indices = [];

            // Spatial hash grid: points are bucketed by their tolerance-sized cell so lookups avoid an O(n) linear scan per point.
            Dictionary<(long X, long Y), List<int>> indexes_ByCell = [];

            int GetOrAddPointIndex(Point2D point2D_Triangle)
            {
                long cellX = (long)System.Math.Round(point2D_Triangle.X / tolerance);
                long cellY = (long)System.Math.Round(point2D_Triangle.Y / tolerance);

                for (long x = cellX - 1; x <= cellX + 1; x++)
                {
                    for (long y = cellY - 1; y <= cellY + 1; y++)
                    {
                        if (indexes_ByCell.TryGetValue((x, y), out List<int>? indexes_Cell) && indexes_Cell != null)
                        {
                            foreach (int index_Cell in indexes_Cell)
                            {
                                if (Query.AlmostEquals(point2Ds[index_Cell], point2D_Triangle, tolerance))
                                {
                                    return index_Cell;
                                }
                            }
                        }
                    }
                }

                int index_New = point2Ds.Count;
                point2Ds.Add(point2D_Triangle);

                (long X, long Y) cell = (cellX, cellY);
                if (!indexes_ByCell.TryGetValue(cell, out List<int>? indexes_New))
                {
                    indexes_New = [];
                    indexes_ByCell[cell] = indexes_New;
                }
                indexes_New.Add(index_New);

                return index_New;
            }

            foreach (Triangle2D triangle2D in triangle2Ds_Cached)
            {
                if (triangle2D == null || triangle2D.GetArea() < tolerance)
                {
                    continue;
                }

                List<Point2D>? point2Ds_Triangle = triangle2D.GetPoints();
                if (point2Ds_Triangle == null || point2Ds_Triangle.Count < 3)
                {
                    continue;
                }

                int index_1 = GetOrAddPointIndex(point2Ds_Triangle[0]);
                int index_2 = GetOrAddPointIndex(point2Ds_Triangle[1]);
                int index_3 = GetOrAddPointIndex(point2Ds_Triangle[2]);

                indices.Add([index_1, index_2, index_3]);
            }

            return new Mesh2D(point2Ds, indices);
        }

        /// <summary>
        /// Converts an <see cref="IPolygonalFace2D"/> to a <see cref="Classes.Mesh2D"/>.
        /// </summary>
        /// <param name="polygonalFace2D">The <see cref="IPolygonalFace2D"/> instance to convert.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used for the conversion.</param>
        /// <returns>A <see cref="Classes.Mesh2D"/> object if the conversion is successful; otherwise, <c>null</c>.</returns>
        public static Mesh2D? Mesh2D(this IPolygonalFace2D? polygonalFace2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            IPolygonal2D? externalEdge = polygonalFace2D?.ExternalEdge;
            if (externalEdge == null)
            {
                return null;
            }

            List<IPolygonal2D>? internalEdges = polygonalFace2D!.InternalEdges;
            if (internalEdges == null || internalEdges.Count == 0)
            {
                List<Point2D>? point2Ds = externalEdge.GetPoints();
                if (point2Ds == null || point2Ds.Count < 3)
                {
                    return null;
                }

                if (point2Ds.Count == 3)
                {
                    return new Mesh2D(point2Ds, [[0, 1, 2]]);
                }

                if (point2Ds.Count == 4)
                {
                    return new Mesh2D(point2Ds, [[0, 1, 2], [2, 3, 0]]);
                }
            }

            List<Polygon>? polygons = polygonalFace2D.ToNTS()?.Triangulate(tolerance);
            if (polygons == null)
            {
                return null;
            }

            List<Triangle2D> triangle2Ds = [];
            foreach (Polygon polygon in polygons)
            {
                List<Point2D>? point2Ds = polygon?.ExteriorRing?.ToDiGi()?.GetPoints();
                if (point2Ds == null || point2Ds.Count < 3)
                {
                    continue;
                }

                triangle2Ds.Add(new(point2Ds[0], point2Ds[1], point2Ds[2]));
            }

            return Mesh2D(triangle2Ds, tolerance);
        }
    }
}
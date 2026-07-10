using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Geometries;
using NetTopologySuite.Geometries.Utilities;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Computes the geometric union of a collection of 2D polygonal faces.
        /// </summary>
        /// <param name="polygonalFace2Ds">The collection of polygonal faces to be unioned.</param>
        /// <returns>A list containing the resulting unioned polygonal faces, or <c>null</c> if the input is null or no result could be produced.</returns>
        public static List<PolygonalFace2D>? Union(this IEnumerable<IPolygonalFace2D>? polygonalFace2Ds)
        {
            if (polygonalFace2Ds == null)
            {
                return null;
            }

            List<Polygon>? polygons = [];
            foreach (IPolygonalFace2D polygonalFace2D in polygonalFace2Ds)
            {
                Polygon? polygon = polygonalFace2D?.ToNTS();
                if (polygon == null)
                {
                    continue;
                }

                polygons.Add(polygon);
            }

            polygons = Union(polygons);

            if (polygons == null)
            {
                return null;
            }

            List<PolygonalFace2D> polygonalFace2Ds_Result = [];
            for (int i = 0; i < polygons.Count; i++)
            {
                PolygonalFace2D? polygonalFace2D = polygons[i].ToDiGi();
                if (polygonalFace2D is null)
                {
                    continue;
                }

                polygonalFace2Ds_Result.Add(polygonalFace2D);
            }

            return polygonalFace2Ds_Result;
        }

        /// <summary>
        /// Calculates the geometric union of two polygonal faces.
        /// </summary>
        /// <remarks>
        /// The computation is delegated to <see cref="Create.UnionResult2D(IPolygonalFace2D?, IPolygonalFace2D?)"/>; the polygonal faces of the result are returned.
        /// </remarks>
        /// <param name="polygonalFace2D_1">The first polygonal face to unify.</param>
        /// <param name="polygonalFace2D_2">The second polygonal face to unify.</param>
        /// <returns>A list of <see cref="PolygonalFace2D"/> objects representing the resulting union, or <c>null</c> if either input is null.</returns>
        public static List<PolygonalFace2D>? Union(this IPolygonalFace2D? polygonalFace2D_1, IPolygonalFace2D? polygonalFace2D_2)
        {
            if (polygonalFace2D_1 == null || polygonalFace2D_2 == null)
            {
                return null;
            }

            UnionResult2D? unionResult2D = Create.UnionResult2D(polygonalFace2D_1, polygonalFace2D_2);
            if (unionResult2D == null)
            {
                return null;
            }

            return unionResult2D.GetGeometry2Ds<PolygonalFace2D>() ?? [];
        }

        /// <summary>
        /// Calculates the geometric union of a collection of polygons.
        /// </summary>
        /// <param name="polygons">The collection of <see cref="Polygon"/> objects to unify.</param>
        /// <returns>A list of <see cref="Polygon"/> objects representing the resulting union, or <c>null</c> if the input is null or an error occurs during processing.</returns>
        public static List<Polygon>? Union(this IEnumerable<Polygon>? polygons)
        {
            if (polygons == null)
                return null;

            List<Polygon> polygons_Result = [];

            // Avoid multiple enumerations
            List<Polygon> polygons_List = polygons as List<Polygon> ?? [.. polygons];

            if (polygons_List.Count == 0)
            {
                return polygons_Result;
            }

            if (polygons_List.Count == 1)
            {
                // Only short-circuit when the single polygon is already valid; a null or invalid
                // (self-intersecting) one must fall through to the repair path below so Union never
                // returns an invalid polygon (consistent with the multi-polygon case).
                Polygon polygon_Single = polygons_List[0];
                if (polygon_Single != null && polygon_Single.IsValid)
                {
                    polygons_Result.Add(polygon_Single);
                    return polygons_Result;
                }
            }

            // Fix invalid input geometries individually first (much faster than fixing the collection)
            List<Polygon> validPolygons = [];
            foreach (Polygon polygon in polygons_List)
            {
                if (polygon == null)
                {
                    continue;
                }

                if (!polygon.IsValid)
                {
                    NetTopologySuite.Geometries.Geometry geometry_Fixed = GeometryFixer.Fix(polygon);
                    if (geometry_Fixed is Polygon polygon_Fixed && !polygon_Fixed.IsEmpty)
                    {
                        validPolygons.Add(polygon_Fixed);
                    }
                    else if (geometry_Fixed is MultiPolygon multiPolygon_Fixed && !multiPolygon_Fixed.IsEmpty)
                    {
                        foreach (Polygon childPolygon in multiPolygon_Fixed.Geometries.Cast<Polygon>())
                        {
                            if (childPolygon != null && !childPolygon.IsEmpty)
                            {
                                validPolygons.Add(childPolygon);
                            }
                        }
                    }
                }
                else
                {
                    validPolygons.Add(polygon);
                }
            }

            if (validPolygons.Count == 0)
            {
                return polygons_Result;
            }

            NetTopologySuite.Geometries.Geometry? geometry;
            try
            {
                geometry = NetTopologySuite.Operation.Union.UnaryUnionOp.Union(validPolygons);
            }
            catch
            {
                return null;
            }

            if (geometry == null || geometry.IsEmpty)
            {
                return polygons_Result;
            }

            if (geometry is MultiPolygon multiPolygon)
            {
                return [.. multiPolygon.Geometries.Cast<Polygon>()];
            }

            if (geometry is Polygon polygonResult)
            {
                polygons_Result.Add(polygonResult);
                return polygons_Result;
            }

            if (geometry is GeometryCollection geometryCollection)
            {
                foreach (NetTopologySuite.Geometries.Geometry geometry_Temp in geometryCollection.Geometries)
                {
                    if (geometry_Temp is Polygon polygon_Temp)
                    {
                        polygons_Result.Add(polygon_Temp);
                    }
                    else if (geometry_Temp is MultiPolygon multiPolygon_Temp)
                    {
                        polygons_Result.AddRange(multiPolygon_Temp.Geometries.Cast<Polygon>());
                    }
                }
                return polygons_Result;
            }

            return polygons_Result;
        }

        /// <summary>
        /// Calculates the union of a collection of polygonal geometries.
        /// </summary>
        /// <typeparam name="TPolygonal2D">The type of polygonal geometry, which must implement <see cref="IPolygonal2D"/>.</typeparam>
        /// <param name="polygonal2Ds">A collection of polygonal geometries to be united.</param>
        /// <returns>A list of <see cref="Polygon2D"/> objects representing the unioned result, or <see langword="null"/> if the input collection is null.</returns>
        public static List<Polygon2D>? Union<TPolygonal2D>(this IEnumerable<TPolygonal2D>? polygonal2Ds) where TPolygonal2D : IPolygonal2D
        {
            if (polygonal2Ds == null)
            {
                return null;
            }

            IReadOnlyList<TPolygonal2D> polygonal2Ds_List = polygonal2Ds as IReadOnlyList<TPolygonal2D> ?? [.. polygonal2Ds];
            int count = polygonal2Ds_List.Count;

            List<Polygon2D> polygon2Ds_Result = [];

            if (count == 0)
            {
                return polygon2Ds_Result;
            }

            if (count == 1)
            {
                polygon2Ds_Result.Add(new Polygon2D(polygonal2Ds_List[0]));
                return polygon2Ds_Result;
            }

            List<Polygon>? polygons = [];
            foreach (TPolygonal2D polygonal2D in polygonal2Ds_List)
            {
                if (polygonal2D?.ToNTS_Polygon() is not Polygon polygon)
                {
                    continue;
                }

                polygons.Add(polygon);
            }

            polygons = Union(polygons);
            if (polygons == null)
            {
                return null;
            }

            for (int i = 0; i < polygons.Count; i++)
            {
                IPolygonal2D? polygonal2D = polygons[i]?.ToDiGi()?.ExternalEdge;
                if (polygonal2D == null)
                {
                    continue;
                }

                polygon2Ds_Result.Add(new(polygonal2D));
            }

            return polygon2Ds_Result;
        }

        /// <summary>
        /// Calculates the union of two 2D polygons.
        /// </summary>
        /// <param name="polygon2D_1">The first polygon to include in the union operation.</param>
        /// <param name="polygon2D_2">The second polygon to include in the union operation.</param>
        /// <returns>A list of <see cref="Polygon2D"/> objects representing the resulting union, or <c>null</c> if either input polygon is <c>null</c>.</returns>
        public static List<Polygon2D>? Union(this Polygon2D? polygon2D_1, Polygon2D? polygon2D_2)
        {
            if (polygon2D_1 == null || polygon2D_2 == null)
            {
                return null;
            }

            BoundingBox2D? boundingBox2D_1 = polygon2D_1.GetBoundingBox();
            BoundingBox2D? boundingBox2D_2 = polygon2D_2.GetBoundingBox();
            if (boundingBox2D_1 != null && boundingBox2D_2 != null && !boundingBox2D_1.InRange(boundingBox2D_2))
            {
                return [new Polygon2D(polygon2D_1), new Polygon2D(polygon2D_2)];
            }

            return Union([polygon2D_1, polygon2D_2]);
        }
    }
}
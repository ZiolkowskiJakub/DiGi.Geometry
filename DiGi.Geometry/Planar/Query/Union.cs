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

            List<PolygonalFace2D> result = [];
            for (int i = 0; i < polygons.Count; i++)
            {
                PolygonalFace2D? polygonalFace2D = polygons[i].ToDiGi();
                if (polygonalFace2D is null)
                {
                    continue;
                }

                result.Add(polygonalFace2D);
            }

            return result;
        }

        /// <summary>
        /// Calculates the geometric union of two polygonal faces.
        /// </summary>
        /// <param name="polygonalFace2D_1">The first polygonal face to unify.</param>
        /// <param name="polygonalFace2D_2">The second polygonal face to unify.</param>
        /// <returns>A list of <see cref="PolygonalFace2D"/> objects representing the resulting union, or <c>null</c> if either input is null.</returns>
        public static List<PolygonalFace2D>? Union(this IPolygonalFace2D? polygonalFace2D_1, IPolygonalFace2D? polygonalFace2D_2)
        {
            if (polygonalFace2D_1 == null || polygonalFace2D_2 == null)
            {
                return null;
            }

            BoundingBox2D? boundingBox2D_1 = polygonalFace2D_1.GetBoundingBox();
            BoundingBox2D? boundingBox2D_2 = polygonalFace2D_2.GetBoundingBox();
            if (boundingBox2D_1 != null && boundingBox2D_2 != null && !boundingBox2D_1.InRange(boundingBox2D_2))
            {
                List<PolygonalFace2D> polygonalFace2Ds_Disjoint = [];
                if (polygonalFace2D_1 is PolygonalFace2D PolygonalFace2D_1_Temp)
                {
                    polygonalFace2Ds_Disjoint.Add(new PolygonalFace2D(PolygonalFace2D_1_Temp));
                }
                else
                {
                    PolygonalFace2D? face1Converted = polygonalFace2D_1.ToNTS().ToDiGi();
                    if (face1Converted != null) polygonalFace2Ds_Disjoint.Add(face1Converted);
                }

                if (polygonalFace2D_2 is PolygonalFace2D PolygonalFace2D_2_Temp)
                {
                    polygonalFace2Ds_Disjoint.Add(new PolygonalFace2D(PolygonalFace2D_2_Temp));
                }
                else
                {
                    PolygonalFace2D? polygonalFace2D_Converted = polygonalFace2D_2.ToNTS().ToDiGi();
                    if (polygonalFace2D_Converted != null)
                    {
                        polygonalFace2Ds_Disjoint.Add(polygonalFace2D_Converted);
                    }
                }

                return polygonalFace2Ds_Disjoint;
            }

            return Union([polygonalFace2D_1, polygonalFace2D_2]);
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

            List<Polygon> result = [];

            // Avoid multiple enumerations
            List<Polygon> polygons_List = polygons as List<Polygon> ?? [.. polygons];

            if (polygons_List.Count == 0)
            {
                return result;
            }

            if (polygons_List.Count == 1)
            {
                result.Add(polygons_List[0]);
                return result;
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
                return result;
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
                return result;
            }

            if (geometry is MultiPolygon multiPolygon)
            {
                return [.. multiPolygon.Geometries.Cast<Polygon>()];
            }

            if (geometry is Polygon polygonResult)
            {
                result.Add(polygonResult);
                return result;
            }

            if (geometry is GeometryCollection geometryCollection)
            {
                foreach (NetTopologySuite.Geometries.Geometry geometry_Temp in geometryCollection.Geometries)
                {
                    if (geometry_Temp is Polygon polygon_Temp)
                    {
                        result.Add(polygon_Temp);
                    }
                    else if (geometry_Temp is MultiPolygon multiPolygon_Temp)
                    {
                        result.AddRange(multiPolygon_Temp.Geometries.Cast<Polygon>());
                    }
                }
                return result;
            }

            return result;
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

            int count = polygonal2Ds.Count();

            List<Polygon2D> result = [];

            if (count == 0)
            {
                return result;
            }

            if (count == 1)
            {
                result.Add(new Polygon2D(polygonal2Ds.ElementAt(0)));
                return result;
            }

            List<Polygon>? polygons = [];
            foreach (TPolygonal2D polygonal2D in polygonal2Ds)
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

                result.Add(new(polygonal2D));
            }

            return result;
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
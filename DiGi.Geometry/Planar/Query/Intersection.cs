using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using NetTopologySuite.Geometries;
using NetTopologySuite.Geometries.Utilities;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static List<PolygonalFace2D>? Intersection(this PolygonalFace2D? polygonalFace2D_1, PolygonalFace2D? polygonalFace2D_2)
        {
            if (polygonalFace2D_1 == null || polygonalFace2D_2 == null)
            {
                return null;
            }

            Polygon? polygon_1 = polygonalFace2D_1.ToNTS();
            if (polygon_1 == null)
            {
                return null;
            }

            Polygon? polygon_2 = polygonalFace2D_2.ToNTS();
            if (polygon_2 == null)
            {
                return null;
            }

            List<PolygonalFace2D>? result = [];

            if (polygon_1.EqualsTopologically(polygon_2))
            {
                return result;
            }

            NetTopologySuite.Geometries.Geometry geometry_1 = polygon_1;
            if (!geometry_1.IsValid)
            {
                geometry_1 = GeometryFixer.Fix(geometry_1);
            }

            NetTopologySuite.Geometries.Geometry geometry_2 = polygon_2;
            if (!geometry_2.IsValid)
            {
                geometry_2 = GeometryFixer.Fix(geometry_2);
            }

            NetTopologySuite.Geometries.Geometry? geometry;
            try
            {
                geometry = geometry_1.Intersection(geometry_2);
            }
            catch
            {
                return null;
            }

            if (geometry == null || geometry.IsEmpty)
            {
                return result;
            }

            List<NetTopologySuite.Geometries.Geometry>? geometries = geometry is GeometryCollection geometryCollection ? geometryCollection.Geometries?.ToList() : [geometry];
            if (geometries == null || geometries.Count == 0)
            {
                return null;
            }

            foreach (NetTopologySuite.Geometries.Geometry geometry_Temp in geometries)
            {
                if (geometry_Temp is Polygon polygon)
                {
                    PolygonalFace2D? polygonalFace2D = polygon.ToDiGi();
                    if (polygonalFace2D != null)
                    {
                        result.Add(polygonalFace2D);
                    }
                }
                else if (geometry_Temp is MultiPolygon multiPolygon)
                {
                    List<PolygonalFace2D>? polygonalFace2Ds = multiPolygon.ToDiGi_PolygonalFace2Ds();
                    if (polygonalFace2Ds != null && polygonalFace2Ds.Count > 0)
                    {
                        result.AddRange(polygonalFace2Ds);
                    }
                }
                else if (geometry_Temp is LinearRing linearRing)
                {
                    Polygon2D? polygon2D = linearRing.ToDiGi();
                    if (polygon2D != null)
                    {
                        result.Add(new PolygonalFace2D(polygon2D));
                    }
                }
            }

            return result;
        }

        public static List<X>? Intersection<X, T>(this IEnumerable<T>? polygonal2Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance) where T : IPolygonal2D where X : IPolygonal2D
        {
            if (polygonal2Ds == null)
            {
                return null;
            }

            List<Polygon> polygons = [];

            foreach(T polygonal2D in polygonal2Ds)
            {
                if(polygonal2D.ToNTS_Polygon() is Polygon polygon)
                {
                    polygons.Add(polygon);
                }
            }

            if(polygons is null || polygons.Count == 0)
            {
                return []; 
            }

            NetTopologySuite.Geometries.Geometry geometry = polygons[0];

            if (polygons.Count > 1)
            {
                for (int i = 1; i < polygons.Count; i++)
                {
                    // Intersect current result with the next polygon
                    geometry = geometry.Intersection(polygons[i]);

                    // Optimization: if at any point the intersection is empty, 
                    // there is no common area for the whole set.
                    if (geometry == null || geometry.IsEmpty)
                    {
                        return [];
                    }
                }
            }


            if (geometry.ToDiGi() is not IGeometry2D geometry2D)
            {
                return null;
            }

            if (geometry2D is not GeometryCollection2D geometryCollection2D)
            {
                if(geometry2D is ICollectable2D collectable2D)
                {
                    if(geometry2D is IPolygonalFace2D polygonalFace2D)
                    {
                        if(polygonalFace2D.Edges is List<IPolygonal2D> polygonal2Ds_Temp)
                        {
                            geometryCollection2D = [.. polygonalFace2D.Edges];
                        }
                        else
                        {
                            return [];
                        }
                    }
                    else
                    {
                        geometryCollection2D = [collectable2D];
                    }
                }
                else
                {
                    return null;
                }
            }

            if(geometryCollection2D is null || geometryCollection2D.Count == 0)
            {
                return [];
            }

            List<X> result = [];
            foreach (ICollectable2D collectable2D in geometryCollection2D)
            {
                if (collectable2D is X x)
                {
                    return [x];
                }

                if (collectable2D is IPolygonal2D polygonal2D_Temp)
                {
                    if (TryConvert(polygonal2D_Temp, out List<X>? polygonal2Ds_Temp, tolerance) && polygonal2Ds_Temp is not null)
                    {
                        result.AddRange(polygonal2Ds_Temp);
                    }
                }

                throw new System.NotImplementedException();
            }

            return result;
        }

        public static List<Polygon2D>? Interscetion(this Polygon2D? polygon2D_1, Polygon2D? polygon2D_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if(polygon2D_1 is null || polygon2D_2 is null)
            {
                return null;
            }

            return Interscetion([polygon2D_1, polygon2D_2], tolerance);
        }

        public static List<Polygon2D>? Interscetion(this IEnumerable<Polygon2D>? polygon2Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            return Intersection<Polygon2D, Polygon2D>(polygon2Ds, tolerance);
        }
    }
}
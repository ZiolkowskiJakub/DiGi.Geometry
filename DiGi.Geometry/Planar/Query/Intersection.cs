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

        public static List<X>? Intersection<T, X>(this IEnumerable<T>? polygon2Ds, double tolerance = DiGi.Core.Constans.Tolerance.Distance) where T : IPolygonal2D where X : IPolygonal2D
        {
            if (polygon2Ds == null)
            {
                return null;
            }

            List<Segment2D> segment2Ds = [];
            foreach (IPolygonal2D polygonal2D in polygon2Ds)
            {
                List<Segment2D>? segment2Ds_Temp = polygonal2D?.GetSegments();
                if (segment2Ds_Temp == null || segment2Ds_Temp.Count == 0)
                {
                    continue;
                }

                segment2Ds.AddRange(segment2Ds_Temp);
            }

            List<Polygon2D>? polygon2Ds_Temp = Create.Polygon2Ds(segment2Ds, tolerance);
            if (polygon2Ds_Temp == null || polygon2Ds_Temp.Count == 0)
            {
                return null;
            }

            List<X> result = [];
            foreach (Polygon2D polygon2D in polygon2Ds_Temp)
            {
                X? x = default;
                if (polygon2D is X)
                {
                    x = (X)(object)polygon2D;
                }
                else
                {
                    IPolygonal2D? polygonal2D = Create.Polygonal2D(polygon2D, tolerance);
                    if (polygonal2D is X)
                    {
                        x = (X)(object)polygonal2D;
                    }
                }

                if (x == null)
                {
                    continue;
                }

                result.Add(x);
            }

            return result;
        }
    }
}
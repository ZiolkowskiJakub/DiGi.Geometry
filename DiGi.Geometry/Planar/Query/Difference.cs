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
        public static List<IPolygonal2D>? Difference(this IPolygonal2D? polygonal2D_1, IPolygonal2D? polygonal2D_2)
        {
            if (polygonal2D_1 == null || polygonal2D_2 == null)
            {
                return null;
            }

            List<PolygonalFace2D>? polygonalFace2Ds = Difference(new PolygonalFace2D(polygonal2D_1), new PolygonalFace2D(polygonal2D_2));
            if(polygonalFace2Ds is null)
            {
                return null;
            }

            List<IPolygonal2D> result = [];
            foreach(PolygonalFace2D polygonalFace2D in polygonalFace2Ds)
            {
                if(polygonalFace2D.ExternalEdge is IPolygonal2D externalEdge)
                {
                    result.Add(externalEdge);
                }

                if(polygonalFace2D.InternalEdges is not List<IPolygonal2D> internalEdges)
                {
                    continue;
                }

                foreach(IPolygonal2D internalEdge in internalEdges)
                {
                    if(internalEdge is not null)
                    {
                        result.Add(internalEdge);
                    }
                }
            }

            return result;
        }

        public static List<PolygonalFace2D>? Difference(this PolygonalFace2D? polygonalFace2D_1, PolygonalFace2D? polygonalFace2D_2)
        {
            if(polygonalFace2D_1 == null || polygonalFace2D_2 == null)
            {
                return null;
            }

            Polygon? polygon_1 = polygonalFace2D_1.ToNTS();
            if(polygon_1 == null)
            {
                return null;
            }

            Polygon? polygon_2 = polygonalFace2D_2.ToNTS();
            if(polygon_2 == null)
            {
                return null;
            }

            List<Polygon>? polygons = Difference(polygon_1, polygon_2);
            if(polygons == null)
            {
                return null;
            }

            List<PolygonalFace2D> result = [];
            foreach(Polygon polygon in polygons)
            {
                if(polygon.ToDiGi() is PolygonalFace2D polygonalFace2D)
                {
                    result.Add(polygonalFace2D);
                }
            }

            return result;
        }

        public static List<Polygon>? Difference(this Polygon? polygon_1, Polygon? polygon_2)
        {
            if(polygon_1 is null || polygon_2 is null)
            {
                return null;
            }

            List<Polygon> result = [];

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
                geometry = geometry_1.Difference(geometry_2);
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
                    result.Add(polygon);
                }
                else if (geometry_Temp is MultiPolygon multiPolygon)
                {
                    List<Polygon>? polygons = Create.Polygons(multiPolygon);
                    if(polygons != null)
                    {
                        result.AddRange(polygons);
                    }
                }
                else if (geometry_Temp is LinearRing linearRing)
                {
                    result.Add(new Polygon(linearRing));
                }
            }

            return result;

        }
    }
}

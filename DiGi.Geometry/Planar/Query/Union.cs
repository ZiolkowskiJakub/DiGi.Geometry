using NetTopologySuite.Geometries.Utilities;
using NetTopologySuite.Geometries;
using System.Collections.Generic;
using System.Linq;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static List<IPolygonalFace2D>? Union(this IEnumerable<IPolygonalFace2D>? polygonalFace2Ds)
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

            List<IPolygonalFace2D> result = [];
            for(int i=0; i < polygons.Count; i++)
            {
                PolygonalFace2D? polygonalFace2D = polygons[i].ToDiGi();
                if(polygonalFace2D is null)
                {
                    continue;
                }

                result.Add(polygonalFace2D);
            }

            return result;
        }

        public static List<IPolygonalFace2D>? Union(this IPolygonalFace2D? polygonalFace2D_1, IPolygonalFace2D? polygonalFace2D_2)
        {
            if(polygonalFace2D_1 == null || polygonalFace2D_2 == null)
            {
                return null;
            }

            return Union([polygonalFace2D_1, polygonalFace2D_2]);
        }

        public static List<Polygon>? Union(this IEnumerable<Polygon>? polygons)
        {
            if (polygons == null)
                return null;

            List<Polygon> result = [];
            if (polygons.Count() == 0)
            {
                return result;
            }

            if (polygons.Count() == 1)
            {
                result.Add(polygons.ElementAt(0));
                return result;
            }

            NetTopologySuite.Geometries.Geometry geometry = new MultiPolygon([.. polygons]);
            if (!geometry.IsValid)
            {
                try
                {
                    geometry = GeometryFixer.Fix(geometry);
                }
                catch
                {
                    return null;
                }
            }

            try
            {
                geometry = geometry.Union();
            }
            catch
            {

            }

            if (geometry == null)
            {
                return null;
            }

            if (geometry is MultiPolygon multiPolygon)
            {
                return [.. multiPolygon.Geometries.Cast<Polygon>()];
            }

            if (geometry is Polygon polygon)
            {
                result.Add(polygon);
            }

            return result;
        }

        public static List<Polygon2D>? Union(this IEnumerable<Polygon2D>? polygon2Ds)
        {
            if(polygon2Ds == null)
            {
                return null;
            }

            int count = polygon2Ds.Count();

            List<Polygon2D> result = [];

            if(count == 0)
            {
                return result;
            }

            if(count == 1)
            {
                result.Add(new Polygon2D(polygon2Ds.ElementAt(0)));
                return result;
            }

            List<Polygon>? polygons = [];
            foreach(Polygon2D polygon2D in polygon2Ds)
            {
                Polygon? polygon = polygon2D?.ToNTS_Polygon();
                if(polygon == null)
                {
                    continue;
                }

                polygons.Add(polygon);
            }

            polygons = Union(polygons);
            if(polygons == null)
            {
                return null;
            }

            for(int i = 0; i < polygons.Count; i++)
            {
                IPolygonal2D? polygonal2D = polygons[i]?.ToDiGi()?.ExternalEdge;
                if(polygonal2D == null)
                {
                    continue;
                }

                result.Add(new (polygonal2D));
            }

            return result;
        }

        public static List<Polygon2D>? Union(this Polygon2D? polygon2D_1, Polygon2D? polygon2D_2)
        {
            if (polygon2D_1 == null || polygon2D_2 == null)
            {
                return null;
            }

            return Union([polygon2D_1, polygon2D_2]);
        }
    }
}

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
        public static List<IPolygonalFace2D> Union(this IEnumerable<IPolygonalFace2D> polygonalFace2Ds)
        {
            if (polygonalFace2Ds == null)
            {
                return null;
            }

            List<Polygon> polygons = new List<Polygon>();
            foreach (PolygonalFace2D polygonalFace2D in polygonalFace2Ds)
            {
                Polygon polygon = polygonalFace2D?.ToNTS();
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

            List<IPolygonalFace2D> result = new List<IPolygonalFace2D>();
            for(int i=0; i < polygons.Count; i++)
            {
                result.Add(polygons[i].ToDiGi());
            }

            return result;
        }

        public static List<IPolygonalFace2D> Union(this IPolygonalFace2D polygonalFace2D_1, IPolygonalFace2D polygonalFace2D_2)
        {
            if(polygonalFace2D_1 == null || polygonalFace2D_2 == null)
            {
                return null;
            }

            return Union(new IPolygonalFace2D[] { polygonalFace2D_1, polygonalFace2D_2 });
        }

        public static List<Polygon> Union(this IEnumerable<Polygon> polygons)
        {
            if (polygons == null)
                return null;

            List<Polygon> result = new List<Polygon>();
            if (polygons.Count() == 0)
            {
                return result;
            }

            if (polygons.Count() == 1)
            {
                result.Add(polygons.ElementAt(0));
                return result;
            }

            NetTopologySuite.Geometries.Geometry geometry = new MultiPolygon(polygons.ToArray());
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

            if (geometry is MultiPolygon)
            {
                return ((MultiPolygon)geometry).Geometries.Cast<Polygon>().ToList();
            }

            if (geometry is Polygon)
            {
                result.Add((Polygon)geometry);
            }

            return result;
        }

        public static List<Polygon2D> Union(this IEnumerable<Polygon2D> polygon2Ds)
        {
            if(polygon2Ds == null)
            {
                return null;
            }

            int count = polygon2Ds.Count();

            List<Polygon2D> result = new List<Polygon2D>();

            if(count == 0)
            {
                return result;
            }

            if(count == 1)
            {
                result.Add(new Polygon2D(polygon2Ds.ElementAt(0)));
                return result;
            }

            List<Polygon> polygons = new List<Polygon>();
            foreach(Polygon2D polygon2D in polygon2Ds)
            {
                polygons.Add(polygon2D.ToNTS_Polygon());
            }

            polygons = Union(polygons);
            if(polygons == null)
            {
                return null;
            }

            for(int i = 0; i < polygons.Count; i++)
            {
                IPolygonal2D polygonal2D = polygons[i]?.ToDiGi()?.ExternalEdge;
                if(polygonal2D == null)
                {
                    continue;
                }

                result.Add(new Polygon2D(polygonal2D));
            }

            return result;
        }

        public static List<Polygon2D> Union(this Polygon2D polygon2D_1, Polygon2D polygon2D_2)
        {
            if (polygon2D_1 == null || polygon2D_2 == null)
            {
                return null;
            }

            return Union(new Polygon2D[] { polygon2D_1, polygon2D_2 });
        }
    }
}

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
        public static List<SegmentableFace2D> Union(this IEnumerable<SegmentableFace2D> segmentableFace2Ds)
        {
            if (segmentableFace2Ds == null)
            {
                return null;
            }

            List<Polygon> polygons = new List<Polygon>();
            foreach (SegmentableFace2D segmentableFace2D in segmentableFace2Ds)
            {
                Polygon polygon = segmentableFace2D?.ToNTS();
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

            List<SegmentableFace2D> result = new List<SegmentableFace2D>();
            for(int i=0; i < polygons.Count; i++)
            {
                result.Add(polygons[i].ToDiGi());
            }

            return result;
        }

        public static List<SegmentableFace2D> Union(this SegmentableFace2D segmentableFace2D_1, SegmentableFace2D segmentableFace2D_2)
        {
            if(segmentableFace2D_1 == null || segmentableFace2D_2 == null)
            {
                return null;
            }

            return Union(new SegmentableFace2D[] { segmentableFace2D_1, segmentableFace2D_2 });
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
                geometry = GeometryFixer.Fix(geometry);
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
                IClosedSegmentable2D closedSegmentable2D = polygons[i]?.ToDiGi()?.ExternalCurve;
                if(closedSegmentable2D == null)
                {
                    continue;
                }

                result.Add(new Polygon2D(closedSegmentable2D));
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

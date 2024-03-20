using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static List<Polygon2D> ExternalPolygons<T>(this IEnumerable<T> segmentable2Ds, double maxDistance, double tolerance = DiGi.Core.Constans.Tolerance.Distance) where T : ISegmentable2D
        {
            List<Segment2D> segment2Ds = segmentable2Ds?.Segments();
            if(segment2Ds == null)
            {
                return null;
            }

            if(maxDistance != 0)
            {
                for (int i = 0; i < segment2Ds.Count; i++)
                {
                    segment2Ds[i] = segment2Ds[i]?.Extend(maxDistance);
                }
            }

            return ExternalPolygons(segment2Ds, tolerance);
        }

        public static List<Polygon2D> ExternalPolygons<T>(this IEnumerable<T> segmentable2Ds, double tolerance = DiGi.Core.Constans.Tolerance.Distance) where T: ISegmentable2D
        {
            return ExternalPolygons(segmentable2Ds?.Segments(), tolerance);
        }

        public static List<Polygon2D> ExternalPolygons(this IEnumerable<Segment2D> segment2Ds, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (segment2Ds == null)
            {
                return null;
            }

            List<Polygon2D> result = new List<Polygon2D>();

            List<PolygonalFace2D> polygonalFace2Ds = Create.PolygonalFace2Ds(segment2Ds, tolerance);
            if (polygonalFace2Ds == null || polygonalFace2Ds.Count == 0)
            {
                return result;
            }

            polygonalFace2Ds = polygonalFace2Ds.Union();
            if (polygonalFace2Ds == null || polygonalFace2Ds.Count == 0)
            {
                return result;
            }

            for (int i = 0; i < polygonalFace2Ds.Count; i++)
            {
                IPolygonal2D polygonal2D = polygonalFace2Ds[i]?.ExternalEdge;
                if (polygonal2D == null)
                {
                    continue;
                }

                result.Add(new Polygon2D(polygonal2D));
            }

            return result;
        }
    }
}

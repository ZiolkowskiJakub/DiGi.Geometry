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

            List<SegmentableFace2D> segmentableFace2Ds = Create.SegmentableFace2Ds(segment2Ds, tolerance);
            if (segmentableFace2Ds == null || segmentableFace2Ds.Count == 0)
            {
                return result;
            }

            segmentableFace2Ds = segmentableFace2Ds.Union();
            if (segmentableFace2Ds == null || segmentableFace2Ds.Count == 0)
            {
                return result;
            }

            for (int i = 0; i < segmentableFace2Ds.Count; i++)
            {
                IClosedSegmentable2D closedSegmentable2D = segmentableFace2Ds[i]?.ExternalCurve;
                if (closedSegmentable2D == null)
                {
                    continue;
                }

                result.Add(new Polygon2D(closedSegmentable2D));
            }

            return result;
        }
    }
}

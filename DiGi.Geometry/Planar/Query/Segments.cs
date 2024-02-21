using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static List<Segment2D> Segments<T>(this IEnumerable<T> segmentable2Ds) where T : ISegmentable2D
        {
            if (segmentable2Ds == null)
            {
                return null;
            }

            List<Segment2D> result = new List<Segment2D>();
            foreach (T segmentable2D in segmentable2Ds)
            {
                List<Segment2D> segment2Ds = segmentable2D?.GetSegments();
                if (segment2Ds == null || segment2Ds.Count == 0)
                {
                    continue;
                }

                for (int i = 0; i < segment2Ds.Count; i++)
                {
                    result.Add(segment2Ds[i]);
                }
            }

            return result;
        }
    }
}

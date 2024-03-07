using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static List<Point2D> Points<T>(this IEnumerable<T> segmentable2Ds) where T : ISegmentable2D
        {
            if (segmentable2Ds == null)
            {
                return null;
            }

            List<Point2D> result = new List<Point2D>();
            foreach (T segmentable2D in segmentable2Ds)
            {
                List<Point2D> point2Ds = segmentable2D?.GetPoints();
                if (point2Ds == null || point2Ds.Count == 0)
                {
                    continue;
                }

                for (int i = 0; i < point2Ds.Count; i++)
                {
                    result.Add(point2Ds[i]);
                }
            }

            return result;
        }
    }
}

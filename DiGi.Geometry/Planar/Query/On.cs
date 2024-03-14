using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static bool On(this ISegmentable2D segmentable2D, Point2D point2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            return On(segmentable2D?.GetSegments(), point2D, tolerance);
        }

        public static bool On(this IEnumerable<Segment2D> segment2Ds, Point2D point2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(point2D == null || segment2Ds == null)
            {
                return false;
            }

            foreach(Segment2D segment2D in segment2Ds)
            {
                if(segment2D == null)
                {
                    continue;
                }

                if(segment2D.On(point2D, tolerance))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool On<T>(this IEnumerable<T> segmentable2Ds, Point2D point2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance) where T: ISegmentable2D
        {
            if(point2D == null || segmentable2Ds == null || segmentable2Ds.Count() == 0)
            {
                return false;
            }

            return On(segmentable2Ds?.Segments(), point2D, tolerance);
        }
    }

}

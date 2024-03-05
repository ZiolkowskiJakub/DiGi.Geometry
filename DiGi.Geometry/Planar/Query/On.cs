using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static bool On(this Point2D point2D, ISegmentable2D segmentable2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            return On(point2D, segmentable2D?.GetSegments(), tolerance);
        }

        public static bool On(this Point2D point2D, IEnumerable<Segment2D> segment2Ds, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
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

        public static bool On<T>(this Point2D point2D, IEnumerable<T> segmentable2Ds, double tolerance = DiGi.Core.Constans.Tolerance.Distance) where T: ISegmentable2D
        {
            if(point2D == null || segmentable2Ds == null || segmentable2Ds.Count() == 0)
            {
                return false;
            }

            return On(point2D, segmentable2Ds?.Segments(), tolerance);
        }
    }

}

using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static double Distance(this Point2D point2D, ISegmentable2D segmentable2D)
        {
            return Distance(point2D, segmentable2D?.GetSegments(), out Point2D closetPoint2D);
        }

        public static double Distance(this Point2D point2D, IEnumerable<Segment2D> segment2Ds, out Point2D closetPoint2D)
        {
            closetPoint2D = ClosestPoint(point2D, segment2Ds, out double result);
            return result;
        }

        public static double Distance(this Point2D point2D, IEnumerable<Segment2D> segment2Ds)
        {
            return Distance(point2D, segment2Ds, out Point2D closetPoint2D);
        }

        public static double Distance<T>(this Point2D point2D, IEnumerable<T> segmentable2Ds, out Point2D closetPoint2D) where T: ISegmentable2D
        {
            closetPoint2D = null;
            if(point2D == null || segmentable2Ds == null || segmentable2Ds.Count() == 0)
            {
                return double.NaN;
            }

            return Distance(point2D, segmentable2Ds?.Segments());
        }

        public static double Distance<T>(this Point2D point2D, IEnumerable<T> segmentable2Ds) where T: ISegmentable2D
        {
            return Distance(point2D, segmentable2Ds, out Point2D closetPoint2D);
        }
    }

}

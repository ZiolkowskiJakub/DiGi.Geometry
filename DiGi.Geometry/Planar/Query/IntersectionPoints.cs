using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static List<Point2D> IntersectionPoints(this IEnumerable<Segment2D> segment2Ds_1, IEnumerable<Segment2D> segment2Ds_2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            return IntersectionPoints(segment2Ds_1, segment2Ds_2, int.MaxValue, tolerance);
        }
        
        public static List<Point2D> IntersectionPoints(this ISegmentable2D segmentable2D, IEnumerable<Segment2D> segment2Ds, double tolerace = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(segmentable2D == null || segment2Ds == null)
            {
                return null;
            }

            return IntersectionPoints(segmentable2D.GetSegments(), segment2Ds, tolerace);
        }

        public static List<Point2D> IntersectionPoints(this ISegmentable2D segmentable2D_1, ISegmentable2D segmentable2D_2, double tolerace = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (segmentable2D_1 == null || segmentable2D_2 == null)
            {
                return null;
            }

            return IntersectionPoints(segmentable2D_1.GetSegments(), segmentable2D_2.GetSegments(), tolerace);
        }

        public static List<Point2D> IntersectionPoints<T>(this ISegmentable2D segmentable2D, IEnumerable<ISegmentable2D> segmentable2Ds, double tolerace = DiGi.Core.Constans.Tolerance.Distance) where T: ISegmentable2D
        {
            if(segmentable2D == null || segmentable2Ds == null)
            {
                return null;
            }

            return IntersectionPoints(segmentable2D.GetSegments(), segmentable2Ds.Segments(), tolerace);
        }

        public static List<Point2D> IntersectionPoints(this IEnumerable<Segment2D> segment2Ds_1, IEnumerable<Segment2D> segment2Ds_2, int maxCount, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(segment2Ds_1 == null || segment2Ds_2 == null || maxCount < 1)
            {
                return null;
            }

            int count_1 = segment2Ds_1.Count();
            if(count_1 == 0)
            {
                return null;
            }

            int count_2 = segment2Ds_2.Count();
            if(count_2 == 0)
            {
                return null;
            }

            List<Point2D> result = new List<Point2D>();
            for (int i = 0; i < count_1; i++)
            {
                Segment2D segment2D_1 = segment2Ds_1.ElementAt(i);
                if(segment2D_1 == null)
                {
                    continue;
                }

                for (int j = 0; j < count_2; j++)
                {
                    Segment2D segment2D_2 = segment2Ds_2.ElementAt(j);
                    if(segment2D_2 == null)
                    {
                        continue;
                    }

                    Point2D point2D = segment2D_1.IntersectionPoint(segment2D_2, tolerance);
                    if(point2D == null)
                    {
                        continue;
                    }

                    result.Add(point2D);
                    if(result.Count >= maxCount)
                    {
                        return result;
                    }
                }
            }

            return result;
        }

    }

}

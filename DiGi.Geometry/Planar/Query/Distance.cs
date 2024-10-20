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

        public static double Distance(ISegmentable2D segmentable2D_1, ISegmentable2D segmentable2D_2, out Point2D point2D_Closest1, out Point2D point2D_Closest2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            point2D_Closest1 = null;
            point2D_Closest2 = null;

            if (segmentable2D_1 == null || segmentable2D_2 == null)
            {
                return double.NaN;
            }

            List<Segment2D> segment2Ds_1 = segmentable2D_1.GetSegments();
            if (segment2Ds_1 == null || segment2Ds_1.Count == 0)
            {
                return double.NaN;
            }

            List<Segment2D> segment2Ds_2 = segmentable2D_2.GetSegments();
            if (segment2Ds_2 == null || segment2Ds_2.Count == 0)
            {
                return double.NaN;
            }

            double result = double.MaxValue;
            foreach (Segment2D segment2D_1 in segment2Ds_1)
            {
                foreach (Segment2D segment2D_2 in segment2Ds_2)
                {
                    Point2D point2D = IntersectionPoint(segment2D_1[0], segment2D_1[1], segment2D_2[0], segment2D_2[1], out Point2D point2D_Closest1_Temp, out Point2D point2D_Closest2_Temp, tolerance);
                    if(point2D_Closest1_Temp != null && point2D_Closest2_Temp != null)
                    {
                        double distance = point2D_Closest1_Temp.Distance(point2D_Closest2_Temp);
                        if (distance == 0)
                        {
                            return 0;
                        }

                        if (distance < result)
                        {
                            point2D_Closest1 = point2D_Closest1_Temp;
                            point2D_Closest2 = point2D_Closest2_Temp;
                            result = distance;
                        }
                    }

                    if(point2D != null)
                    {
                        point2D_Closest1 = point2D;
                        point2D_Closest2 = new Point2D(point2D);
                        return 0;
                    }
                }
            }

            if(result == double.MaxValue)
            {
                return double.NaN;
            }

            return result;
        }
    }

}

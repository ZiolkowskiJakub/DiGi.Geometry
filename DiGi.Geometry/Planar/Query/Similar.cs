using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static bool Similar(this Point2D point2D_1, Point2D point2D_2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            return AlmostEquals(point2D_1, point2D_2, tolerance);
        }

        public static bool Similar(this Segment2D segment2D_1, Segment2D segment2D_2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (segment2D_1 == segment2D_2)
            {
                return true;
            }

            if (segment2D_1 == null || segment2D_2 == null)
            {
                return false;
            }

            return (segment2D_1[0].AlmostEquals(segment2D_2[0], tolerance) && segment2D_1[1].AlmostEquals(segment2D_2[1], tolerance)) || (segment2D_1[0].AlmostEquals(segment2D_2[1], tolerance) && segment2D_1[1].AlmostEquals(segment2D_2[0], tolerance));
        }

        public static bool Similar(this ISegmentable2D segmentable2D_1, ISegmentable2D segmentable2D_2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (segmentable2D_1 == segmentable2D_2)
            {
                return true;
            }

            if (segmentable2D_1 == null || segmentable2D_2 == null)
            {
                return false;
            }

            List<Point2D> point2Ds = null;

            point2Ds = segmentable2D_1.GetPoints();
            foreach (Point2D point2D in point2Ds)
            {
                if (!segmentable2D_2.On(point2D, tolerance))
                {
                    return false;
                }
            }


            point2Ds = segmentable2D_2.GetPoints();
            foreach (Point2D point2D in point2Ds)
            {
                if (!segmentable2D_1.On(point2D, tolerance))
                {
                    return false;
                }
            }

            return true;
        }
    }
}

using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static bool AlmostEquals(this Point2D point2D_1, Point2D point2D_2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(point2D_1 == point2D_2)
            {
                return true;
            }

            if(point2D_1 == null || point2D_2 == null)
            {
                return false;
            }

            return point2D_1.Distance(point2D_2) <= tolerance;
        }

        public static bool AlmostEquals(this ISegmentable2D segmentable2D_1, ISegmentable2D segmentable2D_2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(segmentable2D_1 == segmentable2D_2)
            {
                return true;
            }

            if (segmentable2D_1 == null || segmentable2D_2 == null)
            {
                return false;
            }

            if(segmentable2D_1.GetType() != segmentable2D_2.GetType())
            {
                return false;
            }

            List<Point2D> point2Ds_1 = segmentable2D_1.GetPoints();
            List<Point2D> point2Ds_2 = segmentable2D_2.GetPoints();

            if((point2Ds_1 == null || point2Ds_1.Count == 0) && (point2Ds_2 == null || point2Ds_2.Count == 0))
            {
                return true;
            }

            if(point2Ds_1 == null || point2Ds_2 == null || point2Ds_1.Count != point2Ds_2.Count)
            {
                return false;
            }

            for(int i = 0; i < point2Ds_1.Count; i++)
            {
                if (!AlmostEquals(point2Ds_1[i], point2Ds_2[i], tolerance))
                {
                    return false;
                }
            }

            return true;
        }
    }
}

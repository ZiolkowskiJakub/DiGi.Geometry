using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;
using DiGi.Geometry.Planar.Interfaces;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static bool Intersect(this ISegmentable2D segmentable2D_1, ISegmentable2D segmentable2D_2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(segmentable2D_1 == null || segmentable2D_2 == null)
            {
                return false;
            }

            BoundingBox2D boundingBox2D_1 = segmentable2D_1.GetBoundingBox();
            if(boundingBox2D_1 == null)
            {
                return false;
            }

            BoundingBox2D boundingBox2D_2 = segmentable2D_2.GetBoundingBox();
            if (boundingBox2D_2 == null)
            {
                return false;
            }

            if(!boundingBox2D_1.InRange(boundingBox2D_2, tolerance))
            {
                return false;
            }


            List<Segment2D> segment2Ds = segmentable2D_2.GetSegments();
            if(segment2Ds == null || segment2Ds.Count == 0) 
            {
                return false;
            }

            foreach(Segment2D segment2D in segment2Ds)
            {
                if(Intersect(segmentable2D_1, segment2D, tolerance))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool Intersect(this ISegmentable2D segmentable2D, Segment2D segment2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(segmentable2D == null || segment2D == null)
            {
                return false;
            }

            BoundingBox2D boundingBox2D = segmentable2D.GetBoundingBox();
            if(boundingBox2D == null)
            {
                return false;
            }

            if(!boundingBox2D.InRange(segment2D, tolerance))
            {
                return false;
            }

            List<Segment2D> segment2Ds = segmentable2D?.GetSegments();
            if(segment2Ds == null || segment2Ds.Count == 0)
            {
                return false;
            }

            foreach(Segment2D segment2D_Temp in segment2Ds)
            {
                if (Intersect((ILinear2D)segment2D, segment2D_Temp, tolerance))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool Intersect(this ILinear2D linear2D_1, ILinear2D linear_2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            Point2D point2D = IntersectionPoint(linear2D_1, linear_2, tolerance);

            return point2D != null;
        }
    }
}

using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static bool SelfIntersect<T>(this ISegmentable2D segmentable2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            List<Segment2D> segment2Ds = segmentable2D?.GetSegments();
            if(segment2Ds == null || segment2Ds.Count == 0)
            {
                return false;
            }

            for(int i = 0; i < segment2Ds.Count - 1; i++)
            {
                for (int j = i + 1; j < segment2Ds.Count; j++)
                {
                    Segment2D segment2D_1 = segment2Ds[i];
                    Segment2D segment2D_2 = segment2Ds[j];

                    IntersectionResult2D intersectionResult2D = Create.IntersectionResult2D(segment2D_1, segment2D_2, tolerance);
                    if(intersectionResult2D != null && intersectionResult2D.Intersect)
                    {
                        if(i + 1 != j)
                        {
                            return true;
                        }

                        if(intersectionResult2D.Contains<Segment2D>())
                        {
                            return true;
                        }

                        Point2D point2D = intersectionResult2D.GetGeometry2Ds<Point2D>().FirstOrDefault();
                        if(point2D != null && !AlmostEquals(segment2D_1[1], point2D, tolerance))
                        {
                            return true;
                        }

                    }
                }
            }

            return false;
        }
    }
}

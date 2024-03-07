using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static bool SelfIntersect(this ISegmentable2D segmentable2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            List<Segment2D> segment2Ds = segmentable2D?.GetSegments();
            if(segment2Ds == null || segment2Ds.Count == 0)
            {
                return false;
            }

            int count = segment2Ds.Count;

            for(int i = 0; i < count - 1; i++)
            {
                Segment2D segment2D_1 = segment2Ds[i];

                for (int j = i + 1; j < count; j++)
                {
                    Segment2D segment2D_2 = segment2Ds[j];

                    IntersectionResult2D intersectionResult2D = Create.IntersectionResult2D(segment2D_1, segment2D_2, tolerance);
                    if(intersectionResult2D != null && intersectionResult2D.Intersect)
                    {
                        bool adjacent = i + 1 == j;
                        bool last = i == 0 && j == count - 1;

                        if (!adjacent && !last)
                        {
                            return true;
                        }

                        if(intersectionResult2D.Contains<Segment2D>())
                        {
                            return true;
                        }

                        Point2D point2D = intersectionResult2D.GetGeometry2Ds<Point2D>().FirstOrDefault();
                        if(point2D != null)
                        {
                            if (adjacent && !AlmostEquals(segment2D_1[1], point2D, tolerance))
                            {
                                return true;
                            }
                            else if (last && !AlmostEquals(segment2D_1[0], point2D, tolerance))
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }
    }
}

using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static bool Convex(this IEnumerable<Point2D> point2Ds)
        {
            if (point2Ds == null || point2Ds.Count() < 3)
            {
                return false;
            }

            return !Concave(point2Ds);
        }

        public static bool Convex(this IClosedSegmentable2D closedSegmentable2D)
        {
            return Convex(closedSegmentable2D?.GetPoints());
        }

        public static bool Convex(this SegmentableFace2D segmentableFace2D, bool externalCurve = true, bool internalCurves = true)
        {
            if (segmentableFace2D == null)
            {
                return false;
            }

            if(externalCurve)
            {
                IClosedSegmentable2D closedSegmentable2D = segmentableFace2D.ExternalCurve;
                if(closedSegmentable2D == null)
                {
                    return false;
                }

                if(!closedSegmentable2D.Convex())
                {
                    return false;
                }
            }

            if(internalCurves)
            {
                List<IClosedSegmentable2D> closedSegmentable2Ds = segmentableFace2D.InternalCurves;
                if(closedSegmentable2Ds != null)
                {
                    for(int i =0; i < closedSegmentable2Ds.Count; i++)
                    {
                        if (!closedSegmentable2Ds[i].Convex())
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
    }
}

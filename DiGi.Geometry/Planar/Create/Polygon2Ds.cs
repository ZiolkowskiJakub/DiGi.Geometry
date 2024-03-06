using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        public static List<Polygon2D> Polygon2Ds(this ISegmentable2D segmentable2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(segmentable2D == null)
            {
                return null;
            }

            List<Polygon2D> result = new List<Polygon2D>();
            if(segmentable2D is Rectangle2D)
            {
                result.Add(new Polygon2D(segmentable2D.GetPoints()));
            }
            else if(segmentable2D is Triangle2D)
            {
                result.Add(new Polygon2D(segmentable2D.GetPoints()));
            }
            else if(segmentable2D is BoundingBox2D)
            {
                result.Add(new Polygon2D(segmentable2D.GetPoints()));
            }
            else
            {
                List<Segment2D> segment2Ds = segmentable2D.GetSegments();
                if(segment2Ds != null && segment2Ds.Count > 2)
                {
                    segment2Ds = Query.Split(segment2Ds, tolerance);
                    List<SegmentableFace2D> segmentableFace2Ds = SegmentableFace2Ds(segment2Ds, tolerance);
                    if(segmentableFace2Ds != null && segmentableFace2Ds.Count != 0)
                    {
                        foreach(SegmentableFace2D segmentableFace2D in segmentableFace2Ds)
                        {
                            List<IClosedSegmentable2D> closedSegmentable2Ds = segmentableFace2D.Curves;
                            if(closedSegmentable2Ds != null)
                            {
                                foreach(IClosedSegmentable2D closedSegmentable2D in closedSegmentable2Ds)
                                {
                                    if(closedSegmentable2D != null)
                                    {
                                        result.Add(new Polygon2D(closedSegmentable2D.GetPoints()));
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return result;
        }
    }

}

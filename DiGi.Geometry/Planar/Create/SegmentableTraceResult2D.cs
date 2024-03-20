using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        public static SegmentableTraceResult2D SegmentableTraceResult2D(this Point2D point2D, Vector2D vector2D, IEnumerable<ISegmentable2D> segmentable2Ds, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            return SegmentableTraceResult2Ds(point2D, vector2D, segmentable2Ds?.Segments(), 0, tolerance)?.FirstOrDefault();
        }

        public static SegmentableTraceResult2D SegmentableTraceResult2D(this Point2D point2D, Vector2D vector2D, IEnumerable<Segment2D> segment2Ds, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            return SegmentableTraceResult2Ds(point2D, vector2D, segment2Ds, 0, tolerance)?.FirstOrDefault();
        }
    }

}

using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Core.Enums;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static VerticalPosition VerticalPosition(this ISegmentable2D segmentable2D, Point2D point2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (segmentable2D == null || point2D == null)
            {
                return Core.Enums.VerticalPosition.Undefined;
            }

            List<Segment2D> segment2Ds = segmentable2D.GetSegments();
            if (segment2Ds == null || segment2Ds.Count == 0)
            {
                return Core.Enums.VerticalPosition.Undefined;
            }

            List<VerticalPosition> verticalPositions = new List<VerticalPosition>();
            foreach (Segment2D segment2D in segmentable2D.GetSegments())
            {
                verticalPositions.Add(VerticalPosition(segment2D, point2D, tolerance));
            }

            if (verticalPositions.TrueForAll(x => x == Core.Enums.VerticalPosition.Undefined))
            {
                return Core.Enums.VerticalPosition.Undefined;
            }

            verticalPositions.RemoveAll(x => x == Core.Enums.VerticalPosition.Undefined);

            if (verticalPositions.TrueForAll(x => x == Core.Enums.VerticalPosition.Below))
            {
                return Core.Enums.VerticalPosition.Below;
            }

            if (verticalPositions.TrueForAll(x => x == Core.Enums.VerticalPosition.Above))
            {
                return Core.Enums.VerticalPosition.Above;
            }

            if (verticalPositions.Contains(Core.Enums.VerticalPosition.On))
            {
                return Core.Enums.VerticalPosition.On;
            }

            return Core.Enums.VerticalPosition.Inside;
        }

        public static VerticalPosition VerticalPosition(this Segment2D segment2D, Point2D point2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(segment2D == null || point2D == null)
            {
                return Core.Enums.VerticalPosition.Undefined;
            }

            BoundingBox2D boundingBox2D = segment2D.GetBoundingBox();
            if(boundingBox2D == null)
            {
                return Core.Enums.VerticalPosition.Undefined;
            }

            if (point2D.X < boundingBox2D.Min.X - tolerance || point2D.X > boundingBox2D.Max.X + tolerance)
            {
                return Core.Enums.VerticalPosition.Undefined;
            }

            SegmentableTraceResult2D segmentableTraceResult2D = Create.SegmentableTraceResult2D(point2D, Constans.Vector2D.WorldY, new Segment2D[] { segment2D }, tolerance);
            if(segmentableTraceResult2D == null)
            {
                return Core.Enums.VerticalPosition.Undefined;
            }

            Vector2D vector2D = segmentableTraceResult2D.Vector2D;
            if(vector2D == null)
            {
                return Core.Enums.VerticalPosition.Below;
            }

            if(vector2D.Length < tolerance)
            {
                return Core.Enums.VerticalPosition.On;
            }

            return Core.Enums.VerticalPosition.Above;
        }
    }
}

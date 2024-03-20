using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static List<Segment2D> SelfIntersectionSegments(this IEnumerable<Segment2D> segment2Ds, double maxLength, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (segment2Ds == null)
                return null;


            List<Segment2D> result = new List<Segment2D>();
            foreach (Segment2D segment2D in segment2Ds)
            {
                Point2D point2D = segment2D.Start;
                Vector2D vector2D = segment2D.Direction;
                vector2D.Inverse();

                List<Segment2D> segment2Ds_Temp = new List<Segment2D>(segment2Ds);
                segment2Ds_Temp.Remove(segment2D);

                Vector2D vector2D_Intersection = Create.SegmentableTraceResult2D(point2D, vector2D, segment2Ds_Temp, tolerance)?.Vector2D;
                if (vector2D_Intersection != null && vector2D_Intersection.Length > 0)
                {
                    Point2D point2D_Temp = new Point2D(point2D);
                    point2D_Temp.Move(vector2D_Intersection);
                    
                    Segment2D segment2D_Intersection = new Segment2D(point2D_Temp, point2D);
                    if (segment2D_Intersection.Length > maxLength)
                    {
                        continue;
                    }

                    List<Point2D> point2Ds_Intersections = segment2D_Intersection.IntersectionPoints(segment2Ds_Temp, tolerance);
                    if (point2Ds_Intersections != null && point2Ds_Intersections.Count == 2)
                    {
                        if (result.Find(x => x.Similar(segment2D_Intersection, tolerance)) == null)
                        {
                            result.Add(segment2D_Intersection);
                        }

                    }
                }

                point2D = segment2D.End;
                vector2D = segment2D.Direction;

                vector2D_Intersection = Create.SegmentableTraceResult2D(point2D, vector2D, segment2Ds_Temp, tolerance)?.Vector2D;
                if (vector2D_Intersection != null && vector2D_Intersection.Length > 0)
                {
                    Point2D point2D_Temp = new Point2D(point2D);
                    point2D_Temp.Move(vector2D_Intersection);

                    Segment2D segment2D_Intersection = new Segment2D(point2D_Temp, point2D);
                    if (segment2D_Intersection.Length > maxLength)
                        continue;

                    List<Point2D> point2Ds_Intersections = segment2D_Intersection.IntersectionPoints(segment2Ds_Temp, tolerance);
                    if (point2Ds_Intersections != null && point2Ds_Intersections.Count == 2)
                    {
                        if (result.Find(x => x.Similar(segment2D_Intersection, tolerance)) == null)
                        {
                            result.Add(segment2D_Intersection);
                        }
                    }
                }
            }

            result.AddRange(segment2Ds);

            return result;
        }


        public static List<Segment2D> SelfIntersectionSegments(this ISegmentable2D segmentable2D, double maxLength, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(segmentable2D == null)
            {
                return null;
            }

            return SelfIntersectionSegments(segmentable2D.GetSegments(), maxLength, tolerance);
        }
    }
}

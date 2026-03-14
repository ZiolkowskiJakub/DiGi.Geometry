using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        public static List<SegmentableTraceResult2D>? SegmentableTraceResult2Ds(this Point2D? point2D, Vector2D? vector2D, IEnumerable<ISegmentable2D>? segmentable2Ds, int bounces = 0, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point2D == null || vector2D == null || segmentable2Ds == null)
            {
                return null;
            }

            return SegmentableTraceResult2Ds(point2D, vector2D, segmentable2Ds.Segments(), bounces, tolerance);
        }

        public static List<SegmentableTraceResult2D>? SegmentableTraceResult2Ds(this Point2D? point2D, Vector2D? vector2D, IEnumerable<Segment2D>? segment2Ds, int bounces = 0, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point2D is null || vector2D is null || segment2Ds is null)
            {
                return null;
            }

            HashSet<Point2D> point2Ds = [];
            foreach (Segment2D segment2D in segment2Ds)
            {
                Point2D? point2D_Temp_Temp;

                point2D_Temp_Temp = segment2D[0];
                if (point2D_Temp_Temp is not null)
                {
                    point2Ds.Add(point2D_Temp_Temp);
                }

                point2D_Temp_Temp = segment2D[1];
                if (point2D_Temp_Temp is not null)
                {
                    point2Ds.Add(point2D_Temp_Temp);
                }
            }

            BoundingBox2D boundingBox2D = new(point2Ds, 1.0);
            double length = new Vector2D(boundingBox2D.Min, boundingBox2D.Max).Length;

            List<SegmentableTraceResult2D> result = [];

            List<Point2D>? point2Ds_Intersection = [];
            Vector2D? vector2D_Temp = vector2D?.Unit * length;
            Point2D? point2D_Temp = point2D;

            if (vector2D_Temp is null)
            {
                return null;
            }

            do
            {
                point2Ds_Intersection = Query.IntersectionPoints(point2D_Temp, vector2D_Temp, segment2Ds, true, true, true, false, out List<Segment2D>? segment2Ds_Intersection, tolerance);
                if (point2Ds_Intersection != null && point2Ds_Intersection.Count > 0 && segment2Ds_Intersection != null && segment2Ds_Intersection.Count > 0)
                {
                    DiGi.Core.Modify.Sort(point2Ds_Intersection, x => x.Distance(point2D_Temp));

                    Point2D point2D_Intersection = point2Ds_Intersection[0];
                    Segment2D segment2D_Intersection = segment2Ds_Intersection[0];

                    Vector2D vector2D_result = new(point2D_Temp, point2D_Intersection);
                    result.Add(new SegmentableTraceResult2D(vector2D_result, segment2D_Intersection, point2D_Intersection));

                    if (result.Count >= bounces)
                    {
                        break;
                    }

                    point2D_Temp = point2D_Intersection;

                    vector2D_Temp = Query.Bounce(vector2D_Temp, segment2D_Intersection);
                }
            }
            while (result.Count <= bounces && point2Ds_Intersection != null && point2Ds_Intersection.Count > 0);

            return result;
        }
    }
}
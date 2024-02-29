using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static List<Point2D> IntersectionPoints(this IEnumerable<Segment2D> segment2Ds_1, IEnumerable<Segment2D> segment2Ds_2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            return IntersectionPoints(segment2Ds_1, segment2Ds_2, int.MaxValue, tolerance);
        }
        
        public static List<Point2D> IntersectionPoints(this ISegmentable2D segmentable2D, IEnumerable<Segment2D> segment2Ds, double tolerace = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(segmentable2D == null || segment2Ds == null)
            {
                return null;
            }

            return IntersectionPoints(segmentable2D.GetSegments(), segment2Ds, tolerace);
        }

        public static List<Point2D> IntersectionPoints(this ISegmentable2D segmentable2D_1, ISegmentable2D segmentable2D_2, double tolerace = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (segmentable2D_1 == null || segmentable2D_2 == null)
            {
                return null;
            }

            return IntersectionPoints(segmentable2D_1.GetSegments(), segmentable2D_2.GetSegments(), tolerace);
        }

        public static List<Point2D> IntersectionPoints<T>(this ISegmentable2D segmentable2D, IEnumerable<ISegmentable2D> segmentable2Ds, double tolerace = DiGi.Core.Constans.Tolerance.Distance) where T: ISegmentable2D
        {
            if(segmentable2D == null || segmentable2Ds == null)
            {
                return null;
            }

            return IntersectionPoints(segmentable2D.GetSegments(), segmentable2Ds.Segments(), tolerace);
        }

        public static List<Point2D> IntersectionPoints(this IEnumerable<Segment2D> segment2Ds_1, IEnumerable<Segment2D> segment2Ds_2, int maxCount, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(segment2Ds_1 == null || segment2Ds_2 == null || maxCount < 1)
            {
                return null;
            }

            int count_1 = segment2Ds_1.Count();
            if(count_1 == 0)
            {
                return null;
            }

            int count_2 = segment2Ds_2.Count();
            if(count_2 == 0)
            {
                return null;
            }

            List<Point2D> result = new List<Point2D>();
            for (int i = 0; i < count_1; i++)
            {
                Segment2D segment2D_1 = segment2Ds_1.ElementAt(i);
                if(segment2D_1 == null)
                {
                    continue;
                }

                for (int j = 0; j < count_2; j++)
                {
                    Segment2D segment2D_2 = segment2Ds_2.ElementAt(j);
                    if(segment2D_2 == null)
                    {
                        continue;
                    }

                    Point2D point2D = segment2D_1.IntersectionPoint(segment2D_2, tolerance);
                    if(point2D == null)
                    {
                        continue;
                    }

                    result.Add(point2D);
                    if(result.Count >= maxCount)
                    {
                        return result;
                    }
                }
            }

            return result;
        }

        public static List<Point2D> IntersectionPoints(this Point2D point2D, Vector2D vector2D, IEnumerable<ISegmentable2D> segmentable2Ds, bool keepDirection, bool removeCollinear, bool sort, bool selfIntersection, out List<Segment2D> intersectionSegment2Ds, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            intersectionSegment2Ds = null;
            if (point2D == null || vector2D == null || segmentable2Ds == null)
            {
                return null;
            }

            List<Segment2D> segment2Ds = new List<Segment2D>();
            foreach (ISegmentable2D segmentable2D in segmentable2Ds)
            {
                List<Segment2D> segment2Ds_Temp = segmentable2D?.GetSegments();
                if (segment2Ds_Temp == null || segment2Ds_Temp.Count == 0)
                {
                    continue;
                }

                segment2Ds.AddRange(segment2Ds_Temp);
            }

            Dictionary<Point2D, Segment2D> dictionary = new Dictionary<Point2D, Segment2D>();

            Segment2D segment2D = new Segment2D(point2D, vector2D);
            foreach (Segment2D segment2D_Temp in segment2Ds)
            {
                Point2D point2D_closest_1;
                Point2D point2D_closest_2;

                if (removeCollinear && segment2D.Collinear(segment2D_Temp))
                {
                    continue;
                }

                Point2D point2D_Intersection = IntersectionPoint(segment2D, segment2D_Temp, out point2D_closest_1, out point2D_closest_2, tolerance);
                if (point2D_Intersection == null)
                {
                    continue;
                }

                if (!selfIntersection && DiGi.Core.Query.Round(point2D_Intersection.Distance(point2D), tolerance) <= tolerance)
                {
                    continue;
                }

                if (point2D_closest_1 == null || point2D_closest_2 == null)
                {
                    dictionary[point2D_Intersection] = segment2D_Temp;
                    continue;
                }

                if (point2D_closest_2 != null && DiGi.Core.Query.Round(segment2D_Temp.Distance(point2D_Intersection), tolerance) <= tolerance)
                {
                    if (keepDirection)
                    {
                        if (!vector2D.Unit.AlmostEqual(new Vector2D(point2D_closest_1, point2D_closest_2).Unit, tolerance))
                        {
                            continue;
                        }
                    }

                    dictionary[point2D_Intersection] = segment2D_Temp;
                }
            }

            if (sort)
            {
                List<Point2D> point2Ds = dictionary.Keys.ToList();
                DiGi.Core.Modify.Sort(point2Ds, x => x.Distance(point2D));

                Dictionary<Point2D, Segment2D> dictionary_Temp = new Dictionary<Point2D, Segment2D>();
                foreach (Point2D point2D_Temp in point2Ds)
                {
                    dictionary_Temp[point2D_Temp] = dictionary[point2D_Temp];
                }

                dictionary = dictionary_Temp;
            }

            intersectionSegment2Ds = new List<Segment2D>(dictionary.Values);

            return new List<Point2D>(dictionary.Keys);
        }

        public static List<Point2D> IntersectionPoints(this Line2D line2D, IEnumerable<ISegmentable2D> segmentable2Ds, out List<Segment2D> intersectionSegment2Ds, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            intersectionSegment2Ds = null;

            if (line2D == null || segmentable2Ds == null)
            {
                return null;
            }

            return IntersectionPoints(line2D.Origin, line2D.Direction, segmentable2Ds, false, true, false, true, out intersectionSegment2Ds, tolerance);
        }

        public static List<Point2D> IntersectionPoints(this Line2D line2D, IEnumerable<ISegmentable2D> segmentable2Ds, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (line2D == null || segmentable2Ds == null)
            {
                return null;
            }

            return IntersectionPoints(line2D.Origin, line2D.Direction, segmentable2Ds, false, true, false, true, out List<Segment2D> intersectionSegment2Ds, tolerance);
        }
    }

}

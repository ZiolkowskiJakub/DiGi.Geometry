using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Split Segment2Ds
        /// </summary>
        /// <returns>List Segment2D</returns>
        /// <param name="segment2Ds">Segments2Ds</param>
        /// <param name="tolerance">tolerance</param>
        public static List<Segment2D> Split(this IEnumerable<Segment2D> segment2Ds, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (segment2Ds == null)
                return null;

            List<Tuple<BoundingBox2D, Segment2D>> tuples = new List<Tuple<BoundingBox2D, Segment2D>>();
            List<Point2D> point2Ds = new List<Point2D>();
            foreach (Segment2D segment2D in segment2Ds)
            {
                if (segment2D == null || segment2D.Length < tolerance)
                {
                    continue;
                }

                tuples.Add(new Tuple<BoundingBox2D, Segment2D>(segment2D.GetBoundingBox(), segment2D));
                Modify.Add(point2Ds, segment2D[0], tolerance);
                Modify.Add(point2Ds, segment2D[1], tolerance);
            }

            int count = tuples.Count();

            List<List<Point2D>> point2DsList = Enumerable.Repeat<List<Point2D>>(null, count).ToList();
            for (int i = 0; i < count - 1; i++)
            {
                BoundingBox2D boundingBox2D_1 = tuples[i].Item1;
                Segment2D segment2D_1 = tuples[i].Item2;

                for (int j = i + 1; j < count; j++)
                {
                    BoundingBox2D boundingBox2D_2 = tuples[j].Item1;
                    if (!boundingBox2D_1.InRange(boundingBox2D_2, tolerance))
                    {
                        continue;
                    }

                    Segment2D segment2D_2 = tuples[j].Item2;
                    if (segment2D_1.Similar(segment2D_2, tolerance))
                    {
                        continue;
                    }

                    Point2D point2D_Closest1;
                    Point2D point2D_Closest2;

                    List<Point2D> point2Ds_Intersection = new List<Point2D>();

                    if (segment2D_1.On(segment2D_2[0], tolerance))
                    {
                        point2Ds_Intersection.Add(segment2D_2[0]);
                    }

                    if (segment2D_2.On(segment2D_1[0], tolerance))
                    {
                        point2Ds_Intersection.Add(segment2D_1[0]);
                    }

                    if (segment2D_1.On(segment2D_2[1], tolerance))
                    {
                        point2Ds_Intersection.Add(segment2D_2[1]);
                    }

                    if (segment2D_2.On(segment2D_1[1], tolerance))
                    {
                        point2Ds_Intersection.Add(segment2D_1[1]);
                    }

                    if (point2Ds_Intersection.Count == 0)
                    {
                        Point2D point2D_Intersection = Query.IntersectionPoint(segment2D_1, segment2D_2, out point2D_Closest1, out point2D_Closest2, tolerance);
                        if (point2D_Intersection == null)
                        {
                            continue;
                        }

                        if (point2D_Closest1 != null && point2D_Closest2 != null)
                        {
                            if (point2D_Closest1.Distance(point2D_Closest2) > tolerance)
                            {
                                continue;
                            }
                        }


                        point2Ds_Intersection.Add(point2D_Intersection);
                    }

                    if (point2Ds_Intersection == null || point2Ds_Intersection.Count == 0)
                    {
                        continue;
                    }

                    foreach (Point2D point2D_Intersection in point2Ds_Intersection)
                    {
                        Point2D point2D_Intersection_Temp = point2Ds.Find(x => point2D_Intersection.AlmostEquals(x, tolerance));
                        if (point2D_Intersection_Temp == null)
                        {
                            point2D_Intersection_Temp = point2D_Intersection;
                            Modify.Add(point2Ds, point2D_Intersection_Temp, tolerance);
                        }

                        if (point2D_Intersection_Temp.Distance(segment2D_1.Start) > tolerance && point2D_Intersection_Temp.Distance(segment2D_1.End) > tolerance)
                        {
                            if (point2DsList[i] == null)
                            {
                                point2DsList[i] = new List<Point2D>();
                            }

                            Modify.Add(point2DsList[i], point2D_Intersection_Temp, tolerance);
                        }

                        if (point2D_Intersection_Temp.Distance(segment2D_2.Start) > tolerance && point2D_Intersection_Temp.Distance(segment2D_2.End) > tolerance)
                        {
                            if (point2DsList[j] == null)
                            {
                                point2DsList[j] = new List<Point2D>();
                            }

                            Modify.Add(point2DsList[j], point2D_Intersection_Temp, tolerance);
                        }
                    }
                }
            }

            List<Segment2D> result = new List<Segment2D>();
            for (int i = 0; i < count; i++)
            {
                Segment2D segment2D_Temp = tuples[i].Item2;
                if (result.Find(x => x.Similar(segment2D_Temp, tolerance)) != null)
                    continue;

                List<Point2D> point2Ds_Temp = point2DsList[i];
                if (point2Ds_Temp == null || point2Ds_Temp.Count == 0)
                {
                    result.Add(segment2D_Temp);
                    continue;
                }

                Modify.Add(point2Ds_Temp, segment2D_Temp[0], tolerance);
                Modify.Add(point2Ds_Temp, segment2D_Temp[1], tolerance);

                Point2D point2D = segment2D_Temp[0];
                DiGi.Core.Modify.Sort(point2Ds_Temp, x => x.Distance(point2D));

                for (int j = 0; j < point2Ds_Temp.Count - 1; j++)
                {
                    Point2D point2D_1 = point2Ds_Temp[j];
                    Point2D point2D_2 = point2Ds_Temp[j + 1];

                    Segment2D segment2D = result.Find(x => (x[0].AlmostEquals(point2D_1, tolerance) && x[1].AlmostEquals(point2D_2, tolerance)) || (x[1].AlmostEquals(point2D_1, tolerance) && x[0].AlmostEquals(point2D_2, tolerance)));
                    if (segment2D != null)
                    {
                        continue;
                    }

                    result.Add(new Segment2D(point2D_1, point2D_2));
                }
            }

            return result;
        }


        public static List<Segment2D> Split(this ISegmentable2D segmentable2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            List<Segment2D> segment2Ds = segmentable2D?.GetSegments();
            if(segment2Ds == null)
            {
                return null;
            }

            return Split(segment2Ds, tolerance);
        }

        public static List<Segment2D> Split<T>(this IEnumerable<T> segmentable2Ds, double tolerance = DiGi.Core.Constans.Tolerance.Distance) where T: ISegmentable2D
        {
            List<Segment2D> segment2Ds = segmentable2Ds?.Segments();
            if (segment2Ds == null)
            {
                return null;
            }

            return Split(segment2Ds, tolerance);
        }
    }
}

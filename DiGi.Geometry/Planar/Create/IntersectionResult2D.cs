﻿using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        public static IntersectionResult2D IntersectionResult2D(this Segment2D segment2D_1, Segment2D segment2D_2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(segment2D_1 == null || segment2D_2 == null)
            {
                return null;
            }

            BoundingBox2D boundingBox2D_1 = segment2D_1.GetBoundingBox();
            BoundingBox2D boundingBox2D_2 = segment2D_2.GetBoundingBox();

            if (!boundingBox2D_1.InRange(boundingBox2D_2, tolerance))
            {
                return new IntersectionResult2D();
            }

            bool on_1 = segment2D_1.On(segment2D_2[0], tolerance);
            bool on_2 = segment2D_1.On(segment2D_2[1], tolerance);
            bool on_3 = segment2D_2.On(segment2D_1[0], tolerance);
            bool on_4 = segment2D_2.On(segment2D_1[1], tolerance);

            if(!on_1 && !on_2 && !on_3 && !on_4)
            {
                return new IntersectionResult2D(segment2D_1.IntersectionPoint(segment2D_2, tolerance));
            }

            if(on_1 && on_2)
            {
                return new IntersectionResult2D(segment2D_2);
            }

            if (on_3 && on_4)
            {
                return new IntersectionResult2D(segment2D_1);
            }

            if (on_2 && on_3)
            {
                if(Query.AlmostEquals(segment2D_2[1], segment2D_1[0], tolerance))
                {
                    return new IntersectionResult2D(segment2D_2[1]);
                }

                return new IntersectionResult2D(new Segment2D(segment2D_2[1], segment2D_1[0]));
            }

            if (on_1 && on_3)
            {
                if (Query.AlmostEquals(segment2D_2[0], segment2D_1[0], tolerance))
                {
                    return new IntersectionResult2D(segment2D_2[0]);
                }

                return new IntersectionResult2D(new Segment2D(segment2D_2[0], segment2D_1[0]));
            }

            if (on_2 && on_4)
            {
                if (Query.AlmostEquals(segment2D_2[1], segment2D_1[1], tolerance))
                {
                    return new IntersectionResult2D(segment2D_2[1]);
                }

                return new IntersectionResult2D(new Segment2D(segment2D_2[1], segment2D_1[1]));
            }

            if (on_1 && on_4)
            {
                if (Query.AlmostEquals(segment2D_2[0], segment2D_1[1], tolerance))
                {
                    return new IntersectionResult2D(segment2D_2[0]);
                }

                return new IntersectionResult2D(new Segment2D(segment2D_2[0], segment2D_1[1]));
            }

            return null;
        }

        public static IntersectionResult2D IntersectionResult2D(this Line2D line2D_1, Line2D line2D_2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (line2D_1 == null || line2D_2 == null)
            {
                return null;
            }

            Point2D point2D = line2D_1.IntersectionPoint(line2D_2);
            if(point2D != null)
            {
                return new IntersectionResult2D(point2D);
            }

            if(line2D_1.On(line2D_2.Origin, tolerance))
            {
                return new IntersectionResult2D(line2D_1);
            }

            return new IntersectionResult2D();

        }

        public static IntersectionResult2D IntersectionResult2D(this Segment2D segment2D, IEnumerable<Segment2D> segment2Ds, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(segment2D == null || segment2Ds == null)
            {
                return null;
            }

            List<Point2D> point2Ds_Intersection = new List<Point2D>();
            List<Segment2D> segment2Ds_Intersection = new List<Segment2D>();
            foreach(Segment2D segment2D_Temp in segment2Ds)
            {
                if(segment2D_Temp == null)
                {
                    continue;
                }

                IntersectionResult2D intersectionResult2D = IntersectionResult2D(segment2D, segment2D_Temp);
                if(intersectionResult2D == null || !intersectionResult2D.Intersect)
                {
                    continue;
                }

                IGeometry2D geometry2D = intersectionResult2D.GetGeometry2Ds<IGeometry2D>()[0];
                if(geometry2D is Point2D)
                {
                    Point2D point2D_Intersection = (Point2D)geometry2D;
                    Point2D point2D_Similar = point2Ds_Intersection.Find(x => x.Similar(point2D_Intersection, tolerance));
                    if(point2D_Similar == null)
                    {
                        point2Ds_Intersection.Add(point2D_Intersection);
                    }
                }
                else if (geometry2D is Segment2D)
                {
                    Segment2D segment2D_Intersection = (Segment2D)geometry2D;
                    Segment2D segment2D_Similar = segment2Ds_Intersection.Find(x => x.Similar(segment2D_Intersection, tolerance));
                    if (segment2D_Similar == null)
                    {
                        segment2Ds_Intersection.Add(segment2D_Intersection);
                    }
                }
            }

            List<IGeometry2D> geometry2Ds = new List<IGeometry2D>();
            for (int i = 0; i < point2Ds_Intersection.Count; i++)
            {
                geometry2Ds.Add(point2Ds_Intersection[i]);
            }

            for (int i = 0; i < segment2Ds_Intersection.Count; i++)
            {
                geometry2Ds.Add(segment2Ds_Intersection[i]);
            }

            return new IntersectionResult2D(geometry2Ds);
        }

        public  static IntersectionResult2D IntersectionResult2D(this IEnumerable<Segment2D> segment2Ds_1, IEnumerable<Segment2D> segment2Ds_2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(segment2Ds_1 == null || segment2Ds_2 == null)
            {
                return null;
            }

            if (segment2Ds_1.Count() == 0 || segment2Ds_2.Count() == 0)
            {
                return new IntersectionResult2D();
            }

            List<Point2D> point2Ds_Intersection = new List<Point2D>();
            List<Segment2D> segment2Ds_Intersection = new List<Segment2D>();
            foreach (Segment2D segment2D_Temp in segment2Ds_1)
            {
                if (segment2D_Temp == null)
                {
                    continue;
                }

                IntersectionResult2D intersectionResult2D = IntersectionResult2D(segment2D_Temp, segment2Ds_2);
                if (intersectionResult2D == null || !intersectionResult2D.Intersect)
                {
                    continue;
                }

                IGeometry2D geometry2D = intersectionResult2D.GetGeometry2Ds<IGeometry2D>()[0];
                if (geometry2D is Point2D)
                {
                    Point2D point2D_Intersection = (Point2D)geometry2D;
                    Point2D point2D_Similar = point2Ds_Intersection.Find(x => x.Similar(point2D_Intersection, tolerance));
                    if (point2D_Similar == null)
                    {
                        point2Ds_Intersection.Add(point2D_Intersection);
                    }
                }
                else if (geometry2D is Segment2D)
                {
                    Segment2D segment2D_Intersection = (Segment2D)geometry2D;
                    Segment2D segment2D_Similar = segment2Ds_Intersection.Find(x => x.Similar(segment2D_Intersection, tolerance));
                    if (segment2D_Similar == null)
                    {
                        segment2Ds_Intersection.Add(segment2D_Intersection);
                    }
                }
            }

            List<IGeometry2D> geometry2Ds = new List<IGeometry2D>();
            for (int i = 0; i < point2Ds_Intersection.Count; i++)
            {
                geometry2Ds.Add(point2Ds_Intersection[i]);
            }

            for (int i = 0; i < segment2Ds_Intersection.Count; i++)
            {
                geometry2Ds.Add(segment2Ds_Intersection[i]);
            }

            return new IntersectionResult2D(geometry2Ds);
        }

        public static IntersectionResult2D IntersectionResult2D(this ISegmentable2D segmentable2D_1, ISegmentable2D segmentable2D_2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(segmentable2D_1 == null || segmentable2D_2 == null)
            {
                return null;
            }

            return IntersectionResult2D(segmentable2D_1.GetSegments(), segmentable2D_2.GetSegments(), tolerance);
        }

        public static IntersectionResult2D IntersectionResult2D(this Line2D line2D, Segment2D segment2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (line2D == null || segment2D == null)
            {
                return null;
            }

            if (line2D.On(segment2D[0], tolerance) && line2D.On(segment2D[1]))
            {
                return new IntersectionResult2D(new Segment2D(segment2D));
            }

            Point2D point2D = line2D.IntersectionPoint(segment2D, tolerance);
            if(point2D == null)
            {
                return new IntersectionResult2D();
            }

            return new IntersectionResult2D(point2D);
        }

        public static IntersectionResult2D IntersectionResult2D(this Line2D line2D, IEnumerable<Segment2D> segment2Ds, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (line2D == null || segment2Ds == null)
            {
                return null;
            }

            List<Point2D> point2Ds_Intersection = new List<Point2D>();
            List<Segment2D> segment2Ds_Intersection = new List<Segment2D>();
            foreach (Segment2D segment2D_Temp in segment2Ds)
            {
                if (segment2D_Temp == null)
                {
                    continue;
                }

                IntersectionResult2D intersectionResult2D = IntersectionResult2D(line2D, segment2D_Temp);
                if (intersectionResult2D == null || !intersectionResult2D.Intersect)
                {
                    continue;
                }

                IGeometry2D geometry2D = intersectionResult2D.GetGeometry2Ds<IGeometry2D>()[0];
                if (geometry2D is Point2D)
                {
                    Point2D point2D_Intersection = (Point2D)geometry2D;
                    Point2D point2D_Similar = point2Ds_Intersection.Find(x => x.Similar(point2D_Intersection, tolerance));
                    if (point2D_Similar == null)
                    {
                        point2Ds_Intersection.Add(point2D_Intersection);
                    }
                }
                else if (geometry2D is Segment2D)
                {
                    Segment2D segment2D_Intersection = (Segment2D)geometry2D;
                    Segment2D segment2D_Similar = segment2Ds_Intersection.Find(x => x.Similar(segment2D_Intersection, tolerance));
                    if (segment2D_Similar == null)
                    {
                        segment2Ds_Intersection.Add(segment2D_Intersection);
                    }
                }
            }

            List<IGeometry2D> geometry2Ds = new List<IGeometry2D>();
            for (int i = 0; i < point2Ds_Intersection.Count; i++)
            {
                geometry2Ds.Add(point2Ds_Intersection[i]);
            }

            for (int i = 0; i < segment2Ds_Intersection.Count; i++)
            {
                geometry2Ds.Add(segment2Ds_Intersection[i]);
            }

            return new IntersectionResult2D(geometry2Ds);
        }

        public static IntersectionResult2D IntersectionResult2D(this Line2D line2D, ISegmentable2D segmentable2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (line2D == null || segmentable2D == null)
            {
                return null;
            }

            return IntersectionResult2D(line2D, segmentable2D.GetSegments(), tolerance);
        }

        public static IntersectionResult2D IntersectionResult2D(this ISegmentable2D segmentable2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            return IntersectionResult2D(segmentable2D, int.MaxValue, tolerance);
        }

        public static IntersectionResult2D IntersectionResult2D(this ISegmentable2D segmentable2D, int maxCount, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            List<Segment2D> segment2Ds = segmentable2D?.GetSegments();
            if (segment2Ds == null || segment2Ds.Count == 0)
            {
                return null;
            }

            int count_Segment2Ds = segment2Ds.Count;

            int count = 0;

            List<Point2D> point2Ds_Intersection = new List<Point2D>();
            List<Segment2D> segment2Ds_Intersection = new List<Segment2D>();


            for (int i = 0; i < count_Segment2Ds - 1; i++)
            {
                Segment2D segment2D_1 = segment2Ds[i];

                for (int j = i + 1; j < count_Segment2Ds; j++)
                {
                    Segment2D segment2D_2 = segment2Ds[j];

                    IntersectionResult2D intersectionResult2D = IntersectionResult2D(segment2D_1, segment2D_2, tolerance);
                    if (intersectionResult2D != null && intersectionResult2D.Intersect)
                    {
                        bool adjacent = i + 1 == j;
                        bool last = i == 0 && j == count_Segment2Ds - 1;

                        IGeometry2D geometry2D = null;

                        if (!adjacent && !last)
                        {
                            geometry2D = intersectionResult2D.GetGeometry2Ds<IGeometry2D>()[0];
                        }
                        else if (intersectionResult2D.Contains<Segment2D>())
                        {
                            geometry2D = intersectionResult2D.GetGeometry2Ds<Segment2D>().FirstOrDefault();
                        }
                        else
                        {
                            Point2D point2D = intersectionResult2D.GetGeometry2Ds<Point2D>().FirstOrDefault();
                            if (point2D != null)
                            {
                                if (adjacent && !Query.AlmostEquals(segment2D_1[1], point2D, tolerance))
                                {
                                    geometry2D = point2D;
                                }
                                else if (last && !Query.AlmostEquals(segment2D_1[0], point2D, tolerance))
                                {
                                    geometry2D = point2D;
                                }
                            }
                        }

                        if(geometry2D == null)
                        {
                            continue;
                        }

                        if (geometry2D is Point2D)
                        {
                            Point2D point2D_Intersection = (Point2D)geometry2D;
                            Point2D point2D_Similar = point2Ds_Intersection.Find(x => x.Similar(point2D_Intersection, tolerance));
                            if (point2D_Similar == null)
                            {
                                point2Ds_Intersection.Add(point2D_Intersection);
                            }
                            count++;
                        }
                        else if (geometry2D is Segment2D)
                        {
                            Segment2D segment2D_Intersection = (Segment2D)geometry2D;
                            Segment2D segment2D_Similar = segment2Ds_Intersection.Find(x => x.Similar(segment2D_Intersection, tolerance));
                            if (segment2D_Similar == null)
                            {
                                segment2Ds_Intersection.Add(segment2D_Intersection);
                            }

                            count++;
                        }
                    }

                    if(count >= maxCount)
                    {
                        break;
                    }
                }

                if(count >= maxCount)
                {
                    break;
                }
            }

            List<IGeometry2D> geometry2Ds = new List<IGeometry2D>();
            for (int i = 0; i < point2Ds_Intersection.Count; i++)
            {
                geometry2Ds.Add(point2Ds_Intersection[i]);
            }

            for (int i = 0; i < segment2Ds_Intersection.Count; i++)
            {
                geometry2Ds.Add(segment2Ds_Intersection[i]);
            }

            return new IntersectionResult2D(geometry2Ds);
        }
    }

}

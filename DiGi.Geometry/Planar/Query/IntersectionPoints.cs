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
            if (segmentable2D == null || segment2Ds == null)
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

        public static List<Point2D> IntersectionPoints<T>(this ISegmentable2D segmentable2D, IEnumerable<ISegmentable2D> segmentable2Ds, double tolerace = DiGi.Core.Constans.Tolerance.Distance) where T : ISegmentable2D
        {
            if (segmentable2D == null || segmentable2Ds == null)
            {
                return null;
            }

            return IntersectionPoints(segmentable2D.GetSegments(), segmentable2Ds.Segments(), tolerace);
        }

        public static List<Point2D> IntersectionPoints(this IEnumerable<Segment2D> segment2Ds_1, IEnumerable<Segment2D> segment2Ds_2, int maxCount, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (segment2Ds_1 == null || segment2Ds_2 == null || maxCount < 1)
            {
                return null;
            }

            int count_1 = segment2Ds_1.Count();
            if (count_1 == 0)
            {
                return null;
            }

            int count_2 = segment2Ds_2.Count();
            if (count_2 == 0)
            {
                return null;
            }

            List<Point2D> result = new List<Point2D>();
            for (int i = 0; i < count_1; i++)
            {
                Segment2D segment2D_1 = segment2Ds_1.ElementAt(i);
                if (segment2D_1 == null)
                {
                    continue;
                }

                for (int j = 0; j < count_2; j++)
                {
                    Segment2D segment2D_2 = segment2Ds_2.ElementAt(j);
                    if (segment2D_2 == null)
                    {
                        continue;
                    }

                    Point2D point2D = segment2D_1.IntersectionPoint(segment2D_2, tolerance);
                    if (point2D == null)
                    {
                        continue;
                    }

                    result.Add(point2D);
                    if (result.Count >= maxCount)
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

            return IntersectionPoints(point2D, vector2D, segment2Ds, keepDirection, removeCollinear, sort, selfIntersection, out intersectionSegment2Ds, tolerance);
        }

        public static List<Point2D> IntersectionPoints(this Point2D point2D, Vector2D vector2D, IEnumerable<Segment2D> segment2Ds, bool keepDirection, bool removeCollinear, bool sort, bool selfIntersection, out List<Segment2D> intersectionSegment2Ds, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            intersectionSegment2Ds = null;
            if (point2D == null || vector2D == null || segment2Ds == null)
            {
                return null;
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
                        if (!vector2D.Unit.AlmostEquals(new Vector2D(point2D_closest_1, point2D_closest_2).Unit, tolerance))
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

        /// <summary>
        /// Returns intersection points between line and segmentable2D
        /// </summary>
        /// <param name="line2D">Line2D to be intersected</param>
        /// <param name="segmentable2Ds">Segmentable2D to be intersected</param>
        /// <param name="intersectionSegment2Ds">Segmentable2D segments intersected by line</param>
        /// <param name="tolerance">Tolerance</param>
        /// <returns>Intersection Points</returns>
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

        public static List<Point2D> IntersectionPoints(this Line2D line2D, ISegmentable2D segmentable2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (line2D == null)
            {
                return null;
            }

            List<Segment2D> segment2Ds = segmentable2D?.GetSegments();
            if (segment2Ds == null)
            {
                return null;
            }

            List<Point2D> result = new List<Point2D>();
            foreach (Segment2D segment2D in segment2Ds)
            {
                Point2D point2D = line2D.IntersectionPoint(segment2D, tolerance);
                if (point2D == null)
                {
                    continue;
                }

                result.Add(point2D, tolerance);
            }

            return result;
        }

        public static List<Point2D> IntersectionPoints(double x, double y, double radius, Point2D point2D_1, Point2D point2D_2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            double dx, dy, a, b, c, det, t;

            dx = point2D_2.X - point2D_1.X;
            dy = point2D_2.Y - point2D_1.Y;

            a = dx * dx + dy * dy;
            b = 2 * (dx * (point2D_1.X - x) + dy * (point2D_1.Y - y));
            c = (point2D_1.X - x) * (point2D_1.X - x) + (point2D_1.Y - y) * (point2D_1.Y - y) - radius * radius;

            det = b * b - 4 * a * c;
            if ((a <= tolerance) || (det < 0))
            {
                return null;
            }

            List<Point2D> result = new List<Point2D>();

            if (System.Math.Abs(det) < tolerance)
            {
                t = -b / (2 * a);
                result.Add(new Point2D(point2D_1.X + t * dx, point2D_1.Y + t * dy));
                return result;
            }

            t = (double)((-b + System.Math.Sqrt(det)) / (2 * a));
            result.Add(new Point2D(point2D_1.X + t * dx, point2D_1.Y + t * dy));
            t = (double)((-b - System.Math.Sqrt(det)) / (2 * a));
            result.Add(new Point2D(point2D_1.X + t * dx, point2D_1.Y + t * dy));

            return result;
        }

        public static List<Point2D> IntersectionPoints(this Circle2D circle2D, Line2D line2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (circle2D == null || line2D == null)
            {
                return null;
            }

            Point2D center = circle2D.Center;
            if (center == null)
            {
                return null;
            }

            double radius = circle2D.Radius;

            Point2D point2D_1 = line2D.Origin;
            if (point2D_1 == null)
            {
                return null;
            }

            Point2D point2D_2 = new Point2D(point2D_1);
            if (point2D_1 == null)
            {
                return null;
            }

            point2D_2.Move(line2D.Direction);

            return IntersectionPoints(center.X, center.Y, radius, point2D_1, point2D_2, tolerance);
        }

        public static List<Point2D> IntersectionPoints(this Circle2D circle2D, Segment2D segment2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (circle2D == null || segment2D == null)
            {
                return null;
            }

            Point2D center = circle2D.Center;
            if (center == null)
            {
                return null;
            }

            double radius = circle2D.Radius;

            Point2D point2D_1 = segment2D.Start;
            if (point2D_1 == null)
            {
                return null;
            }

            Point2D point2D_2 = segment2D.End;
            if (point2D_2 == null)
            {
                return null;
            }

            List<Point2D> result = IntersectionPoints(center.X, center.Y, radius, point2D_1, point2D_2, tolerance);
            if (result == null)
            {
                return result;
            }

            for (int i = result.Count - 1; i >= 0; i--)
            {
                if (!segment2D.On(result[i], tolerance))
                {
                    result.RemoveAt(i);
                }
            }

            return result;
        }

        public static List<Point2D> IntersectionPoints(this Circle2D circle2D, ISegmentable2D segmentable2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (circle2D == null || segmentable2D == null)
            {
                return null;
            }

            List<Segment2D> segment2Ds = segmentable2D.GetSegments();
            if (segment2Ds == null)
            {
                return null;
            }

            List<Point2D> result = new List<Point2D>();
            foreach (Segment2D segment2D in segment2Ds)
            {
                List<Point2D> point2Ds = IntersectionPoints(circle2D, segment2D, tolerance);
                if (point2Ds == null)
                {
                    continue;
                }

                for (int i = 0; i < point2Ds.Count; i++)
                {
                    result.Add(point2Ds[i], tolerance);
                }
            }

            return result;
        }

        public static List<Point2D> IntersectionPoints(this Ellipse2D ellipse2D, Segment2D segment2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            // Translate points to ellipse-centered coordinates
            double dx0 = segment2D[0].X - ellipse2D.Center.X;
            double dy0 = segment2D[0].Y - ellipse2D.Center.Y;
            double dx1 = segment2D[1].X - ellipse2D.Center.X;
            double dy1 = segment2D[1].Y - ellipse2D.Center.Y;

            // Rotate into ellipse-aligned coordinates
            double ux = ellipse2D.Direction.X;
            double uy = ellipse2D.Direction.Y;
            double vx = -uy;
            double vy = ux;

            double x0 = dx0 * ux + dy0 * uy;
            double y0 = dx0 * vx + dy0 * vy;
            double x1 = dx1 * ux + dy1 * uy;
            double y1 = dx1 * vx + dy1 * vy;

            double dx = x1 - x0;
            double dy = y1 - y0;

            // Coefficients for the quadratic equation At^2 + Bt + C = 0
            double A = (dx * dx) / (ellipse2D.A * ellipse2D.A) + (dy * dy) / (ellipse2D.B * ellipse2D.B);
            double Bcoef = 2 * ((x0 * dx) / (ellipse2D.A * ellipse2D.A) + (y0 * dy) / (ellipse2D.B * ellipse2D.B));
            double C = (x0 * x0) / (ellipse2D.A * ellipse2D.A) + (y0 * y0) / (ellipse2D.B * ellipse2D.B) - 1;

            double discriminant = Bcoef * Bcoef - 4 * A * C;

            List<Point2D> results = new List<Point2D>();

            if (discriminant < tolerance)
            {
                return results; // no intersection
            }

            double sqrtDisc = System.Math.Sqrt(discriminant);
            double t1 = (-Bcoef - sqrtDisc) / (2 * A);
            double t2 = (-Bcoef + sqrtDisc) / (2 * A);

            foreach (var t in new[] { t1, t2 })
            {
                if (t >= -tolerance && t <= 1 + tolerance)
                {
                    double x = segment2D[0].X + t * (segment2D[1].X - segment2D[0].X);
                    double y = segment2D[0].Y + t * (segment2D[1].Y - segment2D[0].Y);
                    results.Add((x, y));
                }
            }

            return results;
        }

        public static List<Point2D> IntersectionPoints(this Ellipse2D ellipse2D, Line2D line2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            // Translate points to ellipse-centered coordinates
            double dx0 = line2D.Origin.X - ellipse2D.Center.X;
            double dy0 = line2D.Origin.Y - ellipse2D.Center.Y;
            double dx1 = line2D.Origin.X - ellipse2D.Center.X;
            double dy1 = line2D.Origin.Y - ellipse2D.Center.Y;

            // Rotate into ellipse-aligned coordinates
            double ux = ellipse2D.Direction.X;
            double uy = ellipse2D.Direction.Y;
            double vx = -uy;
            double vy = ux;

            double x0 = dx0 * ux + dy0 * uy;
            double y0 = dx0 * vx + dy0 * vy;
            double x1 = dx1 * ux + dy1 * uy;
            double y1 = dx1 * vx + dy1 * vy;

            double dx = x1 - x0;
            double dy = y1 - y0;

            // Coefficients for the quadratic equation At^2 + Bt + C = 0
            double A = (dx * dx) / (ellipse2D.A * ellipse2D.A) + (dy * dy) / (ellipse2D.B * ellipse2D.B);
            double Bcoef = 2 * ((x0 * dx) / (ellipse2D.A * ellipse2D.A) + (y0 * dy) / (ellipse2D.B * ellipse2D.B));
            double C = (x0 * x0) / (ellipse2D.A * ellipse2D.A) + (y0 * y0) / (ellipse2D.B * ellipse2D.B) - 1;

            double discriminant = Bcoef * Bcoef - 4 * A * C;

            List<Point2D> results = new List<Point2D>();

            if (discriminant < tolerance)
            {
                return results; // no intersection
            }

            double sqrtDisc = System.Math.Sqrt(discriminant);
            double t1 = (-Bcoef - sqrtDisc) / (2 * A);
            double t2 = (-Bcoef + sqrtDisc) / (2 * A);

            foreach (var t in new[] { t1, t2 })
            {
                double x = line2D.Origin.X + t * (line2D.Origin.X - line2D.Origin.X);
                double y = line2D.Origin.Y + t * (line2D.Origin.Y - line2D.Origin.Y);
                results.Add((x, y));
            }

            return results;
        }

        public static List<Point2D> IntersectionPoints(this Ellipse2D ellipse2D, ISegmentable2D segmentable2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (ellipse2D == null || segmentable2D == null)
            {
                return null;
            }

            List<Segment2D> segment2Ds = segmentable2D.GetSegments();
            if (segment2Ds == null)
            {
                return null;
            }

            List<Point2D> result = new List<Point2D>();
            foreach (Segment2D segment2D in segment2Ds)
            {
                List<Point2D> point2Ds = IntersectionPoints(ellipse2D, segment2D, tolerance);
                if (point2Ds == null)
                {
                    continue;
                }

                for (int i = 0; i < point2Ds.Count; i++)
                {
                    result.Add(point2Ds[i], tolerance);
                }
            }

            return result;
        }
    }
}

using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the intersection points between two collections of 2D segments.
        /// </summary>
        /// <param name="segment2Ds_1">The first <see cref="IEnumerable{Segment2D}"/> collection of segments.</param>
        /// <param name="segment2Ds_2">The second <see cref="IEnumerable{Segment2D}"/> collection of segments.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used for intersection calculations.</param>
        /// <returns>A <see cref="List{Point2D}"/> containing the intersection points, or <c>null</c> if either input collection is null.</returns>
        public static List<Point2D>? IntersectionPoints(this IEnumerable<Segment2D>? segment2Ds_1, IEnumerable<Segment2D>? segment2Ds_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            return IntersectionPoints(segment2Ds_1, segment2Ds_2, int.MaxValue, tolerance);
        }

        /// <summary>
        /// Calculates the intersection points between an <see cref="ISegmentable2D"/> object and a collection of <see cref="Segment2D"/> segments.
        /// </summary>
        /// <param name="segmentable2D">The <see cref="ISegmentable2D"/> object to check for intersections.</param>
        /// <param name="segment2Ds">An <see cref="IEnumerable{Segment2D}"/> containing the segments to intersect with.</param>
        /// <param name="tolerace">A <see cref="double"/> value representing the distance tolerance for intersection detection.</param>
        /// <returns>A <see cref="List{Point2D}"/> of intersection points if successful; otherwise, <c>null</c>.</returns>
        public static List<Point2D>? IntersectionPoints(this ISegmentable2D? segmentable2D, IEnumerable<Segment2D>? segment2Ds, double tolerace = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segmentable2D == null || segment2Ds == null)
            {
                return null;
            }

            return IntersectionPoints(segmentable2D.GetSegments(), segment2Ds, tolerace);
        }

        /// <summary>
        /// Calculates the intersection points between two segmentable 2D objects.
        /// </summary>
        /// <param name="segmentable2D_1">The first <see cref="ISegmentable2D"/> object to check for intersections.</param>
        /// <param name="segmentable2D_2">The second <see cref="ISegmentable2D"/> object to check for intersections.</param>
        /// <param name="tolerace">The <see cref="double"/> distance tolerance used to determine if points intersect.</param>
        /// <returns>A <see cref="List{Point2D}"/> containing the intersection points, or <c>null</c> if either <paramref name="segmentable2D_1"/> or <paramref name="segmentable2D_2"/> is <c>null</c>.</returns>
        public static List<Point2D>? IntersectionPoints(this ISegmentable2D? segmentable2D_1, ISegmentable2D? segmentable2D_2, double tolerace = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segmentable2D_1 == null || segmentable2D_2 == null)
            {
                return null;
            }

            return IntersectionPoints(segmentable2D_1.GetSegments(), segmentable2D_2.GetSegments(), tolerace);
        }

        /// <summary>
        /// Calculates the intersection points between a segmentable 2D object and a collection of other segmentable 2D objects.
        /// </summary>
        /// <typeparam name="T">The type of the segmentable 2D object, which must implement <see cref="ISegmentable2D"/>.</typeparam>
        /// <param name="segmentable2D">The <see cref="ISegmentable2D"/> object to check for intersections.</param>
        /// <param name="segmentable2Ds">An <see cref="IEnumerable{ISegmentable2D}"/> of segmentable 2D objects to intersect with the source object.</param>
        /// <param name="tolerace">The distance tolerance used for intersection calculations as a <see cref="double"/>.</param>
        /// <returns>A <see cref="List{Point2D}"/> containing the found intersection points, or <c>null</c> if either input is null.</returns>
        public static List<Point2D>? IntersectionPoints<T>(this ISegmentable2D? segmentable2D, IEnumerable<ISegmentable2D>? segmentable2Ds, double tolerace = DiGi.Core.Constants.Tolerance.Distance) where T : ISegmentable2D
        {
            if (segmentable2D == null || segmentable2Ds == null)
            {
                return null;
            }

            return IntersectionPoints(segmentable2D.GetSegments(), segmentable2Ds.Segments(), tolerace);
        }

        /// <summary>
        /// Calculates the intersection points between two collections of <see cref="Segment2D"/> objects.
        /// </summary>
        /// <param name="segment2Ds_1">The first collection of <see cref="Segment2D"/> objects.</param>
        /// <param name="segment2Ds_2">The second collection of <see cref="Segment2D"/> objects.</param>
        /// <param name="maxCount">The maximum number of intersection points to find as an <see cref="int"/>.</param>
        /// <param name="tolerance">The distance tolerance used for the calculation as a <see cref="double"/>.</param>
        /// <returns>A <see cref="List{Point2D}"/> containing the found intersection points, or <c>null</c> if either collection is null or empty, or if <paramref name="maxCount"/> is less than 1.</returns>
        public static List<Point2D>? IntersectionPoints(this IEnumerable<Segment2D>? segment2Ds_1, IEnumerable<Segment2D>? segment2Ds_2, int maxCount, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
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

            List<Point2D> result = [];
            for (int i = 0; i < count_1; i++)
            {
                Segment2D? segment2D_1 = segment2Ds_1.ElementAt(i);
                if (segment2D_1 == null)
                {
                    continue;
                }

                for (int j = 0; j < count_2; j++)
                {
                    Segment2D? segment2D_2 = segment2Ds_2.ElementAt(j);
                    if (segment2D_2 == null)
                    {
                        continue;
                    }

                    Point2D? point2D = segment2D_1.IntersectionPoint(segment2D_2, tolerance);
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

        /// <summary>
        /// Calculates the intersection points between a ray or line defined by a point and a vector, and a collection of segmentable 2D objects.
        /// </summary>
        /// <param name="point2D">The <see cref="Point2D"/> starting point.</param>
        /// <param name="vector2D">The <see cref="Vector2D"/> direction vector.</param>
        /// <param name="segmentable2Ds">An <see cref="IEnumerable{ISegmentable2D}"/> of segmentable 2D objects to check for intersections.</param>
        /// <param name="keepDirection">A <see cref="bool"/> indicating whether to keep the direction of the intersection points.</param>
        /// <param name="removeCollinear">A <see cref="bool"/> indicating whether collinear points should be removed.</param>
        /// <param name="sort">A <see cref="bool"/> indicating whether the resulting intersection points should be sorted.</param>
        /// <param name="selfIntersection">A <see cref="bool"/> indicating whether self-intersections are considered.</param>
        /// <param name="intersectionSegment2Ds">When this method returns, contains a <see cref="List{Segment2D}"/> of the segments that were intersected; otherwise, null.</param>
        /// <param name="tolerance">A <see cref="double"/> representing the distance tolerance for intersection calculations.</param>
        /// <returns>A <see cref="List{Point2D}"/> containing the intersection points if successful; otherwise, null.</returns>
        public static List<Point2D>? IntersectionPoints(this Point2D? point2D, Vector2D? vector2D, IEnumerable<ISegmentable2D>? segmentable2Ds, bool keepDirection, bool removeCollinear, bool sort, bool selfIntersection, out List<Segment2D>? intersectionSegment2Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            intersectionSegment2Ds = null;
            if (point2D == null || vector2D == null || segmentable2Ds == null)
            {
                return null;
            }

            List<Segment2D> segment2Ds = [];
            foreach (ISegmentable2D segmentable2D in segmentable2Ds)
            {
                List<Segment2D>? segment2Ds_Temp = segmentable2D?.GetSegments();
                if (segment2Ds_Temp == null || segment2Ds_Temp.Count == 0)
                {
                    continue;
                }

                segment2Ds.AddRange(segment2Ds_Temp);
            }

            return IntersectionPoints(point2D, vector2D, segment2Ds, keepDirection, removeCollinear, sort, selfIntersection, out intersectionSegment2Ds, tolerance);
        }

        /// <summary>
        /// Calculates the intersection points between a line defined by a point and a vector, and a collection of 2D segments.
        /// </summary>
        /// <param name="point2D">The starting <see cref="Point2D"/> of the line.</param>
        /// <param name="vector2D">The direction <see cref="Vector2D"/> of the line.</param>
        /// <param name="segment2Ds">An <c>IEnumerable&lt;Segment2D&gt;</c> containing the segments to check for intersections.</param>
        /// <param name="keepDirection">A <see cref="bool"/> indicating whether to keep only points that follow the direction of the vector.</param>
        /// <param name="removeCollinear">A <see cref="bool"/> indicating whether collinear segments should be removed from the results.</param>
        /// <param name="sort">A <see cref="bool"/> indicating whether the resulting intersection points should be sorted.</param>
        /// <param name="selfIntersection">A <see cref="bool"/> indicating whether to include self-intersections.</param>
        /// <param name="intersectionSegment2Ds">When this method returns, contains a <c>List&lt;Segment2D&gt;</c> of segments that were intersected.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used for intersection calculations.</param>
        /// <returns>A <c>List&lt;Point2D&gt;</c> containing the intersection points, or null if no intersections are found or input parameters are invalid.</returns>
        public static List<Point2D>? IntersectionPoints(this Point2D? point2D, Vector2D? vector2D, IEnumerable<Segment2D>? segment2Ds, bool keepDirection, bool removeCollinear, bool sort, bool selfIntersection, out List<Segment2D>? intersectionSegment2Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            intersectionSegment2Ds = null;
            if (point2D == null || segment2Ds == null)
            {
                return null;
            }

            Vector2D? unit = vector2D?.Unit;
            if (unit is null)
            {
                return null;
            }

            Dictionary<Point2D, Segment2D> dictionary = [];

            Segment2D segment2D = new(point2D, vector2D);
            foreach (Segment2D segment2D_Temp in segment2Ds)
            {
                if (removeCollinear && segment2D.Collinear(segment2D_Temp))
                {
                    continue;
                }

                Point2D? point2D_Intersection = IntersectionPoint(segment2D, segment2D_Temp, out Point2D? point2D_closest_1, out Point2D? point2D_closest_2, tolerance);
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
                        if (!unit.AlmostEquals(new Vector2D(point2D_closest_1, point2D_closest_2).Unit, tolerance))
                        {
                            continue;
                        }
                    }

                    dictionary[point2D_Intersection] = segment2D_Temp;
                }
            }

            if (sort)
            {
                List<Point2D> point2Ds = [.. dictionary.Keys];
                DiGi.Core.Modify.Sort(point2Ds, x => x.Distance(point2D));

                Dictionary<Point2D, Segment2D> dictionary_Temp = [];
                foreach (Point2D point2D_Temp in point2Ds)
                {
                    dictionary_Temp[point2D_Temp] = dictionary[point2D_Temp];
                }

                dictionary = dictionary_Temp;
            }

            intersectionSegment2Ds = [.. dictionary.Values];

            return [.. dictionary.Keys];
        }

        /// <summary>
        /// Returns intersection points between line and segmentable2D
        /// </summary>
        /// <param name="line2D">Line2D to be intersected</param>
        /// <param name="segmentable2Ds">Segmentable2D to be intersected</param>
        /// <param name="intersectionSegment2Ds">Segmentable2D segments intersected by line</param>
        /// <param name="tolerance">Tolerance</param>
        /// <returns>Intersection Points</returns>
        public static List<Point2D>? IntersectionPoints(this Line2D? line2D, IEnumerable<ISegmentable2D> segmentable2Ds, out List<Segment2D>? intersectionSegment2Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            intersectionSegment2Ds = null;

            if (line2D is null || segmentable2Ds == null)
            {
                return null;
            }

            return IntersectionPoints(line2D.Origin, line2D.Direction, segmentable2Ds, false, true, false, true, out intersectionSegment2Ds, tolerance);
        }

        /// <summary>
        /// Calculates the intersection points between a <see cref="Line2D"/> and a collection of <see cref="ISegmentable2D"/> objects.
        /// </summary>
        /// <param name="line2D">The <see cref="Line2D"/> to check for intersections.</param>
        /// <param name="segmentable2Ds">A collection of <see cref="ISegmentable2D"/> objects to intersect with the line.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used for intersection calculations.</param>
        /// <returns>A <see cref="List{Point2D}"/> containing the intersection points, or <c>null</c> if either the <paramref name="line2D"/> or <paramref name="segmentable2Ds"/> is null.</returns>
        public static List<Point2D>? IntersectionPoints(this Line2D? line2D, IEnumerable<ISegmentable2D>? segmentable2Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (line2D is null || segmentable2Ds is null)
            {
                return null;
            }

            return IntersectionPoints(line2D.Origin, line2D.Direction, segmentable2Ds, false, true, false, true, out _, tolerance);
        }

        /// <summary>
        /// Calculates the intersection points between a <see cref="Line2D"/> and an <see cref="ISegmentable2D"/>.
        /// </summary>
        /// <param name="line2D">The <see cref="Line2D"/> to check for intersections.</param>
        /// <param name="segmentable2D">The <see cref="ISegmentable2D"/> object containing segments to intersect with.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance used for the intersection calculation.</param>
        /// <returns>A <see cref="List{Point2D}"/> containing the intersection points, or <c>null</c> if the <see cref="Line2D"/> or segmentable object is null.</returns>
        public static List<Point2D>? IntersectionPoints(this Line2D? line2D, ISegmentable2D segmentable2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (line2D is null)
            {
                return null;
            }

            List<Segment2D>? segment2Ds = segmentable2D?.GetSegments();
            if (segment2Ds == null)
            {
                return null;
            }

            List<Point2D> result = [];
            foreach (Segment2D segment2D in segment2Ds)
            {
                Point2D? point2D = line2D.IntersectionPoint(segment2D, tolerance);
                if (point2D == null)
                {
                    continue;
                }

                result!.Add(point2D, tolerance);
            }

            return result;
        }

        /// <summary>
        /// Calculates the intersection points between a circle and a line defined by two points.
        /// </summary>
        /// <param name="x">The X-coordinate of the center of the circle as a <see cref="double"/>.</param>
        /// <param name="y">The Y-coordinate of the center of the circle as a <see cref="double"/>.</param>
        /// <param name="radius">The radius of the circle as a <see cref="double"/>.</param>
        /// <param name="point2D_1">The first point defining the line as a <see cref="Point2D"/>?</param>
        /// <param name="point2D_2">The second point defining the line as a <see cref="Point2D"/>?</param>
        /// <param name="tolerance">The distance tolerance used for calculations as a <see cref="double"/>.</param>
        /// <returns>A <see cref="List{Point2D}"/>? containing the intersection points, or <see langword="null"/> if no intersections exist or input points are invalid.</returns>
        public static List<Point2D>? IntersectionPoints(double x, double y, double radius, Point2D? point2D_1, Point2D? point2D_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point2D_1 is null || point2D_2 is null)
            {
                return null;
            }

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

            List<Point2D> result = [];

            if (System.Math.Abs(det) < tolerance)
            {
                t = -b / (2 * a);
                result.Add(new(point2D_1.X + t * dx, point2D_1.Y + t * dy));
                return result;
            }

            t = (double)((-b + System.Math.Sqrt(det)) / (2 * a));
            result.Add(new Point2D(point2D_1.X + t * dx, point2D_1.Y + t * dy));
            t = (double)((-b - System.Math.Sqrt(det)) / (2 * a));
            result.Add(new Point2D(point2D_1.X + t * dx, point2D_1.Y + t * dy));

            return result;
        }

        /// <summary>
        /// Calculates the intersection points between a circle and a line.
        /// </summary>
        /// <param name="circle2D">The <see cref="Circle2D"/> instance to intersect.</param>
        /// <param name="line2D">The <see cref="Line2D"/> instance to intersect.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance for intersection calculations.</param>
        /// <returns>A <see cref="List{Point2D}"/> containing the intersection points, or <c>null</c> if either input is null or required properties are missing.</returns>
        public static List<Point2D>? IntersectionPoints(this Circle2D? circle2D, Line2D? line2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (circle2D is null || line2D is null)
            {
                return null;
            }

            Point2D? center = circle2D.Center;
            if (center == null)
            {
                return null;
            }

            double radius = circle2D.Radius;

            Point2D? point2D_1 = line2D.Origin;
            if (point2D_1 == null)
            {
                return null;
            }

            Point2D? point2D_2 = new(point2D_1);
            if (point2D_1 == null)
            {
                return null;
            }

            point2D_2.Move(line2D.Direction);

            return IntersectionPoints(center.X, center.Y, radius, point2D_1, point2D_2, tolerance);
        }

        /// <summary>
        /// Calculates the intersection points between a circle and a line segment.
        /// </summary>
        /// <param name="circle2D">The <see cref="Circle2D"/> instance to check for intersections.</param>
        /// <param name="segment2D">The <see cref="Segment2D"/> instance to check for intersections.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance used for calculations.</param>
        /// <returns>A <see cref="List{Point2D}"/> containing the intersection points, or <c>null</c> if either input is <c>null</c> or the circle center is not defined.</returns>
        public static List<Point2D>? IntersectionPoints(this Circle2D? circle2D, Segment2D? segment2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (circle2D == null || segment2D == null)
            {
                return null;
            }

            Point2D? center = circle2D.Center;
            if (center == null)
            {
                return null;
            }

            double radius = circle2D.Radius;

            Point2D? point2D_1 = segment2D.Start;
            if (point2D_1 == null)
            {
                return null;
            }

            Point2D? point2D_2 = segment2D.End;
            if (point2D_2 == null)
            {
                return null;
            }

            List<Point2D>? result = IntersectionPoints(center.X, center.Y, radius, point2D_1, point2D_2, tolerance);
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

        /// <summary>
        /// Calculates the intersection points between a <see cref="Circle2D"/> and an <see cref="ISegmentable2D"/>.
        /// </summary>
        /// <param name="circle2D">The <see cref="Circle2D"/> to check for intersections.</param>
        /// <param name="segmentable2D">The <see cref="ISegmentable2D"/> object to check for intersections.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used for the intersection calculation.</param>
        /// <returns>A <see cref="List{Point2D}"/> containing the intersection points, or <c>null</c> if either input is <c>null</c> or no segments are found.</returns>
        public static List<Point2D>? IntersectionPoints(this Circle2D? circle2D, ISegmentable2D? segmentable2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (circle2D == null || segmentable2D == null)
            {
                return null;
            }

            List<Segment2D>? segment2Ds = segmentable2D.GetSegments();
            if (segment2Ds == null)
            {
                return null;
            }

            List<Point2D> result = [];
            foreach (Segment2D segment2D in segment2Ds)
            {
                List<Point2D>? point2Ds = IntersectionPoints(circle2D, segment2D, tolerance);
                if (point2Ds == null)
                {
                    continue;
                }

                for (int i = 0; i < point2Ds.Count; i++)
                {
                    if (point2Ds[i] is null)
                    {
                        continue;
                    }

                    result!.Add(point2Ds[i], tolerance);
                }
            }

            return result;
        }

        /// <summary>
        /// Calculates the intersection points between an ellipse and a line segment.
        /// </summary>
        /// <param name="ellipse2D">The <see cref="Ellipse2D"/> to intersect.</param>
        /// <param name="segment2D">The <see cref="Segment2D"/> to intersect.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance used for the intersection calculation.</param>
        /// <returns>A <see cref="List{Point2D}"/> containing the intersection points, or <c>null</c> if either input is null or the segment is invalid.</returns>
        public static List<Point2D>? IntersectionPoints(this Ellipse2D? ellipse2D, Segment2D? segment2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (ellipse2D is null || segment2D is null)
            {
                return null;
            }

            Point2D? point2D_1 = segment2D[0];
            if (point2D_1 is null)
            {
                return null;
            }

            Point2D? point2D_2 = segment2D[1];
            if (point2D_2 is null)
            {
                return null;
            }

            Point2D? center = ellipse2D.Center;
            if (center is null)
            {
                return null;
            }

            Vector2D? directionA = ellipse2D.DirectionA;
            if (directionA is null)
            {
                return null;
            }

            // Translate points to ellipse-centered coordinates
            double dx0 = point2D_1.X - center.X;
            double dy0 = point2D_1.Y - center.Y;
            double dx1 = point2D_2.X - center.X;
            double dy1 = point2D_2.Y - center.Y;

            // Rotate into ellipse-aligned coordinates
            double ux = directionA.X;
            double uy = directionA.Y;
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

            List<Point2D> results = [];

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
                    double x = point2D_1.X + t * (point2D_2.X - point2D_1.X);
                    double y = point2D_1.Y + t * (point2D_2.Y - point2D_1.Y);
                    results.Add((x, y));
                }
            }

            return results;
        }

        /// <summary>
        /// Calculates the intersection points between an ellipse and a line.
        /// </summary>
        /// <param name="ellipse2D">The <see cref="Ellipse2D"/> instance to intersect.</param>
        /// <param name="line2D">The <see cref="Line2D"/> instance to intersect.</param>
        /// <param name="tolerance">A <see cref="double"/> value specifying the distance tolerance for the intersection calculation.</param>
        /// <returns>A <see cref="List{Point2D}"/> containing the intersection points, or <c>null</c> if either input is null.</returns>
        public static List<Point2D>? IntersectionPoints(this Ellipse2D? ellipse2D, Line2D? line2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            Point2D? center = ellipse2D?.Center;
            if (center is null)
            {
                return null;
            }

            Point2D? origin = line2D?.Origin;
            if (origin is null)
            {
                return null;
            }

            Vector2D? directionA = ellipse2D?.DirectionA;
            if (directionA is null)
            {
                return null;
            }

            // Translate points to ellipse-centered coordinates
            double dx0 = origin.X - center.X;
            double dy0 = origin.Y - center.Y;
            double dx1 = origin.X - center.X;
            double dy1 = origin.Y - center.Y;

            // Rotate into ellipse-aligned coordinates
            double ux = directionA.X;
            double uy = directionA.Y;
            double vx = -uy;
            double vy = ux;

            double x0 = dx0 * ux + dy0 * uy;
            double y0 = dx0 * vx + dy0 * vy;
            double x1 = dx1 * ux + dy1 * uy;
            double y1 = dx1 * vx + dy1 * vy;

            double dx = x1 - x0;
            double dy = y1 - y0;

            // Coefficients for the quadratic equation At^2 + Bt + C = 0
            double A = (dx * dx) / (ellipse2D!.A * ellipse2D.A) + (dy * dy) / (ellipse2D.B * ellipse2D.B);
            double Bcoef = 2 * ((x0 * dx) / (ellipse2D.A * ellipse2D.A) + (y0 * dy) / (ellipse2D.B * ellipse2D.B));
            double C = (x0 * x0) / (ellipse2D.A * ellipse2D.A) + (y0 * y0) / (ellipse2D.B * ellipse2D.B) - 1;

            double discriminant = Bcoef * Bcoef - 4 * A * C;

            List<Point2D> results = [];

            if (discriminant < tolerance)
            {
                return results; // no intersection
            }

            double sqrtDisc = System.Math.Sqrt(discriminant);
            double t1 = (-Bcoef - sqrtDisc) / (2 * A);
            double t2 = (-Bcoef + sqrtDisc) / (2 * A);

            foreach (var t in new[] { t1, t2 })
            {
                double x = origin.X + t * (origin.X - origin.X);
                double y = origin.Y + t * (origin.Y - origin.Y);
                results.Add((x, y));
            }

            return results;
        }

        /// <summary>
        /// Calculates the intersection points between an <see cref="Ellipse2D"/> and an <see cref="ISegmentable2D"/>.
        /// </summary>
        /// <param name="ellipse2D">The <see cref="Ellipse2D"/> to check for intersections.</param>
        /// <param name="segmentable2D">The <see cref="ISegmentable2D"/> object containing segments to check for intersections.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance used for intersection calculations.</param>
        /// <returns>A <see cref="List{Point2D}"/> containing the intersection points if successful; otherwise, null.</returns>
        public static List<Point2D>? IntersectionPoints(this Ellipse2D? ellipse2D, ISegmentable2D? segmentable2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (ellipse2D == null || segmentable2D == null)
            {
                return null;
            }

            List<Segment2D>? segment2Ds = segmentable2D.GetSegments();
            if (segment2Ds == null)
            {
                return null;
            }

            List<Point2D> result = [];
            foreach (Segment2D segment2D in segment2Ds)
            {
                List<Point2D>? point2Ds = IntersectionPoints(ellipse2D, segment2D, tolerance);
                if (point2Ds == null)
                {
                    continue;
                }

                for (int i = 0; i < point2Ds.Count; i++)
                {
                    if (point2Ds[i] is null)
                    {
                        continue;
                    }

                    result!.Add(point2Ds[i], tolerance);
                }
            }

            return result;
        }
    }
}
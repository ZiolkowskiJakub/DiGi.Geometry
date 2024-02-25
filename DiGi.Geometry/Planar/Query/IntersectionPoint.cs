using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Intersection of two segments/lines represented by four point2Ds with given tolerance.
        /// </summary>
        /// <param name="point2D_1_Start">Segment 1 start Point2D</param>
        /// <param name="point2D_1_End">Segment 1 end Point2D</param>
        /// <param name="point2D_2_Start">Segment 2 start Point2D</param>
        /// <param name="point2D_2_End">Segment 2 end Point2D</param>
        /// <param name="bounded">if bounded set to false then segments will be treated as lines (unlimited)</param>
        /// <param name="tolerance">tolerance</param>
        /// <returns>Intersection Point2D</returns>
        public static Point2D IntersectionPoint(Point2D point2D_1_Start, Point2D point2D_1_End, Point2D point2D_2_Start, Point2D point2D_2_End, bool bounded, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            Point2D point2D_Closest1 = null;
            Point2D point2D_Closest2 = null;

            Point2D point2D_Intersection = IntersectionPoint(point2D_1_Start, point2D_1_End, point2D_2_Start, point2D_2_End, out point2D_Closest1, out point2D_Closest2, tolerance);
            if (bounded && (point2D_Closest1 != null || point2D_Closest2 != null))
            {
                return null;
            }

            return point2D_Intersection;
        }

        /// <summary>
        /// Intersection of two segments represented by four point2Ds with given tolerance. Output points point2D_Closest1 and point2D_Closest2 are null if intersection point is on segments
        /// </summary>
        /// <param name="point2D_1_Start">Segment 1 start Point2D</param>
        /// <param name="point2D_1_End">Segment 1 end Point2D</param>
        /// <param name="point2D_2_Start">Segment 2 start Point2D</param>
        /// <param name="point2D_2_End">Segment 2 end Point2D</param>
        /// <param name="point2D_Closest1">Closest point for Segment 1</param>
        /// <param name="point2D_Closest2">Closest point for Segment 2</param>
        /// <param name="tolerance"></param>
        /// <returns></returns>
        public static Point2D IntersectionPoint(Point2D point2D_1_Start, Point2D point2D_1_End, Point2D point2D_2_Start, Point2D point2D_2_End, out Point2D point2D_Closest1, out Point2D point2D_Closest2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            point2D_Closest1 = null;
            point2D_Closest2 = null;

            if (point2D_1_Start == null || point2D_1_End == null || point2D_2_Start == null || point2D_2_End == null)
            {
                return null;
            }

            // Get the segments' parameters.
            double dx12 = point2D_1_End.X - point2D_1_Start.X;
            double dy12 = point2D_1_End.Y - point2D_1_Start.Y;
            double dx34 = point2D_2_End.X - point2D_2_Start.X;
            double dy34 = point2D_2_End.Y - point2D_2_Start.Y;

            // Solve for t1 and t2
            double denominator = (dy12 * dx34 - dx12 * dy34);
            if (double.IsNaN(denominator) || System.Math.Abs(denominator) < tolerance)
            {
                return null;
            }

            double t1 = ((point2D_1_Start.X - point2D_2_Start.X) * dy34 + (point2D_2_Start.Y - point2D_1_Start.Y) * dx34) / denominator;

            // The lines are parallel (or close enough to it).
            if (double.IsInfinity(t1) || double.IsNaN(t1))
            {
                return null;
            }

            double t2 = ((point2D_2_Start.X - point2D_1_Start.X) * dy12 + (point2D_1_Start.Y - point2D_2_Start.Y) * dx12) / -denominator;

            // Find the point of intersection.
            Point2D point2D_Intersection = new Point2D(point2D_1_Start.X + dx12 * t1, point2D_1_Start.Y + dy12 * t1);

            double t1_Temp = DiGi.Core.Query.Round(t1, tolerance);
            double t2_Temp = DiGi.Core.Query.Round(t2, tolerance);

            // The segments intersect if t1 and t2 are between 0 and 1.
            if (((t1_Temp >= 0) && (t1_Temp <= 1) && (t2_Temp >= 0) && (t2_Temp <= 1)))
            {
                return point2D_Intersection;
            }

            // Find the closest points on the segments.
            if (t1 < 0)
            {
                t1 = 0;
            }
            else if (t1 > 1)
            {
                t1 = 1;
            }

            if (t2 < 0)
            {
                t2 = 0;
            }
            else if (t2 > 1)
            {
                t2 = 1;
            }

            point2D_Closest1 = new Point2D(point2D_1_Start.X + dx12 * t1, point2D_1_Start.Y + dy12 * t1);
            point2D_Closest2 = new Point2D(point2D_2_Start.X + dx34 * t2, point2D_2_Start.Y + dy34 * t2);
            return point2D_Intersection;
        }
    
        public static Point2D IntersectionPoint(Segment2D segment2D_1, Segment2D segment2D_2, out Point2D point2D_Closest1, out Point2D point2D_Closest2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            point2D_Closest1 = null;
            point2D_Closest2 = null;

            if (segment2D_1 == null || segment2D_2 == null)
            {
                return null;
            }

            return IntersectionPoint(segment2D_1[0], segment2D_1[1], segment2D_2[0], segment2D_2[1], out point2D_Closest1, out point2D_Closest2, tolerance);
        }
    }

}

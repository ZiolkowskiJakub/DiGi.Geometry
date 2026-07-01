using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the closest point on a line or line segment defined by two points relative to a target point.
        /// </summary>
        /// <param name="point2D">The target <c>Point2D?</c> point.</param>
        /// <param name="point2D_1">The first <c>Point2D?</c> point defining the line or segment.</param>
        /// <param name="point2D_2">The second <c>Point2D?</c> point defining the line or segment.</param>
        /// <param name="bounded">A <see cref="bool" /> value indicating whether the result should be bounded to the line segment between the two points.</param>
        /// <returns>The closest <c>Point2D?</c> point on the line or segment, or null if any of the input points are null.</returns>
        public static Point2D? ClosestPoint(this Point2D? point2D, Point2D? point2D_1, Point2D? point2D_2, bool bounded)
        {
            return ClosestPoint(point2D, point2D_1, point2D_2, bounded, bounded);
        }

        /// <summary>
        /// Calculates the closest point on a line or line segment defined by two points relative to a target point.
        /// </summary>
        /// <param name="point2D">The <c>Point2D?</c> target point.</param>
        /// <param name="point2D_1">The <c>Point2D?</c> first point defining the line or segment.</param>
        /// <param name="point2D_2">The <c>Point2D?</c> second point defining the line or segment.</param>
        /// <param name="bounded_1">A <see cref="bool" /> value indicating whether the result is bounded by the first point.</param>
        /// <param name="bounded_2">A <see cref="bool" /> value indicating whether the result is bounded by the second point.</param>
        /// <returns>The closest <c>Point2D?</c> on the line or segment, or null if any of the input points are null.</returns>
        public static Point2D? ClosestPoint(this Point2D? point2D, Point2D? point2D_1, Point2D? point2D_2, bool bounded_1, bool bounded_2)
        {
            if (point2D == null || point2D_1 == null || point2D_2 == null)
            {
                return null;
            }

            double a = point2D.X - point2D_1.X;
            double b = point2D.Y - point2D_1.Y;
            double c = point2D_2.X - point2D_1.X;
            double d = point2D_2.Y - point2D_1.Y;

            double dot = a * c + b * d;
            double len_sq = c * c + d * d;
            double parameter = -1;
            if (len_sq != 0)
            {
                parameter = dot / len_sq;
            }

            if (parameter < 0 && bounded_1)
            {
                return new Point2D(point2D_1);
            }

            if (parameter > 1 && bounded_2)
            {
                return new Point2D(point2D_2);
            }

            return new Point2D(point2D_1.X + parameter * c, point2D_1.Y + parameter * d);
        }

        /// <summary>
        /// Calculates the closest point on an <see cref="ISegmentable2D"/> object to a given <see cref="Point2D"/>.
        /// </summary>
        /// <param name="point2D">The <see cref="Point2D"/> for which the closest point is being sought.</param>
        /// <param name="segmentable2D">The <see cref="ISegmentable2D"/> object to find the closest point on.</param>
        /// <returns>The closest <see cref="Point2D"/> found, or <see langword="null"/> if no point could be determined.</returns>
        public static Point2D? ClosestPoint(this Point2D? point2D, ISegmentable2D segmentable2D)
        {
            return ClosestPoint(point2D, segmentable2D?.GetSegments(), out _);
        }

        /// <summary>
        /// Calculates the closest point on an <see cref="ISegmentable2D"/> object to a given <see cref="Point2D"/>.
        /// </summary>
        /// <param name="point2D">The <see cref="Point2D"/> from which the distance is measured.</param>
        /// <param name="segmentable2D">The <see cref="ISegmentable2D"/> object to find the closest point on.</param>
        /// <param name="distance">When this method returns, contains the distance between the input <see cref="Point2D"/> and the resulting closest <see cref="Point2D"/>.</param>
        /// <returns>The closest <see cref="Point2D"/> found on the <see cref="ISegmentable2D"/> object, or <c>null</c> if no point could be determined.</returns>
        public static Point2D? ClosestPoint(this Point2D? point2D, ISegmentable2D? segmentable2D, out double distance)
        {
            return ClosestPoint(point2D, segmentable2D?.GetSegments(), out distance);
        }

        /// <summary>
        /// Finds the closest point among a collection of line segments to a given point.
        /// </summary>
        /// <param name="point2D">The source <see cref="Point2D"/> point.</param>
        /// <param name="segment2Ds">An <see cref="IEnumerable{T}"/> of <see cref="Segment2D"/> objects to search.</param>
        /// <param name="distance">When this method returns, contains the distance between the source <see cref="Point2D"/> and the closest point found; otherwise, <see cref="double.NaN"/>.</param>
        /// <returns>The closest <see cref="Point2D"/> found across all segments, or <see langword="null"/> if no valid point is found or inputs are null.</returns>
        public static Point2D? ClosestPoint(this Point2D? point2D, IEnumerable<Segment2D>? segment2Ds, out double distance)
        {
            distance = double.NaN;
            if (point2D == null || segment2Ds == null)
            {
                return null;
            }

            double distanceSq = double.MaxValue;
            Point2D? point2D_Result = null;
            foreach (Segment2D segment2D in segment2Ds)
            {
                Point2D? point2D_Closest = segment2D?.ClosestPoint(point2D);
                if (point2D_Closest == null)
                {
                    continue;
                }

                double dx = point2D_Closest.X - point2D.X;
                double dy = point2D_Closest.Y - point2D.Y;
                double distanceSq_Temp = dx * dx + dy * dy;
                if (distanceSq_Temp < distanceSq)
                {
                    distanceSq = distanceSq_Temp;
                    point2D_Result = point2D_Closest;
                }
            }

            distance = point2D_Result != null ? System.Math.Sqrt(distanceSq) : double.NaN;
            return point2D_Result;
        }

        /// <summary>
        /// Finds the closest point on a collection of <see cref="Segment2D"/> objects to the specified <see cref="Point2D"/>.
        /// </summary>
        /// <param name="point2D">The <see cref="Point2D"/> for which the closest point is being sought.</param>
        /// <param name="segment2Ds">An <see cref="IEnumerable{Segment2D}"/> containing the segments to evaluate.</param>
        /// <returns>The closest <see cref="Point2D"/> found on any of the provided segments, or <see langword="null"/> if the point is null, the collection is null, or the collection contains no elements.</returns>
        public static Point2D? ClosestPoint(this Point2D? point2D, IEnumerable<Segment2D>? segment2Ds)
        {
            return ClosestPoint(point2D, segment2Ds, out _);
        }

        /// <summary>
        /// Finds the closest point to a given point from a collection of segmentable 2D objects.
        /// </summary>
        /// <typeparam name="T">A type that implements <see cref="ISegmentable2D"/>.</typeparam>
        /// <param name="point2D">The source <see cref="Point2D"/> to calculate the distance from.</param>
        /// <param name="segmentable2Ds">An <see cref="IEnumerable{T}"/> of objects implementing <see cref="ISegmentable2D"/>.</param>
        /// <param name="distance">When this method returns, contains the <see cref="double"/> distance to the closest point found; otherwise, <see cref="double.NaN"/>.</param>
        /// <returns>The closest <see cref="Point2D"/> found, or <see langword="null"/> if no points are available or inputs are null.</returns>
        public static Point2D? ClosestPoint<T>(this Point2D? point2D, IEnumerable<T>? segmentable2Ds, out double distance) where T : ISegmentable2D
        {
            distance = double.NaN;
            if (point2D == null || segmentable2Ds == null)
            {
                return null;
            }

            double double_DistanceSq = double.MaxValue;
            Point2D? point2D_Result = null;

            foreach (T segmentable2D in segmentable2Ds)
            {
                if (segmentable2D == null)
                {
                    continue;
                }

                List<Segment2D>? segment2Ds = segmentable2D.GetSegments();
                if (segment2Ds == null)
                {
                    continue;
                }

                for (int int_I = 0; int_I < segment2Ds.Count; int_I++)
                {
                    Segment2D segment2D = segment2Ds[int_I];
                    if (segment2D == null)
                    {
                        continue;
                    }

                    Point2D? point2D_Closest = segment2D.ClosestPoint(point2D);
                    if (point2D_Closest == null)
                    {
                        continue;
                    }

                    double double_Dx = point2D_Closest.X - point2D.X;
                    double double_Dy = point2D_Closest.Y - point2D.Y;
                    double double_DistanceSqTemp = double_Dx * double_Dx + double_Dy * double_Dy;
                    if (double_DistanceSqTemp < double_DistanceSq)
                    {
                        double_DistanceSq = double_DistanceSqTemp;
                        point2D_Result = point2D_Closest;
                    }
                }
            }

            if (point2D_Result != null)
            {
                distance = System.Math.Sqrt(double_DistanceSq);
                return point2D_Result;
            }

            return null;
        }

        /// <summary>
        /// Finds the closest <see cref="Point2D"/> to the specified reference point from a collection of segmentable 2D objects.
        /// </summary>
        /// <typeparam name="T">A type that implements the <see cref="ISegmentable2D"/> interface.</typeparam>
        /// <param name="point2D">The reference <see cref="Point2D"/> to calculate distance from.</param>
        /// <param name="segmentable2Ds">An <see cref="IEnumerable{T}"/> of objects that implement the <see cref="ISegmentable2D"/> interface.</param>
        /// <returns>The closest <see cref="Point2D"/> found, or <see langword="null"/> if the reference point or the collection is null.</returns>
        public static Point2D? ClosestPoint<T>(this Point2D? point2D, IEnumerable<T>? segmentable2Ds) where T : ISegmentable2D
        {
            return ClosestPoint(point2D, segmentable2Ds, out _);
        }

        /// <summary>
        /// Finds the closest <see cref="Point2D"/> in a collection of points relative to a specified source point.
        /// </summary>
        /// <param name="point2D">The source <see cref="Point2D"/> used as the reference for distance calculations.</param>
        /// <param name="point2Ds">An <see cref="IEnumerable{T}"/> of <see cref="Point2D"/> objects to search through.</param>
        /// <param name="distance">When this method returns, contains the minimum <see cref="double"/> distance found; otherwise, <see cref="double.NaN"/>.</param>
        /// <returns>The closest <see cref="Point2D"/> from the collection, or <see langword="null"/> if no point is found or if either input parameter is <see langword="null"/>.</returns>
        public static Point2D? ClosestPoint(this Point2D? point2D, IEnumerable<Point2D>? point2Ds, out double distance)
        {
            distance = double.NaN;
            if (point2D == null || point2Ds == null)
            {
                return null;
            }

            double distanceSq = double.MaxValue;
            Point2D? point2D_Result = null;

            foreach (Point2D point2D_Temp in point2Ds)
            {
                if (point2D_Temp == null)
                {
                    continue;
                }

                double dx = point2D.X - point2D_Temp.X;
                double dy = point2D.Y - point2D_Temp.Y;
                double distanceSq_Temp = dx * dx + dy * dy;
                if (distanceSq_Temp < distanceSq)
                {
                    distanceSq = distanceSq_Temp;
                    point2D_Result = point2D_Temp;
                }
            }

            distance = point2D_Result != null ? System.Math.Sqrt(distanceSq) : double.NaN;
            return point2D_Result;
        }

        /// <summary>
        /// Finds the closest <see cref="Point2D"/> in a collection of points to the specified <see cref="Point2D"/>.
        /// </summary>
        /// <param name="point2D">The source <see cref="Point2D"/> for which the closest point is sought.</param>
        /// <param name="point2Ds">An <see cref="IEnumerable{T}"/> of <see cref="Point2D"/> objects to search through.</param>
        /// <returns>The closest <see cref="Point2D"/> found in the collection, or null if no point is found.</returns>
        public static Point2D? ClosestPoint(this Point2D? point2D, IEnumerable<Point2D>? point2Ds)
        {
            return ClosestPoint(point2D, point2Ds, out _);
        }
    }
}
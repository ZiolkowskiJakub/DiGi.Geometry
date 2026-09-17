using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Checks if a point lies on a segmentable geometry within a given tolerance.
        /// </summary>
        /// <param name="segmentable2D">The segmentable geometry to check.</param>
        /// <param name="point2D">The target point.</param>
        /// <param name="tolerance">The distance tolerance for the check.</param>
        /// <returns>True if the point is on the geometry, otherwise false.</returns>
        public static bool On(this ISegmentable2D? segmentable2D, Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segmentable2D is Segment2D segment2D)
            {
                return segment2D.On(point2D, tolerance);
            }

            // A polygon or polyline answers from its own points. Going through GetSegments() here built
            // one Segment2D per edge for every query point, which on a 4 000-point outline tested against
            // 150 000 points was the whole cost of the call (ZiolkowskiJakub/DiGi.Geometry#5).
            if (segmentable2D is Segmentable2D segmentable2D_Points)
            {
                return point2D != null && segmentable2D_Points.On(point2D.X, point2D.Y, tolerance);
            }

            return On(segmentable2D?.GetSegments(), point2D, tolerance);
        }

        /// <summary>
        /// Checks if a point lies on the chain of segments running through the given points within a given tolerance, without building the segments.
        /// </summary>
        /// <param name="point2Ds">The vertices of the chain, in order.</param>
        /// <param name="point2D">The target point.</param>
        /// <param name="closed">A value indicating whether the chain closes from the last vertex back to the first, as a polygon does.</param>
        /// <param name="tolerance">The distance tolerance for the check.</param>
        /// <returns>True if the point is within the tolerance of any segment of the chain; otherwise, false.</returns>
        public static bool On(this IReadOnlyList<Point2D>? point2Ds, Point2D? point2D, bool closed = false, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            return point2D != null && On(point2Ds, point2D.X, point2D.Y, closed, tolerance);
        }

        /// <summary>
        /// Checks if the point given by its coordinates lies on the chain of segments running through the given points within a given tolerance, without allocating.
        /// <para>Answers what <see cref="On(IEnumerable{Segment2D}, Point2D, double)"/> answers over <see cref="Create.Segment2Ds(IEnumerable{Point2D}, bool)"/> of the same points: a null vertex breaks the chain on both sides, and a point is on a segment when its distance to it is strictly below the tolerance.</para>
        /// </summary>
        /// <param name="point2Ds">The vertices of the chain, in order.</param>
        /// <param name="x">The X coordinate of the target point.</param>
        /// <param name="y">The Y coordinate of the target point.</param>
        /// <param name="closed">A value indicating whether the chain closes from the last vertex back to the first, as a polygon does.</param>
        /// <param name="tolerance">The distance tolerance for the check.</param>
        /// <returns>True if the point is within the tolerance of any segment of the chain; otherwise, false.</returns>
        internal static bool On(IReadOnlyList<Point2D>? point2Ds, double x, double y, bool closed, double tolerance)
        {
            if (point2Ds == null)
            {
                return false;
            }

            int count = point2Ds.Count;
            if (count < 2)
            {
                return false;
            }

            double tolerance_Squared = tolerance * tolerance;

            Point2D? point2D_First = null;
            Point2D? point2D_Last = null;

            for (int i = 1; i < count; i++)
            {
                Point2D? point2D_1 = point2Ds[i - 1];
                Point2D? point2D_2 = point2Ds[i];
                if (point2D_1 == null || point2D_2 == null)
                {
                    continue;
                }

                if (On(point2D_1, point2D_2, x, y, tolerance_Squared))
                {
                    return true;
                }

                point2D_First ??= point2D_1;
                point2D_Last = point2D_2;
            }

            if (closed && point2D_First != null && point2D_Last != null && !ReferenceEquals(point2D_First, point2D_Last))
            {
                return On(point2D_Last, point2D_First, x, y, tolerance_Squared);
            }

            return false;

            static bool On(Point2D start, Point2D end, double x, double y, double tolerance_Squared)
            {
                double vector_X = end.X - start.X;
                double vector_Y = end.Y - start.Y;

                double dot = (x - start.X) * vector_X + (y - start.Y) * vector_Y;
                double length_Squared = vector_X * vector_X + vector_Y * vector_Y;

                double t = 0.0;
                if (length_Squared > 0.0)
                {
                    t = dot / length_Squared;
                    if (t < 0.0)
                    {
                        t = 0.0;
                    }
                    else if (t > 1.0)
                    {
                        t = 1.0;
                    }
                }

                double distance_X = x - (start.X + t * vector_X);
                double distance_Y = y - (start.Y + t * vector_Y);

                return distance_X * distance_X + distance_Y * distance_Y < tolerance_Squared;
            }
        }

        /// <summary>
        /// Checks if a point lies on any of the provided segments within a given tolerance.
        /// </summary>
        /// <param name="segment2Ds">The collection of segments to check.</param>
        /// <param name="point2D">The target point.</param>
        /// <param name="tolerance">The distance tolerance for the check.</param>
        /// <returns>True if the point is on any segment, otherwise false.</returns>
        public static bool On(this IEnumerable<Segment2D?>? segment2Ds, Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point2D == null || segment2Ds == null)
            {
                return false;
            }

            foreach (Segment2D? segment2D in segment2Ds)
            {
                if (segment2D is null)
                {
                    continue;
                }

                if (segment2D.On(point2D, tolerance))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Checks if a point lies on any of the provided segmentable geometries within a given tolerance.
        /// </summary>
        /// <typeparam name="T">The type of segmentable geometry, which must implement <see cref="ISegmentable2D"/>.</typeparam>
        /// <param name="segmentable2Ds">The collection of segmentable geometries to check.</param>
        /// <param name="point2D">The target point to evaluate.</param>
        /// <param name="tolerance">The distance tolerance used to determine if the point is on the geometry.</param>
        /// <returns>True if the point lies on any of the provided geometries within the specified tolerance; otherwise, false.</returns>
        public static bool On<T>(this IEnumerable<T>? segmentable2Ds, Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance) where T : ISegmentable2D
        {
            if (point2D == null || segmentable2Ds == null)
            {
                return false;
            }

            foreach (T segmentable2D in segmentable2Ds)
            {
                if (segmentable2D == null)
                {
                    continue;
                }

                if (segmentable2D.On(point2D, tolerance))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
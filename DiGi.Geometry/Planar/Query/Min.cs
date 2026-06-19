using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Returns the minimum <see cref="Point2D"/> from the specified collection of <see cref="Point2D"/> objects.
        /// </summary>
        /// <param name="point2Ds">The <see cref="IEnumerable{T}"/> of <see cref="Point2D"/> objects to evaluate.</param>
        /// <returns>The minimum <see cref="Point2D"/> found in the collection, or null if the collection is null or empty.</returns>
        public static Point2D? Min(this IEnumerable<Point2D?>? point2Ds)
        {
            return Min(point2Ds, out _);
        }

        /// <summary>
        /// Returns the minimum of two <c>Point2D?</c> points.
        /// </summary>
        /// <param name="point2D_1">The first <c>Point2D?</c> point.</param>
        /// <param name="point2D_2">The second <c>Point2D?</c> point.</param>
        /// <returns>The minimum of the two <c>Point2D?</c> points, or <c>null</c> if either input is <c>null</c>.</returns>
        public static Point2D? Min(this Point2D? point2D_1, Point2D? point2D_2)
        {
            if (point2D_1 == null || point2D_2 == null)
            {
                return null;
            }

            return Min([point2D_1, point2D_2], out _);
        }

        /// <summary>
        /// Calculates the minimum and maximum points from a collection of <see cref="Point2D"/> objects.
        /// </summary>
        /// <param name="point2Ds">The <see cref="IEnumerable{T}"/> of <see cref="Point2D"/> objects to evaluate.</param>
        /// <param name="max">When this method returns, contains the maximum <see cref="Point2D"/> found; otherwise, null.</param>
        /// <returns>The minimum <see cref="Point2D"/> found in the collection; otherwise, null if the collection is null or empty.</returns>
        public static Point2D? Min(this IEnumerable<Point2D?>? point2Ds, out Point2D? max)
        {
            max = null;
            if (point2Ds == null || point2Ds.Count() == 0)
            {
                return null;
            }

            double x_Min = double.MaxValue;
            double x_Max = double.MinValue;
            double y_Min = double.MaxValue;
            double y_Max = double.MinValue;
            foreach (Point2D? point2D in point2Ds)
            {
                if (point2D == null)
                {
                    continue;
                }

                if (point2D.X > x_Max)
                {
                    x_Max = point2D.X;
                }

                if (point2D.X < x_Min)
                {
                    x_Min = point2D.X;
                }

                if (point2D.Y > y_Max)
                {
                    y_Max = point2D.Y;
                }

                if (point2D.Y < y_Min)
                {
                    y_Min = point2D.Y;
                }
            }

            if (x_Min == double.MaxValue || x_Max == double.MinValue || y_Min == double.MaxValue || y_Max == double.MinValue)
            {
                return null;
            }

            max = new Point2D(x_Max, y_Max);
            return new Point2D(x_Min, y_Min);
        }

        /// <summary>
        /// Calculates the minimum and maximum <see cref="Point2D"/> points of the specified <see cref="ISegmentable2D"/>.
        /// </summary>
        /// <param name="segmentable2D">The <see cref="ISegmentable2D"/> object to evaluate.</param>
        /// <param name="max">When this method returns, contains the maximum <see cref="Point2D"/> found; otherwise, <see langword="null"/>.</param>
        /// <returns>The minimum <see cref="Point2D"/> found; otherwise, <see langword="null"/> if the <paramref name="segmentable2D"/> is <see langword="null"/>.</returns>
        public static Point2D? Min(this ISegmentable2D? segmentable2D, out Point2D? max)
        {
            max = null;

            if (segmentable2D == null)
            {
                return null;
            }

            return Min(segmentable2D.GetPoints(), out max);
        }

        /// <summary>
        /// Calculates the minimum and maximum <see cref="Point2D"/> coordinates from a collection of objects that implement <see cref="ISegmentable2D"/>.
        /// </summary>
        /// <typeparam name="T">The type of elements in the collection, which must implement <see cref="ISegmentable2D"/>.</typeparam>
        /// <param name="segmentable2Ds">An <see cref="IEnumerable{T}"/> of <see cref="ISegmentable2D"/> objects to evaluate.</param>
        /// <param name="max">When this method returns, contains the maximum <see cref="Point2D"/> found in the collection, or <see langword="null"/> if no points were found.</param>
        /// <returns>The minimum <see cref="Point2D"/> found in the collection, or <see langword="null"/> if the <see cref="IEnumerable{T}"/> is <see langword="null"/> or empty.</returns>
        public static Point2D? Min<T>(this IEnumerable<T?>? segmentable2Ds, out Point2D? max) where T : ISegmentable2D
        {
            max = null;

            if (segmentable2Ds == null)
            {
                return null;
            }

            return Min(segmentable2Ds.Points(), out max);
        }
    }
}
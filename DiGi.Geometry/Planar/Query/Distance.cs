using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the shortest distance between a <see cref="Point2D"/> and an <see cref="ISegmentable2D"/>.
        /// </summary>
        /// <param name="point2D">The <see cref="Point2D"/> from which to calculate the distance.</param>
        /// <param name="segmentable2D">The <see cref="ISegmentable2D"/> object to measure the distance to.</param>
        /// <returns>The shortest distance as a <see cref="double"/>.</returns>
        public static double Distance(this Point2D? point2D, ISegmentable2D? segmentable2D)
        {
            return Distance(point2D, segmentable2D?.GetSegments(), out _);
        }

        /// <summary>
        /// Calculates the shortest distance from a <see cref="Point2D"/> to a collection of <see cref="Segment2D"/> objects.
        /// </summary>
        /// <param name="point2D">The <see cref="Point2D"/> instance to measure the distance from.</param>
        /// <param name="segment2Ds">An <see cref="IEnumerable{Segment2D}"/> containing the segments to evaluate.</param>
        /// <param name="closetPoint2D">When this method returns, contains the <see cref="Point2D"/> that is closest to the source point; otherwise, null.</param>
        /// <returns>The minimum distance as a <see cref="double"/>.</returns>
        public static double Distance(this Point2D? point2D, IEnumerable<Segment2D>? segment2Ds, out Point2D? closetPoint2D)
        {
            closetPoint2D = ClosestPoint(point2D, segment2Ds, out double result);
            return result;
        }

        /// <summary>
        /// Calculates the shortest distance between a specified <see cref="Point2D"/> and a collection of <see cref="Segment2D"/> objects.
        /// </summary>
        /// <param name="point2D">The <see cref="Point2D"/> from which to calculate the distance.</param>
        /// <param name="segment2Ds">An <see cref="IEnumerable{T}"/> of <see cref="Segment2D"/> objects to measure the distance against.</param>
        /// <returns>The shortest distance as a <see cref="double"/>. Returns <see cref="double.NaN"/> if the point or the collection is null or empty.</returns>
        public static double Distance(this Point2D? point2D, IEnumerable<Segment2D>? segment2Ds)
        {
            return Distance(point2D, segment2Ds, out _);
        }

        /// <summary>
        /// Calculates the shortest distance from a <see cref="Point2D"/> to a collection of objects that implement <see cref="ISegmentable2D"/>.
        /// </summary>
        /// <typeparam name="T">A type that implements <see cref="ISegmentable2D"/>.</typeparam>
        /// <param name="point2D">The source <see cref="Point2D"/> to measure the distance from.</param>
        /// <param name="segmentable2Ds">An <see cref="IEnumerable{T}"/> of objects that implement <see cref="ISegmentable2D"/>.</param>
        /// <param name="closetPoint2D">When this method returns, contains the closest <see cref="Point2D"/> found on the segmentable objects; otherwise, null.</param>
        /// <returns>The minimum distance as a <see cref="double"/>, or <see cref="double.NaN"/> if the source point is null, the collection is null, or the collection contains no elements.</returns>
        public static double Distance<T>(this Point2D? point2D, IEnumerable<T>? segmentable2Ds, out Point2D? closetPoint2D) where T : ISegmentable2D
        {
            closetPoint2D = null;
            if (point2D == null || segmentable2Ds == null)
            {
                return double.NaN;
            }

            List<Segment2D>? segment2Ds = segmentable2Ds.Segments();
            if (segment2Ds == null || segment2Ds.Count == 0)
            {
                return double.NaN;
            }

            return Distance(point2D, segment2Ds, out closetPoint2D);
        }

        /// <summary>
        /// Calculates the shortest distance between a specified <see cref="Point2D"/> and a collection of objects that implement <see cref="ISegmentable2D"/>.
        /// </summary>
        /// <typeparam name="T">A type that implements the <see cref="ISegmentable2D"/> interface.</typeparam>
        /// <param name="point2D">The <see cref="Point2D"/> from which the distance is measured.</param>
        /// <param name="segmentable2Ds">An <see cref="IEnumerable{T}"/> collection of objects implementing <see cref="ISegmentable2D"/> to measure the distance against.</param>
        /// <returns>The shortest distance as a <see cref="double"/>.</returns>
        public static double Distance<T>(this Point2D? point2D, IEnumerable<T>? segmentable2Ds) where T : ISegmentable2D
        {
            return Distance(point2D, segmentable2Ds, out _);
        }

        /// <summary>
        /// Calculates the shortest distance between two segmentable 2D objects.
        /// </summary>
        /// <param name="segmentable2D_1">The first <see cref="ISegmentable2D"/> object.</param>
        /// <param name="segmentable2D_2">The second <see cref="ISegmentable2D"/> object.</param>
        /// <param name="point2D_Closest1">When this method returns, contains the <see cref="Point2D"/> on the first segmentable object that is closest to the second segmentable object, or null if no distance could be calculated.</param>
        /// <param name="point2D_Closest2">When this method returns, contains the <see cref="Point2D"/> on the second segmentable object that is closest to the first segmentable object, or null if no distance could be calculated.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used for calculations.</param>
        /// <returns>The shortest distance as a <see cref="double"/> between the two objects, or <see cref="double.NaN"/> if either object is null or contains no segments.</returns>
        public static double Distance(ISegmentable2D? segmentable2D_1, ISegmentable2D? segmentable2D_2, out Point2D? point2D_Closest1, out Point2D? point2D_Closest2, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            point2D_Closest1 = null;
            point2D_Closest2 = null;

            if (segmentable2D_1 == null || segmentable2D_2 == null)
            {
                return double.NaN;
            }

            List<Segment2D>? segment2Ds_1 = segmentable2D_1.GetSegments();
            if (segment2Ds_1 == null || segment2Ds_1.Count == 0)
            {
                return double.NaN;
            }

            List<Segment2D>? segment2Ds_2 = segmentable2D_2.GetSegments();
            if (segment2Ds_2 == null || segment2Ds_2.Count == 0)
            {
                return double.NaN;
            }

            double resultSq = double.MaxValue;
            foreach (Segment2D segment2D_1 in segment2Ds_1)
            {
                foreach (Segment2D segment2D_2 in segment2Ds_2)
                {
                    Point2D? point2D = IntersectionPoint(segment2D_1[0], segment2D_1[1], segment2D_2[0], segment2D_2[1], out Point2D? point2D_Closest1_Temp, out Point2D? point2D_Closest2_Temp, tolerance);
                    if (point2D_Closest1_Temp != null && point2D_Closest2_Temp != null)
                    {
                        double dx = point2D_Closest1_Temp.X - point2D_Closest2_Temp.X;
                        double dy = point2D_Closest1_Temp.Y - point2D_Closest2_Temp.Y;
                        double distanceSq = dx * dx + dy * dy;
                        if (distanceSq == 0)
                        {
                            point2D_Closest1 = point2D_Closest1_Temp;
                            point2D_Closest2 = point2D_Closest2_Temp;
                            return 0;
                        }

                        if (distanceSq < resultSq)
                        {
                            point2D_Closest1 = point2D_Closest1_Temp;
                            point2D_Closest2 = point2D_Closest2_Temp;
                            resultSq = distanceSq;
                        }
                    }

                    if (point2D != null && point2D_Closest1_Temp == null && point2D_Closest2_Temp == null)
                    {
                        point2D_Closest1 = point2D;
                        point2D_Closest2 = new Point2D(point2D);
                        return 0;
                    }
                }
            }

            if (resultSq == double.MaxValue)
            {
                return double.NaN;
            }

            return System.Math.Sqrt(resultSq);
        }

        /// <summary>
        /// Calculates the distance between a <see cref="BoundingBox2D"/> and an <see cref="ISegmentable2D"/>.
        /// </summary>
        /// <param name="boundingBox2D">The <see cref="BoundingBox2D"/> to measure the distance from.</param>
        /// <param name="segmentable2D">The <see cref="ISegmentable2D"/> to measure the distance to.</param>
        /// <param name="point2D_Closest1">When this method returns, contains the <see cref="Point2D"/> on the <see cref="BoundingBox2D"/> closest to the <see cref="ISegmentable2D"/>, or null if not found.</param>
        /// <param name="point2D_Closest2">When this method returns, contains the <see cref="Point2D"/> on the <see cref="ISegmentable2D"/> closest to the <see cref="BoundingBox2D"/>, or null if not found.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used for distance calculations.</param>
        /// <returns>The <see cref="double"/> distance between the two objects, or <see cref="double.NaN"/> if either input is null.</returns>
        public static double Distance(BoundingBox2D? boundingBox2D, ISegmentable2D? segmentable2D, out Point2D? point2D_Closest1, out Point2D? point2D_Closest2, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            point2D_Closest1 = null;
            point2D_Closest2 = null;

            if (boundingBox2D is null || segmentable2D is null)
            {
                return double.NaN;
            }

            return Distance((Polygon2D?)boundingBox2D, segmentable2D, out point2D_Closest1, out point2D_Closest2, tolerance);
        }

        /// <summary>
        /// Calculates the shortest distance between an <see cref="ISegmentable2D"/> and a <see cref="BoundingBox2D"/>.
        /// </summary>
        /// <param name="segmentable2D">The <see cref="ISegmentable2D"/> object.</param>
        /// <param name="boundingBox2D">The <see cref="BoundingBox2D"/> object.</param>
        /// <param name="point2D_Closest1">When this method returns, contains the <see cref="Point2D"/> that is closest to the other object on the <see cref="ISegmentable2D"/>.</param>
        /// <param name="point2D_Closest2">When this method returns, contains the <see cref="Point2D"/> that is closest to the other object on the <see cref="BoundingBox2D"/>.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used for distance calculations.</param>
        /// <returns>The shortest distance as a <see cref="double"/> between the two objects.</returns>
        public static double Distance(ISegmentable2D? segmentable2D, BoundingBox2D? boundingBox2D, out Point2D? point2D_Closest1, out Point2D? point2D_Closest2, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            return Distance(boundingBox2D, segmentable2D, out point2D_Closest2, out point2D_Closest1, tolerance);
        }
    }
}
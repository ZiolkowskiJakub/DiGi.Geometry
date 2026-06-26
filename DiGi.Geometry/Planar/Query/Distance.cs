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

            int int_Count2 = segment2Ds_2.Count;
            Point2D?[] point2Ds_Start2 = new Point2D?[int_Count2];
            Point2D?[] point2Ds_End2 = new Point2D?[int_Count2];
            double[] doubles_MinX2 = new double[int_Count2];
            double[] doubles_MaxX2 = new double[int_Count2];
            double[] doubles_MinY2 = new double[int_Count2];
            double[] doubles_MaxY2 = new double[int_Count2];

            for (int int_I = 0; int_I < int_Count2; int_I++)
            {
                Segment2D segment2D_Temp = segment2Ds_2[int_I];
                Point2D? point2D_Start = segment2D_Temp.Start;
                Point2D? point2D_End = segment2D_Temp.End;

                point2Ds_Start2[int_I] = point2D_Start;
                point2Ds_End2[int_I] = point2D_End;

                double double_Sx = point2D_Start?.X ?? double.NaN;
                double double_Sy = point2D_Start?.Y ?? double.NaN;
                double double_Ex = point2D_End?.X ?? double.NaN;
                double double_Ey = point2D_End?.Y ?? double.NaN;

                doubles_MinX2[int_I] = double_Sx < double_Ex ? double_Sx : double_Ex;
                doubles_MaxX2[int_I] = double_Sx > double_Ex ? double_Sx : double_Ex;
                doubles_MinY2[int_I] = double_Sy < double_Ey ? double_Sy : double_Ey;
                doubles_MaxY2[int_I] = double_Sy > double_Ey ? double_Sy : double_Ey;
            }

            double resultSq = double.MaxValue;

            for (int int_I = 0; int_I < segment2Ds_1.Count; int_I++)
            {
                Segment2D segment2D_1 = segment2Ds_1[int_I];
                Point2D? point2D_Start1 = segment2D_1.Start;
                Point2D? point2D_End1 = segment2D_1.End;

                double double_1StartX = point2D_Start1?.X ?? double.NaN;
                double double_1StartY = point2D_Start1?.Y ?? double.NaN;
                double double_1EndX = point2D_End1?.X ?? double.NaN;
                double double_1EndY = point2D_End1?.Y ?? double.NaN;

                double double_1MinX = double_1StartX < double_1EndX ? double_1StartX : double_1EndX;
                double double_1MaxX = double_1StartX > double_1EndX ? double_1StartX : double_1EndX;
                double double_1MinY = double_1StartY < double_1EndY ? double_1StartY : double_1EndY;
                double double_1MaxY = double_1StartY > double_1EndY ? double_1StartY : double_1EndY;

                for (int int_J = 0; int_J < int_Count2; int_J++)
                {
                    double double_2MinX = doubles_MinX2[int_J];
                    double double_2MaxX = doubles_MaxX2[int_J];
                    double double_2MinY = doubles_MinY2[int_J];
                    double double_2MaxY = doubles_MaxY2[int_J];

                    double double_Dx = 0.0;
                    if (double_1MinX > double_2MaxX)
                    {
                        double_Dx = double_1MinX - double_2MaxX;
                    }
                    else if (double_2MinX > double_1MaxX)
                    {
                        double_Dx = double_2MinX - double_1MaxX;
                    }

                    double double_Dy = 0.0;
                    if (double_1MinY > double_2MaxY)
                    {
                        double_Dy = double_1MinY - double_2MaxY;
                    }
                    else if (double_2MinY > double_1MaxY)
                    {
                        double_Dy = double_2MinY - double_1MaxY;
                    }

                    double double_MinBoxDistSq = double_Dx * double_Dx + double_Dy * double_Dy;
                    if (double_MinBoxDistSq >= resultSq)
                    {
                        continue;
                    }

                    Point2D? point2D_Start2 = point2Ds_Start2[int_J];
                    Point2D? point2D_End2 = point2Ds_End2[int_J];

                    Point2D? point2D_Intersection = IntersectionPoint(point2D_Start1, point2D_End1, point2D_Start2, point2D_End2, out Point2D? point2D_Closest1_Temp, out Point2D? point2D_Closest2_Temp, tolerance);
                    if (point2D_Closest1_Temp != null && point2D_Closest2_Temp != null)
                    {
                        double double_Dx_Temp = point2D_Closest1_Temp.X - point2D_Closest2_Temp.X;
                        double double_Dy_Temp = point2D_Closest1_Temp.Y - point2D_Closest2_Temp.Y;
                        double double_DistanceSq = double_Dx_Temp * double_Dx_Temp + double_Dy_Temp * double_Dy_Temp;
                        if (double_DistanceSq == 0)
                        {
                            point2D_Closest1 = point2D_Closest1_Temp;
                            point2D_Closest2 = point2D_Closest2_Temp;
                            return 0;
                        }

                        if (double_DistanceSq < resultSq)
                        {
                            point2D_Closest1 = point2D_Closest1_Temp;
                            point2D_Closest2 = point2D_Closest2_Temp;
                            resultSq = double_DistanceSq;
                        }
                    }

                    if (point2D_Intersection != null && point2D_Closest1_Temp == null && point2D_Closest2_Temp == null)
                    {
                        point2D_Closest1 = point2D_Intersection;
                        point2D_Closest2 = new Point2D(point2D_Intersection);
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
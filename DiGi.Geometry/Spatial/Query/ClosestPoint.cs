using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the closest <see cref="Point3D"/> on a line defined by two points relative to a given point.
        /// </summary>
        /// <param name="point3D">The target <c>Point3D?</c> for which the closest point is calculated.</param>
        /// <param name="point3D_1">The first <c>Point3D?</c> defining the line.</param>
        /// <param name="point3D_2">The second <c>Point3D?</c> defining the line.</param>
        /// <param name="bounded">A <see cref="bool"/> value indicating whether the result should be bounded to the segment between the two points.</param>
        /// <returns>The closest <c>Point3D?</c> on the line, or <see langword="null"/> if any of the input points are <see langword="null"/>.</returns>
        public static Point3D? ClosestPoint(this Point3D? point3D, Point3D? point3D_1, Point3D? point3D_2, bool bounded)
        {
            return ClosestPoint(point3D, point3D_1, point3D_2, bounded, bounded);
        }

        /// <summary>
        /// Calculates the closest <see cref="Point3D"/> on a line or line segment defined by two points to a given target point.
        /// </summary>
        /// <param name="point3D">The target <see cref="Point3D"/> for which the closest point is calculated.</param>
        /// <param name="point3D_1">The first <c>Point3D?</c> defining the line or segment.</param>
        /// <param name="point3D_2">The second <see cref="Point3D"/> defining the line or segment.</param>
        /// <param name="bounded_1">A <see cref="bool"/> indicating whether the result is bounded by the first point.</param>
        /// <param name="bounded_2">A bool indicating whether the result is bounded by the second point.</param>
        /// <returns>The closest <see cref="Point3D"/> on the line or segment, or null if any of the input points are null.</returns>
        public static Point3D? ClosestPoint(this Point3D? point3D, Point3D? point3D_1, Point3D? point3D_2, bool bounded_1, bool bounded_2)
        {
            if (point3D == null || point3D_1 == null || point3D_2 == null)
            {
                return null;
            }

            Point3D start = point3D_1;
            Point3D end = point3D_2;

            double a = point3D.X - start.X;
            double b = point3D.Y - start.Y;
            double e = point3D.Z - start.Z;
            double c = end.X - start.X;
            double d = end.Y - start.Y;
            double f = end.Z - start.Z;

            double dot = a * c + b * d + e * f;
            double squareLength = c * c + d * d + f * f;
            double parameter = -1;
            if (squareLength != 0)
            {
                parameter = dot / squareLength;
            }

            if (parameter < 0 && bounded_1)
            {
                return new Point3D(start);
            }

            if (parameter > 1 && bounded_2)
            {
                return new Point3D(end);
            }

            return new Point3D(start.X + parameter * c, start.Y + parameter * d, start.Z + parameter * f);
        }

        /// <summary>
        /// Calculates the closest point on an <see cref="ISegmentable3D"/> object to a given <see cref="Point3D"/>.
        /// </summary>
        /// <param name="point3D">The source <see cref="Point3D"/> for which the closest point is being calculated.</param>
        /// <param name="segmentable3D">The <see cref="ISegmentable3D"/> object to find the closest point on.</param>
        /// <returns>The closest <see cref="Point3D"/> found on the segmentable object, or null if no such point exists.</returns>
        public static Point3D? ClosestPoint(this Point3D? point3D, ISegmentable3D segmentable3D)
        {
            return ClosestPoint(point3D, segmentable3D?.GetSegments(), out _);
        }

        /// <summary>
        /// Calculates the closest point on an <see cref="ISegmentable3D"/> object from a given <see cref="Point3D"/>.
        /// </summary>
        /// <param name="point3D">The source <see cref="Point3D"/> to find the closest point from.</param>
        /// <param name="segmentable3D">The <see cref="ISegmentable3D"/> object containing segments to evaluate.</param>
        /// <param name="distance">When this method returns, contains the distance between the source <see cref="Point3D"/> and the closest point found; otherwise, <see cref="double.NaN"/>.</param>
        /// <returns>The closest <see cref="Point3D"/> on the segments of the <see cref="ISegmentable3D"/> object, or <see langword="null"/> if no point could be determined.</returns>
        public static Point3D? ClosestPoint(this Point3D? point3D, ISegmentable3D? segmentable3D, out double distance)
        {
            return ClosestPoint(point3D, segmentable3D?.GetSegments(), out distance);
        }

        /// <summary>
        /// Calculates the closest point among a collection of 3D segments to a given 3D point.
        /// </summary>
        /// <param name="point3D">The <see cref="Point3D"/> source point.</param>
        /// <param name="segment3Ds">An <see cref="IEnumerable{T}"/> of <see cref="Segment3D"/> objects to evaluate.</param>
        /// <returns>The closest <see cref="Point3D"/> found on the segments, or <see langword="null"/> if the source point or the collection is null.</returns>
        public static Point3D? ClosestPoint(this Point3D? point3D, IEnumerable<Segment3D>? segment3Ds)
        {
            return ClosestPoint(point3D, segment3Ds, out _);
        }

        /// <summary>
        /// Calculates the closest point on a collection of 3D segments relative to a given 3D point.
        /// </summary>
        /// <param name="point3D">The source <see cref="Point3D"/> point.</param>
        /// <param name="segment3Ds">An <see cref="IEnumerable{T}"/> of <see cref="Segment3D"/> segments to evaluate.</param>
        /// <param name="distance">When this method returns, contains the distance between the source <see cref="Point3D"/> and the closest point found; otherwise, <see cref="double.NaN"/>.</param>
        /// <returns>The closest <see cref="Point3D"/> found among the provided segments, or <see langword="null"/> if no point is found or input parameters are null.</returns>
        public static Point3D? ClosestPoint(this Point3D? point3D, IEnumerable<Segment3D>? segment3Ds, out double distance)
        {
            distance = double.NaN;
            if (point3D == null || segment3Ds == null)
            {
                return null;
            }

            double distanceSq = double.MaxValue;
            Point3D? point3D_Result = null;
            foreach (Segment3D segment3D in segment3Ds)
            {
                Point3D? point3D_Closest = segment3D?.ClosestPoint(point3D);
                if (point3D_Closest == null)
                {
                    continue;
                }

                double dx = point3D_Closest.X - point3D.X;
                double dy = point3D_Closest.Y - point3D.Y;
                double dz = point3D_Closest.Z - point3D.Z;
                double distanceSq_Temp = dx * dx + dy * dy + dz * dz;
                if (distanceSq_Temp < distanceSq)
                {
                    distanceSq = distanceSq_Temp;
                    point3D_Result = point3D_Closest;
                }
            }

            distance = point3D_Result != null ? System.Math.Sqrt(distanceSq) : double.NaN;
            return point3D_Result;
        }

        /// <summary>
        /// Finds the closest <see cref="Point3D"/> in a collection of points to a specified source point.
        /// </summary>
        /// <param name="point3D">The source <see cref="Point3D"/> used as the reference for distance calculations.</param>
        /// <param name="point3Ds">An <see cref="IEnumerable{T}"/> of <see cref="Point3D"/> objects to search through.</param>
        /// <param name="distance">When this method returns, contains the minimum <see cref="double"/> distance between the source point and the closest point found; otherwise, <see cref="double.NaN"/>.</param>
        /// <returns>The closest <see cref="Point3D"/> from the collection, or <see langword="null"/> if the source point is null, the collection is null, or no points are available.</returns>
        public static Point3D? ClosestPoint(this Point3D? point3D, IEnumerable<Point3D>? point3Ds, out double distance)
        {
            distance = double.NaN;
            if (point3D == null || point3Ds == null)
            {
                return null;
            }

            double distanceSq = double.MaxValue;
            Point3D? point3D_Result = null;

            foreach (Point3D point3D_Temp in point3Ds)
            {
                if (point3D_Temp == null)
                {
                    continue;
                }

                double dx = point3D.X - point3D_Temp.X;
                double dy = point3D.Y - point3D_Temp.Y;
                double dz = point3D.Z - point3D_Temp.Z;
                double distanceSq_Temp = dx * dx + dy * dy + dz * dz;
                if (distanceSq_Temp < distanceSq)
                {
                    distanceSq = distanceSq_Temp;
                    point3D_Result = point3D_Temp;
                }
            }

            distance = point3D_Result != null ? System.Math.Sqrt(distanceSq) : double.NaN;
            return point3D_Result;
        }

        /// <summary>
        /// Calculates the closest point on a collection of polygonal faces to a given point.
        /// </summary>
        /// <typeparam name="TPolygonalFace3D">The type of the polygonal face, which must implement <see cref="IPolygonalFace3D"/>.</typeparam>
        /// <param name="point3D">The source <c>Point3D?</c> point.</param>
        /// <param name="polygonalFace3Ds">An <see cref="IEnumerable{TPolygonalFace3D}"/> of polygonal faces to evaluate.</param>
        /// <returns>The closest <c>Point3D?</c> found on the provided polygonal faces, or <see langword="null"/> if the input point or collection is null.</returns>
        public static Point3D? ClosestPoint<TPolygonalFace3D>(this Point3D? point3D, IEnumerable<TPolygonalFace3D> polygonalFace3Ds) where TPolygonalFace3D : IPolygonalFace3D
        {
            return ClosestPoint(point3D, polygonalFace3Ds, out _, out _, 0.0);
        }

        /// <summary>
        /// Calculates the closest point to a given point from a collection of polygonal faces.
        /// </summary>
        /// <typeparam name="TPolygonalFace3D">The type of the polygonal face, which must implement <see cref="IPolygonalFace3D"/>.</typeparam>
        /// <param name="point3D">The source <c>Point3D?</c> from which to find the closest point.</param>
        /// <param name="polygonalFace3Ds">An <see cref="IEnumerable{TPolygonalFace3D}"/> of polygonal faces to evaluate.</param>
        /// <param name="closestPolygonalFace3D">When this method returns, contains the <c>TPolygonalFace3D?</c> that is closest to the source point.</param>
        /// <param name="distance">When this method returns, contains the <see cref="double"/> distance between the source point and the closest point found.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance used for calculations.</param>
        /// <returns>The closest <c>Point3D?</c> found among all provided polygonal faces, or <see langword="null"/> if no closest point is found or the input point or collection is null.</returns>
        public static Point3D? ClosestPoint<TPolygonalFace3D>(this Point3D? point3D, IEnumerable<TPolygonalFace3D> polygonalFace3Ds, out TPolygonalFace3D? closestPolygonalFace3D, out double distance, double tolerance = DiGi.Core.Constants.Tolerance.Distance) where TPolygonalFace3D : IPolygonalFace3D
        {
            distance = double.NaN;
            closestPolygonalFace3D = default;

            if (point3D is null || polygonalFace3Ds is null)
            {
                return null;
            }

            double double_DistanceSq = double.MaxValue;
            double double_ToleranceSq = tolerance * tolerance;
            Point3D? point3D_Result = null;

            foreach (TPolygonalFace3D polygonalFace3D in polygonalFace3Ds)
            {
                if (polygonalFace3D?.ClosestPoint(point3D) is not Point3D point3D_ClosestPointTemp)
                {
                    continue;
                }

                double double_Dx = point3D_ClosestPointTemp.X - point3D.X;
                double double_Dy = point3D_ClosestPointTemp.Y - point3D.Y;
                double double_Dz = point3D_ClosestPointTemp.Z - point3D.Z;
                double double_DistanceSqTemp = double_Dx * double_Dx + double_Dy * double_Dy + double_Dz * double_Dz;

                if (double_DistanceSqTemp < double_DistanceSq)
                {
                    point3D_Result = point3D_ClosestPointTemp;
                    double_DistanceSq = double_DistanceSqTemp;
                    closestPolygonalFace3D = polygonalFace3D;
                    if (double_DistanceSq < double_ToleranceSq)
                    {
                        break;
                    }
                }
            }

            distance = point3D_Result is not null ? System.Math.Sqrt(double_DistanceSq) : double.NaN;
            return point3D_Result;
        }
    }
}
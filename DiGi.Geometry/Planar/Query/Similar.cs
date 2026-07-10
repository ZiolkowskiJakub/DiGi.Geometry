using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Checks if two points are similar (almost equal) within a given tolerance.
        /// </summary>
        /// <param name="point2D_1">The first point to compare.</param>
        /// <param name="point2D_2">The second point to compare.</param>
        /// <param name="tolerance">The distance tolerance used to determine similarity.</param>
        /// <returns><c>true</c> if the points are similar; otherwise, <c>false</c>.</returns>
        public static bool Similar(this Point2D? point2D_1, Point2D? point2D_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point2D_1 == point2D_2)
            {
                return true;
            }

            if (point2D_1 is null && point2D_2 is null)
            {
                return true;
            }

            if (point2D_1 is null || point2D_2 is null)
            {
                return false;
            }

            return AlmostEquals(point2D_1, point2D_2, tolerance);
        }

        /// <summary>
        /// Checks if two segments are similar (identical endpoints regardless of order) within a given tolerance.
        /// </summary>
        /// <param name="segment2D_1">The first segment to compare.</param>
        /// <param name="segment2D_2">The second segment to compare.</param>
        /// <param name="tolerance">The distance tolerance used to determine similarity.</param>
        /// <returns><c>true</c> if the segments are similar; otherwise, <c>false</c>.</returns>
        public static bool Similar(this Segment2D? segment2D_1, Segment2D? segment2D_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segment2D_1 == segment2D_2)
            {
                return true;
            }

            if (segment2D_1 is null && segment2D_2 is null)
            {
                return true;
            }

            if (segment2D_1 is null || segment2D_2 is null)
            {
                return false;
            }

            if (!segment2D_1.TryGetCoordinates(out double x_Start1, out double y_Start1, out double x_End1, out double y_End1) ||
                !segment2D_2.TryGetCoordinates(out double x_Start2, out double y_Start2, out double x_End2, out double y_End2))
            {
                return false;
            }

            double tolerance_Squared = tolerance * tolerance;

            bool AlmostEqualCoordinates(double x_1, double y_1, double x_2, double y_2)
            {
                double double_Dx = x_1 - x_2;
                double double_Dy = y_1 - y_2;
                return (double_Dx * double_Dx + double_Dy * double_Dy) <= tolerance_Squared;
            }

            return (AlmostEqualCoordinates(x_Start1, y_Start1, x_Start2, y_Start2) && AlmostEqualCoordinates(x_End1, y_End1, x_End2, y_End2)) ||
                   (AlmostEqualCoordinates(x_Start1, y_Start1, x_End2, y_End2) && AlmostEqualCoordinates(x_End1, y_End1, x_Start2, y_Start2));
        }

        /// <summary>
        /// Checks if two vectors are similar (identical or opposite) within a specified tolerance.
        /// </summary>
        /// <param name="vector2D_1">The first vector to compare.</param>
        /// <param name="vector2D_2">The second vector to compare.</param>
        /// <param name="tolerance">The distance tolerance used to determine similarity.</param>
        /// <returns><c>true</c> if the vectors are similar; otherwise, <c>false</c>.</returns>
        public static bool Similar(this Vector2D? vector2D_1, Vector2D? vector2D_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (vector2D_1 == vector2D_2)
            {
                return true;
            }

            if (vector2D_1 is null && vector2D_2 is null)
            {
                return true;
            }

            if (vector2D_1 is null || vector2D_2 is null)
            {
                return false;
            }

            Vector2D vector2D_3 = new(vector2D_2);
            vector2D_3.Inverse();

            return vector2D_1.AlmostEquals(vector2D_2, tolerance) || vector2D_1.AlmostEquals(vector2D_3, tolerance);
        }

        /// <summary>
        /// Checks if two segmentable 2D geometries are similar within a specified tolerance.
        /// </summary>
        /// <param name="segmentable2D_1">The first segmentable geometry to compare.</param>
        /// <param name="segmentable2D_2">The second segmentable geometry to compare.</param>
        /// <param name="tolerance">The distance tolerance used to determine similarity.</param>
        /// <returns><c>true</c> if the geometries are similar; otherwise, <c>false</c>.</returns>
        public static bool Similar(this ISegmentable2D? segmentable2D_1, ISegmentable2D? segmentable2D_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segmentable2D_1 == segmentable2D_2)
            {
                return true;
            }

            if (segmentable2D_1 is null && segmentable2D_2 is null)
            {
                return true;
            }

            if (segmentable2D_1 is null || segmentable2D_2 is null)
            {
                return false;
            }

            if (segmentable2D_1 is Segment2D segment2D_1 && segmentable2D_2 is Segment2D segment2D_2)
            {
                return Similar(segment2D_1, segment2D_2, tolerance);
            }

            List<Point2D>? point2Ds_1 = segmentable2D_1.GetPoints();
            List<Point2D>? point2Ds_2 = segmentable2D_2.GetPoints();
            if ((point2Ds_1 == null || point2Ds_1.Count == 0) && (point2Ds_2 == null || point2Ds_2.Count == 0))
            {
                return true;
            }

            if (point2Ds_1 == null || point2Ds_1.Count == 0 || point2Ds_2 == null || point2Ds_2.Count == 0)
            {
                return false;
            }

            if (point2Ds_1.Count == 2 && point2Ds_2.Count == 2)
            {
                return Similar(new Segment2D(point2Ds_1[0], point2Ds_1[1]), new Segment2D(point2Ds_2[0], point2Ds_2[1]), tolerance);
            }

            if ((point2Ds_1 == null || point2Ds_1.Count == 0) && (point2Ds_2 == null || point2Ds_2.Count == 0))
            {
                return true;
            }

            if (point2Ds_1 == null || point2Ds_1.Count == 0 || point2Ds_2 == null || point2Ds_2.Count == 0)
            {
                return false;
            }

            if (point2Ds_1.Count == point2Ds_2.Count)
            {
                bool similar = true;
                for (int i = 0; i < point2Ds_2.Count; i++)
                {
                    similar = Similar(point2Ds_1[i], point2Ds_2[i], tolerance);
                    if (!similar)
                    {
                        break;
                    }
                }

                if (similar)
                {
                    return true;
                }
            }

            List<Segment2D>? segment2Ds = segmentable2D_1.GetSegments();
            segment2Ds?.AddRange(segmentable2D_2.GetSegments());

            segment2Ds = segment2Ds.Split(tolerance);
            if (segment2Ds != null)
            {
                foreach (Segment2D segment2D in segment2Ds)
                {
                    Point2D? point2D = segment2D.Mid();

                    if (!segmentable2D_1.On(point2D, tolerance))
                    {
                        return false;
                    }

                    if (!segmentable2D_2.On(point2D, tolerance))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Checks if two polygonal faces are similar within a given tolerance.
        /// </summary>
        /// <param name="polygonalFace2D_1">The first polygonal face to compare.</param>
        /// <param name="polygonalFace2D_2">The second polygonal face to compare.</param>
        /// <param name="tolerance">The distance tolerance used for the similarity check.</param>
        /// <returns>True if the two polygonal faces are similar; otherwise, false.</returns>
        public static bool Similar(this IPolygonalFace2D? polygonalFace2D_1, IPolygonalFace2D? polygonalFace2D_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (polygonalFace2D_1 == null && polygonalFace2D_2 == null)
            {
                return true;
            }

            if (polygonalFace2D_1 == null || polygonalFace2D_2 == null)
            {
                return false;
            }

            List<IPolygonal2D>? internalEdges_1 = polygonalFace2D_1.InternalEdges;
            internalEdges_1?.RemoveAll(x => x == null);
            List<IPolygonal2D>? internalEdges_2 = polygonalFace2D_2.InternalEdges;
            internalEdges_2?.RemoveAll(x => x == null);

            if (internalEdges_1 != null && internalEdges_2 != null)
            {
                if (internalEdges_1.Count != internalEdges_2.Count)
                {
                    return false;
                }

                for (int i = 0; i < internalEdges_1.Count; i++)
                {
                    bool result = Similar(internalEdges_1[i], internalEdges_2[i], tolerance);
                    if (!result)
                    {
                        return false;
                    }
                }
            }

            return Similar(polygonalFace2D_1.ExternalEdge, polygonalFace2D_2.ExternalEdge, tolerance);
        }
    }
}
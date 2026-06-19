using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates a point that is strictly internal to the polygon defined by the provided collection of points.
        /// </summary>
        /// <param name="point2Ds">The <see cref="IEnumerable{Point2D}"/> collection of points defining the boundary.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used to determine if a point lies on a segment.</param>
        /// <returns>A <see cref="Point2D"/> representing an internal point, or <see langword="null"/> if the input is invalid or no internal point can be determined.</returns>
        public static Point2D? InternalPoint(IEnumerable<Point2D>? point2Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point2Ds == null)
            {
                return null;
            }

            List<Point2D> point2Ds_List = point2Ds as List<Point2D> ?? [.. point2Ds];
            if (point2Ds_List.Count < 3)
            {
                return null;
            }

            Point2D? point2D_Centroid = Centroid(point2Ds_List);
            if (point2D_Centroid == null)
            {
                return null;
            }

            List<Segment2D>? segment2Ds = Create.Segment2Ds(point2Ds_List, true);
            if (segment2Ds == null)
            {
                return null;
            }

            if (Inside(point2Ds_List, point2D_Centroid) && !On(segment2Ds, point2D_Centroid, tolerance))
            {
                return point2D_Centroid;
            }

            // Fallback 1: Use NetTopologySuite's highly optimized and robust InteriorPoint computation
            try
            {
                Polygon2D polygon2D_Temp = new(point2Ds_List);
                NetTopologySuite.Geometries.Polygon? polygon_NTS = polygon2D_Temp.ToNTS_Polygon();
                if (polygon_NTS != null)
                {
                    NetTopologySuite.Geometries.Point? point_NTS = polygon_NTS.InteriorPoint;
                    if (point_NTS != null && !point_NTS.IsEmpty)
                    {
                        Point2D point2D_Candidate = new(point_NTS.X, point_NTS.Y);
                        if (Inside(point2Ds_List, point2D_Candidate) && !On(segment2Ds, point2D_Candidate, tolerance))
                        {
                            return point2D_Candidate;
                        }
                    }
                }
            }
            catch
            {
                // Fall back to algorithmic search
            }

            // Fallback 2: Check consecutive triplets. Every simple polygon has at least two ears
            // (Two-Ears Theorem), meaning at least one consecutive triplet's centroid is strictly inside.
            // This runs in O(N^2) time compared to the original O(N^4) brute force search over all triplets.
            int count = point2Ds_List.Count;
            for (int i = 0; i < count; i++)
            {
                Point2D point2D_1 = point2Ds_List[i];
                Point2D point2D_2 = point2Ds_List[(i + 1) % count];
                Point2D point2D_3 = point2Ds_List[(i + 2) % count];

                // Check triangle centroid
                Point2D point2D_CentroidCandidate = new((point2D_1.X + point2D_2.X + point2D_3.X) / 3.0, (point2D_1.Y + point2D_2.Y + point2D_3.Y) / 3.0);
                if (Inside(point2Ds_List, point2D_CentroidCandidate) && !On(segment2Ds, point2D_CentroidCandidate, tolerance))
                {
                    return point2D_CentroidCandidate;
                }

                // Check chord midpoint (shifted slightly towards point2D_2 to be inside the triangle)
                Point2D point2D_ChordMidCandidate = new(
                    0.5 * (point2D_1.X + point2D_3.X) * 0.99 + point2D_2.X * 0.01,
                    0.5 * (point2D_1.Y + point2D_3.Y) * 0.99 + point2D_2.Y * 0.01
                );
                if (Inside(point2Ds_List, point2D_ChordMidCandidate) && !On(segment2Ds, point2D_ChordMidCandidate, tolerance))
                {
                    return point2D_ChordMidCandidate;
                }
            }

            return null;
        }
    }
}
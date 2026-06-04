using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Identifies and returns a list of adjacent 2D segments from a collection of segmentable objects based on a specified distance tolerance.
        /// </summary>
        /// <typeparam name="T">The type of the segmentable objects, which must implement <see cref="ISegmentable2D"/>.</typeparam>
        /// <param name="segmentable2Ds">An <see cref="IEnumerable{T}"/> containing the segmentable objects to evaluate for adjacency.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance used to determine if segments are adjacent.</param>
        /// <returns>A <see cref="List{Segment2D}"/> of adjacent segments, or <c>null</c> if the input collection is <c>null</c>.</returns>
        public static List<Segment2D>? AdjacentSegments<T>(this IEnumerable<T?>? segmentable2Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance) where T : ISegmentable2D
        {
            if (segmentable2Ds == null)
            {
                return null;
            }

            List<Segment2D> result = [];
            if (segmentable2Ds.Count() < 2)
            {
                return result;
            }

            List<Segment2D> segment2Ds = [];
            List<Tuple<T?, BoundingBox2D, List<Segment2D>>> tuples = [];
            foreach (T? segmentable2D in segmentable2Ds)
            {
                BoundingBox2D? boundingBox2D = segmentable2D?.GetBoundingBox();
                if (boundingBox2D == null)
                {
                    continue;
                }

                List<Segment2D>? segment2Ds_Segmentable2D = segmentable2D?.GetSegments();
                if (segment2Ds_Segmentable2D == null || segment2Ds_Segmentable2D.Count == 0)
                {
                    continue;
                }

                tuples.Add(new Tuple<T?, BoundingBox2D, List<Segment2D>>(segmentable2D, boundingBox2D, segment2Ds_Segmentable2D));
                segment2Ds.AddRange(segment2Ds_Segmentable2D);
            }

            if (segment2Ds.Count < 2)
            {
                return result;
            }

            List<Segment2D>? segment2Ds_Split = Split(segment2Ds, tolerance);
            if (segment2Ds_Split == null || segment2Ds_Split.Count < 2)
            {
                return result;
            }

            foreach (Segment2D segment2D in segment2Ds_Split)
            {
                Point2D? point2D = segment2D?.Mid();
                if (point2D == null)
                {
                    continue;
                }

                int count = 0;
                for (int i = 0; i < tuples.Count; i++)
                {
                    Tuple<T?, BoundingBox2D, List<Segment2D>> tuple = tuples[i];

                    if (!tuple.Item2.InRange(point2D, tolerance))
                    {
                        continue;
                    }

                    if (tuple.Item3.Find(x => x.On(point2D, tolerance)) == null)
                    {
                        continue;
                    }

                    count++;
                    if (count > 1)
                    {
                        break;
                    }
                }

                if (count > 1)
                {
                    result.Add(segment2D!);
                }
            }

            return result;
        }

        /// <summary>
        /// Retrieves the adjacent <see cref="Segment2D"/> objects between two <see cref="ISegmentable2D"/> instances within a specified tolerance.
        /// </summary>
        /// <param name="segmentable2D_1">The first <see cref="ISegmentable2D"/> instance.</param>
        /// <param name="segmentable2D_2">The second <see cref="ISegmentable2D"/> instance.</param>
        /// <param name="tolerance">The <see cref="double"/> distance tolerance used to determine if the bounding boxes are in range.</param>
        /// <returns>A <see cref="List{Segment2D}"/> containing the adjacent segments, or <see langword="null"/> if either input is null or no adjacency is found.</returns>
        public static List<Segment2D>? AdjacentSegments(this ISegmentable2D? segmentable2D_1, ISegmentable2D? segmentable2D_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segmentable2D_1 == null || segmentable2D_2 == null)
            {
                return null;
            }

            BoundingBox2D? boundingBox2D_1 = segmentable2D_1.GetBoundingBox();
            if (boundingBox2D_1 == null)
            {
                return null;
            }

            BoundingBox2D? boundingBox2D_2 = segmentable2D_2.GetBoundingBox();
            if (boundingBox2D_2 == null)
            {
                return null;
            }

            if (!boundingBox2D_1.InRange(boundingBox2D_2, tolerance))
            {
                return null;
            }

            return AdjacentSegments([segmentable2D_1, segmentable2D_2], tolerance);
        }
    }
}
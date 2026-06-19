using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Computes the convex hull for a collection of <see cref="Point2D"/> points.
        /// </summary>
        /// <param name="point2Ds">The <see cref="IEnumerable{T}"/> of <see cref="Point2D"/> objects to process.</param>
        /// <param name="keepOrder">A <see cref="bool"/> value indicating whether the original order of the points should be preserved in the resulting list.</param>
        /// <returns>A <see cref="List{T}"/> of <see cref="Point2D"/> objects forming the convex hull, or <see langword="null"/> if the input collection is <see langword="null"/>.</returns>
        public static List<Point2D>? ConvexHull(this IEnumerable<Point2D>? point2Ds, bool keepOrder)
        {
            if (point2Ds is null)
            {
                return null;
            }

            List<Point2D>? result = ConvexHull(point2Ds);

            if (!keepOrder || result is null || result.Count < 2)
            {
                return result;
            }

            HashSet<Point2D> point2Ds_ResultSet = [.. result];
            List<Point2D> point2Ds_Temp = [];
            foreach (Point2D point2D in point2Ds)
            {
                if (point2D != null && point2Ds_ResultSet.Contains(point2D))
                {
                    point2Ds_Temp.Add(point2D);
                }
            }

            result = point2Ds_Temp;

            return result;
        }

        /// <summary>
        /// Computes the convex hull for a given collection of <see cref="Point2D"/> objects.
        /// </summary>
        /// <param name="point2Ds">An <see cref="IEnumerable{Point2D}"/>  containing the points to process.</param>
        /// <returns>A <see cref="List{T}"/> representing the vertices of the convex hull, or <see langword="null"/> if the input collection is <see langword="null"/>.</returns>
        public static List<Point2D>? ConvexHull(this IEnumerable<Point2D>? point2Ds)
        {
            if (point2Ds == null)
            {
                return null;
            }

            List<Point2D> point2Ds_List = point2Ds as List<Point2D> ?? [.. point2Ds];
            List<Point2D> point2Ds_Temp = [];
            foreach (Point2D point in point2Ds_List)
            {
                if (point != null)
                {
                    point2Ds_Temp.Add(point);
                }
            }

            if (point2Ds_Temp.Count <= 3)
            {
                return point2Ds_Temp;
            }

            point2Ds_Temp.Sort(new ConvexHullComparer());

            // Remove duplicates
            int uniqueCount = 1;
            for (int i = 1; i < point2Ds_Temp.Count; i++)
            {
                if (point2Ds_Temp[i].X != point2Ds_Temp[uniqueCount - 1].X ||
                    point2Ds_Temp[i].Y != point2Ds_Temp[uniqueCount - 1].Y)
                {
                    point2Ds_Temp[uniqueCount] = point2Ds_Temp[i];
                    uniqueCount++;
                }
            }

            if (uniqueCount < point2Ds_Temp.Count)
            {
                point2Ds_Temp.RemoveRange(uniqueCount, point2Ds_Temp.Count - uniqueCount);
            }

            if (point2Ds_Temp.Count <= 3)
            {
                return point2Ds_Temp;
            }

            List<Point2D> point2Ds_Temp_UpperHull = [];
            foreach (Point2D point2D in point2Ds_Temp)
            {
                while (point2Ds_Temp_UpperHull.Count >= 2)
                {
                    Point2D point2D_1 = point2Ds_Temp_UpperHull[point2Ds_Temp_UpperHull.Count - 1];
                    Point2D point2D_2 = point2Ds_Temp_UpperHull[point2Ds_Temp_UpperHull.Count - 2];
                    if ((point2D_1.X - point2D_2.X) * (point2D.Y - point2D_2.Y) >= (point2D_1.Y - point2D_2.Y) * (point2D.X - point2D_2.X))
                    {
                        point2Ds_Temp_UpperHull.RemoveAt(point2Ds_Temp_UpperHull.Count - 1);
                    }
                    else
                    {
                        break;
                    }
                }
                point2Ds_Temp_UpperHull.Add(point2D);
            }
            point2Ds_Temp_UpperHull.RemoveAt(point2Ds_Temp_UpperHull.Count - 1);

            IList<Point2D> point2DList_LowerHull = [];
            for (int i = point2Ds_Temp.Count - 1; i >= 0; i--)
            {
                Point2D point2D = point2Ds_Temp[i];
                while (point2DList_LowerHull.Count >= 2)
                {
                    Point2D point2D_1 = point2DList_LowerHull[point2DList_LowerHull.Count - 1];
                    Point2D point2D_2 = point2DList_LowerHull[point2DList_LowerHull.Count - 2];
                    if ((point2D_1.X - point2D_2.X) * (point2D.Y - point2D_2.Y) >= (point2D_1.Y - point2D_2.Y) * (point2D.X - point2D_2.X))
                    {
                        point2DList_LowerHull.RemoveAt(point2DList_LowerHull.Count - 1);
                    }
                    else
                    {
                        break;
                    }
                }
                point2DList_LowerHull.Add(point2D);
            }
            point2DList_LowerHull.RemoveAt(point2DList_LowerHull.Count - 1);

            if (!(point2Ds_Temp_UpperHull.Count == 1 && Enumerable.SequenceEqual(point2Ds_Temp_UpperHull, point2DList_LowerHull)))
            {
                point2Ds_Temp_UpperHull.AddRange(point2DList_LowerHull);
            }

            return point2Ds_Temp_UpperHull;
        }

        /// <summary>
        /// Computes the convex hull for a collection of <see cref="Segment2D"/>.
        /// </summary>
        /// <param name="segment2Ds">The <see cref="IEnumerable{T}"/> of <see cref="Segment2D"/> objects used to derive points for the convex hull.</param>
        /// <returns>A <see cref="List{T}"/> of <see cref="Point2D"/> vertices forming the convex hull, or <see langword="null"/> if the input is <see langword="null"/>.</returns>
        public static List<Point2D>? ConvexHull(this IEnumerable<Segment2D>? segment2Ds)
        {
            if (segment2Ds is null)
            {
                return null;
            }

            List<Point2D> point2Ds = [];
            foreach (Segment2D segment2D in segment2Ds)
            {
                Point2D? point2D = segment2D[0];
                if (point2D is not null)
                {
                    point2Ds.Add(point2D);
                }

                point2D = segment2D[1];
                if (point2D is not null)
                {
                    point2Ds.Add(point2D);
                }
            }

            return ConvexHull(point2Ds);
        }

        /// <summary>
        /// Computes the convex hull for the specified <see cref="ISegmentable2D"/> instance.
        /// </summary>
        /// <param name="segmentable2D">The <see cref="ISegmentable2D"/> instance to calculate the convex hull for.</param>
        /// <returns>A <see cref="List{Point2D}"/> containing the points of the convex hull, or null if the <paramref name="segmentable2D"/> is null.</returns>
        public static List<Point2D>? ConvexHull(this ISegmentable2D? segmentable2D)
        {
            return ConvexHull(segmentable2D?.GetPoints());
        }
    }
}
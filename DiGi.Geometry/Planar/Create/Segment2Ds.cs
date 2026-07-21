using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        /// <summary>
        /// Converts a collection of <see cref="Point2D"/> objects into a list of <see cref="Segment2D"/> objects.
        /// </summary>
        /// <param name="point2Ds">The <see cref="IEnumerable{T}"/> of <see cref="Point2D"/> points to process.</param>
        /// <param name="closed">A <see cref="bool"/> value indicating whether the sequence should be closed by connecting the last point back to the first point.</param>
        /// <returns>A <see cref="List{T}"/> of <see cref="Segment2D"/> objects, or <see langword="null"/> if the provided <see cref="IEnumerable{T}"/> is null.</returns>
        public static List<Segment2D>? Segment2Ds(this IEnumerable<Point2D>? point2Ds, bool closed = false)
        {
            if (point2Ds == null)
            {
                return null;
            }

            Point2D[] point2Ds_Local = point2Ds as Point2D[] ?? [.. point2Ds];
            int count = point2Ds_Local.Length;

            List<Segment2D> segment2Ds_Result = [];

            if (count < 2)
            {
                return segment2Ds_Result;
            }

            for (int i = 1; i < count; i++)
            {
                Point2D point2D_1 = point2Ds_Local[i - 1];
                if (point2D_1 == null)
                {
                    continue;
                }

                Point2D point2D_2 = point2Ds_Local[i];
                if (point2D_2 == null)
                {
                    continue;
                }

                segment2Ds_Result.Add(new Segment2D(new Point2D(point2D_1), new Point2D(point2D_2)));
            }

            if (closed)
            {
                segment2Ds_Result.Add(new Segment2D(new Point2D(segment2Ds_Result[segment2Ds_Result.Count - 1][1]), new Point2D(segment2Ds_Result[0][0])));
            }

            return segment2Ds_Result;
        }
    }
}
using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the orientations of all consecutive point triplets in a collection of points.
        /// </summary>
        /// <param name="point2Ds">The collection of points.</param>
        /// <returns>A list of orientations for each triplet, or null if not possible.</returns>
        public static List<Orientation>? Orientations(this IEnumerable<Point2D>? point2Ds)
        {
            if (point2Ds == null)
            {
                return null;
            }

            Point2D[] point2Ds_Local = point2Ds as Point2D[] ?? [.. point2Ds];
            int count = point2Ds_Local.Length;
            if (count < 3)
            {
                return null;
            }

            List<Orientation> orientations_Result = new()
            {
                Orientation(point2Ds_Local[count - 1], point2Ds_Local[0], point2Ds_Local[1])
            };

            for (int i = 1; i < count - 1; i++)
            {
                orientations_Result.Add(Orientation(point2Ds_Local[i - 1], point2Ds_Local[i], point2Ds_Local[i + 1]));
            }

            orientations_Result.Add(Orientation(point2Ds_Local[count - 2], point2Ds_Local[count - 1], point2Ds_Local[0]));

            return orientations_Result;
        }
    }
}
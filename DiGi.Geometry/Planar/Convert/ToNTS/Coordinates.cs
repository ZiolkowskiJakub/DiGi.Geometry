using DiGi.Geometry.Planar.Classes;
using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a collection of Point2D objects to a list of Coordinate objects.
        /// </summary>
/// <param name="point2Ds">The IEnumerable&lt;Point2D&gt; containing the points to convert.</param>
/// <returns>A <c>List&lt;Coordinate&gt;</c> containing the converted coordinates, or <see langword="null"/> if the input collection is null.</returns>
        public static List<Coordinate>? ToNTS(this IEnumerable<Point2D>? point2Ds)
        {
            if (point2Ds == null)
            {
                return null;
            }

            List<Coordinate> result = [];
            foreach (Point2D point2D in point2Ds)
            {
                Coordinate? coordinate = point2D?.ToNTS();
                if (coordinate is null)
                {
                    continue;
                }

                result.Add(coordinate);
            }

            return result;
        }
    }
}

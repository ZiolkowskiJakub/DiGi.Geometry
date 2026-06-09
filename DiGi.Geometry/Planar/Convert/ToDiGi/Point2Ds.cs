using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a collection of <see cref="NetTopologySuite.Geometries.Coordinate"/> objects to a list of <see cref="Point2D"/> objects.
        /// </summary>
/// <param name="coordinates">The <c>IEnumerable&lt;NetTopologySuite.Geometries.Coordinate&gt;</c> containing the coordinates to convert.</param>
/// <returns>A <c>List&lt;Point2D&gt;</c> containing the converted points, or null if the input <c>IEnumerable&lt;NetTopologySuite.Geometries.Coordinate&gt;</c> is null.</returns>
        public static List<Point2D>? ToDiGi(this IEnumerable<NetTopologySuite.Geometries.Coordinate>? coordinates)
        {
            if (coordinates == null)
            {
                return null;
            }

            List<Point2D> result = [];
            foreach (NetTopologySuite.Geometries.Coordinate coordinate in coordinates)
            {
                Point2D point2D = coordinate.ToDiGi();
                if (point2D == null)
                {
                    continue;
                }

                result.Add(point2D);
            }

            return result;
        }
    }
}
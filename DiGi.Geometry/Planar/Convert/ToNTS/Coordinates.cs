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

        /// <summary>
        /// Converts the points of a <see cref="Segmentable2D"/> to an array of NTS <see cref="Coordinate"/> objects without cloning the points.
        /// </summary>
        /// <param name="segmentable2D">The <see cref="Segmentable2D"/> instance to convert.</param>
        /// <param name="close">When <see langword="true"/>, the first coordinate is appended at the end to close the ring.</param>
        /// <returns>An array of <see cref="Coordinate"/> objects, or <see langword="null"/> if there are no points.</returns>
        public static Coordinate[]? ToNTS_Coordinates(this Segmentable2D? segmentable2D, bool close)
        {
            List<Point2D>? point2Ds = segmentable2D?.GetPoints(false);
            if (point2Ds == null || point2Ds.Count == 0)
            {
                return null;
            }

            int count = point2Ds.Count;

            List<Coordinate> coordinates = new(count + 1);
            for (int i = 0; i < count; i++)
            {
                Point2D point2D = point2Ds[i];
                if (point2D == null)
                {
                    continue;
                }

                coordinates.Add(new Coordinate(point2D.X, point2D.Y));
            }

            if (coordinates.Count == 0)
            {
                return null;
            }

            if (close)
            {
                coordinates.Add(coordinates[0]);
            }

            return [.. coordinates];
        }
    }
}
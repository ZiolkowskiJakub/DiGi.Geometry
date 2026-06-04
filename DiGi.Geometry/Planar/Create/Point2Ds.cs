using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        /// <summary>
        /// Generates a list of random points within the specified bounding box.
        /// </summary>
        /// <param name="boundingBox2D">The bounding box defining the area.</param>
        /// <param name="count">The number of points to generate; -1 returns null.</param>
        /// <returns>A list of random Point2D objects, or null if parameters are invalid.</returns>
        public static List<Point2D>? Point2Ds(this BoundingBox2D? boundingBox2D, int count)
        {
            if (count == -1 || boundingBox2D is null)
            {
                return null;
            }

            return Point2Ds(boundingBox2D.Min.X, boundingBox2D.Min.Y, boundingBox2D.Max.X, boundingBox2D.Max.Y, count);
        }

        /// <summary>
        /// Generates a list of random points within the specified coordinate range.
        /// </summary>
        /// <param name="x_min">The minimum X coordinate.</param>
        /// <param name="y_min">The minimum Y coordinate.</param>
        /// <param name="x_max">The maximum X coordinate.</param>
        /// <param name="y_max">The maximum Y coordinate.</param>
        /// <param name="count">The number of points to generate; -1 returns null.</param>
        /// <returns>A list of random Point2D objects, or null if count is -1.</returns>
        public static List<Point2D>? Point2Ds(double x_min, double y_min, double x_max, double y_max, int count)
        {
            if (count == -1)
            {
                return null;
            }

            System.Random random = new();

            List<Point2D> result = [];
            for (int i = 0; i < count; i++)
            {
                double x = DiGi.Core.Query.Random(random, x_min, x_max);
                double y = DiGi.Core.Query.Random(random, y_min, y_max);

                result.Add(new Point2D(x, y));
            }

            return result;
        }

        /// <summary>
        /// Creates a list of points from an array of coordinates.
        /// </summary>
        /// <param name="values">An array of X and Y coordinates (must have an even length).</param>
        /// <returns>A list of Point2D objects, or null if the input is null or has an invalid length.</returns>
        public static List<Point2D>? Point2Ds(params double[]? values)
        {
            if (values == null)
            {
                return null;
            }

            int length = values.Length;
            if (length == 0 || length % 2 != 0)
            {
                return null;
            }

            List<Point2D> result = [];
            for (int i = 0; i < length; i += 2)
            {
                result.Add(new Point2D(values[i], values[i + 1]));
            }

            return result;
        }
    }
}
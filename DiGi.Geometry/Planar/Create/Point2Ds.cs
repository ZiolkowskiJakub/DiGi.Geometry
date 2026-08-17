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
        /// Generates a regular grid of points covering the specified bounding box.
        /// <para>The first point sits on the minimum corner of the bounding box and the grid steps by <paramref name="gridSize_X"/> and <paramref name="gridSize_Y"/> towards the maximum corner. A row or column landing on the maximum corner within <paramref name="tolerance"/> is still included, so a bounding box whose extents are exact multiples of the grid size yields points on both corners.</para>
        /// </summary>
        /// <param name="boundingBox2D">The bounding box defining the area.</param>
        /// <param name="gridSize_X">The grid spacing along the X axis; has to be greater than zero.</param>
        /// <param name="gridSize_Y">The grid spacing along the Y axis; has to be greater than zero.</param>
        /// <param name="tolerance">The distance tolerance used when deciding whether the last row or column still fits within the bounding box.</param>
        /// <returns>A list of Point2D objects ordered column by column, or null if the parameters are invalid or the grid does not fit in a single list.</returns>
        public static List<Point2D>? Point2Ds(this BoundingBox2D? boundingBox2D, double gridSize_X, double gridSize_Y, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (boundingBox2D is null || double.IsNaN(gridSize_X) || double.IsNaN(gridSize_Y) || gridSize_X <= 0 || gridSize_Y <= 0)
            {
                return null;
            }

            double width = boundingBox2D.Width;
            double height = boundingBox2D.Height;
            if (double.IsNaN(width) || double.IsNaN(height))
            {
                return null;
            }

            // Kept in double for the range check - a large bounding box combined with a small grid size overflows int long before the list itself could be allocated.
            double count_X_Double = System.Math.Floor((width + tolerance) / gridSize_X) + 1;
            double count_Y_Double = System.Math.Floor((height + tolerance) / gridSize_Y) + 1;
            if (count_X_Double * count_Y_Double > int.MaxValue)
            {
                return null;
            }

            int count_X = System.Convert.ToInt32(count_X_Double);
            int count_Y = System.Convert.ToInt32(count_Y_Double);

            Point2D point2D_Min = boundingBox2D.Min;

            List<Point2D> result = new(count_X * count_Y);
            for (int i = 0; i < count_X; i++)
            {
                double x = point2D_Min.X + (i * gridSize_X);
                for (int j = 0; j < count_Y; j++)
                {
                    result.Add(new Point2D(x, point2D_Min.Y + (j * gridSize_Y)));
                }
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
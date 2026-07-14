using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Fits a collection of <see cref="Point2D"/> objects into the specified <see cref="BoundingBox2D"/>.
        /// </summary>
        /// <param name="boundingBox2D">The <see cref="BoundingBox2D"/> that defines the target area for fitting.</param>
        /// <param name="point2Ds">An <see cref="IEnumerable{Point2D}"/> containing the points to be fitted.</param>
        /// <param name="scale">When this method returns, contains the <see cref="double"/> scale factor used to fit the points; otherwise, <see cref="double.NaN"/>.</param>
        /// <param name="offset">A <see cref="double"/> value representing the offset applied during fitting.</param>
        /// <returns>A <c>List&lt;Point2D&gt;</c> containing the fitted points if successful; otherwise, <see langword="null"/>.</returns>
        public static List<Point2D>? Fit(this BoundingBox2D? boundingBox2D, IEnumerable<Point2D>? point2Ds, out double scale, double offset = 0)
        {
            scale = double.NaN;
            if (boundingBox2D is null || point2Ds is null)
            {
                return null;
            }

            Point2D[] point2Ds_Local = point2Ds as Point2D[] ?? [.. point2Ds];
            int count = point2Ds_Local.Length;
            if (count < 1)
            {
                return null;
            }

            Point2D point2D_First = point2Ds_Local[0];
            if (point2D_First == null)
            {
                return null;
            }

            double minSX = point2D_First.X;
            double maxSX = minSX;
            double minSY = point2D_First.Y;
            double maxSY = minSY;

            for (int i = 1; i < count; i++)
            {
                Point2D point2D = point2Ds_Local[i];
                if (point2D is null)
                {
                    continue;
                }

                minSX = System.Math.Min(minSX, point2D.X);
                maxSX = System.Math.Max(maxSX, point2D.X);
                minSY = System.Math.Min(minSY, point2D.Y);
                maxSY = System.Math.Max(maxSY, point2D.Y);
            }

            double minBX = boundingBox2D.Min.X;
            double maxBX = boundingBox2D.Max.X;

            double minBY = boundingBox2D.Min.Y;
            double maxBY = boundingBox2D.Max.Y;

            // shrink the bounding box by offset
            double innerMinBX = minBX + offset;
            double innerMinBY = minBY + offset;
            double innerMaxBX = maxBX - offset;
            double innerMaxBY = maxBY - offset;

            double sourceWidth = maxSX - minSX;
            double sourceHeight = maxSY - minSY;

            double targetWidth = innerMaxBX - innerMinBX;
            double targetHeight = innerMaxBY - innerMinBY;

            scale = System.Math.Min(targetWidth / sourceWidth, targetHeight / sourceHeight);

            double translateX = innerMinBX - minSX * scale;
            double translateY = innerMinBY - minSY * scale;

            List<Point2D> point2Ds_Result = new();

            for (int i = 0; i < count; i++)
            {
                Point2D point2D = point2Ds_Local[i];
                if (point2D is null)
                {
                    continue;
                }

                point2Ds_Result.Add(new Point2D(point2D.X * scale + translateX, point2D.Y * scale + translateY));
            }

            return point2Ds_Result;
        }

        /// <summary>
        /// Fits a collection of <see cref="Point2D"/> objects within the specified <see cref="BoundingBox2D"/>.
        /// </summary>
        /// <param name="boundingBox2D">The <see cref="BoundingBox2D"/> to fit the points into.</param>
        /// <param name="point2Ds">An <see cref="IEnumerable{T}"/> of <see cref="Point2D"/> objects to be fitted.</param>
        /// <param name="offset">A <see cref="double"/> value representing the offset for the fitting process.</param>
        /// <returns>A <see cref="List{T}"/> of fitted <see cref="Point2D"/> objects, or <see langword="null"/> if the input is invalid.</returns>
        public static List<Point2D>? Fit(this BoundingBox2D? boundingBox2D, IEnumerable<Point2D>? point2Ds, double offset = 0)
        {
            return Fit(boundingBox2D, point2Ds, out double _, offset);
        }

        /// <summary>
        /// Fits a <see cref="Segment2D"/> into a <see cref="BoundingBox2D"/>.
        /// </summary>
        /// <param name="boundingBox2D">The <see cref="BoundingBox2D"/> to fit the segment into.</param>
        /// <param name="segment2D">The <see cref="Segment2D"/> to be fitted.</param>
        /// <param name="scale">When this method returns, contains the calculated <see cref="double"/> scale factor; otherwise, <see cref="double.NaN"/>.</param>
        /// <param name="offset">The <see cref="double"/> offset value used during the fitting process.</param>
        /// <returns>A new <see cref="Segment2D"/> that fits within the bounding box, or <see langword="null"/> if the input parameters are null or the segment cannot be fitted.</returns>
        public static Segment2D? Fit(this BoundingBox2D? boundingBox2D, Segment2D? segment2D, out double scale, double offset = 0)
        {
            scale = double.NaN;
            if (boundingBox2D is null || segment2D is null)
            {
                return null;
            }

            if (segment2D[0] is not Point2D point2D_1)
            {
                return null;
            }

            if (segment2D[1] is not Point2D point2D_2)
            {
                return null;
            }

            List<Point2D>? point2Ds = boundingBox2D.Fit([point2D_1, point2D_2], out scale, offset);
            if (point2Ds is null || point2Ds.Count < 2)
            {
                return null;
            }

            return new Segment2D(point2Ds[0], point2Ds[1]);
        }

        /// <summary>
        /// Fits a <see cref="Segment2D"/> into a <see cref="BoundingBox2D"/>.
        /// </summary>
        /// <param name="boundingBox2D">The target <see cref="BoundingBox2D"/> to fit the segment into.</param>
        /// <param name="segment2D">The source <see cref="Segment2D"/> to be fitted.</param>
        /// <param name="offset">A <see cref="double"/> value representing the offset.</param>
        /// <returns>A <see cref="Segment2D"/> that fits within the bounding box, or <see langword="null"/> if either input is null.</returns>
        public static Segment2D? Fit(this BoundingBox2D? boundingBox2D, Segment2D? segment2D, double offset = 0)
        {
            return Fit(boundingBox2D, segment2D, out double _, offset);
        }

        /// <summary>
        /// Fits a source <see cref="BoundingBox2D"/> into a target <see cref="BoundingBox2D"/>.
        /// </summary>
        /// <param name="boundingBox2D">The target <see cref="BoundingBox2D"/> to fit the source bounding box into.</param>
        /// <param name="boundingBox2D_Source">The source <see cref="BoundingBox2D"/> that is being fitted.</param>
        /// <param name="scale">When this method returns, contains the calculated <see cref="double"/> scale factor used for fitting; otherwise, <see cref="double.NaN"/>.</param>
        /// <param name="offset">The <see cref="double"/> offset to apply during the fitting process.</param>
        /// <returns>A <see cref="BoundingBox2D"/> representing the fitted result, or <see langword="null"/> if either input bounding box is <see langword="null"/> or cannot be processed.</returns>
        public static BoundingBox2D? Fit(this BoundingBox2D? boundingBox2D, BoundingBox2D? boundingBox2D_Source, out double scale, double offset = 0)
        {
            scale = double.NaN;
            if (boundingBox2D is null || boundingBox2D_Source is null)
            {
                return null;
            }

            if (boundingBox2D_Source.Min is not Point2D point2D_Min)
            {
                return null;
            }

            if (boundingBox2D_Source.Max is not Point2D point2D_Max)
            {
                return null;
            }

            List<Point2D>? point2Ds = boundingBox2D.Fit([point2D_Min, point2D_Max], out scale, offset);
            if (point2Ds is null || point2Ds.Count < 2)
            {
                return null;
            }

            return new BoundingBox2D(point2Ds[0], point2Ds[1]);
        }

        /// <summary>
        /// Fits a source <see cref="BoundingBox2D"/> into a target <see cref="BoundingBox2D"/> with an optional offset.
        /// </summary>
        /// <param name="boundingBox2D">The target <see cref="BoundingBox2D"/> to fit into.</param>
        /// <param name="boundingBox2D_Source">The source <see cref="BoundingBox2D"/> to be fitted.</param>
        /// <param name="offset">A <see cref="double"/> value representing the offset applied during fitting.</param>
        /// <returns>The resulting <see cref="BoundingBox2D"/> if successful; otherwise, null.</returns>
        public static BoundingBox2D? Fit(this BoundingBox2D? boundingBox2D, BoundingBox2D? boundingBox2D_Source, double offset = 0)
        {
            return Fit(boundingBox2D, boundingBox2D_Source, out double _, offset);
        }

        /// <summary>
        /// Fits a <see cref="Polygon2D"/> into a <see cref="BoundingBox2D"/>.
        /// </summary>
        /// <param name="boundingBox2D">The <see cref="BoundingBox2D"/> to fit the polygon into.</param>
        /// <param name="polygon2D">The <see cref="Polygon2D"/> to be fitted.</param>
        /// <param name="offset">A <see cref="double"/> value representing the offset.</param>
        /// <returns>A new <see cref="Polygon2D"/> that fits within the bounding box, or <see langword="null"/> if the operation fails or any input is <see langword="null"/>.</returns>
        public static Polygon2D? Fit(this BoundingBox2D? boundingBox2D, Polygon2D? polygon2D, double offset = 0)
        {
            return Fit(boundingBox2D, polygon2D, out double _, offset);
        }

        /// <summary>
        /// Fits a <see cref="Polygon2D"/> into a <see cref="BoundingBox2D"/>.
        /// </summary>
        /// <param name="boundingBox2D">The <see cref="BoundingBox2D"/> that defines the target area for fitting.</param>
        /// <param name="polygon2D">The <see cref="Polygon2D"/> to be fitted into the bounding box.</param>
        /// <param name="scale">When this method returns, contains the <see cref="double"/> scale factor applied to fit the polygon; otherwise, <see cref="double.NaN"/>.</param>
        /// <param name="offset">A <see cref="double"/> value representing the offset used during the fitting process.</param>
        /// <returns>A new <see cref="Polygon2D"/> that fits within the specified bounding box, or <see langword="null"/> if either input is <see langword="null"/> or the resulting polygon contains fewer than two points.</returns>
        public static Polygon2D? Fit(this BoundingBox2D? boundingBox2D, Polygon2D? polygon2D, out double scale, double offset = 0)
        {
            scale = double.NaN;
            if (boundingBox2D is null || polygon2D is null)
            {
                return null;
            }

            List<Point2D>? point2Ds = boundingBox2D.Fit(polygon2D.GetPoints(), out scale, offset);
            if (point2Ds is null || point2Ds.Count < 2)
            {
                return null;
            }

            return new Polygon2D(point2Ds);
        }
    }
}
using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static List<Point2D>? Fit(this BoundingBox2D? boundingBox2D, IEnumerable<Point2D>? point2Ds, out double scale, double offset = 0)
        {
            scale = double.NaN;
            if (boundingBox2D is null || point2Ds is null)
            {
                return null;
            }

            int count = point2Ds.Count();
            if (count < 1)
            {
                return null;
            }

            double minSX = point2Ds.ElementAt(0).X;
            double maxSX = minSX;
            double minSY = point2Ds.ElementAt(0).Y;
            double maxSY = minSY;

            for (int i = 1; i < count; i++)
            {
                if (point2Ds.ElementAt(i) is not Point2D point2D)
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

            List<Point2D> result = [];

            foreach (Point2D point2D in point2Ds)
            {
                if (point2D is null)
                {
                    continue;
                }

                result.Add(new Point2D(point2D.X * scale + translateX, point2D.Y * scale + translateY));
            }

            return result;
        }

        public static List<Point2D>? Fit(this BoundingBox2D? boundingBox2D, IEnumerable<Point2D>? point2Ds, double offset = 0)
        {
            return Fit(boundingBox2D, point2Ds, out double _, offset);
        }

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

        public static Segment2D? Fit(this BoundingBox2D? boundingBox2D, Segment2D? segment2D, double offset = 0)
        {
            return Fit(boundingBox2D, segment2D, out double _, offset);
        }

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

        public static BoundingBox2D? Fit(this BoundingBox2D? boundingBox2D, BoundingBox2D? boundingBox2D_Source, double offset = 0)
        {
            return Fit(boundingBox2D, boundingBox2D_Source, out double _, offset);
        }

        public static Polygon2D? Fit(this BoundingBox2D? boundingBox2D, Polygon2D? polygon2D, double offset = 0)
        {
            return Fit(boundingBox2D, polygon2D, out double _, offset);
        }

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
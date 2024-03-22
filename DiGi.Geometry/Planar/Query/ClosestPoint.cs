using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static Point2D ClosestPoint(this Point2D point2D, Point2D point2D_1, Point2D point2D_2, bool bounded)
        {
            if(point2D == null || point2D_1 == null || point2D_2 == null)
            {
                return null;
            }

            double a = point2D.X - point2D_1.X;
            double b = point2D.Y - point2D_1.Y;
            double c = point2D_2.X - point2D_1.X;
            double d = point2D_2.Y - point2D_1.Y;

            double dot = a * c + b * d;
            double len_sq = c * c + d * d;
            double parameter = -1;
            if (len_sq != 0)
            {
                parameter = dot / len_sq;
            }

            if (parameter < 0 && bounded)
            {
                return new Point2D(point2D_1);
            }
            else if (parameter > 1 && bounded)
            {
                return new Point2D(point2D_2);
            }

            return new Point2D(point2D_1.X + parameter * c, point2D_1.Y + parameter * d);
        }

        public static Point2D ClosestPoint(this Point2D point2D, ISegmentable2D segmentable2D)
        {
            return ClosestPoint(point2D, segmentable2D?.GetSegments(), out double distance);
        }

        public static Point2D ClosestPoint(this Point2D point2D, ISegmentable2D segmentable2D, out double distance)
        {
            return ClosestPoint(point2D, segmentable2D?.GetSegments(), out distance);
        }

        public static Point2D ClosestPoint(this Point2D point2D, IEnumerable<Segment2D> segment2Ds, out double distance)
        {
            distance = double.NaN;
            if(point2D == null || segment2Ds == null)
            {
                return null;
            }

            distance = double.MaxValue;
            Point2D result = null;
            foreach(Segment2D segment2D in segment2Ds)
            {
                Point2D point2D_Closest = segment2D?.ClosestPoint(point2D);
                if(point2D_Closest == null)
                {
                    continue;
                }

                double distance_Temp = point2D_Closest.Distance(point2D);
                if(distance_Temp < distance)
                {
                    distance = distance_Temp;
                    result = point2D_Closest;
                }
            }

            return result;
        }

        public static Point2D ClosestPoint(this Point2D point2D, IEnumerable<Segment2D> segment2Ds)
        {
            return ClosestPoint(point2D, segment2Ds, out double distance);
        }

        public static Point2D ClosestPoint<T>(this Point2D point2D, IEnumerable<T> segmentable2Ds, out double distance) where T: ISegmentable2D
        {
            distance = double.NaN;
            if(point2D == null || segmentable2Ds == null || segmentable2Ds.Count() == 0)
            {
                return null;
            }

            return ClosestPoint(point2D, segmentable2Ds?.Segments());
        }

        public static Point2D ClosestPoint<T>(this Point2D point2D, IEnumerable<T> segmentable2Ds) where T: ISegmentable2D
        {
            return ClosestPoint(point2D, segmentable2Ds, out double distance);
        }
    }

}

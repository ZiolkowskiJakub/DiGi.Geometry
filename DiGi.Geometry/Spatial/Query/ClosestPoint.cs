using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        public static Point3D? ClosestPoint(this Point3D? point3D, Point3D? point3D_1, Point3D? point3D_2, bool bounded)
        {
            return ClosestPoint(point3D, point3D_1, point3D_2, bounded, bounded);
        }

        public static Point3D? ClosestPoint(this Point3D? point3D, Point3D? point3D_1, Point3D? point3D_2, bool bounded_1, bool bounded_2)
        {
            if (point3D == null || point3D_1 == null || point3D_2 == null)
            {
                return null;
            }

            Point3D start = point3D_1;
            Point3D end = point3D_2;

            double a = point3D.X - start.X;
            double b = point3D.Y - start.Y;
            double e = point3D.Z - start.Z;
            double c = end.X - start.X;
            double d = end.Y - start.Y;
            double f = end.Z - start.Z;

            double dot = a * c + b * d + e * f;
            double squareLength = c * c + d * d + f * f;
            double parameter = -1;
            if (squareLength != 0)
            {
                parameter = dot / squareLength;
            }

            if (parameter < 0 && bounded_1)
            {
                return new Point3D(start);
            }

            if (parameter > 1 && bounded_2)
            {
                return new Point3D(end);
            }

            return new Point3D(start.X + parameter * c, start.Y + parameter * d, start.Z + parameter * f);
        }

        public static Point3D? ClosestPoint(this Point3D? point3D, ISegmentable3D segmentable3D)
        {
            return ClosestPoint(point3D, segmentable3D?.GetSegments(), out _);
        }

        public static Point3D? ClosestPoint(this Point3D? point3D, ISegmentable3D? segmentable3D, out double distance)
        {
            return ClosestPoint(point3D, segmentable3D?.GetSegments(), out distance);
        }

        public static Point3D? ClosestPoint(this Point3D? point3D, IEnumerable<Segment3D>? segment3Ds)
        {
            return ClosestPoint(point3D, segment3Ds, out _);
        }

        public static Point3D? ClosestPoint(this Point3D? point3D, IEnumerable<Segment3D>? segment3Ds, out double distance)
        {
            distance = double.NaN;
            if (point3D == null || segment3Ds == null)
            {
                return null;
            }

            distance = double.MaxValue;
            Point3D? result = null;
            foreach (Segment3D segment3D in segment3Ds)
            {
                Point3D? point3D_Closest = segment3D?.ClosestPoint(point3D);
                if (point3D_Closest == null)
                {
                    continue;
                }

                double distance_Temp = point3D_Closest.Distance(point3D);
                if (distance_Temp < distance)
                {
                    distance = distance_Temp;
                    result = point3D_Closest;
                }
            }

            return result;
        }

        public static Point3D? ClosestPoint(this Point3D? point3D, IEnumerable<Point3D>? point3Ds, out double distance)
        {
            distance = double.NaN;
            if (point3D == null || point3Ds == null)
            {
                return null;
            }

            distance = double.MaxValue;
            Point3D? result = null;

            foreach (Point3D point3D_Temp in point3Ds)
            {
                if (point3D_Temp == null)
                {
                    continue;
                }

                double distance_Temp = point3D.Distance(point3D_Temp);
                if (distance_Temp > distance)
                {
                    continue;
                }

                distance = distance_Temp;
                result = point3D_Temp;
            }

            if (distance == double.MaxValue)
            {
                distance = double.NaN;
            }

            return result;
        }

        public static Point3D? ClosestPoint<TPolygonalFace3D>(this Point3D? point3D, IEnumerable<TPolygonalFace3D> polygonalFace3Ds) where TPolygonalFace3D : IPolygonalFace3D
        {
            return ClosestPoint(point3D, polygonalFace3Ds, out _, out _, 0.0);
        }

        public static Point3D? ClosestPoint<TPolygonalFace3D>(this Point3D? point3D, IEnumerable<TPolygonalFace3D> polygonalFace3Ds, out TPolygonalFace3D? closestPolygonalFace3D, out double distance, double tolerance = DiGi.Core.Constans.Tolerance.Distance) where TPolygonalFace3D : IPolygonalFace3D
        {
            distance = double.NaN;
            closestPolygonalFace3D = default;

            if (point3D is null || polygonalFace3Ds is null)
            {
                return null;
            }

            distance = double.MaxValue;

            Point3D? result = null;

            foreach (TPolygonalFace3D polygonalFace3D in polygonalFace3Ds)
            {
                if (polygonalFace3D?.ClosestPoint(point3D) is not Point3D closestPoint_Temp)
                {
                    continue;
                }

                double distance_Temp = closestPoint_Temp.Distance(point3D);
                if (distance_Temp < distance)
                {
                    result = closestPoint_Temp;

                    distance = distance_Temp;
                    closestPolygonalFace3D = polygonalFace3D;
                    if (distance < tolerance)
                    {
                        break;
                    }
                }
            }

            return result;
        }
    }

}

using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        public static Point3D ClosestPoint(this Point3D point3D, Point3D point3D_1, Point3D point3D_2, bool bounded)
        {
            if(point3D == null || point3D_1 == null || point3D_2 == null)
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
                parameter = dot / squareLength;

            if (parameter < 0 && bounded)
            {
                return start;
            }
            else if (parameter > 1 && bounded)
            {
                return end;
            }
            else
            {
                return new Point3D(start.X + parameter * c, start.Y + parameter * d, start.Z + parameter * f);
            }
        }

        public static Point3D ClosestPoint(this Point3D point3D, ISegmentable3D segmentable3D)
        {
            return ClosestPoint(point3D, segmentable3D?.GetSegments(), out double distance);
        }

        public static Point3D ClosestPoint(this Point3D point3D, ISegmentable3D segmentable3D, out double distance)
        {
            return ClosestPoint(point3D, segmentable3D?.GetSegments(), out distance);
        }

        public static Point3D ClosestPoint(this Point3D point3D, IEnumerable<Segment3D> segment3Ds)
        {
            return ClosestPoint(point3D, segment3Ds, out double distance);
        }

        public static Point3D ClosestPoint(this Point3D point3D, IEnumerable<Segment3D> segment3Ds, out double distance)
        {
            distance = double.NaN;
            if (point3D == null || segment3Ds == null)
            {
                return null;
            }

            distance = double.MaxValue;
            Point3D result = null;
            foreach (Segment3D segment3D in segment3Ds)
            {
                Point3D point3D_Closest = segment3D?.ClosestPoint(point3D);
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
    }

}

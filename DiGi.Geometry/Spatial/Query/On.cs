using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        public static bool On(this ISegmentable3D segmentable3D, Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point3D == null || segmentable3D == null)
            {
                return false;
            }

            List<Segment3D> segment3Ds = segmentable3D.GetSegments();
            if (segment3Ds == null)
            {
                return false;
            }

            for (int i = 0; i < segment3Ds.Count; i++)
            {
                if (segment3Ds[i].On(point3D, tolerance))
                {
                    return true;
                }
            }

            return false;

        }

        public static bool On(this Plane plane, Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point3D == null || plane == null)
            {
                return false;
            }

            Vector3D normal = plane.Normal;
            if(normal == null)
            {
                return false;
            }


            Point3D origin = plane.Origin;
            if(origin == null)
            {
                return false;
            }


            return System.Math.Abs((normal.X * (point3D.X - origin.X)) + (normal.Y * (point3D.Y - origin.Y)) + (normal.Z * (point3D.Z - origin.Z))) < tolerance;
        }
        
        public static bool On(this Plane plane, Segment3D segment3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(plane == null || segment3D == null)
            {
                return false;
            }

            return plane.On(segment3D.Start, tolerance) && plane.On(segment3D.End, tolerance);
        }

        public static bool On(this Plane plane, ISegmentable3D segmentable3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(plane == null || segmentable3D == null)
            {
                return false;
            }

            List<Point3D> point3Ds = segmentable3D.GetPoints();
            if(point3Ds == null)
            {
                return false;
            }

            for (int i = 0; i < point3Ds.Count; i++)
            {
                if (!plane.On(point3Ds[i], tolerance))
                {
                    return false;
                }
            }

            return true;

        }
    }
}

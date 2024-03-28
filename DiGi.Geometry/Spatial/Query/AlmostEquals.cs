using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        public static bool AlmostEquals(this Point3D point3D_1, Point3D point3D_2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(point3D_1 == point3D_2)
            {
                return true;
            }

            if(point3D_1 == null || point3D_2 == null)
            {
                return false;
            }

            return point3D_1.Distance(point3D_2) <= tolerance;
        }

        public static bool AlmostEquals(this ISegmentable3D segmentable3D_1, ISegmentable3D segmentable3D_2, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(segmentable3D_1 == segmentable3D_2)
            {
                return true;
            }

            if (segmentable3D_1 == null || segmentable3D_2 == null)
            {
                return false;
            }

            if(segmentable3D_1.GetType() != segmentable3D_2.GetType())
            {
                return false;
            }

            List<Point3D> point3Ds_1 = segmentable3D_1.GetPoints();
            List<Point3D> point3Ds_2 = segmentable3D_2.GetPoints();

            if((point3Ds_1 == null || point3Ds_1.Count == 0) && (point3Ds_2 == null || point3Ds_2.Count == 0))
            {
                return true;
            }

            if(point3Ds_1 == null || point3Ds_2 == null || point3Ds_1.Count != point3Ds_2.Count)
            {
                return false;
            }

            for(int i = 0; i < point3Ds_1.Count; i++)
            {
                if (!AlmostEquals(point3Ds_1[i], point3Ds_2[i], tolerance))
                {
                    return false;
                }
            }

            return true;
        }
    }
}

using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        public static bool InRange<T>(IPlanar<T> planar, Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance) where T : IPolygonal2D
        {
            if(planar == null || point3D == null)
            {
                return false;
            }

            return InRange(planar, new Point3D[] { point3D }, tolerance);
        }

        public static bool InRange<T>(IPlanar<T> planar, IEnumerable<Point3D> point3Ds, double tolerance = DiGi.Core.Constans.Tolerance.Distance) where T : IPolygonal2D
        {
            if (point3Ds == null || planar == null)
            {
                return false;
            }

            Plane plane = planar.Plane;
            if (plane == null)
            {
                return false;
            }

            for (int i = 0; i < point3Ds.Count(); i++)
            {
                if (!plane.On(point3Ds.ElementAt(i), tolerance))
                {
                    return false;
                }
            }

            IPolygonal2D polygonal2D = planar.Geometry2D;
            for (int i = 0; i < point3Ds.Count(); i++)
            {
                Point2D point2D = plane.Convert(point3Ds.ElementAt(i));
                if (point2D == null)
                {
                    continue;
                }

                if (!polygonal2D.InRange(point2D, tolerance))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool InRange<T>(IPlanar<T> planar, ISegmentable3D segmentable3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance) where T : IPolygonal2D
        {
            if (planar == null || segmentable3D == null)
            {
                return false;
            }

            Plane plane = planar.Plane;

            if (!On(plane, segmentable3D, tolerance))
            {
                return false;
            }

            List<Segment3D> segment3Ds = segmentable3D.GetSegments();
            if (segment3Ds == null)
            {
                return false;
            }

            IPolygonal2D polygonal2D = planar.Geometry2D;
            if (polygonal2D == null)
            {
                return false;
            }

            for (int i = 0; i < segment3Ds.Count; i++)
            {
                Segment2D segment2D = plane.Convert(segment3Ds[i]);
                if (segment2D == null)
                {
                    continue;
                }

                if (!polygonal2D.InRange(segment2D, tolerance))
                {
                    return false;
                }
            }

            return true;
        }
    }

}

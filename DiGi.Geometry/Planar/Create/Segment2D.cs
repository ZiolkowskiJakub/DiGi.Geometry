using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        public static Segment2D Segment2D(this Line2D line2D, IClosedSegmentable2D closedSegmentable2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (line2D == null || closedSegmentable2D == null)
            {
                return null;
            }

            IntersectionResult2D intersectionResult2D = IntersectionResult2D(line2D, closedSegmentable2D, tolerance);
            if(intersectionResult2D == null || !intersectionResult2D.Intersect)
            {
                return null;
            }

            if(intersectionResult2D.Contains<Segment2D>())
            {
                return intersectionResult2D.GetGeometry2Ds<Segment2D>()?.FirstOrDefault();
            }


            List<Point2D> point2Ds = intersectionResult2D.GetGeometry2Ds<Point2D>();
            if(point2Ds == null || point2Ds.Count < 2)
            {
                return null;
            }

            return new Segment2D(point2Ds[0], point2Ds[1]);
        }
    }

}

using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Geometries;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        public static List<SegmentableFace2D> SegmentableFace2Ds(this IEnumerable<Segment2D> segment2Ds, double tolerace = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(segment2Ds == null || segment2Ds.Count() < 3)
            {
                return null;
            }

            List<Polygon> polygons = Polygons(segment2Ds, tolerace);
            if(polygons == null)
            {
                return null;
            }

            List<SegmentableFace2D> result = new List<SegmentableFace2D>();
            foreach(Polygon polygon in polygons)
            {
                SegmentableFace2D segmentableFace2D = polygon?.ToDiGi();
                if (segmentableFace2D == null)
                {
                    continue;
                }

                result.Add(segmentableFace2D);
            }

            return result;
        }

        public static List<SegmentableFace2D> SegmentableFace2Ds(this IEnumerable<IClosedSegmentable2D> closedSegmentable2Ds, double tolerace = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(closedSegmentable2Ds == null)
            {
                return null;
            }

            return SegmentableFace2Ds(closedSegmentable2Ds.Segments(), tolerace);
        }
    }

}

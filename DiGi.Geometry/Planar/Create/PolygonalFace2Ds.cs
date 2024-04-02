using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Geometries;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        public static List<PolygonalFace2D> PolygonalFace2Ds(this IEnumerable<Segment2D> segment2Ds, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(segment2Ds == null || segment2Ds.Count() < 3)
            {
                return null;
            }

            List<Polygon> polygons = Polygons(segment2Ds, tolerance);
            if(polygons == null)
            {
                return null;
            }

            List<PolygonalFace2D> result = new List<PolygonalFace2D>();
            foreach(Polygon polygon in polygons)
            {
                PolygonalFace2D polygonalFace2D = polygon?.ToDiGi();
                if (polygonalFace2D == null)
                {
                    continue;
                }

                result.Add(polygonalFace2D);
            }

            return result;
        }

        public static List<PolygonalFace2D> PolygonalFace2Ds(this IEnumerable<IPolygonal2D> polygonal2Ds, double tolerace = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(polygonal2Ds == null)
            {
                return null;
            }

            return PolygonalFace2Ds(polygonal2Ds.Segments(), tolerace);
        }
    }

}

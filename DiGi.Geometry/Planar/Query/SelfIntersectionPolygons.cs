using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static List<Polygon2D> SelfIntersectionPolygons(this IPolygonal2D polygonal2D, double maxLength, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            List<Segment2D> segment2Ds = SelfIntersectionSegments(polygonal2D, maxLength, tolerance);
            if (segment2Ds == null || segment2Ds.Count < 2)
            {
                return null;
            }

            segment2Ds = segment2Ds.Split(tolerance);

            List<PolygonalFace2D> polygonalFace2Ds = Create.PolygonalFace2Ds(segment2Ds, tolerance);
            if (polygonalFace2Ds == null)
            {
                return null;
            }

            BoundingBox2D boundingBox2D = polygonal2D.GetBoundingBox();

            List<Polygon2D> result = new List<Polygon2D>();
            for(int i = 0; i < polygonalFace2Ds.Count; i++)
            {
                List<IPolygonal2D> polygonal2Ds = polygonalFace2Ds[i]?.Edges;
                if(polygonal2Ds == null)
                {
                    continue;
                }

                for(int j = 0; j < polygonal2Ds.Count; j++)
                {
                    IPolygonal2D polygonal2D_Temp = polygonal2Ds[j];
                    if(polygonal2D_Temp == null)
                    {
                        continue;
                    }

                    Point2D point2D = polygonal2D_Temp.GetInternalPoint();
                    if(!boundingBox2D.Inside(point2D, tolerance))
                    {
                        continue;
                    }

                    if(!polygonal2D.Inside(point2D, tolerance))
                    {
                        continue;
                    }

                    result.Add(new Polygon2D(polygonal2D_Temp));
                }
            }

            return result;
        }
    }
}

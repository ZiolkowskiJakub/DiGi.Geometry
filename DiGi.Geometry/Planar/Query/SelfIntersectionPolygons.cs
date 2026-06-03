using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Identifies polygons that are formed by self-intersections in a polygonal geometry.
        /// </summary>
        /// <param name="polygonal2D">The polygonal geometry to analyze.</param>
        /// <param name="maxLength">The maximum length for an intersection segment to be considered.</param>
        /// <param name="tolerance">The distance tolerance for intersection detection.</param>
        /// <returns>A list of polygons formed by self-intersections.</returns>
        public static List<Polygon2D>? SelfIntersectionPolygons(this IPolygonal2D? polygonal2D, double maxLength, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            List<Segment2D>? segment2Ds = SelfIntersectionSegments(polygonal2D, maxLength, tolerance);
            if (segment2Ds == null || segment2Ds.Count < 2)
            {
                return null;
            }

            segment2Ds = segment2Ds.Split(tolerance);

            List<PolygonalFace2D>? polygonalFace2Ds = Create.PolygonalFace2Ds(segment2Ds, tolerance);
            if (polygonalFace2Ds == null)
            {
                return null;
            }

            BoundingBox2D? boundingBox2D = polygonal2D?.GetBoundingBox();
            if (boundingBox2D is null)
            {
                return null;
            }

            List<Polygon2D> result = [];
            for (int i = 0; i < polygonalFace2Ds.Count; i++)
            {
                List<IPolygonal2D>? polygonal2Ds = polygonalFace2Ds[i]?.Edges;
                if (polygonal2Ds == null)
                {
                    continue;
                }

                for (int j = 0; j < polygonal2Ds.Count; j++)
                {
                    IPolygonal2D polygonal2D_Temp = polygonal2Ds[j];
                    if (polygonal2D_Temp == null)
                    {
                        continue;
                    }

                    Point2D? point2D = polygonal2D_Temp.GetInternalPoint();
                    if (!boundingBox2D.Inside(point2D, tolerance))
                    {
                        continue;
                    }

                    if (!polygonal2D!.Inside(point2D, tolerance))
                    {
                        continue;
                    }

                    result.Add(new(polygonal2D_Temp));
                }
            }

            return result;
        }
    }
}
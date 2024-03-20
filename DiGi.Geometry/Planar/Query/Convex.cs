using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static bool Convex(this IEnumerable<Point2D> point2Ds)
        {
            if (point2Ds == null || point2Ds.Count() < 3)
            {
                return false;
            }

            return !Concave(point2Ds);
        }

        public static bool Convex(this IPolygonal2D polygonal2D)
        {
            return Convex(polygonal2D?.GetPoints());
        }

        public static bool Convex(this PolygonalFace2D polygonalFace2D, bool externalEdge = true, bool internalEdges = true)
        {
            if (polygonalFace2D == null)
            {
                return false;
            }

            if(externalEdge)
            {
                IPolygonal2D polygonal2D = polygonalFace2D.ExternalEdge;
                if(polygonal2D == null)
                {
                    return false;
                }

                if(!polygonal2D.Convex())
                {
                    return false;
                }
            }

            if(internalEdges)
            {
                List<IPolygonal2D> polygonal2Ds = polygonalFace2D.InternalEdges;
                if(polygonal2Ds != null)
                {
                    for(int i =0; i < polygonal2Ds.Count; i++)
                    {
                        if (!polygonal2Ds[i].Convex())
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
    }
}

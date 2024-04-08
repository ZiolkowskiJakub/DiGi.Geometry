using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        public static PolygonalFace2D PolygonalFace2D(this IPolygonal2D externalEdge, IEnumerable<IPolygonal2D> internalEdges = null, double tolerace = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(externalEdge == null)
            {
                return null;
            }

            List<IPolygonal2D> internalEdges_Inside = null;
            if(internalEdges != null)
            {
                internalEdges_Inside = new List<IPolygonal2D>();
                foreach (IPolygonal2D internalEdge in internalEdges)
                {
                    if(externalEdge.Inside(internalEdge, tolerace))
                    {
                        internalEdges_Inside.Add(internalEdge);
                    }
                }

                if (internalEdges_Inside.Count > 1)
                {
                    DiGi.Core.Modify.Sort(internalEdges_Inside, x => x.GetArea());
                    internalEdges_Inside.Reverse();

                    List<IPolygonal2D> internalEdges_Temp = new List<IPolygonal2D>();

                    while(internalEdges_Inside.Count > 0)
                    {
                        IPolygonal2D internalEdge = internalEdges_Inside[0];

                        internalEdges_Temp.Add(internalEdge);
                        internalEdges_Inside.RemoveAt(0);

                        for (int i = internalEdges_Inside.Count - 1; i >= 0; i--)
                        {
                            if (internalEdge.InRange(internalEdges_Inside[i], tolerace))
                            {
                                internalEdges_Inside.RemoveAt(i);
                            }
                        }
                    }

                    internalEdges_Inside = internalEdges_Temp;
                }

                if (internalEdges_Inside.Count == 0)
                {
                    internalEdges_Inside = null;
                }
            }

            return new PolygonalFace2D(externalEdge, internalEdges_Inside);
        }

        public static PolygonalFace2D PolygonalFace2D(params Point2D[] points)
        {
            if(points == null || points.Length < 3)
            {
                return null;
            }

            return new PolygonalFace2D(new Polygon2D(points));
        }
    }

}

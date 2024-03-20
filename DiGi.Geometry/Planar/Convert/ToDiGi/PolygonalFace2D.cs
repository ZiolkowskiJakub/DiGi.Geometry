using DiGi.Geometry.Planar.Classes;
using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        public static PolygonalFace2D ToDiGi(this Polygon polygon)
        {
            if (polygon == null || polygon.IsEmpty)
            {
                return null;
            }

            LinearRing linearRing = polygon.ExteriorRing as LinearRing;
            if (linearRing == null)
            {
                return null;
            }

            Polygon2D externalEdge = linearRing.ToDiGi();
            if(externalEdge == null)
            {
                return null;
            }

            List<Polygon2D> internalEdges = new List<Polygon2D>();

            LineString[] lineStrings = polygon.InteriorRings;
            if (lineStrings != null && lineStrings.Length > 0)
            {
                foreach (LineString lineString in lineStrings)
                {
                    LinearRing linearRing_Temp = lineString as LinearRing;
                    if (linearRing_Temp == null)
                    {
                        continue;
                    }

                    Polygon2D polygon2D_Temp = linearRing_Temp.ToDiGi();
                    if (polygon2D_Temp == null)
                    {
                        continue;
                    }

                    internalEdges.Add(polygon2D_Temp);
                }
            }

            return new PolygonalFace2D(externalEdge, internalEdges);
        }
    }
}

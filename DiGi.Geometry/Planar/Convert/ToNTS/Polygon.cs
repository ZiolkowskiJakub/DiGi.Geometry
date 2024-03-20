using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        public static Polygon ToNTS(this IPolygonalFace2D polygonalFace2D)
        {
            LinearRing linearRing_ExternalEdge = polygonalFace2D?.ExternalEdge?.ToNTS();
            if (linearRing_ExternalEdge == null)
            {
                return null;
            }

            List<LinearRing> linearRings_InternalEdges = polygonalFace2D.InternalEdges?.ConvertAll(x => x.ToNTS());

            LinearRing[] linearRingsArray_InternalEdges = null;
            if (linearRings_InternalEdges != null && linearRings_InternalEdges.Count > 0)
            {
                linearRingsArray_InternalEdges = linearRings_InternalEdges.ToArray();
            }

            if (linearRingsArray_InternalEdges == null)
            {
                return new Polygon(linearRing_ExternalEdge);
            }
            else
            {
                return new Polygon(linearRing_ExternalEdge, linearRingsArray_InternalEdges);
            }
        }

        public static Polygon ToNTS_Polygon(this Polygon2D polygon2D)
        {
            if(polygon2D == null)
            {
                return null;
            }

            return new Polygon(polygon2D.ToNTS());
        }
    }
}

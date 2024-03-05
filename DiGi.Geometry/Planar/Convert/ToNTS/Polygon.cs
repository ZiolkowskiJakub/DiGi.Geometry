using DiGi.Geometry.Planar.Classes;
using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        public static Polygon ToNTS(this SegmentableFace2D segmentableFace2D)
        {
            LinearRing linearRing_ExternalEdge = segmentableFace2D?.ExternalCurve?.ToNTS();
            if (linearRing_ExternalEdge == null)
            {
                return null;
            }

            List<LinearRing> linearRings_InternalEdges = segmentableFace2D.InternalCurves?.ConvertAll(x => x.ToNTS());

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
    }
}

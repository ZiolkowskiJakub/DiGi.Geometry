using DiGi.Geometry.Planar.Classes;
using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        public static SegmentableFace2D ToDiGi(this Polygon polygon)
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

            Polygon2D externalCurve = linearRing.ToDiGi();
            if(externalCurve == null)
            {
                return null;
            }

            List<Polygon2D> internalCurves = new List<Polygon2D>();

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

                    internalCurves.Add(polygon2D_Temp);
                }
            }

            return new SegmentableFace2D(externalCurve, internalCurves);
        }
    }
}

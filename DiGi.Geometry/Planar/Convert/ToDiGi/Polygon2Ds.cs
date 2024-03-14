using DiGi.Geometry.Planar.Classes;
using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        public static List<Polygon2D> ToDiGi_Polygon2Ds(this Polygon polygon)
        {
            if(polygon == null)
            {
                return null;
            }

            LineString lineString = polygon.ExteriorRing;
            if(lineString == null)
            {
                return null;
            }

            List<Polygon2D> result = new List<Polygon2D>();
            result.Add(new Polygon2D(lineString.Coordinates.ToDiGi()));

            LineString[] lineStrings = polygon.InteriorRings;
            if(lineStrings == null)
            {
                return result;
            }

            foreach(LineString lineString_Temp in lineStrings)
            {
                result.Add(new Polygon2D(lineString_Temp.Coordinates.ToDiGi()));
            }

            return result;
        }
    }
}

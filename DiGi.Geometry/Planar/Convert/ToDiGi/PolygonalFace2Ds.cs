using DiGi.Geometry.Planar.Classes;
using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        public static List<PolygonalFace2D>? ToDiGi_PolygonalFace2Ds(this MultiPolygon? multiPolygon)
        {
            List<Polygon>? polygons = Create.Polygons(multiPolygon);
            if (polygons == null)
            {
                return null;
            }

            List<PolygonalFace2D> result = [];
            foreach (Polygon polygon in polygons)
            {
                PolygonalFace2D? polygonalFace2D = polygon?.ToDiGi();
                if (polygonalFace2D is not null)
                {
                    result.Add(polygonalFace2D);
                }
            }

            return result;
        }
    }
}
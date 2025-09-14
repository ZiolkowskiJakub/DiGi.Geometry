using DiGi.Geometry.Planar.Classes;
using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        public static List<PolygonalFace2D>? ToDiGi_PolygonalFace2Ds(this MultiPolygon? multiPolygon)
        {
            if (multiPolygon == null)
            {
                return null;
            }

            NetTopologySuite.Geometries.Geometry[] geometries = multiPolygon.Geometries;
            if (geometries == null)
            {
                return null;
            }

            List<PolygonalFace2D> result = [];
            foreach (NetTopologySuite.Geometries.Geometry geometry in geometries)
            {
                if (geometry is Polygon polygon)
                {
                    PolygonalFace2D? polygonalFace2D = polygon.ToDiGi();
                    if(polygonalFace2D is not null)
                    {
                        result.Add(polygonalFace2D);
                    }
                }
                else if (geometry is MultiPolygon multiPolygon_Temp)
                {
                    List<PolygonalFace2D>? polygons = ToDiGi_PolygonalFace2Ds(multiPolygon_Temp);
                    if (polygons != null && polygons.Count > 0)
                    {
                        result.AddRange(polygons);
                    }
                }
                else if (geometry is LinearRing linearRing)
                {
                    result.Add(new PolygonalFace2D(linearRing.ToDiGi()));
                }
            }

            return result;
        }
    }
}

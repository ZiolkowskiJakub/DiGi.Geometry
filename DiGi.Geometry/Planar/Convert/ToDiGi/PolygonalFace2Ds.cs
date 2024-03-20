using DiGi.Geometry.Planar.Classes;
using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        public static List<PolygonalFace2D> ToDiGi_PolygonalFace2Ds(this MultiPolygon multiPolygon)
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

            List<PolygonalFace2D> result = new List<PolygonalFace2D>();
            foreach (NetTopologySuite.Geometries.Geometry geometry in geometries)
            {
                if (geometry is Polygon)
                {
                    result.Add(((Polygon)geometry).ToDiGi());
                }
                else if (geometry is MultiPolygon)
                {
                    List<PolygonalFace2D> polygons = ToDiGi_PolygonalFace2Ds((MultiPolygon)geometry);
                    if (polygons != null && polygons.Count > 0)
                    {
                        result.AddRange(polygons);
                    }
                }
                else if (geometry is LinearRing)
                {
                    result.Add(new PolygonalFace2D(((LinearRing)geometry).ToDiGi()));
                }
            }

            return result;
        }
    }
}

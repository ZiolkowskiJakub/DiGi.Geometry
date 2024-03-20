using DiGi.Geometry.Planar.Classes;
using NetTopologySuite.Geometries;
using NetTopologySuite.Geometries.Utilities;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static List<PolygonalFace2D> Difference(this PolygonalFace2D polygonalFace2D_1, PolygonalFace2D polygonalFace2D_2)
        {
            if(polygonalFace2D_1 == null || polygonalFace2D_2 == null)
            {
                return null;
            }

            Polygon polygon_1 = polygonalFace2D_1.ToNTS();
            if(polygon_1 == null)
            {
                return null;
            }

            Polygon polygon_2 = polygonalFace2D_2.ToNTS();
            if(polygon_2 == null)
            {
                return null;
            }

            List<PolygonalFace2D> result = new List<PolygonalFace2D>();

            if (polygon_1.EqualsTopologically(polygon_2))
            {
                return result;
            }

            NetTopologySuite.Geometries.Geometry geometry_1 = polygon_1;
            if (!geometry_1.IsValid)
            {
                geometry_1 = GeometryFixer.Fix(geometry_1);
            }

            NetTopologySuite.Geometries.Geometry geometry_2 = polygon_2;
            if (!geometry_2.IsValid)
            {
                geometry_2 = GeometryFixer.Fix(geometry_2);
            }

            NetTopologySuite.Geometries.Geometry geometry = null;
            try
            {
                geometry = geometry_1.Difference(geometry_2);
            }
            catch
            {
                return null;
            }

            if (geometry == null || geometry.IsEmpty)
            {
                return result;
            }

            List<NetTopologySuite.Geometries.Geometry> geometries = geometry is GeometryCollection ? ((GeometryCollection)geometry).Geometries?.ToList() : new List<NetTopologySuite.Geometries.Geometry>() { geometry };
            if (geometries == null || geometries.Count == 0)
            {
                return null;
            }

            foreach (NetTopologySuite.Geometries.Geometry geometry_Temp in geometries)
            {
                if (geometry_Temp is Polygon)
                {
                    PolygonalFace2D polygonalFace2D = ((Polygon)geometry_Temp).ToDiGi();
                    if (polygonalFace2D != null)
                    {
                        result.Add(polygonalFace2D);
                    }
                }
                else if (geometry_Temp is MultiPolygon)
                {
                    List<PolygonalFace2D> polygonalFace2Ds = ((MultiPolygon)geometry_Temp).ToDiGi_PolygonalFace2Ds();
                    if (polygonalFace2Ds != null && polygonalFace2Ds.Count > 0)
                    {
                        result.AddRange(polygonalFace2Ds);
                    }
                }
                else if (geometry_Temp is LinearRing)
                {
                    Polygon2D polygon2D = ((LinearRing)geometry_Temp).ToDiGi();
                    if (polygon2D != null)
                    {
                        result.Add(new PolygonalFace2D(polygon2D));
                    }
                }
            }

            return result;
        }
    }
}

using DiGi.Geometry.Planar.Classes;
using NetTopologySuite.Geometries;
using NetTopologySuite.Geometries.Utilities;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static List<SegmentableFace2D> Difference(this SegmentableFace2D segmentableFace2D_1, SegmentableFace2D segmentableFace2D_2)
        {
            if(segmentableFace2D_1 == null || segmentableFace2D_2 == null)
            {
                return null;
            }

            Polygon polygon_1 = segmentableFace2D_1.ToNTS();
            if(polygon_1 == null)
            {
                return null;
            }

            Polygon polygon_2 = segmentableFace2D_2.ToNTS();
            if(polygon_2 == null)
            {
                return null;
            }

            List<SegmentableFace2D> result = new List<SegmentableFace2D>();

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
                    SegmentableFace2D segmentableFace2D = ((Polygon)geometry_Temp).ToDiGi();
                    if (segmentableFace2D != null)
                    {
                        result.Add(segmentableFace2D);
                    }
                }
                else if (geometry_Temp is MultiPolygon)
                {
                    List<SegmentableFace2D> segmentableFace2Ds = ((MultiPolygon)geometry_Temp).ToDiGi_SegmentableFace2Ds();
                    if (segmentableFace2Ds != null && segmentableFace2Ds.Count > 0)
                    {
                        result.AddRange(segmentableFace2Ds);
                    }
                }
                else if (geometry_Temp is LinearRing)
                {
                    Polygon2D polygon2D = ((LinearRing)geometry_Temp).ToDiGi();
                    if (polygon2D != null)
                    {
                        result.Add(new SegmentableFace2D(polygon2D));
                    }
                }
            }

            return result;
        }
    }
}

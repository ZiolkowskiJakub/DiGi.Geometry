using DiGi.Geometry.Planar.Classes;
using NetTopologySuite.Geometries;
using NetTopologySuite.Noding.Snapround;
using NetTopologySuite.Operation.Polygonize;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        public static List<Polygon>? Polygons(this IEnumerable<Segment2D>? segment2Ds, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (segment2Ds == null)
            {
                return null;
            }

            if (segment2Ds.Count() == 0)
            {
                return [];
            }

            List<NetTopologySuite.Geometries.Geometry> geometries = [];
            foreach (Segment2D segment2D in segment2Ds)
            {
                NetTopologySuite.Geometries.Geometry? geometry = segment2D.ToNTS_LineString();
                if (geometry == null)
                {
                    continue;
                }

                geometries.Add(geometry);
            }

            return Polygons(geometries, tolerance);
        }

        public static List<Polygon>? Polygons(this IEnumerable<NetTopologySuite.Geometries.Geometry>? geometries, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (geometries == null)
            {
                return null;
            }

            List<Polygon> result = [];

            if (geometries.Count() == 0)
            {
                return result;
            }

            List<NetTopologySuite.Geometries.Geometry> geometries_Temp = [];
            foreach (NetTopologySuite.Geometries.Geometry geometry_Temp in geometries)
            {
                if (geometry_Temp == null || !geometry_Temp.IsValid)
                {
                    continue;
                }

                geometries_Temp.Add(geometry_Temp);
            }

            if (geometries_Temp.Count() == 0)
            {
                return result;
            }

            GeometryNoder geometryNoder = new(new PrecisionModel(1 / tolerance));

            List<LineString> lineStrings = [.. geometryNoder.Node(geometries_Temp)];
            if (lineStrings == null || lineStrings.Count == 0)
            {
                return result;
            }

            Polygonizer polygonizer = new(false);
            polygonizer.Add([.. lineStrings]);

            IEnumerable<NetTopologySuite.Geometries.Geometry> geometries_Result = polygonizer.GetPolygons();
            if (geometries_Result == null)
            {
                return null;
            }

            if (geometries_Result.Count() == 0)
            {
                result.AddRange(geometries_Temp.FindAll(x => x is Polygon).Cast<Polygon>());
                result.AddRange(geometries_Temp.FindAll(x => x is LinearRing).ConvertAll(x => new Polygon((LinearRing)x)));
                return result;
            }

            foreach (NetTopologySuite.Geometries.Geometry geometry in geometries_Result)
            {
                Polygon? polygon = geometry as Polygon;
                if (polygon == null)
                {
                    continue;
                }

                result.Add(polygon);
            }

            return result;
        }

        public static List<Polygon>? Polygons(this MultiPolygon? multiPolygon)
        {
            NetTopologySuite.Geometries.Geometry[]? geometries = multiPolygon?.Geometries;
            if (geometries == null)
            {
                return null;
            }

            List<Polygon> result = [];
            foreach (NetTopologySuite.Geometries.Geometry geometry in geometries)
            {
                if (geometry is Polygon polygon)
                {
                    result.Add(polygon);
                }
                else if (geometry is MultiPolygon multiPolygon_Temp)
                {
                    List<Polygon>? polygons = Polygons(multiPolygon_Temp);
                    if (polygons != null && polygons.Count > 0)
                    {
                        result.AddRange(polygons);
                    }
                }
                else if (geometry is LinearRing linearRing)
                {
                    result.Add(new Polygon(linearRing));
                }
            }

            return result;
        }
    }
}
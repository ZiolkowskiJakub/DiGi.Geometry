using DiGi.Core;
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
        public static List<Polygon> Polygons(this IEnumerable<Segment2D> segment2Ds, double tolerance = Constans.Tolerance.Distance)
        {
            if (segment2Ds == null)
            {
                return null;
            }

            if (segment2Ds.Count() == 0)
            {
                return new List<Polygon>();
            }

            List<NetTopologySuite.Geometries.Geometry> geometries = new List<NetTopologySuite.Geometries.Geometry>();
            foreach(Segment2D segment2D in segment2Ds)
            {
                NetTopologySuite.Geometries.Geometry geometry = segment2D.ToNTS_LineString();
                if(geometry == null)
                {
                    continue;
                }

                geometries.Add(geometry);
            }

            return Polygons(geometries, tolerance);
        }

        public static List<Polygon> Polygons(this IEnumerable<NetTopologySuite.Geometries.Geometry> geometries, double tolerance = Constans.Tolerance.Distance)
        {
            if (geometries == null)
            {
                return null;
            }

            List<Polygon> result = new List<Polygon>();

            if (geometries.Count() == 0)
            {
                return result;
            }

            List<NetTopologySuite.Geometries.Geometry> geometries_Temp = new List<NetTopologySuite.Geometries.Geometry>();
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

            GeometryNoder geometryNoder = new GeometryNoder(new PrecisionModel(1 / tolerance));

            List<LineString> lineStrings = geometryNoder.Node(geometries_Temp).ToList();
            if (lineStrings == null || lineStrings.Count == 0)
            {
                return result;
            }

            Polygonizer polygonizer = new Polygonizer(false);
            polygonizer.Add(lineStrings.ToArray());

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
                Polygon polygon = geometry as Polygon;
                if (polygon == null)
                {
                    continue;
                }

                result.Add(polygon);
            }

            return result;
        }
    }
}

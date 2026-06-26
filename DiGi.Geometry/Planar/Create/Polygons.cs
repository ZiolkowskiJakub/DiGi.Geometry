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
        /// <summary>
        /// Creates a list of NTS polygons from a collection of segments.
        /// </summary>
        /// <param name="segment2Ds">The collection of segments.</param>
        /// <param name="tolerance">The distance tolerance for connecting segments into loops.</param>
        /// <returns>A list of NetTopologySuite Polygons; otherwise, null if input is null.</returns>
        public static List<Polygon>? Polygons(this IEnumerable<Segment2D>? segment2Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segment2Ds == null)
            {
                return null;
            }

            List<NetTopologySuite.Geometries.Geometry> geometries = [];
            foreach (Segment2D segment2D in segment2Ds)
            {
                if (segment2D == null)
                {
                    continue;
                }

                NetTopologySuite.Geometries.Geometry? geometry = segment2D.ToNTS_LineString();
                if (geometry != null)
                {
                    geometries.Add(geometry);
                }
            }

            if (geometries.Count == 0)
            {
                return [];
            }

            return Polygons(geometries, tolerance);
        }

        /// <summary>
        /// Creates a list of NTS polygons from a collection of geometries by nodalizing and polygonizing them.
        /// </summary>
        /// <param name="geometries">The collection of geometries (lines, rings, etc.).</param>
        /// <param name="tolerance">The precision tolerance used for nodalization.</param>
        /// <returns>A list of NetTopologySuite Polygons; otherwise, null if input is null.</returns>
        public static List<Polygon>? Polygons(this IEnumerable<NetTopologySuite.Geometries.Geometry>? geometries, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (geometries == null)
            {
                return null;
            }

            List<Polygon> polygons_Result = [];

            List<NetTopologySuite.Geometries.Geometry> geometries_Temp = [];
            foreach (NetTopologySuite.Geometries.Geometry geometry_Temp in geometries)
            {
                if (geometry_Temp == null || !geometry_Temp.IsValid)
                {
                    continue;
                }

                geometries_Temp.Add(geometry_Temp);
            }

            if (geometries_Temp.Count == 0)
            {
                return polygons_Result;
            }

            GeometryNoder geometryNoder = new(new PrecisionModel(1 / tolerance));

            List<LineString> lineStrings = [.. geometryNoder.Node(geometries_Temp)];
            if (lineStrings == null || lineStrings.Count == 0)
            {
                return polygons_Result;
            }

            Polygonizer polygonizer = new(false);
            polygonizer.Add([.. lineStrings]);

            IEnumerable<NetTopologySuite.Geometries.Geometry> geometries_Result = polygonizer.GetPolygons();
            if (geometries_Result == null)
            {
                return null;
            }

            List<NetTopologySuite.Geometries.Geometry> geometries_ResultList = [.. geometries_Result];
            if (geometries_ResultList.Count == 0)
            {
                polygons_Result.AddRange(geometries_Temp.FindAll(x => x is Polygon).Cast<Polygon>());
                polygons_Result.AddRange(geometries_Temp.FindAll(x => x is LinearRing).ConvertAll(x => new Polygon((LinearRing)x)));
                return polygons_Result;
            }

            foreach (NetTopologySuite.Geometries.Geometry geometry in geometries_ResultList)
            {
                Polygon? polygon = geometry as Polygon;
                if (polygon == null)
                {
                    continue;
                }

                polygons_Result.Add(polygon);
            }

            return polygons_Result;
        }

        /// <summary>
        /// Extracts a list of polygons from an NTS MultiPolygon.
        /// </summary>
        /// <param name="multiPolygon">The MultiPolygon to extract polygons from.</param>
        /// <returns>A list of NetTopologySuite Polygons; otherwise, null if input is null.</returns>
        public static List<Polygon>? Polygons(this MultiPolygon? multiPolygon)
        {
            NetTopologySuite.Geometries.Geometry[]? geometries = multiPolygon?.Geometries;
            if (geometries == null)
            {
                return null;
            }

            List<Polygon> polygons_Result = [];
            foreach (NetTopologySuite.Geometries.Geometry geometry in geometries)
            {
                if (geometry is Polygon polygon)
                {
                    polygons_Result.Add(polygon);
                }
                else if (geometry is MultiPolygon multiPolygon_Temp)
                {
                    List<Polygon>? polygons = Polygons(multiPolygon_Temp);
                    if (polygons != null && polygons.Count > 0)
                    {
                        polygons_Result.AddRange(polygons);
                    }
                }
                else if (geometry is LinearRing linearRing)
                {
                    polygons_Result.Add(new Polygon(linearRing));
                }
            }

            return polygons_Result;
        }
    }
}
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a list of polygons from a segmentable geometry.
        /// </summary>
        /// <param name="segmentable2D">The segmentable geometry.</param>
        /// <param name="tolerance">The distance tolerance for identifying loops.</param>
        /// <returns>A list of Polygon2D objects; otherwise, null if input is null.</returns>
        public static List<Polygon2D>? Polygon2Ds(this ISegmentable2D? segmentable2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segmentable2D == null)
            {
                return null;
            }

            List<Polygon2D> polygon2Ds_Result = [];
            if (segmentable2D is Rectangle2D)
            {
                polygon2Ds_Result.Add(new Polygon2D(segmentable2D.GetPoints()));
            }
            else if (segmentable2D is Triangle2D)
            {
                polygon2Ds_Result.Add(new Polygon2D(segmentable2D.GetPoints()));
            }
            else if (segmentable2D is BoundingBox2D)
            {
                polygon2Ds_Result.Add(new Polygon2D(segmentable2D.GetPoints()));
            }
            else
            {
                List<Segment2D>? segment2Ds = segmentable2D.GetSegments();
                if (segment2Ds != null && segment2Ds.Count > 2)
                {
                    segment2Ds = Query.Split(segment2Ds, tolerance);
                    List<PolygonalFace2D>? polygonalFace2Ds = PolygonalFace2Ds(segment2Ds, tolerance);
                    if (polygonalFace2Ds != null && polygonalFace2Ds.Count != 0)
                    {
                        foreach (PolygonalFace2D polygonalFace2D in polygonalFace2Ds)
                        {
                            List<IPolygonal2D>? polygonal2Ds = polygonalFace2D.Edges;
                            if (polygonal2Ds != null)
                            {
                                foreach (IPolygonal2D polygonal2D in polygonal2Ds)
                                {
                                    if (polygonal2D != null)
                                    {
                                        polygon2Ds_Result.Add(new Polygon2D(polygonal2D.GetPoints()));
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return polygon2Ds_Result;
        }

        /// <summary>
        /// Creates a list of polygons from a collection of segments.
        /// </summary>
        /// <param name="segment2Ds">The collection of segments.</param>
        /// <param name="tolerance">The distance tolerance for connecting segments into loops.</param>
        /// <returns>A list of Polygon2D objects; otherwise, null if inputs are invalid or no polygons can be formed.</returns>
        public static List<Polygon2D>? Polygon2Ds(this IEnumerable<Segment2D>? segment2Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segment2Ds == null)
            {
                return null;
            }

            Segment2D[] segment2Ds_Materialized = segment2Ds as Segment2D[] ?? [.. segment2Ds];
            if (segment2Ds_Materialized.Length < 3)
            {
                return null;
            }

            List<Polygon>? polygons = Polygons(segment2Ds_Materialized, tolerance);
            if (polygons == null)
            {
                return null;
            }

            List<Polygon2D> polygon2Ds_Result = [];
            foreach (Polygon polygon in polygons)
            {
                List<Polygon2D>? polygon2Ds = polygon?.ToDiGi_Polygon2Ds();
                if (polygon2Ds == null)
                {
                    continue;
                }

                polygon2Ds_Result.AddRange(polygon2Ds);
            }

            return polygon2Ds_Result;
        }
    }
}
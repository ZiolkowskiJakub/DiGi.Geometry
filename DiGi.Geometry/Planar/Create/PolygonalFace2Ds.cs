using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a list of <see cref="Classes.PolygonalFace2D"/> objects from a collection of <see cref="Segment2D"/> segments.
        /// </summary>
        /// <param name="segment2Ds">The <see cref="IEnumerable{T}"/> of <see cref="Segment2D"/> segments to process.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used for distance calculations.</param>
        /// <returns>A <see cref="List{T}"/> of <see cref="Classes.PolygonalFace2D"/> objects if successful; otherwise, <c>null</c>.</returns>
        public static List<PolygonalFace2D>? PolygonalFace2Ds(this IEnumerable<Segment2D>? segment2Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
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

            List<PolygonalFace2D> polygonalFace2Ds_Result = new(polygons.Count);
            foreach (Polygon polygon in polygons)
            {
                PolygonalFace2D? polygonalFace2D = polygon?.ToDiGi();
                if (polygonalFace2D == null)
                {
                    continue;
                }

                polygonalFace2Ds_Result.Add(polygonalFace2D);
            }

            return polygonalFace2Ds_Result;
        }

        /// <summary>
        /// Converts a collection of <see cref="IPolygonal2D"/> objects to a list of <see cref="Classes.PolygonalFace2D"/> objects.
        /// </summary>
        /// <param name="polygonal2Ds">The <see cref="IEnumerable{T}"/> of <see cref="IPolygonal2D"/> objects to convert.</param>
        /// <param name="tolerace">The <see cref="double"/> distance tolerance used for the conversion.</param>
        /// <returns>A <see cref="List{T}"/> of <see cref="Classes.PolygonalFace2D"/> objects, or <see langword="null"/> if the input collection is <see langword="null"/>.</returns>
        public static List<PolygonalFace2D>? PolygonalFace2Ds(this IEnumerable<IPolygonal2D>? polygonal2Ds, double tolerace = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (polygonal2Ds == null)
            {
                return null;
            }

            List<NetTopologySuite.Geometries.Geometry> geometries = [];
            foreach (IPolygonal2D polygonal2D in polygonal2Ds)
            {
                LinearRing? linearRing = polygonal2D?.ToNTS();
                if (linearRing == null)
                {
                    continue;
                }

                geometries.Add(linearRing);
            }

            if (geometries.Count == 0)
            {
                return null;
            }

            List<Polygon>? polygons = Polygons(geometries, tolerace);
            if (polygons == null)
            {
                return null;
            }

            List<PolygonalFace2D> polygonalFace2Ds_Result = new(polygons.Count);
            foreach (Polygon polygon in polygons)
            {
                PolygonalFace2D? polygonalFace2D = polygon?.ToDiGi();
                if (polygonalFace2D == null)
                {
                    continue;
                }

                polygonalFace2Ds_Result.Add(polygonalFace2D);
            }

            return polygonalFace2Ds_Result;
        }
    }
}
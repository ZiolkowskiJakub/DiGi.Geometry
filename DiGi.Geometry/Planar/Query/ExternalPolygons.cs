using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Extracts and identifies external polygons from a collection of segmentable 2D objects, optionally extending the segments by a specified distance.
        /// </summary>
        /// <typeparam name="T">The type of the segmentable 2D objects, which must implement <see cref="ISegmentable2D"/>.</typeparam>
        /// <param name="segmentable2Ds">An <see cref="IEnumerable{T}"/> of segmentable 2D objects to process.</param>
        /// <param name="maxDistance">A <see cref="double"/> representing the distance by which each segment should be extended.</param>
        /// <param name="tolerance">A <see cref="double"/> specifying the tolerance used for distance calculations.</param>
        /// <returns>A <see cref="List{Polygon2D}"/> containing the identified external polygons, or <see langword="null"/> if the input collection is null or contains no segments.</returns>
        public static List<Polygon2D>? ExternalPolygons<T>(this IEnumerable<T>? segmentable2Ds, double maxDistance, double tolerance = DiGi.Core.Constants.Tolerance.Distance) where T : ISegmentable2D
        {
            List<Segment2D>? segment2Ds = segmentable2Ds?.Segments();
            if (segment2Ds == null)
            {
                return null;
            }

            if (maxDistance != 0)
            {
                for (int i = 0; i < segment2Ds.Count; i++)
                {
                    Segment2D? segment2D = segment2Ds[i]?.Extend(maxDistance);
                    if (segment2D is not null)
                    {
                        segment2Ds[i] = segment2D;
                    }
                }
            }

            return ExternalPolygons(segment2Ds, tolerance);
        }

        /// <summary>
        /// Extracts the external polygons from a collection of segmentable 2D objects using a specified distance tolerance.
        /// </summary>
        /// <typeparam name="T">The type of the segmentable 2D objects, which must implement <see cref="ISegmentable2D"/>.</typeparam>
        /// <param name="segmentable2Ds">The <see cref="IEnumerable{T}"/> collection of segmentable 2D objects to process.</param>
        /// <param name="tolerance">The <see cref="double"/> distance tolerance used for calculations.</param>
        /// <returns>A <see cref="List{Polygon2D}"/> containing the external polygons, or <c>null</c> if the input collection is <c>null</c>.</returns>
        public static List<Polygon2D>? ExternalPolygons<T>(this IEnumerable<T>? segmentable2Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance) where T : ISegmentable2D
        {
            return ExternalPolygons(segmentable2Ds?.Segments(), tolerance);
        }

        /// <summary>
        /// Extracts the external polygons from a collection of 2D segments using a specified distance tolerance.
        /// </summary>
        /// <param name="segment2Ds">The <see cref="IEnumerable{Segment2D}"/> collection of segments to process.</param>
        /// <param name="tolerance">The <see cref="double"/> distance tolerance used for calculations.</param>
        /// <returns>A <see cref="List{Polygon2D}"/> containing the external polygons, or <c>null</c> if the input collection is <c>null</c>.</returns>
        public static List<Polygon2D>? ExternalPolygons(this IEnumerable<Segment2D>? segment2Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segment2Ds == null)
            {
                return null;
            }

            List<Polygon2D> result = [];

            List<PolygonalFace2D>? polygonalFace2Ds = Create.PolygonalFace2Ds(segment2Ds, tolerance);
            if (polygonalFace2Ds == null || polygonalFace2Ds.Count == 0)
            {
                return result;
            }

            polygonalFace2Ds = polygonalFace2Ds.Union();
            if (polygonalFace2Ds == null || polygonalFace2Ds.Count == 0)
            {
                return result;
            }

            for (int i = 0; i < polygonalFace2Ds.Count; i++)
            {
                IPolygonal2D? polygonal2D = polygonalFace2Ds[i]?.ExternalEdge;
                if (polygonal2D == null)
                {
                    continue;
                }

                result.Add(new(polygonal2D));
            }

            return result;
        }
    }
}

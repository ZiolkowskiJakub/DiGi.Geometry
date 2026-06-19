using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves all segments from a collection of segmentable 2D geometries.
        /// </summary>
        /// <typeparam name="T">The type of the segmentable geometry, which must implement <see cref="ISegmentable2D"/>.</typeparam>
        /// <param name="segmentable2Ds">The collection of segmentable 2D geometries to process.</param>
        /// <returns>A list containing all segments extracted from the provided geometries, or null if the input collection is null.</returns>
        public static List<Segment2D>? Segments<T>(this IEnumerable<T>? segmentable2Ds) where T : ISegmentable2D
        {
            if (segmentable2Ds == null)
            {
                return null;
            }

            List<Segment2D> result = [];
            foreach (T segmentable2D in segmentable2Ds)
            {
                List<Segment2D>? segment2Ds = segmentable2D?.GetSegments();
                if (segment2Ds == null || segment2Ds.Count == 0)
                {
                    continue;
                }

                for (int i = 0; i < segment2Ds.Count; i++)
                {
                    result.Add(segment2Ds[i]);
                }
            }

            return result;
        }

        /// <summary>
        /// Retrieves all segments (external and internal) from a polygonal face.
        /// </summary>
        /// <param name="polygonalFace2D">The polygonal face to extract segments from.</param>
        /// <returns>A list of all segments in the polygonal face.</returns>
        public static List<Segment2D>? Segments(this IPolygonalFace2D? polygonalFace2D)
        {
            IPolygonal2D? externalEdge = polygonalFace2D?.ExternalEdge;
            if (externalEdge == null)
            {
                return null;
            }

            List<Segment2D>? result = externalEdge.GetSegments();
            if (result == null)
            {
                return null;
            }

            List<IPolygonal2D>? internalEdges = polygonalFace2D?.InternalEdges;
            if (internalEdges != null)
            {
                for (int i = 0; i < internalEdges.Count; i++)
                {
                    List<Segment2D>? segment2Ds = internalEdges[i]?.GetSegments();
                    if (segment2Ds != null && segment2Ds.Count != 0)
                    {
                        result.AddRange(segment2Ds);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Retrieves all segments from a collection of polygonal faces.
        /// </summary>
        /// <typeparam name="T">The type of the polygonal face elements, which must implement <see cref="IPolygonalFace2D"/>.</typeparam>
        /// <param name="polygonalFace2Ds">The collection of polygonal faces to extract segments from.</param>
        /// <returns>A list containing all extracted <see cref="Segment2D"/> objects, or null if the input collection is null.</returns>
        public static List<Segment2D>? Segment2Ds<T>(this IEnumerable<T>? polygonalFace2Ds) where T : IPolygonalFace2D
        {
            if (polygonalFace2Ds == null)
            {
                return null;
            }

            List<Segment2D> result = [];
            foreach (T polygonalFace2D in polygonalFace2Ds)
            {
                List<Segment2D>? segment2Ds = polygonalFace2D?.Segments();
                if (segment2Ds == null || segment2Ds.Count == 0)
                {
                    continue;
                }

                result.AddRange(segment2Ds);
            }

            return result;
        }
    }
}
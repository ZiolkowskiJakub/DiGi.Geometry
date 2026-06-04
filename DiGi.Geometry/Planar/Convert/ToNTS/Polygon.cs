using DiGi.Core;
using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts an <see cref="IPolygonalFace2D"/> instance to a NetTopologySuite <see cref="Polygon"/>.
        /// </summary>
        /// <param name="polygonalFace2D">The <see cref="IPolygonalFace2D"/> instance to convert.</param>
        /// <returns>A <see cref="Polygon"/> representing the polygonal face, or <see langword="null"/> if the provided <see cref="IPolygonalFace2D"/> is null or its external edge cannot be converted.</returns>
        public static Polygon? ToNTS(this IPolygonalFace2D? polygonalFace2D)
        {
            LinearRing? linearRing_ExternalEdge = polygonalFace2D?.ExternalEdge?.ToNTS();
            if (linearRing_ExternalEdge == null)
            {
                return null;
            }

            List<LinearRing>? linearRings_InternalEdges = polygonalFace2D?.InternalEdges?.ConvertAll(x => x.ToNTS())?.FilterNulls();

            LinearRing[]? linearRingsArray_InternalEdges = null;
            if (linearRings_InternalEdges != null && linearRings_InternalEdges.Count > 0)
            {
                linearRingsArray_InternalEdges = [.. linearRings_InternalEdges];
            }

            if (linearRingsArray_InternalEdges == null)
            {
                return new Polygon(linearRing_ExternalEdge);
            }
            else
            {
                return new Polygon(linearRing_ExternalEdge, linearRingsArray_InternalEdges);
            }
        }

        /// <summary>
        /// Converts the specified <see cref="IPolygonal2D"/> instance to a NetTopologySuite <see cref="Polygon"/>.
        /// </summary>
        /// <param name="polygonal2D">The <see cref="IPolygonal2D"/> instance to convert.</param>
        /// <returns>A <see cref="Polygon"/> object if the provided <see cref="IPolygonal2D"/> is not null; otherwise, null.</returns>
        public static Polygon? ToNTS_Polygon(this IPolygonal2D? polygonal2D)
        {
            if (polygonal2D == null)
            {
                return null;
            }

            return new Polygon(polygonal2D.ToNTS());
        }
    }
}
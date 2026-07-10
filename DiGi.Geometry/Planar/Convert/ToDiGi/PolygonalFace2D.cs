using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts the specified <see cref="Polygon"/> to a <see cref="PolygonalFace2D"/>.
        /// </summary>
        /// <param name="polygon">The <see cref="Polygon"/> instance to convert.</param>
        /// <returns>A <see cref="PolygonalFace2D"/> representation of the polygon, or <see langword="null"/> if the <see cref="Polygon"/> is null, empty, or cannot be converted.</returns>
        public static PolygonalFace2D? ToDiGi(this Polygon? polygon)
        {
            if (polygon == null || polygon.IsEmpty)
            {
                return null;
            }

            LinearRing? linearRing = polygon.ExteriorRing as LinearRing;
            if (linearRing == null)
            {
                return null;
            }

            Polygon2D? externalEdge = linearRing.ToDiGi();
            if (externalEdge == null)
            {
                return null;
            }

            List<IPolygonal2D> internalEdges = [];

            LineString[] lineStrings = polygon.InteriorRings;
            if (lineStrings != null && lineStrings.Length > 0)
            {
                foreach (LineString lineString in lineStrings)
                {
                    LinearRing? linearRing_Temp = lineString as LinearRing;
                    if (linearRing_Temp == null)
                    {
                        continue;
                    }

                    Polygon2D? polygon2D_Temp = linearRing_Temp.ToDiGi();
                    if (polygon2D_Temp == null)
                    {
                        continue;
                    }

                    internalEdges.Add(polygon2D_Temp);
                }
            }

            return new PolygonalFace2D(externalEdge, internalEdges, false);
        }
    }
}
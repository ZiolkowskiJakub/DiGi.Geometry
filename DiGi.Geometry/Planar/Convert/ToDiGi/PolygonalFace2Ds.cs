using DiGi.Geometry.Planar.Classes;
using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="MultiPolygon"/> instance to a <see cref="List{PolygonalFace2D}"/> of <see cref="PolygonalFace2D"/> objects.
        /// </summary>
        /// <param name="multiPolygon">The <see cref="MultiPolygon"/> instance to convert.</param>
        /// <returns>A <see cref="List{PolygonalFace2D}"/> containing the converted <see cref="PolygonalFace2D"/> objects, or null if the input is null or cannot be processed.</returns>
        public static List<PolygonalFace2D>? ToDiGi_PolygonalFace2Ds(this MultiPolygon? multiPolygon)
        {
            List<Polygon>? polygons = Create.Polygons(multiPolygon);
            if (polygons == null)
            {
                return null;
            }

            List<PolygonalFace2D> result = [];
            foreach (Polygon polygon in polygons)
            {
                PolygonalFace2D? polygonalFace2D = polygon?.ToDiGi();
                if (polygonalFace2D is not null)
                {
                    result.Add(polygonalFace2D);
                }
            }

            return result;
        }
    }
}
using DiGi.Geometry.Planar.Classes;
using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="Polygon"/> to a list of <see cref="Polygon2D"/>.
        /// </summary>
        /// <param name="polygon">The <see cref="Polygon"/> instance to convert.</param>
        /// <returns>A <see cref="List{Polygon2D}"/> containing the converted polygons, or null if the provided <see cref="Polygon"/> is null or has no exterior ring.</returns>
        public static List<Polygon2D>? ToDiGi_Polygon2Ds(this Polygon? polygon)
        {
            if (polygon == null)
            {
                return null;
            }

            LineString lineString = polygon.ExteriorRing;
            if (lineString == null)
            {
                return null;
            }

            List<Polygon2D> result = [];
            result.Add(new Polygon2D(lineString.Coordinates.ToDiGi()));

            LineString[] lineStrings = polygon.InteriorRings;
            if (lineStrings == null)
            {
                return result;
            }

            foreach (LineString lineString_Temp in lineStrings)
            {
                result.Add(new Polygon2D(lineString_Temp.Coordinates.ToDiGi()));
            }

            return result;
        }
    }
}
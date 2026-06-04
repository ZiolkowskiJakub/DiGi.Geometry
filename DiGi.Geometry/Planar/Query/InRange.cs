using NetTopologySuite.Geometries;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether two geometries are within a specified distance tolerance of each other.
        /// </summary>
        /// <param name="geometry_1">The first <see cref="NetTopologySuite.Geometries.Geometry"/> to evaluate.</param>
        /// <param name="geometry_2">The second <see cref="NetTopologySuite.Geometries.Geometry"/> to evaluate.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the maximum distance threshold for proximity.</param>
        /// <returns>A <see cref="bool"/> indicating whether the geometries intersect or are within the specified tolerance; otherwise, false if either geometry is null.</returns>
        public static bool InRange(this NetTopologySuite.Geometries.Geometry geometry_1, NetTopologySuite.Geometries.Geometry geometry_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (geometry_1 is null || geometry_2 is null)
            {
                return false;
            }

            // 1. Topological Check
            // Intersects() in NTS for Polygons includes the Interior.
            // This returns true if geometry2 is inside or touching geometry1.
            if (geometry_1.Intersects(geometry_2))
            {
                return true;
            }

            // 2. Proximity Check (Gap analysis)
            // If they don't intersect, we check if the gap is within the tolerance.
            // We treat LinearRings as "Filled" Polygons for this logic.

            NetTopologySuite.Geometries.Geometry geometry_Temp_1 = geometry_1;
            NetTopologySuite.Geometries.Geometry geometry_Temp_2 = geometry_2;

            // Mapping LinearRing to Polygon to ensure "Filled" behavior during Distance calculation
            if (geometry_1 is LinearRing linearRing_1)
            {
                geometry_Temp_1 = new Polygon(linearRing_1);
            }

            if (geometry_2 is LinearRing linearRing_2)
            {
                geometry_Temp_2 = new Polygon(linearRing_2);
            }

            // NTS Distance() returns the minimum distance between geometries.
            // Since we ensured Polygons are used for closed loops,
            // any point inside will result in a distance of 0 (already caught by Intersects).
            return geometry_Temp_1.Distance(geometry_Temp_2) < tolerance;
        }
    }
}
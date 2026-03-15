using NetTopologySuite.Geometries;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
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
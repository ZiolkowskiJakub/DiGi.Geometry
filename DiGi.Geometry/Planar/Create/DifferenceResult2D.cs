using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Geometries;
using NetTopologySuite.Geometries.Utilities;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        /// <summary>
        /// Calculates the 2D boolean difference between two polygonal faces.
        /// </summary>
        /// <remarks>
        /// <para>Invalid (self-intersecting) inputs are repaired before the overlay is computed.</para>
        /// <para>If the first face is degenerate (zero area, collapsing under repair), the difference is lower-dimensional: the parts of the face boundary linework lying outside the second face are returned as <see cref="Segment2D"/>/<see cref="Polyline2D"/>/<see cref="Point2D"/> elements.</para>
        /// </remarks>
        /// <param name="polygonalFace2D_1">The first polygonal face (from which to subtract).</param>
        /// <param name="polygonalFace2D_2">The second polygonal face (to subtract).</param>
        /// <returns>A <see cref="Classes.DifferenceResult2D"/> containing the difference geometry, or null if polygonalFace2D_1 is null or the computation fails.</returns>
        public static DifferenceResult2D? DifferenceResult2D(this IPolygonalFace2D? polygonalFace2D_1, IPolygonalFace2D? polygonalFace2D_2)
        {
            if (polygonalFace2D_1 == null)
            {
                return null;
            }

            if (polygonalFace2D_2 == null)
            {
                PolygonalFace2D? polygonalFace2D = polygonalFace2D_1 as PolygonalFace2D ?? polygonalFace2D_1.ToNTS()?.ToDiGi();
                return polygonalFace2D == null ? null : new DifferenceResult2D(polygonalFace2D);
            }

            // Early-out Axis-Aligned Bounding Box (AABB) intersection check
            BoundingBox2D? boundingBox2D_1 = polygonalFace2D_1.GetBoundingBox();
            BoundingBox2D? boundingBox2D_2 = polygonalFace2D_2.GetBoundingBox();
            if (boundingBox2D_1 != null && boundingBox2D_2 != null && !boundingBox2D_1.InRange(boundingBox2D_2))
            {
                PolygonalFace2D? polygonalFace2D = polygonalFace2D_1 as PolygonalFace2D ?? polygonalFace2D_1.ToNTS()?.ToDiGi();
                return polygonalFace2D == null ? null : new DifferenceResult2D(polygonalFace2D);
            }

            Polygon? polygon_1 = polygonalFace2D_1.ToNTS();
            if (polygon_1 == null)
            {
                return null;
            }

            Polygon? polygon_2 = polygonalFace2D_2.ToNTS();
            if (polygon_2 == null)
            {
                return null;
            }

            // Repair invalid inputs before any topological operation
            NetTopologySuite.Geometries.Geometry geometry_1 = polygon_1;
            if (!geometry_1.IsValid)
            {
                geometry_1 = GeometryFixer.Fix(geometry_1);
            }

            NetTopologySuite.Geometries.Geometry geometry_2 = polygon_2;
            if (!geometry_2.IsValid)
            {
                geometry_2 = GeometryFixer.Fix(geometry_2);
            }

            if (geometry_1 == null || geometry_2 == null)
            {
                return null;
            }

            // Degenerate (zero-area) first face: it collapses to its boundary linework, so the difference is lower-dimensional
            if (geometry_1.IsEmpty)
            {
                NetTopologySuite.Geometries.Geometry? geometry_LowerDimensional;
                try
                {
                    // Unary union nodes and dissolves the duplicate linework of collapsed rings
                    NetTopologySuite.Geometries.Geometry geometry_Boundary = polygon_1.Boundary.Union();
                    geometry_LowerDimensional = geometry_2.IsEmpty ? geometry_Boundary : geometry_Boundary.Difference(geometry_2);
                }
                catch
                {
                    return null;
                }

                return new DifferenceResult2D(geometry_LowerDimensional.ToDiGi_Geometry2Ds(), false);
            }

            // Degenerate (zero-area) second face removes nothing
            if (geometry_2.IsEmpty)
            {
                return new DifferenceResult2D(geometry_1.ToDiGi_Geometry2Ds(), false);
            }

            bool equal;
            try
            {
                equal = geometry_1.EqualsTopologically(geometry_2);
            }
            catch
            {
                equal = false;
            }

            if (equal)
            {
                return new DifferenceResult2D();
            }

            NetTopologySuite.Geometries.Geometry? geometry;
            try
            {
                geometry = geometry_1.Difference(geometry_2);
            }
            catch
            {
                return null;
            }

            if (geometry == null || geometry.IsEmpty)
            {
                return new DifferenceResult2D();
            }

            return new DifferenceResult2D(geometry.ToDiGi_Geometry2Ds(), false);
        }
    }
}

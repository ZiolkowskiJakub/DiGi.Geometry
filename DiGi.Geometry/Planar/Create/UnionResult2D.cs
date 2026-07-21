using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        /// <summary>
        /// Calculates the 2D boolean union between two polygonal faces.
        /// </summary>
        /// <remarks>
        /// <para>Invalid (self-intersecting) inputs are repaired before the overlay is computed. Disjoint inputs produce a result containing both faces.</para>
        /// </remarks>
        /// <param name="polygonalFace2D_1">The first polygonal face.</param>
        /// <param name="polygonalFace2D_2">The second polygonal face.</param>
        /// <returns>A <see cref="Classes.UnionResult2D"/> containing the union geometry, or null if both inputs are null or the computation fails.</returns>
        public static UnionResult2D? UnionResult2D(this IPolygonalFace2D? polygonalFace2D_1, IPolygonalFace2D? polygonalFace2D_2)
        {
            if (polygonalFace2D_1 == null && polygonalFace2D_2 == null)
            {
                return null;
            }

            if (polygonalFace2D_1 == null || polygonalFace2D_2 == null)
            {
                IPolygonalFace2D polygonalFace2D_Single = polygonalFace2D_1 ?? polygonalFace2D_2!;
                PolygonalFace2D? polygonalFace2D = polygonalFace2D_Single as PolygonalFace2D ?? polygonalFace2D_Single.ToNTS()?.ToDiGi();
                return polygonalFace2D == null ? null : new UnionResult2D(polygonalFace2D);
            }

            // Early-out Axis-Aligned Bounding Box (AABB) intersection check
            BoundingBox2D? boundingBox2D_1 = polygonalFace2D_1.GetBoundingBox();
            BoundingBox2D? boundingBox2D_2 = polygonalFace2D_2.GetBoundingBox();
            if (boundingBox2D_1 != null && boundingBox2D_2 != null && !boundingBox2D_1.InRange(boundingBox2D_2))
            {
                // Disjoint union consists of both faces
                List<IGeometry2D> geometry2Ds_Disjoint = [];

                PolygonalFace2D? polygonalFace2D_Temp = polygonalFace2D_1 as PolygonalFace2D ?? polygonalFace2D_1.ToNTS()?.ToDiGi();
                if (polygonalFace2D_Temp != null)
                {
                    geometry2Ds_Disjoint.Add(polygonalFace2D_Temp);
                }

                polygonalFace2D_Temp = polygonalFace2D_2 as PolygonalFace2D ?? polygonalFace2D_2.ToNTS()?.ToDiGi();
                if (polygonalFace2D_Temp != null)
                {
                    geometry2Ds_Disjoint.Add(polygonalFace2D_Temp);
                }

                return new UnionResult2D(geometry2Ds_Disjoint);
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

            // Query.Union repairs invalid inputs and performs the unary union
            List<Polygon>? polygons = Query.Union([polygon_1, polygon_2]);
            if (polygons == null)
            {
                return null;
            }

            List<IGeometry2D> geometry2Ds = new(polygons.Count);
            for (int i = 0; i < polygons.Count; i++)
            {
                PolygonalFace2D? polygonalFace2D = polygons[i]?.ToDiGi();
                if (polygonalFace2D == null)
                {
                    continue;
                }

                geometry2Ds.Add(polygonalFace2D);
            }

            return new UnionResult2D(geometry2Ds, false);
        }
    }
}
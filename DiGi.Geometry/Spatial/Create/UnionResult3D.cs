using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        /// <summary>
        /// Calculates the 3D boolean union between two polyhedra defined by TPolygonalFace3D faces.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The boundary of the union polyhedron <c>A U B</c> is composed of:
        /// <list type="bullet">
        /// <item>Faces of A that lie outside the volume of B.</item>
        /// <item>Faces of B that lie outside the volume of A.</item>
        /// </list>
        /// </para>
        /// <para>
        /// If the remaining boundary pieces do not form a closed solid volume (less than 4 faces, or non-closed shell),
        /// the method falls back to returning the individual <see cref="Classes.PolygonalFace3D"/> elements representing the
        /// remaining boundary surfaces.
        /// </para>
        /// </remarks>
        /// <typeparam name="TPolygonalFace3D">The type of polygonal face, which must implement <see cref="IPolygonalFace3D"/>.</typeparam>
        /// <param name="polyhedron_1">The first polyhedron.</param>
        /// <param name="polyhedron_2">The second polyhedron.</param>
        /// <param name="tolerance">The distance tolerance for boolean union computations.</param>
        /// <returns>A <see cref="Classes.UnionResult3D"/> containing the union geometry (either a Polyhedron, multiple disjoint Polyhedrons, or individual face/segment elements), or null if both inputs are null.</returns>
        public static UnionResult3D? UnionResult3D<TPolygonalFace3D>(
            this Polyhedron<TPolygonalFace3D>? polyhedron_1,
            Polyhedron<TPolygonalFace3D>? polyhedron_2,
            double tolerance = DiGi.Core.Constants.Tolerance.Distance)
            where TPolygonalFace3D : IPolygonalFace3D
        {
            if (polyhedron_1 == null && polyhedron_2 == null)
            {
                return null;
            }

            if (polyhedron_1 == null)
            {
                return new UnionResult3D(polyhedron_2);
            }

            if (polyhedron_2 == null)
            {
                return new UnionResult3D(polyhedron_1);
            }

            // Early-out Axis-Aligned Bounding Box (AABB) intersection check
            BoundingBox3D? boundingBox3D_1 = polyhedron_1.GetBoundingBox();
            BoundingBox3D? boundingBox3D_2 = polyhedron_2.GetBoundingBox();
            if (boundingBox3D_1 == null || boundingBox3D_2 == null || !boundingBox3D_1.InRange(boundingBox3D_2, tolerance))
            {
                // Disjoint union consists of both disjoint solid volumes
                return new UnionResult3D(new IGeometry3D[] { polyhedron_1, polyhedron_2 });
            }

            List<IPolygonalFace3D> polygonalFace3Ds_1 = PolygonalFace3Ds(polyhedron_1);
            List<IPolygonalFace3D> polygonalFace3Ds_2 = PolygonalFace3Ds(polyhedron_2);

            if (polygonalFace3Ds_1.Count == 0 && polygonalFace3Ds_2.Count == 0)
            {
                return new UnionResult3D();
            }

            if (polygonalFace3Ds_1.Count == 0)
            {
                return new UnionResult3D(polyhedron_2);
            }

            if (polygonalFace3Ds_2.Count == 0)
            {
                return new UnionResult3D(polyhedron_1);
            }

            List<IPolygonalFace3D> polygonalFace3Ds_Unique = BooleanOperationPolygonalFace3Ds(BooleanOpertaionType.Union, polyhedron_1, polyhedron_2, polygonalFace3Ds_1, polygonalFace3Ds_2, out BVHNode _, tolerance);

            // Solid union volume if valid, individual boundary faces as fallback for non-solid remnants
            List<IGeometry3D>? geometry3Ds = BooleanOperationGeometry3Ds(polygonalFace3Ds_Unique);

            return geometry3Ds == null ? new UnionResult3D() : new UnionResult3D(geometry3Ds);
        }
    }
}

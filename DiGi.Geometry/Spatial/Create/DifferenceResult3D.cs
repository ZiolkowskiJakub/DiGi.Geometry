using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        /// <summary>
        /// Calculates the 3D boolean difference between two polyhedra defined by TPolygonalFace3D faces.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The boundary of the difference polyhedron <c>A \ B</c> is composed of:
        /// <list type="bullet">
        /// <item>Faces of A that lie outside the volume of B.</item>
        /// <item>Faces of B that lie inside the volume of A, with their orientations inverted (normals flipped)
        /// to face outward from the resulting solid difference volume.</item>
        /// </list>
        /// </para>
        /// <para>
        /// If the remaining boundary pieces do not form a closed solid volume (less than 4 faces, or non-closed shell),
        /// the method falls back to returning the individual <see cref="Classes.PolygonalFace3D"/> elements representing the
        /// remaining boundary surfaces.
        /// </para>
        /// </remarks>
        /// <typeparam name="TPolygonalFace3D">The type of polygonal face, which must implement <see cref="IPolygonalFace3D"/>.</typeparam>
        /// <param name="polyhedron_1">The first polyhedron (from which to subtract).</param>
        /// <param name="polyhedron_2">The second polyhedron (to subtract).</param>
        /// <param name="tolerance">The distance tolerance for boolean difference computations.</param>
        /// <returns>A <see cref="Classes.DifferenceResult3D"/> containing the difference geometry (either a Polyhedron or individual face/segment elements), or null if polyhedron_1 is null.</returns>
        public static DifferenceResult3D? DifferenceResult3D<TPolygonalFace3D>(
            this Polyhedron<TPolygonalFace3D>? polyhedron_1,
            Polyhedron<TPolygonalFace3D>? polyhedron_2,
            double tolerance = DiGi.Core.Constants.Tolerance.Distance)
            where TPolygonalFace3D : IPolygonalFace3D
        {
            if (polyhedron_1 == null)
            {
                return null;
            }

            if (polyhedron_2 == null)
            {
                return new DifferenceResult3D(polyhedron_1);
            }

            // Early-out Axis-Aligned Bounding Box (AABB) intersection check
            BoundingBox3D? boundingBox3D_1 = polyhedron_1.GetBoundingBox();
            BoundingBox3D? boundingBox3D_2 = polyhedron_2.GetBoundingBox();
            if (boundingBox3D_1 == null || boundingBox3D_2 == null || !boundingBox3D_1.InRange(boundingBox3D_2, tolerance))
            {
                return new DifferenceResult3D(polyhedron_1);
            }

            List<IPolygonalFace3D> polygonalFace3Ds_1 = PolygonalFace3Ds(polyhedron_1);
            if (polygonalFace3Ds_1.Count == 0)
            {
                return new DifferenceResult3D();
            }

            List<IPolygonalFace3D> polygonalFace3Ds_2 = PolygonalFace3Ds(polyhedron_2);
            if (polygonalFace3Ds_2.Count == 0)
            {
                return new DifferenceResult3D(polyhedron_1);
            }

            List<IPolygonalFace3D> polygonalFace3Ds_Unique = BooleanOperationPolygonalFace3Ds(BooleanOpertaionType.Difference, polyhedron_1, polyhedron_2, polygonalFace3Ds_1, polygonalFace3Ds_2, out BVHNode _, tolerance);

            // Solid difference volume if valid, individual boundary faces as fallback for non-solid remnants
            List<IGeometry3D>? geometry3Ds = BooleanOperationGeometry3Ds(polygonalFace3Ds_Unique);

            return geometry3Ds == null ? new DifferenceResult3D() : new DifferenceResult3D(geometry3Ds);
        }
    }
}
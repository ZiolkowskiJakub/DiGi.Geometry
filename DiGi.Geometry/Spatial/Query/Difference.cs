using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the 3D boolean difference between two polyhedra.
        /// </summary>
        /// <remarks>
        /// The computation is delegated to <see cref="Create.DifferenceResult3D{TPolygonalFace3D}(Polyhedron{TPolygonalFace3D}?, Polyhedron{TPolygonalFace3D}?, double)"/>; only the polyhedra of the result are returned. Use the result object directly to access lower-dimensional geometry elements.
        /// </remarks>
        /// <typeparam name="TPolygonalFace3D">The type of polygonal face, which must implement <see cref="IPolygonalFace3D"/>.</typeparam>
        /// <param name="polyhedron_1">The first polyhedron (from which to subtract).</param>
        /// <param name="polyhedron_2">The second polyhedron (to subtract).</param>
        /// <param name="tolerance">The distance tolerance for boolean difference computations.</param>
        /// <returns>A list of <see cref="Polyhedron"/> objects representing the resulting difference, or <c>null</c> if either input is null.</returns>
        public static List<Polyhedron>? Difference<TPolygonalFace3D>(this Polyhedron<TPolygonalFace3D>? polyhedron_1, Polyhedron<TPolygonalFace3D>? polyhedron_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance) where TPolygonalFace3D : IPolygonalFace3D
        {
            if (polyhedron_1 == null || polyhedron_2 == null)
            {
                return null;
            }

            DifferenceResult3D? differenceResult3D = Create.DifferenceResult3D(polyhedron_1, polyhedron_2, tolerance);
            if (differenceResult3D == null)
            {
                return null;
            }

            return differenceResult3D.GetGeometry3Ds<Polyhedron>() ?? [];
        }
    }
}

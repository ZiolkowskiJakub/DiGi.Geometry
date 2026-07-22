using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the 3D boolean intersection between two polyhedra.
        /// </summary>
        /// <remarks>
        /// The computation is delegated to <see cref="Create.IntersectionResult3D{TPolygonalFace3D}(Polyhedron{TPolygonalFace3D}?, Polyhedron{TPolygonalFace3D}?, double)"/>; only the polyhedra of the result are returned. Use the result object directly to access lower-dimensional geometry elements.
        /// </remarks>
        /// <typeparam name="TPolygonalFace3D">The type of polygonal face, which must implement <see cref="IPolygonalFace3D"/>.</typeparam>
        /// <param name="polyhedron_1">The first polyhedron to intersect.</param>
        /// <param name="polyhedron_2">The second polyhedron to intersect.</param>
        /// <param name="tolerance">The distance tolerance for boolean intersection computations.</param>
        /// <returns>A list of <see cref="Polyhedron"/> objects representing the resulting intersection, or <c>null</c> if either input is null.</returns>
        public static List<Polyhedron>? Intersection<TPolygonalFace3D>(this Polyhedron<TPolygonalFace3D>? polyhedron_1, Polyhedron<TPolygonalFace3D>? polyhedron_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance) where TPolygonalFace3D : IPolygonalFace3D
        {
            if (polyhedron_1 == null || polyhedron_2 == null)
            {
                return null;
            }

            IntersectionResult3D? intersectionResult3D = Create.IntersectionResult3D(polyhedron_1, polyhedron_2, tolerance);
            if (intersectionResult3D == null)
            {
                return null;
            }

            return intersectionResult3D.GetGeometry3Ds<Polyhedron>() ?? [];
        }
    }
}
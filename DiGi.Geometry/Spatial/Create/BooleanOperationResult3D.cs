using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System;

namespace DiGi.Geometry.Spatial
{
    public static partial class Create
    {
        /// <summary>
        /// Calculates the 3D boolean operation result between two polyhedra based on the specified operation type.
        /// </summary>
        /// <typeparam name="TPolygonalFace3D">The type of polygonal face, which must implement <see cref="IPolygonalFace3D"/>.</typeparam>
        /// <param name="booleanOpertaionType">The type of the boolean operation.</param>
        /// <param name="polyhedron_1">The first polyhedron.</param>
        /// <param name="polyhedron_2">The second polyhedron.</param>
        /// <param name="tolerance">The distance tolerance for the boolean computations.</param>
        /// <returns>A <see cref="Classes.BooleanOperationResult3D"/> containing the result of the operation, or null if the operation type is not supported.</returns>
        public static BooleanOperationResult3D? BooleanOperationResult3D<TPolygonalFace3D>(
            this BooleanOpertaionType booleanOpertaionType,  
            Polyhedron<TPolygonalFace3D>? polyhedron_1, 
            Polyhedron<TPolygonalFace3D>? polyhedron_2, 
            double tolerance = DiGi.Core.Constants.Tolerance.Distance) 
            where TPolygonalFace3D : IPolygonalFace3D
        {
            switch (booleanOpertaionType)
            {
                case BooleanOpertaionType.Intersection:
                    return IntersectionResult3D(polyhedron_1, polyhedron_2, tolerance);
                case BooleanOpertaionType.Difference:
                    return DifferenceResult3D(polyhedron_1, polyhedron_2, tolerance);
                case BooleanOpertaionType.Union:
                    return UnionResult3D(polyhedron_1, polyhedron_2, tolerance);
                default:
                    return null;
            }
        }
    }
}

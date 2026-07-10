using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        /// <summary>
        /// Calculates the 2D boolean operation result between two polygonal faces based on the specified operation type.
        /// </summary>
        /// <param name="booleanOpertaionType">The type of the boolean operation.</param>
        /// <param name="polygonalFace2D_1">The first polygonal face.</param>
        /// <param name="polygonalFace2D_2">The second polygonal face.</param>
        /// <returns>A <see cref="Classes.BooleanOperationResult2D"/> containing the result of the operation, or null if the operation type is not supported.</returns>
        public static BooleanOperationResult2D? BooleanOperationResult2D(this BooleanOpertaionType booleanOpertaionType, IPolygonalFace2D? polygonalFace2D_1, IPolygonalFace2D? polygonalFace2D_2)
        {
            switch (booleanOpertaionType)
            {
                case BooleanOpertaionType.Intersection:
                    return IntersectionResult2D(polygonalFace2D_1, polygonalFace2D_2);
                case BooleanOpertaionType.Difference:
                    return DifferenceResult2D(polygonalFace2D_1, polygonalFace2D_2);
                case BooleanOpertaionType.Union:
                    return UnionResult2D(polygonalFace2D_1, polygonalFace2D_2);
                default:
                    return null;
            }
        }
    }
}

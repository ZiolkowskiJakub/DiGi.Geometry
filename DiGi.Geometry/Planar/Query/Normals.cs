using DiGi.Geometry.Core;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the normal vectors for each segment of the specified polygonal object based on the provided side.
        /// </summary>
        /// <param name="polygonal2D">The <see cref="IPolygonal2D"/> instance to calculate normals for.</param>
        /// <param name="side">The <see cref="Core.Enums.Side"/> specifying whether the external or internal normal vectors should be calculated.</param>
        /// <returns>A <see cref="List{Vector2D?}"/> containing the normal vectors, or <c>null</c> if the <see cref="IPolygonal2D"/> is null, contains invalid segments, or has a collinear or undefined orientation.</returns>
        public static List<Vector2D?>? Normals(this IPolygonal2D? polygonal2D, Core.Enums.Side side = Core.Enums.Side.External)
        {
            if (polygonal2D?.GetSegments() is not List<Segment2D> segment2Ds)
            {
                return null;
            }

            Core.Enums.Orientation orientation = polygonal2D.Orientation();
            if (orientation == Core.Enums.Orientation.Collinear || orientation == Core.Enums.Orientation.Undefined)
            {
                return null;
            }

            if (side == Core.Enums.Side.External)
            {
                orientation = orientation.Opposite();
            }

            List<Vector2D?> result = [];
            foreach (Segment2D segment2D in segment2Ds)
            {
                result.Add(segment2D?.Direction?.GetPerpendicular(orientation));
            }

            return result;
        }
    }
}
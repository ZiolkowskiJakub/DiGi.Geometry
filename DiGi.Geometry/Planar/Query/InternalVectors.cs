using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static List<Vector2D?>? InternalVectors(this IPolygon2D? polygonal2D)
        {
            if (polygonal2D == null)
            {
                return null;
            }

            List<Segment2D>? segment2Ds = polygonal2D.GetSegments();
            if (segment2Ds is null)
            {
                return null;
            }

            Core.Enums.Orientation orientation = polygonal2D.Orientation();
            if (orientation == Core.Enums.Orientation.Undefined || orientation == Core.Enums.Orientation.Collinear)
            {
                return null;
            }

            List<Vector2D?> result = [];
            foreach (Segment2D segment2D in segment2Ds)
            {
                Vector2D? vector2D = segment2D?.Vector?.GetPerpendicular(orientation);
                result.Add(vector2D?.Unit);
            }

            return result;
        }
    }
}

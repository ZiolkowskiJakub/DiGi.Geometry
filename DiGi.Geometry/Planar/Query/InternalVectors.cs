using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static List<Vector2D> InternalVectors(this Polygon2D polygon2D)
        {
            if (polygon2D == null)
            {
                return null;
            }

            Core.Enums.Orientation orientation = polygon2D.Orientation();
            if (orientation == Core.Enums.Orientation.Undefined || orientation == Core.Enums.Orientation.Collinear)
            {
                return null;
            }

            List<Vector2D> result = new List<Vector2D>();
            foreach (Segment2D segment2D in polygon2D.GetSegments())
            {
                Vector2D vector2D = segment2D.Vector.GetPerpendicular(orientation);
                result.Add(vector2D?.Unit);
            }

            return result;
        }
    }
}

using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;
using DiGi.Geometry.Planar.Interfaces;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        public static BoundingBox2D BoundingBox2D<T>(this IEnumerable<T> segmentable2Ds, double offset = 0) where T : ISegmentable2D
        {
            List<Point2D> point2Ds = segmentable2Ds?.Points();
            if (point2Ds == null || point2Ds.Count == 0)
            {
                return null;
            }

            BoundingBox2D result = new BoundingBox2D(point2Ds);
            if (offset != 0)
            {
                result.Offset(offset);
            }

            return result;
        }

        public static BoundingBox2D BoundingBox2D(this Point2D point2D, double width, double height, Core.Enums.Corner corner)
        {
            if(double.IsNaN(width) || double.IsNaN(height) || point2D == null)
            {
                return null;
            }

            Query.Directions(corner, out Vector2D heightDirection, out Vector2D widthDirection);

            if(heightDirection == null || widthDirection == null)
            {
                return null;
            }

            Point2D point2D_Temp = point2D.GetMoved(heightDirection).GetMoved(widthDirection);

            return new BoundingBox2D(point2D, point2D_Temp);
        }

        public static BoundingBox2D BoundingBox2D(this Point2D center, double width, double height)
        {
            if (double.IsNaN(width) || double.IsNaN(height) || center == null)
            {
                return null;
            }

            Vector2D vector2D_Width = Constans.Vector2D.WorldX * width / 2;
            Vector2D vector2D_Height = Constans.Vector2D.WorldY * height / 2;

            Point2D point2D_1 = center.GetMoved(vector2D_Width).GetMoved(vector2D_Height);
            Point2D point2D_2 = center.GetMoved(vector2D_Width.GetInversed()).GetMoved(vector2D_Height.GetInversed());

            return new BoundingBox2D(point2D_1, point2D_2);
        }
    }

}

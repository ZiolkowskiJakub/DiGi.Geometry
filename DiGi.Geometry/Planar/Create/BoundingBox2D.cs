using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        public static BoundingBox2D BoundingBox2D<T>(this IEnumerable<T> boundable2Ds, double offset = 0) where T : IBoundable2D
        {
            if(boundable2Ds == null)
            {
                return null;
            }

            BoundingBox2D result = null;
            foreach (T boundable2D in boundable2Ds)
            {
                BoundingBox2D boundingBox2D = boundable2D?.GetBoundingBox();
                if(boundingBox2D == null)
                {
                    continue;
                }

                if(result == null)
                {
                    result = boundingBox2D;
                    continue;
                }

                result.Add(boundingBox2D);
            }

            if (result != null && offset != 0)
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

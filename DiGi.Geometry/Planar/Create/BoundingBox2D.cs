using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a bounding box that encompasses all provided boundable geometries.
        /// </summary>
        /// <typeparam name="T">A type that implements IBoundable2D.</typeparam>
        /// <param name="boundable2Ds">The collection of boundable geometries.</param>
        /// <param name="offset">An optional offset to apply to the resulting bounding box.</param>
        /// <returns>A BoundingBox2D that encompasses all inputs; otherwise, null if input is null.</returns>
        public static BoundingBox2D? BoundingBox2D<T>(this IEnumerable<T>? boundable2Ds, double offset = 0) where T : IBoundable2D
        {
            if (boundable2Ds == null)
            {
                return null;
            }

            BoundingBox2D? result = null;
            foreach (T boundable2D in boundable2Ds)
            {
                BoundingBox2D? boundingBox2D = boundable2D?.GetBoundingBox();
                if (boundingBox2D == null)
                {
                    continue;
                }

                if (result == null)
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

        /// <summary>
        /// Creates a bounding box with specified width and height, using the point as a corner.
        /// </summary>
        /// <param name="point2D">The anchor point.</param>
        /// <param name="width">The width of the bounding box.</param>
        /// <param name="height">The height of the bounding box.</param>
        /// <param name="corner">The corner that the specified point represents.</param>
        /// <returns>A new BoundingBox2D; otherwise, null if any input is invalid.</returns>
        public static BoundingBox2D? BoundingBox2D(this Point2D? point2D, double width, double height, Core.Enums.Corner corner)
        {
            if (double.IsNaN(width) || double.IsNaN(height) || point2D == null)
            {
                return null;
            }

            Query.Directions(corner, out Vector2D? heightDirection, out Vector2D? widthDirection);

            if (heightDirection == null || widthDirection == null)
            {
                return null;
            }

            Point2D? point2D_Temp = point2D.GetMoved(heightDirection)?.GetMoved(widthDirection);

            return new(point2D, point2D_Temp);
        }

        /// <summary>
        /// Creates a bounding box with specified width and height, centered at the given point.
        /// </summary>
        /// <param name="center">The center point of the bounding box.</param>
        /// <param name="width">The width of the bounding box.</param>
        /// <param name="height">The height of the bounding box.</param>
        /// <returns>A new BoundingBox2D; otherwise, null if any input is invalid.</returns>
        public static BoundingBox2D? BoundingBox2D(this Point2D? center, double width, double height)
        {
            if (double.IsNaN(width) || double.IsNaN(height) || center == null)
            {
                return null;
            }

            Vector2D? vector2D_Width = Constants.Vector2D.WorldX * width / 2;
            Vector2D? vector2D_Height = Constants.Vector2D.WorldY * height / 2;

            Point2D? point2D_1 = center.GetMoved(vector2D_Width)?.GetMoved(vector2D_Height);
            Point2D? point2D_2 = center.GetMoved(vector2D_Width?.GetInversed())?.GetMoved(vector2D_Height?.GetInversed());

            return new(point2D_1, point2D_2);
        }
    }
}
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Offsets the specified <see cref="Polygon2D"/> by a given distance.
        /// </summary>
        /// <param name="polygon2D">The <see cref="Polygon2D"/> to offset. Can be null.</param>
        /// <param name="offset">The double value representing the offset distance. Positive values expand the polygon, while negative values shrink it.</param>
        /// <returns>A <see cref="List{Polygon2D}"/> containing the resulting offset polygons, or null if the input <see cref="Polygon2D"/> is null.</returns>
        public static List<Polygon2D>? Offset(this Polygon2D? polygon2D, double offset)
        {
            if (polygon2D == null)
            {
                return null;
            }

            NetTopologySuite.Operation.Buffer.BufferParameters bufferParameters = new()
            {
                JoinStyle = NetTopologySuite.Operation.Buffer.JoinStyle.Mitre,
                EndCapStyle = NetTopologySuite.Operation.Buffer.EndCapStyle.Square,
            };

            return polygon2D.Offset(offset, bufferParameters);
        }

        /// <summary>
        /// Offsets the radius of the specified <see cref="Circle2D"/> by a given amount.
        /// </summary>
        /// <param name="circle2D">The <see cref="Circle2D"/> instance to offset.</param>
        /// <param name="offset">The <see cref="double"/> value to add to the radius of the circle.</param>
        /// <returns>A new <see cref="Circle2D"/> with the adjusted radius, or <c>null</c> if the input <see cref="Circle2D"/> is <c>null</c>, its center is <c>null</c>, or its radius is <see cref="double.NaN"/>.</returns>
        public static Circle2D? Offset(this Circle2D? circle2D, double offset)
        {
            if (circle2D == null)
            {
                return null;
            }

            Point2D? center = circle2D.Center;
            if (center == null)
            {
                return null;
            }

            double radius = circle2D.Radius;
            if (double.IsNaN(radius))
            {
                return null;
            }

            radius += offset;
            if (radius <= 0)
            {
                return null;
            }

            return new(center, radius);
        }

        /// <summary>
        /// Offsets the specified <see cref="Rectangle2D"/> by a given value.
        /// </summary>
        /// <param name="rectangle2D">The <see cref="Rectangle2D"/> to offset.</param>
        /// <param name="offset">The double value used to offset the rectangle's origin and dimensions.</param>
        /// <returns>A new <see cref="Rectangle2D"/> that is offset by the specified value, or null if the input rectangle or its properties are invalid.</returns>
        public static Rectangle2D? Offset(this Rectangle2D? rectangle2D, double offset)
        {
            if (rectangle2D?.Origin is not Point2D origin || rectangle2D.HeightDirection is not Vector2D heightDirection || rectangle2D.WidthDirection is not Vector2D widthDirection)
            {
                return null;
            }

            Vector2D? vector2D = (heightDirection.GetInversed() + widthDirection.GetInversed()) * offset;
            origin?.Move(vector2D);

            double width = rectangle2D.Width;
            double height = rectangle2D.Height;

            width += 2 * offset;
            height += 2 * offset;

            return new(origin, width, height, heightDirection);
        }

        /// <summary>
        /// Offsets the specified <see cref="Triangle2D"/> by a given distance.
        /// </summary>
        /// <param name="triangle2D">The <see cref="Triangle2D"/> instance to offset.</param>
        /// <param name="offset">The double value representing the offset distance.</param>
        /// <returns>A new <see cref="Triangle2D"/> resulting from the offset operation, or null if the input is null or the result cannot be formed into a triangle.</returns>
        public static Triangle2D? Offset(this Triangle2D? triangle2D, double offset)
        {
            if (triangle2D == null)
            {
                return null;
            }

            List<Polygon2D>? polygon2Ds = ((Polygon2D)triangle2D).Offset(offset);
            if (polygon2Ds == null || polygon2Ds.Count < 1)
            {
                return null;
            }

            List<Point2D>? point2Ds = polygon2Ds[0]?.GetPoints();
            if (point2Ds == null || point2Ds.Count < 3)
            {
                return null;
            }

            return new(point2Ds[0], point2Ds[1], point2Ds[2]);
        }

        /// <summary>
        /// Offsets the specified <see cref="IPolygonal2D"/> by a given distance.
        /// </summary>
        /// <param name="polygonal2D">The <see cref="IPolygonal2D"/> instance to offset.</param>
        /// <param name="offset">The double value representing the offset distance.</param>
        /// <returns>A <see cref="List{IPolygonal2D}"/> containing the resulting offset polygonal shapes, or null if the input is null or no result is produced.</returns>
        public static List<IPolygonal2D>? Offset(this IPolygonal2D? polygonal2D, double offset)
        {
            if (polygonal2D == null)
            {
                return null;
            }

            if (polygonal2D is Rectangle2D rectangle2D)
            {
                IPolygonal2D? polygonal2D_Temp = rectangle2D.Offset(offset);
                return polygonal2D_Temp != null ? [polygonal2D_Temp] : null;
            }

            if (polygonal2D is Triangle2D triangle2D)
            {
                IPolygonal2D? polygonal2D_Temp = triangle2D.Offset(offset);
                return polygonal2D_Temp != null ? [polygonal2D_Temp] : null;
            }

            if (polygonal2D is Polygon2D polygon2D)
            {
                List<Polygon2D>? polygon2Ds = polygon2D.Offset(offset);
                if (polygon2Ds != null)
                {
                    List<IPolygonal2D> result = [];
                    for (int i = 0; i < polygon2Ds.Count; i++)
                    {
                        if (polygon2Ds[i] is IPolygonal2D polygonal2D_Temp)
                        {
                            result.Add(polygonal2D_Temp);
                        }
                    }

                    return result;
                }
            }

            return null;
        }

        /// <summary>
        /// Offsets the specified <see cref="Polygon2D"/>.
        /// </summary>
        /// <param name="polygon2D">The <see cref="Polygon2D"/> to be offset.</param>
        /// <param name="offset">The distance by which to offset the polygon. A positive <see cref="double"/> value expands the polygon, while a negative <see cref="double"/> value contracts it.</param>
        /// <param name="bufferParameters">The <see cref="NetTopologySuite.Operation.Buffer.BufferParameters"/> used to configure the buffering operation.</param>
        /// <returns>A <see cref="List{Polygon2D}"/> containing the resulting offset polygons, or <see langword="null"/> if the input <see cref="Polygon2D"/> is <see langword="null"/> or the <see cref="double"/> offset value is <see cref="double.NaN"/>.</returns>
        public static List<Polygon2D>? Offset(this Polygon2D? polygon2D, double offset, NetTopologySuite.Operation.Buffer.BufferParameters bufferParameters)
        {
            if (polygon2D == null || double.IsNaN(offset))
            {
                return null;
            }

            if (offset == 0)
            {
                if (DiGi.Core.Query.Clone(polygon2D) is Polygon2D polygon2D_Clone)
                {
                    return [polygon2D_Clone];
                }

                return null;
            }

            Polygon? polygon = polygon2D.ToNTS_Polygon();
            if (polygon == null)
            {
                return null;
            }

            NetTopologySuite.Geometries.Geometry? geometry = polygon.Buffer(offset, bufferParameters);
            if (geometry == null)
            {
                return null;
            }

            List<Polygon2D> result = [];

            if (geometry is Polygon polygon2D_Temp)
            {
                List<Polygon2D>? polygon2Ds = polygon2D_Temp.ToDiGi_Polygon2Ds();
                if (polygon2Ds != null)
                {
                    result.AddRange(polygon2Ds);
                }
            }
            else if (geometry is MultiPolygon multiPolygon)
            {
                foreach (NetTopologySuite.Geometries.Geometry geometry_NTS in multiPolygon)
                {
                    if (geometry_NTS is not Polygon polygon_Temp_Temp)
                    {
                        continue;
                    }

                    List<Polygon2D>? polygon2Ds = polygon_Temp_Temp.ToDiGi_Polygon2Ds();
                    if (polygon2Ds != null)
                    {
                        result.AddRange(polygon2Ds);
                    }
                }
            }

            return result;
        }
    }
}
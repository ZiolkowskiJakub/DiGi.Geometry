using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static List<Polygon2D>? Offset(this Polygon2D? polygon2D, double offset)
        {
            if(polygon2D == null)
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

        public static Circle2D? Offset(this Circle2D? circle2D, double offset)
        {
            if(circle2D == null)
            {
                return null;
            }

            Point2D? center = circle2D.Center;
            if(center == null)
            {
                return null;
            }

            double radius = circle2D.Radius;
            if(double.IsNaN(radius))
            {
                return null;
            }

            radius += offset;
            if(radius <= 0)
            {
                return null;
            }

            return new (center, radius);
        }

        public static Rectangle2D? Offset(this Rectangle2D? rectangle2D, double offset)
        {
            if(rectangle2D?.Origin is not Point2D origin || rectangle2D.HeightDirection is not Vector2D heightDirection || rectangle2D.WidthDirection is not Vector2D widthDirection)
            {
                return null;
            }

            Vector2D? vector2D = (heightDirection.GetInversed() + widthDirection.GetInversed()) * offset;
            origin?.Move(vector2D);

            double width = rectangle2D.Width;
            double height = rectangle2D.Height;

            width += 2 * offset;
            height += 2 * offset;

            return new (origin, width, height, heightDirection);
        }

        public static Triangle2D? Offset(this Triangle2D? triangle2D, double offset)
        {
            if(triangle2D == null)
            {
                return null;
            }

            List<Polygon2D>? polygon2Ds = ((Polygon2D)triangle2D).Offset(offset);
            if(polygon2Ds == null || polygon2Ds.Count < 1)
            {
                return null;
            }

            List<Point2D>? point2Ds = polygon2Ds[0]?.GetPoints();
            if(point2Ds == null || point2Ds.Count < 3)
            {
                return null;
            }

            return new (point2Ds[0], point2Ds[1], point2Ds[2]);
        }

        public static List<IPolygonal2D>? Offset(this IPolygonal2D? polygonal2D, double offset)
        {
            if(polygonal2D == null)
            {
                return null;
            }

            if(polygonal2D is Rectangle2D rectangle2D)
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
                if(polygon2Ds != null)
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

        public static List<Polygon2D>? Offset(this Polygon2D? polygon2D, double offset, NetTopologySuite.Operation.Buffer.BufferParameters bufferParameters)
        {
            if(polygon2D == null || double.IsNaN(offset))
            {
                return null;
            }

            if(offset == 0)
            {
                if(DiGi.Core.Query.Clone(polygon2D) is Polygon2D polygon2D_Clone)
                {
                    return [polygon2D_Clone];
                }

                return null;
            }

            Polygon? polygon = polygon2D.ToNTS_Polygon();
            if(polygon == null)
            {
                return null;
            }

            NetTopologySuite.Geometries.Geometry? geometry = polygon.Buffer(offset, bufferParameters);
            if(geometry == null)
            {
                return null;
            }

            List<Polygon2D> result = [];

            if(geometry is Polygon polygon2D_Temp)
            {
                List<Polygon2D>? polygon2Ds = polygon2D_Temp.ToDiGi_Polygon2Ds();
                if(polygon2Ds != null)
                {
                    result.AddRange(polygon2Ds);
                }
            }
            else if (geometry is MultiPolygon multiPolygon)
            {
                foreach(NetTopologySuite.Geometries.Geometry geometry_NTS in multiPolygon)
                {
                    if(geometry_NTS is not Polygon polygon_Temp_Temp)
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

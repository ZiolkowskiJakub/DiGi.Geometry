using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static List<Polygon2D> Offset(this Polygon2D polygon2D, double offset)
        {
            if(polygon2D == null)
            {
                return null;
            }

            NetTopologySuite.Operation.Buffer.BufferParameters bufferParameters = new NetTopologySuite.Operation.Buffer.BufferParameters()
            {
                JoinStyle = NetTopologySuite.Operation.Buffer.JoinStyle.Mitre,
                EndCapStyle = NetTopologySuite.Operation.Buffer.EndCapStyle.Square,
            };

            return polygon2D.Offset(offset, bufferParameters);
        }

        public static Circle2D Offset(this Circle2D circle2D, double offset)
        {
            if(circle2D == null)
            {
                return null;
            }

            Point2D center = circle2D.Center;
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

            return new Circle2D(center, radius);
        }

        public static Rectangle2D Offset(this Rectangle2D rectangle2D, double offset)
        {
            if(rectangle2D == null)
            {
                return null;
            }

            Point2D origin = rectangle2D.Origin;
            Vector2D heightDirection = rectangle2D.HeightDirection;

            Vector2D vector2D = (heightDirection + rectangle2D.WidthDirection) * offset;
            origin.Move(vector2D);

            double width = rectangle2D.Width;
            double height = rectangle2D.Height;

            width += 2 * offset;
            height += 2 * offset;

            return new Rectangle2D(origin, width, height, heightDirection);
        }

        public static Triangle2D Offset(this Triangle2D triangle2D, double offset)
        {
            if(triangle2D == null)
            {
                return null;
            }

            List<Polygon2D> polygon2Ds = ((Polygon2D)triangle2D).Offset(offset);
            if(polygon2Ds == null || polygon2Ds.Count < 1)
            {
                return null;
            }

            List<Point2D> point2Ds = polygon2Ds[0]?.GetPoints();
            if(point2Ds == null || point2Ds.Count < 3)
            {
                return null;
            }

            return new Triangle2D(point2Ds[0], point2Ds[1], point2Ds[2]);
        }

        public static List<IPolygonal2D> Offset(this IPolygonal2D polygonal2D, double offset)
        {
            if(polygonal2D == null)
            {
                return null;
            }

            if(polygonal2D is Rectangle2D)
            {
                IPolygonal2D polygonal2D_Temp = ((Rectangle2D)(object)polygonal2D).Offset(offset);
                return polygonal2D_Temp != null ? new List<IPolygonal2D> { polygonal2D_Temp } : null;
            }

            if (polygonal2D is Triangle2D)
            {
                IPolygonal2D polygonal2D_Temp = ((Triangle2D)(object)polygonal2D).Offset(offset);
                return polygonal2D_Temp != null ? new List<IPolygonal2D> { polygonal2D_Temp } : null;
            }

            if (polygonal2D is Polygon2D)
            {
                List<Polygon2D> polygon2Ds = ((Polygon2D)(object)polygonal2D).Offset(offset);
                if(polygon2Ds != null)
                {
                    List<IPolygonal2D> result = new List<IPolygonal2D>();
                    for (int i = 0; i < polygon2Ds.Count; i++)
                    {
                        if (polygon2Ds[i] is IPolygonal2D)
                        {
                            result.Add((IPolygonal2D)(object)(polygon2Ds[i]));
                        }
                    }

                    return result;
                }
            }

            return null;
        }

        public static List<Polygon2D> Offset(this Polygon2D polygon2D, double offset, NetTopologySuite.Operation.Buffer.BufferParameters bufferParameters)
        {
            if(polygon2D == null || double.IsNaN(offset))
            {
                return null;
            }

            if(offset == 0)
            {
                return new List<Polygon2D> { DiGi.Core.Query.Clone(polygon2D) };
            }

            Polygon polygon = polygon2D.ToNTS_Polygon();
            if(polygon == null)
            {
                return null;
            }

            NetTopologySuite.Geometries.Geometry geometry = polygon.Buffer(offset, bufferParameters);
            if(geometry == null)
            {
                return null;
            }

            List<Polygon2D> result = new List<Polygon2D>();

            if(geometry is Polygon)
            {
                List<Polygon2D> polygon2Ds = ((Polygon)geometry).ToDiGi_Polygon2Ds();
                if(polygon2Ds != null)
                {
                    result.AddRange(polygon2Ds);
                }
            }
            else if (geometry is MultiPolygon)
            {
                foreach(Polygon polygon_Temp in (MultiPolygon)geometry)
                {
                    List<Polygon2D> polygon2Ds = polygon_Temp.ToDiGi_Polygon2Ds();
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

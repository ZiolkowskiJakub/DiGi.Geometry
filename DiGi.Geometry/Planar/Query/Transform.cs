using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static Point2D Transform(this Point2D point2D, Func<Point2D, Point2D> func)
        {
            if(point2D == null || func == null)
            {
                return null;
            }

            return func(point2D);
        }

        public static List<Point2D> Transform(this IEnumerable<Point2D> point2Ds, Func<Point2D, Point2D> func)
        {
            if(point2Ds == null || func == null)
            {
                return null;
            }

            List<Point2D> result = new List<Point2D>();
            foreach(Point2D point2D in point2Ds)
            {
                result.Add(func(point2D));
            }

            return result;
        }

        public static Segment2D Transform(this Segment2D segment2D, Func<Point2D, Point2D> func)
        {
            if(segment2D  == null || func == null)
            {
                return null;
            }

            Point2D point2D_1 = Transform(segment2D[0], func);
            if(point2D_1 == null)
            {
                return null;
            }

            Point2D point2D_2 = Transform(segment2D[1], func);
            if (point2D_2 == null)
            {
                return null;
            }

            return new Segment2D(point2D_1, point2D_2);
        }

        public static BoundingBox2D Transform(this BoundingBox2D boundingBox2D, Func<Point2D, Point2D> func)
        {
            if (boundingBox2D == null || func == null)
            {
                return null;
            }

            Point2D point2D_Min = Transform(boundingBox2D.Min, func);
            if (point2D_Min == null)
            {
                return null;
            }

            Point2D point2D__Max = Transform(boundingBox2D.Max, func);
            if (point2D__Max == null)
            {
                return null;
            }

            return new BoundingBox2D(point2D_Min, point2D__Max);
        }

        public static Polygon2D Transform(this Polygon2D polygon2D, Func<Point2D, Point2D> func)
        {
            if (polygon2D == null || func == null)
            {
                return null;
            }

            List<Point2D> point2Ds = Transform(polygon2D.GetPoints(), func);
            if(point2Ds == null || point2Ds.Count == 0)
            {
                return null;
            }

            return new Polygon2D(point2Ds);
        }

        public static Polyline2D Transform(this Polyline2D polyline2D, Func<Point2D, Point2D> func)
        {
            if (polyline2D == null || func == null)
            {
                return null;
            }

            List<Point2D> point2Ds = Transform(polyline2D.GetPoints(), func);
            if (point2Ds == null || point2Ds.Count == 0)
            {
                return null;
            }

            return new Polyline2D(point2Ds);
        }

        public static Triangle2D Transform(this Triangle2D triangle2D, Func<Point2D, Point2D> func)
        {
            if (triangle2D == null || func == null)
            {
                return null;
            }

            List<Point2D> point2Ds = Transform(triangle2D.GetPoints(), func);
            if (point2Ds == null || point2Ds.Count == 0)
            {
                return null;
            }

            return new Triangle2D(point2Ds);
        }

        public static PolygonalFace2D Transform(this PolygonalFace2D polygonalFace2D, Func<Point2D, Point2D> func, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(polygonalFace2D == null || func == null)
            {
                return null;
            }

            IPolygonal2D externalEdge = polygonalFace2D.ExternalEdge;
            if(externalEdge == null)
            {
                return null;
            }

            externalEdge = Create.Polygonal2D(Transform(externalEdge.GetPoints(), func), tolerance);
            if(externalEdge == null)
            {
                return null;
            }

            List<IPolygonal2D> internalEdges = polygonalFace2D.InternalEdges;
            if(internalEdges != null)
            {
                int count = internalEdges.Count;

                for(int i =count -1; i >= 0; i--)
                {
                    IPolygonal2D internalEdge = Create.Polygonal2D(Transform(internalEdges[i].GetPoints(), func), tolerance);
                    if (internalEdge == null)
                    {
                        internalEdges.RemoveAt(i);
                        continue;
                    }

                    internalEdges[i] = internalEdge;
                }
            }

            return Create.PolygonalFace2D(externalEdge, internalEdges, tolerance);
           
        }

        public static IPolygonal2D Transform(this IPolygonal2D polygonal2D, Func<Point2D, Point2D> func, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (polygonal2D == null || func == null)
            {
                return null;
            }

            return Create.Polygonal2D(Transform(polygonal2D.GetPoints(), func), tolerance);
        }
    }
}

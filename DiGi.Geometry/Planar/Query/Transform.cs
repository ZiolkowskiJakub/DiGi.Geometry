using DiGi.Core;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Transforms a point by applying the specified transformation function.
        /// </summary>
        /// <param name="point2D">The <see cref="Point2D"/> point to transform.</param>
        /// <param name="func">The transformation function used to map the <see cref="Point2D"/> to a new position.</param>
        /// <returns>The transformed <see cref="Point2D"/> point, or <see langword="null"/> if the input point or transformation function is null.</returns>
        public static Point2D? Transform(this Point2D? point2D, Func<Point2D?, Point2D?>? func)
        {
            if (point2D == null || func == null)
            {
                return null;
            }

            return func(point2D);
        }

        /// <summary>
        /// Transforms a collection of points by applying the specified transformation function to each point.
        /// </summary>
        /// <param name="point2Ds">The collection of <see cref="Point2D"/> points to transform.</param>
        /// <param name="func">The transformation function used to map each <see cref="Point2D"/> to a new position.</param>
        /// <returns>A list containing the transformed <see cref="Point2D"/> points, or <see langword="null"/> if the input collection or transformation function is null.</returns>
        public static List<Point2D?>? Transform(this IEnumerable<Point2D>? point2Ds, Func<Point2D?, Point2D?>? func)
        {
            if (point2Ds == null || func == null)
            {
                return null;
            }

            List<Point2D?> result = [];
            foreach (Point2D? point2D in point2Ds)
            {
                result.Add(func(point2D));
            }

            return result;
        }

        /// <summary>
        /// Transforms a segment by applying the specified transformation function to its start and end points.
        /// </summary>
        /// <param name="segment2D">The segment to transform.</param>
        /// <param name="func">The transformation function used to map each <see cref="Point2D"/> to a new position.</param>
        /// <returns>A new <see cref="Segment2D"/> representing the transformed segment, or <see langword="null"/> if the input segment or function is null, or if the transformation fails to produce valid points.</returns>
        public static Segment2D? Transform(this Segment2D? segment2D, Func<Point2D?, Point2D?>? func)
        {
            if (segment2D == null || func == null)
            {
                return null;
            }

            Point2D? point2D_1 = Transform(segment2D.Start, func);
            if (point2D_1 == null)
            {
                return null;
            }

            Point2D? point2D_2 = Transform(segment2D.End, func);
            if (point2D_2 == null)
            {
                return null;
            }

            return new Segment2D(point2D_1, point2D_2);
        }

        /// <summary>
        /// Transforms a bounding box by applying the specified transformation function to its minimum and maximum points.
        /// </summary>
        /// <param name="boundingBox2D">The bounding box to transform.</param>
        /// <param name="func">The transformation function used to map each <see cref="Point2D"/> to a new position.</param>
        /// <returns>A new <see cref="BoundingBox2D"/> representing the transformed bounding box, or <see langword="null"/> if the input bounding box or function is null, or if the transformation fails to produce valid points.</returns>
        public static BoundingBox2D? Transform(this BoundingBox2D? boundingBox2D, Func<Point2D?, Point2D?>? func)
        {
            if (boundingBox2D == null || func == null)
            {
                return null;
            }

            Point2D? point2D_Min = Transform(boundingBox2D.Min, func);
            if (point2D_Min == null)
            {
                return null;
            }

            Point2D? point2D__Max = Transform(boundingBox2D.Max, func);
            if (point2D__Max == null)
            {
                return null;
            }

            return new BoundingBox2D(point2D_Min, point2D__Max);
        }

        /// <summary>
        /// Transforms a polygon by applying the specified transformation function to its vertices.
        /// </summary>
        /// <param name="polygon2D">The polygon to transform.</param>
        /// <param name="func">The transformation function used to map each <see cref="Point2D"/> to a new position.</param>
        /// <returns>A new <see cref="Polygon2D"/> representing the transformed polygon, or <see langword="null"/> if the input polygon or function is null, or if the transformation fails to produce a valid geometry.</returns>
        public static Polygon2D? Transform(this Polygon2D? polygon2D, Func<Point2D?, Point2D?>? func)
        {
            if (polygon2D == null || func == null)
            {
                return null;
            }

            List<Point2D>? point2Ds = Transform(polygon2D.GetPoints(), func)?.FilterNulls();
            if (point2Ds == null || point2Ds.Count == 0)
            {
                return null;
            }

            return new Polygon2D(point2Ds);
        }

        /// <summary>
        /// Transforms a polyline by applying the specified transformation function to its vertices.
        /// </summary>
        /// <param name="polyline2D">The polyline to transform.</param>
        /// <param name="func">The transformation function used to map each <see cref="Point2D"/> to a new position.</param>
        /// <returns>A new <see cref="Polyline2D"/> representing the transformed polyline, or <see langword="null"/> if the input polyline or function is null, or if the transformation fails to produce a valid geometry.</returns>
        public static Polyline2D? Transform(this Polyline2D? polyline2D, Func<Point2D?, Point2D?>? func)
        {
            if (polyline2D == null || func == null)
            {
                return null;
            }

            List<Point2D>? point2Ds = Transform(polyline2D.GetPoints(), func)?.FilterNulls();
            if (point2Ds == null || point2Ds.Count == 0)
            {
                return null;
            }

            return new Polyline2D(point2Ds);
        }

        /// <summary>
        /// Transforms a triangle by applying the specified transformation function to its vertices.
        /// </summary>
        /// <param name="triangle2D">The triangle to transform.</param>
        /// <param name="func">The transformation function used to map each <see cref="Point2D"/> to a new position.</param>
        /// <returns>A new <see cref="Triangle2D"/> representing the transformed triangle, or <see langword="null"/> if the input triangle or function is null, or if the transformation fails to produce a valid geometry.</returns>
        public static Triangle2D? Transform(this Triangle2D? triangle2D, Func<Point2D?, Point2D?>? func)
        {
            if (triangle2D == null || func == null)
            {
                return null;
            }

            List<Point2D>? point2Ds = Transform(triangle2D.GetPoints(), func)?.FilterNulls();
            if (point2Ds == null || point2Ds.Count == 0)
            {
                return null;
            }

            return new Triangle2D(point2Ds);
        }

        /// <summary>
        /// Transforms a polygonal face by applying the specified transformation function to its vertices.
        /// </summary>
        /// <param name="polygonalFace2D">The polygonal face to transform.</param>
        /// <param name="func">The transformation function used to map each <see cref="Point2D"/> to a new position.</param>
        /// <param name="tolerance">The distance tolerance used during the creation of the transformed polygonal edges.</param>
        /// <returns>A new <see cref="PolygonalFace2D"/> representing the transformed face, or <see langword="null"/> if the input face or function is null, or if the transformation fails to produce a valid geometry.</returns>
        public static PolygonalFace2D? Transform(this PolygonalFace2D? polygonalFace2D, Func<Point2D?, Point2D?>? func, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (polygonalFace2D == null || func == null)
            {
                return null;
            }

            IPolygonal2D? externalEdge = polygonalFace2D.ExternalEdge;
            if (externalEdge == null)
            {
                return null;
            }

            externalEdge = Create.Polygonal2D(Transform(externalEdge.GetPoints(), func)?.FilterNulls(), tolerance);
            if (externalEdge == null)
            {
                return null;
            }

            List<IPolygonal2D>? internalEdges = polygonalFace2D.InternalEdges;
            if (internalEdges != null)
            {
                int count = internalEdges.Count;

                for (int i = count - 1; i >= 0; i--)
                {
                    IPolygonal2D? internalEdge = Create.Polygonal2D(Transform(internalEdges[i].GetPoints(), func).FilterNulls(), tolerance);
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

        /// <summary>
        /// Transforms a polygonal geometry by applying the specified transformation function to its points.
        /// </summary>
        /// <param name="polygonal2D">The polygonal geometry to transform.</param>
        /// <param name="func">The function used to transform each <see cref="Point2D"/> of the polygonal geometry.</param>
        /// <param name="tolerance">The distance tolerance used when creating the resulting polygonal geometry.</param>
        /// <returns>A new transformed <see cref="IPolygonal2D"/> instance, or <c>null</c> if the input geometry or transformation function is <c>null</c>.</returns>
        public static IPolygonal2D? Transform(this IPolygonal2D? polygonal2D, Func<Point2D?, Point2D?>? func, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (polygonal2D == null || func == null)
            {
                return null;
            }

            return Create.Polygonal2D(Transform(polygonal2D.GetPoints(), func).FilterNulls(), tolerance);
        }
    }
}
using DiGi.Core;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a rectangle that bounds the given points along the specified direction.
        /// </summary>
        /// <param name="point2Ds">The collection of points to bound.</param>
        /// <param name="direction">The primary orientation vector for the rectangle's height.</param>
        /// <returns>A Rectangle2D that bounds the points; otherwise, null if inputs are invalid.</returns>
        public static Rectangle2D? Rectangle2D(this IEnumerable<Point2D>? point2Ds, Vector2D? direction)
        {
            if (point2Ds == null || direction == null || point2Ds.Count() < 2)
            {
                return null;
            }

            if (direction.Unit is not Vector2D direction_Height)
            {
                return null;
            }

            if (direction_Height.GetPerpendicular() is not Vector2D direction_Width)
            {
                return null;
            }

            double minHeight = double.MaxValue;
            double maxHeight = double.MinValue;
            double minWidth = double.MaxValue;
            double maxWidth = double.MinValue;

            foreach (Point2D point2D in point2Ds)
            {
                if ((Vector2D?)point2D is not Vector2D vector2D)
                {
                    continue;
                }

                double projHeight = vector2D.DotProduct(direction_Height);

                if (projHeight < minHeight)
                {
                    minHeight = projHeight;
                }

                if (projHeight > maxHeight)
                {
                    maxHeight = projHeight;
                }

                double projWidth = vector2D.DotProduct(direction_Width);

                if (projWidth < minWidth)
                {
                    minWidth = projWidth;
                }

                if (projWidth > maxWidth)
                {
                    maxWidth = projWidth;
                }
            }

            Vector2D? vector2D_Origin = direction_Height * minHeight + direction_Width * minWidth;
            if (vector2D_Origin is null)
            {
                return null;
            }

            return new Rectangle2D(new Point2D(vector2D_Origin.X, vector2D_Origin.Y), maxWidth - minWidth, maxHeight - minHeight, direction_Height);
        }

        /// <summary>
        /// Creates the minimum area bounding rectangle for a set of points.
        /// </summary>
        /// <param name="point2Ds">The collection of points.</param>
        /// <param name="tolerance">The distance tolerance for calculations.</param>
        /// <returns>The smallest Rectangle2D that contains all points; otherwise, null if too few points are provided.</returns>
        public static Rectangle2D? Rectangle2D(this IEnumerable<Point2D>? point2Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point2Ds == null || point2Ds.Count() <= 2)
            {
                return null;
            }

            List<Point2D>? point2Ds_ConvexHull = Query.ConvexHull(point2Ds);
            if (point2Ds_ConvexHull == null || point2Ds_ConvexHull.Count < 2)
            {
                return null;
            }

            double area = double.MaxValue;
            Rectangle2D? result = null;

            Vector2D vector2D = Constants.Vector2D.WorldY;

            HashSet<double> angleHashSet = [];
            for (int i = 0; i < point2Ds_ConvexHull.Count - 1; i++)
            {
                Vector2D direction = new(point2Ds_ConvexHull[i], point2Ds_ConvexHull[i + 1]);
                double angle = direction.Angle(vector2D);
                if (!angleHashSet.Contains(angle))
                {
                    angleHashSet.Add(angle);
                    Rectangle2D? rectangle_Temp = Rectangle2D(point2Ds_ConvexHull, direction);
                    if (rectangle_Temp == null)
                    {
                        continue;
                    }

                    double area_Temp = rectangle_Temp.GetArea();
                    if (DiGi.Core.Query.AlmostEquals(area_Temp, area, tolerance))
                    {
                        List<Point2D>? point2Ds_1 = result?.GetPoints();
                        List<Point2D>? point2Ds_2 = rectangle_Temp?.GetPoints();

                        int count_1 = point2Ds_1.Count(x => point2Ds_ConvexHull.Find(y => Query.AlmostEquals(y, x, tolerance)) != null);
                        int count_2 = point2Ds_2.Count(x => point2Ds_ConvexHull.Find(y => Query.AlmostEquals(y, x, tolerance)) != null);

                        if (count_2 > count_1)
                        {
                            area = area_Temp;
                            result = rectangle_Temp;
                        }
                    }
                    else if (area_Temp < area)
                    {
                        area = area_Temp;
                        result = rectangle_Temp;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Creates the minimum area bounding rectangle for a set of segmentable geometries.
        /// </summary>
        /// <param name="segmentable2Ds">The collection of segmentable geometries.</param>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>A Rectangle2D that bounds all points in the geometries; otherwise, null if no points are found.</returns>
        public static Rectangle2D? Rectangle2D(this IEnumerable<ISegmentable2D>? segmentable2Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            List<Point2D>? point2Ds = segmentable2Ds?.Points()?.FilterNulls();
            if (point2Ds is null)
            {
                return null;
            }

            return Rectangle2D(point2Ds, tolerance);
        }

        /// <summary>
        /// Creates the minimum area bounding rectangle for a single segmentable geometry.
        /// </summary>
        /// <param name="segmentable2D">The segmentable geometry.</param>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>A Rectangle2D that bounds the geometry; otherwise, null if points cannot be extracted.</returns>
        public static Rectangle2D? Rectangle2D(this ISegmentable2D? segmentable2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (segmentable2D is Rectangle2D rectangle2D)
            {
                return new Rectangle2D(rectangle2D);
            }

            return Rectangle2D(segmentable2D?.GetPoints(), tolerance);
        }

        /// <summary>
        /// Creates the minimum area bounding rectangle for a polygonal face's external edge.
        /// </summary>
        /// <param name="polygonalFace2D">The polygonal face.</param>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>A Rectangle2D that bounds the outer boundary; otherwise, null if no external edge exists.</returns>
        public static Rectangle2D? Rectangle2D(this IPolygonalFace2D? polygonalFace2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            IPolygonal2D? polygonal2D = polygonalFace2D?.ExternalEdge;
            if (polygonal2D == null)
            {
                return null;
            }

            return Rectangle2D(polygonal2D, tolerance);
        }

        /// <summary>
        /// Creates the minimum area bounding rectangle that encompasses two existing rectangles.
        /// </summary>
        /// <param name="rectangle2D_1">The first rectangle.</param>
        /// <param name="rectangle2D_2">The second rectangle.</param>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>A Rectangle2D that bounds both inputs; otherwise, null if either is null.</returns>
        public static Rectangle2D? Rectangle2D(this Rectangle2D? rectangle2D_1, Rectangle2D? rectangle2D_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (rectangle2D_1 == null || rectangle2D_2 == null)
            {
                return null;
            }

            List<Point2D>? point2Ds = rectangle2D_1.GetPoints();
            point2Ds?.AddRange(rectangle2D_2.GetPoints());

            return Rectangle2D(point2Ds, tolerance);
        }
    }
}
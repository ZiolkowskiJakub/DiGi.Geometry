using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Determines the orientation of three points (clockwise, counter-clockwise, or collinear).
        /// </summary>
        /// <param name="point2D_1">The first point.</param>
        /// <param name="point2D_2">The second point.</param>
        /// <param name="point2D_3">The third point.</param>
        /// <returns>The orientation of the triplet.</returns>
        public static Orientation Orientation(this Point2D? point2D_1, Point2D? point2D_2, Point2D? point2D_3)
        {
            double determinant = Determinant(point2D_1, point2D_2, point2D_3);
            if (double.IsNaN(determinant))
            {
                return Core.Enums.Orientation.Undefined;
            }

            if (determinant == 0)
            {
                return Core.Enums.Orientation.Collinear;
            }

            return determinant > 0 ? Core.Enums.Orientation.Clockwise : Core.Enums.Orientation.CounterClockwise;
        }

        /// <summary>
        /// Determines the orientation of two vectors (clockwise, counter-clockwise, or collinear).
        /// </summary>
        /// <param name="vector2D_1">The first vector.</param>
        /// <param name="vector2D_2">The second vector.</param>
        /// <returns>The orientation of the vectors.</returns>
        public static Orientation Orientation(this Vector2D? vector2D_1, Vector2D? vector2D_2)
        {
            double determinant = Determinant(vector2D_1, vector2D_2);

            if (determinant == 0)
            {
                return Core.Enums.Orientation.Collinear;
            }

            return determinant > 0 ? Core.Enums.Orientation.Clockwise : Core.Enums.Orientation.CounterClockwise;
        }

        /// <summary>
        /// Determines the overall orientation of a collection of points.
        /// </summary>
        /// <param name="point2Ds">The collection of points.</param>
        /// <param name="convexHull">Whether to use the convex hull for determination.</param>
        /// <returns>The orientation of the point set.</returns>
        public static Orientation Orientation(this IEnumerable<Point2D>? point2Ds, bool convexHull = true)
        {
            if (point2Ds == null || point2Ds.Count() < 3)
            {
                return Core.Enums.Orientation.Undefined;
            }

            List<Point2D>? point2Ds_Temp = convexHull && point2Ds.Count() > 3 ? ConvexHull(point2Ds, true) : [.. point2Ds];
            if (point2Ds_Temp == null || point2Ds_Temp.Count < 3)
            {
                return Core.Enums.Orientation.Undefined;
            }

            point2Ds_Temp.Add(point2Ds_Temp[0]);
            point2Ds_Temp.Add(point2Ds_Temp[1]);

            for (int i = 0; i < point2Ds_Temp.Count - 2; i++)
            {
                Orientation orientation = Orientation(point2Ds_Temp[i], point2Ds_Temp[i + 1], point2Ds_Temp[i + 2]);
                if (orientation != Core.Enums.Orientation.Collinear && orientation != Core.Enums.Orientation.Undefined)
                {
                    return orientation;
                }
            }

            return Core.Enums.Orientation.Undefined;
        }

        /// <summary>
        /// Determines the overall orientation of a polygonal geometry.
        /// </summary>
        /// <param name="polygonal2D">The polygonal geometry.</param>
        /// <param name="convexHull">Whether to use the convex hull for determination.</param>
        /// <returns>The orientation of the geometry.</returns>
        public static Orientation Orientation(this IPolygonal2D? polygonal2D, bool convexHull = true)
        {
            if (polygonal2D == null)
            {
                return Core.Enums.Orientation.Undefined;
            }

            List<Point2D>? point2Ds = polygonal2D?.GetPoints();
            if (point2Ds == null || point2Ds.Count < 3)
            {
                return Core.Enums.Orientation.Undefined;
            }

            return Orientation(point2Ds, convexHull);
        }
    }
}
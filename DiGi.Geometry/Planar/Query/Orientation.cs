﻿using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static Orientation Orientation(this Point2D point2D_1, Point2D point2D_2, Point2D point2D_3)
        {
            double determinant = Determinant(point2D_1, point2D_2, point2D_3);

            if (determinant == 0)
            {
                return Core.Enums.Orientation.Collinear;
            }

            return determinant > 0 ? Core.Enums.Orientation.Clockwise : Core.Enums.Orientation.CounterClockwise;
        }

        public static Orientation Orientation(this Vector2D vector2D_1, Vector2D vector2D_2)
        {
            double determinant = Determinant(vector2D_1, vector2D_2);

            if (determinant == 0)
            {
                return Core.Enums.Orientation.Collinear;
            }

            return determinant > 0 ? Core.Enums.Orientation.Clockwise : Core.Enums.Orientation.CounterClockwise;
        }

        public static Orientation Orientation(this IEnumerable<Point2D> point2Ds, bool convexHull = true)
        {
            if (point2Ds == null || point2Ds.Count() == 0)
            {
                return Core.Enums.Orientation.Undefined;
            }

            List<Point2D> point2Ds_Temp = new List<Point2D>(point2Ds);
            if (point2Ds_Temp == null || point2Ds_Temp.Count < 3)
            {
                return Core.Enums.Orientation.Undefined;
            }

            if (convexHull)
            {
                List<Point2D> point2Ds_ConvexHull = ConvexHull(point2Ds);

                //ConvexHull may have different orientation so needs to remove unnecessary points from existing point2Ds
                if (point2Ds_ConvexHull != null && point2Ds_ConvexHull.Count > 0)
                {
                    List<Point2D> point2Ds_ConvexHull_Temp = new List<Point2D>(point2Ds);
                    point2Ds_ConvexHull_Temp.RemoveAll(x => point2Ds_ConvexHull.Contains(x));
                    point2Ds_Temp.RemoveAll(x => point2Ds_ConvexHull_Temp.Contains(x));
                }
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

        public static Orientation Orientation(this IPolygonal2D polygonal2D)
        {
            if (polygonal2D == null)
            {
                return Core.Enums.Orientation.Undefined;
            }

            List<Point2D> point2Ds = polygonal2D?.GetPoints();
            if(point2Ds == null || point2Ds.Count < 3)
            {
                return Core.Enums.Orientation.Undefined;
            }

            return Orientation(point2Ds);
        }
    }
}

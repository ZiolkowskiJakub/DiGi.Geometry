﻿using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        public static List<Point2D> Point2Ds(this BoundingBox2D boundingBox2D, int count)
        {
            if (count == -1)
            {
                return null;
            }

            return Point2Ds(boundingBox2D.Min.X, boundingBox2D.Min.Y, boundingBox2D.Max.X, boundingBox2D.Max.Y, count);
        }

        public static List<Point2D> Point2Ds(double x_min, double y_min, double x_max, double y_max, int count)
        {
            if (count == -1)
            {
                return null;
            }

            System.Random random = new System.Random();

            List<Point2D> result = new List<Point2D>();
            for (int i = 0; i < count; i++)
            {
                double x = DiGi.Core.Query.Random(random, x_min, x_max);
                double y = DiGi.Core.Query.Random(random, y_min, y_max);

                result.Add(new Point2D(x, y));
            }

            return result;
        }

        public static List<Point2D> Point2Ds(params double[] values)
        {
            if (values == null)
            {
                return null;
            }

            int length = values.Length;
            if (length == 0 || length % 2 != 0)
            {
                return null;
            }

            List<Point2D> result = new List<Point2D>();
            for (int i = 0; i < length; i = i + 2)
            {
                result.Add(new Point2D(values[i], values[i + 1]));
            }

            return result;
        }
    }

}

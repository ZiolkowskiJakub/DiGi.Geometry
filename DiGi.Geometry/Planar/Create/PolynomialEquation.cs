﻿using DiGi.Geometry.Planar.Classes;
using DiGi.Math.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        public static PolynomialEquation PolynomialEquation(this IEnumerable<Point2D> point2Ds, int order = -1)
        {
            if (point2Ds == null || point2Ds.Count() < 2)
            {
                return null;
            }

            List<double> x = new List<double>();
            List<double> y = new List<double>();
            foreach (Point2D point2D in point2Ds)
            {
                x.Add(point2D.X);
                y.Add(point2D.Y);
            }

            return Math.Create.PolynomialEquation(x, y, order);
        }
    }

}

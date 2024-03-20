﻿using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        public static LinearRing ToNTS(this IPolygonal2D polygonal2D)
        {
            if(polygonal2D == null)
            {
                return null;
            }

            List<Point2D> point2Ds = polygonal2D.GetPoints();
            if(point2Ds == null || point2Ds.Count < 3)
            {
                return null;
            }

            List<Coordinate> cooridnates = point2Ds.ToNTS();
            if(cooridnates == null)
            {
                return null;
            }

            cooridnates.Add(cooridnates[0]);

            return new LinearRing(cooridnates.ToArray());
        }
    }
}

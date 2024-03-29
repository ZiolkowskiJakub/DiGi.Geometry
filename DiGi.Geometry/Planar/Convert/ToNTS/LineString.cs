﻿using DiGi.Geometry.Planar.Classes;
using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        public static LineString ToNTS(this Polyline2D polyline2D)
        {
            List<Coordinate> coordinates = polyline2D?.GetPoints()?.ToNTS();
            if(coordinates == null)
            {
                return null;
            }

            return new LineString(coordinates.ToArray());
        }

        public static LineString ToNTS_LineString(this Segment2D segment2D)
        {
            List<Coordinate> coordinates = segment2D?.GetPoints()?.ToNTS();
            if (coordinates == null)
            {
                return null;
            }

            return new LineString(coordinates.ToArray());
        }
    }
}

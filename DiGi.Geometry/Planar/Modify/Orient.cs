using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Modify
    {
        public static bool Orient(this IPolygonal2D polygonal2D, Orientation orientation)
        {
            if(polygonal2D == null || orientation == Orientation.Undefined || orientation == Orientation.Collinear)
            {
                return false;
            }

            Orientation orientation_Temp = polygonal2D.Orientation();
            if(orientation_Temp == orientation)
            {
                return false;
            }

            polygonal2D.Inverse();
            return true;
        }

        public static bool Orient(List<Point2D> point2Ds, Orientation orientation)
        {
            if (point2Ds == null || point2Ds.Count < 3 || orientation == Orientation.Collinear)
            {
                return false;
            }

            if (orientation == Orientation.Undefined)
            {
                return false;
            }

            List<Orientation> orienations = Query.Orientations(point2Ds);
            if (orienations.Count(x => x == orientation) > (orienations.Count / 2))
            {
                return false;
            }

            point2Ds.Reverse();

            return true;
        }
    }
}

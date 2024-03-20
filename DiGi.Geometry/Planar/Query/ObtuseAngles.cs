using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static List<bool> ObtuseAngles(this IPolygonal2D polygonal2D)
        {
            List<double> determinats = Determinants(polygonal2D);
            if (determinats == null)
            {
                return null;
            }

            List<bool> result = new List<bool>();

            if (determinats.Count == 0)
            {
                return result;
            }

            List<Point2D> point2Ds = polygonal2D.GetPoints();
            if (point2Ds == null)
            {
                return null;
            }

            if (point2Ds.Count != determinats.Count)
            {
                return null;
            }

            Orientation orientation = Orientation(point2Ds, true);

            switch (orientation)
            {
                case Core.Enums.Orientation.Clockwise:
                    return determinats.ConvertAll(x => x < 0);

                case Core.Enums.Orientation.CounterClockwise:
                    return determinats.ConvertAll(x => x > 0);
            }

            return null;
        }
    }
}

using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static List<double> Determinants(this IClosedSegmentable2D closedSegmentable2D)
        {
            return Determinants(closedSegmentable2D?.GetPoints());
        }

        public static List<double> Determinants(this IEnumerable<Point2D> point2Ds)
        {
            if (point2Ds == null || point2Ds.Count() < 3)
            {
                return null;
            }

            List<Point2D> point2Ds_Temp = new List<Point2D>(point2Ds);

            int index = point2Ds_Temp.Count - 1;

            point2Ds_Temp.Add(point2Ds_Temp[0]);
            point2Ds_Temp.Insert(0, point2Ds_Temp[index]);

            List<double> result = new List<double>();
            for (int i = 1; i < point2Ds_Temp.Count - 1; i++)
            {
                result.Add(Determinant(point2Ds_Temp[i - 1], point2Ds_Temp[i], point2Ds_Temp[i + 1]));
            }

            return result;
        }
    }
}

using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static Point2D InternalPoint(IEnumerable<Point2D> point2Ds, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point2Ds == null || point2Ds.Count() < 3)
            {
                return null;
            }

            Point2D result = Centroid(point2Ds);
            if(result == null)
            {
                return null;
            }

            List<Segment2D> segment2Ds = Create.Segment2Ds(point2Ds, true);
            if(segment2Ds == null)
            {
                return null;
            }

            if (Inside(point2Ds, result) && !On(segment2Ds, result, tolerance))
            {
                return result;
            }

            List<Point2D> point2Ds_List = new List<Point2D>(point2Ds);
            point2Ds_List.Add(point2Ds_List[0]);
            point2Ds_List.Add(point2Ds_List[1]);

            int count = point2Ds_List.Count;

            for (int i = 0; i < count - 2; i++)
            {
                for (int j = i + 1; j < count - 1; j++)
                {
                    for (int k = j + 1; k < count; k++)
                    {
                        Point2D point2D_1 = point2Ds_List[i];
                        Point2D point2D_2 = point2Ds_List[j];
                        Point2D point2D_3 = point2Ds_List[k];

                        Segment2D segment2D = new Segment2D(point2D_1, point2D_3);
                        if (segment2D.On(point2D_2, tolerance))
                        {
                            continue;
                        }

                        result = segment2D.Mid();
                        if (Inside(point2Ds, result) && !On(segment2Ds, result, tolerance))
                        {
                            return result;
                        }
                    }
                }
            }

            return null;
        }
    }
}

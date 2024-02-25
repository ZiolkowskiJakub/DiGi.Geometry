using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        public static List<Segment2D> Segment2Ds(this IEnumerable<Point2D> point2Ds, bool closed = false)
        {
            if(point2Ds == null)
            {
                return null;
            }

            int count = point2Ds.Count();

            List<Segment2D> result = new List<Segment2D>();

            if (count < 2)
            {
                return result;
            }

            for (int i = 1; i < count; i++)
            {
                Point2D point2D_1 = point2Ds.ElementAt(i - 1);
                if(point2D_1 == null)
                {
                    continue;
                }

                Point2D point2D_2 = point2Ds.ElementAt(i);
                if (point2D_2 == null)
                {
                    continue;
                }

                result.Add(new Segment2D(new Point2D(point2D_1), new Point2D(point2D_2)));
            }

            if(closed)
            {
                result.Add(new Segment2D(new Point2D(result[result.Count - 1][1]), new Point2D(result[0][0])));
            }

            return result;
        }
    }

}

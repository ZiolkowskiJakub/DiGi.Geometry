using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        public static BoundingBox2D BoundingBox2D<T>(this IEnumerable<T> segmentable2Ds, double offset = 0) where T: ISegmentable2D
        {
            List<Point2D> point2Ds = segmentable2Ds?.Points();
            if(point2Ds == null || point2Ds.Count == 0)
            {
                return null;
            }

            BoundingBox2D result = new BoundingBox2D(point2Ds);
            if(offset != 0)
            {
                result.Offset(offset);
            }

            return result;
        }
    }

}

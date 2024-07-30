using DiGi.Geometry.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Core
{
    public static partial class Query
    {
        public static List<T> PointsByDistance<T>(this IEnumerable<T> points, T point, double tolerance = DiGi.Core.Constans.Tolerance.Distance) where T : IPoint<T>
        {
            if(points == null || point == null)
            {
                return null;
            }

            List<T> result = new List<T>();
            foreach (T point_Temp in points)
            {
                if (point_Temp == null)
                {
                    continue;
                }

                if (point.Distance(point_Temp) <= tolerance)
                {
                    result.Add(point_Temp);
                }
            }
            return result;
        }
    }
}

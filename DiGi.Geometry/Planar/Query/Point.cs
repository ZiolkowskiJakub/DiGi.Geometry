using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates a point along a polyline defined by a collection of points, given a parameter (normalized length).
        /// </summary>
        /// <param name="point2Ds">The collection of points defining the polyline.</param>
        /// <param name="parameter">The normalized distance along the polyline.</param>
        /// <returns>The calculated point, or null if not possible.</returns>
        public static Point2D? Point(this IEnumerable<Point2D>? point2Ds, double parameter)
        {
            if (point2Ds == null || double.IsNaN(parameter))
            {
                return null;
            }

            Point2D[] point2Ds_Local = point2Ds as Point2D[] ?? point2Ds.ToArray();
            int count = point2Ds_Local.Length;
            if (count < 2)
            {
                return null;
            }

            List<double> lengths = new();
            double length = 0;
            for (int i = 1; i < count; i++)
            {
                Point2D point2D_1 = point2Ds_Local[i - 1];
                Point2D point2D_2 = point2Ds_Local[i];

                if (point2D_1 == null || point2D_2 == null)
                {
                    lengths.Add(0);
                    continue;
                }

                double distance = point2D_1.Distance(point2D_2);
                lengths.Add(distance);
                length += distance;
            }

            double value = length * parameter;

            Point2D? point2D_Result = null;

            int index = 0;
            while (value > 0)
            {
                double value_Temp = value - lengths[index];
                if (value_Temp > 0)
                {
                    value = value_Temp;
                    index++;
                    if (index >= lengths.Count)
                    {
                        index = 0;
                    }
                    continue;
                }

                Point2D point2D_1 = point2Ds_Local[index];
                Point2D point2D_2 = point2Ds_Local[index + 1];
                if (point2D_1 == null || point2D_2 == null)
                {
                    break;
                }

                Vector2D vector2D = new(point2D_1, point2D_2)
                {
                    Length = value
                };

                point2D_Result = new(point2D_1);
                point2D_Result.Move(vector2D);

                value = value_Temp;
            }

            return point2D_Result;
        }
    }
}
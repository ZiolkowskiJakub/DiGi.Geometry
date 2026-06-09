using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the determinants for the specified <see cref="IPolygonal2D"/> object.
        /// </summary>
        /// <param name="polygonal2D">The <see cref="IPolygonal2D"/> instance to process.</param>
        /// <returns>A <see cref="List{T}"/> of <see cref="double"/> values representing the determinants, or null if the input is null or contains fewer than three points.</returns>
        public static List<double>? Determinants(this IPolygonal2D? polygonal2D)
        {
            return Determinants(polygonal2D?.GetPoints());
        }

        /// <summary>
        /// Calculates the determinants for a sequence of <see cref="Point2D"/> objects by treating them as a closed loop.
        /// </summary>
/// <param name="point2Ds">The <c>IEnumerable&lt;Point2D&gt;</c> collection of points to process.</param>
/// <returns>A <c>List&lt;double&gt;</c> containing the calculated determinants, or null if the input is null or contains fewer than 3 <see cref="Point2D"/> elements.</returns>
        public static List<double>? Determinants(this IEnumerable<Point2D>? point2Ds)
        {
            if (point2Ds == null || point2Ds.Count() < 3)
            {
                return null;
            }

            List<Point2D> point2Ds_Temp = [.. point2Ds];

            int index = point2Ds_Temp.Count - 1;

            point2Ds_Temp.Add(point2Ds_Temp[0]);
            point2Ds_Temp.Insert(0, point2Ds_Temp[index]);

            List<double> result = [];
            for (int i = 1; i < point2Ds_Temp.Count - 1; i++)
            {
                result.Add(Determinant(point2Ds_Temp[i - 1], point2Ds_Temp[i], point2Ds_Temp[i + 1]));
            }

            return result;
        }
    }
}
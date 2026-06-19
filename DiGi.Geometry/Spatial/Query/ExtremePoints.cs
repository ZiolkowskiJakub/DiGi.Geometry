using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the two extreme points from a collection of nullable <see cref="Point3D"/> objects.
        /// </summary>
        /// <param name="point3Ds">The <see cref="IEnumerable{T}"/> of nullable <see cref="Point3D"/> objects to evaluate.</param>
        /// <param name="point3D_1">When this method returns, contains the first extreme <see cref="Point3D"/> found; otherwise, null.</param>
        /// <param name="point3D_2">When this method returns, contains the second extreme <see cref="Point3D"/> found; otherwise, null.</param>
        public static void ExtremePoints(this IEnumerable<Point3D?>? point3Ds, out Point3D? point3D_1, out Point3D? point3D_2)
        {
            ExtremePoints(point3Ds, out point3D_1, out point3D_2, out _);
        }

        /// <summary>
        /// Finds the two points within a collection that are furthest apart and calculates the distance between them.
        /// </summary>
        /// <param name="point3Ds">The <c>IEnumerable&lt;Point3D?&gt;</c> of <see cref="Point3D"/> objects to evaluate.</param>
        /// <param name="point3D_1">When this method returns, contains the first point of the pair with the maximum distance, or <see langword="null"/> if the collection is null or contains fewer than two points.</param>
        /// <param name="point3D_2">When this method returns, contains the second point of the pair with the maximum distance, or <see langword="null"/> if the collection is null or contains fewer than two points.</param>
        /// <param name="distance">When this method returns, contains the <see cref="double"/> value representing the distance between the two extreme points, or <see cref="double.NaN"/> if the collection is null or contains fewer than two points.</param>
        public static void ExtremePoints(this IEnumerable<Point3D?>? point3Ds, out Point3D? point3D_1, out Point3D? point3D_2, out double distance)
        {
            point3D_1 = null;
            point3D_2 = null;
            distance = double.NaN;

            if (point3Ds == null)
            {
                return;
            }

            int count = point3Ds.Count();

            if (count < 2)
            {
                return;
            }

            double distance_Max = double.MinValue;
            for (int i = 0; i < count - 1; i++)
            {
                Point3D? point3D_1_Temp = point3Ds.ElementAt(i);
                if (point3D_1_Temp is null)
                {
                    continue;
                }

                for (int j = i + 1; j < count; j++)
                {
                    Point3D? point3D_2_Temp = point3Ds.ElementAt(j);
                    if (point3D_2_Temp is null)
                    {
                        continue;
                    }

                    double distance_Temp = point3D_1_Temp.Distance(point3D_2_Temp);
                    if (distance_Max < distance_Temp)
                    {
                        point3D_1 = point3D_1_Temp;
                        point3D_2 = point3D_2_Temp;
                        distance_Max = distance_Temp;
                    }
                }
            }

            if (distance_Max != double.MinValue)
            {
                distance = distance_Max;
            }
        }
    }
}
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the centroid of a collection of <see cref="Point3D"/> points.
        /// </summary>
        /// <param name="point3Ds">An <c>IEnumerable&lt;Point3D&gt;</c> containing the points to process.</param>
        /// <returns>A <see cref="Point3D"/>? representing the centroid, or null if the input collection is null or empty.</returns>
        public static Point3D? Centroid(this IEnumerable<Point3D>? point3Ds)
        {
            if (point3Ds == null)
            {
                return null;
            }

            Point3D[] point3Ds_Local = point3Ds as Point3D[] ?? [.. point3Ds];
            int int_Count = point3Ds_Local.Length;
            if (int_Count == 0)
            {
                return null;
            }

            Point3D point3D_1 = point3Ds_Local[0];

            if (int_Count == 1)
            {
                return new(point3D_1);
            }

            Point3D point3D_2 = point3Ds_Local[1];

            if (int_Count == 2)
            {
                if (point3D_1 == null || point3D_2 == null)
                {
                    return null;
                }
                return new((point3D_1.X + point3D_2.X) / 2.0, (point3D_1.Y + point3D_2.Y) / 2.0, (point3D_1.Z + point3D_2.Z) / 2.0);
            }

            if (int_Count == 3)
            {
                Point3D point3D_3 = point3Ds_Local[2];
                if (point3D_1 == null || point3D_2 == null || point3D_3 == null)
                {
                    return null;
                }

                double double_CentroidX = (point3D_1.X + point3D_2.X + point3D_3.X) / 3.0;
                double double_CentroidY = (point3D_1.Y + point3D_2.Y + point3D_3.Y) / 3.0;
                double double_CentroidZ = (point3D_1.Z + point3D_2.Z + point3D_3.Z) / 3.0;

                return new(double_CentroidX, double_CentroidY, double_CentroidZ);
            }

            double double_SumX = 0.0;
            double double_SumY = 0.0;
            double double_SumZ = 0.0;
            double double_TotalArea = 0.0;

            if (point3D_1 == null || point3D_2 == null)
            {
                return null;
            }

            double double_X1 = point3D_1.X;
            double double_Y1 = point3D_1.Y;
            double double_Z1 = point3D_1.Z;

            double double_X2 = point3D_2.X;
            double double_Y2 = point3D_2.Y;
            double double_Z2 = point3D_2.Z;

            for (int int_I = 2; int_I < int_Count; int_I++)
            {
                Point3D point3D_3 = point3Ds_Local[int_I];
                if (point3D_3 == null)
                {
                    continue;
                }

                double double_X3 = point3D_3.X;
                double double_Y3 = point3D_3.Y;
                double double_Z3 = point3D_3.Z;

                double double_V1x = double_X3 - double_X1;
                double double_V1y = double_Y3 - double_Y1;
                double double_V1z = double_Z3 - double_Z1;

                double double_V2x = double_X3 - double_X2;
                double double_V2y = double_Y3 - double_Y2;
                double double_V2z = double_Z3 - double_Z2;

                double double_Cx = double_V1y * double_V2z - double_V1z * double_V2y;
                double double_Cy = double_V1z * double_V2x - double_V1x * double_V2z;
                double double_Cz = double_V1x * double_V2y - double_V1y * double_V2x;

                double double_LenSq = double_Cx * double_Cx + double_Cy * double_Cy + double_Cz * double_Cz;
                if (double_LenSq <= 0.0)
                {
                    continue;
                }

                double double_AreaTemp = System.Math.Sqrt(double_LenSq) / 2.0;

                double_SumX += double_AreaTemp * (double_X1 + double_X2 + double_X3) / 3.0;
                double_SumY += double_AreaTemp * (double_Y1 + double_Y2 + double_Y3) / 3.0;
                double_SumZ += double_AreaTemp * (double_Z1 + double_Z2 + double_Z3) / 3.0;

                double_TotalArea += double_AreaTemp;

                double_X2 = double_X3;
                double_Y2 = double_Y3;
                double_Z2 = double_Z3;
            }

            if (double_TotalArea == 0.0)
            {
                return null;
            }

            return new(double_SumX / double_TotalArea, double_SumY / double_TotalArea, double_SumZ / double_TotalArea);
        }
    }
}
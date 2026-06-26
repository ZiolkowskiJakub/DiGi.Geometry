using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geometry.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether three 3D points are collinear within a specified angular tolerance.
        /// </summary>
        /// <param name="point3D_1">The first <see cref="Point3D"/>? point.</param>
        /// <param name="point3D_2">The second <see cref="Point3D"/>? point, acting as the vertex for the angle calculation.</param>
        /// <param name="point3D_3">The third <see cref="Point3D"/>? point.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the angular tolerance used to determine collinearity.</param>
        /// <returns>A <see cref="bool"/> indicating whether the points are collinear; returns <c>false</c> if any of the provided points are null.</returns>
        public static bool Collinear(this Point3D? point3D_1, Point3D? point3D_2, Point3D? point3D_3, double tolerance = DiGi.Core.Constants.Tolerance.Angle)
        {
            if (point3D_1 == null || point3D_2 == null || point3D_3 == null)
            {
                return false;
            }

            double double_V1x = point3D_1.X - point3D_2.X;
            double double_V1y = point3D_1.Y - point3D_2.Y;
            double double_V1z = point3D_1.Z - point3D_2.Z;

            double double_V2x = point3D_3.X - point3D_2.X;
            double double_V2y = point3D_3.Y - point3D_2.Y;
            double double_V2z = point3D_3.Z - point3D_2.Z;

            double double_Dot = double_V1x * double_V2x + double_V1y * double_V2y + double_V1z * double_V2z;
            double double_Len1Sq = double_V1x * double_V1x + double_V1y * double_V1y + double_V1z * double_V1z;
            double double_Len2Sq = double_V2x * double_V2x + double_V2y * double_V2y + double_V2z * double_V2z;

            if (double_Len1Sq == 0.0 || double_Len2Sq == 0.0)
            {
                return true;
            }

            double double_CosTol = System.Math.Cos(tolerance);
            double double_CosTolSq = double_CosTol * double_CosTol;

            return double_Dot * double_Dot > double_CosTolSq * double_Len1Sq * double_Len2Sq;
        }

        /// <summary>
        /// Determines whether a collection of <see cref="Point3D"/> points are collinear within a specified tolerance.
        /// </summary>
        /// <param name="point3Ds">The <see cref="IEnumerable{T}"/> of <see cref="Point3D"/> objects to evaluate.</param>
        /// <param name="tolerance">The <see cref="double"/> value representing the distance tolerance for collinearity.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the points are collinear. Returns <see langword="true"/> if there are fewer than three points; otherwise, returns <see langword="false"/> if the collection is null or the points are not collinear.</returns>
        public static bool Collinear(this IEnumerable<Point3D>? point3Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point3Ds == null)
            {
                return false;
            }

            Point3D? point3D_A = null;
            Point3D? point3D_B = null;
            int int_NonNullCount = 0;
            double double_Abx = 0.0;
            double double_Aby = 0.0;
            double double_Abz = 0.0;
            double double_AbSq = 0.0;
            double double_TolSq = tolerance * tolerance;

            foreach (Point3D? point3D_C in point3Ds)
            {
                if (point3D_C == null)
                {
                    continue;
                }

                int_NonNullCount++;

                if (point3D_A == null)
                {
                    point3D_A = point3D_C;
                }
                else if (point3D_B == null)
                {
                    double double_Dx = point3D_C.X - point3D_A.X;
                    double double_Dy = point3D_C.Y - point3D_A.Y;
                    double double_Dz = point3D_C.Z - point3D_A.Z;
                    double double_DistSq = double_Dx * double_Dx + double_Dy * double_Dy + double_Dz * double_Dz;
                    if (double_DistSq > double_TolSq)
                    {
                        point3D_B = point3D_C;
                        double_Abx = double_Dx;
                        double_Aby = double_Dy;
                        double_Abz = double_Dz;
                        double_AbSq = double_DistSq;
                    }
                }
                else
                {
                    double double_Acx = point3D_C.X - point3D_A.X;
                    double double_Acy = point3D_C.Y - point3D_A.Y;
                    double double_Acz = point3D_C.Z - point3D_A.Z;

                    double double_CrossX = double_Aby * double_Acz - double_Abz * double_Acy;
                    double double_CrossY = double_Abz * double_Acx - double_Abx * double_Acz;
                    double double_CrossZ = double_Abx * double_Acy - double_Aby * double_Acx;

                    double double_CrossSq = double_CrossX * double_CrossX + double_CrossY * double_CrossY + double_CrossZ * double_CrossZ;
                    if (double_CrossSq > double_TolSq * double_AbSq)
                    {
                        return false;
                    }
                }
            }

            if (int_NonNullCount < 3)
            {
                return true;
            }

            return true;
        }
    }
}
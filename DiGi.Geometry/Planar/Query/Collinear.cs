using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether two <see cref="ILinear2D"/> objects are collinear within a specified tolerance.
        /// </summary>
        /// <param name="linear2D_1">The first <see cref="ILinear2D"/> object.</param>
        /// <param name="linear2D_2">The second <see cref="ILinear2D"/> object.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the tolerance for collinearity.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the two objects are collinear.</returns>
        public static bool Collinear(this ILinear2D? linear2D_1, ILinear2D? linear2D_2, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            Vector2D? direction_1 = linear2D_1?.Direction;
            if (direction_1 is null)
            {
                return false;
            }

            Vector2D? direction_2 = linear2D_2?.Direction;
            if (direction_2 is null)
            {
                return false;
            }

            return System.Math.Abs(System.Math.Abs(direction_1 * direction_2) - 1) <= tolerance;
        }

        /// <summary>
        /// Determines whether a collection of points are collinear within a specified tolerance.
        /// </summary>
        /// <param name="point2Ds">The <c>IEnumerable&lt;Point2D?&gt;</c> collection of points to evaluate.</param>
        /// <param name="tolerance">The <see cref="double"/> distance tolerance used to determine if the points lie on the same line.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the points are collinear; returns <c>false</c> if the input collection is null.</returns>
        public static bool Collinear(this IEnumerable<Point2D?>? point2Ds, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point2Ds == null)
            {
                return false;
            }

            Point2D? point2D_A = null;
            Point2D? point2D_B = null;
            int int_NonNullCount = 0;
            double double_Abx = 0.0;
            double double_Aby = 0.0;
            double double_AbSq = 0.0;
            double double_TolSq = tolerance * tolerance;

            foreach (Point2D? point2D_C in point2Ds)
            {
                if (point2D_C == null)
                {
                    continue;
                }

                int_NonNullCount++;

                if (point2D_A == null)
                {
                    point2D_A = point2D_C;
                }
                else if (point2D_B == null)
                {
                    double double_Dx = point2D_C.X - point2D_A.X;
                    double double_Dy = point2D_C.Y - point2D_A.Y;
                    double double_DistSq = double_Dx * double_Dx + double_Dy * double_Dy;
                    if (double_DistSq > double_TolSq)
                    {
                        point2D_B = point2D_C;
                        double_Abx = double_Dx;
                        double_Aby = double_Dy;
                        double_AbSq = double_DistSq;
                    }
                }
                else
                {
                    double double_Cross = double_Abx * (point2D_C.Y - point2D_A.Y) - double_Aby * (point2D_C.X - point2D_A.X);
                    if (double_Cross * double_Cross > double_TolSq * double_AbSq)
                    {
                        return false;
                    }
                }
            }

            if (int_NonNullCount < 2)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Determines whether three <see cref="Point2D"/> points are collinear within a specified tolerance.
        /// </summary>
        /// <param name="point2D_1">The first <see cref="Point2D"/> point.</param>
        /// <param name="point2D_2">The second <see cref="Point2D"/> point.</param>
        /// <param name="point2D_3">The third <see cref="Point2D"/> point.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value used to determine collinearity.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the points are collinear; returns false if any of the provided points are null.</returns>
        public static bool Collinear(this Point2D? point2D_1, Point2D? point2D_2, Point2D? point2D_3, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point2D_1 == null || point2D_2 == null || point2D_3 == null)
            {
                return false;
            }

            double double_Abx = point2D_2.X - point2D_1.X;
            double double_Aby = point2D_2.Y - point2D_1.Y;
            double double_AbSq = double_Abx * double_Abx + double_Aby * double_Aby;

            double double_Cross = double_Abx * (point2D_3.Y - point2D_1.Y) - double_Aby * (point2D_3.X - point2D_1.X);
            return double_Cross * double_Cross <= tolerance * tolerance * double_AbSq;
        }
    }
}
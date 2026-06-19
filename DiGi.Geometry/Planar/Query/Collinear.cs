using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Linq;

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

            List<Point2D> point2Ds_Temp = [];
            foreach (Point2D? point2D in point2Ds)
            {
                if (point2D == null)
                {
                    continue;
                }

                point2Ds_Temp.Add(point2D);
            }

            int count = point2Ds_Temp.Count();

            if (count < 2)
            {
                return false;
            }

            if (count == 2)
            {
                return true;
            }

            Vector2D? direction_1 = new Vector2D(point2Ds_Temp[0], point2Ds_Temp[1]).Unit;

            for (int i = 1; i < count - 1; i++)
            {
                Vector2D? direction_2 = new Vector2D(point2Ds_Temp[i], point2Ds_Temp[i + 1]).Unit;

                if (System.Math.Abs(System.Math.Abs(direction_1 * direction_2) - 1) > tolerance)
                {
                    return false;
                }
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

            return Collinear([point2D_1, point2D_2, point2D_3], tolerance);
        }
    }
}
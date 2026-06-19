using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Modify
    {
        /// <summary>
        /// Adds a <c>Point2D?</c> to the <c>List&lt;Point2D?&gt;?</c> if it is not null and does not already exist within the specified tolerance.
        /// </summary>
        /// <param name="point2Ds">The <c>List&lt;Point2D?&gt;?</c> to which the point will be added.</param>
        /// <param name="point2D">The <c>Point2D?</c> object to add to the list.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance used to determine if a point is a duplicate.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the point was successfully added to the list.</returns>
        public static bool Add(this List<Point2D?>? point2Ds, Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point2Ds == null || point2D == null)
            {
                return false;
            }

            foreach (Point2D? point2D_Temp in point2Ds)
            {
                if (point2D_Temp == null)
                {
                    continue;
                }

                if (System.Math.Abs(point2D_Temp.X - point2D.X) > tolerance)
                {
                    continue;
                }

                if (System.Math.Abs(point2D_Temp.Y - point2D.Y) > tolerance)
                {
                    continue;
                }

                if (point2D_Temp.Distance(point2D) <= tolerance)
                {
                    return false;
                }
            }

            point2Ds.Add(point2D);
            return true;
        }

        /// <summary>
        /// Adds a new <see cref="Point2D"/> to the specified list of nullable <see cref="Point2D"/> objects using the provided x and y coordinates.
        /// </summary>
        /// <param name="point2Ds">The <see cref="List{T}"/> of nullable <see cref="Point2D"/> objects to which the point will be added.</param>
        /// <param name="x">The double value for the X coordinate.</param>
        /// <param name="y">The double value for the Y coordinate.</param>
        /// <returns>A boolean value indicating whether the point was successfully added; returns false if the list is null.</returns>
        public static bool Add(this List<Point2D?>? point2Ds, double x, double y)
        {
            if (point2Ds == null)
            {
                return false;
            }

            point2Ds.Add(new Point2D(x, y));
            return true;
        }
    }
}
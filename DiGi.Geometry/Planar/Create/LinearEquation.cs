using DiGi.Geometry.Planar.Classes;
using DiGi.Math.Classes;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a linear equation from two points.
        /// </summary>
        /// <param name="point2D_1">The first point.</param>
        /// <param name="point2D_2">The second point.</param>
        /// <returns>A LinearEquation; otherwise, null if points are identical or either is null.</returns>
        public static LinearEquation? LinearEquation(this Point2D? point2D_1, Point2D? point2D_2)
        {
            if (point2D_1 == point2D_2 || point2D_1 is null || point2D_2 is null)
            {
                return null;
            }

            return Math.Create.LinearEquation(point2D_1.X, point2D_1.Y, point2D_2.X, point2D_2.Y);
        }

        /// <summary>
        /// Creates a linear equation from a segment.
        /// </summary>
        /// <param name="segment2D">The segment.</param>
        /// <returns>A LinearEquation; otherwise, null if the segment is null or has missing endpoints.</returns>
        public static LinearEquation? LinearEquation(this Segment2D? segment2D)
        {
            if (segment2D == null)
            {
                return null;
            }

            Point2D? point2D_1 = segment2D[0];
            if (point2D_1 == null)
            {
                return null;
            }

            Point2D? point2D_2 = segment2D[1];
            if (point2D_2 == null)
            {
                return null;
            }

            return LinearEquation(point2D_1, point2D_2);
        }

        /// <summary>
        /// Creates a linear equation from a line.
        /// </summary>
        /// <param name="line2D">The line.</param>
        /// <returns>A LinearEquation; otherwise, null if the line is null or has no origin.</returns>
        public static LinearEquation? LinearEquation(this Line2D? line2D)
        {
            if (line2D is null)
            {
                return null;
            }

            Point2D? point2D_1 = line2D.Origin;
            if (point2D_1 == null)
            {
                return null;
            }

            Point2D? point2D_2 = point2D_1.GetMoved(line2D.Direction);
            if (point2D_2 == null)
            {
                return null;
            }

            return LinearEquation(point2D_1, point2D_2);
        }
    }
}
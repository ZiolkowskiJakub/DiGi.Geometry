using System.Collections.Generic;

namespace DiGi.Geometry.Planar.Classes
{
    internal class ConvexHullComparer : IComparer<Point2D>
    {
        /// <summary>
        /// Compares two points for the purpose of calculating a convex hull.
        /// </summary>
        /// <param name="point2D_1">The first point to compare.</param>
        /// <param name="point2D_2">The second point to compare.</param>
        /// <returns>A value indicating the relative order of the two points.</returns>
        public int Compare(Point2D point2D_1, Point2D point2D_2)
        {
            if (point2D_1.X < point2D_2.X)
            {
                return -1;
            }
            else if (point2D_1.X > point2D_2.X)
            {
                return +1;
            }
            else if (point2D_1.Y < point2D_2.Y)
            {
                return -1;
            }
            else if (point2D_1.Y > point2D_2.Y)
            {
                return +1;
            }
            else
            {
                return 0;
            }
        }
    }
}
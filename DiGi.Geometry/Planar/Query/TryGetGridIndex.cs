using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether a point is a node of the grid anchored at <paramref name="origin"/>, and if it is, which node.
        /// <para>This is the counterpart of <see cref="Create.Point2Ds(BoundingBox2D, Point2D, double, double, double)"/>: every point that method produces is recognised here, and <paramref name="origin"/> plus the returned indexes times the grid size gives that point back.</para>
        /// <para>A point that is merely near a node is rejected rather than snapped to it. That distinction matters wherever grid nodes share a store with points of other origins - rounding without the check would report an arbitrary point as a node that was never generated, and a point of a coarser or finer grid as a node of this one.</para>
        /// </summary>
        /// <param name="point2D">The point to classify.</param>
        /// <param name="origin">The point the lattice is anchored at.</param>
        /// <param name="gridSize_X">The grid spacing along the X axis; has to be greater than zero.</param>
        /// <param name="gridSize_Y">The grid spacing along the Y axis; has to be greater than zero.</param>
        /// <param name="index_X">The number of steps along the X axis from the origin to the point; zero when the point is not a node.</param>
        /// <param name="index_Y">The number of steps along the Y axis from the origin to the point; zero when the point is not a node.</param>
        /// <param name="tolerance">The distance the point may lie from a node and still be counted as that node.</param>
        /// <returns>True when the point lies on a node of the lattice within the tolerance; otherwise false.</returns>
        public static bool TryGetGridIndex(
            this Point2D? point2D,
            Point2D? origin,
            double gridSize_X,
            double gridSize_Y,
            out int index_X,
            out int index_Y,
            double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            index_X = 0;
            index_Y = 0;

            if (point2D is null || origin is null || double.IsNaN(gridSize_X) || double.IsNaN(gridSize_Y) || gridSize_X <= 0 || gridSize_Y <= 0)
            {
                return false;
            }

            double index_X_Double = System.Math.Round((point2D.X - origin.X) / gridSize_X);
            double index_Y_Double = System.Math.Round((point2D.Y - origin.Y) / gridSize_Y);

            if (double.IsNaN(index_X_Double) || double.IsNaN(index_Y_Double) || index_X_Double < int.MinValue || index_X_Double > int.MaxValue || index_Y_Double < int.MinValue || index_Y_Double > int.MaxValue)
            {
                return false;
            }

            int index_X_Temp = System.Convert.ToInt32(index_X_Double);
            int index_Y_Temp = System.Convert.ToInt32(index_Y_Double);

            // The node is rebuilt the same way Create.Point2Ds builds it, so a point that method produced compares equal
            // outright and the tolerance only has to absorb coordinates that reached the caller by some other route.
            if (System.Math.Abs(point2D.X - (origin.X + (index_X_Temp * gridSize_X))) > tolerance)
            {
                return false;
            }

            if (System.Math.Abs(point2D.Y - (origin.Y + (index_Y_Temp * gridSize_Y))) > tolerance)
            {
                return false;
            }

            index_X = index_X_Temp;
            index_Y = index_Y_Temp;
            return true;
        }
    }
}

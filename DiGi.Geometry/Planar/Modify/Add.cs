using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace DiGi.Geometry.Planar
{
    public static partial class Modify
    {
        /// <summary>
        /// Caches a tolerance-bucketed spatial hash grid per <see cref="List{T}"/> instance so repeated <see cref="Add(List{Point2D}, Point2D, double)"/> / <see cref="FindNear(List{Point2D}, Point2D, double)"/> calls on the same list avoid an O(n) linear scan.
        /// </summary>
        private sealed class PointIndex2D
        {
            public int Count;
            public double Tolerance;
            public Dictionary<(long X, long Y), List<int>> IndexesByCell { get; } = [];
        }

        private static readonly ConditionalWeakTable<List<Point2D?>, PointIndex2D> pointIndex2Ds_ByList = new();

        private static (long X, long Y) GetCell(Point2D point2D_Cell, double tolerance)
        {
            return ((long)System.Math.Round(point2D_Cell.X / tolerance), (long)System.Math.Round(point2D_Cell.Y / tolerance));
        }

        private static void RegisterPoint(PointIndex2D pointIndex2D, int index_Point, Point2D point2D, double tolerance)
        {
            (long X, long Y) cell = GetCell(point2D, tolerance);
            if (!pointIndex2D.IndexesByCell.TryGetValue(cell, out List<int>? indexes_Cell))
            {
                indexes_Cell = [];
                pointIndex2D.IndexesByCell[cell] = indexes_Cell;
            }

            indexes_Cell.Add(index_Point);
        }

        /// <summary>
        /// Returns the cached spatial index for the given list, rebuilding it (one O(n) pass) if the list was mutated outside of <see cref="Add(List{Point2D}, Point2D, double)"/>/<see cref="FindNear(List{Point2D}, Point2D, double)"/> or the tolerance changed; otherwise the cached index is reused as-is.
        /// </summary>
        private static PointIndex2D GetIndex(List<Point2D?> point2Ds, double tolerance)
        {
            PointIndex2D pointIndex2D = pointIndex2Ds_ByList.GetValue(point2Ds, _ => new PointIndex2D());

            if (pointIndex2D.Count != point2Ds.Count || pointIndex2D.Tolerance != tolerance)
            {
                pointIndex2D.IndexesByCell.Clear();
                for (int index_Existing = 0; index_Existing < point2Ds.Count; index_Existing++)
                {
                    Point2D? point2D_Existing = point2Ds[index_Existing];
                    if (point2D_Existing == null)
                    {
                        continue;
                    }

                    RegisterPoint(pointIndex2D, index_Existing, point2D_Existing, tolerance);
                }

                pointIndex2D.Tolerance = tolerance;
                pointIndex2D.Count = point2Ds.Count;
            }

            return pointIndex2D;
        }

        private static Point2D? FindNear(PointIndex2D pointIndex2D, List<Point2D?> point2Ds, Point2D point2D, double tolerance)
        {
            (long X, long Y) = GetCell(point2D, tolerance);

            for (long x = X - 1; x <= X + 1; x++)
            {
                for (long y = Y - 1; y <= Y + 1; y++)
                {
                    if (!pointIndex2D.IndexesByCell.TryGetValue((x, y), out List<int>? indexes_Cell))
                    {
                        continue;
                    }

                    foreach (int index_Cell in indexes_Cell)
                    {
                        Point2D? point2D_Existing = point2Ds[index_Cell];
                        if (point2D_Existing == null)
                        {
                            continue;
                        }

                        double dx = point2D_Existing.X - point2D.X;
                        if (System.Math.Abs(dx) > tolerance)
                        {
                            continue;
                        }

                        double dy = point2D_Existing.Y - point2D.Y;
                        if (System.Math.Abs(dy) > tolerance)
                        {
                            continue;
                        }

                        if (dx * dx + dy * dy <= tolerance * tolerance)
                        {
                            return point2D_Existing;
                        }
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Finds the first point in the <c>List&lt;Point2D?&gt;?</c> that lies within the specified tolerance of the given point, using the same cached spatial index as <see cref="Add(List{Point2D}, Point2D, double)"/>.
        /// </summary>
        /// <param name="point2Ds">The <c>List&lt;Point2D?&gt;?</c> to search.</param>
        /// <param name="point2D">The <c>Point2D?</c> to search for.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance used to determine a match.</param>
        /// <returns>The matching <see cref="Point2D"/> from the list, or <c>null</c> if none is found.</returns>
        internal static Point2D? FindNear(this List<Point2D?>? point2Ds, Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance)
        {
            if (point2Ds == null || point2D == null)
            {
                return null;
            }

            PointIndex2D pointIndex2D = GetIndex(point2Ds, tolerance);
            return FindNear(pointIndex2D, point2Ds, point2D, tolerance);
        }

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

            PointIndex2D pointIndex2D = GetIndex(point2Ds, tolerance);

            if (FindNear(pointIndex2D, point2Ds, point2D, tolerance) != null)
            {
                return false;
            }

            int index_New = point2Ds.Count;
            point2Ds.Add(point2D);
            RegisterPoint(pointIndex2D, index_New, point2D, tolerance);
            pointIndex2D.Count = point2Ds.Count;

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
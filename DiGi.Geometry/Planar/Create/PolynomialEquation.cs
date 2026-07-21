using DiGi.Geometry.Planar.Classes;
using DiGi.Math.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar
{
    public static partial class Create
    {
        /// <summary>
        /// Fits a polynomial equation to the specified collection of <see cref="Point2D"/> points.
        /// </summary>
        /// <param name="point2Ds">The <see cref="IEnumerable{T}"/> of <see cref="Point2D"/> objects used for the fit.</param>
        /// <param name="order">The <see cref="int"/> order of the polynomial equation to be created.</param>
        /// <returns>A <see cref="PolynomialEquation"/> if the input collection is not null and contains at least two points; otherwise, <c>null</c>.</returns>
        public static PolynomialEquation? PolynomialEquation(this IEnumerable<Point2D>? point2Ds, int order = -1)
        {
            if (point2Ds == null)
            {
                return null;
            }

            Point2D[] point2Ds_Cached = point2Ds as Point2D[] ?? [.. point2Ds];
            if (point2Ds_Cached.Length < 2)
            {
                return null;
            }

            List<double> doubleXs = new(point2Ds_Cached.Length);
            List<double> doubleYs = new(point2Ds_Cached.Length);
            foreach (Point2D point2D in point2Ds_Cached)
            {
                doubleXs.Add(point2D.X);
                doubleYs.Add(point2D.Y);
            }

            return Math.Create.PolynomialEquation(doubleXs, doubleYs, order);
        }
    }
}
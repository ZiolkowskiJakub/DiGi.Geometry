using DiGi.Geometry.Planar.Classes;
using DiGi.Math.Classes;
using System.Collections.Generic;
using System.Linq;

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
            if (point2Ds == null || point2Ds.Count() < 2)
            {
                return null;
            }

            List<double> x = [];
            List<double> y = [];
            foreach (Point2D point2D in point2Ds)
            {
                x.Add(point2D.X);
                y.Add(point2D.Y);
            }

            return Math.Create.PolynomialEquation(x, y, order);
        }
    }
}
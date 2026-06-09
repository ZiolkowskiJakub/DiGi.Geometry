using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar.Interfaces
{
    public interface IClosedCurve2D : IClosedCurve, IGeometry2D, ICurve2D, IBoundable2D
    {
        /// <summary>
        /// Gets an internal point of the closed curve.
        /// </summary>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>An internal point if found; otherwise, null.</returns>
        Point2D? GetInternalPoint(double tolerance = DiGi.Core.Constants.Tolerance.Distance);

        /// <summary>
        /// Determines whether the specified point is within range of the closed curve.
        /// </summary>
        /// <param name="point2D">The point to check.</param>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>True if the point is in range; otherwise, false.</returns>
        public bool InRange(Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance);

        /// <summary>
        /// Determines whether the specified point is inside the closed curve.
        /// </summary>
        /// <param name="point2D">The point to check.</param>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>True if the point is inside; otherwise, false.</returns>
        public bool Inside(Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance);

        /// <summary>
        /// Calculates the area of the closed curve.
        /// </summary>
        /// <returns>The area of the closed curve.</returns>
        double GetArea();
    }
}
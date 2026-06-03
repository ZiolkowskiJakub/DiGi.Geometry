using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar.Interfaces
{
    public interface IFace2D : IFace, IGeometry2D, IBoundable2D, ISurface2D
    {
    /// <summary>
    /// Gets an internal point of the face.
    /// </summary>
    /// <param name="tolerance">The distance tolerance.</param>
    /// <returns>An internal point if found; otherwise, null.</returns>
        Point2D? GetInternalPoint(double tolerance = DiGi.Core.Constants.Tolerance.Distance);

        /// <summary>
        /// Gets the closest point on the face to the specified point.
        /// </summary>
        /// <param name="point2D">The point to check.</param>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>The closest point if found; otherwise, null.</returns>
        Point2D? ClosestPoint(Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance);

        /// <summary>
        /// Determines whether the specified point is within range of the face.
        /// </summary>
        /// <param name="point2D">The point to check.</param>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>True if the point is in range; otherwise, false.</returns>
        public bool InRange(Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance);

        /// <summary>
        /// Determines whether the specified point is inside the face.
        /// </summary>
        /// <param name="point2D">The point to check.</param>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>True if the point is inside; otherwise, false.</returns>
        public bool Inside(Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance);
    }

    public interface IFace2D<T> : IFace2D, IFace<T> where T : IClosedCurve2D
    {
    }
}
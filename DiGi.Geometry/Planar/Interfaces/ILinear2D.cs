using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar.Interfaces
{
    public interface ILinear2D : IMovable2D, ICurve, ITransformable2D, IGeometry2D
    {
        /// <summary>
        /// Gets the direction vector of the linear geometry.
        /// </summary>
        Vector2D? Direction { get; }

        /// <summary>
        /// Gets the closest point on the linear geometry to the specified point.
        /// </summary>
        /// <param name="point2D">The point to check.</param>
        /// <returns>The closest point if found; otherwise, null.</returns>
        Point2D? ClosestPoint(Point2D? point2D);

        /// <summary>
        /// Projects the specified point onto the linear geometry.
        /// </summary>
        /// <param name="point2D">The point to project.</param>
        /// <returns>The projected point if found; otherwise, null.</returns>
        Point2D? Project(Point2D? point2D);

        /// <summary>
        /// Calculates the distance from the specified point to the linear geometry.
        /// </summary>
        /// <param name="point2D">The point to calculate the distance from.</param>
        /// <returns>The shortest distance between the point and the linear geometry.</returns>
        double Distance(Point2D? point2D);

        /// <summary>
        /// Determines whether this linear geometry is collinear with another linear geometry.
        /// </summary>
        /// <param name="linear2D">The other linear geometry to check.</param>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>True if the geometries are collinear; otherwise, false.</returns>
        bool Collinear(ILinear2D? linear2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance);

        /// <summary>
        /// Determines whether the specified point lies on the linear geometry.
        /// </summary>
        /// <param name="point2D">The point to check.</param>
        /// <param name="tolerance">The distance tolerance.</param>
        /// <returns>True if the point is on the linear geometry; otherwise, false.</returns>
        bool On(Point2D? point2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance);
    }
}
using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar.Interfaces
{
    public interface IEllipse2D : IClosedCurve2D
    {
        /// <summary>
        /// Gets the center point of the ellipse.
        /// </summary>
        Point2D? Center { get; }
    }
}
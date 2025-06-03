using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar.Interfaces
{
    public interface IEllipse2D : IClosedCurve2D
    {
        Point2D Center { get; }
    }
}

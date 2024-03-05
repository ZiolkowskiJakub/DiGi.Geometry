using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar.Interfaces
{
    public interface ILinear2D : IMovable2D, IInvertible, ICurve, ITransformable2D
    {
        Vector2D Direction { get; }

        Point2D ClosestPoint(Point2D point2D);

        double Distance(Point2D point2D);

        bool Collinear(ILinear2D linear2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance);

        bool On(Point2D point2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance);

    }
}

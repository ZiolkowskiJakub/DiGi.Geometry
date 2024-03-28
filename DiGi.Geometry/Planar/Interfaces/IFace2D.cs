using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar.Interfaces
{
    public interface IFace2D : IFace, IGeometry2D, IBoundable2D
    {
        Point2D GetInternalPoint(double tolerance = DiGi.Core.Constans.Tolerance.Distance);

        Point2D ClosestPoint(Point2D point2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance);

        public bool InRange(Point2D point2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance);

        public bool Inside(Point2D point2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance);
    }

    public interface IFace2D<T> : IFace2D, IFace<T> where T : IClosedCurve2D
    {

    }
}

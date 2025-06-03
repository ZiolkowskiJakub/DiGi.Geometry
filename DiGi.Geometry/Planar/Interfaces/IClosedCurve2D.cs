using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar.Interfaces
{
    public interface IClosedCurve2D : IClosedCurve, IGeometry2D, ICurve2D, IBoundable2D
    {
        Point2D GetInternalPoint(double tolerance = DiGi.Core.Constans.Tolerance.Distance);

        public bool InRange(Point2D point2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance);

        public bool Inside(Point2D point2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance);
    }
}

using DiGi.Core;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar.Interfaces
{
    public interface IClosedCurve2D : IClosedCurve, IGeometry2D
    {
        double GetArea();

        double GetLength();

        public bool Inside(Point2D point2D, double tolerance = Constans.Tolerance.Distance);

        public bool InRange(Point2D point2D, double tolerance = Constans.Tolerance.Distance);
    }
}

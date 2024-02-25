using DiGi.Core;
using DiGi.Geometry.Planar.Classes;
using Microsoft.Win32.SafeHandles;

namespace DiGi.Geometry.Planar.Interfaces
{
    public interface IClosed2D : IGeometry2D
    {
        double GetArea();

        double GetLength();

        public bool Inside(Point2D point2D, double tolerance = Constans.Tolerance.Distance);

        public bool InRange(Point2D point2D, double tolerance = Constans.Tolerance.Distance);
    }
}

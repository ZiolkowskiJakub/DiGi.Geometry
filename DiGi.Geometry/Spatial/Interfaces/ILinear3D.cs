using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial.Interfaces
{
    public interface ILinear3D : IMovable3D, IInvertible, ICurve, ITransformable3D
    {
        Vector3D Direction { get; }

        Point3D ClosestPoint(Point3D point3D);

        double Distance(Point3D point3D);

        bool Collinear(ILinear3D linear3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance);

        bool On(Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance);

    }
}

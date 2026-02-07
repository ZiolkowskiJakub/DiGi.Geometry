using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial.Interfaces
{
    public interface ILinear3D : IMovable3D, ICurve, ITransformable3D
    {
        Vector3D? Direction { get; }

        Point3D? ClosestPoint(Point3D? point3D);

        Point3D? Project(Point3D? point3D);

        double Distance(Point3D? point3D);

        bool Collinear(ILinear3D? linear3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance);

        bool On(Point3D? point3D, double tolerance = DiGi.Core.Constants.Tolerance.Distance);
    }
}
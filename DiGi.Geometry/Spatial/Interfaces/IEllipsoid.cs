using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial.Interfaces
{
    public interface IEllipsoid : IGeometry3D, IBoundable3D
    {
        Point3D Center { get; }

        Vector3D Extent { get; }
    }
}

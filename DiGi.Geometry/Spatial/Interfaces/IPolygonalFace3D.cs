using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial.Interfaces
{
    public interface IPolygonalFace3D : IFace3D<IPolygonal3D>
    {
        Plane Plane { get; }
    }
}

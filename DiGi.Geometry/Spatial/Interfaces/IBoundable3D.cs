using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial.Interfaces
{
    public interface IBoundable3D : IGeometry3D, IBoundable
    {
        BoundingBox3D GetBoundingBox();
    }
}

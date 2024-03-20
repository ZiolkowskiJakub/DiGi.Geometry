using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar.Interfaces
{
    public interface IBoundable2D : IGeometry2D, IBoundable
    {
        BoundingBox2D GetBoundingBox();
    }
}

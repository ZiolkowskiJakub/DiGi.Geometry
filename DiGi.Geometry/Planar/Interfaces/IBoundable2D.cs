using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar.Interfaces
{
    public interface IBoundable2D : IGeometry2D
    {
        BoundingBox2D GetBoundingBox();
    }
}

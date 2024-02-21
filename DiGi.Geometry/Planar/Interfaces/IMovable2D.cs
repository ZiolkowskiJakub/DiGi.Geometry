using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar.Interfaces
{
    public interface IMovable2D : IGeometry2D
    {
        void Move(Vector2D vector2D);
    }
}

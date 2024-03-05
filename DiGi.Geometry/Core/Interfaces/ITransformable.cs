using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Core.Interfaces
{
    public interface ITransformable : IGeometry
    {
    }

    public interface ITransformable<T> : ITransformable where T: ITransform
    {
        bool Transform(T transform);
    }
}

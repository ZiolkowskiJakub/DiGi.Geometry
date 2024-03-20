using DiGi.Core.Interfaces;

namespace DiGi.Geometry.Core.Interfaces
{
    public interface IBoundedGeometry<T, X> : ISerializableObject, IBoundable where T : IBoundable where X : IBoundingBox
    {
        X GetBoundingBox();

        T Boundable { get; set; }
    }
}

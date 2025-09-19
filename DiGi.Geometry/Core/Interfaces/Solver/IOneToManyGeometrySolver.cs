using DiGi.Core.Interfaces;

namespace DiGi.Geometry.Core.Interfaces
{
    public interface IOneToManyGeometrySolver<TInputGeometry, TOutputGeometry> : IGeometrySolver, IOneToManySolver<TInputGeometry, TOutputGeometry> where TInputGeometry : IGeometry where TOutputGeometry : IGeometry
    {

    }
}

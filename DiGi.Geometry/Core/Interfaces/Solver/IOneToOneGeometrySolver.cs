using DiGi.Core.Interfaces;

namespace DiGi.Geometry.Core.Interfaces
{
    public interface IOneToOneGeometrySolver<TInputGeometry, TOutputGeometry> : IGeometrySolver, IOneToOneSolver<TInputGeometry, TOutputGeometry> where TInputGeometry : IGeometry where TOutputGeometry : IGeometry
    {

    }
}

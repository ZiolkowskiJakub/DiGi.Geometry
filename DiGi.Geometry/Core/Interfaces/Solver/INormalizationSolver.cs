using DiGi.Core.Interfaces;

namespace DiGi.Geometry.Core.Interfaces
{
    public interface INormalizationSolver : ISolver
    {
        bool Normalized();
    }
}

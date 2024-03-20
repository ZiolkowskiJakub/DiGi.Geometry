using System.Collections.Generic;

namespace DiGi.Geometry.Core.Interfaces
{
    public interface IFace : ISurface
    {
        double GetArea();
    }

    public interface IFace<T> : IFace where T : IClosedCurve
    {
        T ExternalEdge { get; }
        List<T> InternalEdges { get; }
    }
}

using System.Collections.Generic;

namespace DiGi.Geometry.Core.Interfaces
{
    public interface IFace : ISurface
    {
    }

    public interface IFace<T> : IFace where T : IClosedCurve
    {
        T ExternalCurve { get; }
        List<T> InternalCurves { get; }
    }
}

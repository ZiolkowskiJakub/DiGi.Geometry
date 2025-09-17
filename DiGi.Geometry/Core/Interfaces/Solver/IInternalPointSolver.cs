using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Core.Interfaces
{
    public interface IInternalPointSolver : ISolver
    {
        int MaxCount { get; set; }
    }

    public interface IInternalPointSolver<TPoint> : IInternalPointSolver where TPoint : IPoint
    {
        TPoint? InternalPoint { get; }

        List<TPoint>? InternalPoints { get; }
    }
}

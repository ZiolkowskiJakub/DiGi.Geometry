using System.Collections.Generic;

namespace DiGi.Geometry.Core.Interfaces
{
    public interface ICoordinateSystem : IGeometry
    {

    }

    public interface ICoordinateSystem<TPoint> : ICoordinateSystem where TPoint : IPoint
    {
        TPoint Origin { get; }
    }
}

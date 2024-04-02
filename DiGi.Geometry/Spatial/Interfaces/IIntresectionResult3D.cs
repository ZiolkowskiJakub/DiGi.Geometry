using DiGi.Geometry.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial.Interfaces
{
    public interface IIntersectionResult3D : IIntersectionResult
    {
        List<T> GetGeometry3Ds<T>() where T : IGeometry3D;
    }
}

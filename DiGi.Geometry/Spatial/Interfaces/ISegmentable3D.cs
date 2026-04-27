using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial.Interfaces
{
    public interface ISegmentable3D : ISegmentable<Point3D>, IMovable3D, ICurve3D, IBoundable3D, IInvertible3D
    {
        List<Segment3D>? GetSegments();
    }
}
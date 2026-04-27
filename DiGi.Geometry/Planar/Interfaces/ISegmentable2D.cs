using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar.Interfaces
{
    public interface ISegmentable2D : ISegmentable<Point2D>, IMovable2D, ICurve2D, IBoundable2D, IInvertible2D
    {
        List<Segment2D>? GetSegments();
    }
}
using System.Collections.Generic;

namespace DiGi.Geometry.Core.Interfaces
{
    public interface ISegmentable : IGeometry, IInvertible, ICurve, IMovable
    {
        double Length { get; }
    }

    public interface ISegmentable<TPoint> : ISegmentable where TPoint : IPoint
    {
        List<TPoint>? GetPoints();

        double Distance(TPoint? point);

        TPoint? ClosestPoint(TPoint? point);

        bool On(TPoint? point, double tolerance = DiGi.Core.Constants.Tolerance.Distance);
    }
}
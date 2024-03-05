using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar.Interfaces
{
    public interface ISegmentable2D : IMovable2D, ICurve2D, IBoundable2D, IInvertible
    {
        List<Segment2D> GetSegments();

        List<Point2D> GetPoints();

        double Distance(Point2D point2D);

        Point2D ClosestPoint(Point2D point2D);

        bool On(Point2D point2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance);

        double Length { get; }
    }
}

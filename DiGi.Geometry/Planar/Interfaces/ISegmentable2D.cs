using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar.Interfaces
{
    public interface ISegmentable2D : IMovable2D
    {
        List<Segment2D> GetSegments();

        List<Point2D> GetPoints();

        double Distance(Point2D point2D);

        Point2D ClosestPoint(Point2D point2D);
    }
}

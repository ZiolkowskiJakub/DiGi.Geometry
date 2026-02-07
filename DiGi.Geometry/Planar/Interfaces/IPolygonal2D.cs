using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar.Interfaces
{
    public interface IPolygonal2D : IClosedCurve2D, ISegmentable2D
    {
        Point2D? GetCentroid();

        bool Inside(ISegmentable2D? segmentable2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance);

        bool InRange(ISegmentable2D? segmentable2D, double tolerance = DiGi.Core.Constants.Tolerance.Distance);

        List<Triangle2D>? Triangulate(double tolerance = DiGi.Core.Constants.Tolerance.MicroDistance);
    }
}
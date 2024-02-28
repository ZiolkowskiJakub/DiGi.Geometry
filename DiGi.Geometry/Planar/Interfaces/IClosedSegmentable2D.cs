using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar.Interfaces
{
    public interface IClosedSegmentable2D : IClosedCurve2D, ISegmentable2D
    {
        bool Inside(ISegmentable2D segmentable2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance);

        bool InRange(ISegmentable2D segmentable2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance);
    }
}

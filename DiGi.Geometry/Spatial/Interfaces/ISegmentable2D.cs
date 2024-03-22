using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial.Interfaces
{
    public interface ISegmentable3D : IMovable3D, ICurve3D, IBoundable3D, IInvertible
    {
        List<Segment3D> GetSegments();

        List<Point3D> GetPoints();

        double Distance(Point3D point3D);

        Point3D ClosestPoint(Point3D point3D);

        bool On(Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance);

        double Length { get; }
    }
}

using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial.Interfaces
{
    public interface IPolygonal3D : IClosedCurve3D, ISegmentable3D, IPlanar, IInvertible3D
    {
        Point3D? GetCentroid();

        bool Inside(ISegmentable3D? segmentable3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance);

        bool InRange(ISegmentable3D? segmentable3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance);

        List<Triangle3D>? Triangulate(double tolerance = DiGi.Core.Constans.Tolerance.MicroDistance);
    }

    public interface IPolygonal3D<TGeometry2D> : IPolygonal3D, IPlanar<TGeometry2D> where TGeometry2D : IGeometry2D
    {

    }
}

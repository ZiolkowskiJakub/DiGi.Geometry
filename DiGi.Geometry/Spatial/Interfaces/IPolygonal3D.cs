using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial.Interfaces
{
    public interface IPolygonal3D : IClosedCurve3D, ISegmentable3D, IPlanar
    {
        Point3D GetCentroid();
        
        bool Inside(ISegmentable3D segmentable3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance);

        bool InRange(ISegmentable3D segmentable3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance);

        List<Triangle3D> Triangulate(double tolerance = DiGi.Core.Constans.Tolerance.MicroDistance);
    }
}

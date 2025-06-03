using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial.Interfaces
{
    public interface IPolygonalFace3D : IFace3D<IPolygonal3D>, IPolyhedronFace
    {
        Plane Plane { get; }

        List<Triangle3D> Triangulate(double tolerance = DiGi.Core.Constans.Tolerance.MicroDistance);
    }
}

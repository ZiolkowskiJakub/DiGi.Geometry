using DiGi.Core.Constants;
using DiGi.Geometry.Core.Enums;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial.Interfaces
{
    public interface IPolyhedron : IGeometry3D, IBoundable3D, IInvertible3D
    {
        int Count { get; }

        Vector3D? GetNormal(int index, out bool inversed, Side? side = null, double tolerance = Tolerance.Distance);

        TPolygonalFace3D? GetPolygonalFace3D<TPolygonalFace3D>(int index) where TPolygonalFace3D : IPolygonalFace3D;

        bool Inside(Point3D? point3D, double tolerance = Tolerance.Distance);

        bool Normalized(int index, Orientation? externalEdgeOrientation, Orientation? internalEdgeOrientation, double tolerance = Tolerance.Distance);

        bool Orient(Orientation? externalEdgeOrientation, Orientation? internalEdgeOrientation);

        bool SetNormal(int index, Side side, double tolerance = Tolerance.Distance);
    }
}
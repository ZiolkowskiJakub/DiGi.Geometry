using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar.Interfaces
{
    public interface IPolygonalFace2D : IFace2D<IPolygonal2D>
    {
        bool OnEdge(Point2D point2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance);
    }
}

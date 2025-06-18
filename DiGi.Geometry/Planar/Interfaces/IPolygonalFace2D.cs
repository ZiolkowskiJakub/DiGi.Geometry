using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar.Interfaces
{
    public interface IPolygonalFace2D : IFace2D<IPolygonal2D>
    {
        List<IPolygonal2D> Edges { get; }

        bool OnEdge(Point2D point2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance);

        List<Triangle2D> Triangulate(double tolerance = DiGi.Core.Constans.Tolerance.MicroDistance);
    }
}

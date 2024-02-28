using DiGi.Geometry.Core.Interfaces;

namespace DiGi.Geometry.Planar.Interfaces
{
    public interface IFace2D : IFace, IGeometry2D
    {

    }

    public interface IFace2D<T> : IFace2D, IFace<T> where T : IClosedCurve2D
    {

    }
}

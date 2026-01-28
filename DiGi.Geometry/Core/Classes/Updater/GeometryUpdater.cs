using DiGi.Geometry.Core.Interfaces;

namespace DiGi.Geometry.Core.Classes
{
    public abstract class GeometryUpdater<TGeometry> : IGeometryUpdater<TGeometry> where TGeometry : IGeometry
    {
        public TGeometry? Value { get; set; }

        public abstract bool Update();
    }
}
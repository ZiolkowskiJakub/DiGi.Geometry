namespace DiGi.Geometry.Spatial.Interfaces
{
    public interface IFlippable : IGeometry3D
    {
        bool Flip(Enums.SpatialAxis prmiaryAxis = Enums.SpatialAxis.Z, Enums.SpatialAxis secondaryAxis = Enums.SpatialAxis.X);
    }
}
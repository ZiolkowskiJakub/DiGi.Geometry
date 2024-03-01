namespace DiGi.Geometry.Core.Interfaces
{
    public interface IClosedCurve : ICurve
    {
        double Length { get; }

        double GetArea();
    }
}

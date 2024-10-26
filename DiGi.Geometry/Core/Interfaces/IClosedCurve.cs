namespace DiGi.Geometry.Core.Interfaces
{
    public interface IClosedCurve : ICurve
    {
        double GetPerimeter();

        double GetArea();
    }
}

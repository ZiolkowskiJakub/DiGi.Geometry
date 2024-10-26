namespace DiGi.Geometry.Core
{
    public static partial class Query
    {
        public static double ThinnessRatio(double area, double perimeter)
        {
            if(double.IsNaN(area) || double.IsNaN(perimeter))
            {
                return double.NaN;
            }

            return (4 * System.Math.PI * area) / (perimeter * perimeter);
        }
    }
}

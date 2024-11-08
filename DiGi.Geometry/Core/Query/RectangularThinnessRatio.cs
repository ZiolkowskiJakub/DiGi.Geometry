namespace DiGi.Geometry.Core
{
    public static partial class Query
    {
        public static double RectangularThinnessRatio(double area, double perimeter)
        {
            if(double.IsNaN(area) || double.IsNaN(perimeter))
            {
                return double.NaN;
            }

            if(perimeter == 0)
            {
                return double.NaN;
            }

            return 4 * System.Math.Sqrt(area) / perimeter;
        }
    }
}

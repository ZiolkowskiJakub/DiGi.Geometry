namespace DiGi.Geometry.Core
{
    public static partial class Query
    {
        public static double IsoperimetricRatio(double area, double perimeter)
        {
            if(double.IsNaN(area) || double.IsNaN(perimeter))
            {
                return double.NaN;
            }

            if(area == 0)
            {
                return double.NaN;
            }

            return (perimeter * perimeter) / area;
        }
    }
}

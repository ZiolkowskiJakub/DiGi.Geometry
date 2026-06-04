namespace DiGi.Geometry.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the thinness ratio of a shape based on its area and perimeter.
        /// </summary>
        /// <param name="area">The double value representing the area of the shape.</param>
        /// <param name="perimeter">The double value representing the perimeter of the shape.</param>
        /// <returns>A double value representing the thinness ratio, or <see cref="double.NaN"/> if either input is <see cref="double.NaN"/> or if the perimeter is zero.</returns>
        public static double ThinnessRatio(double area, double perimeter)
        {
            if (double.IsNaN(area) || double.IsNaN(perimeter))
            {
                return double.NaN;
            }

            if (perimeter == 0)
            {
                return double.NaN;
            }

            return (4 * System.Math.PI * area) / (perimeter * perimeter);
        }
    }
}
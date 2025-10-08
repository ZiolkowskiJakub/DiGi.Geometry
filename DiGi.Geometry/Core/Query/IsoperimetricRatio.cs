namespace DiGi.Geometry.Core
{
    public static partial class Query
    {
        /// <summary>
        /// the Isoperimetric Ratio (IR) (also called Isoperimetric Quotient, Circular Compactness, or Shape Factor) is a classic geometric measure that describes how close a shape is to a perfect circle.
        /// </summary>
        /// <param name="area">Area of the shape</param>
        /// <param name="perimeter">Perimeter (or boundary length)</param>
        /// <returns>Isoperimetric ratio</returns>
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

            //return (perimeter * perimeter) / area;

            return (4 * System.Math.PI * area) / (perimeter * perimeter);
        }
    }
}

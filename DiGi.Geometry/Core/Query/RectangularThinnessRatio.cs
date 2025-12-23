namespace DiGi.Geometry.Core
{
    public static partial class Query
    {
        /// <summary>
        /// The Rectangular Thinness Ratio (RTR) — also sometimes called the Rectangular Compactness Ratio or Rectangular Shape Factor — is a geometric shape descriptor that measures how elongated or “thin” a shape is compared to a rectangle that perfectly fits around it (its minimum bounding rectangle).
        /// </summary>
        /// <param name="area">shape area</param>
        /// <param name="rectangleArea">Minimal rectangle area</param>
        /// <returns>Rectangular thinness ratio</returns>
        public static double RectangularThinnessRatio(double area, double rectangleArea)
        {
            if (double.IsNaN(area) || double.IsNaN(rectangleArea))
            {
                return double.NaN;
            }

            if (rectangleArea == 0)
            {
                return double.NaN;
            }

            return area / rectangleArea;
        }
    }
}

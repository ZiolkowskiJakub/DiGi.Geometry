namespace DiGi.Geometry.Core
{
    public static partial class Query
    {
        /// <summary>
        /// The Square Thinness Ratio (STR) — also sometimes called the Square Compactness Ratio or Square Shape Factor — is a geometric shape descriptor that measures how elongated or “thin” a shape is compared to a square that perfectly fits around it (its minimum bounding square).
        /// </summary>
        /// <param name="area">shape area</param>
        /// <param name="squareArea">square area</param>
        /// <returns>Square thinness ratio</returns>
        public static double SquareThinnessRatio(double area, double squareArea)
        {
            if (double.IsNaN(area) || double.IsNaN(squareArea))
            {
                return double.NaN;
            }

            if (squareArea == 0)
            {
                return double.NaN;
            }

            return area / squareArea;
        }
    }
}
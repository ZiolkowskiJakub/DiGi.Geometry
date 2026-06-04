using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the length of the diagonal for the specified <see cref="BoundingBox2D"/>.
        /// </summary>
        /// <param name="boundingBox2D">The <see cref="BoundingBox2D"/> instance to calculate the diagonal length for.</param>
        /// <returns>A <see cref="double"/> representing the length of the diagonal, or <see cref="double.NaN"/> if the <see cref="BoundingBox2D"/> is null or contains no diagonals.</returns>
        public static double DiagonalLength(this BoundingBox2D boundingBox2D)
        {
            if (boundingBox2D == null)
            {
                return double.NaN;
            }

            Segment2D[]? segment2Ds = boundingBox2D.GetDiagonals();
            if (segment2Ds == null || segment2Ds.Length == 0)
            {
                return double.NaN;
            }

            return segment2Ds[0].Length;
        }
    }
}
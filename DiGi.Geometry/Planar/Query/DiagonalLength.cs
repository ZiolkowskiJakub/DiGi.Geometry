using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static double DiagonalLength(this BoundingBox2D boundingBox2D)
        {
            if (boundingBox2D == null)
            {
                return double.NaN;
            }

            Segment2D[] segment2Ds = boundingBox2D.GetDiagonals();
            if (segment2Ds == null || segment2Ds.Length == 0)
            {
                return double.NaN;
            }

            return segment2Ds[0].Length;
        }
    }
}

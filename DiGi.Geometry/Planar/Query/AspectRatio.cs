using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        public static double AspectRatio(this Rectangle2D rectangle2D, bool normalized = true)
        {
            if (rectangle2D is null)
            {
                return double.NaN;
            }

            return DiGi.Core.Query.AspectRatio(rectangle2D.Width, rectangle2D.Height, normalized);
        }

        public static double AspectRatio(this BoundingBox2D boundingBox2D, bool normalized = true)
        {
            if (boundingBox2D is null)
            {
                return double.NaN;
            }

            return DiGi.Core.Query.AspectRatio(boundingBox2D.Width, boundingBox2D.Height, normalized);
        }
    }
}

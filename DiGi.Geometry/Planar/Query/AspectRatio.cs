using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the aspect ratio of the specified <see cref="Rectangle2D"/>.
        /// </summary>
        /// <param name="rectangle2D">The <see cref="Rectangle2D"/> instance to calculate the aspect ratio for.</param>
        /// <param name="normalized">A <see cref="bool"/> value indicating whether the result should be normalized. Defaults to true.</param>
        /// <returns>A <see cref="double"/> representing the aspect ratio, or <see cref="double.NaN"/> if the <paramref name="rectangle2D"/> is null.</returns>
        public static double AspectRatio(this Rectangle2D rectangle2D, bool normalized = true)
        {
            if (rectangle2D is null)
            {
                return double.NaN;
            }

            return DiGi.Core.Query.AspectRatio(rectangle2D.Width, rectangle2D.Height, normalized);
        }

        /// <summary>
        /// Calculates the aspect ratio of the specified <see cref="BoundingBox2D"/>.
        /// </summary>
        /// <param name="boundingBox2D">The <see cref="BoundingBox2D"/> to calculate the aspect ratio for.</param>
        /// <param name="normalized">A <see cref="bool"/> value indicating whether the result should be normalized. Defaults to true.</param>
        /// <returns>A <see cref="double"/> representing the aspect ratio, or <see cref="double.NaN"/> if the <see cref="BoundingBox2D"/> is null.</returns>
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
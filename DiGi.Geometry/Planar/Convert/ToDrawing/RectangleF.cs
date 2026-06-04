using DiGi.Geometry.Planar.Classes;
using System.Drawing;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts the specified <see cref="BoundingBox2D"/> to a <see cref="RectangleF"/>.
        /// </summary>
        /// <param name="boundingBox2D">The <see cref="BoundingBox2D"/> instance to convert.</param>
        /// <returns>A <see cref="RectangleF"/> representing the bounding box, or <c>null</c> if the <see cref="BoundingBox2D"/> is null or its minimum point is null.</returns>
        public static RectangleF? ToDrawing(this BoundingBox2D boundingBox2D)
        {
            Point2D? min = boundingBox2D?.Min;
            if (min == null)
            {
                return null;
            }

            return new RectangleF(
                System.Convert.ToSingle(min.X),
                System.Convert.ToSingle(min.Y),
                System.Convert.ToSingle(boundingBox2D!.Width),
                System.Convert.ToSingle(boundingBox2D!.Height));
        }
    }
}
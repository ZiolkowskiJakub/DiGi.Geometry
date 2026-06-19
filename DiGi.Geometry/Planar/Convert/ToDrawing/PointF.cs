using DiGi.Geometry.Planar.Classes;
using System.Drawing;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <c>Point2D?</c> to a <c>PointF?</c> for drawing purposes.
        /// </summary>
        /// <param name="point2D">The <see cref="Point2D"/> instance to convert.</param>
        /// <returns>A <c>PointF?</c> representation of the point, or <see langword="null"/> if the provided <c>Point2D?</c> is <see langword="null"/>.</returns>
        public static PointF? ToDrawing(this Point2D? point2D)
        {
            if (point2D == null)
            {
                return null;
            }

            return new PointF(System.Convert.ToSingle(point2D.X), System.Convert.ToSingle(point2D.Y));
        }
    }
}
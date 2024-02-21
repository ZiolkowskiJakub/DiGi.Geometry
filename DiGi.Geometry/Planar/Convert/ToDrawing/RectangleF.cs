using DiGi.Geometry.Planar.Classes;
using System.Drawing;

namespace DiGi.Geometry.Planar
{
    public static partial class Convert
    {
        public static RectangleF? ToDrawing(this BoundingBox2D boundingBox2D)
        {
            Point2D min = boundingBox2D?.Min;
            if(min == null)
            {
                return null;
            }

            return new RectangleF(
                System.Convert.ToSingle(min.X), 
                System.Convert.ToSingle(min.Y), 
                System.Convert.ToSingle(boundingBox2D.Width), 
                System.Convert.ToSingle(boundingBox2D.Height));
        }
    }
}

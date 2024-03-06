using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Math.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Planar.Classes
{
    public class Point2D : Coordinate2D, IMovable2D, IPoint
    {
        public Point2D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Point2D(double x, double y)
            : base(x, y)
        {

        }

        public Point2D(double[] values)
            : base(values)
        {

        }

        public Point2D(Point2D point2D)
            : base(point2D)
        {

        }

        public override ISerializableObject Clone()
        {
            return new Point2D(values);
        }

        public Point2D Mid(Point2D point2D)
        {
            if(point2D == null)
            {
                return null;
            }

            return new Point2D((point2D[0] + values[0]) / 2, (point2D[1] + values[1]) / 2);
        }

        public double Distance(Point2D point2D)
        {
            if(point2D == null)
            {
                return double.NaN;
            }

            return new Vector2D(this, point2D).Length;
        }
    }
}

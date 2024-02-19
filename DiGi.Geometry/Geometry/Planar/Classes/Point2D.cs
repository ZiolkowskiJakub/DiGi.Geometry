using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Planar.Classes
{
    public class Point2D : Coordinate2D, IMovable2D
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

        public void Move(Vector2D vector2D)
        {
            if(vector2D == null)
            {
                return;
            }

            values[0] += vector2D[0];
            values[1] += vector2D[1];
        }
    }
}

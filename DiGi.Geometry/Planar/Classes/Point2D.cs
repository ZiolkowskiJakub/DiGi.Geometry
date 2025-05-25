using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Geometry.Planar.Classes
{
    public class Point2D : Coordinate2D, IMovable2D, IPoint<Point2D>
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

        public static implicit operator Point2D((double x, double y) @object)
        {
            return new Point2D(@object.x, @object.y);
        }

        public override ISerializableObject Clone()
        {
            return new Point2D(values);
        }

        public double Distance(Point2D point2D)
        {
            if (point2D == null)
            {
                return double.NaN;
            }

            return new Vector2D(this, point2D).Length;
        }

        public Point2D GetMoved(Vector2D vector3D)
        {
            if (vector3D == null)
            {
                return null;
            }

            Point2D result = new Point2D(this);
            result.Move(vector3D);

            return result;
        }

        public bool InDistance(Point2D point2D, double distance, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point2D == null)
            {
                return false;
            }

            if (System.Math.Abs(X - point2D.X) > distance + tolerance)
            {
                return false;
            }

            if (System.Math.Abs(Y - point2D.Y) > distance + tolerance)
            {
                return false;
            }

            return Distance(point2D) < distance - tolerance;

        }

        public Point2D Mid(Point2D point2D)
        {
            if(point2D == null)
            {
                return null;
            }

            return new Point2D((point2D[0] + values[0]) / 2, (point2D[1] + values[1]) / 2);
        }
    }
}

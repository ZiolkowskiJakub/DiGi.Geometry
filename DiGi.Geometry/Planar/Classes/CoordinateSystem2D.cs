using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    public class CoordinateSystem2D : SerializableObject, IMovable2D, ITransformable2D
    {
        [JsonInclude, JsonPropertyName("AxisX")]
        private Vector2D axisX;

        [JsonInclude, JsonPropertyName("AxisY")]
        private Vector2D axisY;

        [JsonInclude, JsonPropertyName("Origin")]
        private Point2D origin;
        public CoordinateSystem2D(Point2D origin)
        {
            this.origin = origin == null ? null : new Point2D(origin);
            axisX = Constans.Vector2D.WorldX;
            axisY = Constans.Vector2D.WorldY;
        }

        public CoordinateSystem2D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public CoordinateSystem2D()
        {
            origin = Constans.Point2D.Zero;
            axisX = Constans.Vector2D.WorldX;
            axisY = Constans.Vector2D.WorldY;
        }

        public CoordinateSystem2D(CoordinateSystem2D coordinateSystem2D)
        {
            if (coordinateSystem2D != null)
            {
                origin = coordinateSystem2D.Origin;
                axisX = coordinateSystem2D.AxisX;
                axisY = coordinateSystem2D.AxisY;
            }
        }

        internal CoordinateSystem2D(Point2D origin, Vector2D axisX, Vector2D axisY)
        {
            this.origin = origin == null ? null : new Point2D(origin);
            this.axisX = axisX == null ? null : new Vector2D(axisX);
            this.axisY = axisY == null ? null : new Vector2D(axisY);
        }
        
        public Vector2D AxisX
        {
            get
            {
                return axisX == null ? null : new Vector2D(axisX);
            }
        }

        public Vector2D AxisY
        {
            get
            {
                return axisY == null ? null : new Vector2D(axisY);
            }
        }

        public Point2D Origin
        {
            get
            {
                return origin == null ? null : new Point2D(origin);
            }
        }

        public override ISerializableObject Clone()
        {
            return new CoordinateSystem2D(this);
        }

        public bool Move(Vector2D vector2D)
        {
            if(origin == null || vector2D == null)
            {
                return false;
            }

            origin.Move(vector2D);
            return true;
        }

        public bool Transform(ITransform2D transform)
        {
            if(transform == null || origin == null || axisX == null || axisY == null)
            {
                return false;
            }

            Point2D point2D_X = new Point2D(origin);
            point2D_X.Move(axisX);

            Point2D point2D_Y = new Point2D(origin);
            point2D_Y.Move(axisY);

            origin.Transform(transform);

            point2D_X.Transform(transform);
            axisX = new Vector2D(origin, point2D_X);
            axisX.Normalize();

            point2D_Y.Transform(transform);
            axisY = new Vector2D(origin, point2D_Y);
            axisY.Normalize();

            return true;
        }
    }
}

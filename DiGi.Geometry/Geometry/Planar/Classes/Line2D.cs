using DiGi.Core;
using DiGi.Core.Interfaces;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    public class Line2D : Geometry2D
    {
        [JsonInclude, JsonPropertyName("Direction")]
        private Vector2D direction;

        [JsonInclude, JsonPropertyName("Origin")]
        private Point2D origin;
        public Line2D(Point2D origin, Vector2D direction)
        {
            this.origin = origin?.Clone<Point2D>();
            this.direction = direction?.Unit;
        }

        [JsonIgnore]
        public Vector2D Direction
        {
            get
            {
                return direction?.Clone<Vector2D>();
            }

            set
            {
                direction = value?.Clone<Vector2D>();
            }
        }

        [JsonIgnore]
        public Point2D Origin
        {
            get
            {
                return origin?.Clone<Point2D>();
            }

            set
            {
                origin = value?.Clone<Point2D>();
            }
        }

        public override ISerializableObject Clone()
        {
            return new Line2D(Origin, Direction);
        }


    }
}

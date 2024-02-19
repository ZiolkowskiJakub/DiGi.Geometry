using DiGi.Core;
using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    public class Segment2D : Geometry2D
    {
        private Point2D origin;
        private Vector2D vector2D;

        public Segment2D(Point2D origin, Vector2D vector2D)
        {
            this.origin = origin?.Clone<Point2D>();
            this.vector2D = vector2D?.Unit;
        }

        public Segment2D(Segment2D segment2D)
            :this(segment2D?.origin, segment2D?.vector2D)
        {

        }

        public Segment2D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonIgnore]
        public Vector2D Direction
        {
            get
            {
                return vector2D?.Unit;
            }

            set
            {
                vector2D = value?.Unit * Length;
            }
        }

        [JsonIgnore]
        public double Length
        {
            get
            {
                return vector2D.Length;
            }

            set
            {
                vector2D = Direction * value;
            }
        }

        [JsonPropertyName("Origin")]
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

        [JsonPropertyName("Vector2D")]
        public Vector2D Vector2D
        {
            get
            {
                return vector2D?.Clone<Vector2D>();
            }

            set
            {
                vector2D = value?.Clone<Vector2D>();
            }
        }

        public override ISerializableObject Clone()
        {
            return new Line2D(Origin, Vector2D);
        }


    }
}

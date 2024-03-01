using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    public class SegmentableTraceResult2D : SerializableObject
    {
        [JsonInclude, JsonPropertyName("Vector2D")]
        private Vector2D vector2D;
        
        [JsonInclude, JsonPropertyName("Segment2D")]
        private Segment2D segment2D;

        [JsonInclude, JsonPropertyName("Point2D")]
        private Point2D point2D;

        public SegmentableTraceResult2D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        internal SegmentableTraceResult2D(Vector2D vector2D, Segment2D segment2D, Point2D point2D)
        {
            this.vector2D = DiGi.Core.Query.Clone(vector2D);
            this.segment2D = DiGi.Core.Query.Clone(segment2D);
            this.point2D = DiGi.Core.Query.Clone(point2D);
        }

        public SegmentableTraceResult2D(SegmentableTraceResult2D segmentableTraceResult2D)
        {
            if(segmentableTraceResult2D != null)
            {
                vector2D = segmentableTraceResult2D.Vector2D;
                segment2D = segmentableTraceResult2D.Segment2D;
                point2D = segmentableTraceResult2D.Point2D;
            }
        }

        /// <summary>
        /// Hit direction
        /// </summary>
        [JsonIgnore]
        public Vector2D Vector2D
        {
            get
            {
                return vector2D == null ? null : new Vector2D(vector2D);
            }
        }

        /// <summary>
        /// Hit Point
        /// </summary>
        [JsonIgnore]
        public Point2D Point2D
        {
            get
            {
                return point2D == null ? null : new Point2D(point2D);
            }
        }

        /// <summary>
        /// Hit Segment
        /// </summary>
        [JsonIgnore]
        public Segment2D Segment2D
        {
            get
            {
                return segment2D == null ? null : new Segment2D(segment2D);
            }
        }

        public override ISerializableObject Clone()
        {
            return new SegmentableTraceResult2D(vector2D, segment2D, point2D);
        }
    }
}

using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    /// <summary>
    /// Represents a result of a trace operation in 2D space that can be segmented into a point, segment, or vector.
    /// </summary>
    public class SegmentableTraceResult2D : SerializableObject
    {
        [JsonInclude, JsonPropertyName("Point2D")]
        private readonly Point2D? point2D;

        [JsonInclude, JsonPropertyName("Segment2D")]
        private readonly Segment2D? segment2D;

        [JsonInclude, JsonPropertyName("Vector2D")]
        private readonly Vector2D? vector2D;

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentableTraceResult2D"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the current instance.</param>
        public SegmentableTraceResult2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentableTraceResult2D"/> class by copying the values from an existing <see cref="SegmentableTraceResult2D"/> instance.
        /// </summary>
        /// <param name="segmentableTraceResult2D">The <see cref="SegmentableTraceResult2D"/> instance to copy data from.</param>
        public SegmentableTraceResult2D(SegmentableTraceResult2D? segmentableTraceResult2D)
        {
            if (segmentableTraceResult2D != null)
            {
                vector2D = segmentableTraceResult2D.Vector2D;
                segment2D = segmentableTraceResult2D.Segment2D;
                point2D = segmentableTraceResult2D.Point2D;
            }
        }

        internal SegmentableTraceResult2D(Vector2D? vector2D, Segment2D? segment2D, Point2D? point2D)
        {
            this.vector2D = DiGi.Core.Query.Clone(vector2D);
            this.segment2D = DiGi.Core.Query.Clone(segment2D);
            this.point2D = DiGi.Core.Query.Clone(point2D);
        }

        /// <summary>
        /// Hit Point
        /// </summary>
        [JsonIgnore]
        public Point2D? Point2D
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
        public Segment2D? Segment2D
        {
            get
            {
                return segment2D == null ? null : new Segment2D(segment2D);
            }
        }

        /// <summary>
        /// Hit direction
        /// </summary>
        [JsonIgnore]
        public Vector2D? Vector2D
        {
            get
            {
                return vector2D == null ? null : new Vector2D(vector2D);
            }
        }

        /// <summary>
        /// Creates a clone of the current object.
        /// </summary>
        /// <returns>A new <see cref="ISerializableObject"/> instance that is a copy of the current object, or null.</returns>
        public override ISerializableObject? Clone()
        {
            return new SegmentableTraceResult2D(vector2D, segment2D, point2D);
        }
    }
}

using DiGi.Core;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    public class Segment2D : Geometry2D, ISegmentable2D, ILinear2D, ISegment<Point2D>
    {
        private Point2D start;
        private Vector2D vector;

        public Segment2D(double x_1, double y_1, double x_2, double y_2)
        {
            start = new Point2D(x_1, y_1);
            vector = new Vector2D(start, new Point2D(x_2, y_2));
        }
        
        public Segment2D(Point2D start, Vector2D vector)
        {
            this.start = start?.Clone<Point2D>();
            this.vector = vector?.Clone<Vector2D>();
        }

        public Segment2D(Point2D start, Point2D end)
        {
            if (start != null && end != null)
            {
                this.start = start?.Clone<Point2D>();
                vector = new Vector2D(start, end);
            }
        }

        public Segment2D(Segment2D segment2D)
            : this(segment2D?.start, segment2D?.vector)
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
                return vector?.Unit;
            }

            set
            {
                vector = value?.Unit * Length;
            }
        }

        [JsonIgnore]
        public Point2D End
        {
            get
            {
                if (vector == null || start == null)
                {
                    return null;
                }

                Point2D result = new Point2D(start);
                result.Move(vector);

                return result;
            }

            set
            {
                if (value == null || start == null)
                {
                    return;
                }

                vector = new Vector2D(start, value);
            }
        }

        [JsonIgnore]
        public double Length
        {
            get
            {
                return vector.Length;
            }

            set
            {
                vector = Direction * value;
            }
        }

        [JsonPropertyName("Start")]
        public Point2D Start
        {
            get
            {
                return start?.Clone<Point2D>();
            }

            set
            {
                start = value?.Clone<Point2D>();
            }
        }

        [JsonPropertyName("Vector")]
        public Vector2D Vector
        {
            get
            {
                return vector?.Clone<Vector2D>();
            }

            set
            {
                vector = value?.Clone<Vector2D>();
            }
        }

        public Point2D this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return Start;

                    case 1:
                        return End;

                    default:
                        return null;
                }
            }
        }

        public static implicit operator Segment2D(((double x, double y), (double x, double y)) @object)
        {
            return new Segment2D(new Point2D(@object.Item1.x, @object.Item1.y), new Point2D(@object.Item2.x, @object.Item2.y));
        }

        public static implicit operator Segment2D((Point2D start, Point2D end) @object)
        {
            return new Segment2D(@object.start, @object.end);
        }

        public static bool operator !=(Segment2D segment2D_1, Segment2D segment2D_2)
        {
            if (ReferenceEquals(segment2D_1, null) && ReferenceEquals(segment2D_2, null))
            {
                return false;
            }

            if (ReferenceEquals(segment2D_1, null) || ReferenceEquals(segment2D_2, null))
            {
                return true;
            }

            return (!segment2D_1.start.Equals(segment2D_2.start)) || (!segment2D_1.vector.Equals(segment2D_2.vector));
        }

        public static bool operator ==(Segment2D segment2D_1, Segment2D segment2D_2)
        {
            if (ReferenceEquals(segment2D_1, null) && ReferenceEquals(segment2D_2, null))
            {
                return true;
            }

            if (ReferenceEquals(segment2D_1, null) || ReferenceEquals(segment2D_2, null))
            {
                return false;
            }

            return segment2D_1.start.Equals(segment2D_2.start) && segment2D_1.vector.Equals(segment2D_2.vector);
        }

        public override ISerializableObject Clone()
        {
            return new Segment2D(this);
        }

        public Point2D ClosestPoint(Point2D point2D)
        {
            return Query.ClosestPoint(point2D, start, End, true);
        }

        public bool Collinear(ILinear2D linear2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            return Query.Collinear(this, linear2D, tolerance);
        }

        public double Distance(Point2D point2D)
        {
            if (point2D == null)
            {
                return double.NaN;
            }

            return point2D.Distance(ClosestPoint(point2D));
        }

        public override bool Equals(object obj)
        {
            Segment2D segment2D = obj as Segment2D;
            if (segment2D == null)
            {
                return false;
            }

            return segment2D.start.Equals(start) && segment2D.vector.Equals(vector);
        }

        public BoundingBox2D GetBoundingBox()
        {
            if (start == null || vector == null)
            {
                return null;
            }

            return new BoundingBox2D(start, End);
        }

        public List<Point2D> GetPoints()
        {
            return new List<Point2D>() { Start, End };
        }

        public List<Segment2D> GetSegments()
        {
            return new List<Segment2D> { new Segment2D(this) };
        }

        public Point2D IntersectionPoint(Segment2D segment2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (segment2D == null)
            {
                return null;
            }

            return Query.IntersectionPoint(start, End, segment2D.start, segment2D.End, true, tolerance);
        }

        public void Inverse()
        {
            vector?.Inverse();
        }

        public Point2D Mid()
        {
            if (start == null || vector == null)
            {
                return null;
            }

            return start.Mid(End);
        }

        public override bool Move(Vector2D vector2D)
        {
            if(vector2D == null || start == null)
            {
                return false;
            }

            start.Move(vector2D);
            return true;
        }

        public bool On(Point2D point2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            double distance = Distance(point2D);
            if (double.IsNaN(distance))
            {
                return false;
            }

            return distance < tolerance;
        }

        public Point2D Project(Point2D point2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point2D == null)
            {
                return null;
            }

            Point2D end = End;

            if (start.X == end.X)
            {
                return new Point2D(start.X, point2D.Y);
            }

            double m = (end.Y - start.Y) / (end.X - start.X);
            double b = start.Y - (m * start.X);

            double x = (m * point2D.Y + point2D.X - m * b) / (m * m + 1);
            double y = (m * m * point2D.Y + m * point2D.X + b) / (m * m + 1);

            Point2D result = new Point2D(x, y);
            if (On(result, tolerance))
            {
                return result;
            }

            return start.Distance(result) < end.Distance(result) ? Start : end;
        }

        public override bool Transform(ITransform2D transform)
        {
            if (transform == null || start == null || vector == null)
            {
                return false;
            }

            Point2D end = End;  

            start.Transform(transform);
            end.Transform(transform);

            vector = new Vector2D(start, end);
            return true;
        }
    }
}

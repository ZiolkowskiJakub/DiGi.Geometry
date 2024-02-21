﻿using DiGi.Core;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    public class Segment2D : Geometry2D, IMovable2D, IBoundable2D, INegatable2D
    {
        private Point2D start;
        private Vector2D vector;

        public Segment2D(Point2D start, Vector2D vector)
        {
            this.start = start?.Clone<Point2D>();
            this.vector = vector?.Unit;
        }

        public Segment2D(Point2D start, Point2D end)
        {
            if(start != null && end != null)
            {
                this.start = start?.Clone<Point2D>();
                vector = new Vector2D(start, end);
            }
        }

        public Segment2D(Segment2D segment2D)
            :this(segment2D?.start, segment2D?.vector)
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
            return new Line2D(Start, Vector);
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

        public Point2D Mid()
        {
            if(start == null || vector == null)
            {
                return null;
            }

            return start.Mid(End);
        }

        public void Move(Vector2D vector2D)
        {
            start?.Move(vector2D);
        }

        public bool On(Point2D point2D, double tolerance = Constans.Tolerance.Distance)
        {
            double distance = Distance(point2D);
            if(double.IsNaN(distance))
            {
                return false;
            }

            return distance < tolerance;
        }

        public void Negate()
        {
            vector?.Negate();
        }

        public Point2D ClosestPoint(Point2D point2D)
        {
            return Query.ClosestPoint(point2D, start, End, true);
        }

        public double Distance(Point2D point2D)
        {
            if(point2D == null)
            {
                return double.NaN;
            }

            return point2D.Distance(ClosestPoint(point2D));
        }

        public Point2D Intersection(Segment2D segment2D, double tolerance = Constans.Tolerance.Distance)
        {
            if(segment2D == null)
            {
                return null;
            }

            return Query.IntersectionPoint(start, End, segment2D.start, segment2D.End, true, tolerance);
        }
    }
}

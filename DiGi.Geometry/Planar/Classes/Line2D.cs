using DiGi.Core;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using NetTopologySuite.Algorithm;
using System.Numerics;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    public class Line2D : Geometry2D, IMovable2D, INegatable2D, ICurve2D
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


        public static explicit operator Line2D(Segment2D segment2D)
        {
            if (segment2D == null)
            {
                return null;
            }

            return new Line2D(segment2D.Start, segment2D.Vector);
        }

        public static bool operator !=(Line2D line2D_1, Line2D line2D_2)
        {
            if (ReferenceEquals(line2D_1, null) && ReferenceEquals(line2D_2, null))
            {
                return false;
            }

            if (ReferenceEquals(line2D_1, null) || ReferenceEquals(line2D_2, null))
            {
                return true;
            }

            return (!line2D_1.origin.Equals(line2D_2.direction)) || (!line2D_1.origin.Equals(line2D_2.direction));
        }

        public static bool operator ==(Line2D segment2D_1, Line2D segment2D_2)
        {
            if (ReferenceEquals(segment2D_1, null) && ReferenceEquals(segment2D_2, null))
            {
                return true;
            }

            if (ReferenceEquals(segment2D_1, null) || ReferenceEquals(segment2D_2, null))
            {
                return false;
            }

            return segment2D_1.origin.Equals(segment2D_2.origin) && segment2D_1.direction.Equals(segment2D_2.direction);
        }

        public override ISerializableObject Clone()
        {
            return new Line2D(Origin, Direction);
        }

        public override bool Equals(object obj)
        {
            Line2D line2D = obj as Line2D;
            if (line2D == null)
            {
                return false;
            }

            return line2D.origin.Equals(origin) && line2D.direction.Equals(direction);
        }

        public Point2D IntersectionPoint(Line2D line2D, double tolerance = Constans.Tolerance.Distance)
        {
            if (line2D == null || origin == null || direction == null)
            {
                return null;
            }

            Point2D point2D_1 = Origin;
            point2D_1.Move(direction);

            Point2D point2D_2 = line2D.Origin;
            point2D_2.Move(line2D.direction);

            return Query.IntersectionPoint(origin, point2D_1, line2D.origin, point2D_2, false, tolerance);
        }

        public bool On(Point2D point2D, double tolerance = Constans.Tolerance.Distance)
        {
            if (origin == null || direction == null || point2D == null)
            {
                return false;
            }

            return Distance(point2D) < tolerance;
        }

        public void Move(Vector2D vector2D)
        {
            origin?.Move(vector2D);
        }

        public void Negate()
        {
            direction?.Negate();
        }

        public Point2D Project(Point2D point2D)
        {
            if (point2D == null)
            {
                return null;
            }

            Point2D end = Origin;
            end.Move(direction);

            if (origin.X == end.X)
            {
                return new Point2D(origin.X, point2D.Y);
            }

            double m = (end.Y - origin.Y) / (end.X - origin.X);
            double b = origin.Y - (m * origin.X);

            double x = (m * point2D.Y + point2D.X - m * b) / (m * m + 1);
            double y = (m * m * point2D.Y + m * point2D.X + b) / (m * m + 1);

            return new Point2D(x, y);
        }

        public Point2D ClosestPoint(Point2D point2D)
        {
            if(origin == null || direction == null)
            {
                return null;
            }

            Point2D end = new Point2D(origin);
            end.Move(direction);

            return Query.ClosestPoint(point2D, origin, end, false);
        }

        public bool Collinear(Line2D line2D, double tolerance = Constans.Tolerance.Distance)
        {
            if (line2D?.Direction == null || direction == null)
            {
                return false;
            }

            return System.Math.Abs(System.Math.Abs(direction * line2D.direction) - 1) <= tolerance;
        }

        public double Distance(Point2D point2D)
        {
            if(point2D == null || origin == null || direction == null)
            {
                return double.NaN;
            }
            
            return Project(point2D).Distance(point2D);
        }
    }
}

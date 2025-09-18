using DiGi.Core;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    public class Line2D : Geometry2D, ILinear2D
    {
        [JsonInclude, JsonPropertyName("Direction")]
        private Vector2D? direction;

        [JsonInclude, JsonPropertyName("Origin")]
        private Point2D? origin;
        
        public Line2D(Point2D? origin, Vector2D? direction)
        {
            this.origin = origin?.Clone<Point2D>();
            this.direction = direction?.Unit;
        }

        public Line2D(Line2D? line2D)
        {
            if(line2D is not null)
            {
                origin = line2D.Origin;
                direction = line2D.Direction;
            }
        }

        [JsonIgnore]
        public Vector2D? Direction
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
        public Point2D? Origin
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


        public static explicit operator Line2D?(Segment2D? segment2D)
        {
            if (segment2D is null)
            {
                return null;
            }

            return new Line2D(segment2D.Start, segment2D.Vector);
        }

        public static bool operator !=(Line2D? line2D_1, Line2D? line2D_2)
        {
            return !(line2D_1 == line2D_2);
        }

        public static bool operator ==(Line2D? line2D_1, Line2D? line2D_2)
        {
            if (line2D_1 is null && line2D_2 is null)
            {
                return true;
            }

            if (line2D_1 is null || line2D_2 is null)
            {
                return false;
            }

            return line2D_1.origin == line2D_2.origin && line2D_1.direction == line2D_2.direction;
        }

        public override ISerializableObject? Clone()
        {
            return new Line2D(this);
        }

        public Point2D? ClosestPoint(Point2D? point2D)
        {
            if (origin is null || direction is null)
            {
                return null;
            }

            return Query.ClosestPoint(point2D, origin, origin + direction, false);
        }

        public bool Collinear(ILinear2D? linear2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            return Query.Collinear(this, linear2D, tolerance);
        }

        public double Distance(Point2D? point2D)
        {
            if (point2D == null || origin == null || direction is null)
            {
                return double.NaN;
            }

            Point2D? point2D_Project = Project(point2D);
            if (point2D_Project is null)
            {
                return double.NaN;
            }

            return point2D_Project.Distance(point2D);
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Line2D line2D)
            {
                return false;
            }

            return line2D.origin == origin && line2D.direction == direction;
        }

        public override int GetHashCode()
        {
            int hashCode = -1652769719;
            hashCode = hashCode * -1521134295 + EqualityComparer<Vector2D?>.Default.GetHashCode(direction);
            hashCode = hashCode * -1521134295 + EqualityComparer<Point2D?>.Default.GetHashCode(origin);
            return hashCode;
        }

        public Point2D? IntersectionPoint(Line2D? line2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (line2D is null || origin == null || direction is null)
            {
                return null;
            }

            Point2D? point2D_1 = Origin;
            point2D_1?.Move(direction);

            Point2D? point2D_2 = line2D.Origin;
            point2D_2?.Move(line2D.direction);

            return Query.IntersectionPoint(origin, point2D_1, line2D.origin, point2D_2, false, tolerance);
        }

        public Point2D? IntersectionPoint(Segment2D? segment2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (segment2D is null || origin is null || direction is null)
            {
                return null;
            }

            Point2D? point2D = Origin;
            point2D?.Move(direction);

            Point2D? result = Query.IntersectionPoint(origin, point2D, segment2D.Start, segment2D.End, false, tolerance);
            if(!segment2D.On(result))
            {
                return null;
            }

            return result;
        }

        public bool Inverse()
        {
            if(direction is null)
            {
                return false;
            }

            return direction.Inverse();
        }

        public override bool Move(Vector2D? vector2D)
        {
            if (vector2D is null || origin is null)
            {
                return false;
            }

            origin.Move(vector2D);
            return true;
        }

        public bool On(Point2D? point2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (origin == null || direction is null || point2D == null)
            {
                return false;
            }

            return Distance(point2D) < tolerance;
        }
        
        public Point2D? Project(Point2D? point2D)
        {
            return ClosestPoint(point2D);
        }
        
        public override bool Transform(ITransform2D? transform)
        {
            if(transform is null || origin is null || direction is null)
            {
                return false;
            }

            Point2D point2D = new (origin);
            point2D.Move(direction);

            origin.Transform(transform);

            point2D.Transform(transform);
            direction = new (origin, point2D);
            direction.Normalize();

            return true;
        }
    }
}

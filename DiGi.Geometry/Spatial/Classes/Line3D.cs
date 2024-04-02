using DiGi.Core;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    public class Line3D : Geometry3D, ILinear3D
    {
        [JsonInclude, JsonPropertyName("Direction")]
        private Vector3D direction;

        [JsonInclude, JsonPropertyName("Origin")]
        private Point3D origin;

        public Line3D(Line3D line3D)
        {
            if(line3D != null)
            {
                origin = DiGi.Core.Query.Clone(line3D.origin);
                direction = DiGi.Core.Query.Clone(line3D.direction);
            }
        }

        public Line3D(Point3D origin, Vector3D direction)
        {
            this.origin = DiGi.Core.Query.Clone(origin);
            this.direction = direction?.Unit;
        }

        public Line3D(Point3D point3D_1, Point3D point3D_2)
        {
            origin = DiGi.Core.Query.Clone(point3D_1);
            direction = new Vector3D(point3D_1, point3D_2).Unit;
        }

        public Line3D(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        [JsonIgnore]
        public Vector3D Direction
        {
            get
            {
                return direction?.Clone<Vector3D>();
            }

            set
            {
                direction = value?.Clone<Vector3D>();
            }
        }

        [JsonIgnore]
        public Point3D Origin
        {
            get
            {
                return origin?.Clone<Point3D>();
            }

            set
            {
                origin = value?.Clone<Point3D>();
            }
        }

        public static bool operator !=(Line3D line3D_1, Line3D line3D_2)
        {
            if (ReferenceEquals(line3D_1, null) && ReferenceEquals(line3D_2, null))
            {
                return false;
            }

            if (ReferenceEquals(line3D_1, null) || ReferenceEquals(line3D_2, null))
            {
                return true;
            }

            return (!line3D_1.origin.Equals(line3D_2.direction)) || (!line3D_1.origin.Equals(line3D_2.direction));
        }

        public static bool operator ==(Line3D line3D_1, Line3D line3D_2)
        {
            if (ReferenceEquals(line3D_1, null) && ReferenceEquals(line3D_2, null))
            {
                return true;
            }

            if (ReferenceEquals(line3D_1, null) || ReferenceEquals(line3D_2, null))
            {
                return false;
            }

            return line3D_1.origin.Equals(line3D_2.origin) && line3D_1.direction.Equals(line3D_2.direction);
        }

        public override ISerializableObject Clone()
        {
            return new Line3D(this);
        }

        public override bool Equals(object obj)
        {
            Line3D line3D = obj as Line3D;
            if (line3D == null)
            {
                return false;
            }

            return line3D.origin.Equals(origin) && line3D.direction.Equals(direction);
        }

        public Point3D IntersectionPoint(Line3D line3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (line3D == null)
                return null;

            return Query.IntersectionPoint(origin, direction, line3D.origin, line3D.direction, tolerance);
        }

        public Point3D IntersectionPoint(Segment3D segment3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (segment3D == null || origin == null || direction == null)
            {
                return null;
            }

            Point3D result = Query.IntersectionPoint(origin, direction, segment3D.Start, segment3D.Vector, tolerance);
            if (!segment3D.On(result))
            {
                return null;
            }

            return result;
        }

        public override bool Move(Vector3D vector3D)
        {
            if (vector3D == null || origin == null)
            {
                return false;
            }

            origin.Move(vector3D);
            return true;
        }

        public Point3D ClosestPoint(Point3D point3D)
        {
            return Project(point3D);
        }

        public double Distance(Point3D point3D)
        {
            if(point3D == null)
            {
                return double.NaN;
            }

            Point3D point3D_Project = Project(point3D);
            if(point3D_Project == null)
            {
                return double.NaN;
            }


            return point3D_Project.Distance(point3D);
        }

        public bool Collinear(ILinear3D linear3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            throw new System.NotImplementedException();
        }

        public bool On(Point3D point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point3D == null)
            {
                return false;
            }

            Point3D point3D_Project = Project(point3D);
            if (point3D_Project == null)
            {
                return false;
            }


            return point3D_Project.Distance(point3D) < tolerance;
        }

        public void Inverse()
        {
            direction?.Inverse();
        }

        public Point3D Project(Point3D point3D)
        {
            if(point3D == null || direction == null || origin == null)
            {
                return null;
            }

            double t = new Vector3D(origin, point3D).DotProduct(direction);
            if(double.IsNaN(t) || t == 0)
            {
                return null;
            }

            return origin.GetMoved(direction * t);
        }

        public bool Transform(ITransform3D transform)
        {
            if (transform == null || origin == null || direction == null)
            {
                return false;
            }

            Point3D point2D = new Point3D(origin);
            point2D.Move(direction);

            origin.Transform(transform);

            point2D.Transform(transform);
            direction = new Vector3D(origin, point2D);
            direction.Normalize();

            return true;
        }
    }
}

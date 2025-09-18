using DiGi.Core;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Spatial.Classes
{
    public class Ray3D : Geometry3D, ILinear3D, IInvertible3D
    {
        [JsonInclude, JsonPropertyName("Direction")]
        private Vector3D? direction;

        [JsonInclude, JsonPropertyName("Origin")]
        private Point3D? origin;

        public Ray3D(Ray3D? ray3D)
        {
            if(ray3D is not null)
            {
                origin = DiGi.Core.Query.Clone(ray3D.origin);
                direction = DiGi.Core.Query.Clone(ray3D.direction);
            }
        }

        public Ray3D(Point3D? origin, Vector3D? direction)
        {
            this.origin = DiGi.Core.Query.Clone(origin);
            this.direction = direction?.Unit;
        }

        public Ray3D(Point3D? point3D_1, Point3D? point3D_2)
        {
            origin = DiGi.Core.Query.Clone(point3D_1);
            direction = new Vector3D(point3D_1, point3D_2).Unit;
        }

        public Ray3D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        [JsonIgnore]
        public Vector3D? Direction
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
        public Point3D? Origin
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

        public static bool operator !=(Ray3D? ray3D_1, Ray3D? ray3D_2)
        {
            return !(ray3D_1 == ray3D_2);
        }

        public static bool operator ==(Ray3D? ray3D_1, Ray3D? ray3D_2)
        {
            if (ray3D_1 is null && ray3D_2 is null)
            {
                return true;
            }

            if (ray3D_1 is null || ray3D_2 is null)
            {
                return false;
            }

            return ray3D_1.origin == ray3D_2.origin && ray3D_1.direction == ray3D_2.direction;
        }

        public override ISerializableObject? Clone()
        {
            return new Ray3D(this);
        }

        public Point3D? ClosestPoint(Point3D? point3D)
        {
            if(origin is null || direction is null)
            {
                return null;
            }

            return Query.ClosestPoint(point3D, origin, origin.GetMoved(direction), true, false);
        }

        public bool Collinear(ILinear3D? linear3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(direction is null || linear3D?.Direction is not Vector3D direction_Temp)
            {
                return false;
            }

            return direction.Collinear(direction_Temp, tolerance);
        }

        public double Distance(Point3D? point3D)
        {
            if (point3D == null)
            {
                return double.NaN;
            }

            Point3D? point3D_Project = Project(point3D);
            if (point3D_Project == null)
            {
                return double.NaN;
            }


            return point3D_Project.Distance(point3D);
        }

        public override bool Equals(object obj)
        {
            if (obj is not Ray3D ray3D)
            {
                return false;
            }

            return ray3D.origin == origin && ray3D.direction == direction;
        }

        public override int GetHashCode()
        {
            int hashCode = -1652769719;
            hashCode = hashCode * -1521134295 + EqualityComparer<Vector3D?>.Default.GetHashCode(direction);
            hashCode = hashCode * -1521134295 + EqualityComparer<Point3D?>.Default.GetHashCode(origin);
            return hashCode;
        }

        public Point3D? IntersectionPoint(Ray3D? line3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (line3D == null)
            {
                return null;
            }

            return Query.IntersectionPoint(origin, direction, line3D.origin, line3D.direction, false, tolerance);
        }

        public Point3D? IntersectionPoint(Segment3D? segment3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (segment3D == null || origin == null || direction == null)
            {
                return null;
            }

            Point3D? result = Query.IntersectionPoint(origin, direction, segment3D.Start, segment3D.Vector, false, tolerance);
            if (!segment3D.On(result))
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

        public override bool Move(Vector3D? vector3D)
        {
            if (vector3D == null || origin == null)
            {
                return false;
            }

            origin.Move(vector3D);
            return true;
        }
        
        public bool On(Point3D? point3D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point3D == null)
            {
                return false;
            }

            Point3D? point3D_Project = Project(point3D);
            if (point3D_Project == null)
            {
                return false;
            }


            return point3D_Project.Distance(point3D) < tolerance;
        }
        
        public Point3D? Project(Point3D? point3D)
        {
            if (origin is null || direction is null)
            {
                return null;
            }

            return Query.ClosestPoint(point3D, origin, origin.GetMoved(direction), false);
        }

        public bool Transform(ITransform3D? transform)
        {
            if (transform == null || origin == null || direction == null)
            {
                return false;
            }

            Point3D point2D = new (origin);
            point2D.Move(direction);

            origin.Transform(transform);

            point2D.Transform(transform);
            direction = new (origin, point2D);
            direction.Normalize();

            return true;
        }
    }
}

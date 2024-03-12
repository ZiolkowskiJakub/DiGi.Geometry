using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    public class Circle2D : Geometry2D, IClosedCurve2D, IBoundable2D
    {
        private Point2D center;
        private double radius;

        public Circle2D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Circle2D(Point2D center, double radius)
        {
            this.center = center;
            this.radius = radius;
        }

        public Circle2D()
        {

        }

        public Circle2D(Circle2D circle2D)
        {
            center = new Point2D(circle2D.center);
            radius = circle2D.radius;
        }

        public Point2D Center
        {
            get
            {
                return new Point2D(center);
            }
            set
            {
                center = value;
            }
        }

        [JsonIgnore]
        public double Diameter
        {
            get
            {
                return radius * 2;
            }
            set
            {
                radius = value / 2;
            }
        }

        [JsonIgnore]
        public double Length
        {
            get
            {
                return 2 * System.Math.PI * radius;
            }
        }

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }
        
        public double GetArea()
        {
            return System.Math.PI * radius * radius;
        }

        public BoundingBox2D GetBoundingBox()
        {
            return new BoundingBox2D(new Point2D(center[0] - radius, center[1] - radius), new Point2D(center[0] + radius, center[1] + radius));
        }

        public bool InRange(Point2D point2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if(point2D == null || center == null || double.IsNaN(radius))
            {
                return false;
            }

            return center.Distance(point2D) < radius + tolerance;
        }

        public bool Inside(Point2D point2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point2D == null || center == null || double.IsNaN(radius))
            {
                return false;
            }

            return center.Distance(point2D) < radius - tolerance;
        }

        public override bool Move(Vector2D vector2D)
        {
            if (vector2D == null || center == null)
            {
                return false;
            }

            center.Move(vector2D);
            return true;
        }

        public bool On(Point2D point2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (point2D == null || center == null || double.IsNaN(radius))
            {
                return false;
            }

            return System.Math.Abs(center.Distance(point2D) - radius) <= tolerance;
        }
        
        public override bool Transform(ITransform2D transform)
        {
            if(transform == null || center == null || double.IsNaN(radius))
            {
                return false;
            }

            Point2D point2D = new Point2D(center);
            point2D.Move(new Vector2D(1, 1) * radius);

            center.Transform(transform);

            point2D.Transform(transform);

            radius = new Vector2D(center, point2D).Length;

            return true;
        }

        public override ISerializableObject Clone()
        {
            return new Circle2D(this);
        }
    }
}

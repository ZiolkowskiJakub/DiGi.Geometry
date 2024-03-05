using DiGi.Core;
using DiGi.Geometry.Planar.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    public class Circle2D : Geometry2D, IClosedCurve2D, IBoundable2D, IMovable2D
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

        public bool InRange(Point2D point2D, double tolerance = Constans.Tolerance.Distance)
        {
            if(point2D == null || center == null || double.IsNaN(radius))
            {
                return false;
            }

            return center.Distance(point2D) < radius + tolerance;
        }

        public bool Inside(Point2D point2D, double tolerance = Constans.Tolerance.Distance)
        {
            if (point2D == null || center == null || double.IsNaN(radius))
            {
                return false;
            }

            return center.Distance(point2D) < radius - tolerance;
        }

        public bool On(Point2D point2D, double tolerance = Constans.Tolerance.Distance)
        {
            if (point2D == null || center == null || double.IsNaN(radius))
            {
                return false;
            }

            return System.Math.Abs(center.Distance(point2D) - radius) <= tolerance;
        }

        public double GetArea()
        {
            return System.Math.PI * radius * radius;
        }

        public void Move(Vector2D vector2D)
        {
            center?.Move(vector2D);
        }

        public BoundingBox2D GetBoundingBox()
        {
            return new BoundingBox2D(new Point2D(center[0] - radius, center[1] - radius), new Point2D(center[0] + radius, center[1] + radius));
        }
    }
}

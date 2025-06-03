using DiGi.Core;
using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    public class Ellipse2D : Geometry2D, IEllipse2D, IBoundable2D
    {
        [JsonInclude, JsonPropertyName("A")]
        private double a;

        [JsonInclude, JsonPropertyName("B")]
        private double b;

        [JsonInclude, JsonPropertyName("Center")]
        private Point2D center;

        [JsonInclude, JsonPropertyName("DirectionA")]
        private Vector2D directionA;
        
        public Ellipse2D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Ellipse2D(Point2D center, double a, double b)
        {
            this.center = DiGi.Core.Query.Clone(center);
            this.a = a;
            this.b = b;
            directionA = Constans.Vector2D.WorldX;
        }

        public Ellipse2D(Ellipse2D ellipse2D)
        {
            if(ellipse2D != null)
            {
                center = ellipse2D.Center;
                a = ellipse2D.a;
                b = ellipse2D.b;
                directionA = ellipse2D.DirectionA;
            }
        }

        public Ellipse2D(Point2D center, double a, double b, Vector2D directionA)
        {
            this.center = DiGi.Core.Query.Clone(center);
            this.a = a;
            this.b = b;
            this.directionA = DiGi.Core.Query.Clone(directionA).Unit;
        }

        [JsonIgnore]
        public double A
        {
            get
            {
                return a;
            }

            set
            {
                a = value;
            }
        }

        [JsonIgnore]
        public double B
        {
            get
            {
                return b;
            }

            set
            {
                b = value;
            }
        }

        [JsonIgnore]
        public double C
        {
            get
            {
                return System.Math.Sqrt((a * a) - (b * b));
            }
        }

        [JsonIgnore]
        public Point2D Center
        {
            get
            {
                return center?.Clone<Point2D>();
            }

            set
            {
                center = value?.Clone<Point2D>();
            }
        }
        
        [JsonIgnore]
        public Vector2D DirectionA
        {
            get
            {
                return directionA?.Clone<Vector2D>();
            }

            set
            {
                directionA = value?.Clone<Vector2D>();
            }
        }

        [JsonIgnore]
        public Vector2D DirectionB
        {
            get
            {
                return directionA?.GetPerpendicular().Clone<Vector2D>();
            }
        }

        public static explicit operator Ellipse2D(Circle2D circle2D)
        {
            if (circle2D == null)
            {
                return null;
            }

            return new Ellipse2D(circle2D.Center, circle2D.Radius, circle2D.Radius);
        }

        public static bool operator !=(Ellipse2D ellipse2D_1, Ellipse2D ellipse2D_2)
        {
            if (ReferenceEquals(ellipse2D_1, null) && ReferenceEquals(ellipse2D_2, null))
            {
                return false;
            }

            if (ReferenceEquals(ellipse2D_1, null) || ReferenceEquals(ellipse2D_2, null))
            {
                return true;
            }

            return (!ellipse2D_1.center.Equals(ellipse2D_2.center)) || (!ellipse2D_1.directionA.Equals(ellipse2D_2.directionA) || ellipse2D_1.a != ellipse2D_2.a || ellipse2D_1.b != ellipse2D_2.b);
        }

        public static bool operator ==(Ellipse2D ellipse2D_1, Ellipse2D ellipse2D_2)
        {
            if (ReferenceEquals(ellipse2D_1, null) && ReferenceEquals(ellipse2D_2, null))
            {
                return true;
            }

            if (ReferenceEquals(ellipse2D_1, null) || ReferenceEquals(ellipse2D_2, null))
            {
                return false;
            }

            return (ellipse2D_1.center.Equals(ellipse2D_2.center)) && (ellipse2D_1.directionA.Equals(ellipse2D_2.directionA) && ellipse2D_1.a == ellipse2D_2.a && ellipse2D_1.b == ellipse2D_2.b);
        }

        public override ISerializableObject Clone()
        {
            return new Ellipse2D(this);
        }

        public double Distance(Point2D point2D)
        {
            Point2D point2D_Project = Project(point2D);
            if (point2D_Project == null)
            {
                return double.NaN;
            }

            return point2D.Distance(point2D_Project);
        }

        public override bool Equals(object obj)
        {
            Ellipse2D ellipse2D = obj as Ellipse2D;
            if (ellipse2D == null)
            {
                return false;
            }

            return center == ellipse2D.center && directionA == ellipse2D.directionA && a == ellipse2D.a && b == ellipse2D.b;
        }

        public double GetArea()
        {
            return System.Math.PI * a * b;
        }

        public BoundingBox2D GetBoundingBox()
        {
            // Unit vectors of major and minor axes
            double ux = DirectionA.X;
            double uy = DirectionA.Y;
            double vx = -uy;
            double vy = ux;

            // Projections of semi-axes onto X and Y axes
            double dx = System.Math.Sqrt(System.Math.Pow(A * ux, 2) + System.Math.Pow(B * vx, 2));
            double dy = System.Math.Sqrt(System.Math.Pow(A * uy, 2) + System.Math.Pow(B * vy, 2));

            // Bounding box
            double minX = Center.X - dx;
            double maxX = Center.X + dx;
            double minY = Center.Y - dy;
            double maxY = Center.Y + dy;

            return new BoundingBox2D(new Point2D(minX, minY), new Point2D(maxX, maxY));
        }

        public double GetFocalLength()
        {
            double c = C;
            if(double.IsNaN(c))
            {
                return double.NaN;
            }

            return c * c;
        }

        public Point2D[] GetFocalPoints()
        {
            if(directionA == null || double.IsNaN(a) || double.IsNaN(b))
            {
                return null;
            }

            Vector2D vector2D = (a > b ? directionA : DirectionB ) * C;

            return new Point2D[] { center.GetMoved(vector2D), center.GetMoved(vector2D.GetInversed()) };
        }
        
        public Point2D GetInternalPoint(double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            if (center == null)
            {
                return null;
            }

            return new Point2D(center);
        }

        public double GetPerimeter()
        {
            double h = System.Math.Pow(a - b, 2) / System.Math.Pow(a + b, 2);
            return System.Math.PI * (a + b) * (1 + (3 * h) / (10 + System.Math.Sqrt(4 - 3 * h)));
        }

        public Point2D GetPoint(Vector2D vector2D)
        {
            if(vector2D == null || directionA == null || center == null)
            {
                return null;
            }

            // Normalize input direction vector
            double len = System.Math.Sqrt(vector2D.X * vector2D.X + vector2D.Y * vector2D.Y);
            if (len == 0)
            {
                return null;
            }

            double dx = vector2D.X / len;
            double dy = vector2D.Y / len;

            // Rotate direction into ellipse-aligned coordinates
            double ux = directionA.X;
            double uy = directionA.Y;
            double vx = -uy;
            double vy = ux;

            double dxRot = dx * ux + dy * uy; // component along major axis
            double dyRot = dx * vx + dy * vy; // component along minor axis

            // Scale to match ellipse shape (a, b)
            double scale = 1 / System.Math.Sqrt((dxRot * dxRot) / (a * a) + (dyRot * dyRot) / (b * b));
            double xr = dxRot * scale;
            double yr = dyRot * scale;

            // Rotate back to global coordinates
            double xGlobal = xr * ux + yr * vx + center.X;
            double yGlobal = xr * uy + yr * vy + center.Y;

            return new Point2D(xGlobal, yGlobal);
        }
        
        public bool InRange(Point2D point2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            double dx = point2D.X - Center.X;
            double dy = point2D.Y - Center.Y;

            // Create perpendicular vector (minor axis direction)
            double majorX = DirectionA.X;
            double majorY = DirectionA.Y;
            double minorX = -majorY;
            double minorY = majorX;

            // Project point onto major/minor axes
            double xr = dx * majorX + dy * majorY; // projection onto major axis
            double yr = dx * minorX + dy * minorY; // projection onto minor axis

            return (xr / a) * (xr / a) + (yr / b) * (yr / b) <= 1.0 + tolerance;
        }

        public bool Inside(Point2D point2D, double tolerance = DiGi.Core.Constans.Tolerance.Distance)
        {
            return InRange(point2D, -tolerance);
        }
        
        public void Inverse()
        {
            directionA?.Inverse();
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
            double dx = point2D.X - Center.X;
            double dy = point2D.Y - Center.Y;

            // Major axis direction (u) and minor axis direction (v)
            double ux = DirectionA.X;
            double uy = DirectionA.Y;
            double vx = -uy;
            double vy = ux;

            // Project point into rotated coordinate system
            double xr = dx * ux + dy * uy; // component along major axis
            double yr = dx * vx + dy * vy; // component along minor axis

            // Evaluate normalized ellipse equation
            double value = (xr / a) * (xr / a) + (yr / b) * (yr / b);

            return System.Math.Abs(value - 1.0) <= tolerance;
        }

        public Point2D Project(Point2D point2D)
        {
            if(point2D == null || center == null)
            {
                return null;
            }

            Vector2D vector2D = (center, point2D);

            vector2D.Scale(System.Math.Max(a, b) * 2);

            return Query.IntersectionPoints(this, new Segment2D(center, vector2D), 0)?.FirstOrDefault();
        }

        public Point2D Project(Point2D point2D, double tolerance)
        {
            if(point2D == null)
            {
                return null;
            }

            // Translate point to ellipse-centered coordinates
            double px = point2D.X - center.X;
            double py = point2D.Y - center.Y;

            // Build orthonormal basis: major (u) and minor (v) axes
            double ux = directionA.X;
            double uy = directionA.Y;
            double vx = -uy;
            double vy = ux;

            // Rotate point into ellipse-aligned space
            double xr = px * ux + py * uy; // coordinate in major axis direction
            double yr = px * vx + py * vy; // coordinate in minor axis direction

            // Newton-Raphson to find projection on ellipse
            double tx = xr;
            double ty = yr;

            double deltaTx = double.MaxValue;
            double deltaTy = double.MaxValue;

            while(System.Math.Min(deltaTx, deltaTy) > tolerance)
            {
                double ex = a * tx / System.Math.Sqrt(tx * tx + (b * b / (a * a)) * ty * ty);
                double ey = b * ty / System.Math.Sqrt((a * a / (b * b)) * tx * tx + ty * ty);

                double norm = System.Math.Sqrt(ex * ex + ey * ey);
                if (DiGi.Core.Query.AlmostEquals(norm, 0, tolerance))
                {
                    break;
                }

                double x = xr * ex / norm;
                double y = yr * ey / norm;

                deltaTx = System.Math.Abs(tx - x);
                deltaTy = System.Math.Abs(ty - y);

                tx = x;
                ty = y;
            }

            // Scale ellipse to get unit circle projection
            double normProj = System.Math.Sqrt((xr * xr) / (a * a) + (yr * yr) / (b * b));
            double prx = xr / normProj;
            double pry = yr / normProj;

            // Map back to global coordinates
            double gx = prx * ux + pry * vx + Center.X;
            double gy = prx * uy + pry * vy + Center.Y;

            return new Point2D(gx, gy);
        }
        
        public override bool Transform(ITransform2D transform)
        {
            if(transform == null || center == null || directionA == null)
            {
                return false;
            }

            Point2D point2D = new Point2D(center);
            point2D.Move(directionA);

            center.Transform(transform);

            point2D.Transform(transform);
            directionA = new Vector2D(center, point2D);
            directionA.Normalize();

            return true;
        }
    }
}

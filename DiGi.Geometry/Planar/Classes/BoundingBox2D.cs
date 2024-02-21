using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Geometry.Planar.Classes
{
    public class BoundingBox2D : Geometry2D, IMovable2D, IClosed2D, ISegmentable2D
    {
        private Point2D max;
        private Point2D min;

        public BoundingBox2D(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public BoundingBox2D(IEnumerable<Point2D> point2Ds)
        {
            min = Query.Min(point2Ds, out max);
        }

        public BoundingBox2D(Point2D point2D_1, Point2D point2D_2)
        {
            min = Query.Min(new Point2D[] { point2D_1, point2D_2 }, out max);
        }

        public BoundingBox2D(BoundingBox2D boundingBox2D)
        {
            if(boundingBox2D != null)
            {
                min = new Point2D(boundingBox2D.min);
                max = new Point2D(boundingBox2D.max);
            }

        }

        public BoundingBox2D(double x, double y, double width, double height)
            : this(new Point2D(x, y), new Point2D(x + width, y + height))
        {

        }

        [JsonIgnore]
        public double Height
        {
            get
            {
                if (max == null || min == null)
                {
                    return double.NaN;
                }

                return max.Y - min.Y;
            }
        }

        public Point2D Max
        {
            get
            {
                return new Point2D(max);
            }
            set
            {
                if (min == null)
                {
                    max = new Point2D(value);
                    min = new Point2D(value);
                }
                else
                {
                    max = Query.Max(min, value);
                    min = Query.Min(min, value);
                }
            }
        }

        public Point2D Min
        {
            get
            {
                return new Point2D(min);
            }
            set
            {
                if (max == null)
                {
                    max = new Point2D(value);
                    min = new Point2D(value);
                }
                else
                {
                    max = Query.Max(max, value);
                    min = Query.Min(max, value);
                }
            }
        }

        [JsonIgnore]
        public double Width
        {
            get
            {
                if (max == null || min == null)
                {
                    return double.NaN;
                }

                return max.X - min.X;
            }
        }

        public bool Add(BoundingBox2D boundingBox2D)
        {
            if (boundingBox2D == null)
                return false;

            max = Query.Max(max, boundingBox2D.Max);
            min = Query.Min(min, boundingBox2D.Min);
            return true;
        }

        public bool Add(Point2D point2D)
        {
            if (point2D == null)
                return false;

            max = Query.Max(max, point2D);
            min = Query.Min(min, point2D);
            return true;
        }

        public override ISerializableObject Clone()
        {
            return new BoundingBox2D(this);
        }

        public Point2D ClosestPoint(Point2D point2D)
        {
            return Query.ClosestPoint(point2D, this);
        }

        public double Distance(Point2D point2D)
        {
            return Query.Distance(point2D, this);
        }

        public double GetArea()
        {
            double width = Width;
            if (double.IsNaN(width))
            {
                return double.NaN;
            }

            double height = Height;
            if (double.IsNaN(height))
            {
                return double.NaN;
            }

            return width * height;
        }

        public Point2D GetCentroid()
        {
            return min?.Mid(max);
        }

        public List<Point2D> GetPoints()
        {
            double height = Height;
            if (double.IsNaN(height))
            {
                return null;
            }

            return new List<Point2D>() { new Point2D(min), new Point2D(min.X, min.Y + height), new Point2D(max), new Point2D(max.X, max.Y - height) };
        }

        public List<Segment2D> GetSegments()
        {
            List<Point2D> points = GetPoints();

            return new List<Segment2D>() { new Segment2D(points[0], points[1]), new Segment2D(points[1], points[2]), new Segment2D(points[2], points[3]), new Segment2D(points[3], points[0]) };
        }

        public void Move(Vector2D vector2D)
        {
            max?.Move(vector2D);
            min?.Move(vector2D);
        }

        public void Offset(double value)
        {
            if(double.IsNaN(value) || min == null || max == null)
            {
                return;
            }

            min = new Point2D(min.X - value, min.Y - value);
            max = new Point2D(max.X + value, max.Y + value);
        }
    }
}
